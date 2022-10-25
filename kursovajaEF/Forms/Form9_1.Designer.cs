
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
            this.disciplines_teachers = new System.Windows.Forms.DataGridView();
            this.teacherIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_teachers = new System.Windows.Forms.DataGridView();
            this.teacherIdCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplines_teachers
            // 
            this.disciplines_teachers.AllowUserToAddRows = false;
            this.disciplines_teachers.AllowUserToDeleteRows = false;
            this.disciplines_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines_teachers.BackgroundColor = System.Drawing.Color.White;
            this.disciplines_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIdCol2,
            this.disciplineIdCol});
            this.disciplines_teachers.Location = new System.Drawing.Point(553, 32);
            this.disciplines_teachers.Name = "disciplines_teachers";
            this.disciplines_teachers.ReadOnly = true;
            this.disciplines_teachers.RowHeadersWidth = 51;
            this.disciplines_teachers.RowTemplate.Height = 29;
            this.disciplines_teachers.Size = new System.Drawing.Size(422, 414);
            this.disciplines_teachers.TabIndex = 0;
            this.disciplines_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // teacherIdCol2
            // 
            this.teacherIdCol2.HeaderText = "Id преподавателя";
            this.teacherIdCol2.MinimumWidth = 6;
            this.teacherIdCol2.Name = "teacherIdCol2";
            this.teacherIdCol2.ReadOnly = true;
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "Id дисциплины";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            // 
            // groups_teachers
            // 
            this.groups_teachers.AllowUserToAddRows = false;
            this.groups_teachers.AllowUserToDeleteRows = false;
            this.groups_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups_teachers.BackgroundColor = System.Drawing.Color.White;
            this.groups_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIdCol3,
            this.groupIdCol});
            this.groups_teachers.Location = new System.Drawing.Point(12, 32);
            this.groups_teachers.Name = "groups_teachers";
            this.groups_teachers.ReadOnly = true;
            this.groups_teachers.RowHeadersWidth = 51;
            this.groups_teachers.RowTemplate.Height = 29;
            this.groups_teachers.Size = new System.Drawing.Size(422, 414);
            this.groups_teachers.TabIndex = 0;
            this.groups_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // teacherIdCol3
            // 
            this.teacherIdCol3.HeaderText = "Id преподавателя";
            this.teacherIdCol3.MinimumWidth = 6;
            this.teacherIdCol3.Name = "teacherIdCol3";
            this.teacherIdCol3.ReadOnly = true;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "Id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            // 
            // Form9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 458);
            this.Controls.Add(this.groups_teachers);
            this.Controls.Add(this.disciplines_teachers);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridView groups_teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
    }
}