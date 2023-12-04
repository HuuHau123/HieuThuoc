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
    public partial class frmQLthuoc : Form
    {
        public frmQLthuoc()
        {
            InitializeComponent();
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        Thuoc thuoc = new Thuoc();
        private void frmQLthuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet20.getLoaithuoc' table. You can move, or remove it, as needed.
            this.getLoaithuocTableAdapter1.Fill(this.hieuThuocN07_05DataSet20.getLoaithuoc);
            cbxLoaithuoc.DisplayMember = "tenloai";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet19.getDonvi' table. You can move, or remove it, as needed.
            this.getDonviTableAdapter1.Fill(this.hieuThuocN07_05DataSet19.getDonvi);
            cbxDonvi.DisplayMember = "tendonvi";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet18.getNhacungcap' table. You can move, or remove it, as needed.
            this.getNhacungcapTableAdapter1.Fill(this.hieuThuocN07_05DataSet18.getNhacungcap);
            cbxNCC.DisplayMember = "tenncc";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet17.getHamluong' table. You can move, or remove it, as needed.
            this.getHamluongTableAdapter1.Fill(this.hieuThuocN07_05DataSet17.getHamluong);
            cbxHamluong.DisplayMember = "hamluong";

            DataTable tb = thuoc.GetThuoc();
            gridviewFrmThuoc.DataSource = tb;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)gridviewFrmThuoc.Columns[9];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemThuoc themthuoc = new frmThemThuoc();
            themthuoc.ShowDialog();
            this.Show();
        }

        private void gridviewFrmThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridviewFrmThuoc.Rows[e.RowIndex];
            txtmathuoc.Text = Convert.ToString(row.Cells["Mã thuốc"].Value);
            txtTenthuoc.Text = Convert.ToString(row.Cells["Tên thuốc"].Value);
            cbxLoaithuoc.Text = Convert.ToString(row.Cells["Loại thuốc"].Value);
            cbxNCC.Text = Convert.ToString(row.Cells["Nhà cung cấp"].Value);
            cbxHamluong.Text = Convert.ToString(row.Cells["Hàm lượng"].Value);
            txtDonggoi.Text = Convert.ToString(row.Cells["Đóng gói"].Value);
            txtGianhap.Text = Convert.ToString(row.Cells["Giá nhập"].Value);
            txtGiaban.Text = Convert.ToString(row.Cells["Giá bán"].Value);
            cbxDonvi.Text = Convert.ToString(row.Cells["Đơn vị"].Value);
            if (gridviewFrmThuoc.CurrentRow.Cells[9].Value.ToString() != "")
            {
                MemoryStream stream = new MemoryStream((byte[])gridviewFrmThuoc.CurrentRow.Cells[9].Value);
                imgThuoc.Image = Image.FromStream(stream);
            }
            else
            {
                imgThuoc.Image = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtmathuoc.Text == "")
            {
                MessageBox.Show("Chọn thuốc để xóa");
            }
            else
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Xóa thuốc!", "Thông báo", MessageBoxButtons.YesNo);
                if(xoa == DialogResult.Yes)
                {
                    thuoc.DelThuoc(int.Parse(txtmathuoc.Text));
                    MessageBox.Show("Xóa thành công");
                    frmQLthuoc_Load(sender, e);
                }
            }
        }
    }
}
