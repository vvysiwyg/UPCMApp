
namespace kursovajaEF.Forms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolGradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameCol,
            this.midnameCol,
            this.lastnameCol,
            this.yobCol,
            this.sexCol,
            this.idCol,
            this.matriculationCol,
            this.phoneNumCol,
            this.schoolGradeCol,
            this.emailCol,
            this.listenerCategoryCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1432, 577);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // firstnameCol
            // 
            this.firstnameCol.HeaderText = "Имя";
            this.firstnameCol.MinimumWidth = 6;
            this.firstnameCol.Name = "firstnameCol";
            // 
            // midnameCol
            // 
            this.midnameCol.HeaderText = "Фамилия";
            this.midnameCol.MinimumWidth = 6;
            this.midnameCol.Name = "midnameCol";
            // 
            // lastnameCol
            // 
            this.lastnameCol.HeaderText = "Отчество";
            this.lastnameCol.MinimumWidth = 6;
            this.lastnameCol.Name = "lastnameCol";
            // 
            // yobCol
            // 
            this.yobCol.HeaderText = "Дата рождения";
            this.yobCol.MinimumWidth = 6;
            this.yobCol.Name = "yobCol";
            // 
            // sexCol
            // 
            this.sexCol.HeaderText = "Пол";
            this.sexCol.MinimumWidth = 6;
            this.sexCol.Name = "sexCol";
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.Visible = false;
            // 
            // matriculationCol
            // 
            this.matriculationCol.HeaderText = "Зачисление";
            this.matriculationCol.MinimumWidth = 6;
            this.matriculationCol.Name = "matriculationCol";
            // 
            // phoneNumCol
            // 
            this.phoneNumCol.HeaderText = "Номер телефона";
            this.phoneNumCol.MinimumWidth = 6;
            this.phoneNumCol.Name = "phoneNumCol";
            // 
            // schoolGradeCol
            // 
            this.schoolGradeCol.HeaderText = "Класс";
            this.schoolGradeCol.MinimumWidth = 6;
            this.schoolGradeCol.Name = "schoolGradeCol";
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            // 
            // listenerCategoryCol
            // 
            this.listenerCategoryCol.HeaderText = "Категория слушателя";
            this.listenerCategoryCol.MinimumWidth = 6;
            this.listenerCategoryCol.Name = "listenerCategoryCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(409, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(258, 37);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить слушателя";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(798, 6);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(258, 37);
            this.updBtn.TabIndex = 3;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(1186, 6);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(258, 37);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Удалить слушателя";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 638);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Список слушателей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolGradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerCategoryCol;
    }
}