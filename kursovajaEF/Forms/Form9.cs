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
    public partial class Form9 : AdvancedForm
    {
        private NpgsqlConnection conn;
        public Form9(NpgsqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Teacher t in db.Teachers.AsNoTracking().ToList())
                teachers.Rows.Add(
                    t.Fio,
                    t.Dob,
                    t.Title,
                    t.Position,
                    t.PedagogicalExperience,
                    t.OverallExperience,
                    t.Degree,
                    t.PhoneNum,
                    t.Email,
                    t.TeacherId
                    );
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form10 form = new(conn);
            form.ShowDialog();
            if (form.label10.Text != "0") {
                teachers.Rows.Add(form.fio.Text, form.dob.Value.ToString().Remove(10),
                    form.title.Text, form.position.Text, form.pedEx.Text, form.overEx.Text, form.degree.Text,
                    form.phone_num.Text, form.email.Text, form.label10.Text);
                for (int i = 0; i < teachers.RowCount - 1; i++)
                    teachers.Rows[i].Selected = false;

                teachers.Rows[teachers.RowCount - 1].Selected = true;
                teachers.CurrentCell = teachers.Rows[teachers.RowCount - 1].Cells[teachers.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (teachers.SelectedRows.Count == 1)
            {
                Form10 fm = new(conn);
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label11.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["teacherIdCol"].Value.ToString();
                fm.fio.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["fioCol"].Value.ToString();
                fm.dob.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["dobCol"].Value.ToString();
                fm.title.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["titleCol"].Value.ToString();
                fm.position.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["posCol"].Value.ToString();
                fm.pedEx.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["pedExCol"].Value.ToString();
                fm.overEx.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["overExCol"].Value.ToString();
                fm.degree.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["degreeCol"].Value.ToString();
                fm.phone_num.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["phoneCol"].Value.ToString();
                fm.email.Text = teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["emailCol"].Value.ToString();
                fm.ShowDialog();
                if (fm.label10.Text == "1") {
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["fioCol"].Value = fm.fio.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["dobCol"].Value = fm.dob.Value.ToString().Remove(10);
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["titleCol"].Value = fm.title.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["posCol"].Value = fm.position.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["pedExCol"].Value = fm.pedEx.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["overExCol"].Value = fm.overEx.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["degreeCol"].Value = fm.degree.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["phoneCol"].Value = fm.phone_num.Text;
                    teachers.Rows[teachers.SelectedCells[0].RowIndex].Cells["emailCol"].Value = fm.email.Text;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int[] selrow = new int[teachers.SelectedCells.Count];
            int index = -1, count = 0;

            for (int i = 0; i < teachers.SelectedCells.Count; i++)
                selrow[i] = teachers.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    if(selrow[i] == selrow[j])
                        selrow[j] = -1;

            for (int i = 0; i < teachers.SelectedCells.Count; i++)
                if (selrow[i] != -1)
                {
                    index = i;
                    count++;
                }

            if (count == 1)
            {
                using (testDBContext db = new())
                {
                    Teacher t = db.Teachers.Find(int.Parse(teachers.
                        Rows[selrow[index]].Cells[teachers.Columns["teacherIdCol"].Index].Value.ToString()));
                    db.Remove(t);
                    db.SaveChanges();
                }
                teachers.Rows.RemoveAt(selrow[index]);
            }
            else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var t = db.Teachers.AsNoTracking().Where(w =>
                    EF.Functions.Like(w.Fio, $"%{txt}%") ||
                    EF.Functions.Like(w.Dob, $"%{txt}%") ||
                    EF.Functions.Like(w.Title, $"%{txt}%") ||
                    EF.Functions.Like(w.Position, $"%{txt}%") ||
                    EF.Functions.Like(w.PedagogicalExperience, $"%{txt}%") ||
                    EF.Functions.Like(w.OverallExperience, $"%{txt}%") ||
                    EF.Functions.Like(w.Degree, $"%{txt}%") ||
                    EF.Functions.Like(w.PhoneNum.ToString(), $"%{txt}%") ||
                    EF.Functions.Like(w.Email, $"%{txt}%"));

                    teachers.Rows.Clear();

                    foreach (var elem in t)
                    {
                        teachers.Rows.Add(
                            elem.Fio,
                            elem.Dob,
                            elem.Title,
                            elem.Position,
                            elem.PedagogicalExperience,
                            elem.OverallExperience,
                            elem.Degree,
                            elem.PhoneNum,
                            elem.Email,
                            elem.TeacherId
                            );
                    }
                }
            }
            else
            {
                teachers.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (teachers.RowCount != 0)
                    teachers.Rows[0].Selected = true;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                fetch(db);
                if (teachers.RowCount != 0)
                    teachers.Rows[0].Selected = true;

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

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (teachers.SelectedRows.Count == 1)
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

                table = dgv.Name + "_" + "teachers";

                if (dgv.SelectedRows.Count == 1)
                {
                    string sql = $"INSERT INTO {table} VALUES((@dgvIdCol), (@idCol));";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                    {
                        Parameters =
                        {
                            new("idCol", int.Parse(teachers.
                            Rows[teachers.SelectedCells[0].RowIndex].Cells["teacherIdCol"].Value.ToString())),
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
            Form9_1 fm = new();
            fm.Show();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
