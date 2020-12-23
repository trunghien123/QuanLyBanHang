using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Employee : DBConnect
    {
        //lấy nhân viên bán hàng
        public DataTable getSaleEmployeeWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where id= '" + id + "' and role_id='Role_2'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy shipper
        public DataTable getShipEmployeeWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where id= '" + id + "' and role_id='Role_3'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
