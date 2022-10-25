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
                var l_cs = db.Listeners.Include(l => l.Contract);
                var ci_s = db.ContractInfos;
                var g_gi_gicis = db.GroupInfoContractInfos.Include(gici => gici.GroupInfo).ThenInclude(gi => gi.Group);

                foreach (var lc in l_cs.ToList())
                    dataGridView1.Rows.Add(
                        lc.Midname,
                        lc.Firstname,
                        lc.Lastname,
                        lc.Yob,
                        lc.Sex,
                        lc.PhoneNum,
                        lc.Email,
                        lc.SchoolGrade,
                        lc.Contract.Crn,
                        lc.Contract.TotalSum,
                        lc.Contract.PayedSum,
                        lc.Contract.RestOfSum,
                        lc.Contract.PayDate40pct,
                        lc.Contract.PaymentDeadline,
                        lc.Contract.WhoPay,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        lc.Id,
                        lc.ContractId);

                foreach (var ci in ci_s.ToList())
                {
                    dataGridView2.Rows.Add(
                        ci.DisciplineName,
                        ci.NumOfPeople,
                        ci.StudyHours,
                        ci.ContractId,
                        ci.DisciplineId,
                        ci.ContractInfoId);
                    dataGridView2.Rows[it].Visible = false;
                    it++;
                }

                it = 0;
                foreach (var ggigici in g_gi_gicis.ToList())
                {
                    dataGridView3.Rows.Add(
                        ggigici.GroupInfo.Group.GroupNum,
                        ggigici.GroupInfo.Group.NumOfHours,
                        ggigici.GroupInfo.Weekday,
                        ggigici.GroupInfo.StartTime,
                        ggigici.GroupInfo.EndTime,
                        ggigici.GroupInfo.StartLearning,
                        ggigici.GroupInfo.EndLearning,
                        ggigici.GroupInfo.GroupId,
                        ggigici.ContractInfoId,
                        ggigici.GroupInfo.GroupInfoId);
                    dataGridView3.Rows[it].Visible = false;
                    it++;
                }
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
                dataGridView1.Rows.Clear();
                fetch();
                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows[0].Selected = true;
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 fm = new(conn);
                foreach (DataGridViewColumn col in fm.contract_info.Columns)
                    if (col.Name != "contractInfoIdCol" && col.Name != "groupInfoIdCol" && col.Name != "groupIdCol")
                        col.Visible = true;

                fm.addBtn.Visible = false;
                fm.updBtn.Visible = true;
                fm.endEduBtn.Visible = true;
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
                fm.addingCheck.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["listenerIdCol"].Value.ToString();
                fm.contractId.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["contractIdCol"].Value.ToString();
                fm.midname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["midnameCol"].Value.ToString();
                fm.firstname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["firstnameCol"].Value.ToString();
                fm.lastname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["lastnameCol"].Value.ToString();
                fm.yob.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["yobCol"].Value.ToString();
                
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["sexCol"].Value.ToString() == "Ж")
                    fm.sexF.Checked = true;
                else fm.sexM.Checked = true;

                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["matriculationCol"].Value.ToString() == "Да")
                    fm.yes.Checked = true;
                else fm.no.Checked = true;

                fm.phoneNum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["phoneNumCol"].Value.ToString();
                fm.schoolGrade.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["schoolGradeCol"].Value.ToString();
                fm.email.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["emailCol"].Value.ToString();
                fm.crn.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["crnCol"].Value.ToString();
                fm.totalSum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["totalSumCol"].Value.ToString();
                fm.payedSum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["payedSumCol"].Value.ToString();
                fm.PayDate40pct.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["PayDate40pctCol"].Value.ToString();
                fm.transferGroup.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["transferGroupCol"].Value.ToString();
                fm.restOfSum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["restOfSumCol"].Value.ToString();
                fm.whoPay.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["whoPayCol"].Value.ToString();
                fm.paymentDeadline.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["paymentDeadlineCol"].Value.ToString();

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

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["listenerIdCol"].Value.ToString() == dataGridView1.SelectedRows[0].Cells["listenerIdCol"].Value.ToString()
                            && !string.IsNullOrWhiteSpace(row.Cells["contractInfoIdCol"].Value.ToString())
                            && !string.IsNullOrWhiteSpace(row.Cells["groupInfoIdCol"].Value.ToString()))
                            fm.contract_info.Rows.Add(row.Cells["disciplineNameCol"].Value.ToString(),
                                row.Cells["studyHoursCol"].Value.ToString(),
                                row.Cells["numOfPeopleCol"].Value.ToString(),
                                row.Cells["contractInfoIdCol"].Value.ToString(),
                                row.Cells["groupNumCol"].Value.ToString(),
                                row.Cells["numOfHoursCol"].Value.ToString(),
                                row.Cells["groupInfoIdCol"].Value.ToString(),
                                row.Cells["weekdayCol"].Value.ToString(),
                                row.Cells["startTimeCol"].Value.ToString(),
                                row.Cells["endTimeCol"].Value.ToString(),
                                row.Cells["startLearningCol"].Value.ToString(),
                                row.Cells["endLearningCol"].Value.ToString(),
                                row.Cells["groupIdCol"].Value.ToString());
                    }
                }
                fm.ShowDialog();
                if (fm.updatingCheck.Text == "1") {
                    dataGridView1.Rows.Clear();

                    fetch();

                    if (dataGridView1.RowCount != 0)
                        dataGridView1.Rows[0].Selected = true;
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
                int index = 0;
                DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
                for (int i = 0; i < 26; i++)
                    if(extendedInfoGB.Controls[i].GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                        tb.Text = selectedRow.Cells[index].Value.ToString();
                        index++;
                    }

                for (int i = 26; i < 58; i++)
                    if (extendedInfoGB.Controls[i].GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                        tb.Text = string.Empty;
                    }

                foreach(DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["contractIdCol2"].Value.ToString() == selectedRow.Cells["contractIdCol"].Value.ToString())
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

                extendedInfoGB.Text = midname.Text;
                extendedInfoGB.Visible = true;
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
                DataGridViewRow selectedRow = dataGridView2.SelectedCells[0].OwningRow;
                disciplineName.Text = selectedRow.Cells["disciplineNameCol2"].Value.ToString();
                studyHours.Text = selectedRow.Cells["studyHoursCol2"].Value.ToString();
                numOfPeople.Text = selectedRow.Cells["numOfPeopleCol2"].Value.ToString();

                for (int i = 33; i < 58; i++)
                    if (extendedInfoGB.Controls[i].GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                        tb.Text = string.Empty;
                    }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells["contractInfoIdCol3"].Value.ToString() == selectedRow.Cells["contractInfoIdCol2"].Value.ToString())
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 1)
            {
                int index = 0;
                DataGridViewRow selectedRow = dataGridView3.SelectedCells[0].OwningRow;

                for (int i = 33; i < 46; i++)
                    if (extendedInfoGB.Controls[i].GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox tb = (TextBox)extendedInfoGB.Controls[i];
                        tb.Text = selectedRow.Cells[index].Value.ToString();
                        index++;
                    }
            }
        }
    }
}
