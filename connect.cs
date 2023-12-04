using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quan_Ly_Hieu_Thuoc
{
    class connect
    {
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        DataSet ds;

        public connect()
        {
            //test git
            string connect = @"Data Source=DESKTOP-B3M8HSN;Initial Catalog=HieuThuocN07_05;Integrated Security=True";
            sqlcon = new SqlConnection(connect);
        }

        public DataTable Execute(string sqlquery)
        {
            adapter = new SqlDataAdapter(sqlquery, sqlcon);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public void ExcuteNonQuery(string sqlquery)
        {
            SqlCommand cmd = new SqlCommand(sqlquery, sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
