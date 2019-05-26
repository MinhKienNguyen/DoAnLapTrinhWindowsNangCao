using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.DTO
{
    public class HangHoaDTO
    {
        string _STT;
        string _MaHangHoa;
        string _TenHangHoa;
        float _GiaBan;
        string _TenLoaiHang;
        int _SoLuongTon;
        string _TenMau;
        string _TenSize;
        string _TenDonViTinh;
        string _Barcode;
        float _DonGaiDat;
        public string STT
        {
            get { return _STT; }
            set { _STT = value; }
        }

        public string MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
        public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
      
     
        public string TenLoaiHang { get => _TenLoaiHang; set => _TenLoaiHang = value; }
    
        public string TenMau { get => _TenMau; set => _TenMau = value; }
        public string TenSize { get => _TenSize; set => _TenSize = value; }
        public string TenDonViTinh { get => _TenDonViTinh; set => _TenDonViTinh = value; }
        public string Barcode { get => _Barcode; set => _Barcode = value; }
        public float GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int SoLuongTon { get => _SoLuongTon; set => _SoLuongTon = value; }
        public float DonGaiDat { get => _DonGaiDat; set => _DonGaiDat = value; }

    }
}
