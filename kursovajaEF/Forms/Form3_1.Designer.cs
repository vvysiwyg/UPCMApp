
namespace kursovajaEF.Forms
{
    partial class Form3_1
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
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удалить слушателя ?";
            // 
            // yesBtn
            // 
            this.yesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.Location = new System.Drawing.Point(12, 132);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(171, 49);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Да";
            this.yesBtn.UseVisualStyleBackColor = true;
            // 
            // noBtn
            // 
            this.noBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBtn.Location = new System.Drawing.Point(231, 132);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(171, 49);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "Нет";
            this.noBtn.UseVisualStyleBackColor = true;
            // 
            // Form3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 193);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form3_1";
            this.Text = "Form3_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
    }
}