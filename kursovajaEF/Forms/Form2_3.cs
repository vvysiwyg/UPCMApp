using kursovajaEF.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Windows.Forms;

namespace kursovajaEF.Forms
{
    public partial class Form2_3 : Form
    {
        public Form2_3()
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

                if (enrollmentOrderRB.Checked)
                {
                    ListenerEnrollmentOrder leo = new()
                    {
                        Number = int.Parse(orderNumber.Text),
                        Date = $"{day}.{month}.{orderDate.Value.Year}",
                        ContractId = int.Parse(contract_id.Text)
                    };
                    db.ListenerEnrollmentOrders.Add(leo);
                }
                else
                {
                    ListenerExpulsionOrder leo = new()
                    {
                        Number = int.Parse(orderNumber.Text),
                        Date = $"{day}.{month}.{orderDate.Value.Year}",
                        ContractId = int.Parse(contract_id.Text)
                    };
                    db.ListenerExpulsionOrders.Add(leo);
                }
                try
                {
                    db.SaveChanges();
                    contract_id.Text = "-1";
                }
                catch (DbUpdateException due)
                {
                    if(due.InnerException is PostgresException pe && pe.Code == "23505")
                        MessageBox.Show("Распоряжение для выбранного договора было сформировано ранее.");
                }
            }
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
