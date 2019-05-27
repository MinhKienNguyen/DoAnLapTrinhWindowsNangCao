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
using DevExpress.XtraGrid.Views.Grid;
using GiaoDien.RP;
using GiaoDien.DoMain;

namespace GiaoDien.Views
{
    public partial class UC_ThongKeKho : DevExpress.XtraEditors.XtraUserControl
    {
        HangHoaModel _hangHoaModel = new HangHoaModel();
        private DataTable iDataSource = null;

        public UC_ThongKeKho()
        {
            InitializeComponent();
            LoadGridProduct();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }
        #region "các hàm con"
        private void LoadGridProduct()
        {
            DataTable dt = _hangHoaModel.GetDataProduct(txt_mahh.Text);
            iDataSource = dt.Copy();
            bt_xuatexcel.DataSource = iDataSource.Copy();
        }
        #endregion

       
        private void txt_mahh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_timkiem.PerformClick();
            }
        }

        private void gridViewthongke_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string SoLuongTon = gv.GetRowCellDisplayText(e.RowHandle, gv.Columns["SoLuongTon"]);
                if (Convert.ToInt32(SoLuongTon.ToString()) <= 10)
                {
                    e.Appearance.BackColor = Color.FromArgb(200, Color.Red);
                    e.Appearance.BackColor2 = Color.FromArgb(50, Color.Yellow);
                }
            }
        }

        private void bt_indanhsach_Click(object sender, EventArgs e)
        {
            if (this.iDataSource == null || this.iDataSource.Rows.Count <= 0 )
            {
                XtraMessageBox.Show(Commons.NoData, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Ngay", typeof(DateTime));
            DataRow dr = dt.NewRow();
            dr["Ngay"] = DateTime.Now;
            dt.Rows.Add(dr);
            RP_ThongKeKho don = new RP_ThongKeKho(iDataSource, dt);
            don.ShowDialog();
        }
    }
}
