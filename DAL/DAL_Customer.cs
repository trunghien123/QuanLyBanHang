using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer : DBConnect
    {
        //lấy khách hàng theo id
        public DataTable getCustomerWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from customer where id= '" + id + "'", con);
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
