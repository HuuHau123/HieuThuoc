using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class NhaCungCap
    {
        connect con;
        public NhaCungCap()
        {
            con = new connect();
        }

        public DataTable LayDsNCC()
        {
            string sqlquery = "select mancc as 'Mã nhà cung cấp', tenncc as 'Tên nhà cung cấp', sdt as 'Điện thoại'," +
                "diachi as 'Địa chỉ' from NhaCungCap";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void AddNCC(string tenncc, string diachi, string dienthoai)
        {
            string sqlquery = string.Format("insert into NhaCungCap values(N'{0}',N'{1}',N'{2}')", tenncc, diachi, dienthoai);
            con.ExcuteNonQuery(sqlquery);
        }
        public void EditNCC(string tenncc, string diachi, string dienthoai, int mancc)
        {
            string sqlquey = string.Format("update NhaCungCap set tenncc = N'{0}',diachi = N'{1}',dienthoai = N'{2}'" +
                "where mancc = {3}", tenncc, diachi, dienthoai, mancc);
            con.ExcuteNonQuery(sqlquey);
        }
        public void DelNCC(int mancc)
        {
            string query = string.Format("delete from NhaCungCap where mancc = {0}", mancc);
            con.ExcuteNonQuery(query);
        }
        public DataTable searchMaNCC(int mancc) 
        {
            string sqlquery = string.Format("select * from NhaCungCap where mancc like '%{0}%'", mancc);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public DataTable searchTenNCC(string tenncc)
        {
            string sqlquery = string.Format("select * from NhaCungCap where tenncc like '%{0}%'", tenncc);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public DataTable searchDiachi(string diachi)
        {
            string sqlquery = string.Format("select * from NhaCungCap where diachi like '%{0}%'", diachi);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
    }
}
