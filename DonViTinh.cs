using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class DonViTinh
    {
        connect con;
        public DonViTinh()
        {
            con = new connect();
        }
        public DataTable DSDonvitinh()
        {
            string sqlquery = "select madonvi as 'Mã đơn vị', tendonvi as 'Tên đơn vị', ghichu as 'Ghi chú' from DonVi";
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public void AddDVT(string tendv, string giaban)
        {
            string sqlquery = string.Format("insert into DonVi values(N'{0}',N'{1}')", tendv, giaban);
            con.ExcuteNonQuery(sqlquery);
        }
        public void EditDVT(string tendv, string ghichu, int madv)
        {
            string sqlquery = string.Format("update DonVi set tendonvi = N'{0}', ghichu = N'{1}' where madonvi = {2}", tendv, ghichu, madv);
            con.ExcuteNonQuery(sqlquery);
        }
        public void DelDVT(int madv)
        {
            string sqlquery = string.Format("delete from DonVi where madonvi = {0}", madv);
            con.ExcuteNonQuery(sqlquery);
        }
        public DataTable searchMaDV(int madv)
        {
            string sqlquery = string.Format("select * from DonVi where madonvi = {0}", madv);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
        public DataTable searchTenDV(string madv)
        {
            string sqlquery = string.Format("select * from DonVi where tendonvi = N'{0}'", madv);
            DataTable tb = con.Execute(sqlquery);
            return tb;
        }
    }
}
