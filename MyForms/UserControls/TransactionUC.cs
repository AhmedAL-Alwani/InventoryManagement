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
using InventoryManagement.MyForms.InnerUserControls;

namespace InventoryManagement.MyForms.UserControls
{
    public partial class TransactionUC : UserControl
    {
        public MainForm main;
        public TransactionUC(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

       public enum TransactionMode
        {
            Supply =1,
            Exchange =2,
            SupplyReturn =3,
            ExchangeReturn =4,
        }

        private void LoadTransactionControl(TransactionMode mode)
        {
            main.panelhome.Controls.Clear(); // تأكد من وجود panelMain في الفورم
            subTranscation sub_Transaction = new subTranscation(mode);
            sub_Transaction.Dock = DockStyle.Fill;
            main.panelhome.Controls.Add(sub_Transaction);
        }

        private void btn_Supply_Click(object sender, EventArgs e)
        {
            LoadTransactionControl(TransactionMode.Supply);
        }

        private void btn_Exchange_Click(object sender, EventArgs e)
        {
            LoadTransactionControl(TransactionMode.Exchange);
        }

        private void btn_SupplyReturn_Click(object sender, EventArgs e)
        {
           
            LoadTransactionControl(TransactionMode.SupplyReturn);
        }

        private void btn_ExchangeReturn_Click(object sender, EventArgs e)
        {
            LoadTransactionControl(TransactionMode.ExchangeReturn);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
