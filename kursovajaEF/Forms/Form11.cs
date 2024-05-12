using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovajaEF.Forms
{
    public partial class Form11 : AdvancedForm
    {
        private NpgsqlConnection con;
        public Form11(NpgsqlConnection conn)
        {
            this.con = conn;
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Timetable t in db.Timetables.AsNoTracking().ToList())
                timetable.Rows.Add(
                    t.TtId,
                    t.StartTime,
                    t.EndTime,
                    t.Weekday
                    );
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                fetch(db);
                if (timetable.RowCount != 0)
                    timetable.Rows[0].Selected = true;

                foreach (Discipline d in db.Disciplines.AsNoTracking().ToList())
                    disciplines.Rows.Add(
                        d.DisciplineId,
                        d.DisciplineName,
                        d.StudyPeriod,
                        d.HoursOfStudy
                        );
                if (disciplines.RowCount != 0)
                    disciplines.Rows[0].Selected = true;

                foreach (Group g in db.Groups.AsNoTracking().ToList())
                    groups.Rows.Add(
                        g.GroupNum,
                        g.GroupId
                        );
                if (groups.RowCount != 0)
                    groups.Rows[0].Selected = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form12 form = new();
            form.ShowDialog();
            if (form.label4.Text != "0") {
                timetable.Rows.Add(form.label4.Text, form.start.Text, form.end.Text, form.weekday.Text);
                for (int i = 0; i < timetable.RowCount - 1; i++)
                    timetable.Rows[i].Selected = false;

                timetable.Rows[timetable.RowCount - 1].Selected = true;
                timetable.CurrentCell = timetable.Rows[timetable.RowCount - 1].Cells[timetable.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (timetable.SelectedRows.Count == 1)
            {
                Form12 fm = new();
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label5.Text = timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString();
                fm.start.Text = timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["startCol"].Value.ToString();
                fm.end.Text = timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["endCol"].Value.ToString();
                fm.weekday.Text = timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["weekdayCol"].Value.ToString();
                fm.ShowDialog();
                if (fm.label4.Text == "1") {
                    timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["startCol"].Value = fm.start.Text;
                    timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["endCol"].Value = fm.end.Text;
                    timetable.Rows[timetable.SelectedCells[0].RowIndex].Cells["weekdayCol"].Value = fm.weekday.Text;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int[] selrow = new int[timetable.SelectedCells.Count];
            int index = -1, count = 0;

            for (int i = 0; i < timetable.SelectedCells.Count; i++)
                selrow[i] = timetable.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    if(selrow[i] == selrow[j])
                        selrow[j] = -1;

            for (int i = 0; i < timetable.SelectedCells.Count; i++)
                if (selrow[i] != -1)
                {
                    index = i;
                    count++;
                }

            if (count == 1)
            {
                using (testDBContext db = new())
                {
                    Timetable t = db.Timetables.Find(int.Parse(timetable.
                        Rows[selrow[index]].Cells[timetable.Columns["idCol"].Index].Value.ToString()));
                    db.Remove(t);
                    db.SaveChanges();
                }
                timetable.Rows.RemoveAt(selrow[index]);
            }
            else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (timetable.SelectedRows.Count == 1)
            {
                DataGridView dgv;
                string idCol;
                string table;

                if (groups.Visible == true)
                {
                    dgv = groups;
                    idCol = dgv.Columns[1].Name;
                }
                else
                {
                    dgv = disciplines;
                    idCol = dgv.Columns[0].Name;
                }

                table = dgv.Name + "_" + "timetable";

                if (dgv.SelectedRows.Count == 1)
                {
                    string sql = $"INSERT INTO {table} VALUES((@dgvIdCol), (@idCol));";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con)
                    {
                        Parameters =
                        {
                            new("idCol", int.Parse(timetable.
                            Rows[timetable.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString())),
                            new("dgvIdCol", int.Parse(dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[idCol].Value.ToString()))
                        }
                    };
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные связаны", Text.ToString());
                }
                else MessageBox.Show("Для создания соотношения между двумя таблицами должно быть выделено ровно по одной строке в каждой из таблиц.", "Ошибка");
            }
            else MessageBox.Show("Для создания соотношения между двумя таблицами должно быть выделено ровно по одной строке в каждой из таблиц.", "Ошибка");
        }

        private void showLinkBtn_Click(object sender, EventArgs e)
        {
            Form11_1 fm = new();
            fm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Группы") {
                groups.Visible = true;
                disciplines.Visible = false;
            }
            else
            {
                disciplines.Visible = true;
                groups.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var t = db.Timetables.AsNoTracking().Where(w =>
                    EF.Functions.Like(w.StartTime, $"%{txt}%") ||
                    EF.Functions.Like(w.EndTime, $"%{txt}%") ||
                    EF.Functions.Like(w.Weekday, $"%{txt}%"));

                    timetable.Rows.Clear();

                    foreach (var elem in t)
                    {
                        timetable.Rows.Add(
                            elem.TtId,
                            elem.StartTime,
                            elem.EndTime,
                            elem.Weekday
                            );
                    }
                }
            }
            else
            {
                timetable.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (timetable.RowCount != 0)
                    timetable.Rows[0].Selected = true;
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
