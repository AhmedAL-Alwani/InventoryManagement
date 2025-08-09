using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.InnerUserControls;
using InventoryManagement.MyForms.InnerUserControls;
using InventoryManagement.BLL;

namespace InventoryManagement.UserControls
{
    public partial class Products_UC : UserControl
    {
        public MainForm main;
        private  ItemBLL itemBLL = new ItemBLL();
        public Products_UC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            DGV_product.AutoGenerateColumns = false;
        }

        private void FillItems()
        {
            try
            {
                DGV_product.DataSource = itemBLL.GetAllItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }

        }
        private void FillComboBoxes()
        {
            DataTable dtCategories = itemBLL.GetCategories();
            com_category_product.DataSource = dtCategories;
            com_category_product.DisplayMember = "Category_Name";
            com_category_product.ValueMember = "Category_ID";
            DataTable dtUnits = itemBLL.GetUnits();
            com_unit_product.DataSource = dtUnits;
            com_unit_product.DisplayMember = "Unit_Name";
            com_unit_product.ValueMember = "Unit_ID";
        }
        private void DGV_product_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void btn_save_modfiy_product_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txt_product_id.Text;
                string name = txt_product_name.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("يرجى إدخال اسم المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int categoryId = Convert.ToInt32(com_category_product.SelectedValue);
                int unitId = Convert.ToInt32(com_unit_product.SelectedValue);

                itemBLL.UpdateItem(id, name, categoryId, unitId);

                MessageBox.Show("تم تعديل المنتج بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Products_UC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء التعديل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Products_UC_Load(object sender, EventArgs e)
        {
            FillItems();
            FillComboBoxes();
            btn_save_modfiy_product.Enabled = false;
            btn_save_new_product.Enabled = false;
            btn_cancel_product.Enabled = false;
            txt_product_id.Enabled = false;
            txt_product_name.Enabled = false;
            com_category_product.Enabled = false;
            com_unit_product.Enabled = false;
            DGV_product.Enabled = true;
            txt_product_id.Clear();
            txt_product_name.Clear();
            com_category_product.SelectedIndex = -1;
            com_unit_product.SelectedIndex = -1;
        }

        private void btn_add_cateory_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            AddCategory addcategory = new AddCategory(main);
            addcategory.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(addcategory);
        }

        private void btn_add_unit_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            AddUnitUC addunit_us = new AddUnitUC(main);
            addunit_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(addunit_us);
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            btn_save_new_product.Enabled = true;
            btn_cancel_product.Enabled = true;
            txt_product_name.Enabled = true;
            txt_product_id.Enabled = true;
            com_category_product.Enabled = true;
            com_unit_product.Enabled = true;
            DGV_product.Enabled = false;
            txt_product_id.Focus();
        }

        private void btn_cancel_product_Click(object sender, EventArgs e)
        {
            Products_UC_Load(sender, e);
        }

        private void btn_save_new_product_Click(object sender, EventArgs e)
        {
            try
            {
                string itemId = txt_product_id.Text.Trim();
                string itemName = txt_product_name.Text.Trim();

                if (string.IsNullOrEmpty(itemId) || string.IsNullOrEmpty(itemName)
                    || com_category_product.SelectedValue == null || com_unit_product.SelectedValue == null)
                {
                    MessageBox.Show("الرجاء تعبئة جميع الحقول.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int categoryId = Convert.ToInt32(com_category_product.SelectedValue);
                int unitId = Convert.ToInt32(com_unit_product.SelectedValue);

                ItemBLL itemBLL = new ItemBLL();
                itemBLL.AddItem(itemId, itemName, categoryId, unitId);

                MessageBox.Show("تمت الإضافة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Products_UC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الإضافة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DGV_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string columnName = DGV_product.Columns[e.ColumnIndex].Name;

                if (columnName == "ModifyColumn")
                {

                    DataGridViewRow selectedRow = DGV_product.Rows[e.RowIndex];

                    txt_product_id.Text = selectedRow.Cells["Item_ID"].Value.ToString();
                    txt_product_name.Text = selectedRow.Cells["Item_Name"].Value.ToString();
                    com_category_product.SelectedValue = Convert.ToInt32(selectedRow.Cells["Category_ID"].Value);
                    com_unit_product.SelectedValue = Convert.ToInt32(selectedRow.Cells["Unit_ID"].Value);
                    btn_add_product.Enabled = false;
                    btn_save_new_product.Enabled = false;
                    DGV_product.Enabled = false;
                    btn_save_modfiy_product.Enabled = true;
                    btn_cancel_product.Enabled = true;
                    txt_product_name.Enabled = true;
                    com_category_product.Enabled = true;
                    com_unit_product.Enabled = true;
                    txt_product_id.Focus();
                }
                else if (columnName == "DeleteColumn")
                {
                    string id = DGV_product.Rows[e.RowIndex].Cells["Item_ID"].Value.ToString();

                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا المنتج؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool deleted = itemBLL.DeleteItem(id);
                        if (deleted)
                        {
                            MessageBox.Show("تم حذف المنتج بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Products_UC_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن حذف هذا المنتج لأنه مرتبط بعمليات توريد او صرف ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

        }

        private void txt_searchproduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_searchproduct.Text.Trim();
                DataTable dt = itemBLL.SearchItems(searchText);
                DGV_product.DataSource = dt;
        }
    }
}
