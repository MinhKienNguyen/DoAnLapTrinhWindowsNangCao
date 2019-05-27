using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_DoiTra : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGridDataSource = null;
        private DataTable iGridDataSourceScanBarCode = null;
        private DataTable iGridHangDoi = null;
        private DoiTraModel _doiModel = new DoiTraModel();
        BanHangModel _banHangModel = new BanHangModel();
        private string _maNV = GiaoDien.Properties.Settings.Default.MaNV;
        private DataTable iDataProducts = null;
        public UC_DoiTra()
        {
            InitializeComponent();
            dtNgayLap.EditValue = DateTime.Now;
            groupQuetCheckHD.Visible = false;
            groupQuetHangDoi.Visible = false;
            btnXoa.Click += BtnXoa_Click;
            btnXoaHang.Click += BtnXoaHang_Click;
            iDataProducts = _banHangModel.GetDataProduct();
            txtNumberDoi.Text = "1";
        }

        /// <summary>
        /// xóa trong grid quét hàng đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnXoaHang_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(Commons.ThongBaoXoa, Commons.Notify, MessageBoxButtons.OK) != DialogResult.No)
            {
                if (this.iGridHangDoi != null)
                {
                    DataRowView row = (DataRowView)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
                    this.iGridHangDoi.Rows.RemoveAt(gridView2.GetSelectedRows()[0]);
                    this.iGridHangDoi.AcceptChanges();
                    grdHangDoi.DataSource = iGridHangDoi.Copy();
                }
            }
        }

        /// <summary>
        /// xóa trong grid hàng bị đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(Commons.ThongBaoXoa, Commons.Notify, MessageBoxButtons.OK) != DialogResult.No)
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
                if(this.iGridDataSource == null || iGridDataSource.Rows.Count <=0)
                {
                    XtraMessageBox.Show(ScanBarcode.HoaDonKhongTonTai, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
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
                    if (XuatHoaDonDoiTra())
                    {
                        this.iGridDataSource.Clear();
                        this.iGridDataSourceScanBarCode.Clear();
                        XtraMessageBox.Show(Commons.LuuThanhCong, Commons.Notify, MessageBoxButtons.OK);
                        return;
                    }
                XtraMessageBox.Show(Commons.LuuBai, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private string TangMaHDDoiTra()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _doiModel.TangMaHDDoiTra("HDDT0000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "HDDT0000" + i;
                    break;
                }
            }
            return strCode;
        }

        private string TangMaCTHDDoiTra(int i)
        {
            string strCode = string.Empty;
            int dtCout = _doiModel.TangMaCTHDDoiTra(TangMaHDDoiTra() + "CT00" + i).Rows.Count;
            if (dtCout == 0)
            {
                strCode = TangMaHDDoiTra() + "CT00" + i;
            }
            return strCode;
        }

        private bool InsertHoaDonTra()
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                string _maHDTra = TangMaHDDoiTra();
                if (_doiModel.Insert_HDTra(_maHDTra, txtMaHD.Text, _maNV, (float)Convert.ToDouble(txtTienTra.Text)) != true)
                {
                    return false;
                }
                int i = 0;
                foreach(DataRow dr in this.iGridDataSourceScanBarCode.Rows)
                {
                    string _maCTHDTra = TangMaCTHDDoiTra(i);
                    if (_doiModel.Insert_CT_HDTra(_maCTHDTra,
                                                  _maHDTra,
                                                  dr["MaHangHoa"].ToString(),
                                                  dr["BarCode"].ToString(),
                                                  Convert.ToInt32(dr["SoLuong"].ToString()),
                                                  (float)Convert.ToDouble(dr["ThanhTien"].ToString())) != true)
                    {
                        return false;
                    }
                    if(_doiModel.Update_CTHD(dr["BarCode"].ToString(),
                                            Convert.ToInt32(dr["SoLuong"].ToString()),
                                            (float)Convert.ToDouble(dr["ThanhTien"].ToString())) != true)
                    {
                        return false;
                    }
                    if(_doiModel.UpdateSL_CTHH(dr["BarCode"].ToString(),
                                                 Convert.ToInt32(dr["SoLuong"].ToString())) != true)
                    {
                        return false;
                    }
                }
                if(_doiModel.Update_HD(txtMaHD.Text) != true)
                {
                    return true;
                }

                tran.Complete();
                return true;
            }
        }

        private void txtNumberScan_KeyDown(object sender, KeyEventArgs e)
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
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void checkKtra_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkKtra.Checked == true)
                {
                    groupQuetCheckHD.Visible = true;
                }
                else
                {
                    groupQuetCheckHD.Visible = false;
                    groupQuetHangDoi.Visible = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            
        }

        private void checkQuetHangDoi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkQuetHangDoi.Checked == true)
                {
                    groupQuetHangDoi.Visible = true;
                    txtBarcodeDoi.ReadOnly = false;
                    txtNumberDoi.ReadOnly = false;
                }
                else
                {
                    groupQuetHangDoi.Visible = false;
                    groupQuetCheckHD.Visible = true;
                    txtBarcodeDoi.ReadOnly = true;
                    txtNumberDoi.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void ScanBarCodeDoi(string _barcode)
        {
            DataRow[] drRows = this.iDataProducts.Select("Barcode ='" + _barcode + "'");
            if (drRows != null && drRows.Length > 0)
            {
                int numberQuantityScan = Convert.ToInt32(txtNumberScan.Text);
                int quantityScan = 1;
                int quantity = Convert.ToInt32(iGridDataSourceScanBarCode.Compute("sum(SoLuong)", "MaHangHoa='"+ drRows[0]["MaHangHoa"].ToString() + "'").ToString());
                int quantityBarcode = numberQuantityScan * quantityScan;
                double tongtiennhan = quantityBarcode * Convert.ToDouble(drRows[0]["GiaBan"].ToString());
                if (this.iGridHangDoi != null && this.iGridHangDoi.Rows.Count > 0)
                {
                    //  xem co chua
                    DataRow[] drScan = this.iGridHangDoi.Select("Barcode='" + _barcode + "' ");
                    if (drScan != null && drScan.Length > 0)
                    {
                        DataRow[] drScanProduct = this.iGridHangDoi.Select("Barcode='" + _barcode + "'");
                        if (drScanProduct != null && drScanProduct.Length > 0)
                        {
                            int totalQuantityScan = Convert.ToInt32(drScanProduct.CopyToDataTable().Compute("sum(SoLuong)", "").ToString());
                            totalQuantityScan += quantityBarcode;
                            // ktra du so luong
                            if (totalQuantityScan > quantity)
                            {
                                XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLDoi, Commons.Notify, MessageBoxButtons.OK);
                                return;
                            }
                            // co r thi cong them vao
                            drScan[0]["SoLuong"] = Convert.ToDecimal(drScan[0]["SoLuong"]) + quantityBarcode;
                            drScan[0]["ThanhTien"] = Convert.ToDouble(drScan[0]["GiaBan"]) * Convert.ToInt16(drScan[0]["SoLuong"]);
                            grdHangDoi.DataSource = iGridHangDoi.Copy();
                            txtTienTra.Text = iGridHangDoi.Compute("sum(ThanhTien)", "").ToString();
                        }
                    }
                    else
                    {
                        if (quantityBarcode > quantity)
                        {
                            XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLDoi, Commons.Notify, MessageBoxButtons.OK);
                            return;
                        }
                        AddDataForTableScanDoi(drRows[0], quantityBarcode, tongtiennhan);
                    }
                }
                //neu chua co san pham nao thi them moi vao
                else
                {
                    // ktra so luong quet
                    if (quantityBarcode > quantity)
                    {
                        XtraMessageBox.Show(ScanBarcode.SoLuogLonHonSLDoi, Commons.Notify, MessageBoxButtons.OK);
                        return;
                    }
                    AddDataForTableScanDoi(drRows[0], quantityBarcode, tongtiennhan);
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
        private void AddDataForTableScanDoi(DataRow drRow, int quantityBarcode, double tongtiennhan)
        {
            if (iGridHangDoi == null || iGridHangDoi.Rows.Count <= 0)
            {
                iGridHangDoi = this.iGridDataSourceScanBarCode.Clone();
            }
            DataRow[] drScan = this.iGridHangDoi.Select("Barcode='" + drRow["Barcode"] + "'");
            if (drScan != null && drScan.Length > 0)
            {
                drScan[0]["SoLuong"] = Convert.ToInt32(drScan[0]["SoLuong"]) + quantityBarcode;
                drScan[0]["ThanhTien"] = Convert.ToInt32(drScan[0]["ThanhTien"]) + tongtiennhan;
            }
            else
            {
                DataRow dr = iGridHangDoi.NewRow();
                dr["MaHoaDon"] = this.iGridDataSource.Rows[0]["MaHoaDon"].ToString() ;
                dr["MaNhanVien"] = this.iGridDataSource.Rows[0]["MaNhanVien"].ToString();
                dr["NgayLapHD"] = this.iGridDataSource.Rows[0]["NgayLapHD"].ToString();
                dr["MaKhachHang"] = this.iGridDataSource.Rows[0]["MaKhachHang"].ToString();
                dr["TongTien"] = this.iGridDataSource.Rows[0]["TongTien"].ToString();
                dr["ChietKhauHD"] = this.iGridDataSource.Rows[0]["ChietKhauHD"].ToString();
                dr["TenNhanVien"] = this.iGridDataSource.Rows[0]["TenNhanVien"].ToString();
                dr["BarCode"] = drRow["BarCode"];
                dr["MaHangHoa"] = drRow["MaHangHoa"];
                dr["TenHangHoa"] = drRow["TenHangHoa"];
                dr["GiaBan"] = drRow["GiaBan"];
                dr["TenSize"] = drRow["TenSize"];
                dr["TenMau"] = drRow["TenMau"];
                dr["SoLuong"] = quantityBarcode;
                dr["ThanhTien"] = tongtiennhan;
                dr["TenLoaiHangHoa"] = drRow["TenLoaiHangHoa"];
                iGridHangDoi.Rows.Add(dr);
                grdHangDoi.DataSource = iGridHangDoi.Copy();
            }
            txtTienTra.Text = iGridHangDoi.Compute("sum(ThanhTien)", "").ToString();
        }

        private void txtBarcodeDoi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Convert.ToInt16(txtNumberDoi.Text) > 0)
                    {
                        ScanBarCodeDoi(txtBarcodeDoi.Text);
                        txtBarcodeDoi.Text = string.Empty;
                        txtNumberDoi.Text = "1";
                    }
                    else
                    {
                        XtraMessageBox.Show(ScanBarcode.SoLuongQuetPhaiLon0, Commons.Notify, MessageBoxButtons.OK);
                        txtBarcodeDoi.Text = string.Empty;
                        txtNumberDoi.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        public string TangMaCTHD()
        {
            string maHD = txtMaHD.Text;
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _doiModel.TangMaCTHD(maHD + "CTHD0" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = maHD + "CTHD0" + i;
                    break;
                }
            }
            return strCode;
        }

        private bool InsertOrUpdateHangQuet()
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                foreach (DataRow dr in this.iGridHangDoi.Rows)
                {
                    string _maCTHD = TangMaCTHD();
                    if (_doiModel.Insert_CT_HDHangQuet(_maCTHD,
                                                       txtMaHD.Text,
                                                       dr["MaHangHoa"].ToString(),
                                                       dr["BarCode"].ToString(),
                                                       Convert.ToInt32(dr["SoLuong"].ToString()),
                                                       (float)Convert.ToDouble(dr["ThanhTien"].ToString())) != true)
                    {
                        return false;
                    }
                    if(_doiModel.UpdateSLHangQuet_Kho(dr["BarCode"].ToString(), Convert.ToInt32(dr["SoLuong"].ToString())) != true)
                    {
                        return false;
                    }
                }
                tran.Complete();
                return true;
            }
        }

        private bool XuatHoaDonDoiTra()
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                if (InsertHoaDonTra() != true)
                {
                    return false;
                }
                if(InsertOrUpdateHangQuet() != true)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
        }
    }
}
