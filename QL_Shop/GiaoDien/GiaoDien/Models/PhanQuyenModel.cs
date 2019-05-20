using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class PhanQuyenModel
    {
        PhanQuyenControllers _phanQuyenControllers = new PhanQuyenControllers();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNhom"></param>
        /// <returns></returns>
        public DataTable GetDataNhomMangHinh(string maNhom)
        {
            return _phanQuyenControllers.GetDataNhomMangHinh(maNhom.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataNhomND()
        {
            return _phanQuyenControllers.GetDataNhomND();
        }

        /// <summary>
        /// lấy mã màng hình phân quyền
        /// </summary>
        /// <param name="pMaNhom"></param>
        /// <returns></returns>
        public DataTable GetDataManHinh(string pMaNhom)
        {
            return _phanQuyenControllers.GetDataManHinh(pMaNhom.ToString());
        }

        /// <summary>
        /// UpdatePhanQuyen -- update quyền
        /// </summary>
        /// <param name="pMaNhom"></param>
        /// <param name="pMaMH"></param>
        /// <returns></returns>
        public DataTable UpdatePhanQuyen(string pMaNhom, string pMaMH)
        {
            return _phanQuyenControllers.UpdatePhanQuyen(pMaNhom.ToString(), pMaMH.ToString());
        }
    }
}
