using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
   public class PhieuDatModel
    {
        PhieuDatControllers _phieuDatControllers = new PhieuDatControllers();
        public DataTable GetKhoHang()
        {
            return _phieuDatControllers.GetKhoHang();
        }

        public DataTable GetLookupMau()
        {
            return _phieuDatControllers.GetLookupMau();
        }

        public DataTable GetLookupSize()
        {
            return _phieuDatControllers.GetLookupSize();
        }

        public DataTable GetLkDVT()
        {
            return _phieuDatControllers.GetLkDVT();
        }

        /// <summary>
        /// mã hàng hóa mới tăng
        /// </summary>
        /// <param name="_maHH"></param>
        /// <returns></returns>
        public DataTable MaHangHoaTag(string _maHH)
        {
            return _phieuDatControllers.MaHangHoaTag(_maHH);
        }

        public DataTable DatHangNCC_MaTang(string _maPD)
        {
            return _phieuDatControllers.DatHangNCC_MaTang(_maPD);
        }

        public DataTable CTDatHangNCC_MaTang(string _maCTPD)
        {
            return _phieuDatControllers.CTDatHangNCC_MaTang(_maCTPD);
        }

        /// <summary>
        /// thêm sản phẩm mới để đặt hàng
        /// </summary>
        /// <param name="_maHH"></param>
        /// <param name="_tenHH"></param>
        /// <param name="_loaiHH"></param>
        /// <param name="_mau"></param>
        /// <param name="_Size"></param>
        /// <param name="_barcode"></param>
        /// <param name="_maCTHH"></param>
        /// <param name="_donvi"></param>
        /// <returns></returns>
        public bool InsertProduct(string _maHH, string _tenHH, string _loaiHH, string _mau, string _Size, string _barcode, string _maCTHH, string _donvi)
        {
            return _phieuDatControllers.InsertProduct(_maHH, _tenHH, _loaiHH, _mau, _Size, _barcode, _maCTHH, _donvi);
        }

        /// <summary>
        /// thêm vào phiếu đặt hàng NCC
        /// </summary>
        /// <param name="_maPD"></param>
        /// <param name="_maNV"></param>
        /// <param name="_maCTPD"></param>
        /// <param name="_maLoaiHang"></param>
        /// <param name="_maHH"></param>
        /// <param name="_tenHH"></param>
        /// <param name="_mau"></param>
        /// <param name="_size"></param>
        /// <param name="_donvi"></param>
        /// <param name="_soLuong"></param>
        /// <returns></returns>
        public bool ThemPhieuDatNCC(string _maPD, string _maNV, string _maNCC)
        {
            return _phieuDatControllers.ThemPhieuDatNCC(_maPD, _maNV, _maNCC);
        }

        /// <summary>
        /// thêm chi tiết phiếu đặt NCC
        /// </summary>
        /// <param name="_maPD"></param>
        /// <param name="_maCTPD"></param>
        /// <param name="_maLoaiHang"></param>
        /// <param name="_maHH"></param>
        /// <param name="_tenHH"></param>
        /// <param name="_mau"></param>
        /// <param name="_size"></param>
        /// <param name="_donvi"></param>
        /// <param name="_soLuong"></param>
        /// <returns></returns>
        public bool ThemCTPhieuDatNCC(string _maPD, string _maCTPD, string _maLoaiHang, string _maHH, string _tenHH, string _mau, string _size, string _donvi, int _soLuong)
        {
            return _phieuDatControllers.ThemCTPhieuDatNCC(_maPD, _maCTPD, _maLoaiHang, _maHH, _tenHH, _mau, _size, _donvi, _soLuong);
        }

    }
}
