using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class HoaDon
    {
        connect con;
        public HoaDon()
        {
            con = new connect();
        }
        public DataTable getChiTietHD()
        {
            string sqlquery = "select mahd as 'Mã hóa đơn', thoigian as 'Thời gian',nv.manv as 'Nhân viên' ,t.mathuoc as 'Mã thuốc', t.tenthuoc as 'Tên thuốc'," +
                               "soluongban as 'Số lượng bán', dv.madonvi as 'Đơn vị bán', t.giaban as 'Giá bán',tenkh as 'Khách hàng', thanhtien as 'Thanh toán' " +
                               "from HoaDon ct inner join Thuoc t on ct.mathuoc = t.mathuoc " +
                               "inner join NhanVien nv on ct.manv = nv.manv " +
                               "inner join DonVi dv on ct.donvi = dv.madonvi";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
/*        public void addHD(int mathuoc,int manv, int slb, int donvi, float giaban, float thanhtien, string tenthuoc, string thoigian, string tenkh)
        {
            string sqlquery = string.Format("insert into HoaDon values({0},{1},{2},{3},{4},{5},N'{6}',N'{7}',N'{8}')",
                mathuoc,manv,slb,donvi,giaban,thanhtien,tenthuoc,thoigian,tenkh);
            con.ExcuteNonQuery(sqlquery);
        }*/
    }
}
