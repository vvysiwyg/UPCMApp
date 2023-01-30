
namespace kursovajaEF.Forms
{
    partial class Form9_2
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
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.issueAnOrderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.orderNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.Label();
            this.discipline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discipline_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(305, 239);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(272, 27);
            this.orderDate.TabIndex = 13;
            // 
            // issueAnOrderBtn
            // 
            this.issueAnOrderBtn.Enabled = false;
            this.issueAnOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issueAnOrderBtn.Location = new System.Drawing.Point(157, 310);
            this.issueAnOrderBtn.Name = "issueAnOrderBtn";
            this.issueAnOrderBtn.Size = new System.Drawing.Size(293, 44);
            this.issueAnOrderBtn.TabIndex = 17;
            this.issueAnOrderBtn.Text = "Оформить распоряжение";
            this.issueAnOrderBtn.UseVisualStyleBackColor = true;
            this.issueAnOrderBtn.Click += new System.EventHandler(this.issueAnOrderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер";
            // 
            // orderNumber
            // 
            this.orderNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderNumber.Location = new System.Drawing.Point(305, 166);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(272, 34);
            this.orderNumber.TabIndex = 12;
            this.orderNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата";
            // 
            // teacher_id
            // 
            this.teacher_id.AutoSize = true;
            this.teacher_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacher_id.Location = new System.Drawing.Point(12, 336);
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(23, 28);
            this.teacher_id.TabIndex = 16;
            this.teacher_id.Text = "0";
            this.teacher_id.Visible = false;
            // 
            // discipline
            // 
            this.discipline.Enabled = false;
            this.discipline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discipline.Location = new System.Drawing.Point(305, 102);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(272, 34);
            this.discipline.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Программа";
            // 
            // teacher
            // 
            this.teacher.Enabled = false;
            this.teacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacher.Location = new System.Drawing.Point(305, 39);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(272, 34);
            this.teacher.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Преподаватель";
            // 
            // discipline_id
            // 
            this.discipline_id.AutoSize = true;
            this.discipline_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discipline_id.Location = new System.Drawing.Point(41, 336);
            this.discipline_id.Name = "discipline_id";
            this.discipline_id.Size = new System.Drawing.Size(23, 28);
            this.discipline_id.TabIndex = 16;
            this.discipline_id.Text = "0";
            this.discipline_id.Visible = false;
            // 
            // Form9_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.issueAnOrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.discipline);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discipline_id);
            this.Controls.Add(this.teacher_id);
            this.Name = "Form9_2";
            this.Text = "Оформление распоряжения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker orderDate;
        public System.Windows.Forms.Button issueAnOrderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderNumber;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label teacher_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label discipline_id;
        public System.Windows.Forms.TextBox discipline;
        public System.Windows.Forms.TextBox teacher;
    }
}