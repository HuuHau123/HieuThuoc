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
    public partial class frmTK : Form
    {
        public frmTK()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        Thongke tk = new Thongke();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txttungay.Text == "")
            {
                MessageBox.Show("Nhập ngày cần tìm");
            }
            else if (txtdenngay.Text == "")
            {
                MessageBox.Show("Nhập ngày cần tìm");
            }
            else
            {
                DataTable tb = tk.searchMocThoiGian(txttungay.Text, txtdenngay.Text);
                gridViewPN.DataSource = tb;
                if(cbxtTK.Text == "Nhân viên bán nhiều nhất")
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string sqlquery = "select hoten from NhanVien nv inner join HoaDon hd " +
                                        "on nv.manv = hd.manv " +
                                        "where thoigian > '" + txttungay.Text + "' and thoigian< '" + txtdenngay.Text + "' " +
                                        "group by hoten " +
                                        "having sum(hd.thanhtien) >= all(select sum(hd.thanhtien) from HoaDon group by manv)";

                    cmd = new SqlCommand(sqlquery, sqlcon);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtnhanvientop1.Text = (string)rd["hoten"];
                    }
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
                else if(cbxtTK.Text == "Thuốc bán nhiều nhất")
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string sqlquery = "select t.tenthuoc from Thuoc t inner join HoaDon hd on t.mathuoc = hd.mathuoc where thoigian > '"+txttungay.Text+"' and thoigian < '"+txtdenngay.Text+"' " +
                                      "group by t.tenthuoc having count(hd.mathuoc) >= all(select count(hd.mathuoc) from HoaDon group by mathuoc)";

                    cmd = new SqlCommand(sqlquery, sqlcon);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtthuocbantop1.Text = (string)rd["tenthuoc"];
                    }
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
                else if (cbxtTK.Text == "Tổng tiền nhập thuốc")
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string sqlquery = "select sum(tongtien) as 'Tongtien'from PhieuNhap where ngaynhap > '" + txttungay.Text + "' and ngaynhap < '" + txtdenngay.Text + "' ";
                    cmd = new SqlCommand(sqlquery, sqlcon);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lbTongtiennhap.Text = (string)rd["Tongtien"].ToString();
                    }
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
                else if (cbxtTK.Text == "Tổng tiền bán thuốc")
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string sqlquery = "select sum(thanhtien) as 'Tongtien'from HoaDon where thoigian > '" + txttungay.Text + "' and thoigian < '" + txtdenngay.Text + "' ";
                    cmd = new SqlCommand(sqlquery, sqlcon);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lbtongtienban.Text = (string)rd["Tongtien"].ToString();
                    }
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
                else if (cbxtTK.Text == "Doanh thu")
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string sqlquery = "declare @tiennhap float " +
                                      "declare @tienban float " +
                                      "select @tiennhap = sum(tongtien) from PhieuNhap where ngaynhap > '" + txttungay.Text + "' and ngaynhap < '" + txtdenngay.Text + "' " +
                                      "select @tienban = sum(thanhtien) from HoaDon where thoigian > '" + txttungay.Text + "' and thoigian < '" + txtdenngay.Text + "' " +
                                      "declare @doanhthu float " +
                                      "set @doanhthu = @tienban - @tiennhap "
                                      ;
                    cmd = new SqlCommand(sqlquery, sqlcon);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lbdoanhthu.Text = (string)rd["@doanhthu"].ToString();
                    }
                    if (sqlcon.State == ConnectionState.Open)
                        sqlcon.Close();
                }
            }
            
        }
        PhieuNhap pn = new PhieuNhap();
        HoaDon hd = new HoaDon();
        private void frmTK_Load(object sender, EventArgs e)
        {
            DataTable tb = pn.getPhieuNhap();
            gridViewPN.DataSource = tb;
            DataTable tb1 = hd.getChiTietHD();
            gridViewPX.DataSource = tb1;
            
        }
    }
}
