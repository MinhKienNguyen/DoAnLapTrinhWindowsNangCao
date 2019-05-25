using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class PhieuDatControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetKhoHang()
        {
            return _unity.filldb("HH_HangHoa_GetDataDatHang");
        }
    }
}
