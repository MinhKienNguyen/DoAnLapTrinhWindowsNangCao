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
    public partial class UC_DoiTra : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iDataSourceBill = null;
        private DoiTraModel _doiModel = new DoiTraModel();
        public UC_DoiTra()
        {
            InitializeComponent();
            dtNgayLap.EditValue = DateTime.Now;
        }

        /// <summary>
        /// Lấy dữ liệu hóa đơn
        /// </summary>
        private void LoadDataBill()
        {
            DataTable dt = _doiModel.GetDataBill(txtMaHD.Text);
            iDataSourceBill = dt.Copy();
            grdPhieuNhap.DataSource = iDataSourceBill.Copy();
        }

        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataBill();
                txtNVLap.Text = iDataSourceBill.Rows[0]["TenNhanVien"].ToString();
                txtTienHD.Text = iDataSourceBill.Rows[0]["TongTien"].ToString();
                dtNgayLap.Text = iDataSourceBill.Rows[0]["NgayLapHD"].ToString();
            }
        }
    }
}
