using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Npgsql;


namespace kursovajaEF.Forms
{
    public partial class Form7 : AdvancedForm
    {
        private NpgsqlConnection conn;
        public DataGridViewRow disciplinesRow;
        public string chosenDis;
        public string formName;
        public Form7(NpgsqlConnection conn)
        {
            this.conn = conn;
            chosenDis = "0";
            formName = "0";
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Discipline d in db.Disciplines.AsNoTracking().ToList())
                disciplines.Rows.Add(
                    d.DisciplineId,
                    d.DisciplineName,
                    d.StudyPeriod,
                    d.HoursOfStudy
                    );
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form8 form = new();
            form.ShowDialog();
            if (form.label4.Text != "0") {
                disciplines.Rows.Add(form.label4.Text, form.dis.Text, form.stdper.Text, form.hours.Text);
                for (int i = 0; i < disciplines.RowCount - 1; i++)
                    disciplines.Rows[i].Selected = false;

                disciplines.Rows[disciplines.RowCount - 1].Selected = true;
                disciplines.CurrentCell = disciplines.Rows[disciplines.RowCount - 1].Cells[disciplines.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (disciplines.SelectedRows.Count == 1)
            {
                Form8 fm = new();
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label5.Text = disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString();
                fm.dis.Text = disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["disCol"].Value.ToString();
                fm.stdper.Text = disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["stdperCol"].Value.ToString();
                fm.hours.Text = disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["hoursCol"].Value.ToString();
                fm.ShowDialog();

                if (fm.label4.Text == "1") {
                    disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["disCol"].Value = fm.dis.Text;
                    disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["stdperCol"].Value = fm.stdper.Text;
                    disciplines.Rows[disciplines.SelectedCells[0].RowIndex].Cells["hoursCol"].Value = fm.hours.Text;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int[] selrow = new int[disciplines.SelectedCells.Count];
            int index = -1, count = 0;

            for (int i = 0; i < disciplines.SelectedCells.Count; i++)
                selrow[i] = disciplines.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    if (selrow[i] == selrow[j])
                        selrow[j] = -1;

            for (int i = 0; i < disciplines.SelectedCells.Count; i++)
                if (selrow[i] != -1)
                {
                    index = i;
                    count++;
                }

            if (count == 1)
            {
                using(testDBContext db = new())
                {
                    Discipline d = db.Disciplines.Find(int.Parse(disciplines.
                        Rows[selrow[index]].Cells[disciplines.Columns["idCol"].Index].Value.ToString()));
                    db.Remove(d);
                    db.SaveChanges();
                }
                disciplines.Rows.RemoveAt(selrow[index]);
            }
            else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Преподаватели") {
                teachers.Visible = true;
                timetable.Visible = false;
            }
            else
            {
                timetable.Visible = true;
                teachers.Visible = false;
            }
        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (disciplines.SelectedRows.Count == 1)
            {
                DataGridView dgv;
                string idCol;
                string table;

                if (teachers.Visible == true)
                {
                    dgv = teachers;
                    idCol = dgv.Columns[9].Name;
                }
                else
                {
                    dgv = timetable;
                    idCol = dgv.Columns[0].Name;
                }

                table = "disciplines_" + dgv.Name;

                if (dgv.SelectedRows.Count == 1)
                {
                    string sql = $"INSERT INTO {table} VALUES((@idCol), (@dgvIdCol));";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                    {
                        Parameters =
                        {
                            new("idCol", int.Parse(disciplines.
                            Rows[disciplines.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString())),
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
            Form7_1 fm = new Form7_1();
            fm.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
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
                if (teachers.RowCount != 0)
                    teachers.Rows[0].Selected = true;

                fetch(db);
                if (disciplines.RowCount != 0)
                    disciplines.Rows[0].Selected = true;

                foreach (Timetable t in db.Timetables.AsNoTracking().ToList())
                    timetable.Rows.Add(
                        t.TtId,
                        t.StartTime,
                        t.EndTime,
                        t.Weekday
                        );
                if (timetable.RowCount != 0)
                    timetable.Rows[0].Selected = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var l = db.Disciplines.AsNoTracking().Where(w =>
                    EF.Functions.Like(w.DisciplineName, $"%{txt}%") ||
                    EF.Functions.Like(w.StudyPeriod, $"%{txt}%") ||
                    EF.Functions.Like(w.HoursOfStudy.ToString(), $"%{txt}%"));

                    disciplines.Rows.Clear();

                    foreach (var elem in l)
                    {
                        disciplines.Rows.Add(
                            elem.DisciplineId,
                            elem.DisciplineName,
                            elem.StudyPeriod,
                            elem.HoursOfStudy
                            );
                    }
                }
            }
            else
            {
                disciplines.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (disciplines.RowCount != 0)
                    disciplines.Rows[0].Selected = true;
            }
        }

        private void setDiscipline()
        {
            if (disciplines.SelectedCells.Count == 1)
            {
                chosenDis = disciplines.SelectedCells[0].OwningRow.Cells["disCol"].Value.ToString();
                Close();
            }
        }

        private void setDisciplineRow()
        {
            if (disciplines.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = disciplines.SelectedCells[0].OwningRow;
                disciplinesRow = (DataGridViewRow)selectedRow.Clone();
                for (int i = 0; i < selectedRow.Cells.Count; ++i)
                    disciplinesRow.Cells[i].Value = selectedRow.Cells[i].Value;
                Close();
            }
        }

        private void setDisBtn_Click(object sender, EventArgs e)
        {
            if (formName == "Form2")
                setDiscipline();
            else if (formName == "Form10")
                setDisciplineRow();
        }

        private void disciplines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setDisBtn_Click(sender, e);
        }
    }
}
