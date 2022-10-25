using Microsoft.EntityFrameworkCore;
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
    public partial class Form16 : AdvancedForm
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            using(testDBContext db = new())
            {
                foreach (string disName in db.Disciplines.Select(s => s.DisciplineName).Distinct())
                    disciplineName.Items.Add(disName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int disId;
                int gId;
                using (testDBContext db = new())
                {
                    disId = db.Disciplines.
                        AsNoTracking().
                        Where(w => w.DisciplineName == disciplineName.Text).
                        Select(s => s.DisciplineId).
                        FirstOrDefault();

                    Group g = new()
                    {
                        GroupNum = groupNum.Text,
                        DisciplineId = disId,
                        NumOfHours = int.Parse(numOfHours.Text),
                        DisciplineName = disciplineName.Text
                    };

                    db.Groups.Add(g);
                    db.SaveChanges();

                    gId = (from gr in db.Groups
                           orderby gr.GroupId descending
                           select gr.GroupId).FirstOrDefault();

                    label6.Text = gId.ToString();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        GroupInfo gi = new()
                        {
                            Weekday = row.Cells["weekdayCol"].Value.ToString(),
                            StartTime = row.Cells["startTimeCol"].Value.ToString(),
                            EndTime = row.Cells["endTimeCol"].Value.ToString(),
                            StartLearning = row.Cells["startLearningCol"].Value.ToString(),
                            EndLearning = row.Cells["endLearningCol"].Value.ToString(),
                            GroupId = int.Parse(label6.Text)
                        };
                        db.GroupInfos.Add(gi);
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("В таблице должна быть по крайней мере одна строка");
                return;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int disId;
            using(testDBContext db = new())
            {
                disId = db.Disciplines.
                    AsNoTracking().
                    Where(w => w.DisciplineName == disciplineName.Text).
                    Select(s => s.DisciplineId).
                    FirstOrDefault();

                Group g = db.Groups.Find(int.Parse(label7.Text));

                g.GroupNum = groupNum.Text;
                g.DisciplineId = disId;
                g.NumOfHours = int.Parse(numOfHours.Text);
                g.DisciplineName = disciplineName.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row.Cells["groupInfoIdCol"].Value.ToString()))
                    {
                        GroupInfo gi = new()
                        {
                            Weekday = row.Cells["weekdayCol"].Value.ToString(),
                            StartTime = row.Cells["startTimeCol"].Value.ToString(),
                            EndTime = row.Cells["endTimeCol"].Value.ToString(),
                            StartLearning = row.Cells["startLearningCol"].Value.ToString(),
                            EndLearning = row.Cells["endLearningCol"].Value.ToString(),
                            GroupId = int.Parse(label7.Text)
                        };
                        db.GroupInfos.Add(gi);
                    }
                    else
                    {
                        GroupInfo gi = db.GroupInfos.Find(int.Parse(row.Cells["groupInfoIdCol"].Value.ToString()));

                        gi.Weekday = row.Cells["weekdayCol"].Value.ToString();
                        gi.StartTime = row.Cells["startTimeCol"].Value.ToString();
                        gi.EndTime = row.Cells["endTimeCol"].Value.ToString();
                        gi.StartLearning = row.Cells["startLearningCol"].Value.ToString();
                        gi.EndLearning = row.Cells["endLearningCol"].Value.ToString();
                    }
                }
                db.SaveChanges();
            }
            label6.Text = "1";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupNum.Text = "";
            numOfHours.Text = "";
            weekday.Text = "";
            startTime.Text = "";
            endTime.Text = "";
            disciplineName.Text = "";
            startLearning.Value = DateTime.UtcNow;
            endLearning.Value = DateTime.UtcNow;
        }

        private void addGIBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(weekday.Text) && 
                !string.IsNullOrWhiteSpace(startTime.Text) && 
                !string.IsNullOrWhiteSpace(endTime.Text))
            {
                dataGridView1.Rows.Add("", weekday.Text, startTime.Text, endTime.Text,
                    startLearning.Value.ToString().Remove(10), endLearning.Value.ToString().Remove(10));
            }
        }

        private void delGIBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string groupInfoId = dataGridView1.SelectedRows[0].Cells["groupInfoIdCol"].Value.ToString();

                if (button3.Visible && !string.IsNullOrWhiteSpace(groupInfoId))
                {
                        if (dataGridView1.Rows.Count != 1)
                        {
                            using (testDBContext db = new())
                            {
                                GroupInfo gi = db.GroupInfos.Find(int.Parse(groupInfoId));

                                db.GroupInfos.Remove(gi);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Группе должно быть назначено по крайней мере одно расписание");
                            return;
                        }
                }

                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
