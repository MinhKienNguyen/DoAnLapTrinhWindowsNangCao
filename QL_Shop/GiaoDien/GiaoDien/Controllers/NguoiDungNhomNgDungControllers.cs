using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{

    public class NguoiDungNhomNgDungControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetNhomND()
        {
            return _unity.filldb("QL_TaiKhoan_GetData");
        }

        public DataTable GetNgDNhomND(string maNhom)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_GetData", maNhom.ToString());
        }

        public DataTable InsertNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_InsertOrUpdate", maNhom.ToString(), user.ToString());
        }

        public DataTable UpdateNhomNDInNV(string maNhom, string user)
        {
            return _unity.filldb("HT_NhanVien_UpdatePhanQuyen", maNhom.ToString(), user.ToString());
        }

        /// <summary>
        /// Xóa mã nhóm trog ng dùng nhóm người dùng
        /// </summary>
        /// <param name="maNhom"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable DeleteNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_Delete", maNhom.ToString(), user.ToString());
        }

        /// <summary>
        /// cập nhật lại mã nhóm người dùng khi xóa người dug nhóm ng dùng
        /// </summary>
        /// <param name="maNhom"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable UpdateMaNhomWhenDel(string maNhom, string user)
        {
            DataTable dt = _unity.filldb("HT_NhanVien_UpdateMaNhomWhenDelete", maNhom.ToString(), user.ToString());
            return dt;
        }

        /// <summary>
        /// lấy má nhóm người dùng để truyền vào phân quyền
        /// </summary>
        /// <param name="pTenDangNhap"></param>
        /// <returns></returns>
        public DataTable GetMaNhomNguoiDung(string pTenDangNhap)
        {
            DataTable dt = _unity.filldb("QL_NguoiDungNhomNguoiDung_GetMaNhomNgDung", pTenDangNhap.ToString());
            return dt;
        }
        
    }
}
