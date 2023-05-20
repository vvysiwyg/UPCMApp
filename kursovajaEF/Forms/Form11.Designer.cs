
namespace kursovajaEF.Forms
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.timetable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.linkBtn = new System.Windows.Forms.Button();
            this.showLinkBtn = new System.Windows.Forms.Button();
            this.disciplines = new System.Windows.Forms.DataGridView();
            this.disciplineIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdperCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.AllowUserToAddRows = false;
            this.timetable.AllowUserToDeleteRows = false;
            this.timetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.startCol,
            this.endCol,
            this.weekdayCol});
            this.timetable.Location = new System.Drawing.Point(12, 12);
            this.timetable.Name = "timetable";
            this.timetable.ReadOnly = true;
            this.timetable.RowHeadersWidth = 51;
            this.timetable.RowTemplate.Height = 29;
            this.timetable.Size = new System.Drawing.Size(1119, 197);
            this.timetable.TabIndex = 0;
            this.timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id расписания";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
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
            // updBtn
            // 
            this.updBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updBtn.Location = new System.Drawing.Point(1164, 97);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(269, 32);
            this.updBtn.TabIndex = 1;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(87, 220);
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
            "Группы",
            "Дисциплины"});
            this.comboBox2.Location = new System.Drawing.Point(12, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Группы";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // linkBtn
            // 
            this.linkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBtn.Location = new System.Drawing.Point(190, 266);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(243, 38);
            this.linkBtn.TabIndex = 1;
            this.linkBtn.Text = "Соотнести данные";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // showLinkBtn
            // 
            this.showLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showLinkBtn.Location = new System.Drawing.Point(479, 266);
            this.showLinkBtn.Name = "showLinkBtn";
            this.showLinkBtn.Size = new System.Drawing.Size(243, 38);
            this.showLinkBtn.TabIndex = 1;
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
            this.disciplines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.disciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdCol2,
            this.disCol,
            this.stdperCol,
            this.hoursCol});
            this.disciplines.Location = new System.Drawing.Point(12, 317);
            this.disciplines.Name = "disciplines";
            this.disciplines.ReadOnly = true;
            this.disciplines.RowHeadersWidth = 51;
            this.disciplines.RowTemplate.Height = 29;
            this.disciplines.Size = new System.Drawing.Size(1433, 412);
            this.disciplines.TabIndex = 0;
            this.disciplines.Visible = false;
            this.disciplines.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineIdCol2
            // 
            this.disciplineIdCol2.HeaderText = "Id дисциплины";
            this.disciplineIdCol2.MinimumWidth = 6;
            this.disciplineIdCol2.Name = "disciplineIdCol2";
            this.disciplineIdCol2.ReadOnly = true;
            this.disciplineIdCol2.Visible = false;
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
            this.groups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.groupIdCol2});
            this.groups.Location = new System.Drawing.Point(12, 317);
            this.groups.Name = "groups";
            this.groups.ReadOnly = true;
            this.groups.RowHeadersWidth = 51;
            this.groups.RowTemplate.Height = 29;
            this.groups.Size = new System.Drawing.Size(1433, 412);
            this.groups.TabIndex = 0;
            this.groups.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            // 
            // groupIdCol2
            // 
            this.groupIdCol2.HeaderText = "Id группы";
            this.groupIdCol2.MinimumWidth = 6;
            this.groupIdCol2.Name = "groupIdCol2";
            this.groupIdCol2.ReadOnly = true;
            this.groupIdCol2.Visible = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 733);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.showLinkBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.timetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Расписание";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timetable;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button showLinkBtn;
        private System.Windows.Forms.DataGridView disciplines;
        private System.Windows.Forms.DataGridView groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdperCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol2;
    }
}