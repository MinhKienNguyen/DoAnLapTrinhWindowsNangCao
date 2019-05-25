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
