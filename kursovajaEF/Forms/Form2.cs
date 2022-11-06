using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursovajaEF.Models;
using Npgsql;

namespace kursovajaEF.Forms
{
    public partial class Form2 : AdvancedForm
    {
        private NpgsqlConnection conn;
        private Dictionary<string, string> ids;
        private int tempIndex;
        public Form2(NpgsqlConnection conn)
        {
            this.conn = conn;
            tempIndex = 0;
            InitializeComponent();
        }

        private string str_formater(string str, string oldValue, string newValue)
        {
            return str.Replace(oldValue, newValue);
        }

        private void delWishBtn_Click(object sender, EventArgs e)
        {
            if (wishes.SelectedRows.Count == 1)
                wishes.Rows.Remove(wishes.SelectedRows[0]);
        }

        private void addWishBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(startTime.Text))
                startTime.Text = "00.00";

            if (string.IsNullOrWhiteSpace(endTime.Text))
                endTime.Text = "24.00";

            wishes.Rows.Add("", weekday.Text, startTime.Text, endTime.Text, "");

            if (wishes.Visible == false)
                wishes.Visible = true;

            try
            {
                DataGridView dgv = ((DataGridView)panel3.Controls.Find("dgv", true)[0]), 
                    dgvs = ((DataGridView)panel3.Controls.Find("dgvS", true)[0]);

                string disName = dgv.Rows[0].Cells["dgvtbc1Col"].Value.ToString(),
                    startTimeFormated = str_formater(startTime.Text, ":", "."),
                    endTimeFormated = str_formater(endTime.Text, ":", ".");

                startTime.Text = "";
                endTime.Text = "";

                string sql = "with sub_group as (select * from groups where " +
                    "discipline_id = (select discipline_id from disciplines where discipline_name = (@disName))) " +
                    "select sg.discipline_name, sg.group_num, sg.num_of_hours, gi.* " +
                    "from sub_group sg join group_info gi on(sg.group_id = gi.group_id) " +
                    "WHERE weekday = (@weekday) AND ((start_time >= (@startTimeFormated) AND start_time < (@endTimeFormated)" +
                    ") OR (end_time >= (@startTimeFormated) AND end_time < (@endTimeFormated)));";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                {
                    Parameters =
                    {
                        new("disName", disName),
                        new("weekday", weekday.Text),
                        new("startTimeFormated", startTimeFormated),
                        new("endTimeFormated", endTimeFormated)
                    }
                };
                NpgsqlDataReader r = cmd.ExecuteReader();

                for(;r.Read();)
                    dgvs.Rows.Add(
                        !r.IsDBNull(0) ? r.GetString(0) : "",
                        !r.IsDBNull(1) ? r.GetString(1) : "",
                        !r.IsDBNull(2) ? r.GetInt32(2) : "",
                        !r.IsDBNull(3) ? r.GetInt32(3) : "",
                        !r.IsDBNull(4) ? r.GetString(4) : "",
                        !r.IsDBNull(5) ? r.GetString(5) : "",
                        !r.IsDBNull(6) ? r.GetString(6) : "",
                        !r.IsDBNull(7) ? r.GetString(7) : "",
                        !r.IsDBNull(8) ? r.GetString(8) : "",
                        !r.IsDBNull(9) ? r.GetInt32(9) : ""
                    );
                r.Close();
            }
            catch (IndexOutOfRangeException ex) {

            }
        }

        private void delWishBtn2_Click(object sender, EventArgs e)
        {
            if (wishes.SelectedRows.Count == 1)
            {
                using (testDBContext db = new())
                {
                    ListenerWish lw = db.ListenerWishes
                        .Find(int.Parse(wishes.SelectedRows[0].Cells["wishIdCol"].Value.ToString()));
                    db.Remove(lw);
                    db.SaveChanges();
                }
                wishes.Rows.Remove(wishes.SelectedRows[0]);
            }
        }

        private void delGIBtn_Click(object sender, EventArgs e)
        {
            if(group_info.SelectedRows.Count == 1 || group_info.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = group_info.SelectedCells[0].OwningRow;
                group_info.Rows.Remove(selectedRow);

                if(updBtn.Visible)
                    using(testDBContext db = new())
                    {
                        var gici = db.GroupInfoContractInfos.
                            Where(f => f.GroupInfoId == int.Parse(selectedRow.Cells["groupInfoIdCol"].Value.ToString())).
                            Where(s => s.ContractInfoId == int.Parse(selectedRow.Cells["contractInfoIdCol2"].Value.ToString()));

                        db.Remove(gici.FirstOrDefault());
                        db.SaveChanges();
                    }
            }
        }

        private void delCIBtn_Click(object sender, EventArgs e)
        {
            if (contract_info.SelectedRows.Count == 1 || contract_info.SelectedCells.Count == 1)
            {
                DataGridViewRow row = contract_info.SelectedCells[0].OwningRow;
                dataGridViewDeleteRowsWithCondition(group_info, "contractInfoIdCol2", row.Cells["contractInfoIdCol"].Value.ToString());
                contract_info.Rows.Remove(row);
            }
        }

        private void addCIBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(hours.Text) && !string.IsNullOrWhiteSpace(numOfPeople.Text))
            {
                contract_info.Rows.Add(discipline.Text, hours.Text, numOfPeople.Text, tempIndex);
                tempIndex++;
                hours.Text = "";
                numOfPeople.Text = "";
                if (!contract_info.Visible)
                {
                    contract_info.Visible = true;
                    group_info.Visible = true;
                }
            }
        }

        private void delCIBtn2_Click(object sender, EventArgs e)
        {
            if (contract_info.SelectedRows.Count == 1 || contract_info.SelectedCells.Count == 1)
            {
                DataGridViewRow row = contract_info.SelectedCells[0].OwningRow;
                using (testDBContext db = new())
                {
                    ContractInfo ci = db.ContractInfos.
                        Find(int.Parse(row.Cells["contractInfoIdCol"].Value.ToString()));
                    db.Remove(ci);
                    db.SaveChanges();
                }
                dataGridViewDeleteRowsWithCondition(group_info, "contractInfoIdCol2", row.Cells["contractInfoIdCol"].Value.ToString());
                contract_info.Rows.Remove(row);
            }
        }

        private void addCIBtn2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(hours.Text) && !string.IsNullOrWhiteSpace(numOfPeople.Text))
            {
                int discipline_id, contract_info_id;

                using(testDBContext db = new())
                {
                    discipline_id = (from dis in db.Disciplines
                                  where dis.DisciplineName == discipline.Text
                                  select dis.DisciplineId).FirstOrDefault();

                    ContractInfo contractInfo = new() 
                    { 
                        DisciplineName = discipline.Text,
                        StudyHours = Int16.Parse(hours.Text),
                        NumOfPeople = Int16.Parse(numOfPeople.Text),
                        ContractId = int.Parse(contractId.Text),
                        DisciplineId = discipline_id
                    };

                    db.ContractInfos.Add(contractInfo);
                    db.SaveChanges();

                    contract_info_id = (from coninfo in db.ContractInfos
                              orderby coninfo.ContractInfoId descending
                              select coninfo.ContractInfoId).FirstOrDefault();

                    contract_info.Rows.Add(
                        discipline.Text,
                        hours.Text,
                        numOfPeople.Text,
                        contract_info_id);
                }
                hours.Text = "";
                numOfPeople.Text = "";
            }
        }

        private void addWishBtn2_Click(object sender, EventArgs e)
        {
            int wish_id;
            string sql;

            if (string.IsNullOrWhiteSpace(startTime.Text))
                startTime.Text = "00.00";

            if (string.IsNullOrWhiteSpace(endTime.Text))
                endTime.Text = "24.00";

            try
            {
                using (testDBContext db = new()) 
                {
                    ListenerWish lw = new()
                    {
                        Weekday = weekday.Text,
                        StartTime = startTime.Text,
                        EndTime = endTime.Text,
                        ContractId = int.Parse(contractId.Text)
                    };

                    db.ListenerWishes.Add(lw);
                    db.SaveChanges();

                    wish_id = (from Lw in db.ListenerWishes
                               orderby Lw.WishId descending
                               select Lw.WishId).FirstOrDefault();

                    wishes.Rows.Add
                    (
                        wish_id,
                        weekday.Text,
                        startTime.Text,
                        endTime.Text,
                        contractId.Text
                    );
                    if (wishes.Visible == false)
                        wishes.Visible = true;

                    DataGridView dgv = ((DataGridView)panel3.Controls.Find("dgv", true)[0]),
                    dgvs = ((DataGridView)panel3.Controls.Find("dgvS", true)[0]);

                    string disName = dgv.Rows[0].Cells["dgvtbc1Col"].Value.ToString(),
                        startTimeFormated = str_formater(startTime.Text, ":", "."),
                        endTimeFormated = str_formater(endTime.Text, ":", ".");

                    startTime.Text = "";
                    endTime.Text = "";

                    sql = "with sub_group as (select * from groups where " +
                        "discipline_id = (select discipline_id from disciplines where discipline_name = (@disName))) " +
                        "select sg.discipline_name, sg.group_num, sg.num_of_hours, gi.* " +
                        "from sub_group sg join group_info gi on(sg.group_id = gi.group_id) " +
                        "WHERE weekday = (@weekday) AND ((start_time >= (@startTimeFormated) AND start_time < (@endTimeFormated)" +
                        ") OR (end_time >= (@startTimeFormated) AND end_time < (@endTimeFormated)));";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                    {
                        Parameters =
                    {
                        new("disName", disName),
                        new("weekday", weekday.Text),
                        new("startTimeFormated", startTimeFormated),
                        new("endTimeFormated", endTimeFormated)
                    }
                    };
                    NpgsqlDataReader r = cmd.ExecuteReader();

                    for (; r.Read();)
                        dgvs.Rows.Add(
                            !r.IsDBNull(0) ? r.GetString(0) : "",
                            !r.IsDBNull(1) ? r.GetString(1) : "",
                            !r.IsDBNull(2) ? r.GetInt32(2) : "",
                            !r.IsDBNull(3) ? r.GetInt32(3) : "",
                            !r.IsDBNull(4) ? r.GetString(4) : "",
                            !r.IsDBNull(5) ? r.GetString(5) : "",
                            !r.IsDBNull(6) ? r.GetString(6) : "",
                            !r.IsDBNull(7) ? r.GetString(7) : "",
                            !r.IsDBNull(8) ? r.GetString(8) : "",
                            !r.IsDBNull(9) ? r.GetInt32(9) : ""
                        );
                    r.Close();
                }
            }
            catch (IndexOutOfRangeException ex)
            {

            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            string sex;
            string matriculation;

            if (sexM.Checked == false && sexF.Checked == false)
            {
                MessageBox.Show("Отметьте Ваш пол.", "Ошибка");
                return;
            }
            else if (sexM.Checked == true)
                sex = sexM.Text;
            else sex = sexF.Text;

            if (yes.Checked == false && no.Checked == false)
            {
                MessageBox.Show("Отметьте отчислен.", "Ошибка");
                return;
            }
            else if (yes.Checked == true)
                matriculation = yes.Text;
            else matriculation = no.Text;

            using (testDBContext db = new()) {
                Listener l = db.Listeners.Find(int.Parse(addingCheck.Text));

                l.Firstname = firstname.Text;
                l.Midname = midname.Text;
                l.Lastname = lastname.Text;
                l.Sex = sex;
                l.Matriculation = matriculation;
                l.PhoneNum = decimal.Parse(phoneNum.Text);
                l.SchoolGrade = schoolGrade.Text;
                l.Email = email.Text;

                db.Listeners.Update(l);

                Contract c = db.Contracts.Find(int.Parse(contractId.Text));

                c.Crn = crn.Text;
                c.TotalSum = decimal.Parse(totalSum.Text);
                c.PayedSum = decimal.Parse(payedSum.Text);
                c.PayDate40pct = PayDate40pct.Value.ToString().Remove(10);
                c.TransferGroup = transferGroup.Text;
                c.RestOfSum = decimal.Parse(restOfSum.Text);
                c.WhoPay = whoPay.Text;
                c.PaymentDeadline = paymentDeadline.Value.ToString().Remove(10);

                db.Contracts.Update(c);

                db.SaveChanges();
            }
            updatingCheck.Text = "1";
            Close();
        }

        private void addGIBtn_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Count != 0)
            {
                bool similarRowsFlag = false;
                DataGridView dgv;

                if (panel3.Controls[0].Visible == true)
                    dgv = (DataGridView)panel3.Controls[0];
                else
                    dgv = (DataGridView)panel3.Controls[1];

                if ((dgv.SelectedRows.Count == 1 || dgv.SelectedCells.Count == 1) &&
                    (contract_info.SelectedRows.Count == 1 || contract_info.SelectedCells.Count == 1))
                {
                    DataGridViewRow r = dgv.SelectedCells[0].OwningRow, r2 = contract_info.SelectedCells[0].OwningRow;

                    foreach (DataGridViewRow row in group_info.Rows)
                        if (row.Cells["groupInfoIdCol"].Value.ToString() == r.Cells["dgvtbc4Col"].Value.ToString() &&
                            row.Cells["contractInfoIdCol2"].Value.ToString() == r2.Cells["contractInfoIdCol"].Value.ToString())
                            similarRowsFlag = true;

                    if (!similarRowsFlag)
                    {
                        group_info.Rows.Add(
                            r.Cells["dgvtbc2Col"].Value,
                            r.Cells["dgvtbc3Col"].Value,
                            r.Cells["dgvtbc4Col"].Value,
                            r.Cells["dgvtbc5Col"].Value,
                            r.Cells["dgvtbc6Col"].Value,
                            r.Cells["dgvtbc7Col"].Value,
                            r.Cells["dgvtbc8Col"].Value,
                            r.Cells["dgvtbc9Col"].Value,
                            r.Cells["dgvtbc10Col"].Value,
                            r2.Cells["contractInfoIdCol"].Value);

                        if (updBtn.Visible == true)
                        {
                            GroupInfoContractInfo gici = new()
                            {
                                GroupInfoId = int.Parse(r.Cells["dgvtbc4Col"].Value.ToString()),
                                ContractInfoId = int.Parse(r2.Cells["contractInfoIdCol"].Value.ToString())
                            };
                            using (testDBContext db = new())
                            {
                                db.GroupInfoContractInfos.Add(gici);
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
        }

        private void totalSum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(totalSum.Text) && !string.IsNullOrWhiteSpace(payedSum.Text))
            {
                double substract = Double.Parse(totalSum.Text) - Double.Parse(payedSum.Text);
                restOfSum.Text = substract.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string sex;
            string matriculation;

            int contract_info_id = -1;
            int contract_id = -1;

            if (sexM.Checked == false && sexF.Checked == false)
            {
                MessageBox.Show("Отметьте пол.", "Ошибка");
                return;
            }
            else if (sexM.Checked == true)
                sex = sexM.Text;
            else sex = sexF.Text;

            if (yes.Checked == false && no.Checked == false)
            {
                MessageBox.Show("Отметьте Зачислен.", "Ошибка");
                return;
            }
            else if (yes.Checked == true)
                matriculation = yes.Text;
            else matriculation = no.Text;

            Dictionary<string, int> dis_name_id = new();
            using (testDBContext db = new()) 
            {
                foreach (DataGridViewRow row in contract_info.Rows)
                {
                    if (!dis_name_id.ContainsKey(row.Cells[0].Value.ToString()))
                    {
                        int discipline_id = (from d in db.Disciplines
                                          where d.DisciplineName == row.Cells[0].Value.ToString()
                                          select d.DisciplineId).FirstOrDefault();
                        dis_name_id.Add(row.Cells[0].Value.ToString(), discipline_id);
                    }
                }

                Contract c = new()
                {
                    Crn = crn.Text,
                    TotalSum = decimal.Parse(totalSum.Text),
                    PayedSum = decimal.Parse(payedSum.Text),
                    PayDate40pct = PayDate40pct.Value.ToString().Remove(10),
                    TransferGroup = transferGroup.Text,
                    RestOfSum = decimal.Parse(restOfSum.Text),
                    WhoPay = whoPay.Text,
                    PaymentDeadline = paymentDeadline.Value.ToString().Remove(10)
                };
                db.Contracts.Add(c);
                db.SaveChanges();

                contract_id = (from contr in db.Contracts
                               orderby contr.ContractId descending
                               select contr.ContractId).FirstOrDefault();

                foreach (DataGridViewRow row in wishes.Rows)
                {
                    ListenerWish lw = new()
                    {
                        Weekday = row.Cells["wWeekdayCol"].Value.ToString(),
                        StartTime = row.Cells["wStartTimeCol"].Value.ToString(),
                        EndTime = row.Cells["wEndTimeCol"].Value.ToString(),
                        ContractId = contract_id
                    };
                    db.ListenerWishes.Add(lw);
                }

                Listener l = new()
                {
                    Firstname = firstname.Text,
                    Midname = midname.Text,
                    Lastname = lastname.Text,
                    Yob = yob.Value.ToString().Remove(10),
                    Sex = sex,
                    Matriculation = matriculation,
                    ContractId = contract_id,
                    PhoneNum = decimal.Parse(phoneNum.Text),
                    SchoolGrade = schoolGrade.Text,
                    Email = email.Text
                };
                db.Listeners.Add(l);
                db.SaveChanges();

                foreach (DataGridViewRow row in contract_info.Rows)
                {
                    ContractInfo ci = new()
                    {
                        DisciplineName = row.Cells[0].Value.ToString(),
                        StudyHours = Int16.Parse(row.Cells[1].Value.ToString()),
                        NumOfPeople = Int16.Parse(row.Cells[2].Value.ToString()),
                        ContractId = contract_id,
                        DisciplineId = dis_name_id[row.Cells[0].Value.ToString()]
                    };
                    db.ContractInfos.Add(ci);
                    db.SaveChanges();

                    contract_info_id = (from Ci in db.ContractInfos
                                        orderby Ci.ContractInfoId descending
                                        select Ci.ContractInfoId).FirstOrDefault();
                    foreach (DataGridViewRow row2 in group_info.Rows)
                        if (row2.Cells["contractInfoIdCol2"].Value.ToString() == row.Cells["contractInfoIdCol"].Value.ToString())
                        {
                            GroupInfoContractInfo gici = new()
                            {
                                GroupInfoId = int.Parse(row2.Cells["groupInfoIdCol"].Value.ToString()),
                                ContractInfoId = contract_info_id
                            };
                            db.GroupInfoContractInfos.Add(gici);
                            db.SaveChanges();
                        }
                }
            }
            Close();
            addingCheck.Text = "1";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void endEduBtn_Click(object sender, EventArgs e)
        {
            Form2_1 form = new(conn);
            form.contract_id.Text = contractId.Text;
            form.ShowDialog();
            updatingCheck.Text = "1";
            Close();
        }

        private void newGroupBtn_Click(object sender, EventArgs e)
        {
            Form16 form = new();
            form.ShowDialog();
        }

        private void contract_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            DataGridView contractInfo = ((DataGridView)sender);
            if (contractInfo.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = contract_info.SelectedCells[0].OwningRow;

                foreach (DataGridViewRow row in group_info.Rows)
                {
                    if (row.Cells["contractInfoIdCol2"].Value.ToString() == selectedRow.Cells["contractInfoIdCol"].Value.ToString())
                        row.Visible = true;
                    else
                        row.Visible = true;
                }

                panel3.Controls.Clear();
                string disName = selectedRow.Cells["disciplineNameCol"].Value.ToString();
                for (int i = 0; i < 2; i++)
                {
                    DataGridView dgv = new();
                    DataGridViewCellStyle dataGridViewCellStyle1 = new();
                    DataGridViewTextBoxColumn dgvtbc1 = new();
                    DataGridViewTextBoxColumn dgvtbc2 = new();
                    DataGridViewTextBoxColumn dgvtbc3 = new();
                    DataGridViewTextBoxColumn dgvtbc4 = new();
                    DataGridViewTextBoxColumn dgvtbc5 = new();
                    DataGridViewTextBoxColumn dgvtbc6 = new();
                    DataGridViewTextBoxColumn dgvtbc7 = new();
                    DataGridViewTextBoxColumn dgvtbc8 = new();
                    DataGridViewTextBoxColumn dgvtbc9 = new();
                    DataGridViewTextBoxColumn dgvtbc10 = new();
                    dgv.Location = new Point(0, 0); //sendBtn.Location.X, sendBtn.Location.Y + sendBtn.Size.Height + 30 * (i + 1) + 150 * i
                    dgv.Size = panel3.Size;
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.Fixed3D;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgv.ReadOnly = true;
                    dgv.AllowUserToAddRows = false;
                    dgv.AllowUserToDeleteRows = false;
                    dgv.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
                            | AnchorStyles.Left)
                            | AnchorStyles.Right);
                    dgv.Columns.AddRange(new DataGridViewColumn[]  {
                        dgvtbc1, dgvtbc2, dgvtbc3, dgvtbc4, dgvtbc5, dgvtbc6, dgvtbc7, dgvtbc8, dgvtbc9, dgvtbc10
                       });
                    dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridViewCellStyle1.BackColor = SystemColors.Control;
                    dataGridViewCellStyle1.Font = (new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point));
                    dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
                    dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
                    dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
                    dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
                    dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
                    dgv.ColumnHeadersHeight = 56;
                    dgv.RowTemplate.DefaultCellStyle.Font = (new Font("Segoe UI", 8, FontStyle.Regular, GraphicsUnit.Point));
                    foreach (DataGridViewTextBoxColumn col in dgv.Columns)
                    {
                        col.MinimumWidth = 6;
                        col.Width = 125;
                    }
                    dgvtbc1.HeaderText = "Программа";
                    dgvtbc1.Name = "dgvtbc1Col";
                    dgvtbc2.HeaderText = "Номер группы";
                    dgvtbc2.Name = "dgvtbc2Col";
                    dgvtbc3.HeaderText = "Часы";
                    dgvtbc3.Name = "dgvtbc3Col";
                    dgvtbc4.HeaderText = "group_info_id";
                    dgvtbc4.Name = "dgvtbc4Col";
                    dgvtbc5.HeaderText = "День недели";
                    dgvtbc5.Name = "dgvtbc5Col";
                    dgvtbc6.HeaderText = "Начало";
                    dgvtbc6.Name = "dgvtbc6Col";
                    dgvtbc7.HeaderText = "Конец";
                    dgvtbc7.Name = "dgvtbc7Col";
                    dgvtbc8.HeaderText = "Дата начала обучения";
                    dgvtbc8.Name = "dgvtbc8Col";
                    dgvtbc9.HeaderText = "Дата окончания обучения";
                    dgvtbc9.Name = "dgvtbc9Col";
                    dgvtbc10.HeaderText = "group_id";
                    dgvtbc10.Name = "dgvtbc10Col";

                    dgvtbc4.Visible = false;
                    dgvtbc10.Visible = false;


                    if (i == 0)
                    {
                        dgv.Name = "dgv";
                        panel3.Controls.Add(dgv);
                        sql = "with sub_group as (select * from groups where " +
                            "discipline_id = (select discipline_id from disciplines where discipline_name = (@disName))) " +
                            "select sg.discipline_name, sg.group_num, sg.num_of_hours, gi.* " +
                            "from sub_group sg join group_info gi on(sg.group_id = gi.group_id)";

                        NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                        {
                            Parameters =
                                {
                                    new("disName", disName)
                                }
                        }; 
                        
                        NpgsqlDataReader r = cmd.ExecuteReader();

                        for (; r.Read();)
                            dgv.Rows.Add(
                                !r.IsDBNull(0) ? r.GetString(0) : "",
                                !r.IsDBNull(1) ? r.GetString(1) : "",
                                !r.IsDBNull(2) ? r.GetInt32(2) : "",
                                !r.IsDBNull(3) ? r.GetInt32(3) : "",
                                !r.IsDBNull(4) ? r.GetString(4) : "",
                                !r.IsDBNull(5) ? r.GetString(5) : "",
                                !r.IsDBNull(6) ? r.GetString(6) : "",
                                !r.IsDBNull(7) ? r.GetString(7) : "",
                                !r.IsDBNull(8) ? r.GetString(8) : "",
                                !r.IsDBNull(9) ? r.GetInt32(9) : ""
                            );

                        r.Close();
                    }
                    else
                    {
                        dgv.Name = "dgvS";
                        panel3.Controls.Add(dgv);
                        foreach (DataGridViewRow row in wishes.Rows)
                        {
                            string startTimeFormated = str_formater(row.Cells["wStartTimeCol"].Value.ToString(), ":", "."), 
                                endTimeFormated = str_formater(row.Cells["wEndTimeCol"].Value.ToString(), ":", ".");

                            sql = "with sub_group as (select * from groups where " +
                                "discipline_id = (select discipline_id from disciplines where discipline_name = (@disName))) " +
                                "select sg.discipline_name, sg.group_num, sg.num_of_hours, gi.* " +
                                "from sub_group sg join group_info gi on(sg.group_id = gi.group_id) " +
                                "WHERE weekday = (@weekday) AND" +
                                " ((start_time >= (@startTimeFormated) AND start_time < (@endTimeFormated)" +
                                ") OR (end_time >= (@startTimeFormated) AND end_time < (@endTimeFormated)));";

                            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)
                            {
                                Parameters =
                                {
                                    new("disName", disName),
                                    new("weekday", row.Cells["wWeekdayCol"].Value.ToString()),
                                    new("startTimeFormated", startTimeFormated),
                                    new("endTimeFormated", endTimeFormated)
                                }
                            };
                            NpgsqlDataReader r = cmd.ExecuteReader();

                            for (; r.Read();)
                                dgv.Rows.Add(
                                    !r.IsDBNull(0) ? r.GetString(0) : "",
                                    !r.IsDBNull(1) ? r.GetString(1) : "",
                                    !r.IsDBNull(2) ? r.GetInt32(2) : "",
                                    !r.IsDBNull(3) ? r.GetInt32(3) : "",
                                    !r.IsDBNull(4) ? r.GetString(4) : "",
                                    !r.IsDBNull(5) ? r.GetString(5) : "",
                                    !r.IsDBNull(6) ? r.GetString(6) : "",
                                    !r.IsDBNull(7) ? r.GetString(7) : "",
                                    !r.IsDBNull(8) ? r.GetString(8) : "",
                                    !r.IsDBNull(9) ? r.GetInt32(9) : ""
                                );
                            r.Close();
                        }
                    }
                }
            }
        }

        private void cbWish_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            DataGridView dgv = new(), dgvS = new();
            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.DataGridView"))
                {
                    DataGridView dataGridView = ((DataGridView)ctrl);
                    if (dataGridView.Name == "dgv")
                        dgv = dataGridView;
                    else if (dataGridView.Name == "dgvS")
                        dgvS = dataGridView;
                }
            }

            if (cb.Checked)
            {
                dgvS.Visible = true;
                dgv.Visible = false;
            }
            else
            {
                dgvS.Visible = false;
                dgv.Visible = true;
            }
        }

        private void setDisBtn_Click(object sender, EventArgs e)
        {
            Form7 f = new(conn);
            f.setDisBtn.Visible = true;
            f.formName = "Form2";
            f.ShowDialog();
            if(f.chosenDis != "0")
                discipline.Text = f.chosenDis;
        }
    }
}