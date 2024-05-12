using Microsoft.EntityFrameworkCore;
using Npgsql;
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
    public partial class Form13 : AdvancedForm
    {
        private NpgsqlConnection con;
        public Form13(NpgsqlConnection conn)
        {
            this.con = conn;
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Contract c in db.Contracts.AsNoTracking().ToList())
            {
                contracts.Rows.Add(
                    c.Crn,
                    c.TotalSum,
                    c.PayedSum,
                    c.PayDate40pct,
                    !string.IsNullOrWhiteSpace(c.ExpulsionDate) ? c.ExpulsionDate : "",
                    !string.IsNullOrWhiteSpace(c.ListenedHours) ? c.ListenedHours : "",
                    !string.IsNullOrWhiteSpace(c.TransferGroup) ? c.TransferGroup : "",
                    c.RestOfSum,
                    c.PaymentDeadline,
                    !string.IsNullOrWhiteSpace(c.IssueCertificate) ? c.IssueCertificate : "",
                    !string.IsNullOrWhiteSpace(c.Certificate) ? c.Certificate : "",
                    c.WhoPay,
                    c.ContractId
                    );

                if(c.Paid40pct == true)
                    contracts.Rows[contracts.RowCount - 1].Cells["PayDate40pctCol"].Style.ForeColor = Color.Green;
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                fetch(db);
                if (contracts.RowCount != 0)
                    contracts.Rows[0].Selected = true;

                foreach (Listener l in db.Listeners.AsNoTracking().ToList())
                    listeners.Rows.Add(
                        l.Firstname,
                        l.Midname,
                        l.Lastname,
                        l.Yob,
                        l.Sex,
                        l.Id,
                        l.Matriculation,
                        "",
                        l.PhoneNum,
                        l.SchoolGrade,
                        l.Email,
                        l.ListenerCategory
                        );
                if (listeners.RowCount != 0)
                    listeners.Rows[0].Selected = true;
            }
        }

        private void contracts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contracts.SelectedCells[0].OwningColumn.Name == "PayDate40pctCol") {
                if (contracts.SelectedCells[0].Style.ForeColor == Color.Green)
                {
                    contracts.SelectedCells[0].Style.ForeColor = SystemColors.ControlText;
                    using(testDBContext db = new())
                    {
                        Contract c = db.Contracts.Find(int.Parse(contracts.
                            Rows[contracts.SelectedCells[0].RowIndex].Cells["contractIdCol"].Value.ToString()));

                        c.Paid40pct = false;
                        db.SaveChanges();
                    }
                }
                else
                {
                    contracts.SelectedCells[0].Style.ForeColor = Color.Green;
                    using (testDBContext db = new())
                    {
                        Contract c = db.Contracts.Find(int.Parse(contracts.
                            Rows[contracts.SelectedCells[0].RowIndex].Cells["contractIdCol"].Value.ToString()));

                        c.Paid40pct = true;
                        db.SaveChanges();
                    }
                }
            }
            else return;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form14 form = new();
            form.ShowDialog();
            if (form.label12.Text != "0") {
                contracts.Rows.Add(form.crn.Text, form.totalSum.Text, form.payedSum.Text,
                    form.PayDate40pct.Value.ToString().Remove(10), form.expulsionDate.Text, form.listenedHours.Text,
                    form.transferGroup.Text, form.restOfSum.Text, form.paymentDeadline.Value.ToString().Remove(10), form.issueCertificate.Value.ToString().Remove(10),
                    form.certificate.Text, form.whoPay.Text, form.label12.Text);
                for (int i = 0; i < contracts.RowCount - 1; i++)
                    contracts.Rows[i].Selected = false;

                contracts.Rows[contracts.RowCount - 1].Selected = true;
                contracts.CurrentCell = contracts.Rows[contracts.RowCount - 1].Cells[contracts.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (contracts.SelectedRows.Count == 1)
            {
                Form14 fm = new();
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label13.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["contractIdCol"].Value.ToString();
                fm.crn.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["crnCol"].Value.ToString();
                fm.totalSum.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["totalSumCol"].Value.ToString();
                fm.payedSum.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["payedSumCol"].Value.ToString();
                fm.PayDate40pct.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["PayDate40pctCol"].Value.ToString();
                fm.expulsionDate.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["expulsionDateCol"].Value.ToString();
                fm.listenedHours.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["listenedHoursCol"].Value.ToString();
                fm.transferGroup.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["transferGroupCol"].Value.ToString();
                fm.restOfSum.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["restOfSumCol"].Value.ToString();
                fm.paymentDeadline.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["paymentDeadlineCol"].Value.ToString();
                fm.issueCertificate.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["issueCertificateCol"].Value.ToString();
                fm.certificate.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["certificateCol"].Value.ToString();
                fm.whoPay.Text = contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["whoPayCol"].Value.ToString();
                fm.ShowDialog();
                if (fm.label12.Text == "1") {
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["crnCol"].Value = fm.crn.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["totalSumCol"].Value = fm.totalSum.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["payedSumCol"].Value = fm.payedSum.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["PayDate40pctCol"].Value = fm.PayDate40pct.Value.ToString().Remove(10);
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["expulsionDateCol"].Value = fm.expulsionDate.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["listenedHoursCol"].Value = fm.listenedHours.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["transferGroupCol"].Value = fm.transferGroup.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["restOfSumCol"].Value = fm.restOfSum.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["paymentDeadlineCol"].Value = fm.paymentDeadline.Value.ToString().Remove(10);
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["issueCertificateCol"].Value = fm.issueCertificate.Value.ToString().Remove(10);
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["certificateCol"].Value = fm.certificate.Text;
                    contracts.Rows[contracts.SelectedCells[0].RowIndex].Cells["whoPayCol"].Value = fm.whoPay.Text;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int[] selrow = new int[contracts.SelectedCells.Count];
            int index = -1, count = 0;

            for (int i = 0; i < contracts.SelectedCells.Count; i++)
                selrow[i] = contracts.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    if(selrow[i] == selrow[j])
                        selrow[j] = -1;

            for (int i = 0; i < contracts.SelectedCells.Count; i++)
                if (selrow[i] != -1)
                {
                    index = i;
                    count++;
                }

            if (count == 1)
            {
                using (testDBContext db = new())
                {
                    Contract c = db.Contracts.Find(int.Parse(contracts.
                        Rows[selrow[index]].Cells[contracts.Columns["contractIdCol"].Index].Value.ToString()));
                    db.Remove(c);
                    db.SaveChanges();
                }
                contracts.Rows.RemoveAt(selrow[index]);
            }
            else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var c = db.Contracts.AsNoTracking().Where(w =>
                    EF.Functions.Like(w.Crn, $"%{txt}%") ||
                    EF.Functions.Like(w.TotalSum.ToString(), $"%{txt}%") ||
                    EF.Functions.Like(w.PayedSum.ToString(), $"%{txt}%") ||
                    EF.Functions.Like(w.PayDate40pct, $"%{txt}%") ||
                    EF.Functions.Like(w.ExpulsionDate, $"%{txt}%") ||
                    EF.Functions.Like(w.ListenedHours, $"%{txt}%") ||
                    EF.Functions.Like(w.TransferGroup, $"%{txt}%") ||
                    EF.Functions.Like(w.RestOfSum.ToString(), $"%{txt}%") ||
                    EF.Functions.Like(w.PaymentDeadline, $"%{txt}%") ||
                    EF.Functions.Like(w.IssueCertificate, $"%{txt}%") ||
                    EF.Functions.Like(w.Certificate, $"%{txt}%") ||
                    EF.Functions.Like(w.WhoPay, $"%{txt}%"));

                    contracts.Rows.Clear();

                    foreach (var elem in c)
                    {
                        contracts.Rows.Add(
                            elem.Crn,
                            elem.TotalSum,
                            elem.PayedSum,
                            elem.PayDate40pct,
                            elem.ExpulsionDate,
                            elem.ListenedHours,
                            elem.TransferGroup,
                            elem.RestOfSum,
                            elem.PaymentDeadline,
                            elem.IssueCertificate,
                            elem.Certificate,
                            elem.WhoPay,
                            elem.ContractId
                            );
                    }
                }
            }
            else
            {
                contracts.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (contracts.RowCount != 0)
                    contracts.Rows[0].Selected = true;
            }
        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (contracts.SelectedRows.Count == 1 && listeners.SelectedRows.Count == 1)
            {
                string sql= "UPDATE listeners SET contract_id = (@contractIdCol) WHERE id = (@idCol);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con)
                {
                    Parameters =
                    {
                        new("idCol", int.Parse(listeners.
                        Rows[listeners.SelectedCells[0].RowIndex].Cells["listenerIdCol"].Value.ToString())),
                        new("contractIdCol", int.Parse(contracts.
                        Rows[contracts.SelectedCells[0].RowIndex].Cells["contractIdCol"].Value.ToString()))
                    }
                };
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные связаны", Text.ToString());
            }
            else MessageBox.Show("Для создания соотношения между двумя таблицами должно быть выделено ровно по одной строке в каждой из таблиц.", "Ошибка");
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}