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

namespace GiaoDien.Views
{
    public partial class UC_DoiTra : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGridDataSource = null;
        private DataTable iGridDataSourceScanBarCode = null;
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
            iGridDataSource = dt.Copy();
            grdPhieuNhap.DataSource = iGridDataSource.Copy();
        }

        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataBill();
                txtNVLap.Text = iGridDataSource.Rows[0]["TenNhanVien"].ToString();
                txtTienHD.Text = iGridDataSource.Rows[0]["TongTien"].ToString();
                dtNgayLap.Text = iGridDataSource.Rows[0]["NgayLapHD"].ToString();
                txtBarcode.ReadOnly = false;
                txtNumberScan.ReadOnly = false;
                txtNumberScan.Text = "1";
            }
        }

        private void ScanBarCode(string _barcode)
        {
            DataRow[] drRows = this.iGridDataSource.Select("Barcode ='" + _barcode + "'");
            if (drRows != null && drRows.Length > 0)
            {
                int numberQuantityScan = Convert.ToInt32(txtNumberScan.Text);
                int quantityScan = 1;
                int quantity = Convert.ToInt32(drRows[0]["SoLuong"].ToString());
                int quantityBarcode = numberQuantityScan * quantityScan;
                double tongtiennhan = quantityBarcode * Convert.ToDouble(drRows[0]["GiaBan"].ToString());
                if (this.iGridDataSourceScanBarCode != null && this.iGridDataSourceScanBarCode.Rows.Count > 0)
                {
                    //  xem co chua
                    DataRow[] drScan = this.iGridDataSourceScanBarCode.Select("Barcode='" + _barcode + "' ");
                    if (drScan != null && drScan.Length > 0)
                    {
                        DataRow[] drScanProduct = this.iGridDataSourceScanBarCode.Select("Barcode='" + _barcode + "'");
                        if (drScanProduct != null && drScanProduct.Length > 0)
                        {
                            int totalQuantityScan = Convert.ToInt32(drScanProduct.CopyToDataTable().Compute("sum(SoLuong)", "").ToString());
                            totalQuantityScan += quantityBarcode;
                            // ktra du so luong
                            if (totalQuantityScan > quantity)
                            {
                                XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLQuet, Commons.Notify, MessageBoxButtons.OK);
                                return;
                            }
                            // co r thi cong them vao
                            drScan[0]["SoLuong"] = Convert.ToDecimal(drScan[0]["SoLuong"]) + quantityBarcode;
                            drScan[0]["ThanhTien"] = Convert.ToDouble(drScan[0]["GiaBan"]) * Convert.ToInt16(drScan[0]["SoLuong"]);
                            grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                            txtTienTra.Text = iGridDataSourceScanBarCode.Compute("sum(ThanhTien)", "").ToString();
                        }
                    }
                    else
                    {
                        if (quantityBarcode > quantity)
                        {
                            XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLQuet, Commons.Notify, MessageBoxButtons.OK);
                            return;
                        }
                        AddDataForTableScan(drRows[0], quantityBarcode, tongtiennhan);
                    }
                }
                //neu chua co san pham nao thi them moi vao
                else
                {
                    // ktra so luong quet
                    if (quantityBarcode > quantity)
                    {
                        XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLQuet, Commons.Notify, MessageBoxButtons.OK);
                        return;
                    }
                    AddDataForTableScan(drRows[0], quantityBarcode, tongtiennhan);
                }
            }
            else
            {
                XtraMessageBox.Show(ScanBarcode.HangKoTonTai, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// AddDataForTableScan -- add mat hang khi quet
        /// </summary>
        /// <param name="drRow"></param>
        /// <param name="quantity"></param>
        /// <param name="barCode"></param>
        private void AddDataForTableScan(DataRow drRow, int quantityBarcode, double tongtiennhan)
        {
            if (iGridDataSourceScanBarCode == null)
            {
                iGridDataSourceScanBarCode = this.iGridDataSource.Clone();
            }
            DataRow[] drScan = this.iGridDataSourceScanBarCode.Select("Barcode='" + drRow["Barcode"] + "'");
            if (drScan != null && drScan.Length > 0)
            {
                drScan[0]["SoLuong"] = Convert.ToInt32(drScan[0]["SoLuong"]) + quantityBarcode;
                drScan[0]["ThanhTien"] = Convert.ToInt32(drScan[0]["ThanhTien"]) + tongtiennhan;
            }
            else
            {
                DataRow dr = iGridDataSourceScanBarCode.NewRow();
                dr["MaHoaDon"] = drRow["MaHoaDon"];
                dr["MaNhanVien"] = drRow["MaNhanVien"];
                dr["NgayLapHD"] = drRow["NgayLapHD"];
                dr["MaKhachHang"] = drRow["MaKhachHang"];
                dr["TichTien"] = drRow["TichTien"];
                dr["TongTien"] = drRow["TongTien"];
                dr["ChietKhauHD"] = drRow["ChietKhauHD"];
                dr["TenNhanVien"] = drRow["TenNhanVien"];
                dr["BarCode"] = drRow["BarCode"];
                dr["MaHangHoa"] = drRow["MaHangHoa"];
                dr["TenHangHoa"] = drRow["TenHangHoa"];
                dr["GiaBan"] = drRow["GiaBan"];
                dr["TenSize"] = drRow["TenSize"];
                dr["TenMau"] = drRow["TenMau"];
                dr["SoLuong"] = quantityBarcode;
                dr["ThanhTien"] = tongtiennhan;
                dr["TenLoaiHangHoa"] = drRow["TenLoaiHangHoa"];
                iGridDataSourceScanBarCode.Rows.Add(dr);
                grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
            }
            txtTienTra.Text = iGridDataSourceScanBarCode.Compute("sum(ThanhTien)", "").ToString();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Convert.ToInt16(txtNumberScan.Text) > 0)
                    {
                        ScanBarCode(txtBarcode.Text);
                        txtBarcode.Text = string.Empty;
                        txtNumberScan.Text = "1";
                    }
                    else
                    {
                        XtraMessageBox.Show(ScanBarcode.SoLuongQuetPhaiLon0, Commons.Notify, MessageBoxButtons.OK);
                        txtBarcode.Text = string.Empty;
                        txtNumberScan.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show(ScanBarcode.BanCoMuonXuatHD, Commons.Notify, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
                {
                    
                    tran.Complete();
                }
            }
        }
    }
}
