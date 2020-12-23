using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Combo
    {
        private String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Combo_Name;

        public String Combo_Name
        {
            get { return _Combo_Name; }
            set { _Combo_Name = value; }
        }

        private String _Product_List;

        public String Product_List
        {
            get { return _Product_List; }
            set { _Product_List = value; }
        }

        private String _StartDate;

        public String StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        private String _EndDate;

        public String EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        private String _ToTalMoney;

        public String ToTalMoney
        {
            get { return _ToTalMoney; }
            set { _ToTalMoney = value; }
        }

        private String _Discount;

        public String Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        private String _DiscountMoney;

        public String DiscountMoney
        {
            get { return _DiscountMoney; }
            set { _DiscountMoney = value; }
        }

        public Combo(String id, String name, String productList, String startDate, String endDate, String totalMoney, String discount, String discountMoney)
        {
            this._ID = id;
            this._Combo_Name = name;
            this._Product_List = productList;
            this._StartDate = startDate;
            this._EndDate = endDate;
            this._ToTalMoney = totalMoney;
            this._Discount = discount;
            this._DiscountMoney = discountMoney;
        }

        public Combo()
        {

        }
    }
}
