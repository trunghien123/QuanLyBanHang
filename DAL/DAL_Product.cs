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
    public class DAL_Product : DBConnect
    {
        //lấy hết danh sách sản phẩm
        public DataTable getAllProduct()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from product", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy sp khi có tìm kiếm
        public DataTable getProductWhenSearch(String search)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from product where id like '%" + search + "%' or product_name like '%" + search + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy sản phẩm với id
        public DataTable getProductWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from product where id= '" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //update sản phẩm
        public void updateSP(Product product)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update product set product_name=N'" + product.Product_Name + "', catalog_id='" + product.Catalog_ID + "', amount=" + product.Amount + ", price='" + product.Price + "' where id='" + product.ID + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }

        //xóa sản phẩm theo id
        public void deleteSPwithId(String id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from product where id='" + id + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        //Thêm sản phẩm
        public void addSP(Product product)
        {
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.InsertCommand = con.CreateCommand();
                da.InsertCommand.CommandText = "insert into product (id, product_name, catalog_id, amount, price) values ('" + product.ID + "', N'" + product.Product_Name + "', '" + product.Catalog_ID + "', " + product.Amount + ", '" + product.Price + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        //sửa số lượng sản phẩm theo id
        public void updateAmountSPWithId(String id, int soLuong)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update product set  amount=" + soLuong + " where id='" + id + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
