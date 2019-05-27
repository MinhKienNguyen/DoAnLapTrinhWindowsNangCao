using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using GiaoDien.RP;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        BanHangModel _banHangModel = new BanHangModel();
        private DataTable iDataProducts = null; 
        private string MaNV = GiaoDien.Properties.Settings.Default.MaNV;
        private DataTable iGridDataSourceScanBarCode = null;
        private DataTable iDataSourceHeaderRP = null;
        private DataTable DataTableKhachHang = null;
        public UC_BanHang()
        {
            InitializeComponent();
            loadbanghang();
            TableBindings();
        }

        private void loadbanghang()
        {
            txtBarCodeKhachHang.Enabled = false;
            txt_makh.ReadOnly = true;
            txtTienTich.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txt_SDT.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            DataTable dt = _banHangModel.GetDataProduct();
            iDataProducts = dt.Copy();
            txtNumberScan.Text = "1";
            txt_mahd.Text = Getincreaseinvoicecode();
            
        }
        private void chek_thanhvien_CheckedChanged(object sender, EventArgs e)
        {
            if(chek_thanhvien.Checked==true)
            {
                txtBarCodeKhachHang.Enabled = true;
                txt_makh.Enabled = true;
                txtTienTich.Enabled = true;
                txtTenKH.Enabled = true;
                txt_SDT.Enabled = true;
            }
            else
            {
                txtBarCodeKhachHang.Enabled = false;
                txt_makh.Enabled = false;
                txtTienTich.Enabled = false;
                txtTenKH.Enabled = false;
                txt_SDT.Enabled = false;
            }
         
        }
        #region "các hàm con"
        /// <summary>
        /// tăng mã hóa đơn
        /// 
        /// </summary>
        /// <returns></returns>
        public string Getincreaseinvoicecode()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _banHangModel.Getsell("HD0000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "HD0000" + i;
                    break;
                }
            }
            return strCode;
        }

        #endregion

        /// <summary>
        /// Quét barcode
        /// </summary>
        /// <param name="_barcode"></param>
        private void ScanBarCode(string _barcode)
        {
            DataRow[] drRows = this.iDataProducts.Select("Barcode ='" + _barcode + "'");
            if (drRows != null && drRows.Length > 0)
            {
                int numberQuantityScan = Convert.ToInt32(txtNumberScan.Text);
                int quantityScan = 1;
                int quantity = Convert.ToInt32(drRows[0]["SoLuongTon"].ToString());
                int quantityBarcode = numberQuantityScan * quantityScan;
                Decimal tongtiennhan = quantityBarcode * Convert.ToDecimal(drRows[0]["GiaBan"].ToString());
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
                                XtraMessageBox.Show(ScanBarcode.SoLuongVuotKho, Commons.Notify, MessageBoxButtons.OK);
                                return;
                            }
                            // co r thi cong them vao
                            drScan[0]["SoLuong"] = Convert.ToDecimal(drScan[0]["SoLuong"]) + quantityBarcode;
                            drScan[0]["TongTien"] = Convert.ToDouble(drScan[0]["GiaBan"]) * Convert.ToInt16(drScan[0]["SoLuong"]);
                            grdBill.DataSource = iGridDataSourceScanBarCode.Copy();
                            decimal _tongTien = Convert.ToDecimal(iGridDataSourceScanBarCode.Compute("sum(TongTien)", "").ToString());
                            txtTongTien.Text = _tongTien.ToString();
                        }
                    }
                    else
                    {
                        if (quantityBarcode > quantity)
                        {
                            XtraMessageBox.Show(ScanBarcode.SoLuongVuotKho, Commons.Notify, MessageBoxButtons.OK);
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
                        XtraMessageBox.Show(ScanBarcode.SoLuongVuotKho, Commons.Notify, MessageBoxButtons.OK);
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
        private void AddDataForTableScan(DataRow drRow, int quantityBarcode, decimal tongtiennhan)
        {
            if (iGridDataSourceScanBarCode == null)
            {
                iGridDataSourceScanBarCode = this.iDataProducts.Clone();
            }
            DataRow[] drScan = this.iGridDataSourceScanBarCode.Select("Barcode='" + drRow["Barcode"] + "'");
            if (drScan != null && drScan.Length > 0)
            {
                drScan[0]["SoLuong"] = Convert.ToInt32(drScan[0]["SoLuong"]) + quantityBarcode;
                drScan[0]["TongTien"] = Convert.ToDecimal(drScan[0]["TongTien"]) + tongtiennhan;
            }
            else
            {
                DataRow dr = iGridDataSourceScanBarCode.NewRow();
                dr["Barcode"] = drRow["Barcode"];
                dr["MaHangHoa"] = drRow["MaHangHoa"];
                dr["TenHangHoa"] = drRow["TenHangHoa"];
                dr["MaLoaiHangHoa"] = drRow["MaLoaiHangHoa"];
                dr["TenLoaiHangHoa"] = drRow["TenLoaiHangHoa"];
                dr["GiaBan"] = drRow["GiaBan"];
                dr["MaMau"] = drRow["MaMau"];
                dr["TenMau"] = drRow["TenMau"];
                dr["MaDVT"] = drRow["MaDVT"];
                dr["TenDonViTinh"] = drRow["TenDonViTinh"];
                dr["MaSize"] = drRow["MaSize"];
                dr["TenSize"] = drRow["TenSize"];
                dr["SoLuongTon"] = drRow["SoLuongTon"];
                dr["TongTien"] = tongtiennhan;
                dr["SoLuong"] = quantityBarcode;
                iGridDataSourceScanBarCode.Rows.Add(dr);
                grdBill.DataSource = iGridDataSourceScanBarCode.Copy();
            }
            decimal _tongTien = Convert.ToDecimal(iGridDataSourceScanBarCode.Compute("sum(TongTien)", "").ToString());
            txtTongTien.Text = _tongTien.ToString();
            //txtTongTien.Text = iGridDataSourceScanBarCode.Compute("sum(TongTien)", "").ToString();
        }

        /// <summary>
        /// bắt sự kiện nhấn enter vào barcode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// TangMaCTHD -- tăng mã chi tiết hàng hóa
        /// </summary>
        /// <returns></returns>
        public string TangMaCTHD(int i)
        {
            string maHD = txt_mahd.Text;
            string strCode = string.Empty;
            int dtCout = _banHangModel.Getsell(maHD + "CTHD0" + i).Rows.Count;
            if (dtCout == 0)
            {
                strCode = maHD + "CTHD0" + i;
            }
            return strCode;
        }

        private void TableBindings()
        {
            try
            {
                this.iDataSourceHeaderRP = new DataTable();
                iDataSourceHeaderRP.Columns.Add("MaHoaDon", typeof(string));
                iDataSourceHeaderRP.Columns.Add("TenKhachHang", typeof(string));
                iDataSourceHeaderRP.Columns.Add("NgayLapHD", typeof(string));
                iDataSourceHeaderRP.Columns.Add("TongTien", typeof(string));
                iDataSourceHeaderRP.Columns.Add("TenNhanVien", typeof(string));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void dtHeaderRP()
        {
            string tenKH = "";
            if(DataTableKhachHang != null && DataTableKhachHang.Rows.Count > 0)
            {
                tenKH = DataTableKhachHang.Rows[0]["TenKhachHang"].ToString();
            }
            DataRow drRow = iDataSourceHeaderRP.NewRow();
            drRow["MaHoaDon"] = txt_mahd.Text;
            drRow["TenKhachHang"] = tenKH;
            drRow["NgayLapHD"] = DateTime.Now;
            drRow["TongTien"] = txtTongTien.Text;
            drRow["TenNhanVien"] = GiaoDien.Properties.Settings.Default.TenNV;
            this.iDataSourceHeaderRP.Rows.Add(drRow);
        }

        /// <summary>
        /// In hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.iDataProducts == null || this.iDataProducts.Rows.Count <= 0 || this.iGridDataSourceScanBarCode == null || this.iGridDataSourceScanBarCode.Rows.Count <= 0)
                {
                    XtraMessageBox.Show(Commons.NoData, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                if (XtraMessageBox.Show(ScanBarcode.BanCoMuonXuatHD, Commons.Notify, MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    if (ThemHoaDon())
                    {
                        dtHeaderRP();
                        RP_HoaDon don = new RP_HoaDon(iGridDataSourceScanBarCode, iDataSourceHeaderRP);
                        don.ShowDialog();
                        iDataSourceHeaderRP.Clear();
                        if(DataTableKhachHang != null && DataTableKhachHang.Rows.Count > 0)
                        {
                            DataTableKhachHang.Clear();
                        }
                        this.iGridDataSourceScanBarCode.Clear();
                        grdBill.DataSource = iGridDataSourceScanBarCode.Copy();
                        this.iDataProducts.Clear();
                        loadbanghang();
                        txtBarCodeKhachHang.Text = String.Empty;
                        txt_makh.Text = String.Empty;
                        txtTienTich.Text = String.Empty;
                        txtTenKH.Text = String.Empty;
                        txt_SDT.Text = String.Empty;
                        txtTongTien.Text = string.Empty;
                        chek_thanhvien.Checked = false;
                    }
                    else
                    {
                        XtraMessageBox.Show(ScanBarcode.XuatHDThatBai, Commons.Notify, MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
               // XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            
            
        }

        public bool ThemHoaDon()
        {
            double _chietKhau = 0;
            decimal _tongTien = Convert.ToDecimal(txtTongTien.Text);
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                {
                    if (string.IsNullOrEmpty(txtBarCodeKhachHang.Text) != true)
                    {
                        if (_banHangModel.UpdateTichTienKH(
                            txtBarCodeKhachHang.Text,
                            Convert.ToDecimal(txtTongTien.Text)) != true)
                        {
                            return false;
                        }
                        if(Convert.ToDecimal(txtTienTich.Text) >= Convert.ToDecimal(StatusBill.DKKM))
                        {
                            _chietKhau = 0.1;
                            _tongTien = _tongTien * Convert.ToDecimal(1 - _chietKhau);
                            if(_banHangModel.UpdateChietKhau(txtBarCodeKhachHang.Text) != true)
                            {
                                return false;
                            }
                        }
                    }
                    if (_banHangModel.ThemHoaDon(
                        txt_mahd.Text,
                        MaNV.ToString(),
                        txt_makh.Text,
                        StatusBill.Xuat,
                        _chietKhau,
                        _tongTien) != true)
                    {
                        return false;
                    }
                    int i = 0;
                    foreach (DataRow dr in iGridDataSourceScanBarCode.Rows)
                    {
                        string _maCTHD = TangMaCTHD(i);
                        if(string.IsNullOrEmpty(_maCTHD))
                        {
                            i++;
                            _maCTHD = TangMaCTHD(i);
                        }
                        if (_banHangModel.ThemCTHoaDon(_maCTHD,
                            txt_mahd.Text,
                            dr["MaHangHoa"].ToString(),
                            dr["Barcode"].ToString(),
                            Convert.ToInt32(dr["SoLuong"].ToString()),
                            Convert.ToDecimal(dr["TongTien"].ToString())) != true)
                        {
                            return false;
                        }
                        if(_banHangModel.UpdateSoLuongBan(
                            dr["Barcode"].ToString(),
                            Convert.ToInt32(dr["SoLuong"].ToString())) != true)
                        {
                            return false;
                        }
                        i++;
                    }
                }
                tran.Complete();
                return true;
            }
        }

        private void txtBarCodeKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = new DataTable();
                    dt = _banHangModel.GetDataCustomers(txtBarCodeKhachHang.Text);
                    DataTableKhachHang = dt.Copy();
                    txtTenKH.Text = DataTableKhachHang.Rows[0]["TenKhachHang"].ToString();
                    txt_makh.Text = DataTableKhachHang.Rows[0]["MaKhachHang"].ToString();
                    txt_SDT.Text = DataTableKhachHang.Rows[0]["SDT_KH"].ToString();
                    txtTienTich.Text = DataTableKhachHang.Rows[0]["TichTien"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
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

        private void txtNumberScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNumberScan_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumberScan.Text, "  ^ [0-9]"))
            {
                txtNumberScan.Text = "";
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
