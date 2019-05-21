﻿using GiaoDien.Controllers;
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
    }
}
