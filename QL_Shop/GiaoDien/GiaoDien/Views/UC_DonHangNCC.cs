using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GiaoDien.Models;

namespace GiaoDien.Views
{
    public partial class UC_DonHangNCC : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGirDataSource = null;
        DonHangNCCModel _donHangNCCModel = new DonHangNCCModel();
        public UC_DonHangNCC()
        {
            InitializeComponent();
            dtimeDenNgay.EditValue = DateTime.Now;
            dtimeTuNgay.EditValue = DateTime.Now;
            LoadComboNCC();
        }
        private void LoadGridDonHang()
        {
            DataTable dt = _donHangNCCModel.GetDonHangNCC(txtMaDH.Text,Convert.ToString(lkNCC.EditValue),Convert.ToDateTime(dtimeTuNgay.EditValue), Convert.ToDateTime(dtimeDenNgay.EditValue));
            this.iGirDataSource = dt.Copy();
            grdDonHang.DataSource = this.iGirDataSource.Copy();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridDonHang();
        }

        public void LoadComboNCC()
        {
            DataTable dt = _donHangNCCModel.GetComboNCC();
            lkNCC.Properties.DataSource = dt;
            lkNCC.Properties.DisplayMember = "TenNCC";
            lkNCC.Properties.ValueMember = "MaNCC";
        }
    }
}
