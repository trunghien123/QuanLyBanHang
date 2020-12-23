using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ProductDetail : DBConnect
    {
        //lấy sản phẩm theo id
        public DataTable getProductDetailWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from productdetail where product_id= '" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //sửa thông tin sản phẩm
        public void updateSPDetail(ProductDetail productDetail)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update productdetail set product_detail=N'" + productDetail.Product_Detail + "' where product_id='" + productDetail.Product_Id + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }

        //xóa thông tin sản phẩm
        public void deleteSPDetailwithId(String id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from productdetail where product_id='" + id + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        //thêm thông tin sản phẩm
        public void addSPDetail(ProductDetail productDetail)
        {
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.InsertCommand = con.CreateCommand();
                da.InsertCommand.CommandText = "insert into productdetail (product_id, product_detail) values ('" + productDetail.Product_Id + "', N'" + productDetail.Product_Detail + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
