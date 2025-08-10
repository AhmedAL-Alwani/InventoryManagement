using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.UserControls;


namespace InventoryManagement
{
    public partial class Login : Form
    {
       private MainForm main;
        public Login(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if(txtname.Text=="ahmed" && txtpass.Text == "123")
            {
                main.btnhome.Enabled = true;
                main.btnproducts.Enabled = true;
                main.btnsuppliers.Enabled = true;
                main.btncustomers.Enabled = true;
                main.btntransactions.Enabled = true;
                main.btnreports.Enabled = true;
                main.panelhome.Controls.Clear();
                Home_UC h = new Home_UC(main);
                h.Dock = DockStyle.Fill;
                main.panelhome.Controls.Add(h);
                a = true;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Name or passwoed isn't correct");
                txtname.Clear();
                txtpass.Clear();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() != "")
            {
                txtpass.ReadOnly = false;
                if (txtpass.Text.Trim() != "")
                {
                    btnlog.Enabled = true;
                }
                else
                {
                    btnlog.Enabled = false;
                }
            }
            else
            {
                txtpass.ReadOnly = true;
                btnlog.Enabled = false;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if(txtpass.Text.Trim()!="")
            {
                btnlog.Enabled = true;
            }
            else
            {
                btnlog.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <'0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
        bool a=false;
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!a)
            {
                Application.Exit();
            }
        }
    }
}
