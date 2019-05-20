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


        }
        /// <summary>
        /// load dữ liệu ln gricontrol
        /// </summary>
        public void LoadGridEmployess()
        {
            string S = txt_tenkhachhang.Text;
            DataTable dt = _khachHangModels.GetEmployees(txt_tenkhachhang.Text,txt_makhachhang.Text);
            this.dtEmployess = dt.Copy();
           gridControl1 .DataSource = dtEmployess;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridEmployess();
        }

        private void griKhachHang_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)griKhachHang.GetRow(griKhachHang.GetSelectedRows()[0]);
            txtmakh.Text = row[0].ToString();
            txttenkh.Text = row[1].ToString();
            txtsdt.Text = row[3].ToString();
            txtdiachi.Text = row[2].ToString();               
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtmakh.Text)|| string.IsNullOrEmpty(txttenkh.Text)|| string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtdiachi.Text))
            {
                XtraMessageBox.Show(Commons.FullData, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dtCheckInsert;
            dtCheckInsert = _khachHangModels.InsertEmployess(txtmakh.Text, txttenkh.Text, txtdiachi.Text,txtsdt.Text);

            if (dtCheckInsert.Rows.Count > 0 && dtCheckInsert != null)
            {
                XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                txtmakh.Text = EmployessCde();
                LoadGridEmployess();
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
            LoadGridEmployess();
        }
    }
}
