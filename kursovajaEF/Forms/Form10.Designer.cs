
namespace kursovajaEF.Forms
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.pedEx = new System.Windows.Forms.TextBox();
            this.overEx = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.phone_num = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(701, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(701, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(701, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(701, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 44);
            this.button4.TabIndex = 0;
            this.button4.Text = "Сбросить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Звание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Общий стаж";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Педагогический стаж";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Образование по диплому";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(25, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(2, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(335, 36);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(341, 27);
            this.fio.TabIndex = 2;
            this.fio.TextChanged += new System.EventHandler(this.fio_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(335, 140);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(341, 27);
            this.title.TabIndex = 2;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(335, 192);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(341, 27);
            this.position.TabIndex = 2;
            this.position.TextChanged += new System.EventHandler(this.position_TextChanged);
            // 
            // pedEx
            // 
            this.pedEx.Location = new System.Drawing.Point(335, 244);
            this.pedEx.Name = "pedEx";
            this.pedEx.Size = new System.Drawing.Size(341, 27);
            this.pedEx.TabIndex = 2;
            this.pedEx.TextChanged += new System.EventHandler(this.pedEx_TextChanged);
            // 
            // overEx
            // 
            this.overEx.Location = new System.Drawing.Point(335, 296);
            this.overEx.Name = "overEx";
            this.overEx.Size = new System.Drawing.Size(341, 27);
            this.overEx.TabIndex = 2;
            this.overEx.TextChanged += new System.EventHandler(this.overEx_TextChanged);
            // 
            // degree
            // 
            this.degree.Location = new System.Drawing.Point(335, 345);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(341, 27);
            this.degree.TabIndex = 2;
            this.degree.TextChanged += new System.EventHandler(this.degree_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(335, 452);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(341, 27);
            this.email.TabIndex = 2;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(335, 86);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(341, 27);
            this.dob.TabIndex = 3;
            // 
            // phone_num
            // 
            this.phone_num.Location = new System.Drawing.Point(335, 400);
            this.phone_num.Mask = "9(999) 000-0000";
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(341, 27);
            this.phone_num.TabIndex = 4;
            this.phone_num.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.overEx);
            this.Controls.Add(this.pedEx);
            this.Controls.Add(this.position);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные преподавателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox fio;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.TextBox position;
        public System.Windows.Forms.TextBox pedEx;
        public System.Windows.Forms.TextBox overEx;
        public System.Windows.Forms.TextBox degree;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.DateTimePicker dob;
        public System.Windows.Forms.MaskedTextBox phone_num;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
    }
}