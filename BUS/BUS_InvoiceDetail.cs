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
    public class BUS_InvoiceDetail
    {
        DAL_InvoiceDetail invoiceDetail = new DAL_InvoiceDetail();

        //get ds chi tiết hóa đơn
        public List<InvoiceDetail> getInvoiceDetail(String hdId)
        {
            List<InvoiceDetail> invoiceDetailList = new List<InvoiceDetail>();

            DataTable dt = invoiceDetail.getAllInvoiceDetailWithInvoiceId(hdId);//lấy chi tiết hóa đơn từ db

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                InvoiceDetail invoiceDetailtDTO = new InvoiceDetail();
                invoiceDetailtDTO.ID = (int)dt.Rows[i]["id"];
                invoiceDetailtDTO.Invoice_ID = (String)dt.Rows[i]["invoice_id"];
                invoiceDetailtDTO.Product_ID = (String)dt.Rows[i]["Product_id"];
                invoiceDetailtDTO.Combo_ID = (String)dt.Rows[i]["Combo_ID"];
                invoiceDetailtDTO.Amount = (int)dt.Rows[i]["amount"];
                invoiceDetailtDTO.Price = (String)dt.Rows[i]["Price"];

                invoiceDetailList.Add(invoiceDetailtDTO);
            }

            return invoiceDetailList;
        }

        //get chi tiết hóa đơn theo id
        public InvoiceDetail getInvoiceDetailWithId(String id)
        {
            DataTable dt = invoiceDetail.getInvoiceDetailWithId(id);

            InvoiceDetail invoiceDetailtDTO = new InvoiceDetail();
            invoiceDetailtDTO.ID = (int)dt.Rows[0]["id"];
            invoiceDetailtDTO.Invoice_ID = (String)dt.Rows[0]["invoice_id"];
            invoiceDetailtDTO.Product_ID = (String)dt.Rows[0]["Product_id"];
            invoiceDetailtDTO.Combo_ID = (String)dt.Rows[0]["Combo_ID"];
            invoiceDetailtDTO.Amount = (int)dt.Rows[0]["amount"];
            invoiceDetailtDTO.Price = (String)dt.Rows[0]["Price"];

            return invoiceDetailtDTO;
        }

        //xóa chi tiết hóa đơn theo hóa đơn id
        public void deleteChiTietHDTheoHDId(String invoiceId)
        {
            invoiceDetail.deleteInvoiceDetailWithInvoiceId(invoiceId);
        }

        //thêm chi tiết hóa
        public void addChiTietHD(InvoiceDetail invoiceDetailDTO)
        {
            invoiceDetail.addInvoiceDetail(invoiceDetailDTO);
        }

        //xóa chi tiết hóa đơn theo id
        public void deleteChiTietHDTheoId(String id)
        {
            invoiceDetail.deleteInvoiceDetailWithId(id);
        }

        //sừa chi tiết hóa đơn
        public void updateChiTietHDTheoId(int id, int soLuong)
        {
            invoiceDetail.updateInvoiceDetailWithId(id, soLuong);
        }
    }
}
