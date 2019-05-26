using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GiaoDien.Models;
using GiaoDien.DoMain;

namespace GiaoDien.Views
{
    public partial class popop_DatHang : DevExpress.XtraEditors.XtraForm
    {
        private HangHoaModel _hoaModel = new HangHoaModel();
        PhieuDatModel _phieuDatModel = new PhieuDatModel();
        public popop_DatHang( string _maHH, string _tenHang, string _loaiHH, string _barcode, string _size, string _mau, string _dvt)
        {
            InitializeComponent();
            LoadLkLoaiHangHoa();
            LoadLkSize();
            LoadLkMau();
            LoadLkDVT();
            if (string.IsNullOrEmpty(_maHH))
            {
                txtMaHH.Text = MaHHTang();
                txtTenHH.Text = string.Empty;
                txtBarcode.Text = string.Empty;
            }
            else
            {
                txtMaHH.Text = _maHH;
                txtTenHH.Text = _tenHang;
                txtBarcode.Text = _barcode;
                lkSize.EditValue = _size;
                lkMau.EditValue = _mau;
                lkLoaiHang.EditValue = _loaiHH;
                lkDVT.EditValue = _dvt;
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLkLoaiHangHoa()
        {
            lkLoaiHang.Properties.DataSource = _hoaModel.Getlkloaihang();
            lkLoaiHang.Properties.DisplayMember = "TenLoaiHangHoa";
            lkLoaiHang.Properties.ValueMember = "MaLoaiHangHoa";
        }

        private void LoadLkMau()
        {
            lkMau.Properties.DataSource = _phieuDatModel.GetLookupMau();
            lkMau.Properties.DisplayMember = "TenMau";
            lkMau.Properties.ValueMember = "MaMau";
        }

        private void LoadLkSize()
        {
            lkSize.Properties.DataSource = _phieuDatModel.GetLookupSize();
            lkSize.Properties.DisplayMember = "TenSize";
            lkSize.Properties.ValueMember = "MaSize";
        }

        private void LoadLkDVT()
        {
            lkDVT.Properties.DataSource = _phieuDatModel.GetLkDVT();
            lkDVT.Properties.DisplayMember = "TenDonViTinh";
            lkDVT.Properties.ValueMember = "MaDVT";
        }

        private string MaHHTang()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _phieuDatModel.MaHangHoaTag("HH000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "HH000" + i;
                    break;
                }
            }
            return strCode;
        }

        public string MaCTHangHoa()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _hoaModel.GetDetailProduct("MCT000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "MCT000" + i;
                    break;
                }
            }
            return strCode;
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string _maCTHH = MaCTHangHoa();
                if (_phieuDatModel.InsertProduct(txtMaHH.Text,
                                                 txtTenHH.Text,
                                                 lkLoaiHang.EditValue.ToString(),
                                                 lkMau.EditValue.ToString(),
                                                 lkSize.EditValue.ToString(),
                                                 txtBarcode.Text,
                                                 _maCTHH,
                                                 lkDVT.EditValue.ToString()))
                {
                    XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                    Refesh();
                    return;
                }
                XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void Refesh()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            LoadLkLoaiHangHoa();
            LoadLkSize();
            LoadLkMau();
            LoadLkDVT();
            txtMaHH.Text = MaHHTang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}