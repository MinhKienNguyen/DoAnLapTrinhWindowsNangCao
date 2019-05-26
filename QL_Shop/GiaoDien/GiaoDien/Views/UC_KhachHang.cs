using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Models;
using GiaoDien.DoMain;
using DevExpress.XtraEditors;

namespace GiaoDien.Views
{
    public partial class UC_KhachHang : UserControl
    {
        KhachHangModels _khachHangModels = new KhachHangModels();
        private DataTable dtEmployess = null;
        public UC_KhachHang()
        {
            InitializeComponent();
            LoadGridKhachHang();
            txt_tongtien.ReadOnly = true;
            txt_mathe.ReadOnly = true;
            txtmakh.ReadOnly = true;

        }
        /// <summary>
        /// load dữ liệu ln gricontrol
        /// </summary>
        public void LoadGridKhachHang()
        {
            DataTable dt = _khachHangModels.GetEmployees(txt_makhachhang.Text);
            this.dtEmployess = dt.Copy();
           gridControl1 .DataSource = dtEmployess;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridKhachHang();
        }

        private void griKhachHang_Click(object sender, EventArgs e)
        {
           
        }
        public string EmployessCde()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _khachHangModels.GetEmployessCde("KH000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "KH000" + i;
                    break;
                }
            }
            return strCode;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.groupThongTinKhachHang.Controls)
            {
                if (item.GetType() == typeof(TextEdit) || item.GetType() == typeof(LookUpEdit))
                {
                    item.Text = string.Empty;
                }
            }
            txtmakh.Text = EmployessCde();
            txt_mathe.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtmakh.Text)|| string.IsNullOrEmpty(txttenkh.Text)|| string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtdiachi.Text))
            {
                XtraMessageBox.Show(Commons.FullData, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dtCheckInsert;
            dtCheckInsert = _khachHangModels.InsertEmployess(txtmakh.Text, txt_mathe.Text, txttenkh.Text, txtdiachi.Text,txtsdt.Text);

            if (dtCheckInsert.Rows.Count > 0 && dtCheckInsert != null)
            {
                XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                txtmakh.Text = EmployessCde();
                LoadGridKhachHang();
                return;
            }
            XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)griKhachHang.GetRow(griKhachHang.GetSelectedRows()[0]);
            bool checkDelete = _khachHangModels.DeleteEmployess(row["MaKhachHang"].ToString());
            if (checkDelete == false)
            {
                XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
            LoadGridKhachHang();
        }

        private void griKhachHang_DoubleClick(object sender, EventArgs e)
        {
            txt_mathe.ReadOnly = true;
            DataRowView row = (DataRowView)griKhachHang.GetRow(griKhachHang.GetSelectedRows()[0]);
            txtmakh.Text = row[0].ToString();
            txttenkh.Text = row[2].ToString();
            txtsdt.Text = row[4].ToString();
            txtdiachi.Text = row[3].ToString();
            txt_mathe.Text = row[1].ToString();
            txt_tongtien.Text = row[5].ToString();
        }

        private void txt_makhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}
