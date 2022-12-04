
namespace kursovajaEF.Forms
{
    partial class Form2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.transferBtn = new System.Windows.Forms.Button();
            this.contract_id = new System.Windows.Forms.Label();
            this.transferGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группа";
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(97, 129);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(158, 36);
            this.transferBtn.TabIndex = 2;
            this.transferBtn.Text = "Перевести";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // contract_id
            // 
            this.contract_id.AutoSize = true;
            this.contract_id.Location = new System.Drawing.Point(12, 177);
            this.contract_id.Name = "contract_id";
            this.contract_id.Size = new System.Drawing.Size(17, 20);
            this.contract_id.TabIndex = 3;
            this.contract_id.Text = "0";
            this.contract_id.Visible = false;
            // 
            // transferGroup
            // 
            this.transferGroup.FormattingEnabled = true;
            this.transferGroup.IntegralHeight = false;
            this.transferGroup.Location = new System.Drawing.Point(174, 62);
            this.transferGroup.Name = "transferGroup";
            this.transferGroup.Size = new System.Drawing.Size(171, 28);
            this.transferGroup.TabIndex = 4;
            // 
            // Form2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 198);
            this.Controls.Add(this.transferGroup);
            this.Controls.Add(this.contract_id);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form2_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевод в группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transferBtn;
        public System.Windows.Forms.Label contract_id;
        private System.Windows.Forms.ComboBox transferGroup;
    }
}