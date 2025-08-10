using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using InventoryManagement.MyForms.InnerUserControls;
=======
>>>>>>> 560d346428c99d5576ad73d7fdbf828c372fff2e

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
<<<<<<< HEAD

        private void pic_transactions_repo_Click(object sender, EventArgs e)
        {
            main.panelhome.Controls.Clear();
            TransactionsRepo transactionsRepo = new TransactionsRepo(main);
            transactionsRepo.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(transactionsRepo);
        }
=======
>>>>>>> 560d346428c99d5576ad73d7fdbf828c372fff2e
    }
}
