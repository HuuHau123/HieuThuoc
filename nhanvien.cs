using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Quan_Ly_Hieu_Thuoc
{
    class nhanvien
    {
        connect con;
        public nhanvien()
        {
            con = new connect();
        }
        public DataTable Laydsnv()
        {
            string sqlquey = "select manv as 'Mã nhân viên', usename as 'Usename', usepass as 'Password', " +
                "ngaysinh as 'Ngày sinh', gioitinh as 'Giới tính', diachi as 'Địa chỉ', chucvu as 'Chức vụ'," +
                "hoten as 'Họ tên', hinhanh as 'Hình ảnh' from NhanVien";
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }
        public void updateNhanVien(string usename, string usepass, string ngaysinh, string gioitinh, string diachi, string chucvu,string hoten,int manv)
        {
            string sqlquery = string.Format("update NhanVien set usename = N'{0}',usepass = N'{1}',ngaysinh = N'{2}',gioitinh = N'{3}'," +
                "diachi = N'{4}',chucvu = N'{5}',hoten = N'{6}' where manv = {7}",usename,usepass,ngaysinh,gioitinh,diachi,chucvu,hoten,manv);
            con.ExcuteNonQuery(sqlquery);
        }
        public void DelNhanVien(int manv)
        {
            string sqlquery = string.Format("delete from NhanVien where manv = {0}", manv);
            con.ExcuteNonQuery(sqlquery);
        }
        public DataTable SearchID(int manv)
        {
            string sqlquey = string.Format("select * from NhanVien where manv like '%{0}%'", manv);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }

        public DataTable SearchName(string hoten)
        {
            string sqlquey = string.Format("select * from NhanVien where hoten like '%{0}%'", hoten);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }

        public DataTable SearchChucVu(string chucvu)
        {
            string sqlquey = string.Format("select * from NhanVien where chucvu like '%{0}%'", chucvu);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }

        public DataTable SearchUsename(string usename)
        {
            string sqlquey = string.Format("select * from NhanVien where usename like '%{0}%'", usename);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }

        public DataTable SearchDiachi(string diachi)
        {
            string sqlquey = string.Format("select * from NhanVien where diachi like '%{0}%'", diachi);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }
        public DataTable SearchGioiTinh(string gioitinh)
        {
            string sqlquey = string.Format("select * from NhanVien where gioitinh like '%{0}%'", gioitinh);
            DataTable tb = con.Execute(sqlquey);
            return tb;
        }
    }
}
