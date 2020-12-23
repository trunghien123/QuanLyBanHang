using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDetail
    {
        private String _Product_Id;

        public String Product_Id
        {
            get { return _Product_Id; }
            set { _Product_Id = value; }
        }

        private String _Product_Detail;

        public String Product_Detail
        {
            get { return _Product_Detail; }
            set { _Product_Detail = value; }
        }

        public ProductDetail(String id, String detail)
        {
            this._Product_Id = id;
            this.Product_Detail = detail;
        }

        public ProductDetail()
        {

        }
    }
}
