using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        nhanvien nv = new nhanvien();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThemNV tnv = new frmThemNV();
            tnv.Show();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet33.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.hieuThuocN07_05DataSet33.NhanVien);
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet32.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hieuThuocN07_05DataSet32.NhanVien);
            DataTable tb = nv.Laydsnv();
            txtmanv.Enabled = false;
            cbxgioitinh.SelectedIndex = -1;
            gridViewNV.DataSource = tb;
            cbxgioitinh.DisplayMember = "gioitinh";
            cbxchucvu.DisplayMember = "chucvu";
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void gridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridViewNV.Rows[e.RowIndex];
            txtmanv.Text = Convert.ToString(row.Cells["Mã nhân viên"].Value);
            txtusename.Text = Convert.ToString(row.Cells["Usename"].Value);
            txtpass.Text = Convert.ToString(row.Cells["Password"].Value);
            dateNgaysinh.Text = Convert.ToString(row.Cells["Ngày sinh"].Value);
            cbxgioitinh.Text = Convert.ToString(row.Cells["Giới tính"].Value);
            txtdiachi.Text = Convert.ToString(row.Cells["Địa chỉ"].Value);
            cbxchucvu.Text = Convert.ToString(row.Cells["Chức vụ"].Value);
            txthoten.Text = Convert.ToString(row.Cells["Họ tên"].Value);
            if (gridViewNV.CurrentRow.Cells[8].Value.ToString() != "")
            {
                MemoryStream stream = new MemoryStream((byte[])gridViewNV.CurrentRow.Cells[8].Value);
                imgNhanVien.Image = Image.FromStream(stream);
            }
            else
            {
                imgNhanVien.Image = null;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtusename.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống!");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
            }
            else if (txtmanv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
            else if (txthoten.Text == "")
            {
                MessageBox.Show("Tên không được để trống!");
            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!");
            }
            else if (cbxchucvu.Text == "")
            {
                MessageBox.Show("Chức vụ không được để trống!");
            }
            else if (cbxgioitinh.Text == "")
            {
                MessageBox.Show("Giới tính không được để trống!");
            }
            else
            {
                nv.updateNhanVien(
                    txtusename.Text, txtpass.Text, dateNgaysinh.Text, cbxgioitinh.Text
                    , txtdiachi.Text, cbxchucvu.Text, txthoten.Text, int.Parse(txtmanv.Text));
                MessageBox.Show("Sửa thành công");
                frmNhanVien_Load(sender, e);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
            else
            {
                nv.DelNhanVien(int.Parse(txtmanv.Text));
                MessageBox.Show("Xóa thành công");
                frmNhanVien_Load(sender, e);
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
            imgNhanVien.Image = null;
        }

        private void cbgioitinhs_CheckedChanged(object sender, EventArgs e)
        {
            if(cbgioitinhs.Checked == true)
            {
                cbxGioitinhS.Enabled = true;
            }
            else
            {
                cbxGioitinhS.Enabled = false;
            }
        }

        private void cbmanvs_CheckedChanged(object sender, EventArgs e)
        {
            if(cbmanvs.Checked == true)
            {
                txtmanvs.Enabled = true;
            }
            else
            {
                txtmanvs.Enabled = false;
            }
        }

        private void cbtennvs_CheckedChanged(object sender, EventArgs e)
        {
            if(cbtennvs.Checked == true)
            {
                txttennvs.Enabled = true;
            }
            else
            {
                txttennvs.Enabled = false;
            }
        }

        private void cbchucvus_CheckedChanged(object sender, EventArgs e)
        {
            if(cbchucvus.Checked == true)
            {
                cbxchucvus.Enabled = true;
            }
            else
            {
                cbxchucvus.Enabled = false;
            }
        }

        private void cbUsenames_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUsenames.Checked == true)
            {
                txtusenames.Enabled = true;
            }
            else
            {
                txtusenames.Enabled = false;
            }
        }

        private void cbdiachis_CheckedChanged(object sender, EventArgs e)
        {
            if(cbdiachis.Checked == true)
            {
                txtdiachis.Enabled = true;
            }
            else
            {
                txtdiachis.Enabled = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (cbmanvs.Checked == true)
            {
                if (txtmanvs.Text == "")
                {
                    MessageBox.Show("Nhập mã để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchID(int.Parse(txtmanvs.Text));
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (cbtennvs.Checked == true)
            {
                if (txttennvs.Text == "")
                {
                    MessageBox.Show("Nhập tên để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchName(txttennvs.Text);
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (cbgioitinhs.Checked == true)
            {
                if (cbxGioitinhS.Text == "")
                {
                    MessageBox.Show("Chọn giới tính để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchGioiTinh(cbxGioitinhS.Text);
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (cbchucvus.Checked == true)
            {
                if (cbxchucvus.Text == "")
                {
                    MessageBox.Show("Chọn chức vụ để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchChucVu(cbxchucvus.Text);
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (cbUsenames.Checked == true)
            {
                if (txtusenames.Text == "")
                {
                    MessageBox.Show("Nhập tên để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchUsename(txtusenames.Text);
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (cbUsenames.Checked == true)
            {
                if (txtusenames.Text == "")
                {
                    MessageBox.Show("Nhập địa chỉ để tìm!");
                }
                else
                {
                    DataTable tb = nv.SearchDiachi(txtdiachis.Text);
                    gridViewNV.DataSource = tb;
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)gridViewNV.Columns[8];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else
            {
                btnTImkiem.Enabled = false;
            }
        }

        private void txtmanvs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
