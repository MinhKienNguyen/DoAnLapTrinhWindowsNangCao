using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class DoiTraModel
    {
        private DoiTraControllers _doiControllers = new DoiTraControllers();

        public DataTable GetDataBill(string _maHD)
        {
            return _doiControllers.GetDataBill(_maHD);
        }

        
        public bool UpdateSL_CTHH(string _barcode, int _soLuong)
        {
            return _doiControllers.UpdateSL_CTHH(_barcode, _soLuong);
        }

        public bool Update_CTHD(string _barcode, int _soLuong, float _tienTra)
        {
            return _doiControllers.Update_CTHD(_barcode, _soLuong, _tienTra);
        }

        public bool Update_HD(string _maHD, float _tienTra)
        {
            return _doiControllers.Update_HD(_maHD, _tienTra);
        }

        public bool Insert_HDTra(string _maHDTra, string _maHD, string _maNV, float _tienTra)
        {
            return _doiControllers.Insert_HDTra(_maHDTra, _maHD, _maNV, _tienTra);
        }

        public bool Insert_CT_HDTra(string _maCTietHDTra, string _maHDTra, string _maHH, string _barcode, int _soLuong, float _thanhTien)
        {
            return _doiControllers.Insert_CT_HDTra(_maCTietHDTra, _maHDTra, _maHH, _barcode, _soLuong, _thanhTien);
        }

        public DataTable TangMaHDDoiTra(string _maHDTra)
        {
            return _doiControllers.TangMaHDDoiTra(_maHDTra);
        }

        public DataTable TangMaCTHDDoiTra(string _maCTHDTra)
        {
            return _doiControllers.TangMaCTHDDoiTra(_maCTHDTra);
        }
    }
}
