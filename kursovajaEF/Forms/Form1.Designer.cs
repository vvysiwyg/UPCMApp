
namespace kursovajaEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Слушатели");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Подразделения");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Программы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Преподаватели");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Расписания");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Договоры");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Группы");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Отчеты");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.midNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolGradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restOfSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate40pctCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDeadlineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoPayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPeopleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expulsionDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenedHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueCertificateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractInfoIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInfoIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.extendedInfoGB = new System.Windows.Forms.GroupBox();
            this.midname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.yob = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.schoolGrade = new System.Windows.Forms.TextBox();
            this.crn = new System.Windows.Forms.TextBox();
            this.totalSum = new System.Windows.Forms.TextBox();
            this.payedSum = new System.Windows.Forms.TextBox();
            this.restOfSum = new System.Windows.Forms.TextBox();
            this.payDate40Pct = new System.Windows.Forms.TextBox();
            this.paymentDeadline = new System.Windows.Forms.TextBox();
            this.whoPay = new System.Windows.Forms.TextBox();
            this.disciplineName = new System.Windows.Forms.TextBox();
            this.startLearning = new System.Windows.Forms.TextBox();
            this.endLearning = new System.Windows.Forms.TextBox();
            this.groupNum = new System.Windows.Forms.TextBox();
            this.numOfPeople = new System.Windows.Forms.TextBox();
            this.numOfHours = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.matriculation = new System.Windows.Forms.TextBox();
            this.expulsionDate = new System.Windows.Forms.TextBox();
            this.listenedHours = new System.Windows.Forms.TextBox();
            this.transferGroup = new System.Windows.Forms.TextBox();
            this.certificate = new System.Windows.Forms.TextBox();
            this.issueCertificate = new System.Windows.Forms.TextBox();
            this.studyHours = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractInfoIdCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPeopleCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyHoursCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractInfoIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.extendedInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(12, 6);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "listenerNode";
            treeNode1.Text = "Слушатели";
            treeNode2.Name = "departmentNode";
            treeNode2.Text = "Подразделения";
            treeNode3.Name = "disciplineNode";
            treeNode3.Text = "Программы";
            treeNode4.Name = "teacherNode";
            treeNode4.Text = "Преподаватели";
            treeNode5.Name = "timetableNode";
            treeNode5.Text = "Расписания";
            treeNode6.Name = "contractNode";
            treeNode6.Text = "Договоры";
            treeNode7.Name = "groupNode";
            treeNode7.Text = "Группы";
            treeNode8.Name = "tableNode";
            treeNode8.Text = "Таблицы";
            treeNode9.Name = "reportNode";
            treeNode9.Text = "Отчеты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(169, 416);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midNameCol,
            this.firstnameCol,
            this.lastNameCol,
            this.yobCol,
            this.sexCol,
            this.phoneNumCol,
            this.emailCol,
            this.schoolGradeCol,
            this.crnCol,
            this.totalSumCol,
            this.payedSumCol,
            this.restOfSumCol,
            this.PayDate40pctCol,
            this.paymentDeadlineCol,
            this.whoPayCol,
            this.disciplineNameCol,
            this.startLearningCol,
            this.endLearningCol,
            this.groupNumCol,
            this.numOfPeopleCol,
            this.numOfHoursCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol,
            this.matriculationCol,
            this.expulsionDateCol,
            this.listenedHoursCol,
            this.transferGroupCol,
            this.certificateCol,
            this.issueCertificateCol,
            this.studyHoursCol,
            this.listenerIdCol,
            this.contractIdCol,
            this.groupIdCol,
            this.disciplineIdCol,
            this.contractInfoIdCol,
            this.groupInfoIdCol});
            this.dataGridView1.Location = new System.Drawing.Point(187, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 365);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // midNameCol
            // 
            this.midNameCol.HeaderText = "Фамилия";
            this.midNameCol.MinimumWidth = 6;
            this.midNameCol.Name = "midNameCol";
            this.midNameCol.ReadOnly = true;
            this.midNameCol.Width = 95;
            // 
            // firstnameCol
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.firstnameCol.HeaderText = "Имя";
            this.firstnameCol.MinimumWidth = 6;
            this.firstnameCol.Name = "firstnameCol";
            this.firstnameCol.ReadOnly = true;
            this.firstnameCol.Width = 62;
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Отчество";
            this.lastNameCol.MinimumWidth = 6;
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.ReadOnly = true;
            this.lastNameCol.Width = 99;
            // 
            // yobCol
            // 
            this.yobCol.HeaderText = "Дата рождения";
            this.yobCol.MinimumWidth = 6;
            this.yobCol.Name = "yobCol";
            this.yobCol.ReadOnly = true;
            this.yobCol.Visible = false;
            this.yobCol.Width = 135;
            // 
            // sexCol
            // 
            this.sexCol.HeaderText = "Пол";
            this.sexCol.MinimumWidth = 6;
            this.sexCol.Name = "sexCol";
            this.sexCol.ReadOnly = true;
            this.sexCol.Visible = false;
            this.sexCol.Width = 62;
            // 
            // phoneNumCol
            // 
            this.phoneNumCol.HeaderText = "Номер телефона";
            this.phoneNumCol.MinimumWidth = 6;
            this.phoneNumCol.Name = "phoneNumCol";
            this.phoneNumCol.ReadOnly = true;
            this.phoneNumCol.Width = 136;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            this.emailCol.Width = 70;
            // 
            // schoolGradeCol
            // 
            this.schoolGradeCol.HeaderText = "Класс";
            this.schoolGradeCol.MinimumWidth = 6;
            this.schoolGradeCol.Name = "schoolGradeCol";
            this.schoolGradeCol.ReadOnly = true;
            this.schoolGradeCol.Visible = false;
            this.schoolGradeCol.Width = 74;
            // 
            // crnCol
            // 
            this.crnCol.HeaderText = "Регистрационный номер договора";
            this.crnCol.MinimumWidth = 6;
            this.crnCol.Name = "crnCol";
            this.crnCol.ReadOnly = true;
            this.crnCol.Width = 183;
            // 
            // totalSumCol
            // 
            this.totalSumCol.HeaderText = "Общая сумма(руб.)";
            this.totalSumCol.MinimumWidth = 6;
            this.totalSumCol.Name = "totalSumCol";
            this.totalSumCol.ReadOnly = true;
            this.totalSumCol.Visible = false;
            this.totalSumCol.Width = 144;
            // 
            // payedSumCol
            // 
            this.payedSumCol.HeaderText = "Оплачено(руб.)";
            this.payedSumCol.MinimumWidth = 6;
            this.payedSumCol.Name = "payedSumCol";
            this.payedSumCol.ReadOnly = true;
            this.payedSumCol.Visible = false;
            this.payedSumCol.Width = 137;
            // 
            // restOfSumCol
            // 
            this.restOfSumCol.HeaderText = "Остаток по оплате(руб.)";
            this.restOfSumCol.MinimumWidth = 6;
            this.restOfSumCol.Name = "restOfSumCol";
            this.restOfSumCol.ReadOnly = true;
            this.restOfSumCol.Visible = false;
            this.restOfSumCol.Width = 177;
            // 
            // PayDate40pctCol
            // 
            this.PayDate40pctCol.HeaderText = "Дата оплаты 40 %";
            this.PayDate40pctCol.MinimumWidth = 6;
            this.PayDate40pctCol.Name = "PayDate40pctCol";
            this.PayDate40pctCol.ReadOnly = true;
            this.PayDate40pctCol.Visible = false;
            this.PayDate40pctCol.Width = 125;
            // 
            // paymentDeadlineCol
            // 
            this.paymentDeadlineCol.HeaderText = "Срок оплаты";
            this.paymentDeadlineCol.MinimumWidth = 6;
            this.paymentDeadlineCol.Name = "paymentDeadlineCol";
            this.paymentDeadlineCol.ReadOnly = true;
            this.paymentDeadlineCol.Visible = false;
            this.paymentDeadlineCol.Width = 110;
            // 
            // whoPayCol
            // 
            this.whoPayCol.HeaderText = "Кто оплатил";
            this.whoPayCol.MinimumWidth = 6;
            this.whoPayCol.Name = "whoPayCol";
            this.whoPayCol.ReadOnly = true;
            this.whoPayCol.Visible = false;
            this.whoPayCol.Width = 108;
            // 
            // disciplineNameCol
            // 
            this.disciplineNameCol.HeaderText = "Программа";
            this.disciplineNameCol.MinimumWidth = 6;
            this.disciplineNameCol.Name = "disciplineNameCol";
            this.disciplineNameCol.ReadOnly = true;
            this.disciplineNameCol.Visible = false;
            this.disciplineNameCol.Width = 110;
            // 
            // startLearningCol
            // 
            this.startLearningCol.HeaderText = "Дата начала обучения";
            this.startLearningCol.MinimumWidth = 6;
            this.startLearningCol.Name = "startLearningCol";
            this.startLearningCol.ReadOnly = true;
            this.startLearningCol.Visible = false;
            this.startLearningCol.Width = 169;
            // 
            // endLearningCol
            // 
            this.endLearningCol.HeaderText = "Дата окончания обучения";
            this.endLearningCol.MinimumWidth = 6;
            this.endLearningCol.Name = "endLearningCol";
            this.endLearningCol.ReadOnly = true;
            this.endLearningCol.Visible = false;
            this.endLearningCol.Width = 189;
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            this.groupNumCol.Visible = false;
            this.groupNumCol.Width = 119;
            // 
            // numOfPeopleCol
            // 
            this.numOfPeopleCol.HeaderText = "Число обучающихся в группе";
            this.numOfPeopleCol.MinimumWidth = 6;
            this.numOfPeopleCol.Name = "numOfPeopleCol";
            this.numOfPeopleCol.ReadOnly = true;
            this.numOfPeopleCol.Visible = false;
            this.numOfPeopleCol.Width = 206;
            // 
            // numOfHoursCol
            // 
            this.numOfHoursCol.HeaderText = "Количество часов";
            this.numOfHoursCol.MinimumWidth = 6;
            this.numOfHoursCol.Name = "numOfHoursCol";
            this.numOfHoursCol.ReadOnly = true;
            this.numOfHoursCol.Visible = false;
            this.numOfHoursCol.Width = 143;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            this.weekdayCol.ReadOnly = true;
            this.weekdayCol.Visible = false;
            this.weekdayCol.Width = 110;
            // 
            // startTimeCol
            // 
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            this.startTimeCol.ReadOnly = true;
            this.startTimeCol.Visible = false;
            this.startTimeCol.Width = 118;
            // 
            // endTimeCol
            // 
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            this.endTimeCol.ReadOnly = true;
            this.endTimeCol.Visible = false;
            this.endTimeCol.Width = 137;
            // 
            // matriculationCol
            // 
            this.matriculationCol.HeaderText = "Зачисление";
            this.matriculationCol.MinimumWidth = 6;
            this.matriculationCol.Name = "matriculationCol";
            this.matriculationCol.ReadOnly = true;
            this.matriculationCol.Visible = false;
            this.matriculationCol.Width = 116;
            // 
            // expulsionDateCol
            // 
            this.expulsionDateCol.HeaderText = "Дата отчисления";
            this.expulsionDateCol.MinimumWidth = 6;
            this.expulsionDateCol.Name = "expulsionDateCol";
            this.expulsionDateCol.ReadOnly = true;
            this.expulsionDateCol.Visible = false;
            this.expulsionDateCol.Width = 136;
            // 
            // listenedHoursCol
            // 
            this.listenedHoursCol.HeaderText = "Прослушанные часы";
            this.listenedHoursCol.MinimumWidth = 6;
            this.listenedHoursCol.Name = "listenedHoursCol";
            this.listenedHoursCol.ReadOnly = true;
            this.listenedHoursCol.Visible = false;
            this.listenedHoursCol.Width = 155;
            // 
            // transferGroupCol
            // 
            this.transferGroupCol.HeaderText = "Переведен(-а) в группу";
            this.transferGroupCol.MinimumWidth = 6;
            this.transferGroupCol.Name = "transferGroupCol";
            this.transferGroupCol.ReadOnly = true;
            this.transferGroupCol.Visible = false;
            this.transferGroupCol.Width = 132;
            // 
            // certificateCol
            // 
            this.certificateCol.HeaderText = "Сертификат";
            this.certificateCol.MinimumWidth = 6;
            this.certificateCol.Name = "certificateCol";
            this.certificateCol.ReadOnly = true;
            this.certificateCol.Visible = false;
            this.certificateCol.Width = 117;
            // 
            // issueCertificateCol
            // 
            this.issueCertificateCol.HeaderText = "Дата выдачи сертификата";
            this.issueCertificateCol.MinimumWidth = 6;
            this.issueCertificateCol.Name = "issueCertificateCol";
            this.issueCertificateCol.ReadOnly = true;
            this.issueCertificateCol.Visible = false;
            this.issueCertificateCol.Width = 191;
            // 
            // studyHoursCol
            // 
            this.studyHoursCol.HeaderText = "Общее количество часов";
            this.studyHoursCol.MinimumWidth = 6;
            this.studyHoursCol.Name = "studyHoursCol";
            this.studyHoursCol.ReadOnly = true;
            this.studyHoursCol.Visible = false;
            this.studyHoursCol.Width = 183;
            // 
            // listenerIdCol
            // 
            this.listenerIdCol.HeaderText = "ID слушателя";
            this.listenerIdCol.MinimumWidth = 6;
            this.listenerIdCol.Name = "listenerIdCol";
            this.listenerIdCol.ReadOnly = true;
            this.listenerIdCol.Visible = false;
            this.listenerIdCol.Width = 112;
            // 
            // contractIdCol
            // 
            this.contractIdCol.HeaderText = "ID договора";
            this.contractIdCol.MinimumWidth = 6;
            this.contractIdCol.Name = "contractIdCol";
            this.contractIdCol.ReadOnly = true;
            this.contractIdCol.Visible = false;
            this.contractIdCol.Width = 105;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "ID группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            this.groupIdCol.Visible = false;
            this.groupIdCol.Width = 92;
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "ID программы";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            this.disciplineIdCol.Visible = false;
            this.disciplineIdCol.Width = 115;
            // 
            // contractInfoIdCol
            // 
            this.contractInfoIdCol.HeaderText = "ID информации о договоре";
            this.contractInfoIdCol.MinimumWidth = 6;
            this.contractInfoIdCol.Name = "contractInfoIdCol";
            this.contractInfoIdCol.ReadOnly = true;
            this.contractInfoIdCol.Visible = false;
            this.contractInfoIdCol.Width = 137;
            // 
            // groupInfoIdCol
            // 
            this.groupInfoIdCol.HeaderText = "ID информации о группе";
            this.groupInfoIdCol.MinimumWidth = 6;
            this.groupInfoIdCol.Name = "groupInfoIdCol";
            this.groupInfoIdCol.ReadOnly = true;
            this.groupInfoIdCol.Visible = false;
            this.groupInfoIdCol.Width = 137;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(187, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(263, 45);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(839, 6);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(263, 45);
            this.updBtn.TabIndex = 2;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(1557, 6);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(263, 45);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // extendedInfoGB
            // 
            this.extendedInfoGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedInfoGB.Controls.Add(this.firstname);
            this.extendedInfoGB.Controls.Add(this.midname);
            this.extendedInfoGB.Controls.Add(this.lastname);
            this.extendedInfoGB.Controls.Add(this.yob);
            this.extendedInfoGB.Controls.Add(this.sex);
            this.extendedInfoGB.Controls.Add(this.phoneNum);
            this.extendedInfoGB.Controls.Add(this.email);
            this.extendedInfoGB.Controls.Add(this.schoolGrade);
            this.extendedInfoGB.Controls.Add(this.endTime);
            this.extendedInfoGB.Controls.Add(this.endLearning);
            this.extendedInfoGB.Controls.Add(this.startTime);
            this.extendedInfoGB.Controls.Add(this.weekday);
            this.extendedInfoGB.Controls.Add(this.crn);
            this.extendedInfoGB.Controls.Add(this.startLearning);
            this.extendedInfoGB.Controls.Add(this.totalSum);
            this.extendedInfoGB.Controls.Add(this.payedSum);
            this.extendedInfoGB.Controls.Add(this.restOfSum);
            this.extendedInfoGB.Controls.Add(this.payDate40Pct);
            this.extendedInfoGB.Controls.Add(this.paymentDeadline);
            this.extendedInfoGB.Controls.Add(this.whoPay);
            this.extendedInfoGB.Controls.Add(this.disciplineName);
            this.extendedInfoGB.Controls.Add(this.groupNum);
            this.extendedInfoGB.Controls.Add(this.numOfPeople);
            this.extendedInfoGB.Controls.Add(this.numOfHours);
            this.extendedInfoGB.Controls.Add(this.matriculation);
            this.extendedInfoGB.Controls.Add(this.expulsionDate);
            this.extendedInfoGB.Controls.Add(this.listenedHours);
            this.extendedInfoGB.Controls.Add(this.transferGroup);
            this.extendedInfoGB.Controls.Add(this.certificate);
            this.extendedInfoGB.Controls.Add(this.issueCertificate);
            this.extendedInfoGB.Controls.Add(this.studyHours);
            this.extendedInfoGB.Controls.Add(this.label19);
            this.extendedInfoGB.Controls.Add(this.label21);
            this.extendedInfoGB.Controls.Add(this.label18);
            this.extendedInfoGB.Controls.Add(this.label15);
            this.extendedInfoGB.Controls.Add(this.label2);
            this.extendedInfoGB.Controls.Add(this.label20);
            this.extendedInfoGB.Controls.Add(this.label1);
            this.extendedInfoGB.Controls.Add(this.label27);
            this.extendedInfoGB.Controls.Add(this.label17);
            this.extendedInfoGB.Controls.Add(this.label14);
            this.extendedInfoGB.Controls.Add(this.label26);
            this.extendedInfoGB.Controls.Add(this.label16);
            this.extendedInfoGB.Controls.Add(this.label13);
            this.extendedInfoGB.Controls.Add(this.label25);
            this.extendedInfoGB.Controls.Add(this.label6);
            this.extendedInfoGB.Controls.Add(this.label12);
            this.extendedInfoGB.Controls.Add(this.label4);
            this.extendedInfoGB.Controls.Add(this.label24);
            this.extendedInfoGB.Controls.Add(this.label7);
            this.extendedInfoGB.Controls.Add(this.label11);
            this.extendedInfoGB.Controls.Add(this.label23);
            this.extendedInfoGB.Controls.Add(this.label3);
            this.extendedInfoGB.Controls.Add(this.label10);
            this.extendedInfoGB.Controls.Add(this.label5);
            this.extendedInfoGB.Controls.Add(this.label22);
            this.extendedInfoGB.Controls.Add(this.label9);
            this.extendedInfoGB.Controls.Add(this.label8);
            this.extendedInfoGB.Location = new System.Drawing.Point(12, 428);
            this.extendedInfoGB.Name = "extendedInfoGB";
            this.extendedInfoGB.Size = new System.Drawing.Size(1808, 190);
            this.extendedInfoGB.TabIndex = 4;
            this.extendedInfoGB.TabStop = false;
            this.extendedInfoGB.Text = "groupBox1";
            this.extendedInfoGB.Visible = false;
            // 
            // midname
            // 
            this.midname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.midname.Location = new System.Drawing.Point(7, 27);
            this.midname.Name = "midname";
            this.midname.ReadOnly = true;
            this.midname.Size = new System.Drawing.Size(181, 25);
            this.midname.TabIndex = 1;
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstname.Location = new System.Drawing.Point(194, 27);
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Size = new System.Drawing.Size(181, 25);
            this.firstname.TabIndex = 2;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(381, 27);
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Size = new System.Drawing.Size(181, 25);
            this.lastname.TabIndex = 3;
            // 
            // yob
            // 
            this.yob.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yob.Location = new System.Drawing.Point(674, 27);
            this.yob.Name = "yob";
            this.yob.ReadOnly = true;
            this.yob.Size = new System.Drawing.Size(75, 25);
            this.yob.TabIndex = 4;
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sex.Location = new System.Drawing.Point(793, 27);
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Size = new System.Drawing.Size(60, 25);
            this.sex.TabIndex = 5;
            // 
            // phoneNum
            // 
            this.phoneNum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNum.Location = new System.Drawing.Point(975, 27);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.ReadOnly = true;
            this.phoneNum.Size = new System.Drawing.Size(116, 25);
            this.phoneNum.TabIndex = 6;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(1097, 27);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(217, 25);
            this.email.TabIndex = 7;
            // 
            // schoolGrade
            // 
            this.schoolGrade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schoolGrade.Location = new System.Drawing.Point(1368, 27);
            this.schoolGrade.Name = "schoolGrade";
            this.schoolGrade.ReadOnly = true;
            this.schoolGrade.Size = new System.Drawing.Size(44, 25);
            this.schoolGrade.TabIndex = 8;
            // 
            // crn
            // 
            this.crn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crn.Location = new System.Drawing.Point(1536, 29);
            this.crn.Name = "crn";
            this.crn.ReadOnly = true;
            this.crn.Size = new System.Drawing.Size(70, 25);
            this.crn.TabIndex = 9;
            // 
            // totalSum
            // 
            this.totalSum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalSum.Location = new System.Drawing.Point(1710, 29);
            this.totalSum.Name = "totalSum";
            this.totalSum.ReadOnly = true;
            this.totalSum.Size = new System.Drawing.Size(78, 25);
            this.totalSum.TabIndex = 10;
            // 
            // payedSum
            // 
            this.payedSum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payedSum.Location = new System.Drawing.Point(81, 77);
            this.payedSum.Name = "payedSum";
            this.payedSum.ReadOnly = true;
            this.payedSum.Size = new System.Drawing.Size(78, 25);
            this.payedSum.TabIndex = 11;
            // 
            // restOfSum
            // 
            this.restOfSum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restOfSum.Location = new System.Drawing.Point(290, 78);
            this.restOfSum.Name = "restOfSum";
            this.restOfSum.ReadOnly = true;
            this.restOfSum.Size = new System.Drawing.Size(78, 25);
            this.restOfSum.TabIndex = 12;
            // 
            // payDate40Pct
            // 
            this.payDate40Pct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payDate40Pct.Location = new System.Drawing.Point(463, 78);
            this.payDate40Pct.Name = "payDate40Pct";
            this.payDate40Pct.ReadOnly = true;
            this.payDate40Pct.Size = new System.Drawing.Size(75, 25);
            this.payDate40Pct.TabIndex = 13;
            // 
            // paymentDeadline
            // 
            this.paymentDeadline.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDeadline.Location = new System.Drawing.Point(601, 78);
            this.paymentDeadline.Name = "paymentDeadline";
            this.paymentDeadline.ReadOnly = true;
            this.paymentDeadline.Size = new System.Drawing.Size(75, 25);
            this.paymentDeadline.TabIndex = 14;
            // 
            // whoPay
            // 
            this.whoPay.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whoPay.Location = new System.Drawing.Point(744, 78);
            this.whoPay.Name = "whoPay";
            this.whoPay.ReadOnly = true;
            this.whoPay.Size = new System.Drawing.Size(292, 25);
            this.whoPay.TabIndex = 15;
            // 
            // disciplineName
            // 
            this.disciplineName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disciplineName.Location = new System.Drawing.Point(1126, 76);
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.ReadOnly = true;
            this.disciplineName.Size = new System.Drawing.Size(104, 25);
            this.disciplineName.TabIndex = 16;
            // 
            // startLearning
            // 
            this.startLearning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startLearning.Location = new System.Drawing.Point(498, 147);
            this.startLearning.Name = "startLearning";
            this.startLearning.ReadOnly = true;
            this.startLearning.Size = new System.Drawing.Size(78, 25);
            this.startLearning.TabIndex = 17;
            // 
            // endLearning
            // 
            this.endLearning.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endLearning.Location = new System.Drawing.Point(663, 146);
            this.endLearning.Name = "endLearning";
            this.endLearning.ReadOnly = true;
            this.endLearning.Size = new System.Drawing.Size(78, 25);
            this.endLearning.TabIndex = 18;
            // 
            // groupNum
            // 
            this.groupNum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupNum.Location = new System.Drawing.Point(1612, 78);
            this.groupNum.Name = "groupNum";
            this.groupNum.ReadOnly = true;
            this.groupNum.Size = new System.Drawing.Size(49, 25);
            this.groupNum.TabIndex = 19;
            // 
            // numOfPeople
            // 
            this.numOfPeople.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numOfPeople.Location = new System.Drawing.Point(1513, 76);
            this.numOfPeople.Name = "numOfPeople";
            this.numOfPeople.ReadOnly = true;
            this.numOfPeople.Size = new System.Drawing.Size(37, 25);
            this.numOfPeople.TabIndex = 20;
            // 
            // numOfHours
            // 
            this.numOfHours.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numOfHours.Location = new System.Drawing.Point(1762, 78);
            this.numOfHours.Name = "numOfHours";
            this.numOfHours.ReadOnly = true;
            this.numOfHours.Size = new System.Drawing.Size(40, 25);
            this.numOfHours.TabIndex = 21;
            // 
            // weekday
            // 
            this.weekday.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weekday.Location = new System.Drawing.Point(63, 147);
            this.weekday.Name = "weekday";
            this.weekday.ReadOnly = true;
            this.weekday.Size = new System.Drawing.Size(91, 25);
            this.weekday.TabIndex = 22;
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime.Location = new System.Drawing.Point(216, 147);
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Size = new System.Drawing.Size(53, 25);
            this.startTime.TabIndex = 23;
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endTime.Location = new System.Drawing.Point(353, 147);
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Size = new System.Drawing.Size(46, 25);
            this.endTime.TabIndex = 24;
            // 
            // matriculation
            // 
            this.matriculation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matriculation.Location = new System.Drawing.Point(825, 146);
            this.matriculation.Name = "matriculation";
            this.matriculation.ReadOnly = true;
            this.matriculation.Size = new System.Drawing.Size(31, 25);
            this.matriculation.TabIndex = 25;
            // 
            // expulsionDate
            // 
            this.expulsionDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expulsionDate.Location = new System.Drawing.Point(947, 147);
            this.expulsionDate.Name = "expulsionDate";
            this.expulsionDate.ReadOnly = true;
            this.expulsionDate.Size = new System.Drawing.Size(76, 25);
            this.expulsionDate.TabIndex = 26;
            // 
            // listenedHours
            // 
            this.listenedHours.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listenedHours.Location = new System.Drawing.Point(1135, 147);
            this.listenedHours.Name = "listenedHours";
            this.listenedHours.ReadOnly = true;
            this.listenedHours.Size = new System.Drawing.Size(41, 25);
            this.listenedHours.TabIndex = 27;
            // 
            // transferGroup
            // 
            this.transferGroup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferGroup.Location = new System.Drawing.Point(1282, 147);
            this.transferGroup.Name = "transferGroup";
            this.transferGroup.ReadOnly = true;
            this.transferGroup.Size = new System.Drawing.Size(52, 25);
            this.transferGroup.TabIndex = 28;
            // 
            // certificate
            // 
            this.certificate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.certificate.Location = new System.Drawing.Point(1430, 147);
            this.certificate.Name = "certificate";
            this.certificate.ReadOnly = true;
            this.certificate.Size = new System.Drawing.Size(190, 25);
            this.certificate.TabIndex = 29;
            // 
            // issueCertificate
            // 
            this.issueCertificate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issueCertificate.Location = new System.Drawing.Point(1730, 146);
            this.issueCertificate.Name = "issueCertificate";
            this.issueCertificate.ReadOnly = true;
            this.issueCertificate.Size = new System.Drawing.Size(72, 25);
            this.issueCertificate.TabIndex = 30;
            // 
            // studyHours
            // 
            this.studyHours.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studyHours.Location = new System.Drawing.Point(1365, 77);
            this.studyHours.Name = "studyHours";
            this.studyHours.ReadOnly = true;
            this.studyHours.Size = new System.Drawing.Size(40, 25);
            this.studyHours.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(747, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 17);
            this.label21.TabIndex = 55;
            this.label21.Text = "Зачисление";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(275, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 34);
            this.label20.TabIndex = 55;
            this.label20.Text = "Время\r\nокончания\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(160, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 34);
            this.label19.TabIndex = 55;
            this.label19.Text = "Время\r\nначала";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(7, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 34);
            this.label18.TabIndex = 55;
            this.label18.Text = "День\r\nнедели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(682, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 34);
            this.label1.TabIndex = 55;
            this.label1.Text = "Кто\r\nоплатил";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(1236, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(123, 34);
            this.label27.TabIndex = 55;
            this.label27.Text = "Общее количество\r\nчасов";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1678, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 34);
            this.label17.TabIndex = 55;
            this.label17.Text = "Количество\r\nчасов";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(544, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 34);
            this.label14.TabIndex = 55;
            this.label14.Text = "Срок \r\nоплаты";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(1340, 149);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 17);
            this.label26.TabIndex = 55;
            this.label26.Text = "Сертификат";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1556, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 34);
            this.label16.TabIndex = 55;
            this.label16.Text = "Номер\r\nгруппы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(165, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 34);
            this.label13.TabIndex = 55;
            this.label13.Text = "Остаток по оплате\r\n(руб.)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(1182, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 34);
            this.label25.TabIndex = 55;
            this.label25.Text = "Переведен(-а)\r\nв группу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(755, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Пол";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(585, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 51);
            this.label15.TabIndex = 55;
            this.label15.Text = "Дата\r\nокончания\r\nобучения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(7, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 34);
            this.label12.TabIndex = 55;
            this.label12.Text = "Оплачено\r\n(руб.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(568, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Дата рождения";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(865, 141);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 34);
            this.label24.TabIndex = 55;
            this.label24.Text = "Дата\r\nотчисления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1042, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Программа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1418, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 34);
            this.label11.TabIndex = 55;
            this.label11.Text = "Регистрационный\r\nномер договора";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(1640, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 34);
            this.label23.TabIndex = 55;
            this.label23.Text = "Дата выдачи\r\nсертификата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1415, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 51);
            this.label3.TabIndex = 55;
            this.label3.Text = "Число\r\nобучающихся\r\nв группе";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(374, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 34);
            this.label10.TabIndex = 55;
            this.label10.Text = "Дата оплаты\r\n40 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(859, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Номер телефона";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(1029, 141);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 34);
            this.label22.TabIndex = 55;
            this.label22.Text = "Прослушанные\r\nчасы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(427, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 51);
            this.label2.TabIndex = 55;
            this.label2.Text = "Дата\r\nначала\r\nобучения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1612, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 34);
            this.label9.TabIndex = 55;
            this.label9.Text = "Общая сумма\r\n(руб.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1320, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Класс";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineNameCol2,
            this.numOfPeopleCol2,
            this.studyHoursCol2,
            this.contractIdCol2,
            this.dataGridViewTextBoxColumn35,
            this.contractInfoIdCol2});
            this.dataGridView2.Location = new System.Drawing.Point(818, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(314, 365);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn71,
            this.contractInfoIdCol3,
            this.dataGridViewTextBoxColumn74});
            this.dataGridView3.Location = new System.Drawing.Point(1138, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(682, 365);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.HeaderText = "Номер группы";
            this.dataGridViewTextBoxColumn56.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Width = 119;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.HeaderText = "Количество часов";
            this.dataGridViewTextBoxColumn58.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Width = 143;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.HeaderText = "День недели";
            this.dataGridViewTextBoxColumn59.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Width = 110;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.HeaderText = "Время начала";
            this.dataGridViewTextBoxColumn60.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Width = 118;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.HeaderText = "Время окончания";
            this.dataGridViewTextBoxColumn61.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 137;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.HeaderText = "Дата начала обучения";
            this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Visible = false;
            this.dataGridViewTextBoxColumn54.Width = 169;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.HeaderText = "Дата окончания обучения";
            this.dataGridViewTextBoxColumn55.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Visible = false;
            this.dataGridViewTextBoxColumn55.Width = 189;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.HeaderText = "ID группы";
            this.dataGridViewTextBoxColumn71.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.Visible = false;
            this.dataGridViewTextBoxColumn71.Width = 92;
            // 
            // contractInfoIdCol3
            // 
            this.contractInfoIdCol3.HeaderText = "ID информации о договоре";
            this.contractInfoIdCol3.MinimumWidth = 6;
            this.contractInfoIdCol3.Name = "contractInfoIdCol3";
            this.contractInfoIdCol3.ReadOnly = true;
            this.contractInfoIdCol3.Visible = false;
            this.contractInfoIdCol3.Width = 137;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.HeaderText = "ID информации о группе";
            this.dataGridViewTextBoxColumn74.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Visible = false;
            this.dataGridViewTextBoxColumn74.Width = 137;
            // 
            // disciplineNameCol2
            // 
            this.disciplineNameCol2.HeaderText = "Программа";
            this.disciplineNameCol2.MinimumWidth = 6;
            this.disciplineNameCol2.Name = "disciplineNameCol2";
            this.disciplineNameCol2.ReadOnly = true;
            // 
            // numOfPeopleCol2
            // 
            this.numOfPeopleCol2.HeaderText = "Число обучающихся в группе";
            this.numOfPeopleCol2.MinimumWidth = 6;
            this.numOfPeopleCol2.Name = "numOfPeopleCol2";
            this.numOfPeopleCol2.ReadOnly = true;
            this.numOfPeopleCol2.Visible = false;
            // 
            // studyHoursCol2
            // 
            this.studyHoursCol2.HeaderText = "Общее количество часов";
            this.studyHoursCol2.MinimumWidth = 6;
            this.studyHoursCol2.Name = "studyHoursCol2";
            this.studyHoursCol2.ReadOnly = true;
            // 
            // contractIdCol2
            // 
            this.contractIdCol2.HeaderText = "ID договора";
            this.contractIdCol2.MinimumWidth = 6;
            this.contractIdCol2.Name = "contractIdCol2";
            this.contractIdCol2.ReadOnly = true;
            this.contractIdCol2.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.HeaderText = "ID программы";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // contractInfoIdCol2
            // 
            this.contractInfoIdCol2.HeaderText = "ID информации о договоре";
            this.contractInfoIdCol2.MinimumWidth = 6;
            this.contractInfoIdCol2.Name = "contractInfoIdCol2";
            this.contractInfoIdCol2.ReadOnly = true;
            this.contractInfoIdCol2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 630);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.extendedInfoGB);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.extendedInfoGB.ResumeLayout(false);
            this.extendedInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox paymentDeadline;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox restOfSum;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox payedSum;
        private System.Windows.Forms.TextBox payDate40Pct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox crn;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yob;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalSum;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox schoolGrade;
        private System.Windows.Forms.TextBox midname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox matriculation;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.TextBox weekday;
        private System.Windows.Forms.TextBox whoPay;
        private System.Windows.Forms.TextBox studyHours;
        private System.Windows.Forms.TextBox numOfHours;
        private System.Windows.Forms.TextBox certificate;
        private System.Windows.Forms.TextBox groupNum;
        private System.Windows.Forms.TextBox transferGroup;
        private System.Windows.Forms.TextBox endLearning;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox issueCertificate;
        private System.Windows.Forms.TextBox numOfPeople;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox expulsionDate;
        private System.Windows.Forms.TextBox disciplineName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox listenedHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startLearning;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox extendedInfoGB;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn midNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolGradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn crnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn payedSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn restOfSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate40pctCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDeadlineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoPayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLearningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endLearningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPeopleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expulsionDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenedHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueCertificateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractInfoIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupInfoIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPeopleCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyHoursCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractInfoIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractInfoIdCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
    }
}

