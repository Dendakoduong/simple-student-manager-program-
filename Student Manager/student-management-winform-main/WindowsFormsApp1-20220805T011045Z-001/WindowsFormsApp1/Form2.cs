using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string username = "admin";
        string password = "admin";
 
        public Form2()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (checklogin(username_txb.Text, pass_txb.Text))
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else MessageBox.Show("Wrong username or password", "Login unsuccessful!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            username_txb.Focus();
        }
        bool checklogin(string username, string password)
        {
            if (username== this.username && password == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass_txb.UseSystemPasswordChar = false;
            }
            else
            {
                pass_txb.UseSystemPasswordChar = true;
            }
        }
    }
}
