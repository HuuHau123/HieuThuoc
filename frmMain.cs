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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        private Form activeForm = null;
        private void CustomDesigning(Form mainForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = mainForm;
            mainForm.TopLevel = false;
            mainForm.FormBorderStyle = FormBorderStyle.None;
            mainForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(mainForm);
            panelMain.Tag = mainForm;
            mainForm.BringToFront();
            mainForm.Show();
        }
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            CustomDesigning(new frmNhanVien());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmNhaCC());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmThuoc());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmThongKe());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmBanHang());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmKho());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmTK());
        }
    }
}
