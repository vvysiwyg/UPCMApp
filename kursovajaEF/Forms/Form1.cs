using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using kursovajaEF.Forms;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using kursovajaEF.Models;

namespace kursovajaEF
{
    public partial class Form1 : AdvancedForm
    {
        private NpgsqlConnection conn;
        private DataGridViewCell currentCellDgv2;
        private DataGridViewCell currentCellDgv3;
        private DataGridViewCell currentCellDgv4;
        public Form1()
        {
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
                var l_cs = db.Listeners.Include(l => l.Contract).AsNoTracking();
                var ci_s = db.ContractInfos.AsNoTracking();
                var g_gi_gicis = db.GroupInfoContractInfos.Include(gici => gici.GroupInfo).ThenInclude(gi => gi.Group).AsNoTracking();
                var w_s = db.ListenerWishes.AsNoTracking();

                foreach (var lc in l_cs.ToList())
                    dataGridView1.Rows.Add(
                        lc.Midname,
                        lc.Firstname,
                        lc.Lastname,
                        lc.Yob,
                        lc.Sex,
                        lc.PhoneNum,
                        lc.Email != null ? lc.Email : "",
                        lc.SchoolGrade,
                        lc.ListenerCategory,
                        lc.Contract.Crn,
                        lc.Contract.TotalSum,
                        lc.Contract.PayedSum,
                        lc.Contract.RestOfSum,
                        lc.Contract.PayDate40pct != null ? lc.Contract.PayDate40pct : "",
                        lc.Contract.PaymentDeadline != null ? lc.Contract.PaymentDeadline : "",
                        lc.Contract.WhoPay,
                        lc.Matriculation,
                        lc.Contract.ExpulsionDate != null ? lc.Contract.ExpulsionDate : "",
                        lc.Contract.ListenedHours != null ? lc.Contract.ListenedHours : "",
                        lc.Contract.TransferGroup != null ? lc.Contract.TransferGroup : "",
                        lc.Contract.Certificate != null ? lc.Contract.Certificate : "",
                        lc.Contract.IssueCertificate != null ? lc.Contract.IssueCertificate : "",
                        lc.Contract.Bank != null ? lc.Contract.Bank : "",
                        lc.Id,
                        lc.ContractId);

                foreach (var ci in ci_s.ToList())
                {
                    dataGridView2.Rows.Add(
                        ci.DisciplineName,
                        ci.NumOfPeople,
                        ci.StudyHours != null ? ci.StudyHours : "",
                        ci.ContractId,
                        ci.DisciplineId,
                        ci.ContractInfoId);
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
            //string sql = "SELECT * FROM main_info;";
            //NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            //NpgsqlDataReader r = cmd.ExecuteReader();

            //for(; r.Read();)
            //    dataGridView1.Rows.Add(
            //        !r.IsDBNull(0) ? r.GetString(0) : "",
            //        !r.IsDBNull(1) ? r.GetString(1) : "",
            //        !r.IsDBNull(2) ? r.GetString(2) : "",
            //        !r.IsDBNull(3) ? r.GetString(3) : "",
            //        !r.IsDBNull(4) ? r.GetString(4) : "",
            //        !r.IsDBNull(5) ? r.GetDecimal(5) : "",
            //        !r.IsDBNull(6) ? r.GetString(6) : "",
            //        !r.IsDBNull(7) ? r.GetString(7) : "",
            //        !r.IsDBNull(8) ? r.GetString(8) : "",
            //        !r.IsDBNull(9) ? r.GetDecimal(9) : "",
            //        !r.IsDBNull(10) ? r.GetDecimal(10) : "",
            //        !r.IsDBNull(11) ? r.GetDecimal(11) : "",
            //        !r.IsDBNull(12) ? r.GetString(12) : "",
            //        !r.IsDBNull(13) ? r.GetString(13) : "",
            //        !r.IsDBNull(14) ? r.GetString(14) : "",
            //        !r.IsDBNull(15) ? r.GetString(15) : "",
            //        !r.IsDBNull(16) ? r.GetString(16) : "",
            //        !r.IsDBNull(17) ? r.GetString(17) : "",
            //        !r.IsDBNull(18) ? r.GetString(18) : "",
            //        !r.IsDBNull(19) ? r.GetInt16(19) : "",
            //        !r.IsDBNull(20) ? r.GetInt32(20) : "",
            //        !r.IsDBNull(21) ? r.GetString(21) : "",
            //        !r.IsDBNull(22) ? r.GetString(22) : "",
            //        !r.IsDBNull(23) ? r.GetString(23) : "",
            //        !r.IsDBNull(24) ? r.GetString(24) : "",
            //        !r.IsDBNull(25) ? r.GetString(25) : "",
            //        !r.IsDBNull(26) ? r.GetString(26) : "",
            //        !r.IsDBNull(27) ? r.GetString(27) : "",
            //        !r.IsDBNull(28) ? r.GetString(28) : "",
            //        !r.IsDBNull(29) ? r.GetString(29) : "",
            //        !r.IsDBNull(30) ? r.GetInt16(30) : "",
            //        !r.IsDBNull(31) ? r.GetInt32(31) : "",
            //        !r.IsDBNull(32) ? r.GetInt32(32) : "",
            //        !r.IsDBNull(33) ? r.GetInt32(33) : "",
            //        !r.IsDBNull(34) ? r.GetInt32(34) : "",
            //        !r.IsDBNull(35) ? r.GetInt32(35) : "",
            //        !r.IsDBNull(36) ? r.GetInt32(36) : "");
            //r.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                //var result = from c in db.Contracts
                //             join ci in db.ContractInfos on c.ContractId equals ci.ContractId
                //             into lj
                //             from leftJoin in lj.DefaultIfEmpty()
                //             select new
                //             {
                //                 C = c,
                //                 Ci = leftJoin
                //             };
                //foreach(var el in result)
                //{
                //    dataGridView1.Rows.Add(
                //        el.C.Crn);
                //}

                fetch();
                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows[0].Selected = true;

                //var res = from l in db.Listeners
                //          join gil in db.GroupInfoListeners on l.Id equals gil.ListenerId
                //          into lj1
                //          from leftJoin1 in lj1.DefaultIfEmpty()
                //          join gi in db.GroupInfos on leftJoin1.GroupInfoId equals gi.GroupInfoId
                //          into lj2
                //          from leftJoin2 in lj2.DefaultIfEmpty()
                //          join g in db.Groups on leftJoin2.GroupId equals g.GroupId
                //          into lj3
                //          from leftJoin3 in lj3.DefaultIfEmpty()
                //          join c in db.Contracts on l.ContractId equals c.ContractId
                //          into lj4
                //          from leftJoin4 in lj4.DefaultIfEmpty()
                //          join ci in db.ContractInfos on leftJoin3.SubjectId equals ci.SubjectId
                //          into lj5
                //          from leftJoin5 in lj5.DefaultIfEmpty()
                //          where leftJoin4.ContractId == leftJoin5.ContractId
                //          orderby l.Firstname, l.Midname, l.Lastname
                //          select new
                //          {
                //              L = l,
                //              Gil = leftJoin1,
                //              Gi = leftJoin2,
                //              G = leftJoin3,
                //              C = leftJoin4,
                //              Ci = leftJoin5,
                //          };

                //var res1 = from l in db.Listeners
                //           join gil in db.GroupInfoListeners on l.Id equals gil.ListenerId
                //           into lj1
                //           from leftJoin1 in lj1.DefaultIfEmpty()
                //           select new
                //           {
                //               L = l,
                //               Gil = leftJoin1
                //           };
                //var res2 = from r in res1
                //           join gi in db.GroupInfos on r.Gil.GroupInfoId equals gi.GroupInfoId
                //           into lj2
                //           from leftJoin2 in lj2.DefaultIfEmpty()
                //           select new
                //           {
                //               L = r.L,
                //               Gil = r.Gil,
                //               Gi = (leftJoin2 == null ? new GroupInfo(): leftJoin2)
                //           };
                //var res3 = from r in res2
                //           join g in db.Groups on r.Gi.GroupId equals g.GroupId
                //           into lj3
                //           from leftJoin3 in lj3.DefaultIfEmpty()
                //           select new
                //           {
                //               L = r.L,
                //               Gil = r.Gil,
                //               Gi = r.Gi,
                //               G = leftJoin3
                //           };
                //var res4 = from r in res3
                //           join c in db.Contracts on r.L.ContractId equals c.ContractId
                //           into lj4
                //           from leftJoin4 in lj4.DefaultIfEmpty()
                //           select new
                //           {
                //               L = r.L,
                //               Gil = r.Gil,
                //               Gi = r.Gi,
                //               G = r.G,
                //               C = (leftJoin4 == null ? new Contract(): leftJoin4)
                //           };
                //var res = from r in res4
                //          join ci in db.ContractInfos on
                //          r.G.SubjectId equals ci.SubjectId
                //          into lj5
                //          from leftJoin5 in (from ci in lj5
                //                             where ci.ContractId == r.C.ContractId
                //                             select ci).DefaultIfEmpty()
                //          orderby r.L.Firstname, r.L.Midname, r.L.Lastname
                //          select new
                //          {
                //              L = r.L,
                //              Gil = r.Gil,
                //              Gi = r.Gi,
                //              G = r.G,
                //              C = r.C,
                //              Ci = (leftJoin5 == null ? new ContractInfo(): leftJoin5),
                //          };

                //var res = db.GroupInfoListeners
                //    .Include(gi => gi.GroupInfo)
                //    .ThenInclude(g => g.Group)
                //    .Include(l => l.Listener)
                //    .ThenInclude(c => c.Contract)
                //    .ThenInclude(ci => ci.ContractInfos);
                //foreach(var el in res)
                //{
                //    dataGridView1.Rows.Add(
                //        el.Listener.Midname);
                //}

                //var res = db.Listeners.FromSqlRaw("select l.midname, l.firstname, l.lastname, l.yob, l.sex, l.pob, " +
                //    "l.series, l.num, l.issued, l.code, l.doi, l.phone_num, l.email, l.school_name, l.school_grade," +
                //    " c.crn, c.total_sum, c.payed_sum, c.rest_of_sum, c.pay_date_40pct, c.payment_deadline, c.who_pay," +
                //    " g.discipline_name, ci.subject_name, gi.start_learning, gi.end_learning, g.group_num, ci.num_of_people," +
                //    " g.num_of_hours, gi.weekday, gi.start_time, gi.end_time, l.matriculation, c.expulsion_date," +
                //    " c.listened_hours, c.transfer_group, c.certificate, c.issue_certificate, ci.study_hours, l.id," +
                //    " c.contract_id, g.group_id, g.subject_id, g.discipline_id, ci.contract_info_id, gi.group_info_id" +
                //    "  from listeners l left join group_info_listeners gil on (l.id = gil.listener_id) left join group_info" +
                //    " gi on (gil.group_info_id = gi.group_info_id) left join groups g on (gi.group_id = g.group_id)" +
                //    " left join contracts c on (l.contract_id = c.contract_id) left join contract_info ci on" +
                //    " (g.subject_id = ci.subject_id and c.contract_id = ci.contract_id)" +
                //    " order by firstname, midname, lastname;").ToList();
                //foreach(var el in res)
                //{
                //    dataGridView1.Rows.Add(el.Midname);
                //}

                //foreach (var element in res)
                //{
                //    dataGridView1.Rows.Add(
                //        element.L.Midname,
                //        element.L.Firstname,
                //        element.L.Lastname,
                //        element.L.Yob,
                //        element.L.Sex,
                //        element.L.PhoneNum,
                //        element.L.Email,
                //        element.L.SchoolGrade,
                //        element.C.Crn,
                //        element.C.TotalSum,
                //        element.C.PayedSum,
                //        element.C.RestOfSum,
                //        element.C.PayDate40pct,
                //        element.C.PaymentDeadline,
                //        element.C.WhoPay,
                //        element.G.DisciplineName,
                //        element.Ci.SubjectName,
                //        element.Gi.StartLearning,
                //        element.Gi.EndLearning,
                //        element.G.GroupNum,
                //        element.Ci.NumOfPeople,
                //        element.G.NumOfHours,
                //        element.Gi.Weekday,
                //        element.Gi.StartTime,
                //        element.Gi.EndTime,
                //        element.L.Matriculation,
                //        element.C.ExpulsionDate,
                //        element.C.ListenedHours,
                //        element.C.TransferGroup,
                //        element.C.Certificate,
                //        element.C.IssueCertificate,
                //        element.Ci.StudyHours,
                //        element.L.Id,
                //        element.C.ContractId,
                //        element.G.GroupId,
                //        element.G.SubjectId,
                //        element.G.DisciplineId,
                //        element.Ci.ContractInfoId,
                //        element.Gi.GroupInfoId);
                //}


                //var result = db.Listeners.LeftJoin(
                //    db.GroupInfoListeners,
                //    l => l.Id,
                //    gil => gil.ListenerId,
                //    (l, gil) => new
                //    {
                //        lID = l.Id,
                //        lFN = l.Firstname,
                //        lMN = l.Midname,
                //        lLN = l.Lastname,
                //        lYob = l.Yob,
                //        lSex = l.Sex,
                //        lPob = l.Pob,
                //        lSeries = l.Series,
                //        lNum = l.Num,
                //        lIssued = l.Issued,
                //        lCode = l.Code,
                //        lDoi = l.Doi,
                //        lMatriculation = l.Matriculation,
                //        lPN = l.PhoneNum,
                //        lSN = l.SchoolName,
                //        lSG = l.SchoolGrade,
                //        lEmail = l.Email,
                //        gilGIID = gil.GroupInfoId
                //    }).LeftJoin(
                //    db.GroupInfos,
                //    gil => gil.gilGIID,
                //    gi => gi.GroupInfoId,
                //    (gil, gi) => new
                //    {

                //    })
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
            if (dataGridView1.SelectedRows.Count == 1 || dataGridView1.SelectedCells.Count == 1)
            {
                List<string> contractInfoIdList = new();
                DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
                Form2 fm = new(conn);

                fm.addBtn.Visible = false;
                fm.updBtn.Visible = true;
                fm.endEduBtn.Visible = true;
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
                fm.contractId.Text = selectedRow.Cells["contractIdCol"].Value.ToString();
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

                fm.crn.Text = selectedRow.Cells["crnCol"].Value.ToString();
                fm.totalSum.Text = selectedRow.Cells["totalSumCol"].Value.ToString();
                fm.payedSum.Text = selectedRow.Cells["payedSumCol"].Value.ToString();
                fm.PayDate40pct.Text = selectedRow.Cells["PayDate40pctCol"].Value.ToString();
                fm.restOfSum.Text = selectedRow.Cells["restOfSumCol"].Value.ToString();
                fm.whoPay.Text = selectedRow.Cells["whoPayCol"].Value.ToString();
                fm.paymentDeadline.Text = selectedRow.Cells["paymentDeadlineCol"].Value.ToString();
                fm.bank.Text = selectedRow.Cells["bankCol"].Value.ToString();

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

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["contractIdCol2"].Value.ToString() == selectedRow.Cells["contractIdCol"].Value.ToString())
                        {
                            fm.contract_info.Rows.Add(row.Cells["disciplineNameCol"].Value.ToString(),
                                        row.Cells["studyHoursCol"].Value.ToString(),
                                        row.Cells["numOfPeopleCol"].Value.ToString(),
                                        row.Cells["contractInfoIdCol"].Value.ToString());

                            contractInfoIdList.Add(row.Cells["contractInfoIdCol"].Value.ToString());
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        if (contractInfoIdList.Contains(row.Cells["contractInfoIdCol2"].Value.ToString()))
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && 
                !string.IsNullOrWhiteSpace(dataGridView1.SelectedRows[0].Cells["contractInfoIdCol"].Value.ToString()) &&
                !string.IsNullOrWhiteSpace(dataGridView1.SelectedRows[0].Cells["groupInfoIdCol"].Value.ToString()))
            {
                int count = 0;
                string contractInfoId = dataGridView1.SelectedRows[0].Cells["contractInfoIdCol"].Value.ToString();

                foreach(DataGridViewRow row in dataGridView1.Rows)
                    if (row.Cells["contractInfoIdCol"].Value.ToString() == contractInfoId)
                        count++;
                using (testDBContext db = new()) 
                {
                    if (count == 1)
                    {
                        ContractInfo ci = db.ContractInfos.Find(int.Parse(contractInfoId));
                        db.Remove(ci);
                    }
                    var gici = db.GroupInfoContractInfos.
                    Where(f => f.GroupInfoId == int.Parse(dataGridView1.SelectedRows[0].Cells["groupInfoIdCol"].Value.ToString())).
                    Where(s => s.ContractInfoId == int.Parse(dataGridView1.SelectedRows[0].Cells["contractInfoIdCol"].Value.ToString()));

                    db.Remove(gici.FirstOrDefault());
                    db.SaveChanges();
                }

                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
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
                for (int i = 0; i < 23; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[i].Value.ToString();
                }

                for (int i = 23; i < 33; i++)
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
                    if (row.Cells["contractIdCol2"].Value.ToString() == selectedRow.Cells["contractIdCol"].Value.ToString())
                    {
                        row.Visible = true;
                        if (!flag)
                        {
                            flag = true;
                            currentCellDgv2.Selected = false;
                            currentCellDgv2 = row.Cells[0];
                        }
                    }
                    else
                        row.Visible = false;
                }

                flag = false;

                foreach(DataGridViewRow row in dataGridView4.Rows)
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

                if (dataGridViewVisibleRowCount(dataGridView2, dataGridView2.Rows.Count - 1) == 0)
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                        row.Visible = false;
                else
                {
                    currentCellDgv2.Selected = true;
                    dataGridView2_CellClick(dataGridView2, e);
                }

                if (dataGridViewVisibleRowCount(dataGridView4, dataGridView4.Rows.Count - 1) != 0)
                {
                    currentCellDgv4.Selected = true;
                    dataGridView4_CellClick(dataGridView4, e);
                }

                extendedInfoGB.Text = midname.Text;
                extendedInfoGB.Visible = true;
                listenerWishesGB.Visible = true;
                ResumeLayout();
                //int index = 0;
                //DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;

                //foreach (Control c in extendedInfoGB.Controls)
                //    if(c.GetType().ToString() == "System.Windows.Forms.TextBox")
                //    {
                //        TextBox tb = (TextBox)c;
                //        tb.Text = selectedRow.Cells[index].Value.ToString();
                //        index++;
                //    }

                //extendedInfoGB.Text = midname.Text;
                //extendedInfoGB.Visible = true;
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

                for (int i = 23; i < 26; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                    tb.Text = selectedRow.Cells[index].Value.ToString();
                    index++;
                }

                for (int i = 26; i < 33; i++)
                {
                    TextBox tb = (TextBox)extendedInfoGB.Controls[i];
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

                if (dataGridViewVisibleRowCount(dataGridView3, dataGridView3.Rows.Count - 1) != 0)
                {
                    currentCellDgv3.Selected = true;
                    dataGridView3_CellClick(dataGridView3, e);
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 1)
            {
                int index = 0;
                DataGridViewRow selectedRow = dataGridView3.SelectedCells[0].OwningRow;

                for (int i = 26; i < 33; i++)
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
                showAllListeners(dataGridView1, dataGridView1.Rows.Count - 1);
            else
                showExpelledListeners(dataGridView1, dataGridView1.Rows.Count - 1);

            ResumeLayout();
        }
    }
}
