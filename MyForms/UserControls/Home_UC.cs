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

namespace InventoryManagement.UserControls
{
    public partial class Home_UC : UserControl
    {
        public MainForm main;
        public Home_UC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void pic_product_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(main);
            products_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(products_us);
        }

        private void pic_suppliers_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            SuppliersUC suppliers_us = new SuppliersUC(main);
            suppliers_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(suppliers_us);
        }

        private void pic_customers_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            CustomersUC customers_us = new CustomersUC(main);
            customers_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(customers_us);
        }

        private void pic_transactions_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            TransactionUC transaction_us = new TransactionUC(main);
            transaction_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(transaction_us);
        }

        private void pic_reports_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            ReportsUC reports_us = new ReportsUC(main);
            reports_us.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(reports_us);
        }
    }
}
