using System;
using System.Data;

namespace GiaoDien.RP
{
    public partial class Rpt_NhapHang : Report
    {
        private int iNo = 1;
        public Rpt_NhapHang()
        {
            InitializeComponent();
        }
        public override void BindHeader(object _obj)
        {
            
            DataTable dt = (DataTable)_obj;
            if (dt != null && dt.Rows.Count > 0)
            {
                this.lbNgay.DataBindings.Add("Text", dt, "Ngay");
                this.colTongTien.DataBindings.Add("Text", dt, "TongTien", "{0:N0} VNĐ");
                this.colTenncc.DataBindings.Add("Text", dt, "TenNhanCungCap");
                this.colnv.DataBindings.Add("Text", dt, "TenNhanVien");
                this.colMaHD.DataBindings.Add("Text", dt, "MaPhieuNhap");
              
            }
        }

        public override void BindData()
        {
            this.colT1.DataBindings.Add("Text", this.DataSource, "MaHangHoa");
            this.colT2.DataBindings.Add("Text", this.DataSource, "TenHangHoa");
            this.colT3.DataBindings.Add("Text", this.DataSource, "TenMau");
            this.colT4.DataBindings.Add("Text", this.DataSource, "TenSize");
            this.colT6.DataBindings.Add("Text", this.DataSource, "DonGiaDat", "{0:N0} VNĐ");
            this.colT5.DataBindings.Add("Text", this.DataSource, "SoLuongGiao", "{0:#,##0.##}");
            this.colT7.DataBindings.Add("Text", this.DataSource, "TenDonViTinh");

        }
        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.colNo.Text = iNo.ToString();
            iNo += 1;
        }
    }
}
