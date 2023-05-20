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
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();
            using (testDBContext db = new())
            {
                string[] gss = db.Groups.AsNoTracking().Select(s => s.GroupNum).ToArray();
                transferGroup.Items.AddRange(gss);
                transferGroup.Text = transferGroup.Items[0].ToString();
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                Contract c = db.Contracts.Find(int.Parse(contract_id.Text));
                c.TransferGroup = transferGroup.Text;
                db.Contracts.Update(c);
                db.SaveChanges();
            }
            contract_id.Text = "-1";
            Close();
        }
    }
}
