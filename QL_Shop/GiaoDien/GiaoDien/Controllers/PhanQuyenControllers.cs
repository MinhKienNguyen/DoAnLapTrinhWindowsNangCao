using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class PhanQuyenControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDataNhomMangHinh(string maNhom)
        {
            return _unity.filldb("QL_PhanQuyen_GetData", maNhom.ToString());
        }

        public DataTable GetDataNhomND()
        {
            return _unity.filldb("QL_NhomNguoiDung_GetData");
        }

        /// <summary>
        /// lấy mã màng hình phân quyền
        /// </summary>
        /// <param name="pMaNhom"></param>
        /// <returns></returns>
        public DataTable GetDataManHinh(string pMaNhom)
        {
            DataTable dt = new DataTable();
            dt = _unity.filldb("QL_PhanQuyen_GetMaNhomNgDung", pMaNhom.ToString());
            return dt;
        }

        public DataTable UpdatePhanQuyen(string pMaNhom, string pMaMH)
        {
            DataTable dt = new DataTable();
            dt = _unity.filldb("QL_PhanQuyen_InsertOrUpdate", pMaNhom.ToString(), pMaMH.ToString());
            return dt;
        }
    }
}
