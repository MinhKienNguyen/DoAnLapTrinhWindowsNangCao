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

        public bool UpdateGiaHinhAn(string ma, string mau, byte[] Image, string giaban)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtNV = _unity.filldb("HH_CT_HangHoa_UpDate", ma, Image, mau);
                if (dtNV.Rows.Count <= 0 || Convert.ToInt16(dtNV.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                DataTable dtND = _unity.filldb("HH_HangHoa_Update", ma, giaban);
                if (dtND.Rows.Count <= 0 || Convert.ToInt16(dtND.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
        }
        public DataTable GetDataHangHoaDonHang(string _maNhapHang)
        {
            return _unity.filldb("PH_CT_DatHang_GetData", _maNhapHang);
        }

        //public DataTable InsertHangHoa(string _maHang, string _tenLoaiHang, string _barcode, string _tenHang, byte[] Image, string _maLoaiHang, string _maGia)
        //{
        //    return _unity.filldb("HH_HangHoa_InsertOrUpdate", _maHang, _tenLoaiHang, _barcode, _tenHang, Image, _maLoaiHang, _maGia);
        //}

        //public DataTable InsertCTHangHoa(string _maCT, string _maHang, string _maMau, string _maDVT, string _maSize, int _sl)
        //{
        //    return _unity.filldb("HH_CT_HangHoa_InsertOrUpdate", _maHang, _tenLoaiHang, _barcode, _tenHang, Image, _maLoaiHang, _maGia);
        //}
        public DataTable Getlkloaihang()
        {
            return _unity.filldb("HH_LoaiHangHoa_Getlkhanghoa");
        }
    }
}
