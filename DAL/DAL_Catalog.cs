using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Catalog : DBConnect
    {
        //lấy hết danh sách catalog
        public DataTable getAllCatalog()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from catalog", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getAllCatalogById(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from catalog where id='" + id + "'", con);
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
