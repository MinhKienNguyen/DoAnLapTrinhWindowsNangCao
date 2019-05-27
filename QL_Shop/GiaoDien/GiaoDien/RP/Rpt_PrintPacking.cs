using System.Data;

namespace GiaoDien.RP
{
    public partial class Rpt_PrintPacking : Report
    {
        private int iNo = 1;
        public Rpt_PrintPacking()
        {
            InitializeComponent();
        }
        public override void BindHeader(object _obj)
        {
            DataTable dt = (DataTable)_obj;
            if (dt != null && dt.Rows.Count > 0)
            {
                
                this.colCustName.DataBindings.Add("Text", dt, "CustName");
                this.colAddress.DataBindings.Add("Text", dt, "Address");
                this.colNote.DataBindings.Add("Text", dt, "Note");
                this.lblUser.DataBindings.Add("Text", dt, "UserInfor");
                string path = System.IO.Directory.GetCurrentDirectory();
                //this.xrPictureBox1.ImageUrl =string.Format("{0}\\Images\\imgpsh_fullsize.png", path);
            }
        }

        public override void BindData()
        {
            this.colT1.DataBindings.Add("Text", this.DataSource, "TenHangHoa");
            this.colT2.DataBindings.Add("Text", this.DataSource, "TenMau");
            this.colT3.DataBindings.Add("Text", this.DataSource, "TenSize");
            this.colT4.DataBindings.Add("Text", this.DataSource, "SoLuong", "{0:#,##0.##}");
            this.colT5.DataBindings.Add("Text", this.DataSource, "TenDonViTinh");
            this.colT6.DataBindings.Add("Text", this.DataSource, "GiaBan");
            this.colT7.DataBindings.Add("Text", this.DataSource, "TongTien");
        }
        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.colNo.Text = iNo.ToString();
            iNo += 1;
        }
    }
}
