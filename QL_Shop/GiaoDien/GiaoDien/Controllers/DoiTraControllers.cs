using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class DoiTraControllers
    {
        private UnityClass _unity = new UnityClass();

        public DataTable GetDataBill(string _maHD)
        {
            return _unity.filldb("PH_HoaDon_GetData", _maHD);
        }
    }
}
