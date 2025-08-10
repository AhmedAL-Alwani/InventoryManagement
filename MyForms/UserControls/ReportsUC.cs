using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.MyForms.InnerUserControls;

namespace InventoryManagement.MyForms.UserControls
{
    public partial class ReportsUC : UserControl
    {
        public MainForm main;
        public ReportsUC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void pic_transactions_repo_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            TransactionsRepo transactionsRepo = new TransactionsRepo(main);
            transactionsRepo.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(transactionsRepo);
        }
    }
}
