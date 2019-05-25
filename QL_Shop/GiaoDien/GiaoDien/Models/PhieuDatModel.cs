using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
   public class PhieuDatModel
    {
        PhieuDatControllers _phieuDatControllers = new PhieuDatControllers();
        public DataTable GetKhoHang()
        {
            return _phieuDatControllers.GetKhoHang();
        }
    }
}
