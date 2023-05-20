
namespace kursovajaEF.Forms
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupNum = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.startLearning = new System.Windows.Forms.DateTimePicker();
            this.endLearning = new System.Windows.Forms.DateTimePicker();
            this.disciplineName = new System.Windows.Forms.ComboBox();
            this.numOfHours = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.addGIBtn = new System.Windows.Forms.Button();
            this.delGIBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupInfoIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endLearningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(758, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Программа, изучаемая в группе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество часов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "День недели";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(280, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Время начала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(530, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Время окончания";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(788, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Дата начала обучения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1075, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Дата окончания обучения";
            // 
            // groupNum
            // 
            this.groupNum.Location = new System.Drawing.Point(391, 45);
            this.groupNum.Name = "groupNum";
            this.groupNum.Size = new System.Drawing.Size(339, 27);
            this.groupNum.TabIndex = 2;
            // 
            // weekday
            // 
            this.weekday.Location = new System.Drawing.Point(33, 236);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(183, 27);
            this.weekday.TabIndex = 2;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(285, 236);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(183, 27);
            this.startTime.TabIndex = 2;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(535, 238);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(183, 27);
            this.endTime.TabIndex = 2;
            // 
            // startLearning
            // 
            this.startLearning.Location = new System.Drawing.Point(793, 236);
            this.startLearning.Name = "startLearning";
            this.startLearning.Size = new System.Drawing.Size(212, 27);
            this.startLearning.TabIndex = 3;
            // 
            // endLearning
            // 
            this.endLearning.Location = new System.Drawing.Point(1080, 234);
            this.endLearning.Name = "endLearning";
            this.endLearning.Size = new System.Drawing.Size(212, 27);
            this.endLearning.TabIndex = 3;
            // 
            // disciplineName
            // 
            this.disciplineName.FormattingEnabled = true;
            this.disciplineName.Location = new System.Drawing.Point(1121, 44);
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.Size = new System.Drawing.Size(339, 28);
            this.disciplineName.TabIndex = 4;
            // 
            // numOfHours
            // 
            this.numOfHours.Location = new System.Drawing.Point(391, 107);
            this.numOfHours.Name = "numOfHours";
            this.numOfHours.Size = new System.Drawing.Size(339, 27);
            this.numOfHours.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1960, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(339, 27);
            this.textBox6.TabIndex = 2;
            // 
            // addGIBtn
            // 
            this.addGIBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGIBtn.ForeColor = System.Drawing.Color.Green;
            this.addGIBtn.Location = new System.Drawing.Point(1357, 227);
            this.addGIBtn.Name = "addGIBtn";
            this.addGIBtn.Size = new System.Drawing.Size(40, 40);
            this.addGIBtn.TabIndex = 5;
            this.addGIBtn.Text = "+";
            this.addGIBtn.UseVisualStyleBackColor = true;
            this.addGIBtn.Click += new System.EventHandler(this.addGIBtn_Click);
            // 
            // delGIBtn
            // 
            this.delGIBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delGIBtn.ForeColor = System.Drawing.Color.Red;
            this.delGIBtn.Location = new System.Drawing.Point(1420, 226);
            this.delGIBtn.Name = "delGIBtn";
            this.delGIBtn.Size = new System.Drawing.Size(40, 40);
            this.delGIBtn.TabIndex = 5;
            this.delGIBtn.Text = "x";
            this.delGIBtn.UseVisualStyleBackColor = true;
            this.delGIBtn.Click += new System.EventHandler(this.delGIBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(315, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(597, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сбросить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(32, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(32, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupInfoIdCol,
            this.weekdayCol,
            this.startTimeCol,
            this.endTimeCol,
            this.startLearningCol,
            this.endLearningCol});
            this.dataGridView1.Location = new System.Drawing.Point(33, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1450, 228);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // groupInfoIdCol
            // 
            this.groupInfoIdCol.HeaderText = "id информации о группе";
            this.groupInfoIdCol.MinimumWidth = 6;
            this.groupInfoIdCol.Name = "groupInfoIdCol";
            this.groupInfoIdCol.Visible = false;
            // 
            // weekdayCol
            // 
            this.weekdayCol.HeaderText = "День недели";
            this.weekdayCol.MinimumWidth = 6;
            this.weekdayCol.Name = "weekdayCol";
            // 
            // startTimeCol
            // 
            this.startTimeCol.HeaderText = "Время начала";
            this.startTimeCol.MinimumWidth = 6;
            this.startTimeCol.Name = "startTimeCol";
            // 
            // endTimeCol
            // 
            this.endTimeCol.HeaderText = "Время окончания";
            this.endTimeCol.MinimumWidth = 6;
            this.endTimeCol.Name = "endTimeCol";
            // 
            // startLearningCol
            // 
            this.startLearningCol.HeaderText = "Дата начала обучения";
            this.startLearningCol.MinimumWidth = 6;
            this.startLearningCol.Name = "startLearningCol";
            // 
            // endLearningCol
            // 
            this.endLearningCol.HeaderText = "Дата окончания обучения";
            this.endLearningCol.MinimumWidth = 6;
            this.endLearningCol.Name = "endLearningCol";
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delGIBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addGIBtn);
            this.Controls.Add(this.disciplineName);
            this.Controls.Add(this.endLearning);
            this.Controls.Add(this.startLearning);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.numOfHours);
            this.Controls.Add(this.groupNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Список групп";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox groupNum;
        public System.Windows.Forms.TextBox weekday;
        public System.Windows.Forms.TextBox startTime;
        public System.Windows.Forms.TextBox endTime;
        public System.Windows.Forms.DateTimePicker startLearning;
        public System.Windows.Forms.DateTimePicker endLearning;
        public System.Windows.Forms.ComboBox disciplineName;
        public System.Windows.Forms.TextBox numOfHours;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button addGIBtn;
        private System.Windows.Forms.Button delGIBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupInfoIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLearningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endLearningCol;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}