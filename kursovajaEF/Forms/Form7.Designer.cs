
namespace kursovajaEF.Forms
{
    partial class Form7
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
            this.disciplines = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdperCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.linkBtn = new System.Windows.Forms.Button();
            this.showLinkBtn = new System.Windows.Forms.Button();
            this.timetable = new System.Windows.Forms.DataGridView();
            this.ttIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setDisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplines
            // 
            this.disciplines.AllowUserToAddRows = false;
            this.disciplines.AllowUserToDeleteRows = false;
            this.disciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines.BackgroundColor = System.Drawing.Color.White;
            this.disciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.disCol,
            this.stdperCol,
            this.hoursCol});
            this.disciplines.Location = new System.Drawing.Point(12, 12);
            this.disciplines.Name = "disciplines";
            this.disciplines.ReadOnly = true;
            this.disciplines.RowHeadersWidth = 51;
            this.disciplines.RowTemplate.Height = 29;
            this.disciplines.Size = new System.Drawing.Size(1119, 197);
            this.disciplines.TabIndex = 0;
            this.disciplines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.disciplines_CellDoubleClick);
            this.disciplines.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // disCol
            // 
            this.disCol.HeaderText = "Дисциплина";
            this.disCol.MinimumWidth = 6;
            this.disCol.Name = "disCol";
            this.disCol.ReadOnly = true;
            // 
            // stdperCol
            // 
            this.stdperCol.HeaderText = "Срок обучения";
            this.stdperCol.MinimumWidth = 6;
            this.stdperCol.Name = "stdperCol";
            this.stdperCol.ReadOnly = true;
            // 
            // hoursCol
            // 
            this.hoursCol.HeaderText = "Количество часов";
            this.hoursCol.MinimumWidth = 6;
            this.hoursCol.Name = "hoursCol";
            this.hoursCol.ReadOnly = true;
            // 
            // teachers
            // 
            this.teachers.AllowUserToAddRows = false;
            this.teachers.AllowUserToDeleteRows = false;
            this.teachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachers.BackgroundColor = System.Drawing.Color.White;
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
            this.teachers.Location = new System.Drawing.Point(12, 342);
            this.teachers.Name = "teachers";
            this.teachers.ReadOnly = true;
            this.teachers.RowHeadersWidth = 51;
            this.teachers.RowTemplate.Height = 29;
            this.teachers.Size = new System.Drawing.Size(1433, 388);
            this.teachers.TabIndex = 0;
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
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(1164, 12);
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
            this.updBtn.Location = new System.Drawing.Point(1164, 94);
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
            this.delBtn.Location = new System.Drawing.Point(1164, 177);
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
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(87, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Преподаватели",
            "Расписание"});
            this.comboBox2.Location = new System.Drawing.Point(12, 302);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Преподаватели";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // linkBtn
            // 
            this.linkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBtn.Location = new System.Drawing.Point(169, 296);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(243, 40);
            this.linkBtn.TabIndex = 2;
            this.linkBtn.Text = "Соотнести данные";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // showLinkBtn
            // 
            this.showLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showLinkBtn.Location = new System.Drawing.Point(418, 296);
            this.showLinkBtn.Name = "showLinkBtn";
            this.showLinkBtn.Size = new System.Drawing.Size(243, 40);
            this.showLinkBtn.TabIndex = 2;
            this.showLinkBtn.Text = "Соотношения";
            this.showLinkBtn.UseVisualStyleBackColor = true;
            this.showLinkBtn.Click += new System.EventHandler(this.showLinkBtn_Click);
            // 
            // timetable
            // 
            this.timetable.AllowUserToAddRows = false;
            this.timetable.AllowUserToDeleteRows = false;
            this.timetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetable.BackgroundColor = System.Drawing.Color.White;
            this.timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ttIdCol,
            this.startCol,
            this.endCol,
            this.weekdayCol});
            this.timetable.Location = new System.Drawing.Point(12, 342);
            this.timetable.Name = "timetable";
            this.timetable.ReadOnly = true;
            this.timetable.RowHeadersWidth = 51;
            this.timetable.RowTemplate.Height = 29;
            this.timetable.Size = new System.Drawing.Size(736, 388);
            this.timetable.TabIndex = 0;
            this.timetable.Visible = false;
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
            // setDisBtn
            // 
            this.setDisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setDisBtn.Location = new System.Drawing.Point(451, 228);
            this.setDisBtn.Name = "setDisBtn";
            this.setDisBtn.Size = new System.Drawing.Size(269, 32);
            this.setDisBtn.TabIndex = 6;
            this.setDisBtn.Text = "Выбрать программу";
            this.setDisBtn.UseVisualStyleBackColor = true;
            this.setDisBtn.Visible = false;
            this.setDisBtn.Click += new System.EventHandler(this.setDisBtn_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 733);
            this.Controls.Add(this.setDisBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showLinkBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.disciplines);
            this.Name = "Form7";
            this.Text = "Список дисциплин";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView disciplines;
        private System.Windows.Forms.DataGridView teachers;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdperCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursCol;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button showLinkBtn;
        private System.Windows.Forms.DataGridView timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
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
        public System.Windows.Forms.Button setDisBtn;
        private System.Windows.Forms.Button addBtn;
    }
}