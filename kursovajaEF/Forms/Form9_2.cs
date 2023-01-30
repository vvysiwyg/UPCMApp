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
    public partial class Form9_2 : Form
    {
        public Form9_2()
        {
            InitializeComponent();
        }

        private void issueAnOrderBtn_Click(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                string day, month;

                if (orderDate.Value.Day < 10)
                    day = $"0{orderDate.Value.Day}";
                else
                    day = orderDate.Value.Day.ToString();

                if (orderDate.Value.Month < 10)
                    month = $"0{orderDate.Value.Month}";
                else
                    month = orderDate.Value.Month.ToString();

                DisciplinesTeacher dt = db.DisciplinesTeachers.Find(
                    new object[] { int.Parse(discipline_id.Text), int.Parse(teacher_id.Text) });

                dt.Number = int.Parse(orderNumber.Text);
                dt.Date = $"{day}.{month}.{orderDate.Value.Year}";

                db.DisciplinesTeachers.Update(dt);
                db.SaveChanges();
            }
            teacher_id.Text = "-1";
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                issueAnOrderBtn.Enabled = false;
            }
            else issueAnOrderBtn.Enabled = true;
        }
    }
}
