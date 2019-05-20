using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class DonHangNCCControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDonHangNCC(string _maDH, string _maNCC, DateTime _tuNgay, DateTime _denNgay)
        {
            return _unity.filldb("PH_PhieuDatHang_GetDonHangNCC",_maDH.ToString(), _maNCC.ToString(),Convert.ToDateTime(_tuNgay), Convert.ToDateTime(_denNgay));
        }

        public DataTable GetComboNCC()
        {
            return _unity.filldb("HH_NhaCungCap_GetComboboxNCC");
        }
    }
}
