namespace InventoryManagement.UserControls
{
    partial class Home_UC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_transactions = new System.Windows.Forms.PictureBox();
            this.pic_reports = new System.Windows.Forms.PictureBox();
            this.pic_customers = new System.Windows.Forms.PictureBox();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.pic_suppliers = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pic_transactions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_reports, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_customers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_product, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_suppliers, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pic_transactions
            // 
            this.pic_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_transactions.Image = global::InventoryManagement.Properties.Resources._4;
            this.pic_transactions.Location = new System.Drawing.Point(3, 289);
            this.pic_transactions.Name = "pic_transactions";
            this.pic_transactions.Size = new System.Drawing.Size(284, 281);
            this.pic_transactions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_transactions.TabIndex = 4;
            this.pic_transactions.TabStop = false;
            this.pic_transactions.Click += new System.EventHandler(this.pic_transactions_Click);
            // 
            // pic_reports
            // 
            this.pic_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_reports.Image = global::InventoryManagement.Properties.Resources._5;
            this.pic_reports.Location = new System.Drawing.Point(293, 289);
            this.pic_reports.Name = "pic_reports";
            this.pic_reports.Size = new System.Drawing.Size(284, 281);
            this.pic_reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_reports.TabIndex = 3;
            this.pic_reports.TabStop = false;
            this.pic_reports.Click += new System.EventHandler(this.pic_reports_Click);
            // 
            // pic_customers
            // 
            this.pic_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_customers.Image = global::InventoryManagement.Properties.Resources._3;
            this.pic_customers.Location = new System.Drawing.Point(583, 3);
            this.pic_customers.Name = "pic_customers";
            this.pic_customers.Size = new System.Drawing.Size(284, 280);
            this.pic_customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_customers.TabIndex = 2;
            this.pic_customers.TabStop = false;
            this.pic_customers.Click += new System.EventHandler(this.pic_customers_Click);
            // 
            // pic_product
            // 
            this.pic_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_product.Image = global::InventoryManagement.Properties.Resources._1;
            this.pic_product.Location = new System.Drawing.Point(3, 3);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(284, 280);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_product.TabIndex = 0;
            this.pic_product.TabStop = false;
            this.pic_product.Click += new System.EventHandler(this.pic_product_Click);
            // 
            // pic_suppliers
            // 
            this.pic_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_suppliers.Image = global::InventoryManagement.Properties.Resources._2;
            this.pic_suppliers.Location = new System.Drawing.Point(293, 3);
            this.pic_suppliers.Name = "pic_suppliers";
            this.pic_suppliers.Size = new System.Drawing.Size(284, 280);
            this.pic_suppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_suppliers.TabIndex = 1;
            this.pic_suppliers.TabStop = false;
            this.pic_suppliers.Click += new System.EventHandler(this.pic_suppliers_Click);
            // 
            // Home_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home_UC";
            this.Size = new System.Drawing.Size(1011, 646);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_suppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_transactions;
        private System.Windows.Forms.PictureBox pic_reports;
        private System.Windows.Forms.PictureBox pic_customers;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.PictureBox pic_suppliers;
    }
}
