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
    public class DAL_Combo : DBConnect
    {
        //lấy danh sách combo
        public DataTable getAllCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from combo", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //lấy combo theo id
        public DataTable getComboWithId(String id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from combo where id='" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //Thêm Combo
        public void addCombo(Combo combo)
        {
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.InsertCommand = con.CreateCommand();
                da.InsertCommand.CommandText = "insert into combo (id, combo_name, product_list, startDate, endDate, totalMoney, discount, discountMoney) values ('" + combo.ID + "', N'" + combo.Combo_Name + "', '" + combo.Product_List + "', " + combo.StartDate + ", '" + combo.EndDate + "', '" + combo.ToTalMoney + "', '" + combo.Discount + "', '" + combo.DiscountMoney + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
