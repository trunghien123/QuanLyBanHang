using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Product_Name;

        public String Product_Name
        {
            get { return _Product_Name; }
            set { _Product_Name = value; }
        }

        private String _Catalog_ID;

        public String Catalog_ID
        {
            get { return _Catalog_ID; }
            set { _Catalog_ID = value; }
        }

        private int _Amount;

        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        private String _Price;

        public String Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public Product(String id, String name, String catalogId, int amount, String price)
        {
            this._ID = id;
            this._Product_Name = name;
            this._Catalog_ID = catalogId;
            this._Amount = amount;
            this._Price = price;
        }

        public Product()
        {

        }

    }
}
