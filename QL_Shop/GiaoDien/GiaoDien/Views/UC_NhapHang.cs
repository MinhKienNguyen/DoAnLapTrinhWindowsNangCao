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
    public partial class UC_NhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGridDataSource = null;
        HangHoaModel _hangModel = new HangHoaModel();
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {

        }

        private void LoadGrid()
        {
            DataTable dt = _hangModel.GetDataHangHoaDonHang(txtMaNhap.Text);
            iGridDataSource = dt.Copy();
            gridControl1.DataSource = iGridDataSource.Copy();
        }

        private void txtMaNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadGrid();
            }
        }
    }
}
