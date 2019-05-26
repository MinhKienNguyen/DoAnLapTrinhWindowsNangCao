using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_PhieuDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGirDataSource = null;
        private DataTable iGridDataSourceDat = null;
        PhieuDatModel _phieuDatModel = new PhieuDatModel();
        public UC_PhieuDatHang()
        {
            InitializeComponent();
            LoadGridKhoHang();
            txtNhanVien.Text = GiaoDien.Properties.Settings.Default.MaNV;
            txtMaPD.Text = MaPhieuDatNCC();
            LoadLkLoaiHangHoa();
            dtNgay.EditValue = DateTime.Now;
            TableBindings();
            btnChuyen.Click += BtnChuyen_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThemHH.Click += BtnThemHH_Click;
        }

        private void BtnThemHH_Click(object sender, EventArgs e)
        {
            popop_DatHang dh = new popop_DatHang("","","","","","","");
            dh.ShowDialog();
            LoadGridKhoHang();
        }

        /// <summary>
        /// Xóa trên lưới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(Commons.ThongBaoXoa, Commons.Notify, MessageBoxButtons.OK) != DialogResult.No)
                {
                    if (this.iGridDataSourceDat != null || this.iGridDataSourceDat.Rows.Count > 0)
                    {
                        DataRowView row = (DataRowView)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
                        this.iGridDataSourceDat.Rows.RemoveAt(gridView2.GetSelectedRows()[0]);
                        this.iGridDataSourceDat.AcceptChanges();
                        grdDatHang.DataSource = iGridDataSourceDat.Copy();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// tạo table cho grid bên phải
        /// </summary>
        private void TableBindings()
        {
            try
            {
                this.iGridDataSourceDat = new DataTable();
                iGridDataSourceDat.Columns.Add("MaLoaiHangHoa", typeof(string));
                iGridDataSourceDat.Columns.Add("TenLoaiHangHoa", typeof(string));
                iGridDataSourceDat.Columns.Add("Barcode", typeof(string));
                iGridDataSourceDat.Columns.Add("MaHangHoa", typeof(string));
                iGridDataSourceDat.Columns.Add("TenHangHoa", typeof(string));
                iGridDataSourceDat.Columns.Add("MaMau", typeof(string));
                iGridDataSourceDat.Columns.Add("TenMau", typeof(string));
                iGridDataSourceDat.Columns.Add("MaSize", typeof(string));
                iGridDataSourceDat.Columns.Add("TenSize", typeof(string));
                iGridDataSourceDat.Columns.Add("MaDVT", typeof(string));
                iGridDataSourceDat.Columns.Add("TenDonViTinh", typeof(string));
                iGridDataSourceDat.Columns.Add("SoLuong", typeof(int));
                grdDatHang.DataSource = this.iGridDataSourceDat.Copy();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// load lookup nhà cung cấp
        /// </summary>
        private void LoadLkLoaiHangHoa()
        {
            lkNCC.Properties.DataSource = _phieuDatModel.GetLkNCC();
            lkNCC.Properties.DisplayMember = "TenNCC";
            lkNCC.Properties.ValueMember = "MaNCC";
        }

        private void Refesh()
        {
            txtNhanVien.Text = GiaoDien.Properties.Settings.Default.MaNV;
            txtMaPD.Text = MaPhieuDatNCC();
            this.iGridDataSourceDat.Clear();
        }

        /// <summary>
        /// thêm hàng cần đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drRow = iGridDataSourceDat.NewRow();
                DataRowView row = (DataRowView)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                if (this.iGridDataSourceDat != null && this.iGridDataSourceDat.Rows.Count > 0)
                {
                    DataRow[] drRows = this.iGridDataSourceDat.Select("Barcode='" + row["Barcode"].ToString() + "'");
                    if (drRows == null || drRows.Length <= 0)
                    {
                        drRow["MaLoaiHangHoa"] = row["MaLoaiHangHoa"];
                        drRow["TenLoaiHangHoa"] = row["TenLoaiHangHoa"];
                        drRow["Barcode"] = row["Barcode"];
                        drRow["MaHangHoa"] = row["MaHangHoa"];
                        drRow["TenHangHoa"] = row["TenHangHoa"];
                        drRow["MaMau"] = row["MaMau"];
                        drRow["TenMau"] = row["TenMau"];
                        drRow["MaSize"] = row["MaSize"];
                        drRow["TenSize"] = row["TenSize"];
                        drRow["MaDVT"] = row["MaDVT"];
                        drRow["TenDonViTinh"] = row["TenDonViTinh"];
                        this.iGridDataSourceDat.Rows.Add(drRow);
                        grdDatHang.DataSource = this.iGridDataSourceDat.Copy();
                        return;
                    }
                    XtraMessageBox.Show(ScanBarcode.HangTonTai, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                drRow["MaLoaiHangHoa"] = row["MaLoaiHangHoa"];
                drRow["TenLoaiHangHoa"] = row["TenLoaiHangHoa"];
                drRow["Barcode"] = row["Barcode"];
                drRow["MaHangHoa"] = row["MaHangHoa"];
                drRow["TenHangHoa"] = row["TenHangHoa"];
                drRow["MaMau"] = row["MaMau"];
                drRow["TenMau"] = row["TenMau"];
                drRow["MaSize"] = row["MaSize"];
                drRow["TenSize"] = row["TenSize"];
                drRow["MaDVT"] = row["MaDVT"];
                drRow["TenDonViTinh"] = row["TenDonViTinh"];
                this.iGridDataSourceDat.Rows.Add(drRow);
                grdDatHang.DataSource = this.iGridDataSourceDat.Copy();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// load danh sách sản phẩm cần đặt hàng
        /// </summary>
        private void LoadGridKhoHang()
        {
            DataTable dt = _phieuDatModel.GetKhoHang();
            this.iGirDataSource = dt.Copy();
            grdHang.DataSource = this.iGirDataSource.Copy();
        }

        private void grdHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                popop_DatHang dh = new popop_DatHang(row[0].ToString(),
                                                     row[1].ToString(),
                                                     row[4].ToString(),
                                                     row[13].ToString(),
                                                     row[9].ToString(),
                                                     row[7].ToString(),
                                                     row[12].ToString());
                dh.ShowDialog();
                LoadGridKhoHang();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void btnLapPD_Click(object sender, EventArgs e)
        {
            try
            {
                //if (lkNCC.EditValue.ToString()=="")
                //{
                //    XtraMessageBox.Show(ScanBarcode.ChonNCC, Commons.Notify, MessageBoxButtons.OK);
                //    return;
                //}
                if(ThemPhieuDatNCC()!= true)
                {
                    XtraMessageBox.Show(ScanBarcode.LapPDatThatBai, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                XtraMessageBox.Show(ScanBarcode.PhieuDatThanhCong, Commons.Notify, MessageBoxButtons.OK);

                Refesh();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private bool ThemPhieuDatNCC()
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
               new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                if (_phieuDatModel.ThemPhieuDatNCC(txtMaPD.Text, txtNhanVien.Text, lkNCC.EditValue.ToString()) != true)
                {
                    return false;
                }
                for (int i = 0; i< this.iGridDataSourceDat.Rows.Count; i++)
                {
                    string _maLoai = gridView2.GetRowCellValue(i, "MaLoaiHangHoa").ToString();
                    string _maHH = gridView2.GetRowCellValue(i, "MaHangHoa").ToString();
                    string _tenHH = gridView2.GetRowCellValue(i, "TenHangHoa").ToString();
                    string _mau = gridView2.GetRowCellValue(i, "MaMau").ToString();
                    string _size = gridView2.GetRowCellValue(i, "MaSize").ToString();
                    string _dvt = gridView2.GetRowCellValue(i, "MaDVT").ToString();
                    int _soluong = Convert.ToInt32(gridView2.GetRowCellValue(i, "SoLuong").ToString());
                    string _maCTDH = MaCTPhieuDatNCC();
                    if (_phieuDatModel.ThemCTPhieuDatNCC(txtMaPD.Text, _maCTDH, _maLoai, _maHH, _tenHH, _mau, _size, _dvt, _soluong) != true)
                    {
                        return false;
                    }
                }
                tran.Complete();
                return true;
            }
        }

        public string MaPhieuDatNCC()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _phieuDatModel.DatHangNCC_MaTang("DHNCC000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "DHNCC000" + i;
                    break;
                }
            }
            return strCode;
        }

        public string MaCTPhieuDatNCC()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _phieuDatModel.CTDatHangNCC_MaTang("CTDH000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "CTDH000" + i;
                    break;
                }
            }
            return strCode;
        }
    }

}

