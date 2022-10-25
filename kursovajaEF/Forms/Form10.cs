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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teachId;

            if (fio.Text.Length == 0 || 
                title.Text.Length == 0 || 
                position.Text.Length == 0 || 
                pedEx.Text.Length == 0 || 
                overEx.Text.Length == 0 || 
                degree.Text.Length == 0 || 
                phone_num.Text.Length == 0 || 
                email.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }
            using (testDBContext db = new())
            {
                Teacher t = new()
                {
                    Fio = fio.Text,
                    Dob = dob.Value.ToString().Remove(10),
                    Title = title.Text,
                    Position = position.Text,
                    PedagogicalExperience = pedEx.Text,
                    OverallExperience = overEx.Text,
                    Degree = degree.Text,
                    PhoneNum = decimal.Parse(phone_num.Text),
                    Email = email.Text
                };

                db.Teachers.Add(t);
                db.SaveChanges();

                teachId = (from teach in db.Teachers
                         orderby teach.TeacherId descending
                         select teach.TeacherId).FirstOrDefault();
            }
            
            label10.Text = teachId.ToString();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fio.Text.Length == 0 || 
                title.Text.Length == 0 || 
                position.Text.Length == 0 || 
                pedEx.Text.Length == 0 || 
                overEx.Text.Length == 0 ||
                degree.Text.Length == 0 || 
                phone_num.Text.Length == 0 || 
                email.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }
            using (testDBContext db = new())
            {
                Teacher t = db.Teachers.Find(int.Parse(label11.Text));

                t.Fio = fio.Text;
                t.Dob = dob.Value.ToString().Remove(10);
                t.Title = title.Text;
                t.Position = position.Text;
                t.PedagogicalExperience = pedEx.Text;
                t.OverallExperience = overEx.Text;
                t.Degree = degree.Text;
                t.PhoneNum = decimal.Parse(phone_num.Text);
                t.Email = email.Text;

                db.Update(t);
                db.SaveChanges();
            }
            //    sql = "UPDATE teachers SET fio = '" +
            //fio.Text + "', dob = '" +
            //dob.Value.ToString().Remove(10) + "', title = '" +
            //title.Text + "', position = '" +
            //position.Text + "', pedagogical_experience = '" +
            //pedEx.Text + "', overall_experience = '" +
            //overEx.Text + "', degree = '" +
            //degree.Text + "', phone_num = " +
            //phone_num.Text + ", email = '" +
            //email.Text + "' WHERE teacher_id = '" + label11.Text + "';";
            //    dml = gcnew OdbcCommand(sql, conn);
            //    dml.ExecuteNonQuery();
            label10.Text = "1";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fio.Text = "";
            dob.Value = DateTime.UtcNow;
            title.Text = "";
            position.Text = "";
            pedEx.Text = "";
            overEx.Text = "";
            degree.Text = "";
            phone_num.Text = "";
            email.Text = "";
        }

        private void fio_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < fio.Text.Length; i++)
            {
                if (fio.Text[i] <= '~' && fio.Text[i] > ' ')
                {
                    fio.ForeColor = Color.Red;
                    break;
                }
                else fio.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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

        private void title_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < title.Text.Length; i++)
            {
                if ((title.Text[i] <= '~' && title.Text[i] > '9') || (title.Text[i] > ' ' && title.Text[i] < '0'))
                {
                    title.ForeColor = Color.Red;
                    break;
                }
                else title.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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

        private void position_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < position.Text.Length; i++)
            {
                if ((position.Text[i] <= '~' && position.Text[i] > '9') || (position.Text[i] > ' ' && position.Text[i] < '0'))
                {
                    position.ForeColor = Color.Red;
                    break;
                }
                else position.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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

        private void pedEx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < pedEx.Text.Length; i++)
            {
                if ((position.Text[i] <= '~' && position.Text[i] > '9') || (position.Text[i] > ' ' && position.Text[i] < '0'))
                {
                    pedEx.ForeColor = Color.Red;
                    break;
                }
                else pedEx.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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

        private void overEx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < overEx.Text.Length; i++)
            {
                if ((position.Text[i] <= '~' && position.Text[i] > '9') || (position.Text[i] > ' ' && position.Text[i] < '0'))
                {
                    overEx.ForeColor = Color.Red;
                    break;
                }
                else overEx.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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

        private void degree_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < degree.Text.Length; i++)
            {
                if ((degree.Text[i] <= '~' && degree.Text[i] > '9') || (degree.Text[i] > ' ' && degree.Text[i] < '0'))
                {
                    degree.ForeColor = Color.Red;
                    break;
                }
                else degree.ForeColor = Color.Black;
            }
            if (fio.ForeColor == Color.Red ||
                title.ForeColor == Color.Red ||
                position.ForeColor == Color.Red ||
                pedEx.ForeColor == Color.Red ||
                overEx.ForeColor == Color.Red ||
                degree.ForeColor == Color.Red ||
                phone_num.ForeColor == Color.Red)
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
    }
}
