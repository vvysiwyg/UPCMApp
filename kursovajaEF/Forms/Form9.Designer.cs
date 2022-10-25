
namespace kursovajaEF.Forms
{
    partial class Form9
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
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.linkBtn = new System.Windows.Forms.Button();
            this.showLinkBtn = new System.Windows.Forms.Button();
            this.disciplines = new System.Windows.Forms.DataGridView();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdperCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(311, 35);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(507, 12);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(311, 35);
            this.updBtn.TabIndex = 0;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(986, 12);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(311, 35);
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // teachers
            // 
            this.teachers.AllowUserToAddRows = false;
            this.teachers.AllowUserToDeleteRows = false;
            this.teachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.teachers.Location = new System.Drawing.Point(12, 53);
            this.teachers.Name = "teachers";
            this.teachers.ReadOnly = true;
            this.teachers.RowHeadersWidth = 51;
            this.teachers.RowTemplate.Height = 29;
            this.teachers.Size = new System.Drawing.Size(1285, 221);
            this.teachers.TabIndex = 1;
            this.teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // fioCol
            // 
            this.fioCol.HeaderText = "ФИО";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(88, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Группы",
            "Дисциплины"});
            this.comboBox2.Location = new System.Drawing.Point(13, 356);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Группы";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // linkBtn
            // 
            this.linkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBtn.Location = new System.Drawing.Point(220, 350);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(243, 38);
            this.linkBtn.TabIndex = 0;
            this.linkBtn.Text = "Соотнести данные";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // showLinkBtn
            // 
            this.showLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showLinkBtn.Location = new System.Drawing.Point(507, 350);
            this.showLinkBtn.Name = "showLinkBtn";
            this.showLinkBtn.Size = new System.Drawing.Size(243, 38);
            this.showLinkBtn.TabIndex = 0;
            this.showLinkBtn.Text = "Соотношения";
            this.showLinkBtn.UseVisualStyleBackColor = true;
            this.showLinkBtn.Click += new System.EventHandler(this.showLinkBtn_Click);
            // 
            // disciplines
            // 
            this.disciplines.AllowUserToAddRows = false;
            this.disciplines.AllowUserToDeleteRows = false;
            this.disciplines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines.BackgroundColor = System.Drawing.Color.White;
            this.disciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdCol,
            this.disCol,
            this.stdperCol,
            this.hoursCol});
            this.disciplines.Location = new System.Drawing.Point(12, 415);
            this.disciplines.Name = "disciplines";
            this.disciplines.ReadOnly = true;
            this.disciplines.RowHeadersWidth = 51;
            this.disciplines.RowTemplate.Height = 29;
            this.disciplines.Size = new System.Drawing.Size(1285, 358);
            this.disciplines.TabIndex = 1;
            this.disciplines.Visible = false;
            this.disciplines.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "Id дисциплины";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            this.disciplineIdCol.Visible = false;
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
            // groups
            // 
            this.groups.AllowUserToAddRows = false;
            this.groups.AllowUserToDeleteRows = false;
            this.groups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups.BackgroundColor = System.Drawing.Color.White;
            this.groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.groupIdCol});
            this.groups.Location = new System.Drawing.Point(12, 415);
            this.groups.Name = "groups";
            this.groups.ReadOnly = true;
            this.groups.RowHeadersWidth = 51;
            this.groups.RowTemplate.Height = 29;
            this.groups.Size = new System.Drawing.Size(1285, 358);
            this.groups.TabIndex = 1;
            this.groups.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "Id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            this.groupIdCol.Visible = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 780);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.showLinkBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form9";
            this.Text = "Данные преподавателя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button showLinkBtn;
        private System.Windows.Forms.DataGridView disciplines;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdperCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursCol;
        private System.Windows.Forms.DataGridView groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
    }
}