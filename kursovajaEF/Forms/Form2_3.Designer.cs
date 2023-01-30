
namespace kursovajaEF.Forms
{
    partial class Form2_3
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
            this.issueAnOrderBtn = new System.Windows.Forms.Button();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.orderNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contract_id = new System.Windows.Forms.Label();
            this.expulsionOrderRB = new System.Windows.Forms.RadioButton();
            this.enrollmentOrderRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // issueAnOrderBtn
            // 
            this.issueAnOrderBtn.Enabled = false;
            this.issueAnOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issueAnOrderBtn.Location = new System.Drawing.Point(157, 300);
            this.issueAnOrderBtn.Name = "issueAnOrderBtn";
            this.issueAnOrderBtn.Size = new System.Drawing.Size(293, 44);
            this.issueAnOrderBtn.TabIndex = 9;
            this.issueAnOrderBtn.Text = "Оформить распоряжение";
            this.issueAnOrderBtn.UseVisualStyleBackColor = true;
            this.issueAnOrderBtn.Click += new System.EventHandler(this.issueAnOrderBtn_Click);
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(305, 218);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(272, 27);
            this.orderDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер";
            // 
            // orderNumber
            // 
            this.orderNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderNumber.Location = new System.Drawing.Point(305, 156);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(272, 34);
            this.orderNumber.TabIndex = 3;
            this.orderNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата";
            // 
            // contract_id
            // 
            this.contract_id.AutoSize = true;
            this.contract_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contract_id.Location = new System.Drawing.Point(12, 326);
            this.contract_id.Name = "contract_id";
            this.contract_id.Size = new System.Drawing.Size(23, 28);
            this.contract_id.TabIndex = 8;
            this.contract_id.Text = "0";
            this.contract_id.Visible = false;
            // 
            // expulsionOrderRB
            // 
            this.expulsionOrderRB.AutoSize = true;
            this.expulsionOrderRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expulsionOrderRB.Location = new System.Drawing.Point(331, 74);
            this.expulsionOrderRB.Name = "expulsionOrderRB";
            this.expulsionOrderRB.Size = new System.Drawing.Size(274, 32);
            this.expulsionOrderRB.TabIndex = 4;
            this.expulsionOrderRB.Text = "Об отчислении слушателя";
            this.expulsionOrderRB.UseVisualStyleBackColor = true;
            // 
            // enrollmentOrderRB
            // 
            this.enrollmentOrderRB.AutoSize = true;
            this.enrollmentOrderRB.Checked = true;
            this.enrollmentOrderRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrollmentOrderRB.Location = new System.Drawing.Point(25, 74);
            this.enrollmentOrderRB.Name = "enrollmentOrderRB";
            this.enrollmentOrderRB.Size = new System.Drawing.Size(261, 32);
            this.enrollmentOrderRB.TabIndex = 5;
            this.enrollmentOrderRB.TabStop = true;
            this.enrollmentOrderRB.Text = "О зачислении слушателя";
            this.enrollmentOrderRB.UseVisualStyleBackColor = true;
            // 
            // Form2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.issueAnOrderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contract_id);
            this.Controls.Add(this.expulsionOrderRB);
            this.Controls.Add(this.enrollmentOrderRB);
            this.Name = "Form2_3";
            this.Text = "Оформление распоряжения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button issueAnOrderBtn;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderNumber;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label contract_id;
        private System.Windows.Forms.RadioButton expulsionOrderRB;
        private System.Windows.Forms.RadioButton enrollmentOrderRB;
    }
}