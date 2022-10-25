
namespace kursovajaEF.Forms
{
    partial class Form2_1
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
            this.expulsionRB = new System.Windows.Forms.RadioButton();
            this.certificateRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expulsionDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listenedHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.issueCertificate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.certificate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contract_id = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expulsionRB
            // 
            this.expulsionRB.AutoSize = true;
            this.expulsionRB.Checked = true;
            this.expulsionRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expulsionRB.Location = new System.Drawing.Point(25, 74);
            this.expulsionRB.Name = "expulsionRB";
            this.expulsionRB.Size = new System.Drawing.Size(221, 32);
            this.expulsionRB.TabIndex = 0;
            this.expulsionRB.TabStop = true;
            this.expulsionRB.Text = "Слушатель отчислен";
            this.expulsionRB.UseVisualStyleBackColor = true;
            this.expulsionRB.CheckedChanged += new System.EventHandler(this.expulsionRB_CheckedChanged);
            // 
            // certificateRB
            // 
            this.certificateRB.AutoSize = true;
            this.certificateRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.certificateRB.Location = new System.Drawing.Point(335, 61);
            this.certificateRB.Name = "certificateRB";
            this.certificateRB.Size = new System.Drawing.Size(229, 60);
            this.certificateRB.TabIndex = 0;
            this.certificateRB.Text = "Выписать сертификат\r\nслушателю";
            this.certificateRB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.expulsionDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listenedHours);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 156);
            this.panel1.TabIndex = 1;
            // 
            // expulsionDate
            // 
            this.expulsionDate.Location = new System.Drawing.Point(283, 82);
            this.expulsionDate.Name = "expulsionDate";
            this.expulsionDate.Size = new System.Drawing.Size(272, 27);
            this.expulsionDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прослушанные часы";
            // 
            // listenedHours
            // 
            this.listenedHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listenedHours.Location = new System.Drawing.Point(283, 17);
            this.listenedHours.Name = "listenedHours";
            this.listenedHours.Size = new System.Drawing.Size(272, 34);
            this.listenedHours.TabIndex = 3;
            this.listenedHours.TextChanged += new System.EventHandler(this.certificate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата отчисления";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.issueCertificate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.certificate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(25, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 156);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // issueCertificate
            // 
            this.issueCertificate.Location = new System.Drawing.Point(283, 82);
            this.issueCertificate.Name = "issueCertificate";
            this.issueCertificate.Size = new System.Drawing.Size(272, 27);
            this.issueCertificate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сертификат";
            // 
            // certificate
            // 
            this.certificate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.certificate.Location = new System.Drawing.Point(283, 17);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(272, 34);
            this.certificate.TabIndex = 3;
            this.certificate.TextChanged += new System.EventHandler(this.certificate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата выдачи сертификата";
            // 
            // contract_id
            // 
            this.contract_id.AutoSize = true;
            this.contract_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contract_id.Location = new System.Drawing.Point(12, 359);
            this.contract_id.Name = "contract_id";
            this.contract_id.Size = new System.Drawing.Size(23, 28);
            this.contract_id.TabIndex = 2;
            this.contract_id.Text = "0";
            this.contract_id.Visible = false;
            // 
            // endBtn
            // 
            this.endBtn.Enabled = false;
            this.endBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endBtn.Location = new System.Drawing.Point(160, 325);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(293, 44);
            this.endBtn.TabIndex = 3;
            this.endBtn.Text = "Завершить обучение";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 396);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contract_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.certificateRB);
            this.Controls.Add(this.expulsionRB);
            this.Name = "Form2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завершение обучения";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton expulsionRB;
        private System.Windows.Forms.RadioButton certificateRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker expulsionDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listenedHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker issueCertificate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox certificate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label contract_id;
        public System.Windows.Forms.Button endBtn;
    }
}