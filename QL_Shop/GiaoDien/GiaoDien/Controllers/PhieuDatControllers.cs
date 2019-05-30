using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class PhieuDatControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetKhoHang()
        {
            return _unity.filldb("HH_HangHoa_GetDataDatHang");
        }

        public DataTable GetLookupMau()
        {
            return _unity.filldb("HH_MauSac_GetLookup");
        }

        public DataTable GetLookupSize()
        {
            return _unity.filldb("HH_Size_GetLookup");
        }

        /// <summary>
        /// mã hàng hóa tăng
        /// </summary>
        /// <param name="_maHH"></param>
        /// <returns></returns>
        public DataTable MaHangHoaTag(string _maHH)
        {
            return _unity.filldb("HH_HangHoa_Tang", _maHH);
        }

        /// <summary>
        /// tăng mã phiếu đặt NCC
        /// </summary>
        /// <param name="_maPD"></param>
        /// <returns></returns>
        public DataTable DatHangNCC_MaTang(string _maPD)
        {
            return _unity.filldb("PH_DatHangNCC_Tang", _maPD);
        }

        /// <summary>
        /// tăng mã chi tiết đặt hàng NCC
        /// </summary>
        /// <param name="_maPD"></param>
        /// <returns></returns>
        public DataTable CTDatHangNCC_MaTang(string _maCTPD)
        {
            return _unity.filldb("PH_CT_DatHangNCC_MaTang", _maCTPD);
        }

        public DataTable GetLkDVT()
        {
            return _unity.filldb("HH_DonViTinh_Lookup");
        }

        public DataTable GetLkNCC()
        {
            return _unity.filldb("HH_NhaCungCap_GetComboboxNCC");
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
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtNV = _unity.filldb("HH_HangHoa_InsertOrUpdate", _maHH, _tenHH, _loaiHH);
                if (dtNV.Rows.Count <= 0 || Convert.ToInt16(dtNV.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                DataTable dtND = _unity.filldb("HH_CT_HangHoa_InsertOrUpdate", _maCTHH, _barcode, _maHH, _mau, _donvi, _Size, 0);
                if (dtND.Rows.Count <= 0 || Convert.ToInt16(dtND.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
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
            DataTable dtNV = _unity.filldb("PH_DatHangNCC_Insert", _maPD, _maNV, _maNCC);
            if (dtNV.Rows.Count <= 0 || Convert.ToInt16(dtNV.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// thêm hàng vào chi tiết phiếu đặt NCC
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
        public bool ThemCTPhieuDatNCC(string _maPD, string _maCTPD, string _maLoaiHang, string _maHH, string _tenHH, string _mau, string _size, string _donvi, int _soLuong, float _giaDat)
        {
            DataTable dtND = _unity.filldb("PH_CT_DatHangNCC_Insert", _maCTPD, _maPD, _maLoaiHang, _maHH, _tenHH, _mau, _size, _donvi, _soLuong, _giaDat);
            if (dtND.Rows.Count <= 0 || Convert.ToInt16(dtND.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }
        public bool ThemPhieuDat(string _maPD, string _maNCC, string _maNV, float _tongTien)
        {
            DataTable dtNH = _unity.filldb("PH_PhieuDatHang_Insert", _maPD, _maNCC, _maNV, _tongTien);
            if (dtNH.Rows.Count <= 0 || Convert.ToInt16(dtNH.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }

        public bool ThemCTPhieuDat(string _maCTPD, string _maLoaiHang, string _maHH, string _tenHH, string _maPD, string _mau, string _size, string _donvi, string _barcode, int _soLuong, float _giaDat)
        {
            DataTable dtNH = _unity.filldb("PH_CT_PhieuDat_Insert", _maCTPD, _maLoaiHang, _maHH, _tenHH, _maPD, _mau, _size, _donvi, _barcode, _soLuong, _giaDat);
            if (dtNH.Rows.Count <= 0 || Convert.ToInt16(dtNH.Rows[0][0].ToString()) <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
