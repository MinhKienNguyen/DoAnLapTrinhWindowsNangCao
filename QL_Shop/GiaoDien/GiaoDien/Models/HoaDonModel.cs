using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class HoaDonModel
    {
        HoaDonContronllers _hoaDonContronllers = new HoaDonContronllers();
        public DataTable GetHoaDon(string _maHD, DateTime _tuNgay, DateTime _denNgay)
        {
            return _hoaDonContronllers.GetHoaDon(_maHD.ToString(), Convert.ToDateTime(_tuNgay), Convert.ToDateTime(_denNgay));
        }
    }
}
