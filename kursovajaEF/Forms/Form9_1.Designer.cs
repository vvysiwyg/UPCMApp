
namespace kursovajaEF.Forms
{
    partial class Form9_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9_1));
            this.disciplines_teachers = new System.Windows.Forms.DataGridView();
            this.teacherFioCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_teachers = new System.Windows.Forms.DataGridView();
            this.teacherFioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplines_teachers
            // 
            this.disciplines_teachers.AllowUserToAddRows = false;
            this.disciplines_teachers.AllowUserToDeleteRows = false;
            this.disciplines_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.disciplines_teachers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.disciplines_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherFioCol2,
            this.disciplineNameCol});
            this.disciplines_teachers.Location = new System.Drawing.Point(517, 32);
            this.disciplines_teachers.Name = "disciplines_teachers";
            this.disciplines_teachers.ReadOnly = true;
            this.disciplines_teachers.RowHeadersWidth = 51;
            this.disciplines_teachers.RowTemplate.Height = 29;
            this.disciplines_teachers.Size = new System.Drawing.Size(458, 414);
            this.disciplines_teachers.TabIndex = 0;
            this.disciplines_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // teacherFioCol2
            // 
            this.teacherFioCol2.HeaderText = "Фио преподавателя";
            this.teacherFioCol2.MinimumWidth = 6;
            this.teacherFioCol2.Name = "teacherFioCol2";
            this.teacherFioCol2.ReadOnly = true;
            this.teacherFioCol2.Width = 162;
            // 
            // disciplineNameCol
            // 
            this.disciplineNameCol.HeaderText = "Дисциплина";
            this.disciplineNameCol.MinimumWidth = 6;
            this.disciplineNameCol.Name = "disciplineNameCol";
            this.disciplineNameCol.ReadOnly = true;
            this.disciplineNameCol.Width = 125;
            // 
            // groups_teachers
            // 
            this.groups_teachers.AllowUserToAddRows = false;
            this.groups_teachers.AllowUserToDeleteRows = false;
            this.groups_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.groups_teachers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherFioCol,
            this.groupNumCol});
            this.groups_teachers.Location = new System.Drawing.Point(12, 32);
            this.groups_teachers.Name = "groups_teachers";
            this.groups_teachers.ReadOnly = true;
            this.groups_teachers.RowHeadersWidth = 51;
            this.groups_teachers.RowTemplate.Height = 29;
            this.groups_teachers.Size = new System.Drawing.Size(465, 414);
            this.groups_teachers.TabIndex = 0;
            this.groups_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // teacherFioCol
            // 
            this.teacherFioCol.HeaderText = "Фио преподавателя";
            this.teacherFioCol.MinimumWidth = 6;
            this.teacherFioCol.Name = "teacherFioCol";
            this.teacherFioCol.ReadOnly = true;
            this.teacherFioCol.Width = 162;
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            this.groupNumCol.Width = 129;
            // 
            // Form9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 458);
            this.Controls.Add(this.groups_teachers);
            this.Controls.Add(this.disciplines_teachers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список связей";
            this.Load += new System.EventHandler(this.Form9_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView disciplines_teachers;
        private System.Windows.Forms.DataGridView groups_teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherFioCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherFioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
    }
}