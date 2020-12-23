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
    public class BUS_ProductDetail
    {
        DAL_ProductDetail productDetailt = new DAL_ProductDetail();

        //lấy thông tin sản phẩm
        public ProductDetail getProductDetail(String id)
        {
            ProductDetail ProductDetailDTO = new ProductDetail();

            DataTable dt = productDetailt.getProductDetailWithId(id);
            ProductDetailDTO.Product_Id = (String)dt.Rows[0]["Product_Id"];
            ProductDetailDTO.Product_Detail = (String)dt.Rows[0]["Product_Detail"];

            return ProductDetailDTO;
        }

        //sửa thông tin sản phẩm
        public void updateSPDetail(ProductDetail productDetailDTO)
        {
            productDetailt.updateSPDetail(productDetailDTO);
        }

        //xóa thông tin sả phẩm
        public void deleteSPDetail(String id)
        {
            productDetailt.deleteSPDetailwithId(id);
        }

        //thêm thông tin sản phảm
        public void addSPDetail(ProductDetail productDetailDTO)
        {
            productDetailt.addSPDetail(productDetailDTO);
        }
    }
}
