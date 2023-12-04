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
using System.IO;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmThemThuocCu : Form
    {
        public frmThemThuocCu()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True");
        SqlCommand cmd;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImgThuoc.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemThuocCu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet28.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hieuThuocN07_05DataSet28.Thuoc);
            cbxmathuoc.DisplayMember = "mathuoc";
            datengaynhap.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void cbxmathuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Thuoc where mathuoc = '" + cbxmathuoc.Text + "'", sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string tenthuoc = (string)rd["tenthuoc"].ToString();
                txttenthuoc.Text = tenthuoc;

                int maloai = int.Parse((string)rd["loaithuoc"].ToString());
                txttenloai.Text = maloai.ToString();

                int ncc = int.Parse(rd["mancc"].ToString());
                txtncc.Text = ncc.ToString();

                int madv = int.Parse(rd["madv"].ToString());
                txtdonvi.Text = madv.ToString();

                float gianhap = float.Parse(rd["gianhap"].ToString());
                txtgianhap.Text = gianhap.ToString();

                float giaban = float.Parse(rd["giaban"].ToString());
                txtgiaban.Text = giaban.ToString();

                var data = (Byte[])rd["hinhanh"];
                var stream = new MemoryStream(data);
                ImgThuoc.Image = Image.FromStream(stream);

                
            }
            sqlcon.Close();
        }
        PhieuNhap pn = new PhieuNhap();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cbxmathuoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thuốc");
            }
            else if(txtsoluong.Text == "")
            {
                MessageBox.Show("Nhập số lượng");
            }
            
            else
            {
                cmd = new SqlCommand("insert into Kho values(@mathuoc,@tenthuoc,@soluongton,@mancc,@madonvi,@maloai,@hinhanh,@gianhap,@giaban)", sqlcon);
                cmd.Parameters.AddWithValue("mathuoc", cbxmathuoc.Text);
                cmd.Parameters.AddWithValue("tenthuoc", txttenthuoc.Text);
                cmd.Parameters.AddWithValue("soluongton", txtsoluong.Text);
                cmd.Parameters.AddWithValue("mancc", txtncc.Text);
                cmd.Parameters.AddWithValue("madonvi", txtdonvi.Text);
                cmd.Parameters.AddWithValue("maloai", txttenloai.Text);
                cmd.Parameters.AddWithValue("gianhap", txtgianhap.Text);
                cmd.Parameters.AddWithValue("giaban", txtgiaban.Text);
                MemoryStream stream = new MemoryStream();
                ImgThuoc.Image.Save(stream, ImgThuoc.Image.RawFormat);
                cmd.Parameters.AddWithValue("hinhanh", stream.ToArray());
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                pn.addPhieuNhap(int.Parse(cbxmathuoc.Text), int.Parse(txttenloai.Text), datengaynhap.Text, int.Parse(txtsoluong.Text), float.Parse(txtgianhap.Text), float.Parse(txtthanhtien.Text), int.Parse(txtncc.Text), txtghichu.Text);
                MessageBox.Show("Thành công");
                sqlcon.Close();
            }
        }

        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            if (txtgianhap.Text != "" && txtgiaban.Text != "")
            {
                float a = float.Parse(txtgianhap.Text);
                float b = float.Parse(txtgiaban.Text);
                float c = a + (a * 5) / 100;
                float d = a + (a * 10) / 100;
                float f = a + (a * 15) / 100;
                if (b == c)
                {
                    txtchietkhau.Text = "5%";
                }
                if (b == d)
                {
                    txtchietkhau.Text = "10%";
                }
                if (b == f)
                {
                    txtchietkhau.Text = "15%";
                }
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if(txtsoluong.Text != "" && txtgiaban.Text != "")
            {
                int soluong = int.Parse(txtsoluong.Text);
                float gianhap = float.Parse(txtgianhap.Text);
                float tongtien = (float)(soluong * gianhap);
                txtthanhtien.Text = tongtien.ToString();
            }
        }
    }
}
