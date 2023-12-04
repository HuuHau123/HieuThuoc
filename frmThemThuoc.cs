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
using System.Data.SqlClient;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmThemThuoc : Form
    {
        public frmThemThuoc()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTenthuoc.Text == "")
            {
                MessageBox.Show("Nhập tên thuốc!");
            }else if (txtDonggoi.Text == "")
            {
                MessageBox.Show("Nhập cách đóng gói!");
            }
            else if (txtGianhap.Text == "")
            {
                MessageBox.Show("Nhập giá nhập!");
            }
            else if (txtgiaban.Text == "")
            {
                MessageBox.Show("Chọn giá bán!");
            }
            else if (cbxhamluong.Text == "")
            {
                MessageBox.Show("Nhập hàm lượng!");
            }
            else if (cbDonvi.Text == "")
            {
                MessageBox.Show("Chọn đơn vị!");
            }
            else if (cbxLoaithuoc.Text == "")
            {
                MessageBox.Show("Chọn loại thuốc!");
            }
            else if (cbxNCC.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp!");
            }else if(ImgThuoc.Image == null)
            {
                MessageBox.Show("Chọn ảnh thuốc!");
            }else if(cbxchietkhau.Text == "")
            {
                MessageBox.Show("Chọn chiết khấu");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into Thuoc values(@tenthuoc,@loaithuoc,@mancc," +
                    "@hamluong,@donggoi,@giaban,@gianhap,@madv,@hinhanh)", sqlcon);
                    cmd.Parameters.AddWithValue("tenthuoc", txtTenthuoc.Text);
                    cmd.Parameters.AddWithValue("loaithuoc", cbxLoaithuoc.Text);
                    cmd.Parameters.AddWithValue("mancc", cbxNCC.Text);
                    cmd.Parameters.AddWithValue("hamluong", cbxhamluong.Text);
                    cmd.Parameters.AddWithValue("donggoi", txtDonggoi.Text);
                    cmd.Parameters.AddWithValue("gianhap", txtGianhap.Text);
                    cmd.Parameters.AddWithValue("giaban", txtgiaban.Text);
                    cmd.Parameters.AddWithValue("madv", cbDonvi.Text);
                    MemoryStream stream = new MemoryStream();
                    ImgThuoc.Image.Save(stream, ImgThuoc.Image.RawFormat);
                    cmd.Parameters.AddWithValue("hinhanh", stream.ToArray());
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Thành công");
                }catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmThemThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet27.DonVi' table. You can move, or remove it, as needed.
            this.donViTableAdapter3.Fill(this.hieuThuocN07_05DataSet27.DonVi);
            cbDonvi.DisplayMember = "madonvi";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet26.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter2.Fill(this.hieuThuocN07_05DataSet26.NhaCungCap);
            cbxNCC.DisplayMember = "mancc";
            // TODO: This line of code loads data into the 'hieuThuocN07_05DataSet25.LoaiThuoc' table. You can move, or remove it, as needed.
            this.loaiThuocTableAdapter2.Fill(this.hieuThuocN07_05DataSet25.LoaiThuoc);
            cbxLoaithuoc.DisplayMember = "maloai";
/*            cbxchietkhau.SelectedIndex = 0;*/
            cbxhamluong.SelectedIndex = 0;
        }
        private void cbxchietkhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGianhap.Text != "")
            {
                int gianhap;
                gianhap = int.Parse(txtGianhap.Text);
                int giaban = 0;
                if (this.cbxchietkhau.SelectedItem.ToString() == "5%")
                {
                    giaban = gianhap + (gianhap * 5) / 100;
                }

                if (this.cbxchietkhau.SelectedItem.ToString() == "10%")
                {
                    giaban = gianhap + (gianhap * 10) / 100;
                }
                if (this.cbxchietkhau.SelectedItem.ToString() == "15%")
                {
                    giaban = gianhap + (gianhap * 15) / 100;
                }
                txtgiaban.Text = giaban.ToString();
            }
        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
