
namespace kursovajaEF.Forms
{
    partial class Form11_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11_1));
            this.groups_timetable = new System.Windows.Forms.DataGridView();
            this.groupNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplines_timetable = new System.Windows.Forms.DataGridView();
            this.disciplineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // groups_timetable
            // 
            this.groups_timetable.AllowUserToAddRows = false;
            this.groups_timetable.AllowUserToDeleteRows = false;
            this.groups_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups_timetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groups_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol});
            this.groups_timetable.Location = new System.Drawing.Point(667, 33);
            this.groups_timetable.Name = "groups_timetable";
            this.groups_timetable.ReadOnly = true;
            this.groups_timetable.RowHeadersWidth = 51;
            this.groups_timetable.RowTemplate.Height = 29;
            this.groups_timetable.Size = new System.Drawing.Size(570, 413);
            this.groups_timetable.TabIndex = 0;
            this.groups_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupNumCol
            // 
            this.groupNumCol.HeaderText = "Номер группы";
            this.groupNumCol.MinimumWidth = 6;
            this.groupNumCol.Name = "groupNumCol";
            this.groupNumCol.ReadOnly = true;
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
            // disciplines_timetable
            // 
            this.disciplines_timetable.AllowUserToAddRows = false;
            this.disciplines_timetable.AllowUserToDeleteRows = false;
            this.disciplines_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines_timetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.disciplines_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineCol,
            this.weekdayCol2,
            this.startTimeCol2,
            this.endTimeCol2});
            this.disciplines_timetable.Location = new System.Drawing.Point(12, 33);
            this.disciplines_timetable.Name = "disciplines_timetable";
            this.disciplines_timetable.ReadOnly = true;
            this.disciplines_timetable.RowHeadersWidth = 51;
            this.disciplines_timetable.RowTemplate.Height = 29;
            this.disciplines_timetable.Size = new System.Drawing.Size(570, 413);
            this.disciplines_timetable.TabIndex = 0;
            this.disciplines_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineCol
            // 
            this.disciplineCol.HeaderText = "Дисциплина";
            this.disciplineCol.MinimumWidth = 6;
            this.disciplineCol.Name = "disciplineCol";
            this.disciplineCol.ReadOnly = true;
            // 
            // weekdayCol2
            // 
            this.weekdayCol2.HeaderText = "День недели";
            this.weekdayCol2.MinimumWidth = 6;
            this.weekdayCol2.Name = "weekdayCol2";
            this.weekdayCol2.ReadOnly = true;
            // 
            // startTimeCol2
            // 
            this.startTimeCol2.HeaderText = "Время начала";
            this.startTimeCol2.MinimumWidth = 6;
            this.startTimeCol2.Name = "startTimeCol2";
            this.startTimeCol2.ReadOnly = true;
            // 
            // endTimeCol2
            // 
            this.endTimeCol2.HeaderText = "Время окончания";
            this.endTimeCol2.MinimumWidth = 6;
            this.endTimeCol2.Name = "endTimeCol2";
            this.endTimeCol2.ReadOnly = true;
            // 
            // Form11_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 474);
            this.Controls.Add(this.disciplines_timetable);
            this.Controls.Add(this.groups_timetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список связей";
            this.Load += new System.EventHandler(this.Form11_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView groups_timetable;
        private System.Windows.Forms.DataGridView disciplines_timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol2;
    }
}