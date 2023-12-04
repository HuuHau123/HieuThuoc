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
    public partial class frmLoaiDuocPham : Form
    {
        public frmLoaiDuocPham()
        {
            InitializeComponent();
        }
        LoaiThuoc lt = new LoaiThuoc();
        private void frmLoaiDuocPham_Load(object sender, EventArgs e)
        {
            DataTable tb = lt.laydsloaithuoc();
            gridviewLoaiThuoc.DataSource = tb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenloai.Text == "")
            {
                MessageBox.Show("Nhập tên loại thuốc");
            }
            else
            {
                lt.AddLoaiThuoc(txtTenloai.Text, txtMota.Text);
                MessageBox.Show("Thêm thành công");
                frmLoaiDuocPham_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenloai.Text == "")
            {
                MessageBox.Show("Nhập tên loại thuốc");
            }else if(txtmaloai.Text == "")
            {
                MessageBox.Show("Chọn loại thuốc để sửa");
            }
            else
            {
                lt.EditLoaiThuoc(txtTenloai.Text, txtMota.Text, int.Parse(txtmaloai.Text));
                MessageBox.Show("Sửa thành công");
                frmLoaiDuocPham_Load(sender, e);
            }
        }

        private void gridviewLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridviewLoaiThuoc.Rows[e.RowIndex];
            txtmaloai.Text = Convert.ToString(row.Cells["Mã loại thuốc"].Value);
            txtTenloai.Text = Convert.ToString(row.Cells["Tên loại thuốc"].Value);
            txtMota.Text = Convert.ToString(row.Cells["Ghi chú"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtmaloai.Text == "")
            {
                MessageBox.Show("Chọn thuốc để xóa!");
            }
            else
            {
                lt.DelLoaiThuoc(int.Parse(txtmaloai.Text));
                MessageBox.Show("Xóa thành công!");
                frmLoaiDuocPham_Load(sender, e);
            }
        }

        private void cbTKtenloai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTKtenloai.Checked)
            {
                txtTenloaiS.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else
            {
                txtTenloaiS.Enabled = false;
                btnTimkiem.Enabled = false;
            }
        }

        private void cbTKmaloai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTKmaloai.Checked)
            {
                txtMaloaiS.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else
            {
                txtMaloaiS.Enabled = false;
                btnTimkiem.Enabled = false;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbTKmaloai.Checked)
            {
                if(txtMaloaiS.Text == "")
                {
                    MessageBox.Show("Nhập mã để tìm!");
                }
                else
                {
                    DataTable tb = lt.searchMaLoai(int.Parse(txtMaloaiS.Text));
                    gridviewLoaiThuoc.DataSource = tb;
                }
            }
            if (cbTKtenloai.Checked)
            {
                if (txtTenloaiS.Text == "")
                {
                    MessageBox.Show("Nhập tên để tìm!");
                }
                else
                {
                    DataTable tb = lt.searchTenLoai(txtTenloaiS.Text);
                    gridviewLoaiThuoc.DataSource = tb;
                }
            }
        }
    }
}
