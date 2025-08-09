namespace InventoryManagement.MyForms.InnerUserControls
{
    partial class TransactionsRepo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCustomer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dptTo = new System.Windows.Forms.DateTimePicker();
            this.dptFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplierCustomer = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back1_to_repo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "اسم المستخدم";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(164, 214);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 35);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "تاريخ العملية";
            this.TransactionDate.MinimumWidth = 6;
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 125;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الانتهاء";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            this.ExpiryDate.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // SupplierCustomer_Name
            // 
            this.SupplierCustomer_Name.HeaderText = "المورد/العميل";
            this.SupplierCustomer_Name.MinimumWidth = 6;
            this.SupplierCustomer_Name.Name = "SupplierCustomer_Name";
            this.SupplierCustomer_Name.ReadOnly = true;
            this.SupplierCustomer_Name.Width = 125;
            // 
            // Unit_Name
            // 
            this.Unit_Name.HeaderText = "الوحدة";
            this.Unit_Name.MinimumWidth = 6;
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.ReadOnly = true;
            this.Unit_Name.Width = 125;
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "الفئة";
            this.Category_Name.MinimumWidth = 6;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            this.Category_Name.Width = 125;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "اسم الصنف";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 125;
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "نوع العملية";
            this.TransactionType.MinimumWidth = 6;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Width = 125;
            // 
            // Transaction_ID
            // 
            this.Transaction_ID.HeaderText = "رقم العملية";
            this.Transaction_ID.MinimumWidth = 6;
            this.Transaction_ID.Name = "Transaction_ID";
            this.Transaction_ID.ReadOnly = true;
            this.Transaction_ID.Width = 125;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(486, 221);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(189, 24);
            this.cmbUser.TabIndex = 34;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_ID,
            this.TransactionType,
            this.Item_Name,
            this.Category_Name,
            this.Unit_Name,
            this.SupplierCustomer_Name,
            this.Quantity,
            this.ExpiryDate,
            this.TransactionDate,
            this.UserName});
            this.dgvTransactions.Location = new System.Drawing.Point(3, 285);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 26;
            this.dgvTransactions.Size = new System.Drawing.Size(877, 338);
            this.dgvTransactions.TabIndex = 32;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(310, 214);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(116, 35);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "تصفية";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dptTo
            // 
            this.dptTo.Location = new System.Drawing.Point(9, 142);
            this.dptTo.Name = "dptTo";
            this.dptTo.Size = new System.Drawing.Size(201, 24);
            this.dptTo.TabIndex = 30;
            // 
            // dptFrom
            // 
            this.dptFrom.Location = new System.Drawing.Point(274, 142);
            this.dptFrom.Name = "dptFrom";
            this.dptFrom.Size = new System.Drawing.Size(216, 24);
            this.dptFrom.TabIndex = 29;
            // 
            // cmbSupplierCustomer
            // 
            this.cmbSupplierCustomer.FormattingEnabled = true;
            this.cmbSupplierCustomer.Location = new System.Drawing.Point(548, 142);
            this.cmbSupplierCustomer.Name = "cmbSupplierCustomer";
            this.cmbSupplierCustomer.Size = new System.Drawing.Size(162, 24);
            this.cmbSupplierCustomer.TabIndex = 28;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(9, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 24);
            this.cmbCategory.TabIndex = 27;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(286, 80);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(189, 24);
            this.cmbItem.TabIndex = 26;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(570, 83);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(167, 24);
            this.cmbTransactionType.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "الى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "من";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "المورد/العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "الفئة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع العملية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(317, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "تقارير حركة المخزون";
            // 
            // btn_back1_to_repo
            // 
            this.btn_back1_to_repo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back1_to_repo.Location = new System.Drawing.Point(20, 214);
            this.btn_back1_to_repo.Name = "btn_back1_to_repo";
            this.btn_back1_to_repo.Size = new System.Drawing.Size(116, 35);
            this.btn_back1_to_repo.TabIndex = 36;
            this.btn_back1_to_repo.Text = "تراجع";
            this.btn_back1_to_repo.UseVisualStyleBackColor = true;
            this.btn_back1_to_repo.Click += new System.EventHandler(this.btn_back1_to_repo_Click);
            // 
            // TransactionsRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back1_to_repo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dptTo);
            this.Controls.Add(this.dptFrom);
            this.Controls.Add(this.cmbSupplierCustomer);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionsRepo";
            this.Size = new System.Drawing.Size(885, 646);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCustomer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dptTo;
        private System.Windows.Forms.DateTimePicker dptFrom;
        private System.Windows.Forms.ComboBox cmbSupplierCustomer;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back1_to_repo;
    }
}
