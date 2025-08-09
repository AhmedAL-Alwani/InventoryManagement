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

namespace InventoryManagement.MyForms.InnerUserControls
{
    public partial class AddUnitUC : UserControl
    {
        public MainForm main;
        private UnitsBLL unitsBLL = new UnitsBLL();
        int selectedUnitID = -1;
        public AddUnitUC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            DGV_unit.AutoGenerateColumns = false;
        }

        private void FillUnits()
        {
            try
            {
                DGV_unit.DataSource = unitsBLL.GetAllUnits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
        private void btn_back_to_product_from_unit_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }

        private void AddUnitUC_Load(object sender, EventArgs e)
        {
            FillUnits();
            btn_save_unit.Enabled = false;
            btn_cancel_unit.Enabled = false;
            btn_add_unit.Enabled = true;
            txt_unit_name.Clear();
            txt_search_unit.Clear();
            txt_search_unit.Focus();
        }

        private void txt_unit_name_TextChanged(object sender, EventArgs e)
        {
            String s = txt_unit_name.Text.Trim();
            if (s.Length > 0)
            {
                btn_cancel_unit.Enabled = true;
                DGV_unit.Enabled = false;
            }
            else
            {
                DGV_unit.Enabled = true;
            }
        }

        private void btn_add_unit_Click(object sender, EventArgs e)
        {
            string name = txt_unit_name.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("يرجى إدخال اسم الفئة");
                return;
            }
            try
            {
                unitsBLL.AddUnit(name);
                MessageBox.Show("تمت الإضافة بنجاح");
                AddUnitUC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

        private void DGV_unit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = DGV_unit.Columns[e.ColumnIndex].Name;
                if(columnName == "btnmodifyunit")
                {
                    DataGridViewRow selectedRow = DGV_unit.Rows[e.RowIndex];
                    selectedUnitID = Convert.ToInt32(selectedRow.Cells["Unit_ID"].Value);
                    txt_unit_name.Text = selectedRow.Cells["Unit_Name"].Value.ToString();
                    btn_add_unit.Enabled = false;
                    btn_save_unit.Enabled = true;
                    btn_cancel_unit.Enabled = true;
                    txt_unit_name.Focus();
                }
                else if (columnName == "btndeleteunit")
                {
                    int id = Convert.ToInt32(DGV_unit.Rows[e.RowIndex].Cells["Unit_ID"].Value);
                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه الوحدة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool deleted = unitsBLL.DeleteUnit(id);
                        if (deleted)
                        {
                            MessageBox.Show("تم حذف الوحدة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddUnitUC_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن حذف هذه الوحدة لأنها مرتبطة بمنتجات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btn_save_unit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_unit_name.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("يرجى إدخال اسم الفئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                unitsBLL.UpdateUnit(selectedUnitID, name);
                MessageBox.Show("تم التعديل بنجاح.");
                AddUnitUC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء التعديل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_unit_Click(object sender, EventArgs e)
        {
            AddUnitUC_Load(sender, e);
        }

        private void txt_search_unit_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search_unit.Text.Trim();
            DataTable dt = unitsBLL.SearchUnit(searchText);
            DGV_unit.DataSource = dt;
        }
    }
}
