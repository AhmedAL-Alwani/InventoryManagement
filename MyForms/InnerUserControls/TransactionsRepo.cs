using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.MyForms.UserControls;
using InventoryManagement.BLL;

namespace InventoryManagement.MyForms.InnerUserControls
{
    public partial class TransactionsRepo : UserControl
    {
        public MainForm main;
        TransactionsRepoBLL transactionsRepoBLL = new TransactionsRepoBLL();
        private ItemBLL itemBLL = new ItemBLL();
        public TransactionsRepo(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btn_back1_to_repo_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            ReportsUC reportsuc = new ReportsUC(main);
            reportsuc.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(reportsuc);
        }

        private void TransactionsRepo_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            label_show_username.Text = main.username;
        }
        public  void FillComboBoxes()
        {
            DataTable dtTypeTransactions = new DataTable();
            cmbTransactionType.DataSource = transactionsRepoBLL.GetAllTypeTransactions();
            cmbTransactionType.DisplayMember = "TransactionType_Name";
            cmbTransactionType.ValueMember = "TransactionType_ID";


            DataTable dtitems = new DataTable();
            cmbItem.DataSource = transactionsRepoBLL.GetAllItem(); ;
            cmbItem.DisplayMember = "Item_Name";
            cmbItem.ValueMember = "Item_ID";
            cmbItem.SelectedIndex = 0;

            DataTable dtCategories = itemBLL.GetCategories();
            DataRow allrowcategory = dtCategories.NewRow();
            allrowcategory["Category_ID"] = DBNull.Value;
            allrowcategory["Category_Name"] = "الكل";
            dtCategories.Rows.InsertAt(allrowcategory, 0);
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = dtCategories;
            cmbCategory.DisplayMember = "Category_Name";
            cmbCategory.ValueMember = "Category_ID";
            cmbCategory.SelectedIndex = 0;
        }
    }
}
