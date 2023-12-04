using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True");
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
            panelTK.Controls.Add(mainForm);
            panelTK.Tag = mainForm;
            mainForm.BringToFront();
            mainForm.Show();
        }
        private void tHÔNGKÊNHÂPHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmPhieuNhap());
        }
        HoaDon cthd = new HoaDon();
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet34.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hieuThuocN07_05DataSet34.NhanVien);
            cbxnhanvien.DisplayMember = "manv";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet31.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hieuThuocN07_05DataSet31.Thuoc);
            cbxmathuoc.DisplayMember = "mathuoc";
            DataTable tb = cthd.getChiTietHD();
            gridViewCTHoaDon.DataSource = tb;
        }

        private void cbxmathuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string sqlquey = "select * from Thuoc where mathuoc = '" + cbxmathuoc.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlquey, sqlcon);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txttenthuoc.Text = (string)rd["tenthuoc"].ToString();
                    txtdonvi.Text = (string)rd["madv"].ToString();
                    txtgiaban.Text = (string)rd["giaban"].ToString();
                }
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsoluongban_TextChanged(object sender, EventArgs e)
        {
            if(txtsoluongban.Text != "")
            {
                int sl = int.Parse(txtsoluongban.Text);
                float giaban = float.Parse(txtgiaban.Text);
                float thanhtien = sl * giaban;
                txtthanhtien.Text = thanhtien.ToString();
            }
        }

        private void xEMPHIẾUXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomDesigning(new frmThongKe());
            menuStrip1.Hide();
        }

        private void gridViewCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridViewCTHoaDon.Rows[e.RowIndex];
            txtmahd.Text = Convert.ToString(row.Cells["Mã hóa đơn"].Value);
            cbxmathuoc.Text = Convert.ToString(row.Cells["Mã thuốc"].Value);
            txttenthuoc.Text = Convert.ToString(row.Cells["Tên thuốc"].Value);
            txtkh.Text = Convert.ToString(row.Cells["Khách hàng"].Value);
            datehoadon.Text = Convert.ToString(row.Cells["Thời gian"].Value);
            cbxnhanvien.Text = Convert.ToString(row.Cells["Nhân viên"].Value);
            txtsoluongban.Text = Convert.ToString(row.Cells["Số lượng bán"].Value);
            txtdonvi.Text = Convert.ToString(row.Cells["Đơn vị bán"].Value);
            txtthanhtien.Text = Convert.ToString(row.Cells["Thanh toán"].Value);
        }
    }
}
