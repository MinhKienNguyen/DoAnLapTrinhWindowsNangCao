using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class HangHoaModel
    {
        HangHoaControllers _hangHoaControllers = new HangHoaControllers();
        public DataTable GetDataProduct(string _maHang, string _tenHang)
        {
            return _hangHoaControllers.GetProduct(_maHang.ToString(), _tenHang.ToString());
        }
        public DataTable GetImage(string EmployessCde)
        {
            return _hangHoaControllers.GetImage(EmployessCde.ToString());
        }

        /// <summary>
        /// update hình ảnh
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="Image"></param>
        /// <returns></returns>
        public DataTable InsertEmployess(string ma, byte[] Image)
        {
            return _hangHoaControllers.InsertEmployess(ma,Image);
        }

        public DataTable GetDataHangHoaDonHang(string _maNhapHang)
        {
            return _hangHoaControllers.GetDataHangHoaDonHang(_maNhapHang);
        }
        public DataTable Getlkloaihang()
        {
            return _hangHoaControllers.Getlkloaihang();
        }

        public bool InsertHangHoa(string _maHang, string _tenHang, string _maLoaiHang, string _maCT, string _barcode, string _maMau, string _maDVT, string _maSize, int _SL)
        {
            return _hangHoaControllers.InsertHangHoa(_maHang, _tenHang, _maLoaiHang, _maCT, _barcode, _maMau, _maDVT, _maSize, _SL);
        }

        public bool UPdateStatusAndQuantity(string _maDH, int _trangThai, string _maCT_DH, int _SLGiao)
        {
            return _hangHoaControllers.UPdateStatusAndQuantity(_maDH, _trangThai, _maCT_DH, _SLGiao);
        }

        public DataTable GetDetailProduct(string _maCTHH)
        {
            return _hangHoaControllers.GetDetailProduct(_maCTHH);
        }
    }
}
