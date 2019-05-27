using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using GiaoDien.RP;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_NhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGridDataSource = null;
        private DataTable iGridDataSourceScanBarCode = null;
        HangHoaModel _hangModel = new HangHoaModel();
        public UC_NhapHang()
        {
            InitializeComponent();
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show(Commons.ThongBaoXoa, Commons.Notify, MessageBoxButtons.OK) != DialogResult.No)
            {
                if (this.iGridDataSourceScanBarCode != null)
                {
                    DataRowView row = (DataRowView)gridViewScanBarcode.GetRow(gridViewScanBarcode.GetSelectedRows()[0]);
                    this.iGridDataSourceScanBarCode.Rows.RemoveAt(gridViewScanBarcode.GetSelectedRows()[0]);
                    this.iGridDataSourceScanBarCode.AcceptChanges();
                    grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                }
            }
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {

        }

        private void LoadGridNhapHang()
        {
            DataTable dt = _hangModel.GetDataHangHoaDonHang(txtMaNhap.Text);
            iGridDataSource = dt.Copy();
            grdPhieuNhap.DataSource = iGridDataSource.Copy();

        }

        private void txtMaNhap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadGridNhapHang();
                txtBarcode.ReadOnly = false;
                txtNumberScan.ReadOnly = false;
                if(iGridDataSource == null || iGridDataSource.Rows.Count <= 0)
                {
                    XtraMessageBox.Show(ScanBarcode.PhieuKhongTonTai, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                txtNVLap.Text = GiaoDien.Properties.Settings.Default.TenNV;
                txtNCC.Text = iGridDataSource.Rows[0]["TenNCC"].ToString(); 
                txtTongTien.Text = iGridDataSource.Rows[0]["TienConLai"].ToString();
                txtNumberScan.Text = "1";
            }
        }

        private void txtNumberScan_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.OemMinus)
            //{
            //    e.Handled = true;
            //    //txtNumberScan.Text = string.Empty;
            //    //XtraMessageBox.Show(Commons.SoLuongQuetPhaiLon0, Commons.Notify, MessageBoxButtons.OK);
                
            //}
            e.Handled = e.KeyCode == Keys.OemMinus;
        }

        /// <summary>
        /// Quét barcode
        /// </summary>
        /// <param name="_barcode"></param>
        private void ScanBarCode(string _barcode)
        {
            DataRow[] drRows = this.iGridDataSource.Select("Barcode ='" + _barcode + "'");
            if (drRows != null && drRows.Length > 0)
            {
                string productCde = drRows[0]["MaHangHoa"].ToString();
                int numberQuantityScan = Convert.ToInt32(txtNumberScan.Text);
                int quantityScan = 1;
                int quantity = Convert.ToInt32(drRows[0]["SoLuongConLai"].ToString());
                int quantityBarcode = numberQuantityScan * quantityScan;
                double tongtiennhan = quantityBarcode * Convert.ToDouble(drRows[0]["DonGiaDat"].ToString());
                if (this.iGridDataSourceScanBarCode != null && this.iGridDataSourceScanBarCode.Rows.Count > 0)
                {
                    //  xem co chua
                    DataRow[] drScan = this.iGridDataSourceScanBarCode.Select("Barcode='" + _barcode + "' ");
                    if (drScan != null && drScan.Length > 0)
                    {
                        DataRow[] drScanProduct = this.iGridDataSourceScanBarCode.Select("Barcode='" + _barcode + "'");
                        if (drScanProduct != null && drScanProduct.Length > 0)
                        {
                            int totalQuantityScan = Convert.ToInt32(drScanProduct.CopyToDataTable().Compute("sum(SoLuongGiao)", "").ToString());
                            totalQuantityScan += quantityBarcode;
                            // ktra du so luong
                            if (totalQuantityScan > quantity)
                            {
                                XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLQuet, Commons.Notify, MessageBoxButtons.OK);
                                return;
                            }
                            // co r thi cong them vao
                            drScan[0]["SoLuongGiao"] = Convert.ToDecimal(drScan[0]["SoLuongGiao"]) + quantityBarcode;
                            drScan[0]["TienNhanHang"] = Convert.ToDouble(drScan[0]["DonGiaDat"]) * Convert.ToInt16(drScan[0]["SoLuongGiao"]);
                            grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                            txtTongTien.Text = drScan[0]["TienNhanHang"].ToString();
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
                drScan[0]["SoLuongGiao"] = Convert.ToInt32(drScan[0]["SoLuongGiao"]) + quantityBarcode;
                drScan[0]["TienNhanHang"] = Convert.ToInt32(drScan[0]["TienNhanHang"]) + tongtiennhan;
            }
            else
            {
                DataRow dr = iGridDataSourceScanBarCode.NewRow();
                dr["TenLoaiHangHoa"] = drRow["TenLoaiHangHoa"];
                dr["MaLoaiHangHoa"] = drRow["MaLoaiHangHoa"];
                dr["MaHangHoa"] = drRow["MaHangHoa"];
                dr["TenHangHoa"] = drRow["TenHangHoa"];
                dr["MaHinhAnh"] = drRow["MaHinhAnh"];
                dr["MaCT_PhieuDat"] = drRow["MaCT_PhieuDat"];
                dr["MaPhieuDH"] = drRow["MaPhieuDH"];
                dr["TenMau"] = drRow["TenMau"];
                dr["MaMau"] = drRow["MaMau"];
                dr["TenSize"] = drRow["TenSize"];
                dr["MaSize"] = drRow["MaSize"];
                dr["MaDVT"] = drRow["MaDVT"];
                dr["TenDonViTinh"] = drRow["TenDonViTinh"];
                dr["SoLuongHangDat"] = drRow["SoLuongHangDat"];
                dr["SoLuongConLai"] = drRow["SoLuongConLai"];
                dr["SoLuongGiao"] = quantityBarcode;
                dr["DonGiaDat"] = drRow["DonGiaDat"];
                dr["TenNCC"] = drRow["TenNCC"];
                dr["MaNCC"] = drRow["MaNCC"];
                dr["Barcode"] = drRow["Barcode"];
                dr["TongTienPDH"] = drRow["TongTienPDH"];
                dr["TienNhanHang"] = tongtiennhan;
                dr["TienConLai"] = drRow["TienConLai"];
                dr["ROWN"] = drRow["ROWN"];
                iGridDataSourceScanBarCode.Rows.Add(dr);
                grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
            }
            txtTongTien.Text = iGridDataSourceScanBarCode.Compute("sum(TienNhanHang)", "").ToString();
        }

        private void txtBarcode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                int _status = 2;
                if (this.iGridDataSource == null || this.iGridDataSource.Rows.Count <= 0 || this.iGridDataSourceScanBarCode == null || this.iGridDataSourceScanBarCode.Rows.Count <= 0)
                {
                    XtraMessageBox.Show(ScanBarcode.PhieuKhongTonTai, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                if (XtraMessageBox.Show(ScanBarcode.BanMuonLuu, Commons.Notify, MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    int sumQuantity = Convert.ToInt32(this.iGridDataSource.Compute("sum(SoLuongHangDat)", "").ToString());
                    int sumQuantityScan = Convert.ToInt32(this.iGridDataSourceScanBarCode.Compute("sum(SoLuongGiao)", "").ToString());
                    if (sumQuantity != sumQuantityScan)
                    {
                        _status = 1;
                        XtraMessageBox.Show(ScanBarcode.SoLuongNhapThieu, Commons.Notify, MessageBoxButtons.OK);
                        if (InsertOrUpdateProduct(_status))
                        {
                            XtraMessageBox.Show(ScanBarcode.NhapThanhCong, Commons.Notify, MessageBoxButtons.OK);
                            LoadGridNhapHang();
                            RP_NhapHang don = new RP_NhapHang(iGridDataSourceScanBarCode, DataReport());
                            don.ShowDialog();
                            iGridDataSourceScanBarCode.Clear();
                            grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                            return;
                        }
                        XtraMessageBox.Show(ScanBarcode.NhapThatBai, Commons.Notify, MessageBoxButtons.OK);
                        return;
                    }
                    if (InsertOrUpdateProduct(_status))
                    {
                        XtraMessageBox.Show(ScanBarcode.NhapThanhCong, Commons.Notify, MessageBoxButtons.OK);
                        LoadGridNhapHang();
                        RP_NhapHang don = new RP_NhapHang(iGridDataSourceScanBarCode, DataReport());
                        don.ShowDialog();
                        iGridDataSourceScanBarCode.Clear();
                        grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                        return;
                    }
                    XtraMessageBox.Show(ScanBarcode.NhapThatBai, Commons.Notify, MessageBoxButtons.OK);
                }
                #region"in report"
                if (this.iGridDataSourceScanBarCode == null || this.iGridDataSourceScanBarCode.Rows.Count <= 0)
                {
                    XtraMessageBox.Show(Commons.NoData, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private DataTable DataReport()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ngay", typeof(DateTime));
            dt.Columns.Add("MaPhieuNhap", typeof(String));
            dt.Columns.Add("TenNhanVien", typeof(String));
            dt.Columns.Add("TenNhanCungCap", typeof(String));
            dt.Columns.Add("TongTien", typeof(decimal));
            DataRow dr = dt.NewRow();
            dr["Ngay"] = DateTime.Now;
            dr["MaPhieuNhap"] = txtMaNhap.EditValue.ToString();
            dr["TenNhanVien"] = txtNVLap.EditValue.ToString();
            dr["TenNhanCungCap"] = txtNCC.EditValue.ToString();
            dr["TongTien"] = txtTongTien.EditValue.ToString();
            dt.Rows.Add(dr);
            return dt;
        }

        private bool InsertOrUpdateProduct(int _status)
        {
            
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                    new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                foreach (DataRow dr in this.iGridDataSourceScanBarCode.Rows)
                {
                    string _maCTHH = MaCTHangHoa();
                    if (_hangModel.InsertHangHoa(
                        dr["MaHangHoa"].ToString(),
                        dr["TenHangHoa"].ToString(),
                        dr["MaLoaiHangHoa"].ToString(),
                        _maCTHH.ToString(),
                        dr["Barcode"].ToString(),
                        dr["MaMau"].ToString(),
                        dr["MaDVT"].ToString(),
                        dr["MaSize"].ToString(),
                        Convert.ToInt32(dr["SoLuongGiao"].ToString())) == false)
                    {
                        return false;
                    }
                    decimal _tienNhan = Convert.ToDecimal(this.iGridDataSourceScanBarCode.Compute("sum(TienNhanHang)", "").ToString());
                    if (_hangModel.UPdateStatusAndQuantity(
                         dr["MaPhieuDH"].ToString(),
                         _status,
                         dr["MaCT_PhieuDat"].ToString(),
                         Convert.ToInt32(dr["SoLuongGiao"].ToString()),
                         _tienNhan) == false)
                    {
                        return false;
                    }
                }
                tran.Complete();
                return true;
            }
        }

        public string MaCTHangHoa()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _hangModel.GetDetailProduct("MCT000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "MCT000" + i;
                    break;
                }
            }
            return strCode;
        }
    }
}
