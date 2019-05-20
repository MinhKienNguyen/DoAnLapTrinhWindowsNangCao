using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class NguoiDungNhomNgDungModel
    {
        NguoiDungNhomNgDungControllers _nguoiDungNhomNgDungControllers = new NguoiDungNhomNgDungControllers();

        /// <summary>
        /// GetNhomND -- Load lưới bên trái
        /// </summary>
        /// <returns></returns>
        public DataTable GetNhomND()
        {
            return _nguoiDungNhomNgDungControllers.GetNhomND();
        }

        /// <summary>
        /// GetNgDNhomND -- Load lưới bên phải
        /// </summary>
        /// <param name="maNhom"></param>
        /// <returns></returns>
        public DataTable GetNgDNhomND(string maNhom)
        {
            return _nguoiDungNhomNgDungControllers.GetNgDNhomND(maNhom);
        }

        /// <summary>
        /// thêm nhóm người dùng vào table người dùng nhóm người dùng
        /// </summary>
        /// <param name="maNhom"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable InsertNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.InsertNguoiDungNhomNgDung(maNhom, user);
        }

        /// <summary>
        /// cập nhật mã nhóm người dùng vào table nhân viên
        /// </summary>
        /// <param name="maNhom"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable UpdateMaNhomInNV(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.UpdateNhomNDInNV(maNhom, user);
        }

        public DataTable DeleteNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.DeleteNguoiDungNhomNgDung(maNhom, user);
        }

        public DataTable UpdateMaNhomWhenDel(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.UpdateMaNhomWhenDel(maNhom, user);
        }

        /// <summary>
        /// lấy má nhóm người dùng để truyền vào phân quyền
        /// </summary>
        /// <param name="pTenDangNhap"></param>
        /// <returns></returns>
        public DataTable GetMaNhomNguoiDung(string pTenDangNhap)
        {
            return _nguoiDungNhomNgDungControllers.GetMaNhomNguoiDung(pTenDangNhap.ToString());
        }
    }
}
