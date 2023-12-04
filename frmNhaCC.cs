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
    public partial class frmNhaCC : Form
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            DataTable tb = ncc.LayDsNCC();
            girdViewNCC.DataSource = tb;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txttenncc.Text == "")
            {
                MessageBox.Show("Nhập tên nhà cung cấp!");
            }
            else if (txtdiadiem.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ nhà cung cấp!");
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại nhà cung cấp!");
            }
            else
            {
                ncc.AddNCC(txttenncc.Text, txtdiadiem.Text, txtsdt.Text);
                frmNhaCC_Load(sender, e);
            }
        }

        private void girdViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = girdViewNCC.Rows[e.RowIndex];
            txtmancc.Text = Convert.ToString(row.Cells["Mã nhà cung cấp"].Value);
            txtdiadiem.Text = Convert.ToString(row.Cells["Địa chỉ"].Value);
            txttenncc.Text = Convert.ToString(row.Cells["Tên nhà cung cấp"].Value);
            txtsdt.Text = Convert.ToString(row.Cells["Điện thoại"].Value);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txttenncc.Text == "")
            {
                MessageBox.Show("Nhập tên nhà cung cấp!");
            }
            else if (txtdiadiem.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ nhà cung cấp!");
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại nhà cung cấp!");
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp để sửa");
            }
            else
            {
                ncc.EditNCC(txttenncc.Text, txtdiadiem.Text, txtsdt.Text,int.Parse(txtmancc.Text));
                frmNhaCC_Load(sender, e);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(txtmancc.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp để xóa");
            }
            else
            {
                ncc.DelNCC(int.Parse(txtmancc.Text));
                ClearTextBoxes();
                frmNhaCC_Load(sender, e);
            }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void cbmanccs_CheckedChanged(object sender, EventArgs e)
        {
            if(cbmanccs.Checked == true)
            {
                txtmanccs.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else
            {
                txtmanccs.Enabled = false;
                btnTimkiem.Enabled = false;
            }
        }

        private void cbtennccs_CheckedChanged(object sender, EventArgs e)
        {
            if(cbtennccs.Checked == true)
            {
                txttennccs.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else
            {
                txttennccs.Enabled = false;
                btnTimkiem.Enabled = false;
            }
        }

        private void cbdiachis_CheckedChanged(object sender, EventArgs e)
        {
            if(cbdiachis.Checked == true)
            {
                txtdiachis.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else
            {
                txtdiachis.Enabled = false;
                btnTimkiem.Enabled = false;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(cbmanccs.Checked)
            {
                if(txtmanccs.Text == "")
                {
                    MessageBox.Show("Nhập mã nhà cung cấp để tìm");
                }
                else
                {
                    DataTable tb = ncc.searchMaNCC(int.Parse(txtmanccs.Text));
                    girdViewNCC.DataSource = tb;
                }
            }
            if (cbtennccs.Checked)
            {
                if (txttennccs.Text == "")
                {
                    MessageBox.Show("Nhập tên nhà cung cấp để tìm");
                }
                else
                {
                    DataTable tb = ncc.searchTenNCC(txttennccs.Text);
                    girdViewNCC.DataSource = tb;
                }
            }
            if (cbmanccs.Checked)
            {
                if (txtdiachis.Text == "")
                {
                    MessageBox.Show("Nhập địa chỉ nhà cung cấp để tìm");
                }
                else
                {
                    DataTable tb = ncc.searchDiachi(txtdiachis.Text);
                    girdViewNCC.DataSource = tb;
                }
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
