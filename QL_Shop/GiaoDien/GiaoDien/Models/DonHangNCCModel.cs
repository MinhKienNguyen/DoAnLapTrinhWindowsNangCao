using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class DonHangNCCModel
    {
        DonHangNCCControllers _donHangNCCControllers = new DonHangNCCControllers();
        public DataTable GetDonHangNCC(string _maDH, string _maNCC, DateTime _tuNgay, DateTime _denNgay)
        {
            return _donHangNCCControllers.GetDonHangNCC(_maDH.ToString(), _maNCC.ToString(), Convert.ToDateTime(_tuNgay), Convert.ToDateTime(_denNgay));
        }

        public DataTable GetComboNCC()
        {
            return _donHangNCCControllers.GetComboNCC();
        }
    }
}
