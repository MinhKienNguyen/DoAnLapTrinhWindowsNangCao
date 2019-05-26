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
                using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
                {

                    tran.Complete();
                    //return true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }
    }

}

