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
    public partial class frmThemNV : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True");
        SqlCommand cmd;
        public frmThemNV()
        {
            InitializeComponent();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImgUser.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Tài khoản nhân viên không được để trống!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Mật khẩu nhân viên không được để trống!");
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!");
            }
            else if (txtHoten.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
            }
            else if (cbxChucvu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }
            else if (cbxGioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }else if(ImgUser.Image == null)
            {
                MessageBox.Show("Chọn ảnh");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("Insert into NhanVien values(@usename,@usepass,@ngaysinh,@gioitinh," +
                    "@diachi,@chucvu,@hoten,@hinhanh)", sqlcon);
                    cmd.Parameters.AddWithValue("usename", txtUsername.Text);
                    cmd.Parameters.AddWithValue("usepass", txtPass.Text);
                    cmd.Parameters.AddWithValue("ngaysinh", datengaysinh.Text);
                    cmd.Parameters.AddWithValue("gioitinh", cbxGioitinh.Text);
                    cmd.Parameters.AddWithValue("diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("chucvu", cbxChucvu.Text);
                    cmd.Parameters.AddWithValue("hoten", txtHoten.Text);
                    MemoryStream stream = new MemoryStream();
                    ImgUser.Image.Save(stream, ImgUser.Image.RawFormat);
                    cmd.Parameters.AddWithValue("hinhanh", stream.ToArray());
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Thành Công");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
