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
    public class BUS_Combo
    {
        DAL_Combo combo = new DAL_Combo();
        DAL_Product product = new DAL_Product();

        //lấy danh sách combo
        public List<Combo> getAllCombo()
        {
            List<Combo> comboList = new List<Combo>();

            DataTable dt = combo.getAllCombo();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Combo comboDTO = new Combo();

                comboDTO.ID = (String)dt.Rows[i]["id"];
                comboDTO.Combo_Name = (String)dt.Rows[i]["combo_name"];
                comboDTO.Product_List = (String)dt.Rows[i]["product_list"];
                comboDTO.StartDate = (String)dt.Rows[i]["startdate"];
                comboDTO.EndDate = (String)dt.Rows[i]["enddate"];
                comboDTO.ToTalMoney = (String)dt.Rows[i]["totalmoney"];
                comboDTO.Discount = (String)dt.Rows[i]["discount"];
                comboDTO.DiscountMoney = (String)dt.Rows[i]["discountmoney"];

                comboList.Add(comboDTO);
            }

            return comboList;
        }

        //kiểm tra sản phẩm có trong combo hay không
        public bool ktSPTrongCombo(String id)
        {
            List<Combo> comboList = getAllCombo();

            for(int i = 0; i < comboList.Count; i++)
            {
                String[] productIdArray = comboList[i].Product_List.Split(';');

                for(int j = 0; j < productIdArray.Length; j++)
                {
                    if(productIdArray[j].Equals(id))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //lấy danh sách sản phẩm của combo
        public String getProductList(String id)
        {
            DataTable dt = combo.getComboWithId(id);
            String listProductName = "";

            String ProductId =  (String)dt.Rows[0]["product_list"];
            String[] listProductId = ProductId.Split(';');
            
            for(int i = 0;i < listProductId.Length - 1; i++)
            {
                DataTable listProduct = product.getProductWithId(listProductId[i]);
                listProductName = listProductName + (String)listProduct.Rows[0]["product_name"] + ";";
            }
            return listProductName;
        }

        //lấy giá combo theo id
        public String getPriceWithId(String id)
        {
            DataTable dt = combo.getComboWithId(id);

            return (String)dt.Rows[0]["discountmoney"];
        }

        //thêm combo
        public void addCombo(Combo comboDTO)
        {
            combo.addCombo(comboDTO);
        }

        //sửa sản phẩm
        public void updateCombo(Combo comboDTO)
        {
            combo.updateCombo(comboDTO);
        }

        //xóa sản phẩm theo id
        public void deleteCombo(String id)
        {
            combo.deleteCombowithId(id);
        }
    }
}
