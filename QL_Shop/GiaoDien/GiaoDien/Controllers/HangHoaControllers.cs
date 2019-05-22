using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class HangHoaControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetProduct(string _maHang, string _tenHang)
        {
            return _unity.filldb("HH_HangHoa_GetData", _maHang.ToString(), _tenHang.ToString());
        }
        public DataTable GetImage(string EmployessCde)
        {
            var result = _unity.filldb("HH_HangHoa_GetImage", EmployessCde.ToString());
            return result;
        }

        /// <summary>
        /// Update hình ảnh
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="Image"></param>
        /// <returns></returns>
        public DataTable InsertEmployess( string ma ,byte[] Image)
        {
            return _unity.filldb("HH_HangHoa_InsertEmployess",ma, Image);
        }

        public DataTable GetDataHangHoaDonHang(string _maNhapHang)
        {
            return _unity.filldb("PH_CT_DatHang_GetData", _maNhapHang);
        }

        public bool InsertHangHoa(string _maHang, string _tenHang, string _maLoaiHang, string _maCT, string _barcode, string _maMau, string _maDVT, string _maSize, int _SL)
        {
            
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtCheck = _unity.filldb("HH_HangHoa_InsertOrUpdate", _maHang, _tenHang, _maLoaiHang);
                if (dtCheck.Rows.Count <= 0 || Convert.ToInt16(dtCheck.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                DataTable dtND = _unity.filldb("HH_CT_HangHoa_InsertOrUpdate", _maCT, _barcode, _maHang, _maMau, _maDVT, _maSize, _SL);
                if (dtND.Rows.Count <= 0 || Convert.ToInt16(dtND.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
        }


        public bool UPdateStatusAndQuantity(string _maDH, int _trangThai, string _maCT_DH, int _SLGiao)
        {
            string _maNV = GiaoDien.Properties.Settings.Default.MaNV;
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtCheck = _unity.filldb("PH_PhieuDatHang_UpdateStatus", _maDH, _trangThai, _maNV);
                if (dtCheck.Rows.Count <= 0 || Convert.ToInt16(dtCheck.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                DataTable dtND = _unity.filldb("PH_CT_PhieuDat_UpdateQuantity", _maCT_DH, _SLGiao);
                if (dtND.Rows.Count <= 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
            
        }

        //public DataTable InsertCTHangHoa(string _maCT, string _maHang, string _maMau, string _maDVT, string _maSize, int _sl)
        //{
        //    return _unity.filldb("HH_CT_HangHoa_InsertOrUpdate", _maHang, _tenLoaiHang, _barcode, _tenHang, Image, _maLoaiHang, _maGia);
        //}
        public DataTable Getlkloaihang()
        {
            return _unity.filldb("HH_LoaiHangHoa_Getlkhanghoa");
        }

        public DataTable GetDetailProduct(string _maCTHH)
        {
            return _unity.filldb("HH_CT_HangHoa_GetDetailProduct", _maCTHH);
        }
    }
}
