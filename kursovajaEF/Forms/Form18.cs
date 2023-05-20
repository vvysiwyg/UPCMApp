using kursovajaEF.Models;
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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chairName.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using (testDBContext db = new())
            {
                Chair c = new()
                {
                    ChairName = chairName.Text,
                };

                db.Chairs.Add(c);
                db.SaveChanges();
            }
            label6.Text = "1";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chairName.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using (testDBContext db = new())
            {
                Chair c = db.Chairs.Find(int.Parse(label7.Text));

                c.ChairName = chairName.Text;

                db.Update(c);
                db.SaveChanges();
            }
            label6.Text = "1";
            Close();
        }

        private void chairName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chairName.Text.Length; i++)
            {
                if ((chairName.Text[i] <= '~' && chairName.Text[i] > 'z') ||
                    (chairName.Text[i] > 'Z' && chairName.Text[i] < 'a') ||
                    (chairName.Text[i] > '9' && chairName.Text[i] < 'A') ||
                    (chairName.Text[i] > ' ' && chairName.Text[i] < '0'))
                {
                    chairName.ForeColor = Color.Red;
                    break;
                }
                else chairName.ForeColor = Color.Black;
            }
            if (chairName.ForeColor == Color.Red)
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
