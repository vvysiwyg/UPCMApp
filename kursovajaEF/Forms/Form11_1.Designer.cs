
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
            this.groups_timetable = new System.Windows.Forms.DataGridView();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttIdCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplines_timetable = new System.Windows.Forms.DataGridView();
            this.disciplineIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttIdCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groups_timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines_timetable)).BeginInit();
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
            this.ttIdCol2});
            this.groups_timetable.Location = new System.Drawing.Point(553, 33);
            this.groups_timetable.Name = "groups_timetable";
            this.groups_timetable.ReadOnly = true;
            this.groups_timetable.RowHeadersWidth = 51;
            this.groups_timetable.RowTemplate.Height = 29;
            this.groups_timetable.Size = new System.Drawing.Size(422, 413);
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
            // ttIdCol2
            // 
            this.ttIdCol2.HeaderText = "Id расписания";
            this.ttIdCol2.MinimumWidth = 6;
            this.ttIdCol2.Name = "ttIdCol2";
            this.ttIdCol2.ReadOnly = true;
            // 
            // disciplines_timetable
            // 
            this.disciplines_timetable.AllowUserToAddRows = false;
            this.disciplines_timetable.AllowUserToDeleteRows = false;
            this.disciplines_timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplines_timetable.BackgroundColor = System.Drawing.Color.White;
            this.disciplines_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdCol,
            this.ttIdCol3});
            this.disciplines_timetable.Location = new System.Drawing.Point(12, 33);
            this.disciplines_timetable.Name = "disciplines_timetable";
            this.disciplines_timetable.ReadOnly = true;
            this.disciplines_timetable.RowHeadersWidth = 51;
            this.disciplines_timetable.RowTemplate.Height = 29;
            this.disciplines_timetable.Size = new System.Drawing.Size(422, 413);
            this.disciplines_timetable.TabIndex = 0;
            this.disciplines_timetable.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // disciplineIdCol
            // 
            this.disciplineIdCol.HeaderText = "Id дисциплины";
            this.disciplineIdCol.MinimumWidth = 6;
            this.disciplineIdCol.Name = "disciplineIdCol";
            this.disciplineIdCol.ReadOnly = true;
            // 
            // ttIdCol3
            // 
            this.ttIdCol3.HeaderText = "Id расписания";
            this.ttIdCol3.MinimumWidth = 6;
            this.ttIdCol3.Name = "ttIdCol3";
            this.ttIdCol3.ReadOnly = true;
            // 
            // Form11_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 458);
            this.Controls.Add(this.disciplines_timetable);
            this.Controls.Add(this.groups_timetable);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttIdCol2;
    }
}