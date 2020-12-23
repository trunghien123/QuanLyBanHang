using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InvoiceDetail
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Invoice_ID;

        public String Invoice_ID
        {
            get { return _Invoice_ID; }
            set { _Invoice_ID = value; }
        }

        private String _Product_ID;

        public String Product_ID
        {
            get { return _Product_ID; }
            set { _Product_ID = value; }
        }

        private String _Combo_ID;

        public String Combo_ID
        {
            get { return _Combo_ID; }
            set { _Combo_ID = value; }
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

        public InvoiceDetail(int id, String invoiceId, String productId, String comboId, int amount, String price)
        {
            this._ID = id;
            this._Invoice_ID = invoiceId;
            this._Product_ID = productId;
            this._Combo_ID = comboId;
            this._Amount = amount;
            this._Price = price;
        }

        public InvoiceDetail()
        {

        }
    }
}
