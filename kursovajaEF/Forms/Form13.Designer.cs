
namespace kursovajaEF.Forms
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.contracts = new System.Windows.Forms.DataGridView();
            this.crnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate40pctCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expulsionDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenedHoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restOfSumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDeadlineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueCertificateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoPayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkBtn = new System.Windows.Forms.Button();
            this.listeners = new System.Windows.Forms.DataGridView();
            this.firstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolGradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listenerCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // contracts
            // 
            this.contracts.AllowUserToAddRows = false;
            this.contracts.AllowUserToDeleteRows = false;
            this.contracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.contracts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crnCol,
            this.totalSumCol,
            this.payedSumCol,
            this.PayDate40pctCol,
            this.expulsionDateCol,
            this.listenedHoursCol,
            this.transferGroupCol,
            this.restOfSumCol,
            this.paymentDeadlineCol,
            this.issueCertificateCol,
            this.certificateCol,
            this.whoPayCol,
            this.contractIdCol});
            this.contracts.Location = new System.Drawing.Point(12, 53);
            this.contracts.Name = "contracts";
            this.contracts.ReadOnly = true;
            this.contracts.RowHeadersWidth = 51;
            this.contracts.RowTemplate.Height = 29;
            this.contracts.Size = new System.Drawing.Size(1285, 221);
            this.contracts.TabIndex = 0;
            this.contracts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contracts_CellDoubleClick);
            this.contracts.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // crnCol
            // 
            this.crnCol.HeaderText = "Регистрационный номер договора";
            this.crnCol.MinimumWidth = 6;
            this.crnCol.Name = "crnCol";
            this.crnCol.ReadOnly = true;
            this.crnCol.Width = 199;
            // 
            // totalSumCol
            // 
            this.totalSumCol.HeaderText = "Общая сумма(руб.)";
            this.totalSumCol.MinimumWidth = 6;
            this.totalSumCol.Name = "totalSumCol";
            this.totalSumCol.ReadOnly = true;
            this.totalSumCol.Width = 157;
            // 
            // payedSumCol
            // 
            this.payedSumCol.HeaderText = "Оплачено(руб.)";
            this.payedSumCol.MinimumWidth = 6;
            this.payedSumCol.Name = "payedSumCol";
            this.payedSumCol.ReadOnly = true;
            this.payedSumCol.Width = 146;
            // 
            // PayDate40pctCol
            // 
            this.PayDate40pctCol.HeaderText = "Дата оплаты 40 %";
            this.PayDate40pctCol.MinimumWidth = 6;
            this.PayDate40pctCol.Name = "PayDate40pctCol";
            this.PayDate40pctCol.ReadOnly = true;
            this.PayDate40pctCol.Width = 133;
            // 
            // expulsionDateCol
            // 
            this.expulsionDateCol.HeaderText = "Дата отчисления";
            this.expulsionDateCol.MinimumWidth = 6;
            this.expulsionDateCol.Name = "expulsionDateCol";
            this.expulsionDateCol.ReadOnly = true;
            this.expulsionDateCol.Width = 142;
            // 
            // listenedHoursCol
            // 
            this.listenedHoursCol.HeaderText = "Прослушанные часы";
            this.listenedHoursCol.MinimumWidth = 6;
            this.listenedHoursCol.Name = "listenedHoursCol";
            this.listenedHoursCol.ReadOnly = true;
            this.listenedHoursCol.Width = 168;
            // 
            // transferGroupCol
            // 
            this.transferGroupCol.HeaderText = "Переведен(-а) в группу";
            this.transferGroupCol.MinimumWidth = 6;
            this.transferGroupCol.Name = "transferGroupCol";
            this.transferGroupCol.ReadOnly = true;
            this.transferGroupCol.Width = 142;
            // 
            // restOfSumCol
            // 
            this.restOfSumCol.HeaderText = "Остаток по оплате(руб.)";
            this.restOfSumCol.MinimumWidth = 6;
            this.restOfSumCol.Name = "restOfSumCol";
            this.restOfSumCol.ReadOnly = true;
            this.restOfSumCol.Width = 186;
            // 
            // paymentDeadlineCol
            // 
            this.paymentDeadlineCol.HeaderText = "Срок оплаты";
            this.paymentDeadlineCol.MinimumWidth = 6;
            this.paymentDeadlineCol.Name = "paymentDeadlineCol";
            this.paymentDeadlineCol.ReadOnly = true;
            this.paymentDeadlineCol.Width = 117;
            // 
            // issueCertificateCol
            // 
            this.issueCertificateCol.HeaderText = "Дата выдачи сертификата";
            this.issueCertificateCol.MinimumWidth = 6;
            this.issueCertificateCol.Name = "issueCertificateCol";
            this.issueCertificateCol.ReadOnly = true;
            this.issueCertificateCol.Width = 198;
            // 
            // certificateCol
            // 
            this.certificateCol.HeaderText = "Сертификат";
            this.certificateCol.MinimumWidth = 6;
            this.certificateCol.Name = "certificateCol";
            this.certificateCol.ReadOnly = true;
            this.certificateCol.Width = 119;
            // 
            // whoPayCol
            // 
            this.whoPayCol.HeaderText = "Кто оплатил обучение";
            this.whoPayCol.MinimumWidth = 6;
            this.whoPayCol.Name = "whoPayCol";
            this.whoPayCol.ReadOnly = true;
            this.whoPayCol.Width = 177;
            // 
            // contractIdCol
            // 
            this.contractIdCol.HeaderText = "Id контракта";
            this.contractIdCol.MinimumWidth = 6;
            this.contractIdCol.Name = "contractIdCol";
            this.contractIdCol.ReadOnly = true;
            this.contractIdCol.Visible = false;
            this.contractIdCol.Width = 125;
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delBtn.Location = new System.Drawing.Point(987, 12);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(311, 35);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updBtn.Location = new System.Drawing.Point(497, 12);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(311, 35);
            this.updBtn.TabIndex = 1;
            this.updBtn.Text = "Изменить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(311, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(87, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkBtn
            // 
            this.linkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBtn.Location = new System.Drawing.Point(12, 336);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(243, 38);
            this.linkBtn.TabIndex = 1;
            this.linkBtn.Text = "Соотнести данные";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // listeners
            // 
            this.listeners.AllowUserToAddRows = false;
            this.listeners.AllowUserToDeleteRows = false;
            this.listeners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeners.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameCol,
            this.midnameCol,
            this.lastnameCol,
            this.yobCol,
            this.sexCol,
            this.listenerIdCol,
            this.matriculationCol,
            this.groupIdCol,
            this.phoneNumCol,
            this.schoolGradeCol,
            this.emailCol,
            this.listenerCategoryCol});
            this.listeners.Location = new System.Drawing.Point(12, 391);
            this.listeners.Name = "listeners";
            this.listeners.ReadOnly = true;
            this.listeners.RowHeadersWidth = 51;
            this.listeners.RowTemplate.Height = 29;
            this.listeners.Size = new System.Drawing.Size(1285, 377);
            this.listeners.TabIndex = 0;
            this.listeners.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            // 
            // firstnameCol
            // 
            this.firstnameCol.HeaderText = "Имя";
            this.firstnameCol.MinimumWidth = 6;
            this.firstnameCol.Name = "firstnameCol";
            this.firstnameCol.ReadOnly = true;
            // 
            // midnameCol
            // 
            this.midnameCol.HeaderText = "Фамилия";
            this.midnameCol.MinimumWidth = 6;
            this.midnameCol.Name = "midnameCol";
            this.midnameCol.ReadOnly = true;
            // 
            // lastnameCol
            // 
            this.lastnameCol.HeaderText = "Отчество";
            this.lastnameCol.MinimumWidth = 6;
            this.lastnameCol.Name = "lastnameCol";
            this.lastnameCol.ReadOnly = true;
            // 
            // yobCol
            // 
            this.yobCol.HeaderText = "Дата рождения";
            this.yobCol.MinimumWidth = 6;
            this.yobCol.Name = "yobCol";
            this.yobCol.ReadOnly = true;
            // 
            // sexCol
            // 
            this.sexCol.HeaderText = "Пол";
            this.sexCol.MinimumWidth = 6;
            this.sexCol.Name = "sexCol";
            this.sexCol.ReadOnly = true;
            // 
            // listenerIdCol
            // 
            this.listenerIdCol.HeaderText = "Id слушателя";
            this.listenerIdCol.MinimumWidth = 6;
            this.listenerIdCol.Name = "listenerIdCol";
            this.listenerIdCol.ReadOnly = true;
            this.listenerIdCol.Visible = false;
            // 
            // matriculationCol
            // 
            this.matriculationCol.HeaderText = "Зачисление";
            this.matriculationCol.MinimumWidth = 6;
            this.matriculationCol.Name = "matriculationCol";
            this.matriculationCol.ReadOnly = true;
            // 
            // groupIdCol
            // 
            this.groupIdCol.HeaderText = "Id группы";
            this.groupIdCol.MinimumWidth = 6;
            this.groupIdCol.Name = "groupIdCol";
            this.groupIdCol.ReadOnly = true;
            this.groupIdCol.Visible = false;
            // 
            // phoneNumCol
            // 
            this.phoneNumCol.HeaderText = "Номер телефона";
            this.phoneNumCol.MinimumWidth = 6;
            this.phoneNumCol.Name = "phoneNumCol";
            this.phoneNumCol.ReadOnly = true;
            // 
            // schoolGradeCol
            // 
            this.schoolGradeCol.HeaderText = "Класс";
            this.schoolGradeCol.MinimumWidth = 6;
            this.schoolGradeCol.Name = "schoolGradeCol";
            this.schoolGradeCol.ReadOnly = true;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "email";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            // 
            // listenerCategoryCol
            // 
            this.listenerCategoryCol.HeaderText = "Категория слушателя";
            this.listenerCategoryCol.MinimumWidth = 6;
            this.listenerCategoryCol.Name = "listenerCategoryCol";
            this.listenerCategoryCol.ReadOnly = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 780);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.listeners);
            this.Controls.Add(this.contracts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.Text = "Список договоров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn crnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn payedSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate40pctCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expulsionDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenedHoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn restOfSumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDeadlineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueCertificateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoPayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIdCol;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.DataGridView listeners;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolGradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenerCategoryCol;
    }
}