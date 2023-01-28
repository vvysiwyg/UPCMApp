
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
            this.disciplines_timetable = new System.Windows.Forms.DataGridView();
            this.disciplineNameCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherFioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplines_teachers
            // 
            this.disciplines_teachers.AllowUserToAddRows = false;
            this.disciplines_teachers.AllowUserToDeleteRows = false;
            this.disciplines_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.disciplines_teachers.BackgroundColor = System.Drawing.Color.White;
            this.disciplines_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineNameCol2,
            this.teacherFioCol});
            this.disciplines_teachers.Location = new System.Drawing.Point(635, 37);
            this.disciplines_teachers.Name = "disciplines_teachers";
            this.disciplines_teachers.ReadOnly = true;
            this.disciplines_teachers.RowHeadersWidth = 51;
            this.disciplines_teachers.RowTemplate.Height = 29;
            this.disciplines_teachers.Size = new System.Drawing.Size(448, 409);
            this.disciplines_teachers.TabIndex = 0;
            this.disciplines_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplines_timetable
            // 
            this.disciplines_timetable.AllowUserToAddRows = false;
            this.disciplines_timetable.AllowUserToDeleteRows = false;
            this.disciplines_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.disciplines_timetable.BackgroundColor = System.Drawing.Color.White;
            this.disciplines_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineNameCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol});
            this.disciplines_timetable.Location = new System.Drawing.Point(12, 37);
            this.disciplines_timetable.Name = "disciplines_timetable";
            this.disciplines_timetable.ReadOnly = true;
            this.disciplines_timetable.RowHeadersWidth = 51;
            this.disciplines_timetable.RowTemplate.Height = 29;
            this.disciplines_timetable.Size = new System.Drawing.Size(603, 409);
            this.disciplines_timetable.TabIndex = 0;
            this.disciplines_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineNameCol2
            // 
            this.disciplineNameCol2.HeaderText = "Дисциплина";
            this.disciplineNameCol2.MinimumWidth = 6;
            this.disciplineNameCol2.Name = "disciplineNameCol2";
            this.disciplineNameCol2.ReadOnly = true;
            this.disciplineNameCol2.Width = 125;
            // 
            // teacherFioCol
            // 
            this.teacherFioCol.HeaderText = "Фио преподавателя";
            this.teacherFioCol.MinimumWidth = 6;
            this.teacherFioCol.Name = "teacherFioCol";
            this.teacherFioCol.ReadOnly = true;
            this.teacherFioCol.Width = 162;
            // 
            // disciplineNameCol
            // 
            this.disciplineNameCol.HeaderText = "Дисциплина";
            this.disciplineNameCol.MinimumWidth = 6;
            this.disciplineNameCol.Name = "disciplineNameCol";
            this.disciplineNameCol.ReadOnly = true;
            this.disciplineNameCol.Width = 125;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            this.weekdayCol.ReadOnly = true;
            this.weekdayCol.Width = 127;
            // 
            // startTimeCol
            // 
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            this.startTimeCol.ReadOnly = true;
            this.startTimeCol.Width = 136;
            // 
            // endTimeCol
            // 
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            this.endTimeCol.ReadOnly = true;
            this.endTimeCol.Width = 149;
            // 
            // Form7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 458);
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
        private System.Windows.Forms.DataGridView disciplines_timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherFioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
    }
}