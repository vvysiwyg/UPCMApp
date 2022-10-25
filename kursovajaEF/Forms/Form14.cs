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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void totalSum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(totalSum.Text) && !string.IsNullOrWhiteSpace(payedSum.Text))
            {
                int substract = int.Parse(totalSum.Text) - int.Parse(payedSum.Text);
                restOfSum.Text = substract.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contractId;

            if (crn.Text.Length == 0 || whoPay.Text.Length == 0)
            {
                MessageBox.Show("Строка не может быть пустой", "Ошибка");
                return;
            }

            using (testDBContext db = new())
            {
                Contract c = new()
                {
                    Crn = crn.Text,
                    TotalSum = decimal.Parse(totalSum.Text),
                    PayedSum = decimal.Parse(payedSum.Text),
                    PayDate40pct = PayDate40pct.Value.ToString().Remove(10),
                    ExpulsionDate = expulsionDate.Text,
                    ListenedHours = listenedHours.Text,
                    TransferGroup = transferGroup.Text,
                    RestOfSum = decimal.Parse(restOfSum.Text),
                    IssueCertificate = issueCertificate.Value.ToString().Remove(10),
                    Certificate = certificate.Text,
                    WhoPay = whoPay.Text,
                    PaymentDeadline = paymentDeadline.Value.ToString().Remove(10)
                };

                db.Contracts.Add(c);
                db.SaveChanges();

                contractId = (from con in db.Contracts
                        orderby con.ContractId descending
                        select con.ContractId).FirstOrDefault();
            }

            label12.Text = contractId.ToString();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                Contract c = db.Contracts.Find(int.Parse(label13.Text));

                c.Crn = crn.Text;
                c.TotalSum = decimal.Parse(totalSum.Text);
                c.PayedSum = decimal.Parse(payedSum.Text);
                c.PayDate40pct = PayDate40pct.Value.ToString().Remove(10);
                c.ExpulsionDate = expulsionDate.Text;
                c.ListenedHours = listenedHours.Text;
                c.TransferGroup = transferGroup.Text;
                c.RestOfSum = decimal.Parse(restOfSum.Text);
                c.IssueCertificate = issueCertificate.Value.ToString().Remove(10);
                c.Certificate = certificate.Text;
                c.WhoPay = whoPay.Text;
                c.PaymentDeadline = paymentDeadline.Value.ToString().Remove(10);

                db.SaveChanges();
            }
            label12.Text = "1";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crn.Text = "";
            totalSum.Text = "";
            payedSum.Text = "";
            PayDate40pct.Value = DateTime.UtcNow;
            expulsionDate.Text = "";
            listenedHours.Text = "";
            transferGroup.Text = "";
            restOfSum.Text = "";
            issueCertificate.Value = DateTime.UtcNow;
            certificate.Text = "";
            whoPay.Text = "";
            paymentDeadline.Value = DateTime.UtcNow;
        }
    }
}
