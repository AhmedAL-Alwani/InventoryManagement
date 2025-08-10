using InventoryManagement.MyForms.UserControls;
using InventoryManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            Home_UC home_uc = new Home_UC(this);
            home_uc.Dock = DockStyle.Fill;
            panelhome.Controls.Add(home_uc);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           /* btnhome.Enabled = false;
            btnproducts.Enabled = false;
            btnsuppliers.Enabled = false;
            btncustomers.Enabled = false;
            btntransactions.Enabled = false;
            btnreports.Enabled = false;
            this.Show();
            Login log = new Login(this);
            log.ShowDialog();*/
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            Products_UC products_us = new Products_UC(this);
            products_us.Dock = DockStyle.Fill;
            panelhome.Controls.Add(products_us);
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            SuppliersUC suppliers_us = new SuppliersUC(this);
            suppliers_us.Dock = DockStyle.Fill;
            panelhome.Controls.Add(suppliers_us);
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            CustomersUC customers_us = new CustomersUC(this);
            customers_us.Dock = DockStyle.Fill;
            panelhome.Controls.Add(customers_us);
        }

        private void btntransactions_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            TransactionUC transaction_us = new TransactionUC(this);
            transaction_us.Dock = DockStyle.Fill;
            panelhome.Controls.Add(transaction_us);
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            ReportsUC reports_us = new ReportsUC(this);
            reports_us.Dock = DockStyle.Fill;
            panelhome.Controls.Add(reports_us);
        }
    }
}
