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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemThuocCu themthuoc = new frmThemThuocCu();
            themthuoc.ShowDialog();
            this.Show();
        }
        Kho kho = new Kho();
        private void frmKho_Load(object sender, EventArgs e)
        {
            DataTable tb = kho.getKho();
            gridviewFrmKho.DataSource = tb;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)gridviewFrmKho.Columns[8];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void gridviewFrmKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridviewFrmKho.Rows[e.RowIndex];
            txtmathuoc.Text = Convert.ToString(row.Cells["Mã thuốc"].Value);
            txtTenthuoc.Text = Convert.ToString(row.Cells["Tên thuốc"].Value);
            txtsoluongton.Text = Convert.ToString(row.Cells["Số lượng tồn"].Value);
            cbxNCC.Text = Convert.ToString(row.Cells["Nhà cung cấp"].Value);
            cbxDonvi.Text = Convert.ToString(row.Cells["Đơn vị"].Value);
            cbxLoaithuoc.Text = Convert.ToString(row.Cells["Mã loại"].Value);
            txtGiaban.Text = Convert.ToString(row.Cells["Giá bán"].Value);
            txtGianhap.Text = Convert.ToString(row.Cells["Giá nhập"].Value);
            if (gridviewFrmKho.CurrentRow.Cells[8].Value.ToString() != "")
            {
                MemoryStream stream = new MemoryStream((byte[])gridviewFrmKho.CurrentRow.Cells[8].Value);
                imgThuoc.Image = Image.FromStream(stream);
            }
            else
            {
                imgThuoc.Image = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtsoluongton.Text == "")
            {
                MessageBox.Show("Nhập số lượng cần sửa");
            }else if(txtmathuoc.Text == "")
            {
                MessageBox.Show("Chọn thuốc cần sửa");
            }
            else
            {
                kho.editKho(int.Parse(txtmathuoc.Text), int.Parse(txtsoluongton.Text));
                frmKho_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtmathuoc.Text == "")
            {
                MessageBox.Show("Chọn thuốc để xóa!");
            }
            else
            {
                kho.delKho(int.Parse(txtmathuoc.Text));
                frmKho_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
        }
    }
}
