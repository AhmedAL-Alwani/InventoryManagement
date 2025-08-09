using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.MyForms.UserControls;

namespace InventoryManagement.MyForms.InnerUserControls
{
    public partial class TransactionsRepo : UserControl
    {
        public MainForm main;
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
    }
}
