using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class HangHoaModel
    {
        HangHoaControllers _hangHoaControllers = new HangHoaControllers();
        public DataTable GetDataProduct(string _maHang, string _tenHang)
        {
            return _hangHoaControllers.GetProduct(_maHang.ToString(), _tenHang.ToString());
        }
        public DataTable GetImage(string EmployessCde)
        {
            return _hangHoaControllers.GetImage(EmployessCde.ToString());
        }

        public DataTable InsertEmployess( byte[] Image)
        {
            return _hangHoaControllers.InsertEmployess(Image);
        }
    }
}
