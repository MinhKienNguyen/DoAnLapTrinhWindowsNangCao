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
using GiaoDien.DoMain;
using DevExpress.XtraGrid.Views.Grid;
using GiaoDien.RP;
using System.Collections;

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
            try
            {
                txt_nvlap.ReadOnly = true;
                DataRowView row = (DataRowView)gridViewhoadon.GetRow(gridViewhoadon.GetSelectedRows()[0]);
                txt_mahd.Text = row[0].ToString();
                txt_nvlap.Text = row[4].ToString();
            }
            catch (Exception ex)
            {
                return;
            }
           
        }

        private void bt_inlaihd_Click(object sender, EventArgs e)
        {
            dtReport();
            RP_HoaDon don = new RP_HoaDon(dtReport(), dtReport());
            don.ShowDialog();
        }

        private void dtime_TuNgay_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btntimkiem.PerformClick();
            }
        }

        private void dtime_denngay_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btntimkiem.PerformClick();
            }
        }

        private void gridViewhoadon_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if(e.RowHandle >=0)
            {
                string TrangThai = gv.GetRowCellDisplayText(e.RowHandle,gv.Columns["TrangThai"]);
                if(TrangThai == "Đã đổi trả")
                {
                    e.Appearance.BackColor = Color.FromArgb(150,Color.Red);
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private DataTable dtReportHeard()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHoaDon", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("NgayLapHD", typeof(string));
            dt.Columns.Add("TongTien", typeof(string));
            dt.Columns.Add("TenNhanVien", typeof(string));
            DataRow drRow = dt.NewRow();
            drRow["MaHoaDon"] = txt_mahd.Text;
            drRow["TenKhachHang"] = iGirDataSource.Rows[0]["TenKhachHang"].ToString();
            drRow["NgayLapHD"] = DateTime.Now;
            drRow["TongTien"] = iGirDataSource.Rows[0]["TenKhachHang"].ToString();
            drRow["TenNhanVien"] = GiaoDien.Properties.Settings.Default.TenNV;
            dt.Rows.Add(drRow);
            return dt;
        }

        private DataTable dtReport()
        {
            DataTable dtReport = new DataTable();
            dtReport = this.iGirDataSource.Clone();
            Int32[] selectedRowHandles = gridViewhoadon.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                {
                    DataRow dr = gridViewhoadon.GetDataRow(selectedRowHandle);
                    dtReport.ImportRow(dr);
                }
            }
            return dtReport;
        }
    }
}
