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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void start_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < start.Text.Length; i++)
            {
                if (start.Text[i] > ':' || start.Text[i] == '/' || (start.Text[i] > ' ' && start.Text[i] < '-'))
                {
                    start.ForeColor = Color.Red;
                    break;
                }
                else start.ForeColor = Color.Black;
            }
            if (start.ForeColor == Color.Red ||
                end.ForeColor == Color.Red ||
                weekday.ForeColor == Color.Red)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void end_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < end.Text.Length; i++)
            {
                if (end.Text[i] > ':' || end.Text[i] == '/' || (end.Text[i] > ' ' && end.Text[i] < '-'))
                {
                    end.ForeColor = Color.Red;
                    break;
                }
                else end.ForeColor = Color.Black;
            }
            if (start.ForeColor == Color.Red ||
                end.ForeColor == Color.Red ||
                weekday.ForeColor == Color.Red)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void weekday_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < weekday.Text.Length; i++)
            {
                if (weekday.Text[i] <= '~')
                {
                    weekday.ForeColor = Color.Red;
                    break;
                }
                else weekday.ForeColor = Color.Black;
            }
            if (start.ForeColor == Color.Red ||
                end.ForeColor == Color.Red ||
                weekday.ForeColor == Color.Red)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ttId;

            if (start.Text.Length == 0 || end.Text.Length == 0 || weekday.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }
            using (testDBContext db = new())
            {
                Timetable t = new()
                {
                    StartTime = start.Text,
                    EndTime = end.Text,
                    Weekday = weekday.Text
                };

                db.Timetables.Add(t);
                db.SaveChanges();

                ttId = (from time in db.Timetables
                           orderby time.TtId descending
                           select time.TtId).FirstOrDefault();
            }

            label4.Text = ttId.ToString();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (start.Text.Length == 0 || end.Text.Length == 0 || weekday.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }
            using (testDBContext db = new())
            {
                Timetable t = db.Timetables.Find(int.Parse(label5.Text));

                t.StartTime = start.Text;
                t.EndTime = end.Text;
                t.Weekday = weekday.Text;

                db.SaveChanges();
            }
            label4.Text = "1";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            start.Text = "";
            end.Text = "";
            weekday.Text = "";
        }
    }
}
