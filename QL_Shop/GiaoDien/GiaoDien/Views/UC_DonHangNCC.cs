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
            LoadGridDonHang();
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        //    try
        //    {
        //        MouseHelper.MouseWait(this);
        //        ExportExcel exp = new ExportExcel();
        //        DataSet dsSource = new DataSet();
        //        string filename = string.Empty;
        //        DataTable dt = new DataTable();
        //        if (this.grdDonHang == null || this.iGridDataSource.Rows.Count <= 0)
        //        {
        //           // base.ShowMessage(MessageType.Information, Convert.ToString(UtilLanguage.ApplyLanguage()["lblNotData"]));
        //            return;
        //        }
        //        dt = this.iGridDataSource.Copy();
        //        dt.TableName = "dt";
        //        dsSource.Tables.Add(dt.Copy());
        //        string templaleFileName = ReportTemplate.ReportEWH01025;
        //        System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
        //        dlg.Filter = Filter.FilterExcel;
        //        dlg.FileName = Guid.NewGuid().ToString();
        //        var result = dlg.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            filename = dlg.FileName;
        //            var export = exp.Return(filename, templaleFileName, dsSource);
        //            if (export)
        //            {
        //                System.Diagnostics.Process.Start(filename);
        //                return;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        base.ShowMessage(MessageType.Error, ex.Message, ex);
        //    }
        //    finally
        //    {
        //        MouseHelper.MouseArrow(this);
        //    }
        }

        private void dtimeTuNgay_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void dtimeDenNgay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void txtMaDH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}
