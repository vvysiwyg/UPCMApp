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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deptId;

            if (dept_name.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }
            
            using(testDBContext db = new())
            {
                Department d = new()
                {
                    DepartmentName = dept_name.Text
                };

                db.Departments.Add(d);
                db.SaveChanges();

                deptId = db.Departments.
                    AsNoTracking().
                    Where(w => w.DepartmentName == dept_name.Text).
                    Select(s => s.DepartmentId).
                    FirstOrDefault();
            }

            label1.Text = deptId.ToString();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dept_name.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using(testDBContext db = new())
            {
                Department d = db.Departments.Find(int.Parse(label2.Text));

                d.DepartmentName = dept_name.Text;
                db.SaveChanges();
            }
            label1.Text = "1";
            Close();
        }
    }
}
