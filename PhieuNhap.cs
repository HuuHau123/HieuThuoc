using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class PhieuNhap
    {
        connect con;
        public PhieuNhap()
        {
            con = new connect();
        }
        public DataTable getPhieuNhap()
        {
            string sqlquery = "select maphieu as 'Mã phiếu', t.tenthuoc as 'Thuốc',ncc.tenncc as 'Nhà cung cấp', dv.tendonvi as 'Đơn vị'," +
                            "ngaynhap as 'Ngày nhập', soluong as 'Số lượng', t.gianhap as 'Giá nhập'," +
                            "t.giaban as 'Giá bán', tongtien as 'Tổng tiền', pn.ghichu as 'Ghi chú' " +
                            "from PhieuNhap pn inner join Thuoc t on pn.mathuoc = t.mathuoc " +
                            "inner join DonVi dv on pn.madv = dv.madonvi " +
                            " inner join NhaCungCap ncc on pn.mancc = ncc.mancc";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void addPhieuNhap(int mathuoc, int madv, string ngaynhap, int soluong, float gianhap,float tongtien ,int mancc, string ghichu)
        {
            string sqlquery = string.Format("insert into PhieuNhap values({0},{1},N'{2}',{3},{4},{5},{6},N'{7}')", mathuoc, madv, ngaynhap, soluong, gianhap, tongtien, mancc, ghichu);
            con.ExcuteNonQuery(sqlquery);
        }
        public void getSoluong(int mathuoc)
        {
            string sqlquery = "select soluongton from Kho where mathuoc '"+mathuoc+"'";
            con.ExcuteNonQuery(sqlquery);
        }
    }
}
