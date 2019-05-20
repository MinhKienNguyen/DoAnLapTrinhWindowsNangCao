using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class HangHoaControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetProduct(string _maHang, string _tenHang)
        {
            return _unity.filldb("HH_HangHoa_GetData", _maHang.ToString(), _tenHang.ToString());
        }
        public DataTable GetImage(string EmployessCde)
        {
            var result = _unity.filldb("HH_HangHoa_GetImage", EmployessCde.ToString());
            return result;
        }
        public DataTable InsertEmployess( byte[] Image)
        {
            return _unity.filldb("HH_HangHoa_InsertEmployess", Image);
        }
    }
}
