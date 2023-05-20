
namespace kursovajaEF.Forms
{
    partial class Form15_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15_1));
            this.groups_timetable = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_teachers = new System.Windows.Forms.DataGridView();
            this.groupNumCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherFioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_listeners = new System.Windows.Forms.DataGridView();
            this.groupNumCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerFioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // groups_timetable
            // 
            this.groups_timetable.AllowUserToAddRows = false;
            this.groups_timetable.AllowUserToDeleteRows = false;
            this.groups_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.groups_timetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol});
            this.groups_timetable.Location = new System.Drawing.Point(520, 12);
            this.groups_timetable.Name = "groups_timetable";
            this.groups_timetable.ReadOnly = true;
            this.groups_timetable.RowHeadersWidth = 51;
            this.groups_timetable.RowTemplate.Height = 29;
            this.groups_timetable.Size = new System.Drawing.Size(619, 203);
            this.groups_timetable.TabIndex = 0;
            this.groups_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
            this.groupNumCol.Width = 129;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            this.weekdayCol.ReadOnly = true;
            this.weekdayCol.Width = 117;
            // 
            // startTimeCol
            // 
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            this.startTimeCol.ReadOnly = true;
            this.startTimeCol.Width = 125;
            // 
            // endTimeCol
            // 
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            this.endTimeCol.ReadOnly = true;
            this.endTimeCol.Width = 149;
            // 
            // groups_teachers
            // 
            this.groups_teachers.AllowUserToAddRows = false;
            this.groups_teachers.AllowUserToDeleteRows = false;
            this.groups_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.groups_teachers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol2,
            this.teacherFioCol});
            this.groups_teachers.Location = new System.Drawing.Point(520, 221);
            this.groups_teachers.Name = "groups_teachers";
            this.groups_teachers.ReadOnly = true;
            this.groups_teachers.RowHeadersWidth = 51;
            this.groups_teachers.RowTemplate.Height = 29;
            this.groups_teachers.Size = new System.Drawing.Size(619, 225);
            this.groups_teachers.TabIndex = 0;
            this.groups_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol2
            // 
            this.groupNumCol2.HeaderText = "Номер группы";
            this.groupNumCol2.MinimumWidth = 6;
            this.groupNumCol2.Name = "groupNumCol2";
            this.groupNumCol2.ReadOnly = true;
            this.groupNumCol2.Width = 129;
            // 
            // teacherFioCol
            // 
            this.teacherFioCol.HeaderText = "Фио преподавателя";
            this.teacherFioCol.MinimumWidth = 6;
            this.teacherFioCol.Name = "teacherFioCol";
            this.teacherFioCol.ReadOnly = true;
            this.teacherFioCol.Width = 162;
            // 
            // groups_listeners
            // 
            this.groups_listeners.AllowUserToAddRows = false;
            this.groups_listeners.AllowUserToDeleteRows = false;
            this.groups_listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.groups_listeners.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups_listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol3,
            this.listenerFioCol});
            this.groups_listeners.Location = new System.Drawing.Point(12, 12);
            this.groups_listeners.Name = "groups_listeners";
            this.groups_listeners.ReadOnly = true;
            this.groups_listeners.RowHeadersWidth = 51;
            this.groups_listeners.RowTemplate.Height = 29;
            this.groups_listeners.Size = new System.Drawing.Size(502, 434);
            this.groups_listeners.TabIndex = 0;
            this.groups_listeners.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol3
            // 
            this.groupNumCol3.HeaderText = "Номер группы";
            this.groupNumCol3.MinimumWidth = 6;
            this.groupNumCol3.Name = "groupNumCol3";
            this.groupNumCol3.ReadOnly = true;
            this.groupNumCol3.Width = 141;
            // 
            // listenerFioCol
            // 
            this.listenerFioCol.HeaderText = "Фио слушателя";
            this.listenerFioCol.MinimumWidth = 6;
            this.listenerFioCol.Name = "listenerFioCol";
            this.listenerFioCol.ReadOnly = true;
            this.listenerFioCol.Width = 143;
            // 
            // Form15_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 458);
            this.Controls.Add(this.groups_listeners);
            this.Controls.Add(this.groups_teachers);
            this.Controls.Add(this.groups_timetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список связей";
            this.Load += new System.EventHandler(this.Form15_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_listeners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groups_timetable;
        private System.Windows.Forms.DataGridView groups_teachers;
        private System.Windows.Forms.DataGridView groups_listeners;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherFioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerFioCol;
    }
}