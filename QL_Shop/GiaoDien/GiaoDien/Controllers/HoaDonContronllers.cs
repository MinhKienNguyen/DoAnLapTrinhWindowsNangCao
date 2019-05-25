using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
   public class HoaDonContronllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetHoaDon(string _maHD, DateTime _tuNgay, DateTime _denNgay)
        {
            return _unity.filldb("PH_HoaDon_Data", _maHD.ToString(), Convert.ToDateTime(_tuNgay), Convert.ToDateTime(_denNgay));
        }

    }
}
