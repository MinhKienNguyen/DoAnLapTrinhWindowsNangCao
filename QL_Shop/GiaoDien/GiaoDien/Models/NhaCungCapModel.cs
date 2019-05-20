using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
   public class NhaCungCapModel
    {
        NhaCungCapControllers ncc = new NhaCungCapControllers();
        /// <summary>
        /// tìm kiếm dữ liệu theo tên
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return ncc.GetEmployees(EmployessName);
        }
        /// <summary>
        /// GetEmployessCde -- lấy mã NCC để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return ncc.GetEmployessCde(EmployessCde.ToString());
        }
        public DataTable InsertEmployess(string ma, string ten, string diachi, string sdt)
        {
            return ncc.InsertEmployess(ma, ten, diachi, sdt);
        }
        public bool DeleteEmployess(string ma)
        {
            return ncc.DeleteEmployess(ma.ToString());
        }
    }
}
