using System.Data;

namespace GiaoDien.RP
{
    public partial class Rpt_HoaDon : Report
    {
        private int iNo = 1;
        public Rpt_HoaDon()
        {
            InitializeComponent();
        }
        public override void BindHeader(object _obj)
        {
            DataTable dt = (DataTable)_obj;
            if (dt != null && dt.Rows.Count > 0)
            {
                this.colMaHD.DataBindings.Add("Text", dt, "MaHoaDon");
                this.colKhachHang.DataBindings.Add("Text", dt, "TenKhachHang");
                this.colNgay.DataBindings.Add("Text", dt, "NgayLapHD");
                this.ColNhanVien.DataBindings.Add("Text", dt, "TenNhanVien");
                this.colTongTien.DataBindings.Add("Text", dt, "TongTien", "{0:N0} VNĐ");
            }
        }

        public override void BindData()
        {
            this.colT1.DataBindings.Add("Text", this.DataSource, "TenHangHoa");
            this.colT2.DataBindings.Add("Text", this.DataSource, "TenMau");
            this.colT3.DataBindings.Add("Text", this.DataSource, "TenSize");
            this.colT4.DataBindings.Add("Text", this.DataSource, "SoLuong", "{0:#,##0.##}");
            this.colT5.DataBindings.Add("Text", this.DataSource, "TenDonViTinh");
            this.colT6.DataBindings.Add("Text", this.DataSource, "GiaBan", "{0:N0} VNĐ");
            this.colT7.DataBindings.Add("Text", this.DataSource, "TongTien", "{0:N0} VNĐ");
        }
        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.colNo.Text = iNo.ToString();
            iNo += 1;
        }
    }
}
