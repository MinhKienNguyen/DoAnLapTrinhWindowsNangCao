﻿using GiaoDien.Unity;
using System;
using System.Data;

namespace GiaoDien.Controllers
{
    public class DoiTraControllers
    {
        private UnityClass _unity = new UnityClass();

        public DataTable GetDataBill(string _maHD)
        {
            return _unity.filldb("PH_HoaDon_GetData", _maHD);
        }

        /// <summary>
        /// cập nhật số lượng hàng trong kho lên
        /// </summary>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <returns></returns>
        public bool UpdateSL_CTHH(string _barcode, int _soLuong)
        {
            DataTable dt = _unity.filldb("HH_CT_HangHoa_UpdateSLTraHang", _barcode, _soLuong);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// cập nhật lại số lượng sản phẩm trong kho xuống sau khi đã quét sô lượng đổi
        /// </summary>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <returns></returns>
        public bool UpdateSLHangQuet_Kho(string _barcode, int _soLuong)
        {
            DataTable dt = _unity.filldb("HH_CT_HangHoa_UpdateSLDoi", _barcode, _soLuong);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// cập nhật lại số lượng hàng trong CT hóa đơn xuống
        /// </summary>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <param name="_tienTra"></param>
        /// <returns></returns>
        public bool Update_CTHD(string _barcode, int _soLuong, float _thanhTien)
        {
            DataTable dt = _unity.filldb("PH_CT_HoaDon_UpdateTraHang", _barcode, _soLuong, _thanhTien);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// update lại chi tiết hóa đơn khi đã quét chọn hàng cần đổi
        /// </summary>
        /// <param name="_maCTietHDTra"></param>
        /// <param name="_maHDTra"></param>
        /// <param name="_maHH"></param>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <param name="_thanhTien"></param>
        /// <returns></returns>
        public bool Insert_CT_HDHangQuet(string _maCTietHDTra, string _maHDTra, string _maHH, string _barcode, int _soLuong, float _thanhTien)
        {
            DataTable dt = _unity.filldb("PH_CT_HoaDon_InsertOrUpdateTraHang", _maCTietHDTra, _maHDTra, _maHH, _barcode, _soLuong, _thanhTien);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// cập nhật trạng thái trong hóa đơn khi trả hàng
        /// </summary>
        /// <param name="_maHD"></param>
        /// <returns></returns>
        public bool Update_HD(string _maHD)
        {
            DataTable dt = _unity.filldb("PH_HoaDon_UpdateTraHang", _maHD);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// thêm hóa đơn đổi trả
        /// </summary>
        /// <param name="_maHDTra"></param>
        /// <param name="_maHD"></param>
        /// <param name="_maNV"></param>
        /// <param name="_tienTra"></param>
        /// <returns></returns>
        public bool Insert_HDTra(string _maHDTra,string _maHD, string _maNV, float _tienTra)
        {
            DataTable dt = _unity.filldb("PH_HoaDonDoiTra_Insert", _maHDTra, _maHD, _maNV, _tienTra);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// thêm vào chi tiết hóa đơn đổi trả
        /// </summary>
        /// <param name="_maCTietHDTra"></param>
        /// <param name="_maHDTra"></param>
        /// <param name="_maHH"></param>
        /// <param name="_barcode"></param>
        /// <param name="_soLuong"></param>
        /// <param name="_thanhTien"></param>
        /// <returns></returns>
        public bool Insert_CT_HDTra(string _maCTietHD, string _maHD, string _maHH, string _barcode, int _soLuong, float _thanhTien)
        {
            DataTable dt = _unity.filldb("PH_CT_HDDoiTra_InsertDetailBill", _maCTietHD, _maHD, _maHH, _barcode, _soLuong, _thanhTien);
            if (dt.Rows.Count <= 0 || Convert.ToInt16(dt.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// tăng mã hóa đơn đổi trả tự động
        /// </summary>
        /// <param name="_maHDTra"></param>
        /// <returns></returns>
        public DataTable TangMaHDDoiTra(string _maHDTra)
        {
            return _unity.filldb("PH_HoaDonDoiTra_TangMa", _maHDTra);
        }

        /// <summary>
        /// tăng mã chi tiết hóa đơn đổi trả
        /// </summary>
        /// <param name="_maCTHDTra"></param>
        /// <returns></returns>
        public DataTable TangMaCTHDDoiTra(string _maCTHDTra)
        {
            return _unity.filldb("PH_CT_HDDoiTra_MaTang", _maCTHDTra);
        }

        public DataTable TangMaCTHD(string _maCTHD)
        {
            return _unity.filldb("PH_CT_HoaDon_MaTang", _maCTHD);
        }
    }
}
