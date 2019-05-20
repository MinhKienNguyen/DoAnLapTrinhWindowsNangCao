using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class popop_DoiMK : DevExpress.XtraEditors.XtraForm
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        string _User = GiaoDien.Properties.Settings.Default.User;
        public popop_DoiMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmkMoi.Text == txtmkMoi.Text)
                {
                    DataTable resutl = _nhanvienModel.UpdatePassWord(_User, txtMKCu.Text, txtmkMoi.Text);
                    if (Convert.ToInt16(resutl.Rows[0]["CheckUpdate"].ToString()) == -2)
                    {
                        XtraMessageBox.Show(Commons.MKSai, Commons.Notify, MessageBoxButtons.OK);
                    }
                    else if (Convert.ToInt16(resutl.Rows[0]["CheckUpdate"].ToString()) == 0)
                    {
                        XtraMessageBox.Show(Commons.TrungMK, Commons.Notify, MessageBoxButtons.OK);
                    }
                    else if (Convert.ToInt16(resutl.Rows[0]["CheckUpdate"].ToString()) == 1)
                    {
                        XtraMessageBox.Show(Commons.DoiMK, Commons.Notify, MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show(Commons.DoiMKThatBai, Commons.Notify, MessageBoxButtons.OK);
                    }
                }
                else
                {
                    XtraMessageBox.Show(Commons.MKKhongKhop, Commons.Notify, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btbLamMoi_Click(object sender, EventArgs e)
        {
            txtMKCu.Text = string.Empty;
            txtmkMoi.Text = string.Empty;
            txtMKNhapLai.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}