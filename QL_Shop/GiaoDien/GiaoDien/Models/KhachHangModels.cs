using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class KhachHangModels
    {
        KhachHangContronllers _khachHangContronllass = new KhachHangContronllers();
        /// <summary>
        /// tìm kiếm dữ liệu theo tên
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName,string EmployessMa)
        {
            return _khachHangContronllass.GetEmployees(EmployessName, EmployessMa);
        }
        /// <summary>
        /// GetEmployessCde -- lấy mã khách hàng để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _khachHangContronllass.GetEmployessCde(EmployessCde.ToString());
        }
        public DataTable InsertEmployess( string ma, string mathe, string ten, string diachi,string sdt)
        {
            return _khachHangContronllass.InsertEmployess(ma, mathe, ten, diachi, sdt);
        }
        public bool DeleteEmployess(string ma)
        {
            return _khachHangContronllass.DeleteEmployess(ma.ToString());
        }
    }
}
