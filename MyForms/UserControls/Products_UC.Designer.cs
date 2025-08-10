namespace InventoryManagement.UserControls
{
    partial class Products_UC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_product = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_searchproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_save_modfiy_product = new System.Windows.Forms.Button();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.com_category_product = new System.Windows.Forms.ComboBox();
            this.com_unit_product = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_cateory = new System.Windows.Forms.Button();
            this.btn_add_unit = new System.Windows.Forms.Button();
            this.btn_save_new_product = new System.Windows.Forms.Button();
            this.btn_cancel_product = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_product
            // 
            this.DGV_product.AllowUserToAddRows = false;
            this.DGV_product.AllowUserToDeleteRows = false;
            this.DGV_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Item_Name,
            this.Category_ID,
            this.Category_Name,
            this.Unit_ID,
            this.Unit_Name,
            this.ModifyColumn,
            this.DeleteColumn});
            this.DGV_product.Location = new System.Drawing.Point(16, 358);
            this.DGV_product.MultiSelect = false;
            this.DGV_product.Name = "DGV_product";
            this.DGV_product.ReadOnly = true;
            this.DGV_product.RowHeadersVisible = false;
            this.DGV_product.RowTemplate.Height = 24;
            this.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_product.Size = new System.Drawing.Size(975, 277);
            this.DGV_product.TabIndex = 0;
            this.DGV_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_product_CellContentClick);
            this.DGV_product.SelectionChanged += new System.EventHandler(this.DGV_product_SelectionChanged);
            // 
            // Item_ID
            // 
            this.Item_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_ID.DataPropertyName = "Item_ID";
            this.Item_ID.FillWeight = 30F;
            this.Item_ID.HeaderText = "ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.FillWeight = 150F;
            this.Item_Name.HeaderText = "Product Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Category_ID
            // 
            this.Category_ID.DataPropertyName = "Category_ID";
            this.Category_ID.HeaderText = "Category_ID";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            this.Category_ID.Visible = false;
            // 
            // Category_Name
            // 
            this.Category_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_Name.DataPropertyName = "Category_Name";
            this.Category_Name.FillWeight = 150F;
            this.Category_Name.HeaderText = "Category";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // Unit_ID
            // 
            this.Unit_ID.DataPropertyName = "Unit_ID";
            this.Unit_ID.HeaderText = "Unit_ID";
            this.Unit_ID.Name = "Unit_ID";
            this.Unit_ID.ReadOnly = true;
            this.Unit_ID.Visible = false;
            // 
            // Unit_Name
            // 
            this.Unit_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit_Name.DataPropertyName = "Unit_Name";
            this.Unit_Name.HeaderText = "Unit";
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.ReadOnly = true;
            // 
            // ModifyColumn
            // 
            this.ModifyColumn.DataPropertyName = "ModifyColumn";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ModifyColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ModifyColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModifyColumn.HeaderText = "";
            this.ModifyColumn.Name = "ModifyColumn";
            this.ModifyColumn.ReadOnly = true;
            this.ModifyColumn.Text = "Modfiy";
            this.ModifyColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.DataPropertyName = "DeleteColumn";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // txt_searchproduct
            // 
            this.txt_searchproduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchproduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchproduct.Location = new System.Drawing.Point(448, 318);
            this.txt_searchproduct.Name = "txt_searchproduct";
            this.txt_searchproduct.Size = new System.Drawing.Size(433, 38);
            this.txt_searchproduct.TabIndex = 0;
            this.txt_searchproduct.TextChanged += new System.EventHandler(this.txt_searchproduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product List";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.Green;
            this.btn_add_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.Color.White;
            this.btn_add_product.Location = new System.Drawing.Point(3, 3);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(225, 37);
            this.btn_add_product.TabIndex = 0;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_save_modfiy_product
            // 
            this.btn_save_modfiy_product.BackColor = System.Drawing.Color.Green;
            this.btn_save_modfiy_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_modfiy_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_modfiy_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_modfiy_product.ForeColor = System.Drawing.Color.White;
            this.btn_save_modfiy_product.Location = new System.Drawing.Point(465, 3);
            this.btn_save_modfiy_product.Name = "btn_save_modfiy_product";
            this.btn_save_modfiy_product.Size = new System.Drawing.Size(225, 37);
            this.btn_save_modfiy_product.TabIndex = 0;
            this.btn_save_modfiy_product.Text = "Save Modify";
            this.btn_save_modfiy_product.UseVisualStyleBackColor = false;
            this.btn_save_modfiy_product.Click += new System.EventHandler(this.btn_save_modfiy_product_Click);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(227, 64);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(572, 38);
            this.txt_product_name.TabIndex = 5;
            // 
            // com_category_product
            // 
            this.com_category_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_category_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_category_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_category_product.FormattingEnabled = true;
            this.com_category_product.Location = new System.Drawing.Point(227, 128);
            this.com_category_product.Name = "com_category_product";
            this.com_category_product.Size = new System.Drawing.Size(572, 36);
            this.com_category_product.TabIndex = 6;
            // 
            // com_unit_product
            // 
            this.com_unit_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_unit_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_unit_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_unit_product.FormattingEnabled = true;
            this.com_unit_product.Location = new System.Drawing.Point(227, 185);
            this.com_unit_product.Name = "com_unit_product";
            this.com_unit_product.Size = new System.Drawing.Size(572, 36);
            this.com_unit_product.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unit";
            // 
            // btn_add_cateory
            // 
            this.btn_add_cateory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_cateory.BackColor = System.Drawing.Color.Navy;
            this.btn_add_cateory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_cateory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_cateory.ForeColor = System.Drawing.Color.White;
            this.btn_add_cateory.Location = new System.Drawing.Point(821, 127);
            this.btn_add_cateory.Name = "btn_add_cateory";
            this.btn_add_cateory.Size = new System.Drawing.Size(170, 36);
            this.btn_add_cateory.TabIndex = 11;
            this.btn_add_cateory.Text = "Add Category";
            this.btn_add_cateory.UseVisualStyleBackColor = false;
            this.btn_add_cateory.Click += new System.EventHandler(this.btn_add_cateory_Click);
            // 
            // btn_add_unit
            // 
            this.btn_add_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_unit.BackColor = System.Drawing.Color.Navy;
            this.btn_add_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_unit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_unit.ForeColor = System.Drawing.Color.White;
            this.btn_add_unit.Location = new System.Drawing.Point(821, 185);
            this.btn_add_unit.Name = "btn_add_unit";
            this.btn_add_unit.Size = new System.Drawing.Size(170, 36);
            this.btn_add_unit.TabIndex = 12;
            this.btn_add_unit.Text = "Add Unit";
            this.btn_add_unit.UseVisualStyleBackColor = false;
            this.btn_add_unit.Click += new System.EventHandler(this.btn_add_unit_Click);
            // 
            // btn_save_new_product
            // 
            this.btn_save_new_product.BackColor = System.Drawing.Color.Green;
            this.btn_save_new_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_new_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_new_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_new_product.ForeColor = System.Drawing.Color.White;
            this.btn_save_new_product.Location = new System.Drawing.Point(234, 3);
            this.btn_save_new_product.Name = "btn_save_new_product";
            this.btn_save_new_product.Size = new System.Drawing.Size(225, 37);
            this.btn_save_new_product.TabIndex = 13;
            this.btn_save_new_product.Text = "Save New Product";
            this.btn_save_new_product.UseVisualStyleBackColor = false;
            this.btn_save_new_product.Click += new System.EventHandler(this.btn_save_new_product_Click);
            // 
            // btn_cancel_product
            // 
            this.btn_cancel_product.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_product.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_product.Location = new System.Drawing.Point(696, 3);
            this.btn_cancel_product.Name = "btn_cancel_product";
            this.btn_cancel_product.Size = new System.Drawing.Size(228, 37);
            this.btn_cancel_product.TabIndex = 14;
            this.btn_cancel_product.Text = "Cancel";
            this.btn_cancel_product.UseVisualStyleBackColor = false;
            this.btn_cancel_product.Click += new System.EventHandler(this.btn_cancel_product_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add_product, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel_product, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_new_product, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_modfiy_product, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 242);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 43);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.Location = new System.Drawing.Point(227, 3);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(572, 38);
            this.txt_product_id.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product ID";
            // 
            // Products_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_add_unit);
            this.Controls.Add(this.btn_add_cateory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_unit_product);
            this.Controls.Add(this.com_category_product);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchproduct);
            this.Controls.Add(this.DGV_product);
            this.Name = "Products_UC";
            this.Size = new System.Drawing.Size(1011, 646);
            this.Load += new System.EventHandler(this.Products_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_product;
        private System.Windows.Forms.TextBox txt_searchproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_save_modfiy_product;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.ComboBox com_category_product;
        private System.Windows.Forms.ComboBox com_unit_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add_cateory;
        private System.Windows.Forms.Button btn_add_unit;
        private System.Windows.Forms.Button btn_save_new_product;
        private System.Windows.Forms.Button btn_cancel_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Name;
        private System.Windows.Forms.DataGridViewButtonColumn ModifyColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
