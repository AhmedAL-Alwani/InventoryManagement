using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
