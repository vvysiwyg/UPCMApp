using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using kursovajaEF.Forms;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using kursovajaEF.Models;
using System.Diagnostics;

namespace kursovajaEF
{
    public partial class Form1 : AdvancedForm
    {
        private NpgsqlConnection conn;
        private DataGridViewCell currentCellDgv2;
        private DataGridViewCell currentCellDgv3;
        private DataGridViewCell currentCellDgv4;
        private Dictionary<int, DataGridViewRow> notExpelledListenersDictionary;
        public Form1()
        {
            notExpelledListenersDictionary = new();
            using (testDBContext db = new())
            {
                conn = new NpgsqlConnection(db.connectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            InitializeComponent();
        }

        private void fetch()
        {
            int it = 0;
            using (testDBContext db = new())
            {
                var l_s = db.Listeners.AsNoTracking();
                var с_ci_leno_lexo_s = db.Contracts.
                    Include(i => i.ContractInfos).
                    Include(i => i.ListenerEnrollmentOrders).
                    Include(i => i.ListenerExpulsionOrders).
                    Select(s => new 
                    {
                        Crn = s.Crn,
                        TotalSum = s.TotalSum,
                        PayedSum = s.PayedSum,
                        RestOfSum = s.RestOfSum,
                        PayDate40pct = s.PayDate40pct,
                        PaymentDeadline = s.PaymentDeadline,
                        WhoPay = s.WhoPay,
                        ExpulsionDate = s.ExpulsionDate,
                        ListenedHours = s.ListenedHours,
                        TransferGroup = s.TransferGroup,
                        Certificate = s.Certificate,
                        IssueCertificate = s.IssueCertificate,
                        Bank = s.Bank,
                        ContractId = s.ContractId,
                        ListenerId = s.ListenerId,
                        ContractInfo = s.ContractInfos.Select(s2 => new 
                            {
                                DisciplineName = s2.DisciplineName,
                                StudyHours = s2.StudyHours,
                                NumOfPeople = s2.NumOfPeople,
                                DisciplineId = s2.DisciplineId,
                                ContractInfoId = s2.ContractInfoId,
                            }),
                        ListenerExpulsionOrder = s.ListenerExpulsionOrders.Select(s3 => new 
                            {
                                Number = s3.Number,
                                Date = s3.Date
                            }),
                        ListenerEnrollmentOrder = s.ListenerEnrollmentOrders.Select(s3 => new
                            {
                                Number = s3.Number,
                                Date = s3.Date
                            })
                    }).
                    AsNoTracking();
                var g_gi_gicis = db.GroupInfoContractInfos.
                    Include(gici => gici.GroupInfo).
                    ThenInclude(gi => gi.Group).
                    AsNoTracking();
                var w_s = db.ListenerWishes.AsNoTracking();
                foreach (var l in l_s.ToList())
                {
                    dataGridView1.Rows.Add(
                        l.Midname,
                        l.Firstname,
                        l.Lastname != null ? l.Lastname : "",
                        l.Yob,
                        l.Sex,
                        l.PhoneNum,
                        l.Email != null ? l.Email : "",
                        l.SchoolGrade != null ? l.SchoolGrade : "",
                        l.ListenerCategory != null ? l.ListenerCategory : "",
                        l.Matriculation != null ? l.Matriculation : "",
                        l.Id);

                    notExpelledListenersDictionary.Add(l.Id, dataGridView1.Rows[it]);
                    it++;
                }
                it = 0;

                foreach (var с_ci_leno_lexo in с_ci_leno_lexo_s.ToList())
                {
                    var ci = с_ci_leno_lexo.ContractInfo.ToArray()[0];

                    var leno = с_ci_leno_lexo.ListenerEnrollmentOrder.ToArray().Length == 1 ? 
                        с_ci_leno_lexo.ListenerEnrollmentOrder.ToArray()[0]: new 
                        {
                            Number = -1,
                            Date = ""
                        };

                    var lexo = с_ci_leno_lexo.ListenerExpulsionOrder.ToArray().Length == 1 ?
                        с_ci_leno_lexo.ListenerExpulsionOrder.ToArray()[0]: new
                        {
                            Number = -1,
                            Date = ""
                        };

                    dataGridView2.Rows.Add(
                        с_ci_leno_lexo.Crn,
                        с_ci_leno_lexo.TotalSum,
                        с_ci_leno_lexo.PayedSum,
                        с_ci_leno_lexo.RestOfSum != null ? с_ci_leno_lexo.RestOfSum : "",
                        с_ci_leno_lexo.PayDate40pct != null ? с_ci_leno_lexo.PayDate40pct : "",
                        с_ci_leno_lexo.PaymentDeadline != null ? с_ci_leno_lexo.PaymentDeadline : "",
                        с_ci_leno_lexo.WhoPay,
                        с_ci_leno_lexo.ExpulsionDate != null ? с_ci_leno_lexo.ExpulsionDate : "",
                        с_ci_leno_lexo.ListenedHours != null ? с_ci_leno_lexo.ListenedHours : "",
                        с_ci_leno_lexo.TransferGroup != null ? с_ci_leno_lexo.TransferGroup : "",
                        с_ci_leno_lexo.Certificate != null ? с_ci_leno_lexo.Certificate : "",
                        с_ci_leno_lexo.IssueCertificate != null ? с_ci_leno_lexo.IssueCertificate : "",
                        с_ci_leno_lexo.Bank,
                        ci.DisciplineName,
                        ci.StudyHours != null ? ci.StudyHours : "",
                        ci.NumOfPeople,
                        leno.Number != -1 ? leno.Number: "",
                        leno.Date,
                        lexo.Number != -1 ? lexo.Number: "",
                        lexo.Date,
                        с_ci_leno_lexo.ContractId,
                        ci.DisciplineId,
                        ci.ContractInfoId,
                        с_ci_leno_lexo.ListenerId);

                    if (!string.IsNullOrWhiteSpace(с_ci_leno_lexo.ExpulsionDate) &&
                        notExpelledListenersDictionary.ContainsKey((int)с_ci_leno_lexo.ListenerId))
                        notExpelledListenersDictionary.Remove((int)с_ci_leno_lexo.ListenerId);

                    dataGridView2.Rows[it].Visible = false;
                    dataGridView2.Rows[it].Selected = false;
                    it++;
                }
                if (dataGridView2.Rows.Count != 0)
                    currentCellDgv2 = dataGridView2.Rows[0].Cells[0];

                it = 0;
                foreach (var ggigici in g_gi_gicis.ToList())
                {
                    dataGridView3.Rows.Add(
                        ggigici.GroupInfo.Group.GroupNum,
                        ggigici.GroupInfo.Group.NumOfHours != null ? ggigici.GroupInfo.Group.NumOfHours : "",
                        ggigici.GroupInfo.Weekday,
                        ggigici.GroupInfo.StartTime,
                        ggigici.GroupInfo.EndTime,
                        ggigici.GroupInfo.StartLearning,
                        ggigici.GroupInfo.EndLearning,
                        ggigici.GroupInfo.GroupId,
                        ggigici.ContractInfoId,
                        ggigici.GroupInfo.GroupInfoId);
                    dataGridView3.Rows[it].Visible = false;
                    dataGridView3.Rows[it].Selected = false;
                    it++;
                }
                if (dataGridView3.Rows.Count != 0)
                    currentCellDgv3 = dataGridView3.Rows[0].Cells[0];

                it = 0;
                foreach (var w in w_s.ToList())
                {
                    dataGridView4.Rows.Add(
                        w.Weekday,
                        w.StartTime,
                        w.EndTime,
                        w.ContractId,
                        w.WishId);
                    dataGridView4.Rows[it].Visible = false;
                    dataGridView4.Rows[it].Selected = false;
                    it++;
                }
                if (dataGridView4.Rows.Count != 0)
                    currentCellDgv4 = dataGridView4.Rows[0].Cells[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fetch();
            if (dataGridView1.RowCount != 0)
                dataGridView1.Rows[0].Selected = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(conn);
            form.ShowDialog();
            if (form.addingCheck.Text != "0")
            {
                resetForm(new List<DataGridView> {
                    dataGridView1,
                    dataGridView2,
                    dataGridView3,
                    dataGridView4}, new List<GroupBox> {
                    extendedInfoGB,
                    listenerWishesGB});

                fetch();

                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows[0].Selected = true;
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count == 1 || dataGridView1.SelectedCells.Count == 1) &&
                (dataGridView2.SelectedRows.Count == 1 || dataGridView2.SelectedCells.Count == 1))
            {
                string contractInfoId = "";
                DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
                DataGridViewRow selectedRow2 = dataGridView2.SelectedCells[0].OwningRow;
                Form2 fm = new(conn);

                fm.addBtn.Visible = false;
                fm.updBtn.Visible = true;
                fm.endEduBtn.Visible = true;
                fm.addOrderBtn.Visible = true;
                fm.transferGroupBtn.Visible = true;
                fm.addCIBtn.Visible = false;
                fm.addCIBtn2.Visible = true;
                fm.delCIBtn.Visible = false;
                fm.delCIBtn2.Visible = true;
                fm.addWishBtn.Visible = false;
                fm.addWishBtn2.Visible = true;
                fm.delWishBtn.Visible = false;
                fm.delWishBtn2.Visible = true;
                fm.wishes.Visible = true;
                fm.contract_info.Visible = true;
                fm.group_info.Visible = true;
                fm.addingCheck.Text = selectedRow.Cells["listenerIdCol"].Value.ToString();
                fm.contractId.Text = selectedRow2.Cells["contractIdCol"].Value.ToString();
                fm.midname.Text = selectedRow.Cells["midnameCol"].Value.ToString();
                fm.firstname.Text = selectedRow.Cells["firstnameCol"].Value.ToString();
                fm.lastname.Text = selectedRow.Cells["lastnameCol"].Value.ToString();
                fm.yob.Text = selectedRow.Cells["yobCol"].Value.ToString();
                
                if (selectedRow.Cells["sexCol"].Value.ToString() == "Ж")
                    fm.sexF.Checked = true;
                else fm.sexM.Checked = true;

                if (selectedRow.Cells["matriculationCol"].Value.ToString() == "Да")
                    fm.yes.Checked = true;
                else fm.no.Checked = true;

                fm.phoneNum.Text = selectedRow.Cells["phoneNumCol"].Value.ToString();
                fm.schoolGrade.Text = selectedRow.Cells["schoolGradeCol"].Value.ToString();
                fm.email.Text = selectedRow.Cells["emailCol"].Value.ToString();
                fm.listenerCategory.Text = selectedRow.Cells["listenerCategoryCol"].Value.ToString();

                if(fm.listenerCategory.Text != "Школьник")
                {
                    fm.label8.Visible = false;
                    fm.schoolGrade.Visible = false;
                }

                fm.crn.Text = selectedRow2.Cells["crnCol"].Value.ToString();
                fm.totalSum.Text = selectedRow2.Cells["totalSumCol"].Value.ToString();
                fm.payedSum.Text = selectedRow2.Cells["payedSumCol"].Value.ToString();
                fm.PayDate40pct.Text = selectedRow2.Cells["PayDate40pctCol"].Value.ToString();
                fm.restOfSum.Text = selectedRow2.Cells["restOfSumCol"].Value.ToString();
                fm.whoPay.Text = selectedRow2.Cells["whoPayCol"].Value.ToString();
                fm.paymentDeadline.Text = selectedRow2.Cells["paymentDeadlineCol"].Value.ToString();
                fm.bank.Text = selectedRow2.Cells["bankCol"].Value.ToString();

                using (testDBContext db = new())
                {
                    try
                    {
                        var wishes = from Lw in db.ListenerWishes
                                     where Lw.ContractId == int.Parse(fm.contractId.Text)
                                     select new { Lw.WishId, Lw.Weekday, Lw.StartTime, Lw.EndTime };

                        foreach (var wish in wishes.ToList())
                            fm.wishes.Rows.Add(wish.WishId, wish.Weekday, wish.StartTime, wish.EndTime, fm.contractId.Text);
                    }
                    catch(InvalidOperationException ioe)
                    {
                        
                    }

                    fm.contract_info.Rows.Add(selectedRow2.Cells["disciplineNameCol"].Value.ToString(),
                                selectedRow2.Cells["studyHoursCol"].Value.ToString(),
                                selectedRow2.Cells["numOfPeopleCol"].Value.ToString(),
                                selectedRow2.Cells["contractInfoIdCol"].Value.ToString());

                    contractInfoId = selectedRow2.Cells["contractInfoIdCol"].Value.ToString();

                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        if (contractInfoId == row.Cells["contractInfoIdCol2"].Value.ToString())
                        {
                            fm.group_info.Rows.Add(row.Cells["groupNumCol"].Value.ToString(),
                                row.Cells["numOfHoursCol"].Value.ToString(),
                                row.Cells["groupInfoIdCol"].Value.ToString(),
                                row.Cells["weekdayCol"].Value.ToString(),
                                row.Cells["startTimeCol"].Value.ToString(),
                                row.Cells["endTimeCol"].Value.ToString(),
                                row.Cells["startLearningCol"].Value.ToString(),
                                row.Cells["endLearningCol"].Value.ToString(),
                                row.Cells["groupIdCol"].Value.ToString(),
                                row.Cells["contractInfoIdCol2"].Value.ToString());

                            fm.group_info.Rows[fm.group_info.Rows.Count - 1].Visible = false;
                            fm.group_info.Rows[fm.group_info.Rows.Count - 1].Selected = false;
                        }
                    }
                }
                fm.ShowDialog();
                if (fm.updatingCheck.Text == "1") {
                    resetForm(new List<DataGridView> {
                    dataGridView1,
                    dataGridView2,
                    dataGridView3,
                    dataGridView4}, new List<GroupBox> {
                    extendedInfoGB,
                    listenerWishesGB});

                    fetch();
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form form;
            string nodeTxt = e.Node.Text;
            switch (nodeTxt)
            {
                case "Подразделения":
                    form = new Form5();
                    break;
                case "Программы":
                    form = new Form7(conn);
                    break;
                case "Преподаватели":
                    form = new Form9(conn);
                    break;
                case "Расписания":
                    form = new Form11(conn);
                    break;
                case "Договоры":
                    form = new Form13(conn);
                    break;
                case "Группы":
                    form = new Form15(conn);
                    break;
                case "Слушатели":
                    form = new Form3(conn);
                    break;
                default:
                    return;
            }
            Hide();
            form.ShowDialog();
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
                bool flag = false;
                SuspendLayout();
                for (int i = 0; i < 10; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[i].Value.ToString();
                }

                for (int i = 10; i < 37; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = string.Empty;
                }

                for(int i = 0; i < 3; i++)
                {
                    TextBox tb = (TextBox)listenerWishesGB.Controls[i];
                    tb.Text = string.Empty;
                }

                foreach(DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["listenerIdCol2"].Value.ToString() == selectedRow.Cells["listenerIdCol"].Value.ToString())
                    {
                        row.Visible = true;
                        if (!flag)
                        {
                            flag = true;
                            if (currentCellDgv2 != null)
                                currentCellDgv2.Selected = false;
                            currentCellDgv2 = row.Cells[0];
                        }
                    }
                    else
                        row.Visible = false;
                }

                if (!flag)
                {
                    if (currentCellDgv2 != null)
                        currentCellDgv2.Selected = false;
                    currentCellDgv2 = null;
                }

                if (dataGridViewVisibleRowCount(dataGridView2, dataGridView2.Rows.Count - 1) == 0)
                {
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                        row.Visible = false;

                    foreach (DataGridViewRow row in dataGridView4.Rows)
                        row.Visible = false;
                }
                else
                {
                    currentCellDgv2.Selected = true;
                    dataGridView2_CellClick(dataGridView2, e);
                }

                extendedInfoGB.Text = midname.Text;
                extendedInfoGB.Visible = true;
                listenerWishesGB.Visible = true;
                ResumeLayout();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 1)
            {
                int index = 0;
                bool flag = false;
                DataGridViewRow selectedRow = dataGridView2.SelectedCells[0].OwningRow;
                currentCellDgv2 = dataGridView2.SelectedCells[0];

                for (int i = 10; i < 30; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }

                for (int i = 30; i < 37; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = string.Empty;
                }

                for (int i = 0; i < 3; i++)
                {
                    TextBox tb = (TextBox)listenerWishesGB.Controls[i];
                    tb.Text = string.Empty;
                }


                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells["contractInfoIdCol2"].Value.ToString() == selectedRow.Cells["contractInfoIdCol"].Value.ToString())
                    {
                        row.Visible = true;
                        if (!flag)
                        {
                            flag = true;
                            currentCellDgv3.Selected = false;
                            currentCellDgv3 = row.Cells[0];
                        }
                    }
                    else
                        row.Visible = false;
                }

                flag = false;

                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    if (row.Cells["contractIdCol3"].Value.ToString() == selectedRow.Cells["contractIdCol"].Value.ToString())
                    {
                        row.Visible = true;
                        if (!flag)
                        {
                            flag = true;
                            currentCellDgv4.Selected = false;
                            currentCellDgv4 = row.Cells[0];
                        }
                    }
                    else
                        row.Visible = false;
                }

                if (dataGridViewVisibleRowCount(dataGridView3, dataGridView3.Rows.Count - 1) != 0)
                {
                    currentCellDgv3.Selected = true;
                    dataGridView3_CellClick(dataGridView3, e);
                }

                if (dataGridViewVisibleRowCount(dataGridView4, dataGridView4.Rows.Count - 1) != 0)
                {
                    currentCellDgv4.Selected = true;
                    dataGridView4_CellClick(dataGridView4, e);
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 1)
            {
                int index = 0;
                DataGridViewRow selectedRow = dataGridView3.SelectedCells[0].OwningRow;

                for (int i = 30; i < 37; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedCells.Count == 1)
            {
                int index = 0;
                DataGridViewRow selectedRow = dataGridView4.SelectedCells[0].OwningRow;
                currentCellDgv4 = dataGridView4.SelectedCells[0];

                for (int i = 0; i < 3; i++)
                {
                    TextBox tb = (TextBox)listenerWishesGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellClick(sender, e);
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3_CellClick(sender, e);
        }

        private void dataGridView4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4_CellClick(sender, e);
        }

        private void listenerFilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuspendLayout();

            if (listenerFilterCB.Text == "Все слушатели")
                showAllRows(dataGridView1, dataGridView1.Rows.Count - 1);
            else
            {
                foreach (DataGridViewRow row in notExpelledListenersDictionary.Values)
                    row.Visible = false;
            }

            ResumeLayout();
        }

        private void newContractBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 || dataGridView1.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
                Form2 fm = new Form2(conn);

                fm.updatingCheck.Text = selectedRow.Cells["listenerIdCol"].Value.ToString();
                fm.midname.Text = selectedRow.Cells["midnameCol"].Value.ToString();
                fm.firstname.Text = selectedRow.Cells["firstnameCol"].Value.ToString();
                fm.lastname.Text = selectedRow.Cells["lastnameCol"].Value.ToString();
                fm.yob.Text = selectedRow.Cells["yobCol"].Value.ToString();

                if (selectedRow.Cells["sexCol"].Value.ToString() == "Ж")
                    fm.sexF.Checked = true;
                else fm.sexM.Checked = true;

                if (selectedRow.Cells["matriculationCol"].Value.ToString() == "Да")
                    fm.yes.Checked = true;
                else fm.no.Checked = true;

                fm.phoneNum.Text = selectedRow.Cells["phoneNumCol"].Value.ToString();
                fm.schoolGrade.Text = selectedRow.Cells["schoolGradeCol"].Value.ToString();
                fm.email.Text = selectedRow.Cells["emailCol"].Value.ToString();
                fm.listenerCategory.Text = selectedRow.Cells["listenerCategoryCol"].Value.ToString();

                if (fm.listenerCategory.Text != "Школьник")
                {
                    fm.label8.Visible = false;
                    fm.schoolGrade.Visible = false;
                }

                fm.ShowDialog();
                if (fm.addingCheck.Text != "0")
                {
                    resetForm(new List<DataGridView> {
                    dataGridView1,
                    dataGridView2,
                    dataGridView3,
                    dataGridView4}, new List<GroupBox> {
                    extendedInfoGB,
                    listenerWishesGB});

                    fetch();

                    if (dataGridView1.RowCount != 0)
                        dataGridView1.Rows[0].Selected = true;
                }
            }
            else MessageBox.Show("Для добавления нового договора необходимо выбрать слушателя, которому будет добавлен договор.");
        }
    }
}
