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
    public class DAL_InvoiceDetail : DBConnect
    {
        //Lấy danh sách chi tiết hóa đơn theo hóa đơn id
        public DataTable getAllInvoiceDetailWithInvoiceId (String hdId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from invoicedetail where invoice_id='" + hdId + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //Lấy chi tiết hóa đơn theo id
        public DataTable getInvoiceDetailWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from invoicedetail where id='" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //xóa các chi tiết hóa đơn theo hóa đơn id
        public void deleteInvoiceDetailWithInvoiceId(String invoiceId)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from invoicedetail where invoice_id='" + invoiceId + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        //thêm chi tiết hóa đơn
        public void addInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.InsertCommand = con.CreateCommand();
                da.InsertCommand.CommandText = "insert into invoicedetail (invoice_id, product_id, combo_id, amount, price) values ('" + invoiceDetail.Invoice_ID + "', '" + invoiceDetail.Product_ID + "', '" + invoiceDetail .Combo_ID + "', " + invoiceDetail .Amount + ", '" + invoiceDetail.Price + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        //xóa các chi tiết hóa đơn theo id
        public void deleteInvoiceDetailWithId(String id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from invoicedetail where id='" + id + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        //sửa chi tiết hóa đơn
        public void updateInvoiceDetailWithId(int id, int amount)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update invoicedetail set amount=" + amount + " where id=" + id;
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
