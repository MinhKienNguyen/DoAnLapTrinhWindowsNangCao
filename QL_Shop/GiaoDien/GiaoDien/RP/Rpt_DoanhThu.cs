﻿using System;
using System.Data;

namespace GiaoDien.RP
{
    public partial class Rpt_DoanhThu : Report
    {
        private int iNo = 1;
        public Rpt_DoanhThu()
        {
            InitializeComponent();
        }
        public override void BindHeader(object _obj)
        {
            
            DataTable dt = (DataTable)_obj;
            if (dt != null && dt.Rows.Count > 0)
            {
                this.lbNgay.DataBindings.Add("Text", dt, "Ngay");
                this.lbTuNgay.DataBindings.Add("Text", dt, "TuNgay");
                this.lbDenNgay.DataBindings.Add("Text", dt, "DenNgay");
                this.lbTongTien.DataBindings.Add("Text", dt, "TongTien", "{0:N0} VNĐ");
            }
        }

        public override void BindData()
        {   
            this.colT1.DataBindings.Add("Text", this.DataSource, "MaHangHoa");
            this.colT2.DataBindings.Add("Text", this.DataSource, "TenHangHoa");
            this.colT3.DataBindings.Add("Text", this.DataSource, "TenMau");
            this.colT4.DataBindings.Add("Text", this.DataSource, "TenSize");
            this.colT5.DataBindings.Add("Text", this.DataSource, "SoLuong", "{0:#,##0.##}");
            this.colT6.DataBindings.Add("Text", this.DataSource, "TenDonViTinh");
            this.colT7.DataBindings.Add("Text", this.DataSource, "ThanhTien", "{0:N0} VNĐ");
           // this.colT8.DataBindings.Add("Text", this.DataSource, "TenLoaiHangHoa");
           // this.lbTongTien.DataBindings.Add("Text", this.DataSource, "GiaBan", "{0:N0} VNĐ");
        }
        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.colNo.Text = iNo.ToString();
            iNo += 1;
        }
    }
}
