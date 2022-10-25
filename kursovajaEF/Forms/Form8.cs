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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dis_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dis.Text.Length; i++)
            {
                if ((dis.Text[i] <= '~' && dis.Text[i] > 'z') || 
                    (dis.Text[i] > 'Z' && dis.Text[i] < 'a') || 
                    (dis.Text[i] > '9' && dis.Text[i] < 'A') || 
                    (dis.Text[i] > ' ' && dis.Text[i] < '0'))
                {
                    dis.ForeColor = Color.Red;
                    break;
                }
                else dis.ForeColor = Color.Black;
            }
            if (dis.ForeColor == Color.Red ||
                stdper.ForeColor == Color.Red ||
                hours.ForeColor == Color.Red)
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

        private void stdper_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < stdper.Text.Length; i++)
            {
                if ((stdper.Text[i] <= '~' && stdper.Text[i] > 'z') || (stdper.Text[i] > 'Z' && stdper.Text[i] < 'a') || (stdper.Text[i] > '9' && stdper.Text[i] < 'A') || (stdper.Text[i] > ' ' && stdper.Text[i] < '0'))
                {
                    stdper.ForeColor = Color.Red;
                    break;
                }
                else stdper.ForeColor = Color.Black;
            }
            if (dis.ForeColor == Color.Red ||
                stdper.ForeColor == Color.Red ||
                hours.ForeColor == Color.Red)
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

        private void hours_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hours.Text.Length; i++)
            {
                if (hours.Text[i] < '0' || hours.Text[i] > '9')
                {
                    hours.ForeColor = Color.Red;
                    break;
                }
                else hours.ForeColor = Color.Black;
            }
            if (dis.ForeColor == Color.Red ||
                stdper.ForeColor == Color.Red ||
                hours.ForeColor == Color.Red)
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
            int disId;

            if (dis.Text.Length == 0 || stdper.Text.Length == 0 || hours.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using(testDBContext db = new())
            {
                Discipline d = new()
                {
                    DisciplineName = dis.Text,
                    StudyPeriod = stdper.Text,
                    HoursOfStudy = Int16.Parse(hours.Text)
                };

                db.Disciplines.Add(d);
                db.SaveChanges();

                disId = (from dis in db.Disciplines
                             orderby dis.DisciplineId descending
                             select dis.DisciplineId).FirstOrDefault();
            }
            label4.Text = disId.ToString();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dis.Text.Length == 0 || stdper.Text.Length == 0 || hours.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using(testDBContext db = new())
            {
                Discipline d = db.Disciplines.Find(int.Parse(label5.Text));

                d.DisciplineName = dis.Text;
                d.StudyPeriod = stdper.Text;
                d.HoursOfStudy = Int16.Parse(hours.Text);

                db.Update(d);
                db.SaveChanges();
            }
            label4.Text = "1";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dis.Text = "";
            stdper.Text = "";
            hours.Text = "";
        }
    }
}
