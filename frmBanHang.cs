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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True");
        SqlCommand cmd;
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet30.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hieuThuocN07_05DataSet30.NhanVien);
            cbxnhanvien.DisplayMember = "manv";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet29.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hieuThuocN07_05DataSet29.Thuoc);
            cbxmathuoc.DisplayMember = "mathuoc";
            datehoadon.Text = DateTime.Today.ToString("yyyy-MM-dd");

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string sqlquey = "select * from Thuoc where mathuoc = '" + cbxmathuoc.Text + "'";
                cmd = new SqlCommand(sqlquey, sqlcon);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txttenthuoc.Text = (string)rd["tenthuoc"].ToString();
                    txtloaithuoc.Text = (string)rd["loaithuoc"].ToString();
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
                int soluong = int.Parse(txtsoluongban.Text);
                float thanhtien;
                float giaban = int.Parse(txtgiaban.Text);
                thanhtien = soluong * giaban;
                txtthanhtien.Text = thanhtien.ToString();
            }
        }
        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (cbxmathuoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thuốc");
            }
            else if (txtsoluongban.Text == "")
            {
                MessageBox.Show("Nhập số lượng mua");
            }
            else if (txttenkh.Text == "")
            {
                MessageBox.Show("Nhập tên khách hàng");
            }
            else if (txttenkh.Text == "")
            {
                MessageBox.Show("Nhập tên khách hàng");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = cbxmathuoc.Text;
                item.SubItems.Add(txttenthuoc.Text);
                item.SubItems.Add(txtloaithuoc.Text);
                item.SubItems.Add(datehoadon.Text);
                item.SubItems.Add(txtgiaban.Text);
                item.SubItems.Add(txtdonvi.Text);
                item.SubItems.Add(txttenkh.Text);
                item.SubItems.Add(txtsoluongban.Text);
                item.SubItems.Add(txtthanhtien.Text);
                listView1.Items.Add(item);

                if (listView1.SelectedIndices.Count > 0)
                {
                    float tongtien = 0;
                    foreach (ColumnHeader header in listView1.Columns)
                    {
                        if (header.Text == "Thành tiền")
                        {
                            foreach (ListViewItem item1 in listView1.Items)
                            {
                                tongtien += Convert.ToInt32(item1.SubItems[8].Text);
                            }
                        }
                    }
                    lbtongtien.Text = tongtien.ToString();
                }
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    cmd = new SqlCommand("insert into HoaDon values(@thoigian, @mathuoc, @manv, @tenthuoc, @tenkh, @soluongban, @donvi, @giaban, @thanhtien)", sqlcon);
                    cmd.Parameters.AddWithValue("thoigian", datehoadon.Text);
                    cmd.Parameters.AddWithValue("mathuoc", cbxmathuoc.Text);
                    cmd.Parameters.AddWithValue("manv", cbxnhanvien.Text);
                    cmd.Parameters.AddWithValue("tenthuoc", txttenthuoc.Text);
                    cmd.Parameters.AddWithValue("tenkh", txttenkh.Text);
                    cmd.Parameters.AddWithValue("soluongban", txtsoluongban.Text);
                    cmd.Parameters.AddWithValue("donvi", txtdonvi.Text);
                    cmd.Parameters.AddWithValue("giaban", txtgiaban.Text);
                    cmd.Parameters.AddWithValue("thanhtien", txtthanhtien.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công!");
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
