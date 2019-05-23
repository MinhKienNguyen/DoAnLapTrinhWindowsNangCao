using GiaoDien.Unity;
using System;
using System.Data;

namespace GiaoDien.Controllers
{
    public class BanHangControllers
    {
        UnityClass _unity = new UnityClass();

        /// <summary>
        /// lấy tất cả các dữ liệu trong sản phẩm
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataProduct()
        {
            return _unity.filldb("HH_HangHoa_Bill");
        }

        /// <summary>
        /// tăng mã hóa đơn
        /// </summary>
        /// <param name="productcode"></param>
        /// <returns></returns>
        public DataTable Getsell(string productcode)
        {
            return _unity.filldb("PH_HoaDon_Getsell", productcode.ToString());
        }

        /// <summary>
        /// tăng mã CT_Hóa đơn
        /// </summary>
        /// <param name="_maCTHoaDon"></param>
        /// <returns></returns>
        public DataTable TangMa(string _maCTHoaDon)
        {
            return _unity.filldb("PH_CT_HoaDon_MaTang", _maCTHoaDon.ToString());
        }

        /// <summary>
        /// thêm thông tin đơn hàng vào hóa đơn
        /// </summary>
        /// <param name="_maHD"></param>
        /// <param name="_maNV"></param>
        /// <param name="_maKH"></param>
        /// <param name="_ngayLap"></param>
        /// <param name="_trangThai"></param>
        /// <param name="_chietKhau"></param>
        /// <param name="_tongTien"></param>
        /// <returns></returns>
        public bool ThemHoaDon(string _maHD, string _maNV, string _maKH, int _trangThai, double _chietKhau, decimal _tongTien)
        {
            DataTable dtCheck = _unity.filldb("PH_HoaDon_InsertBill", _maHD, _maNV, _maKH, _trangThai, _chietKhau, _tongTien);
            if (dtCheck.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// thêm vào chi tiết hóa đơn
        /// </summary>
        /// <param name="_maCTHD"></param>
        /// <param name="_maHD"></param>
        /// <param name="_maHH"></param>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <param name="_thanhTien"></param>
        /// <returns></returns>
        public bool ThemCTHoaDon(string _maCTHD, string _maHD, string _maHH, string _barcode, int _soLuong, decimal _thanhTien)
        {
            DataTable dtCheck = _unity.filldb("PH_CT_HoaDon_InsertDetailBill", _maCTHD, _maHD, _maHH, _barcode, _soLuong, _thanhTien);
            if (dtCheck.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// update tiền tích lũy cho khách hàng là thành viên
        /// </summary>
        /// <param name="_maCTHD"></param>
        /// <param name="_maHD"></param>
        /// <param name="_maHH"></param>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <param name="_thanhTien"></param>
        /// <returns></returns>
        public bool UpdateTichTienKH(string _barCdeKH, decimal _tienTich)
        {
            DataTable dtCheck = _unity.filldb("KH_KhachHang_UpDateTichTien", _barCdeKH, _tienTich);
            if (dtCheck.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// cập nhật lại số lượng trong kho
        /// </summary>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <returns></returns>
        public bool UpdateSoLuongBan(string _barcode, int _soLuong)
        {
            DataTable dtCheck = _unity.filldb("HH_CT_HangHoa_UpdateSLBan", _barcode, _soLuong);
            if (dtCheck.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        public DataTable GetDataCustomers(string _barcode)
        {
            return _unity.filldb("KH_KhachHang_GetDataBarcode", _barcode);
        }
    }
}
