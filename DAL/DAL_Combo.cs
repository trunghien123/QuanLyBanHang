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
                double discountMoneyInt = Int32.Parse(combo.ToTalMoney) - (Int32.Parse(combo.ToTalMoney) * Int32.Parse(combo.Discount)) / 100;
                string discountMoney = discountMoneyInt.ToString();
                da.InsertCommand.CommandText = "insert into combo (id, combo_name, product_list, startDate, endDate, totalMoney, discount, discountMoney) values ('" + combo.ID + "', N'" + combo.Combo_Name + "', '" + combo.Product_List + "', '" + combo.StartDate + "', '" + combo.EndDate + "', '" + combo.ToTalMoney + "', '" + combo.Discount + "', '" + discountMoney + "')";
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
        }
        //Update Combo
        public void updateCombo(Combo combo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = con.CreateCommand();
            double discountMoneyInt = Int32.Parse(combo.ToTalMoney) - (Int32.Parse(combo.ToTalMoney) * Int32.Parse(combo.Discount)) / 100;
            string discountMoney = discountMoneyInt.ToString();
            da.UpdateCommand.CommandText = "update combo set Combo_Name=N'" + combo.Combo_Name + "', product_list='" + combo.Product_List + "', startDate='" + combo.StartDate + "', endDate='" + combo.EndDate + "', totalMoney='" + combo.ToTalMoney + "', discount='" + combo.Discount + "', discountMoney='" + discountMoney + "' where id='" + combo.ID + "'";
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
        //Delete
        public void deleteCombowithId(String id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandText = "delete from Combo where id='" + id + "'";
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
