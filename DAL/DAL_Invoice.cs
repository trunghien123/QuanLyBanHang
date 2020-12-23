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
    public class DAL_Invoice : DBConnect
    {
        //lấy hết hóa đơn
        public DataTable getAllInvoice()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from invoice", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy hóa đơn theo tìm kiếm
        public DataTable getInvoiceWhenSearch(String search)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from invoice where id like '%" + search + "%' or invoice_name like '%" + search + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy hóa đơn theo id
        public DataTable getInvoiceWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from invoice where id= '" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //thêm hóa đơn
        public void addInvoice(Invoice invoice)
        {
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.InsertCommand = con.CreateCommand();
                da.InsertCommand.CommandText = "insert into invoice (id, invoice_name, customer_id, shipper_id, totalmoney, createdDate, customeraddress, shipdate) values ('" + invoice.ID + "', N'" + invoice.Invoice_Name + "', '" + invoice.Customer_ID + "', '" + invoice.Shipper_ID + "', '" + invoice.TotalMoney + "', '" + invoice.CreatedDate + "', '" + invoice.CustomerAddress + "', '" + invoice.ShipDate + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        //update hóa đơn
        public void updateInvoice(Invoice invoice)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update invoice set invoice_name=N'" + invoice.Invoice_Name + "', customer_id='" + invoice.Customer_ID + "', shipper_id='" + invoice.Shipper_ID + "', totalmoney='" + invoice.TotalMoney + "', createddate='" + invoice.CreatedDate + "', customeraddress='" + invoice.CustomerAddress + "', shipdate='" + invoice.ShipDate + "' where id='" + invoice.ID + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }

        //xóa hóa đơn theo id
        public void deleteInvoiceWithId(String id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from invoice where id='" + id + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        //update tổng tiền hóa đơn
        public void updateTotalMoneyInvoice(String id, String money)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandText = "update invoice set totalmoney='" + money + "' where id='" + id + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
