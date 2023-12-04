using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class LoaiThuoc
    {
        connect con;
        public LoaiThuoc()
        {
            con = new connect();
        }

        public DataTable laydsloaithuoc()
        {
            string sqlquery = "select maloai as 'Mã loại thuốc', tenloai as 'Tên loại thuốc', ghichu as 'Ghi chú' from LoaiThuoc";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void AddLoaiThuoc(string tenloai, string ghichu)
        {
            string sqlquery = string.Format("insert into LoaiThuoc values(N'{0}',N'{1}')", tenloai, ghichu);
            con.ExcuteNonQuery(sqlquery);
        }
        public void EditLoaiThuoc(string tenloai, string ghichu, int maloai)
        {
            string sqlquery = string.Format("update LoaiThuoc set tenloai = N'{0}',ghichu = N'{1}' where maloai = {2}", tenloai, ghichu,maloai);
            con.ExcuteNonQuery(sqlquery);
        }
        public void DelLoaiThuoc(int maloai)
        {
            string sqlquery = string.Format("delete from LoaiThuoc where maloai = {0}",maloai);
            con.ExcuteNonQuery(sqlquery);
        }
        public DataTable searchMaLoai(int maloai)
        {
            string sqlquery = string.Format("select * from LoaiThuoc where maloai like {0}", maloai);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public DataTable searchTenLoai(string maloai)
        {
            string sqlquery = string.Format("select * from LoaiThuoc where tenloai like {0}", maloai);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
    }
}
