using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    class DoanhThuContronllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDoanhthu(DateTime _tuNgay, DateTime _denNgay)
        {
            return _unity.filldb("HH_HangHoa_GetDataDoanhThu",_tuNgay,_denNgay);
            
        }
    }
}
