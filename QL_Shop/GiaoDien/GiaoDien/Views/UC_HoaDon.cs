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
    public partial class UC_HoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGirDataSource = null;
        HoaDonModel _hoaDonModel = new HoaDonModel();
        public UC_HoaDon()
        {
            InitializeComponent();
            dtime_denngay.EditValue = DateTime.Now;
            dtime_TuNgay.EditValue = DateTime.Now;
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {

        }
        #region "Các hàm con"
        private void LoadGridDonHang()
        {
            DataTable dt = _hoaDonModel.GetHoaDon(txt_mahd.Text, Convert.ToDateTime(dtime_TuNgay.EditValue), Convert.ToDateTime(dtime_denngay.EditValue));
            this.iGirDataSource = dt.Copy();
            grdHoaDon.DataSource = this.iGirDataSource.Copy();
        }
        #endregion

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            LoadGridDonHang();
        }

        private void gridViewhoadon_DoubleClick(object sender, EventArgs e)
        {
            txt_nvlap.ReadOnly = true;
            DataRowView row = (DataRowView)gridViewhoadon.GetRow(gridViewhoadon.GetSelectedRows()[0]);
            txt_mahd.Text = row[0].ToString();
            txt_nvlap.Text = row[4].ToString();

        }

        private void bt_inlaihd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

        }
    }
}
