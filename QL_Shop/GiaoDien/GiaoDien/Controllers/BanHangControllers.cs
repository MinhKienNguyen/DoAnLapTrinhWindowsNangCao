﻿using GiaoDien.Unity;
using System.Data;

namespace GiaoDien.Controllers
{
    public class BanHangControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDataScanBarcode( string barcode)
        {
            return _unity.filldb("HH_HangHoa_ScanBarcode", barcode.ToString());
        }
    }
}
