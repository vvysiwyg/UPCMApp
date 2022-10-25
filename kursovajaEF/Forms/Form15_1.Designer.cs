
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
            this.groups_timetable = new System.Windows.Forms.DataGridView();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_teachers = new System.Windows.Forms.DataGridView();
            this.groupIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groups_listeners = new System.Windows.Forms.DataGridView();
            this.listenerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups_listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // groups_timetable
            // 
            this.groups_timetable.AllowUserToAddRows = false;
            this.groups_timetable.AllowUserToDeleteRows = false;
            this.groups_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups_timetable.BackgroundColor = System.Drawing.Color.White;
            this.groups_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIdCol,
            this.ttIdCol});
            this.groups_timetable.Location = new System.Drawing.Point(12, 33);
            this.groups_timetable.Name = "groups_timetable";
            this.groups_timetable.ReadOnly = true;
            this.groups_timetable.RowHeadersWidth = 51;
            this.groups_timetable.RowTemplate.Height = 29;
            this.groups_timetable.Size = new System.Drawing.Size(422, 150);
            this.groups_timetable.TabIndex = 0;
            this.groups_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "Id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            // 
            // ttIdCol
            // 
            this.ttIdCol.HeaderText = "Id расписания";
            this.ttIdCol.MinimumWidth = 6;
            this.ttIdCol.Name = "ttIdCol";
            this.ttIdCol.ReadOnly = true;
            // 
            // groups_teachers
            // 
            this.groups_teachers.AllowUserToAddRows = false;
            this.groups_teachers.AllowUserToDeleteRows = false;
            this.groups_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups_teachers.BackgroundColor = System.Drawing.Color.White;
            this.groups_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIdCol2,
            this.teacherIdCol});
            this.groups_teachers.Location = new System.Drawing.Point(553, 33);
            this.groups_teachers.Name = "groups_teachers";
            this.groups_teachers.ReadOnly = true;
            this.groups_teachers.RowHeadersWidth = 51;
            this.groups_teachers.RowTemplate.Height = 29;
            this.groups_teachers.Size = new System.Drawing.Size(422, 150);
            this.groups_teachers.TabIndex = 0;
            this.groups_teachers.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupIdCol2
            // 
            this.groupIdCol2.HeaderText = "Id группы";
            this.groupIdCol2.MinimumWidth = 6;
            this.groupIdCol2.Name = "groupIdCol2";
            this.groupIdCol2.ReadOnly = true;
            // 
            // teacherIdCol
            // 
            this.teacherIdCol.HeaderText = "Id преподавателя";
            this.teacherIdCol.MinimumWidth = 6;
            this.teacherIdCol.Name = "teacherIdCol";
            this.teacherIdCol.ReadOnly = true;
            // 
            // groups_listeners
            // 
            this.groups_listeners.AllowUserToAddRows = false;
            this.groups_listeners.AllowUserToDeleteRows = false;
            this.groups_listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groups_listeners.BackgroundColor = System.Drawing.Color.White;
            this.groups_listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listenerIdCol,
            this.groupIdCol3});
            this.groups_listeners.Location = new System.Drawing.Point(295, 296);
            this.groups_listeners.Name = "groups_listeners";
            this.groups_listeners.ReadOnly = true;
            this.groups_listeners.RowHeadersWidth = 51;
            this.groups_listeners.RowTemplate.Height = 29;
            this.groups_listeners.Size = new System.Drawing.Size(422, 150);
            this.groups_listeners.TabIndex = 0;
            this.groups_listeners.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // listenerIdCol
            // 
            this.listenerIdCol.HeaderText = "Id слушателя";
            this.listenerIdCol.MinimumWidth = 6;
            this.listenerIdCol.Name = "listenerIdCol";
            this.listenerIdCol.ReadOnly = true;
            // 
            // groupIdCol3
            // 
            this.groupIdCol3.HeaderText = "Id группы";
            this.groupIdCol3.MinimumWidth = 6;
            this.groupIdCol3.Name = "groupIdCol3";
            this.groupIdCol3.ReadOnly = true;
            // 
            // Form15_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 458);
            this.Controls.Add(this.groups_listeners);
            this.Controls.Add(this.groups_teachers);
            this.Controls.Add(this.groups_timetable);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol;
        private System.Windows.Forms.DataGridView groups_teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdCol;
        private System.Windows.Forms.DataGridView groups_listeners;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol3;
    }
}