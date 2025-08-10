namespace InventoryManagement.InnerUserControls
{
    partial class AddCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.DGV_category = new System.Windows.Forms.DataGridView();
            this.btn_save_category = new System.Windows.Forms.Button();
            this.btn_cancel_category = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_add_catecory = new System.Windows.Forms.Button();
            this.btn_back_to_product = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search_category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifycategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeletecategory = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_category)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // txt_category_name
            // 
            this.txt_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_category_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category_name.Location = new System.Drawing.Point(379, 161);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(614, 38);
            this.txt_category_name.TabIndex = 2;
            this.txt_category_name.TextChanged += new System.EventHandler(this.txt_category_name_TextChanged);
            // 
            // DGV_category
            // 
            this.DGV_category.AllowUserToAddRows = false;
            this.DGV_category.AllowUserToDeleteRows = false;
            this.DGV_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_ID,
            this.Category_Name,
            this.btnmodifycategory,
            this.btndeletecategory});
            this.DGV_category.Location = new System.Drawing.Point(18, 355);
            this.DGV_category.MultiSelect = false;
            this.DGV_category.Name = "DGV_category";
            this.DGV_category.ReadOnly = true;
            this.DGV_category.RowHeadersVisible = false;
            this.DGV_category.RowTemplate.Height = 24;
            this.DGV_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_category.Size = new System.Drawing.Size(975, 277);
            this.DGV_category.TabIndex = 3;
            this.DGV_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_category_CellContentClick);
            // 
            // btn_save_category
            // 
            this.btn_save_category.BackColor = System.Drawing.Color.Green;
            this.btn_save_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_category.ForeColor = System.Drawing.Color.White;
            this.btn_save_category.Location = new System.Drawing.Point(182, 3);
            this.btn_save_category.Name = "btn_save_category";
            this.btn_save_category.Size = new System.Drawing.Size(173, 37);
            this.btn_save_category.TabIndex = 4;
            this.btn_save_category.Text = "Save";
            this.btn_save_category.UseVisualStyleBackColor = false;
            this.btn_save_category.Click += new System.EventHandler(this.btn_save_category_Click);
            // 
            // btn_cancel_category
            // 
            this.btn_cancel_category.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancel_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_category.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_category.Location = new System.Drawing.Point(361, 3);
            this.btn_cancel_category.Name = "btn_cancel_category";
            this.btn_cancel_category.Size = new System.Drawing.Size(174, 37);
            this.btn_cancel_category.TabIndex = 5;
            this.btn_cancel_category.Text = "Cancel";
            this.btn_cancel_category.UseVisualStyleBackColor = false;
            this.btn_cancel_category.Click += new System.EventHandler(this.btn_cancel_category_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add_catecory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel_category, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save_category, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(419, 221);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 43);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btn_add_catecory
            // 
            this.btn_add_catecory.BackColor = System.Drawing.Color.Green;
            this.btn_add_catecory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_catecory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_catecory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_catecory.ForeColor = System.Drawing.Color.White;
            this.btn_add_catecory.Location = new System.Drawing.Point(3, 3);
            this.btn_add_catecory.Name = "btn_add_catecory";
            this.btn_add_catecory.Size = new System.Drawing.Size(173, 37);
            this.btn_add_catecory.TabIndex = 6;
            this.btn_add_catecory.Text = "Add";
            this.btn_add_catecory.UseVisualStyleBackColor = false;
            this.btn_add_catecory.Click += new System.EventHandler(this.btn_add_catecory_Click);
            // 
            // btn_back_to_product
            // 
            this.btn_back_to_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back_to_product.BackColor = System.Drawing.Color.Navy;
            this.btn_back_to_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back_to_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_product.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back_to_product.Location = new System.Drawing.Point(818, 59);
            this.btn_back_to_product.Name = "btn_back_to_product";
            this.btn_back_to_product.Size = new System.Drawing.Size(175, 37);
            this.btn_back_to_product.TabIndex = 17;
            this.btn_back_to_product.Text = "Back";
            this.btn_back_to_product.UseVisualStyleBackColor = false;
            this.btn_back_to_product.Click += new System.EventHandler(this.btn_back_to_product_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 51);
            this.label3.TabIndex = 27;
            this.label3.Text = "Search";
            // 
            // txt_search_category
            // 
            this.txt_search_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_category.Location = new System.Drawing.Point(354, 312);
            this.txt_search_category.Name = "txt_search_category";
            this.txt_search_category.Size = new System.Drawing.Size(493, 38);
            this.txt_search_category.TabIndex = 26;
            this.txt_search_category.TextChanged += new System.EventHandler(this.txt_search_category_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 59);
            this.label4.TabIndex = 28;
            this.label4.Text = "Category List";
            // 
            // Category_ID
            // 
            this.Category_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_ID.DataPropertyName = "Category_ID";
            this.Category_ID.FillWeight = 10F;
            this.Category_ID.HeaderText = "ID";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            // 
            // Category_Name
            // 
            this.Category_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_Name.DataPropertyName = "Category_Name";
            this.Category_Name.FillWeight = 150F;
            this.Category_Name.HeaderText = "Category Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // btnmodifycategory
            // 
            this.btnmodifycategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnmodifycategory.DataPropertyName = "btnmodifycategory";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.btnmodifycategory.DefaultCellStyle = dataGridViewCellStyle15;
            this.btnmodifycategory.FillWeight = 50F;
            this.btnmodifycategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifycategory.HeaderText = "";
            this.btnmodifycategory.Name = "btnmodifycategory";
            this.btnmodifycategory.ReadOnly = true;
            this.btnmodifycategory.Text = "Modfiy";
            this.btnmodifycategory.UseColumnTextForButtonValue = true;
            // 
            // btndeletecategory
            // 
            this.btndeletecategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btndeletecategory.DataPropertyName = "btndeletecategory";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.btndeletecategory.DefaultCellStyle = dataGridViewCellStyle16;
            this.btndeletecategory.FillWeight = 50F;
            this.btndeletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletecategory.HeaderText = "";
            this.btndeletecategory.Name = "btndeletecategory";
            this.btndeletecategory.ReadOnly = true;
            this.btndeletecategory.Text = "Delete";
            this.btndeletecategory.UseColumnTextForButtonValue = true;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search_category);
            this.Controls.Add(this.btn_back_to_product);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DGV_category);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(1011, 646);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_category)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.DataGridView DGV_category;
        private System.Windows.Forms.Button btn_save_category;
        private System.Windows.Forms.Button btn_cancel_category;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_back_to_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_catecory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewButtonColumn btnmodifycategory;
        private System.Windows.Forms.DataGridViewButtonColumn btndeletecategory;
    }
}
