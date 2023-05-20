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
        private DataGridViewCell currentCellDiscipline;
        private DataGridViewCell currentCellGI;
        private DataGridViewCellStyle defaultCellStyle;
        public Form9(NpgsqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            defaultCellStyle = teachers.DefaultCellStyle;
            fetch();
        }

        private void fetch()
        {
            using (testDBContext db = new())
            {
                int it = 0;
                var ts = db.Teachers.Include(i => i.Chair).AsNoTracking();
                var ds = db.DisciplinesTeachers.Include(i => i.Discipline).AsNoTracking();
                var gis = db.GroupInfoTeachers.Include(i => i.GroupInfo).ThenInclude(i => i.Group).AsNoTracking();

                foreach (Teacher t in ts.ToList())
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
                        t.Chair == null ? "": t.Chair.ChairName,
                        t.TeacherId,
                        t.ChairId == null ? "": t.ChairId
                        );

                foreach (var d in ds.ToList())
                {
                    disciplines.Rows.Add(
                        d.DisciplineId,
                        d.Discipline.DisciplineName,
                        d.Discipline.StudyPeriod,
                        d.Discipline.HoursOfStudy,
                        d.Number != null ? d.Number: "",
                        d.Date != null ? d.Date: "",
                        d.TeacherId
                        );
                    disciplines.Rows[it].Visible = false;
                    disciplines.Rows[it].Selected = false;
                    it++;
                }
                if (disciplines.Rows.Count != 0)
                    currentCellDiscipline = disciplines.Rows[0].Cells[0];

                foreach (var gi in gis.ToList())
                    group_info.Rows.Add(
                        gi.GroupInfo.Group.GroupNum,
                        gi.GroupInfo.Weekday,
                        gi.GroupInfo.StartTime,
                        gi.GroupInfo.EndTime,
                        gi.GroupInfo.StartLearning,
                        gi.GroupInfo.EndLearning,
                        gi.GroupInfo.GroupId,
                        gi.GroupInfo.Group.DisciplineId,
                        gi.GroupInfo.Group.NumOfHours,
                        gi.GroupInfo.Group.DisciplineName,
                        gi.GroupInfoId,
                        gi.TeacherId
                        );
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form10 form = new(conn);
            form.ShowDialog();
            if (form.label10.Text != "0") {
                teachers.Rows.Add(form.fio.Text, form.dob.Value.ToString().Remove(10),
                    form.title.Text, form.position.Text, form.pedEx.Text, form.overEx.Text, form.degree.Text,
                    form.phone_num.Text, form.email.Text, form.chair.Text, form.label10.Text, form.chairId.Text);
                for (int i = 0; i < teachers.RowCount - 1; i++)
                    teachers.Rows[i].Selected = false;

                teachers.Rows[teachers.RowCount - 1].Selected = true;
                teachers.CurrentCell = teachers.Rows[teachers.RowCount - 1].Cells[teachers.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (teachers.SelectedRows.Count == 1 || teachers.SelectedCells.Count == 1)
            {
                Form10 fm = new(conn);
                DataGridViewRow selectedRow = teachers.SelectedCells[0].OwningRow;
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.addDisBtn.Visible = false;
                fm.addDisBtn2.Visible = true;
                fm.addGIBtn.Visible = false;
                fm.addGIBtn2.Visible = true;
                fm.label11.Text = selectedRow.Cells["teacherIdCol"].Value.ToString();
                fm.chairId.Text = selectedRow.Cells["chairIdCol"].Value.ToString();
                fm.fio.Text = selectedRow.Cells["fioCol"].Value.ToString();
                fm.dob.Text = selectedRow.Cells["dobCol"].Value.ToString();
                fm.title.Text = selectedRow.Cells["titleCol"].Value.ToString();
                fm.position.Text = selectedRow.Cells["posCol"].Value.ToString();
                fm.pedEx.Text = selectedRow.Cells["pedExCol"].Value.ToString();
                fm.overEx.Text = selectedRow.Cells["overExCol"].Value.ToString();
                fm.degree.Text = selectedRow.Cells["degreeCol"].Value.ToString();
                fm.phone_num.Text = selectedRow.Cells["phoneCol"].Value.ToString();
                fm.email.Text = selectedRow.Cells["emailCol"].Value.ToString();
                fm.chair.Text = selectedRow.Cells["chairNameCol"].Value.ToString();

                foreach (DataGridViewRow row in disciplines.Rows)
                    if (row.Cells["teacherIdCol2"].Value.ToString() == selectedRow.Cells["teacherIdCol"].Value.ToString())
                        fm.disciplines.Rows.Add(
                            row.Cells["disciplineIdCol"].Value,
                            row.Cells["disCol"].Value,
                            row.Cells["stdperCol"].Value,
                            row.Cells["hoursCol"].Value);

                foreach (DataGridViewRow row in group_info.Rows)
                    if (row.Cells["teacherIdCol3"].Value.ToString() == selectedRow.Cells["teacherIdCol"].Value.ToString())
                        fm.group_info.Rows.Add(
                            row.Cells["groupNumCol"].Value,
                            row.Cells["groupIdCol"].Value,
                            row.Cells["disciplineIdCol2"].Value,
                            row.Cells["numOfHoursCol"].Value,
                            row.Cells["dataGridViewTextBoxColumn2"].Value,
                            row.Cells["groupInfoIdCol"].Value,
                            row.Cells["weekdayCol"].Value,
                            row.Cells["startTimeCol"].Value,
                            row.Cells["endTimeCol"].Value,
                            row.Cells["startLearningCol"].Value,
                            row.Cells["endLearningCol"].Value);

                fm.ShowDialog();
                if (fm.label10.Text == "1") {
                    resetForm(new List<DataGridView> {
                    teachers,
                    disciplines,
                    group_info}, new List<GroupBox> {
                    extendedInfoGB});

                    fetch();
                    if (teachers.RowCount != 0)
                        teachers.Rows[0].Selected = true;
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
                    EF.Functions.Like(w.Email, $"%{txt}%") ||
                    EF.Functions.Like(w.Chair.ChairName, $"%{txt}%"));

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
                            elem.Chair.ChairName,
                            elem.TeacherId,
                            elem.ChairId
                            );
                    }
                }
            }
            else
            {
                resetForm(new List<DataGridView> {
                    teachers,
                    disciplines,
                    group_info}, new List<GroupBox> {
                    extendedInfoGB});

                fetch();
                if (teachers.RowCount != 0)
                    teachers.Rows[0].Selected = true;
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (teachers.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = teachers.SelectedCells[0].OwningRow;
                bool flag = false;
                SuspendLayout();
                for (int i = 0; i < 10; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[i].Value.ToString();
                }

                for (int i = 10; i < 21; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = string.Empty;
                }

                foreach (DataGridViewRow row in disciplines.Rows)
                {
                    if (row.Cells["teacherIdCol2"].Value.ToString() == selectedRow.Cells["teacherIdCol"].Value.ToString())
                    {
                        row.Visible = true;
                        if (!flag)
                        {
                            flag = true;
                            currentCellDiscipline.Selected = false;
                            currentCellDiscipline = row.Cells[0];
                        }
                    }
                    else
                        row.Visible = false;
                }

                if (dataGridViewVisibleRowCount(disciplines, disciplines.Rows.Count - 1) == 0)
                    foreach (DataGridViewRow row in group_info.Rows)
                        row.DefaultCellStyle = defaultCellStyle;
                else
                {
                    currentCellDiscipline.Selected = true;
                    currentCellGI.Selected = false;
                    disciplines_CellClick(disciplines, e);
                }

                extendedInfoGB.Text = fio.Text;
                extendedInfoGB.Visible = true;
                ResumeLayout();
            }
        }

        private void disciplines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (disciplines.SelectedCells.Count == 1)
            {
                int index = 1;
                bool flag = false;
                DataGridViewRow selectedRow = disciplines.SelectedCells[0].OwningRow;
                currentCellDiscipline = disciplines.SelectedCells[0];

                for (int i = 10; i < 15; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }

                for (int i = 15; i < 21; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = string.Empty;
                }

                foreach (DataGridViewRow row in group_info.Rows)
                {
                    if (row.Cells["disciplineIdCol2"].Value.ToString() == selectedRow.Cells["disciplineIdCol"].Value.ToString())
                    {
                        row.DefaultCellStyle = getSelectedCellStyle();
                        if (!flag)
                        {
                            flag = true;
                            currentCellGI.Selected = false;
                            currentCellGI = row.Cells[0];
                        }
                    }
                    else
                        row.DefaultCellStyle = defaultCellStyle;
                }

                if (dataGridViewSelectedCellStyleCount(group_info, group_info.Rows.Count - 1) != 0)
                {
                    currentCellGI.Selected = true;
                    group_info_CellClick(group_info, e);
                }
            }
        }

        private void group_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (group_info.SelectedCells.Count == 1)
            {
                int index = 0;
                DataGridViewRow selectedRow = group_info.SelectedCells[0].OwningRow;
                currentCellGI = group_info.SelectedCells[0];

                for (int i = 15; i < 21; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in group_info.Rows)
                row.Selected = false;
            if (group_info.Rows.Count != 0)
                currentCellGI = group_info.Rows[0].Cells[0];
        }

        private void addAppointmentTeacherOrderBtn_Click(object sender, EventArgs e)
        {
            if ((teachers.SelectedRows.Count == 1 || teachers.SelectedCells.Count == 1) &&
                (disciplines.SelectedRows.Count == 1 || disciplines.SelectedCells.Count == 1))
            {
                Form9_2 form = new();
                DataGridViewRow selectedRow = teachers.SelectedCells[0].OwningRow;
                DataGridViewRow selectedRow2 = disciplines.SelectedCells[0].OwningRow;
                form.teacher_id.Text = selectedRow.Cells["teacherIdCol"].Value.ToString();
                form.discipline_id.Text = selectedRow2.Cells["disciplineIdCol"].Value.ToString();
                form.teacher.Text = selectedRow.Cells["fioCol"].Value.ToString();
                form.discipline.Text = selectedRow2.Cells["disCol"].Value.ToString();
                form.ShowDialog();
                if (form.teacher_id.Text == "-1")
                {
                    resetForm(new List<DataGridView> {
                    teachers,
                    disciplines,
                    group_info}, new List<GroupBox> {
                    extendedInfoGB});

                    fetch();
                    if (teachers.RowCount != 0)
                        teachers.Rows[0].Selected = true;
                }
            }
        }
    }
}
