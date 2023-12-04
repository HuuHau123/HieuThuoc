using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*  if(txtAcc.Text == "SOS" && txtPass.Text == "lol")
              {

              }*/
            frmMain m = new frmMain();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbshow.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
                cbshow.Text = "Hide password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
                cbshow.Text = "Show password";
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
