
namespace kursovajaEF.Forms
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.groups = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInfoIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gWeekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachers = new System.Windows.Forms.DataGridView();
            this.fioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedExCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overExCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listeners = new System.Windows.Forms.DataGridView();
            this.firstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolGradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetable = new System.Windows.Forms.DataGridView();
            this.ttIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.showLinkBtn = new System.Windows.Forms.Button();
            this.linkBtn = new System.Windows.Forms.Button();
            this.chooseGIBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // groups
            // 
            this.groups.AllowUserToAddRows = false;
            this.groups.AllowUserToDeleteRows = false;
            this.groups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.groups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.groupIdCol,
            this.disciplineIdCol,
            this.numOfHoursCol,
            this.disciplineNameCol,
            this.groupInfoIdCol,
            this.gWeekdayCol,
            this.startTimeCol,
            this.endTimeCol,
            this.startLearningCol,
            this.endLearningCol});
            this.groups.Location = new System.Drawing.Point(12, 12);
            this.groups.Name = "groups";
            this.groups.ReadOnly = true;
            this.groups.RowHeadersWidth = 51;
            this.groups.RowTemplate.Height = 29;
            this.groups.Size = new System.Drawing.Size(1120, 195);
            this.groups.TabIndex = 0;
            this.groups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groups_CellDoubleClick);
            this.groups.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol
            // 
            this.groupNumCol.FillWeight = 25.66845F;
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            this.groupNumCol.Width = 129;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "Id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            this.groupIdCol.Visible = false;
            this.groupIdCol.Width = 106;
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "id программы";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            this.disciplineIdCol.Visible = false;
            this.disciplineIdCol.Width = 138;
            // 
            // numOfHoursCol
            // 
            this.numOfHoursCol.FillWeight = 25.66845F;
            this.numOfHoursCol.HeaderText = "Количество часов";
            this.numOfHoursCol.MinimumWidth = 6;
            this.numOfHoursCol.Name = "numOfHoursCol";
            this.numOfHoursCol.ReadOnly = true;
            this.numOfHoursCol.Width = 149;
            // 
            // disciplineNameCol
            // 
            this.disciplineNameCol.FillWeight = 620.3209F;
            this.disciplineNameCol.HeaderText = "Программа";
            this.disciplineNameCol.MinimumWidth = 6;
            this.disciplineNameCol.Name = "disciplineNameCol";
            this.disciplineNameCol.ReadOnly = true;
            this.disciplineNameCol.Width = 120;
            // 
            // groupInfoIdCol
            // 
            this.groupInfoIdCol.HeaderText = "id информации о группе";
            this.groupInfoIdCol.MinimumWidth = 6;
            this.groupInfoIdCol.Name = "groupInfoIdCol";
            this.groupInfoIdCol.ReadOnly = true;
            this.groupInfoIdCol.Visible = false;
            this.groupInfoIdCol.Width = 150;
            // 
            // gWeekdayCol
            // 
            this.gWeekdayCol.FillWeight = 25.66845F;
            this.gWeekdayCol.HeaderText = "День недели";
            this.gWeekdayCol.MinimumWidth = 6;
            this.gWeekdayCol.Name = "gWeekdayCol";
            this.gWeekdayCol.ReadOnly = true;
            this.gWeekdayCol.Width = 117;
            // 
            // startTimeCol
            // 
            this.startTimeCol.FillWeight = 25.66845F;
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            this.startTimeCol.ReadOnly = true;
            this.startTimeCol.Width = 125;
            // 
            // endTimeCol
            // 
            this.endTimeCol.FillWeight = 25.66845F;
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            this.endTimeCol.ReadOnly = true;
            this.endTimeCol.Width = 149;
            // 
            // startLearningCol
            // 
            this.startLearningCol.FillWeight = 25.66845F;
            this.startLearningCol.HeaderText = "Дата начала обучения";
            this.startLearningCol.MinimumWidth = 6;
            this.startLearningCol.Name = "startLearningCol";
            this.startLearningCol.ReadOnly = true;
            this.startLearningCol.Width = 177;
            // 
            // endLearningCol
            // 
            this.endLearningCol.FillWeight = 25.66845F;
            this.endLearningCol.HeaderText = "Дата окончания обучения";
            this.endLearningCol.MinimumWidth = 6;
            this.endLearningCol.Name = "endLearningCol";
            this.endLearningCol.ReadOnly = true;
            this.endLearningCol.Width = 201;
            // 
            // teachers
            // 
            this.teachers.AllowUserToAddRows = false;
            this.teachers.AllowUserToDeleteRows = false;
            this.teachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioCol,
            this.dobCol,
            this.titleCol,
            this.posCol,
            this.pedExCol,
            this.overExCol,
            this.degreeCol,
            this.phoneCol,
            this.emailCol,
            this.teacherIdCol});
            this.teachers.Location = new System.Drawing.Point(15, 325);
            this.teachers.Name = "teachers";
            this.teachers.ReadOnly = true;
            this.teachers.RowHeadersWidth = 51;
            this.teachers.RowTemplate.Height = 29;
            this.teachers.Size = new System.Drawing.Size(1434, 400);
            this.teachers.TabIndex = 0;
            this.teachers.Visible = false;
            this.teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // fioCol
            // 
            this.fioCol.HeaderText = "ФИО преподавателя";
            this.fioCol.MinimumWidth = 6;
            this.fioCol.Name = "fioCol";
            this.fioCol.ReadOnly = true;
            // 
            // dobCol
            // 
            this.dobCol.HeaderText = "Дата рождения";
            this.dobCol.MinimumWidth = 6;
            this.dobCol.Name = "dobCol";
            this.dobCol.ReadOnly = true;
            // 
            // titleCol
            // 
            this.titleCol.HeaderText = "Звание";
            this.titleCol.MinimumWidth = 6;
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            // 
            // posCol
            // 
            this.posCol.HeaderText = "Должность";
            this.posCol.MinimumWidth = 6;
            this.posCol.Name = "posCol";
            this.posCol.ReadOnly = true;
            // 
            // pedExCol
            // 
            this.pedExCol.HeaderText = "Педагогический стаж";
            this.pedExCol.MinimumWidth = 6;
            this.pedExCol.Name = "pedExCol";
            this.pedExCol.ReadOnly = true;
            // 
            // overExCol
            // 
            this.overExCol.HeaderText = "Общий стаж";
            this.overExCol.MinimumWidth = 6;
            this.overExCol.Name = "overExCol";
            this.overExCol.ReadOnly = true;
            // 
            // degreeCol
            // 
            this.degreeCol.HeaderText = "Образование по диплому";
            this.degreeCol.MinimumWidth = 6;
            this.degreeCol.Name = "degreeCol";
            this.degreeCol.ReadOnly = true;
            // 
            // phoneCol
            // 
            this.phoneCol.HeaderText = "Номер телефона";
            this.phoneCol.MinimumWidth = 6;
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.ReadOnly = true;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "email";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            // 
            // teacherIdCol
            // 
            this.teacherIdCol.HeaderText = "Id преподавателя";
            this.teacherIdCol.MinimumWidth = 6;
            this.teacherIdCol.Name = "teacherIdCol";
            this.teacherIdCol.ReadOnly = true;
            this.teacherIdCol.Visible = false;
            // 
            // listeners
            // 
            this.listeners.AllowUserToAddRows = false;
            this.listeners.AllowUserToDeleteRows = false;
            this.listeners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeners.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameCol,
            this.midnameCol,
            this.lastnameCol,
            this.yobCol,
            this.sexCol,
            this.listenerIdCol,
            this.matriculationCol,
            this.phoneNumCol,
            this.schoolGradeCol,
            this.dataGridViewTextBoxColumn1,
            this.listenerCategoryCol});
            this.listeners.Location = new System.Drawing.Point(15, 325);
            this.listeners.Name = "listeners";
            this.listeners.ReadOnly = true;
            this.listeners.RowHeadersWidth = 51;
            this.listeners.RowTemplate.Height = 29;
            this.listeners.Size = new System.Drawing.Size(1434, 400);
            this.listeners.TabIndex = 0;
            this.listeners.Visible = false;
            this.listeners.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // firstnameCol
            // 
            this.firstnameCol.HeaderText = "Имя";
            this.firstnameCol.MinimumWidth = 6;
            this.firstnameCol.Name = "firstnameCol";
            this.firstnameCol.ReadOnly = true;
            // 
            // midnameCol
            // 
            this.midnameCol.HeaderText = "Фамилия";
            this.midnameCol.MinimumWidth = 6;
            this.midnameCol.Name = "midnameCol";
            this.midnameCol.ReadOnly = true;
            // 
            // lastnameCol
            // 
            this.lastnameCol.HeaderText = "Отчество";
            this.lastnameCol.MinimumWidth = 6;
            this.lastnameCol.Name = "lastnameCol";
            this.lastnameCol.ReadOnly = true;
            // 
            // yobCol
            // 
            this.yobCol.HeaderText = "Дата рождения";
            this.yobCol.MinimumWidth = 6;
            this.yobCol.Name = "yobCol";
            this.yobCol.ReadOnly = true;
            // 
            // sexCol
            // 
            this.sexCol.HeaderText = "Пол";
            this.sexCol.MinimumWidth = 6;
            this.sexCol.Name = "sexCol";
            this.sexCol.ReadOnly = true;
            // 
            // listenerIdCol
            // 
            this.listenerIdCol.HeaderText = "Id слушателя";
            this.listenerIdCol.MinimumWidth = 6;
            this.listenerIdCol.Name = "listenerIdCol";
            this.listenerIdCol.ReadOnly = true;
            this.listenerIdCol.Visible = false;
            // 
            // matriculationCol
            // 
            this.matriculationCol.HeaderText = "Зачисление";
            this.matriculationCol.MinimumWidth = 6;
            this.matriculationCol.Name = "matriculationCol";
            this.matriculationCol.ReadOnly = true;
            // 
            // phoneNumCol
            // 
            this.phoneNumCol.HeaderText = "Номер телефона";
            this.phoneNumCol.MinimumWidth = 6;
            this.phoneNumCol.Name = "phoneNumCol";
            this.phoneNumCol.ReadOnly = true;
            // 
            // schoolGradeCol
            // 
            this.schoolGradeCol.HeaderText = "Класс";
            this.schoolGradeCol.MinimumWidth = 6;
            this.schoolGradeCol.Name = "schoolGradeCol";
            this.schoolGradeCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // listenerCategoryCol
            // 
            this.listenerCategoryCol.HeaderText = "Категория слушателя";
            this.listenerCategoryCol.MinimumWidth = 6;
            this.listenerCategoryCol.Name = "listenerCategoryCol";
            this.listenerCategoryCol.ReadOnly = true;
            // 
            // timetable
            // 
            this.timetable.AllowUserToAddRows = false;
            this.timetable.AllowUserToDeleteRows = false;
            this.timetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ttIdCol,
            this.startCol,
            this.endCol,
            this.weekdayCol});
            this.timetable.Location = new System.Drawing.Point(13, 321);
            this.timetable.Name = "timetable";
            this.timetable.ReadOnly = true;
            this.timetable.RowHeadersWidth = 51;
            this.timetable.RowTemplate.Height = 29;
            this.timetable.Size = new System.Drawing.Size(1434, 404);
            this.timetable.TabIndex = 0;
            this.timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // ttIdCol
            // 
            this.ttIdCol.HeaderText = "Id расписания";
            this.ttIdCol.MinimumWidth = 6;
            this.ttIdCol.Name = "ttIdCol";
            this.ttIdCol.ReadOnly = true;
            this.ttIdCol.Visible = false;
            // 
            // startCol
            // 
            this.startCol.HeaderText = "Время начала";
            this.startCol.MinimumWidth = 6;
            this.startCol.Name = "startCol";
            this.startCol.ReadOnly = true;
            // 
            // endCol
            // 
            this.endCol.HeaderText = "Время конца";
            this.endCol.MinimumWidth = 6;
            this.endCol.Name = "endCol";
            this.endCol.ReadOnly = true;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            this.weekdayCol.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(1159, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(269, 32);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updBtn.Location = new System.Drawing.Point(1159, 96);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(269, 32);
            this.updBtn.TabIndex = 1;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delBtn.Location = new System.Drawing.Point(1159, 175);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(269, 32);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(88, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Расписание",
            "Преподаватели",
            "Слушатели"});
            this.comboBox2.Location = new System.Drawing.Point(15, 281);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Расписание";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // showLinkBtn
            // 
            this.showLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showLinkBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showLinkBtn.Location = new System.Drawing.Point(492, 274);
            this.showLinkBtn.Name = "showLinkBtn";
            this.showLinkBtn.Size = new System.Drawing.Size(243, 38);
            this.showLinkBtn.TabIndex = 1;
            this.showLinkBtn.Text = "Соотношения";
            this.showLinkBtn.UseVisualStyleBackColor = true;
            this.showLinkBtn.Click += new System.EventHandler(this.showLinkBtn_Click);
            // 
            // linkBtn
            // 
            this.linkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkBtn.Location = new System.Drawing.Point(207, 274);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(243, 38);
            this.linkBtn.TabIndex = 1;
            this.linkBtn.Text = "Соотнести данные";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // chooseGIBtn
            // 
            this.chooseGIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseGIBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseGIBtn.Location = new System.Drawing.Point(386, 222);
            this.chooseGIBtn.Name = "chooseGIBtn";
            this.chooseGIBtn.Size = new System.Drawing.Size(269, 32);
            this.chooseGIBtn.TabIndex = 1;
            this.chooseGIBtn.Text = "Выбрать расписание";
            this.chooseGIBtn.UseVisualStyleBackColor = true;
            this.chooseGIBtn.Visible = false;
            this.chooseGIBtn.Click += new System.EventHandler(this.chooseGIBtn_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 731);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.showLinkBtn);
            this.Controls.Add(this.chooseGIBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.listeners);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.groups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15";
            this.Text = "Список групп";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groups;
        private System.Windows.Forms.DataGridView teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn posCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedExCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn overExCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdCol;
        private System.Windows.Forms.DataGridView listeners;
        private System.Windows.Forms.DataGridView timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button showLinkBtn;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupInfoIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gWeekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLearningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endLearningCol;
        public System.Windows.Forms.Button chooseGIBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolGradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerCategoryCol;
    }
}