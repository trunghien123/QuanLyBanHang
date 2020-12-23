using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Invoice
    {
        private String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Invoice_Name;

        public String Invoice_Name
        {
            get { return _Invoice_Name; }
            set { _Invoice_Name = value; }
        }

        private String _Customer_ID;

        public String Customer_ID
        {
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }

        private String _Shipper_ID;

        public String Shipper_ID
        {
            get { return _Shipper_ID; }
            set { _Shipper_ID = value; }
        }

        private String _TotalMoney;

        public String TotalMoney
        {
            get { return _TotalMoney; }
            set { _TotalMoney = value; }
        }

        private String _CreatedDate;

        public String CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        private String _CustomerAddress;

        public String CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }

        private String _ShipDate;

        public String ShipDate
        {
            get { return _ShipDate; }
            set { _ShipDate = value; }
        }

        public Invoice(String id, String name, String customerId, String shipperId, String totalMoney, String createdDate, String customerAddress, String shipDate)
        {
            this._ID = id;
            this._Invoice_Name = name;
            this._Customer_ID = customerId;
            this._Shipper_ID = shipperId;
            this._TotalMoney = totalMoney;
            this._CreatedDate = createdDate;
            this._CustomerAddress = customerAddress;
            this._ShipDate = shipDate;
        }

        public Invoice()
        {

        }
    }
}
