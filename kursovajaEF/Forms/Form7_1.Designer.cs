
namespace kursovajaEF.Forms
{
    partial class Form7_1
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
            this.disciplineIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplines_timetable = new System.Windows.Forms.DataGridView();
            this.disciplineIdCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).BeginInit();
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
            this.disciplineIdCol2,
            this.teacherIdCol});
            this.disciplines_teachers.Location = new System.Drawing.Point(553, 37);
            this.disciplines_teachers.Name = "disciplines_teachers";
            this.disciplines_teachers.ReadOnly = true;
            this.disciplines_teachers.RowHeadersWidth = 51;
            this.disciplines_teachers.RowTemplate.Height = 29;
            this.disciplines_teachers.Size = new System.Drawing.Size(422, 409);
            this.disciplines_teachers.TabIndex = 0;
            this.disciplines_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineIdCol2
            // 
            this.disciplineIdCol2.HeaderText = "Id дисциплины";
            this.disciplineIdCol2.MinimumWidth = 6;
            this.disciplineIdCol2.Name = "disciplineIdCol2";
            this.disciplineIdCol2.ReadOnly = true;
            // 
            // teacherIdCol
            // 
            this.teacherIdCol.HeaderText = "Id преподавателя";
            this.teacherIdCol.MinimumWidth = 6;
            this.teacherIdCol.Name = "teacherIdCol";
            this.teacherIdCol.ReadOnly = true;
            // 
            // disciplines_timetable
            // 
            this.disciplines_timetable.AllowUserToAddRows = false;
            this.disciplines_timetable.AllowUserToDeleteRows = false;
            this.disciplines_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines_timetable.BackgroundColor = System.Drawing.Color.White;
            this.disciplines_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdCol3,
            this.ttIdCol});
            this.disciplines_timetable.Location = new System.Drawing.Point(12, 37);
            this.disciplines_timetable.Name = "disciplines_timetable";
            this.disciplines_timetable.ReadOnly = true;
            this.disciplines_timetable.RowHeadersWidth = 51;
            this.disciplines_timetable.RowTemplate.Height = 29;
            this.disciplines_timetable.Size = new System.Drawing.Size(422, 409);
            this.disciplines_timetable.TabIndex = 0;
            this.disciplines_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineIdCol3
            // 
            this.disciplineIdCol3.HeaderText = "Id дисциплины";
            this.disciplineIdCol3.MinimumWidth = 6;
            this.disciplineIdCol3.Name = "disciplineIdCol3";
            this.disciplineIdCol3.ReadOnly = true;
            // 
            // ttIdCol
            // 
            this.ttIdCol.HeaderText = "Id расписания";
            this.ttIdCol.MinimumWidth = 6;
            this.ttIdCol.Name = "ttIdCol";
            this.ttIdCol.ReadOnly = true;
            // 
            // Form7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 458);
            this.Controls.Add(this.disciplines_timetable);
            this.Controls.Add(this.disciplines_teachers);
            this.Name = "Form7_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список связей";
            this.Load += new System.EventHandler(this.Form7_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView disciplines_teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdCol;
        private System.Windows.Forms.DataGridView disciplines_timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol;
    }
}