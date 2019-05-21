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
        public DataTable InsertEmployess( string ma ,byte[] Image)
        {
            return _unity.filldb("HH_HangHoa_InsertEmployess",ma, Image);
        }

        public DataTable GetDataHangHoaDonHang(string _maNhapHang)
        {
            return _unity.filldb("PH_CT_DatHang_GetData", _maNhapHang);
        }

        public DataTable InsertHangHoa(string _maHang, string _tenLoaiHang, string _barcode, string _tenHang, byte[] Image, string _maLoaiHang, string _maGia)
        {
            return _unity.filldb("HH_HangHoa_InsertOrUpdate", _maHang, _tenLoaiHang, _barcode, _tenHang, Image, _maLoaiHang, _maGia);
        }

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
