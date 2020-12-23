using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Invoice
    {
        DAL_Invoice invoice = new DAL_Invoice();

        //get hóa đơn
        public List<Invoice> getInvoice(String search)
        {
            List<Invoice> productsList = new List<Invoice>();

            if (search.Equals(""))
            {
                DataTable dt = invoice.getAllInvoice();//lấy sp từ db

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Invoice invoiceDTO = new Invoice();
                    invoiceDTO.ID = (String)dt.Rows[i]["id"];
                    invoiceDTO.Invoice_Name = (String)dt.Rows[i]["invoice_Name"];
                    invoiceDTO.Customer_ID = (String)dt.Rows[i]["customer_id"];
                    invoiceDTO.Shipper_ID = (String)dt.Rows[i]["shipper_id"];
                    invoiceDTO.TotalMoney = (String)dt.Rows[i]["totalmoney"];
                    invoiceDTO.CreatedDate = (String)dt.Rows[i]["CreatedDate"];
                    invoiceDTO.CustomerAddress = (String)dt.Rows[i]["CustomerAddress"];
                    invoiceDTO.ShipDate = (String)dt.Rows[i]["ShipDate"];
                    productsList.Add(invoiceDTO);
                }
            }
            else
            {
                DataTable dt = invoice.getInvoiceWhenSearch(search);//lấy sp từ db

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Invoice invoiceDTO = new Invoice();
                    invoiceDTO.ID = (String)dt.Rows[i]["id"];
                    invoiceDTO.Invoice_Name = (String)dt.Rows[i]["invoice_Name"];
                    invoiceDTO.Customer_ID = (String)dt.Rows[i]["customer_id"];
                    invoiceDTO.Shipper_ID = (String)dt.Rows[i]["shipper_id"];
                    invoiceDTO.TotalMoney = (String)dt.Rows[i]["totalmoney"];
                    invoiceDTO.CreatedDate = (String)dt.Rows[i]["CreatedDate"];
                    invoiceDTO.CustomerAddress = (String)dt.Rows[i]["CustomerAddress"];
                    invoiceDTO.ShipDate = (String)dt.Rows[i]["ShipDate"];
                    productsList.Add(invoiceDTO);
                }
            }

            return productsList;
        }

        //KT tồn tại id của hóa đơn
        public bool ktTonTaiHoaDonId(String id)
        {
            DataTable dt = invoice.getInvoiceWithId(id);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //thêm hóa đơn
        public void addHoaDon(Invoice invoiceDTO)
        {
            invoice.addInvoice(invoiceDTO);
        }

        //sửa hóa đơn
        public void updateInvoice(Invoice invoiceDTO)
        {
            invoice.updateInvoice(invoiceDTO);
        }

        //xóa hóa đơn theo id
        public void deleteHoaDonTheoId(String id)
        {
            invoice.deleteInvoiceWithId(id);
        }

        //update tồng tiền hóa đơn
        public void updateTongTien(String id, String money)
        {
            invoice.updateTotalMoneyInvoice(id, money);
        }

        //lấy tổng số tiền hiện tại
        public int getTongTien(String id)
        {
            DataTable dt = invoice.getInvoiceWithId(id);

            int soTienHienTai = int.Parse((String)dt.Rows[0]["totalmoney"]);

            return soTienHienTai;
        }
    }
}
