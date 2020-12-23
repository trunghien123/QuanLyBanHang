using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Customer
    {
        DAL_Customer customer = new DAL_Customer();

        //KT tồn tại khách hàng
        public bool ktTonTaiKhachHangTheoId(String id)
        {
            DataTable dt = customer.getCustomerWithId(id);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
