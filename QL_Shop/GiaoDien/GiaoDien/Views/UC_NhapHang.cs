﻿using System;
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
using System.Windows.Input;

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

        private void txtMaNhap_KeyDown(object sender, KeyEventArgs e)
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
                txtTongTien.Text = iGridDataSource.Rows[0]["TongTienPDH"].ToString();
            }
        }

        private void txtNumberScan_KeyDown(object sender, KeyEventArgs e)
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
                int quantity = Convert.ToInt32(drRows[0]["SoLuongHangDat"].ToString());
                int quantityBarcode = numberQuantityScan * quantityScan;
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
                            grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
                        }
                    }
                    else
                    {
                        AddDataForTableScan(drRows[0], quantityBarcode, quantity);
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
                    AddDataForTableScan(drRows[0], quantityBarcode, quantity);
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
        private void AddDataForTableScan(DataRow drRow, int quantityBarcode, int quantity)
        {
            if (iGridDataSourceScanBarCode == null)
            {
                iGridDataSourceScanBarCode = this.iGridDataSource.Clone();
            }
            DataRow[] drScan = this.iGridDataSourceScanBarCode.Select("Barcode='" + drRow["Barcode"] + "'");
            if (drScan != null && drScan.Length > 0)
            {
                drScan[0]["SoLuongGiao"] = Convert.ToInt32(drScan[0]["SoLuongGiao"]) + quantityBarcode;
            }
            else
            {
                DataRow dr = iGridDataSourceScanBarCode.NewRow();
                dr["TenLoaiHangHoa"] = drRow["TenLoaiHangHoa"];
                dr["MaLoaiHangHoa"] = drRow["MaLoaiHangHoa"];
                dr["MaHangHoa"] = drRow["MaHangHoa"];
                dr["TenHangHoa"] = drRow["TenHangHoa"];
                dr["MaHinhAnh"] = drRow["MaHinhAnh"];
                dr["MaPhieuDH"] = drRow["MaPhieuDH"];
                dr["TenMau"] = drRow["TenMau"];
                dr["MaMau"] = drRow["MaMau"];
                dr["TenSize"] = drRow["TenSize"];
                dr["MaSize"] = drRow["MaSize"];
                dr["SoLuongHangDat"] = drRow["SoLuongHangDat"];
                dr["SoLuongGiao"] = quantityBarcode;
                dr["DonGiaDat"] = drRow["DonGiaDat"];
                dr["TenNCC"] = drRow["TenNCC"];
                dr["MaNCC"] = drRow["MaNCC"];
                dr["Barcode"] = drRow["Barcode"];
                dr["TongTienPDH"] = drRow["TongTienPDH"];
                dr["ROWN"] = drRow["ROWN"];
                iGridDataSourceScanBarCode.Rows.Add(dr);
                grdScanBarCode.DataSource = iGridDataSourceScanBarCode.Copy();
            }
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
    }
}
