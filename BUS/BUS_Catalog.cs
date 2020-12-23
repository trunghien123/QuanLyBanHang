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
    public class BUS_Catalog
    {
        DAL_Catalog catalog = new DAL_Catalog();

        public List<Catalog> getAllCatalog()
        {
            List<Catalog> catalogsList = new List<Catalog>();

            DataTable dt = catalog.getAllCatalog();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Catalog catalogDTO = new Catalog();
                catalogDTO.ID = (String)dt.Rows[i]["id"];
                catalogDTO.Catalog_Name = (String)dt.Rows[i]["catalog_Name"];

                catalogsList.Add(catalogDTO);
            }

            return catalogsList;
        }
    }
}
