using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class Thongke
    {
        connect con;
        public Thongke()
        {
            con = new connect();
        }
        public DataTable searchMocThoiGian(string time1, string time2)
        {
            string sqlquery = string.Format("select maphieu as 'Mã phiếu', t.tenthuoc as 'Thuốc',ncc.tenncc as 'Nhà cung cấp', dv.tendonvi as 'Đơn vị'," +
                            "ngaynhap as 'Ngày nhập', soluong as 'Số lượng', t.gianhap as 'Giá nhập'," +
                            "t.giaban as 'Giá bán', tongtien as 'Tổng tiền', pn.ghichu as 'Ghi chú' " +
                            "from PhieuNhap pn inner join Thuoc t on pn.mathuoc = t.mathuoc " +
                            "inner join DonVi dv on pn.madv = dv.madonvi " +
                            " inner join NhaCungCap ncc on pn.mancc = ncc.mancc " +
                            "where ngaynhap > N'{0}' and ngaynhap < N'{1}'", time1, time2);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
    }
}
