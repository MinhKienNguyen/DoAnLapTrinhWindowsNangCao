using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using GiaoDien.Unity;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_DanhMucHangHoa : DevExpress.XtraEditors.XtraUserControl
    {

        HangHoaModel _hangHoaModel = new HangHoaModel();
        DataTable iDataSource = null;
        UnityClass _unityClass = new UnityClass();
        
        public UC_DanhMucHangHoa()
        {
            InitializeComponent();
            LoadGridProduct();
            Loadlkloaihang();          
            lk_size.ReadOnly = true;
            lk_mausac.ReadOnly = true;
            txtGianhap.ReadOnly = true;
            lk_dvt.ReadOnly = true;
            lk_loaihang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txt_Barcode.ReadOnly = true;
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }

        private void tileViewHangHoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)tileViewHangHoa.GetRow(tileViewHangHoa.GetSelectedRows()[0]);
            txtMaHH.Text = row[0].ToString();
            txtTenHH.Text = row[1].ToString();
            lk_size.Properties.NullText = row[10].ToString();        
            lk_mausac.Properties.NullText = row[8].ToString();
            txtGianhap.Text = row[13].ToString();
            txtgiaban.Text = row[3].ToString();
            lk_dvt.Properties.NullText = row[11].ToString();
            lk_loaihang.Properties.NullText = row[5].ToString();
            txtSoLuong.Text = row[6].ToString();
            txt_Barcode.Text = row[12].ToString();
            //chuyển hình ảnh load lên picturebox
            if (row[2] == null || string.IsNullOrEmpty(row[2].ToString()))
                return;
            byte[] data = new byte[0];
            data = (byte[])(row[2]);
            MemoryStream ms = new MemoryStream(data);
            imgChonAnh.Image = Image.FromStream(ms);
        }

        private void bt_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Commons.FilterImage;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgChonAnh.ImageLocation = openFileDialog.FileName;
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(imgChonAnh.ImageLocation))
            {
                XtraMessageBox.Show(Commons.ChooseImage, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
         
            byte[] image = _unityClass.CoverFilltoByte(imgChonAnh.ImageLocation);
            DataRowView row = (DataRowView)tileViewHangHoa.GetRow(tileViewHangHoa.GetSelectedRows()[0]);
            string mau = row[7].ToString();
            if (_hangHoaModel.UpdateGiaHinhAnh(txtMaHH.Text, mau, image, txtgiaban.Text))
            {
                XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                txtMaHH.Text = string.Empty;
                txtTenHH.Text = string.Empty;
                LoadGridProduct();
                return;
            }
            XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);

        }

        private void txtMaHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();

            }
        }

        private void txtTenHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();

            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            
        }
        #region "các hàm con"
        private void LoadGridProduct()
        {
            DataTable dt = _hangHoaModel.GetDataProduct(txtMaHH.Text, txtTenHH.Text);
            iDataSource = dt.Copy();
            grdHangHoa.DataSource = iDataSource.Copy();
        }
        public void Loadlkloaihang()
        {
            DataTable dtDuty = _hangHoaModel.Getlkloaihang();
            lk_loaihang.Properties.DataSource = dtDuty.Copy();
            lk_loaihang.Properties.DisplayMember = "TenLoaiHangHoa";
            lk_loaihang.Properties.ValueMember = "MaLoaiHangHoa";
        }
        //public void ExportTableToExcel(System.Data.DataTable dt)
        //{
        //    using (SaveFileDialog saveDialog = new SaveFileDialog())
        //    {
        //        saveDialog.Filter = "Excel (Phiên ban 2007 tro lên (.xlsx)|*.xlsx";
        //        if (saveDialog.ShowDialog() != DialogResult.Cancel)
        //        {
        //            ExcelPackage p = new ExcelPackage();
        //            string exportFilePath = saveDialog.FileName;
        //            var newFile = new FileInfo(exportFilePath);
        //            using (var package = new ExcelPackage(newFile))
        //            {
        //                ExcelWorksheet ws = package.Workbook.Worksheets.Add("NewSheet1");

        //                ws.Cells["C6"].LoadFromDataTable(dt, true);
        //                //Luu file Excel
        //                package.Save();
        //            }
        //            MessageBox.Show("Xuất excel thành công!");
        //        }
        //    }

        //}
        #endregion
    }
}
