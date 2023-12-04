using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quan_Ly_Hieu_Thuoc
{
    class Kho
    {
        connect con;
        public Kho()
        {
            con = new connect();
        }
        public DataTable getKho()
        {
            string sqlquery = "select t.mathuoc as 'Mã thuốc', t.tenthuoc as 'Tên thuốc', soluongton as 'Số lượng tồn'," +
                                "ncc.tenncc as 'Nhà cung cấp', dv.tendonvi as 'Đơn vị', lt.tenloai as 'Mã loại'," +
                                "t.gianhap as 'Giá bán', t.giaban as 'Giá nhập', t.hinhanh as 'Ảnh'" +
                                "from Kho k inner join Thuoc t on k.mathuoc = t.mathuoc " +
                                "inner join NhaCungCap ncc on k.mancc = ncc.mancc " +
                                "inner join LoaiThuoc lt on k.maloai = lt.maloai " +
                                "inner join DonVi dv on k.madonvi = dv.madonvi ";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void editKho(int mathuoc, int soluongton)
        {
            string sqlquery = string.Format("update Kho set soluongton = {0} where mathuoc = {1}", soluongton, mathuoc);
            con.ExcuteNonQuery(sqlquery);
        }
        public void delKho(int mathuoc)
        {
            string sqlquery = "delete from Kho where mathuoc = '" + mathuoc + "'";
            con.ExcuteNonQuery(sqlquery);
        }
    }
}
