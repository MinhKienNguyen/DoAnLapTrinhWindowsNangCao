using System;

namespace GiaoDien.Views
{
    public partial class frmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            thoigian.Text = now.ToString();
            dtGridNCC.Rows.Add("KM01", "H01", "Áo thun nam có cổ, đen sọc trắng", "25%");
        }
    }
}