using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class Thuoc
    {
        connect con;
        public Thuoc()
        {
            con = new connect();
        }
        public DataTable GetThuoc()
        {
            string sqlquery = "select mathuoc as 'Mã thuốc', tenthuoc as 'Tên thuốc', LoaiThuoc.tenloai as 'Loại thuốc'," +
                "NhaCungCap.tenncc as 'Nhà cung cấp', hamluong as 'Hàm lượng', donggoi as 'Đóng gói'," +
                "gianhap as 'Giá nhập', Thuoc.giaban as 'Giá bán',Donvi.tendonvi as 'Đơn vị',Thuoc.hinhanh as 'Hình ảnh'" +
                "from Thuoc inner join LoaiThuoc " +
                "on Thuoc.loaithuoc = LoaiThuoc.maloai " +
                "inner join NhaCungCap " +
                "on Thuoc.mancc = NhaCungCap.mancc " +
                "inner join DonVi " +
                "on Thuoc.madv = DonVi.madonvi";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void DelThuoc(int mathuoc)
        {
            string sqlquery = string.Format("delete from Thuoc where mathuoc = {0}", mathuoc);
            con.ExcuteNonQuery(sqlquery);
        }
    }
}
