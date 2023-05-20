
namespace kursovajaEF.Forms
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.pedEx = new System.Windows.Forms.TextBox();
            this.overEx = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.phone_num = new System.Windows.Forms.MaskedTextBox();
            this.disciplines = new System.Windows.Forms.DataGridView();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyPeriodCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursOfStudyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_info = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInfoIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addDisBtn = new System.Windows.Forms.Button();
            this.addGIBtn = new System.Windows.Forms.Button();
            this.addDisBtn2 = new System.Windows.Forms.Button();
            this.addGIBtn2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.chair = new System.Windows.Forms.TextBox();
            this.addChairBtn = new System.Windows.Forms.Button();
            this.chairId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_info)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1263, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1263, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1263, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1263, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 44);
            this.button4.TabIndex = 0;
            this.button4.Text = "Сбросить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Звание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(573, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Общий стаж";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Педагогический стаж";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(573, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Образование по диплому";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(573, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(573, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1035, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1012, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(226, 7);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(341, 27);
            this.fio.TabIndex = 2;
            this.fio.TextChanged += new System.EventHandler(this.fio_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(226, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(341, 27);
            this.title.TabIndex = 2;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(226, 127);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(341, 27);
            this.position.TabIndex = 2;
            this.position.TextChanged += new System.EventHandler(this.position_TextChanged);
            // 
            // pedEx
            // 
            this.pedEx.Location = new System.Drawing.Point(226, 167);
            this.pedEx.Name = "pedEx";
            this.pedEx.Size = new System.Drawing.Size(109, 27);
            this.pedEx.TabIndex = 2;
            this.pedEx.TextChanged += new System.EventHandler(this.pedEx_TextChanged);
            // 
            // overEx
            // 
            this.overEx.Location = new System.Drawing.Point(832, 7);
            this.overEx.Name = "overEx";
            this.overEx.Size = new System.Drawing.Size(109, 27);
            this.overEx.TabIndex = 2;
            this.overEx.TextChanged += new System.EventHandler(this.overEx_TextChanged);
            // 
            // degree
            // 
            this.degree.Location = new System.Drawing.Point(832, 53);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(341, 27);
            this.degree.TabIndex = 2;
            this.degree.TextChanged += new System.EventHandler(this.degree_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(832, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(341, 27);
            this.email.TabIndex = 2;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(226, 47);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(341, 27);
            this.dob.TabIndex = 3;
            // 
            // phone_num
            // 
            this.phone_num.Location = new System.Drawing.Point(832, 93);
            this.phone_num.Mask = "9(999) 000-0000";
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(109, 27);
            this.phone_num.TabIndex = 4;
            this.phone_num.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // disciplines
            // 
            this.disciplines.AllowUserToAddRows = false;
            this.disciplines.AllowUserToDeleteRows = false;
            this.disciplines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.disciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.disciplines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.disciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdCol,
            this.disciplineNameCol,
            this.studyPeriodCol,
            this.hoursOfStudyCol});
            this.disciplines.Location = new System.Drawing.Point(12, 258);
            this.disciplines.Name = "disciplines";
            this.disciplines.ReadOnly = true;
            this.disciplines.RowHeadersWidth = 51;
            this.disciplines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disciplines.RowTemplate.Height = 24;
            this.disciplines.Size = new System.Drawing.Size(484, 283);
            this.disciplines.TabIndex = 8;
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "id программы";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            this.disciplineIdCol.Visible = false;
            // 
            // disciplineNameCol
            // 
            this.disciplineNameCol.HeaderText = "Программа";
            this.disciplineNameCol.MinimumWidth = 6;
            this.disciplineNameCol.Name = "disciplineNameCol";
            this.disciplineNameCol.ReadOnly = true;
            // 
            // studyPeriodCol
            // 
            this.studyPeriodCol.HeaderText = "Период обучения";
            this.studyPeriodCol.MinimumWidth = 6;
            this.studyPeriodCol.Name = "studyPeriodCol";
            this.studyPeriodCol.ReadOnly = true;
            // 
            // hoursOfStudyCol
            // 
            this.hoursOfStudyCol.HeaderText = "Часы";
            this.hoursOfStudyCol.MinimumWidth = 6;
            this.hoursOfStudyCol.Name = "hoursOfStudyCol";
            this.hoursOfStudyCol.ReadOnly = true;
            // 
            // group_info
            // 
            this.group_info.AllowUserToAddRows = false;
            this.group_info.AllowUserToDeleteRows = false;
            this.group_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.group_info.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.group_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.group_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.group_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.groupIdCol,
            this.dataGridViewTextBoxColumn1,
            this.numOfHoursCol,
            this.dataGridViewTextBoxColumn2,
            this.groupInfoIdCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol,
            this.startLearningCol,
            this.endLearningCol});
            this.group_info.Location = new System.Drawing.Point(527, 258);
            this.group_info.Name = "group_info";
            this.group_info.ReadOnly = true;
            this.group_info.RowHeadersWidth = 51;
            this.group_info.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_info.RowTemplate.Height = 24;
            this.group_info.Size = new System.Drawing.Size(945, 283);
            this.group_info.TabIndex = 9;
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Группа";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            this.groupIdCol.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id программы";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // numOfHoursCol
            // 
            this.numOfHoursCol.HeaderText = "Часы";
            this.numOfHoursCol.MinimumWidth = 6;
            this.numOfHoursCol.Name = "numOfHoursCol";
            this.numOfHoursCol.ReadOnly = true;
            this.numOfHoursCol.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Программа";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // groupInfoIdCol
            // 
            this.groupInfoIdCol.HeaderText = "id информации о группе";
            this.groupInfoIdCol.MinimumWidth = 6;
            this.groupInfoIdCol.Name = "groupInfoIdCol";
            this.groupInfoIdCol.ReadOnly = true;
            this.groupInfoIdCol.Visible = false;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            this.weekdayCol.ReadOnly = true;
            // 
            // startTimeCol
            // 
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            this.startTimeCol.ReadOnly = true;
            // 
            // endTimeCol
            // 
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            this.endTimeCol.ReadOnly = true;
            // 
            // startLearningCol
            // 
            this.startLearningCol.HeaderText = "Дата начала обучения";
            this.startLearningCol.MinimumWidth = 6;
            this.startLearningCol.Name = "startLearningCol";
            this.startLearningCol.ReadOnly = true;
            // 
            // endLearningCol
            // 
            this.endLearningCol.HeaderText = "Дата окончания обучения";
            this.endLearningCol.MinimumWidth = 6;
            this.endLearningCol.Name = "endLearningCol";
            this.endLearningCol.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Преподаваемые программы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(527, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Расписание преподавателя";
            // 
            // addDisBtn
            // 
            this.addDisBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addDisBtn.ForeColor = System.Drawing.Color.Green;
            this.addDisBtn.Location = new System.Drawing.Point(293, 208);
            this.addDisBtn.Name = "addDisBtn";
            this.addDisBtn.Size = new System.Drawing.Size(46, 46);
            this.addDisBtn.TabIndex = 22;
            this.addDisBtn.Text = "+";
            this.addDisBtn.UseVisualStyleBackColor = true;
            this.addDisBtn.Click += new System.EventHandler(this.addDisBtn_Click);
            // 
            // addGIBtn
            // 
            this.addGIBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGIBtn.ForeColor = System.Drawing.Color.Green;
            this.addGIBtn.Location = new System.Drawing.Point(796, 208);
            this.addGIBtn.Name = "addGIBtn";
            this.addGIBtn.Size = new System.Drawing.Size(46, 46);
            this.addGIBtn.TabIndex = 22;
            this.addGIBtn.Text = "+";
            this.addGIBtn.UseVisualStyleBackColor = true;
            this.addGIBtn.Click += new System.EventHandler(this.addGIBtn_Click);
            // 
            // addDisBtn2
            // 
            this.addDisBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addDisBtn2.ForeColor = System.Drawing.Color.Green;
            this.addDisBtn2.Location = new System.Drawing.Point(293, 208);
            this.addDisBtn2.Name = "addDisBtn2";
            this.addDisBtn2.Size = new System.Drawing.Size(46, 46);
            this.addDisBtn2.TabIndex = 22;
            this.addDisBtn2.Text = "+";
            this.addDisBtn2.UseVisualStyleBackColor = true;
            this.addDisBtn2.Visible = false;
            this.addDisBtn2.Click += new System.EventHandler(this.addDisBtn2_Click);
            // 
            // addGIBtn2
            // 
            this.addGIBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGIBtn2.ForeColor = System.Drawing.Color.Green;
            this.addGIBtn2.Location = new System.Drawing.Point(796, 208);
            this.addGIBtn2.Name = "addGIBtn2";
            this.addGIBtn2.Size = new System.Drawing.Size(46, 46);
            this.addGIBtn2.TabIndex = 22;
            this.addGIBtn2.Text = "+";
            this.addGIBtn2.UseVisualStyleBackColor = true;
            this.addGIBtn2.Visible = false;
            this.addGIBtn2.Click += new System.EventHandler(this.addGIBtn2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(573, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 28);
            this.label14.TabIndex = 1;
            this.label14.Text = "Кафедра";
            // 
            // chair
            // 
            this.chair.Location = new System.Drawing.Point(832, 171);
            this.chair.Name = "chair";
            this.chair.ReadOnly = true;
            this.chair.Size = new System.Drawing.Size(341, 27);
            this.chair.TabIndex = 2;
            // 
            // addChairBtn
            // 
            this.addChairBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addChairBtn.ForeColor = System.Drawing.Color.Green;
            this.addChairBtn.Location = new System.Drawing.Point(670, 159);
            this.addChairBtn.Name = "addChairBtn";
            this.addChairBtn.Size = new System.Drawing.Size(46, 46);
            this.addChairBtn.TabIndex = 22;
            this.addChairBtn.Text = "+";
            this.addChairBtn.UseVisualStyleBackColor = true;
            this.addChairBtn.Click += new System.EventHandler(this.addChairBtn_Click);
            // 
            // chairId
            // 
            this.chairId.AutoSize = true;
            this.chairId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chairId.Location = new System.Drawing.Point(1058, 9);
            this.chairId.Name = "chairId";
            this.chairId.Size = new System.Drawing.Size(17, 20);
            this.chairId.TabIndex = 1;
            this.chairId.Text = "0";
            this.chairId.Visible = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 553);
            this.Controls.Add(this.addChairBtn);
            this.Controls.Add(this.addGIBtn2);
            this.Controls.Add(this.addDisBtn2);
            this.Controls.Add(this.addGIBtn);
            this.Controls.Add(this.addDisBtn);
            this.Controls.Add(this.group_info);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.chair);
            this.Controls.Add(this.email);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.overEx);
            this.Controls.Add(this.pedEx);
            this.Controls.Add(this.position);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chairId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные преподавателя";
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox fio;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.TextBox position;
        public System.Windows.Forms.TextBox pedEx;
        public System.Windows.Forms.TextBox overEx;
        public System.Windows.Forms.TextBox degree;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.DateTimePicker dob;
        public System.Windows.Forms.MaskedTextBox phone_num;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView disciplines;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyPeriodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursOfStudyCol;
        public System.Windows.Forms.DataGridView group_info;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupInfoIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLearningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endLearningCol;
        public System.Windows.Forms.Button addDisBtn2;
        public System.Windows.Forms.Button addGIBtn2;
        public System.Windows.Forms.Button addDisBtn;
        public System.Windows.Forms.Button addGIBtn;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox chair;
        public System.Windows.Forms.Button addChairBtn;
        public System.Windows.Forms.Label chairId;
    }
}