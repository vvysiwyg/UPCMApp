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
    public partial class Form15 : AdvancedForm
    {
        private NpgsqlConnection conn;
        public Form15(NpgsqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Group g in db.Groups.ToList())
            {
                db.Entry(g).Collection(c => c.GroupInfos).Load();

                foreach (GroupInfo gi in g.GroupInfos)
                    groups.Rows.Add(
                        g.GroupNum,
                        g.GroupId,
                        g.DisciplineId,
                        g.NumOfHours,
                        g.DisciplineName,
                        gi.GroupInfoId,
                        gi.Weekday,
                        gi.StartTime,
                        gi.EndTime,
                        gi.StartLearning,
                        gi.EndLearning
                        );
            }

        }

        private void addBtn_Click(object sender, EventArgs e) 
        {
            Form16 form = new();
            form.ShowDialog();
            if (form.label6.Text != "0") {
                groups.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }

                if(groups.RowCount != 0)
                    groups.Rows[0].Selected = true;
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (groups.SelectedRows.Count == 1)
            {
                Form16 fm = new();
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label7.Text = groups.Rows[groups.SelectedCells[0].RowIndex].Cells["groupIdCol"].Value.ToString();
                fm.groupNum.Text = groups.Rows[groups.SelectedCells[0].RowIndex].Cells["groupNumCol"].Value.ToString();
                fm.numOfHours.Text = groups.Rows[groups.SelectedCells[0].RowIndex].Cells["numOfHoursCol"].Value.ToString();

                using(testDBContext db = new())
                {
                    fm.disciplineName.Text = db.Disciplines.Find(int.Parse(groups.
                        Rows[groups.SelectedCells[0].RowIndex].Cells["disciplineIdCol"].Value.ToString())).DisciplineName;

                    var gi = db.GroupInfos.
                        AsNoTracking().
                        Where(w => w.GroupId == int.Parse(fm.label7.Text)).
                        Select(s => new
                        {
                            GroupInfoId = s.GroupInfoId,
                            Weekday = s.Weekday,
                            StartTime = s.StartTime,
                            EndTime = s.EndTime,
                            StartLearning = s.StartLearning,
                            EndLearning = s.EndLearning
                        });

                    foreach (var res in gi.ToList())
                        fm.dataGridView1.Rows.Add(
                            res.GroupInfoId,
                            res.Weekday,
                            res.StartTime,
                            res.EndTime,
                            res.StartLearning,
                            res.EndLearning);
                }

                fm.ShowDialog();
                if (fm.label6.Text == "1") {
                    groups.Rows.Clear();
                    using (testDBContext db = new())
                    {
                        fetch(db);
                    }

                    if(groups.RowCount != 0)
                        groups.Rows[0].Selected = true;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int[] selrow = new int[groups.SelectedCells.Count];
            int index = -1, count = 0;

            for (int i = 0; i < groups.SelectedCells.Count; i++)
                selrow[i] = groups.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    if(selrow[i] == selrow[j])
                        selrow[j] = -1;

            for (int i = 0; i < groups.SelectedCells.Count; i++)
                if (selrow[i] != -1)
                {
                    index = i;
                    count++;
                }

            if (count == 1)
            {
                string groupId = groups.Rows[selrow[index]].Cells[groups.Columns["groupIdCol"].Index].Value.ToString();

                using(testDBContext db = new())
                {
                    Group g = db.Groups.Find(int.Parse(groupId));
                    db.Remove(g);
                    db.SaveChanges();
                    groups.Rows.Clear();
                    fetch(db);
                }
                if (groups.RowCount != 0)
                    groups.Rows[0].Selected = true;
            }
            else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                fetch(db);
                if (groups.RowCount != 0)
                    groups.Rows[0].Selected = true;

                foreach (Listener l in db.Listeners.AsNoTracking().ToList())
                    listeners.Rows.Add(
                        l.Firstname,
                        l.Midname,
                        l.Lastname,
                        l.Yob,
                        l.Sex,
                        l.Id,
                        l.Matriculation,
                        l.ContractId,
                        l.PhoneNum,
                        l.SchoolGrade,
                        l.Email
                        );
                if (listeners.RowCount != 0)
                    listeners.Rows[0].Selected = true;

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
                    var g = db.Groups.Join(
                        db.GroupInfos,
                        oks => oks.GroupId,
                        iks => iks.GroupId,
                        (oks, iks) => new
                        {
                            Groups = oks,
                            GroupInfos = iks
                        }).Where(w =>
                        EF.Functions.Like(w.Groups.GroupNum, $"%{txt}%") ||
                        EF.Functions.Like(w.Groups.NumOfHours.ToString(), $"%{txt}%") ||
                        EF.Functions.Like(w.Groups.DisciplineName, $"%{txt}%") ||
                        EF.Functions.Like(w.GroupInfos.Weekday, $"%{txt}%") ||
                        EF.Functions.Like(w.GroupInfos.StartTime, $"%{txt}%") ||
                        EF.Functions.Like(w.GroupInfos.EndTime, $"%{txt}%") ||
                        EF.Functions.Like(w.GroupInfos.StartLearning, $"%{txt}%") ||
                        EF.Functions.Like(w.GroupInfos.EndLearning, $"%{txt}%"));

                    groups.Rows.Clear();

                    foreach (var elem in g)
                    {
                        groups.Rows.Add(
                            elem.Groups.GroupNum,
                            elem.Groups.GroupId,
                            elem.Groups.DisciplineId,
                            elem.Groups.NumOfHours,
                            elem.Groups.DisciplineName,
                            elem.GroupInfos.GroupInfoId,
                            elem.GroupInfos.Weekday,
                            elem.GroupInfos.StartTime,
                            elem.GroupInfos.EndTime,
                            elem.GroupInfos.StartLearning,
                            elem.GroupInfos.EndLearning
                            );
                    }
                }
            }
            else
            {
                groups.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (groups.RowCount != 0)
                    groups.Rows[0].Selected = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Расписание") {
                timetable.Visible = true;
                teachers.Visible = false;
                listeners.Visible = false;
            }
            else if (comboBox2.Text == "Преподаватели") {
                teachers.Visible = true;
                listeners.Visible = false;
                timetable.Visible = false;
            }
            else
            {
                listeners.Visible = true;
                timetable.Visible = false;
                teachers.Visible = false;
            }
        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (groups.SelectedRows.Count == 1)
            {
                DataGridView dgv;
                string idCol;
                string table;

                if (teachers.Visible == true)
                {
                    dgv = teachers;
                    idCol = dgv.Columns[9].Name;
                }
                else if (listeners.Visible == true)
                {
                    dgv = listeners;
                    idCol = dgv.Columns[5].Name;
                }
                else
                {
                    dgv = timetable;
                    idCol = dgv.Columns[0].Name;
                }

                table = "groups_" + dgv.Name;

                if (dgv.SelectedRows.Count == 1)
                {
                    string sql = $"INSERT INTO {table} VALUES((@idCol), (@dgvIdCol));";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                    {
                        Parameters =
                        {
                            new("idCol", int.Parse(groups.
                            Rows[groups.SelectedCells[0].RowIndex].Cells["groupIdCol"].Value.ToString())),
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
            Form15_1 fm = new();
            fm.Show();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
