using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.UserControls;
using InventoryManagement.BLL;

namespace InventoryManagement.InnerUserControls
{
    public partial class AddCategory : UserControl
    {
        public MainForm main;
        private CategoriesBLL categoriesBLL = new CategoriesBLL();
        int selectedCategoryID = -1;
        public AddCategory(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            DGV_category.AutoGenerateColumns = false;
        }

        private void FillCategories()
        {
            try
            {
                DGV_category.DataSource = categoriesBLL.GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {
            FillCategories();
            btn_save_category.Enabled = false;
            btn_cancel_category.Enabled = false;
            txt_category_name.Clear();
            btn_add_catecory.Enabled = true;
            txt_search_category.Clear();
            txt_search_category.Focus();
        }

        private void btn_back_to_product_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }

        private void txt_category_name_TextChanged(object sender, EventArgs e)
        {
            String s = txt_category_name.Text.Trim();
            if (s.Length > 0)
            {
                btn_cancel_category.Enabled = true;
                DGV_category.Enabled = false;
            }
            else
            {
                DGV_category.Enabled = true;
            }
        }

        private void btn_add_catecory_Click(object sender, EventArgs e)
        {
            string name = txt_category_name.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("يرجى إدخال اسم الفئة");
                return;
            }

            try
            {
                categoriesBLL.InsertCategory(name);
                MessageBox.Show("تمت الإضافة بنجاح");
                AddCategory_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }

        }

        private void btn_cancel_category_Click(object sender, EventArgs e)
        {
            AddCategory_Load(sender, e);
        }

        private void DGV_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = DGV_category.Columns[e.ColumnIndex].Name;
                if(columnName == "btnmodifycategory")
                {
                    DataGridViewRow selectedRow = DGV_category.Rows[e.RowIndex];
                    selectedCategoryID = Convert.ToInt32(selectedRow.Cells["Category_ID"].Value);
                    txt_category_name.Text = selectedRow.Cells["Category_Name"].Value.ToString();
                    btn_add_catecory.Enabled = false;
                    btn_save_category.Enabled = true;
                    btn_cancel_category.Enabled = true;
                    txt_category_name.Focus();
                }
                else if(columnName == "btndeletecategory")
                {
                    int id = Convert.ToInt32(DGV_category.Rows[e.RowIndex].Cells["Category_ID"].Value);
                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه الفئة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool deleted = categoriesBLL.DeleteCategory(id);
                        if (deleted)
                        {
                            MessageBox.Show("تم حذف الفئة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddCategory_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن حذف هذه الفئة لأنها مستخدمة في منتجات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btn_save_category_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_category_name.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("يرجى إدخال اسم الفئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                categoriesBLL.UpdateCategory(selectedCategoryID, name);
                MessageBox.Show("تم التعديل بنجاح.");
                AddCategory_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء التعديل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_search_category_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search_category.Text.Trim();
            DataTable dt = categoriesBLL.SearchCategory(searchText);
            DGV_category.DataSource = dt;
        }
    }
}
