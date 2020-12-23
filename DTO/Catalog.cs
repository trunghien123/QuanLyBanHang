using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Catalog
    {
        private String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Catalog_Name;

        public String Catalog_Name
        {
            get { return _Catalog_Name; }
            set { _Catalog_Name = value; }
        }

        public Catalog(String id, String name)
        {
            this._ID = id;
            this._Catalog_Name = name;
        }

        public Catalog()
        {

        }
    }
}
