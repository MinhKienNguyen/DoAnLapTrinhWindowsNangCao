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
            txtTenHH.ReadOnly = true;
            txtMaHH.ReadOnly = true;
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }

        private void tileViewHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)tileViewHangHoa.GetRow(tileViewHangHoa.GetSelectedRows()[0]);
                txtMaHH.Text = row[0].ToString();
                txtTenHH.Text = row[1].ToString();
                lk_size.Properties.NullText = row[8].ToString();
                lk_mausac.Properties.NullText = row[6].ToString();
                txtGianhap.Text = row[12].ToString();
                txtgiaban.Text = row[2].ToString();
                lk_dvt.Properties.NullText = row[9].ToString();
                lk_loaihang.Properties.NullText = row[4].ToString();
                txtSoLuong.Text = row[13].ToString();
                txt_Barcode.Text = row[11].ToString();
                //chuyển hình ảnh load lên picturebox
                if (row[20] == null || string.IsNullOrEmpty(row[20].ToString()))
                    return;
                byte[] data = new byte[0];
                data = (byte[])(row[20]);
                MemoryStream ms = new MemoryStream(data);
                imgChonAnh.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void bt_chonanh_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(imgChonAnh.ImageLocation))
                {
                    XtraMessageBox.Show(Commons.ChooseImage, Commons.Notify,  MessageBoxButtons.OK);
                    return;
                }
                byte[] image = _unityClass.CoverFilltoByte(imgChonAnh.ImageLocation);
                DataRowView row = (DataRowView)tileViewHangHoa.GetRow(tileViewHangHoa.GetSelectedRows()[0]);
                string mau = row[5].ToString();
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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
        }
        private void LoadGridProduct()
        {
            DataTable dt = _hangHoaModel.GetDataProduct(txt_timkiem.Text);
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
        
        private void txt_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();

            }
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtgiaban_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtgiaban.Text, "  ^ [0-9]"))
            {
                txtgiaban.Text = "";
            }
        }
    }
}
