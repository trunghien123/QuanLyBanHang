using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Employee
    {
        DAL_Employee employee = new DAL_Employee();

        //KT tồn tại nhân viên
        public bool ktTonTaiShipperTheoId(String id)
        {
            DataTable dt = employee.getShipEmployeeWithId(id);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
