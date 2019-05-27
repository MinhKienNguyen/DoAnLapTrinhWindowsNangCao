using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
   
    public class BanHangModel
    {
        BanHangControllers _banHangControllers = new BanHangControllers();
        public DataTable GetDataProduct()
        {
            return _banHangControllers.GetDataProduct();
        }

        /// <summary>
        /// tăng mã hóa đơn
        /// </summary>
        /// <param name="productcode"></param>
        /// <returns></returns>
        public DataTable Getsell(string productcode)
        {
            return _banHangControllers.Getsell(productcode.ToString());
        }

        public bool UpdateChietKhau(string _barCdeKH)
        {
            return _banHangControllers.UpdateChietKhau(_barCdeKH);
        }

        /// <summary>
        /// tăng mã CT_Hóa đơn
        /// </summary>
        /// <param name="_maCTHD"></param>
        /// <returns></returns>
        public DataTable TangMaCTHD(string _maCTHD)
        {
            return _banHangControllers.TangMa(_maCTHD.ToString());
        }

        public bool ThemHoaDon(string _maHD, string _maNV, string _maKH, int _trangThai, double _chietKhau, decimal _tongTien)
        {
            return _banHangControllers.ThemHoaDon(_maHD, _maNV, _maKH, _trangThai, _chietKhau, _tongTien);
        }

        public bool ThemCTHoaDon(string _maCTHD, string _maHD, string _maHH, string _barcode, int _soLuong, decimal _thanhTien)
        {
            return _banHangControllers.ThemCTHoaDon(_maCTHD, _maHD, _maHH, _barcode, _soLuong, _thanhTien);
        }

        public bool UpdateTichTienKH(string _barCdeKH, decimal tichTien)
        {
            return _banHangControllers.UpdateTichTienKH(_barCdeKH, tichTien);
        }

        public bool UpdateSoLuongBan(string _barcode, int _soLuong)
        {
            return _banHangControllers.UpdateSoLuongBan(_barcode, _soLuong);
        }

        public DataTable GetDataCustomers(string _barcode)
        {
            return _banHangControllers.GetDataCustomers(_barcode);
        }
    }
}
