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
    public class BUS_Product
    {
        DAL_Product product = new DAL_Product();
        DAL_Catalog catalog = new DAL_Catalog();

        //get sp
        public List<Product> getProduct(String search)
        {
            List<Product> productsList = new List<Product>();

            if (search.Equals(""))
            {
                DataTable dt = product.getAllProduct();//lấy sp từ db

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product productDTO = new Product();
                    productDTO.ID = (String)dt.Rows[i]["id"];
                    productDTO.Product_Name = (String)dt.Rows[i]["Product_Name"];
                    DataTable dtCatalog = catalog.getAllCatalogById((String)dt.Rows[i]["Catalog_ID"]);
                    productDTO.Catalog_ID = (String)dt.Rows[i]["Catalog_ID"] + "(" + (String)dtCatalog.Rows[0]["catalog_name"] + ")";
                    productDTO.Amount = (int)dt.Rows[i]["Amount"];
                    productDTO.Price = (String)dt.Rows[i]["Price"];
                    productsList.Add(productDTO);
                }
            }
            else
            {
                DataTable dt = product.getProductWhenSearch(search);//lấy sp từ db

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product productDTO = new Product();
                    productDTO.ID = (String)dt.Rows[i]["id"];
                    productDTO.Product_Name = (String)dt.Rows[i]["Product_Name"];
                    DataTable dtCatalog = catalog.getAllCatalogById((String)dt.Rows[i]["Catalog_ID"]);
                    productDTO.Catalog_ID = (String)dt.Rows[i]["Catalog_ID"] + "(" + (String)dtCatalog.Rows[0]["catalog_name"] + ")";
                    productDTO.Amount = (int)dt.Rows[i]["Amount"];
                    productDTO.Price = (String)dt.Rows[i]["Price"];
                    productsList.Add(productDTO);
                }
            }

            return productsList;
        }

        //sửa sản phẩm
        public void updateSP(Product productDTO)
        {
            product.updateSP(productDTO);
        }

        //xóa sản phẩm theo id
        public void deleteSP(String id)
        {
            product.deleteSPwithId(id);
        }
        //lay ten tat ca san pham
        public String getAllProductName()
        {
            String productName = "";
            DataTable dt = product.getAllProduct();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                productName = productName + (String)dt.Rows[i]["Product_Name"] + ";";
            }
            return productName;
        }
        //lay product id theo product name
        public String getProductIdWithName(String productName)
        {
            String productID = "";
            DataTable dt = product.getProductWithName(productName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                productID = (String)dt.Rows[i]["ID"];
            }
            return productID;
        }

        //thêm sản phẩm
        public void addSP(Product productDTO)
        {
            product.addSP(productDTO);
        }

        //Kiểm tra ID sản phẩm có tồn tại không
        public bool ktTonTaiId(String id)
        {
            DataTable dt = product.getProductWithId(id);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //lấy số lượng sản phẩm hiện tại
        public int getSoLuongSP(String id)
        {
            DataTable dt = product.getProductWithId(id);

            int soLuongHienTai = (int)dt.Rows[0]["Amount"];

            return soLuongHienTai;
        }

        //kiểm tra số lượng tồn trong kho
        public bool ktSoLuongSPTheoId(String id, int soLuong)
        {
            int soLuongHienTai = getSoLuongSP(id);

            if (soLuong <= soLuongHienTai && soLuongHienTai != 0 && soLuong != 0)
            {
                return true;
            }
            return false;
        }

        //sửa số lượng sản phẩm sau khi thêm chi tiết hóa đơn
        public void updateSoLuongSP(String id, int soLuong)
        {
            product.updateAmountSPWithId(id, soLuong);
        }
    }
}
