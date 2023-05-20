
namespace kursovajaEF.Forms
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.chairs = new System.Windows.Forms.DataGridView();
            this.chairIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chairNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseСBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chairs)).BeginInit();
            this.SuspendLayout();
            // 
            // chairs
            // 
            this.chairs.AllowUserToAddRows = false;
            this.chairs.AllowUserToDeleteRows = false;
            this.chairs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chairs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.chairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chairIdCol,
            this.chairNameCol});
            this.chairs.Location = new System.Drawing.Point(12, 12);
            this.chairs.Name = "chairs";
            this.chairs.ReadOnly = true;
            this.chairs.RowHeadersWidth = 51;
            this.chairs.RowTemplate.Height = 29;
            this.chairs.Size = new System.Drawing.Size(567, 242);
            this.chairs.TabIndex = 1;
            this.chairs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chairs_CellDoubleClick);
            this.chairs.Sorted += new System.EventHandler(this.chairs_Sorted);
            // 
            // chairIdCol
            // 
            this.chairIdCol.HeaderText = "id кафедры";
            this.chairIdCol.MinimumWidth = 6;
            this.chairIdCol.Name = "chairIdCol";
            this.chairIdCol.ReadOnly = true;
            this.chairIdCol.Visible = false;
            // 
            // chairNameCol
            // 
            this.chairNameCol.FillWeight = 25.66845F;
            this.chairNameCol.HeaderText = "Кафедра";
            this.chairNameCol.MinimumWidth = 6;
            this.chairNameCol.Name = "chairNameCol";
            this.chairNameCol.ReadOnly = true;
            // 
            // chooseСBtn
            // 
            this.chooseСBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseСBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseСBtn.Location = new System.Drawing.Point(12, 272);
            this.chooseСBtn.Name = "chooseСBtn";
            this.chooseСBtn.Size = new System.Drawing.Size(269, 44);
            this.chooseСBtn.TabIndex = 2;
            this.chooseСBtn.Text = "Выбрать кафедру";
            this.chooseСBtn.UseVisualStyleBackColor = true;
            this.chooseСBtn.Visible = false;
            this.chooseСBtn.Click += new System.EventHandler(this.chooseСBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delBtn.Location = new System.Drawing.Point(597, 210);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(269, 44);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updBtn.Location = new System.Drawing.Point(597, 109);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(269, 44);
            this.updBtn.TabIndex = 4;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(597, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(269, 44);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 337);
            this.Controls.Add(this.chooseСBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.chairs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафедры";
            ((System.ComponentModel.ISupportInitialize)(this.chairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn chairIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn chairNameCol;
        public System.Windows.Forms.Button chooseСBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button addBtn;
    }
}