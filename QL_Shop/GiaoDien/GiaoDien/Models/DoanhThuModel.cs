using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
   public class DoanhThuModel
    {
        DoanhThuContronllers _doanhThuContronllers = new DoanhThuContronllers();
        public DataTable GetDoanhthu(DateTime _tuNgay, DateTime _denNgay)
        {
            return _doanhThuContronllers.GetDoanhthu(Convert.ToDateTime(_tuNgay),Convert.ToDateTime(_denNgay));

        }
    }
}
