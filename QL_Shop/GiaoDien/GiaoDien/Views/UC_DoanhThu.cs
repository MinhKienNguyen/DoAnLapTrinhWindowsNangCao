using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using GiaoDien.RP;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_DoanhThu : DevExpress.XtraEditors.XtraUserControl

    {
        private DataTable iGirDataSource = null;
        DoanhThuModel _doanhThuModel = new DoanhThuModel();
        public UC_DoanhThu()
        {
            InitializeComponent();
            dtime_TuNgay.EditValue = DateTime.Now;
            dtime_denngay.EditValue = DateTime.Now;
        }
        #region"Các hàm con"
        public void LoadDoanhthu()
        {
            DataTable dt = _doanhThuModel.GetDoanhthu(Convert.ToDateTime( dtime_TuNgay.EditValue),Convert.ToDateTime( dtime_denngay.EditValue));
            this.iGirDataSource=dt.Copy();
            griddoanhthu.DataSource = this.iGirDataSource.Copy();
        }
        #endregion
        private void bt_tiemkiem_Click(object sender, EventArgs e)
        {
            LoadDoanhthu();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (this.iGirDataSource == null || this.iGirDataSource.Rows.Count <= 0)
            {
                XtraMessageBox.Show(Commons.NoData, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("TuNgay", typeof(DateTime));
            dt.Columns.Add("DenNgay", typeof(DateTime));
            dt.Columns.Add("Ngay", typeof(DateTime));
            dt.Columns.Add("TongTien", typeof(decimal));
            DataRow dr = dt.NewRow();
            dr["Ngay"] = DateTime.Now;
            dr["TuNgay"] = dtime_TuNgay.EditValue.ToString() ;
            dr["DenNgay"] = dtime_denngay.EditValue.ToString();
            dr["TongTien"] = this.iGirDataSource.Compute("sum(ThanhTien)","").ToString();
            dt.Rows.Add(dr);
            RP_DoanhThu don = new RP_DoanhThu(iGirDataSource, dt);
            don.ShowDialog();
        }

        private void dtime_TuNgay_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                bt_tiemkiem.PerformClick();
            }
        }
    }
}
