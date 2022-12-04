using System;
using System.Windows.Forms;
using Npgsql;

namespace kursovajaEF.Forms
{
    public partial class Form2_1 : AdvancedForm
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                Contract c = db.Contracts.Find(int.Parse(contract_id.Text));
                if (expulsionRB.Checked)
                {
                    c.ExpulsionDate = expulsionDate.Value.ToString().Remove(10);
                    c.ListenedHours = listenedHours.Text;
                    c.Certificate = null;
                    c.IssueCertificate = null;
                    db.Contracts.Update(c);
                }
                else 
                {
                    c.ExpulsionDate = null;
                    c.ListenedHours = null;
                    c.Certificate = certificate.Text;
                    c.IssueCertificate = issueCertificate.Value.ToString().Remove(10);
                    db.Contracts.Update(c);
                }
                db.SaveChanges();
            }
            Close();
        }

        private void expulsionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (!expulsionRB.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                if (string.IsNullOrWhiteSpace(certificate.Text))
                {
                    endBtn.Enabled = false;
                }
                else endBtn.Enabled = true;
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;
                if (string.IsNullOrWhiteSpace(listenedHours.Text))
                {
                    endBtn.Enabled = false;
                }
                else endBtn.Enabled = true;
            }
        }

        private void certificate_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                endBtn.Enabled = false;
            }
            else endBtn.Enabled = true;
        }
    }
}
