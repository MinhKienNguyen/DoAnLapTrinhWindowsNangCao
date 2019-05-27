using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_NhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        NhaCungCapModel ncc = new NhaCungCapModel();
        private DataTable dtEmployess = null;
        public UC_NhaCungCap()
        {
            InitializeComponent();
            LoadGridNhaCC();
        }
        /// <summary>
        /// load dữ liệu ln gricontrol
        /// </summary>
        public void LoadGridNhaCC()
        {
            string S = txtTenNhaCC.Text;
            DataTable dt = ncc.GetEmployees(txtTenNhaCC.Text);
            this.dtEmployess = dt.Copy();
            gridNCC.DataSource = dtEmployess;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridNhaCC();
        }

        private void txtTenNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();

            }
        }    

        private void gridnhacc_Click(object sender, EventArgs e)
        {
            
        }
        public string EmployessCde()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = ncc.GetEmployessCde("NCC000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "NCC000" + i;
                    break;
                }
            }
            return strCode;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.groupThongtinncc.Controls)
            {
                if (item.GetType() == typeof(TextEdit) || item.GetType() == typeof(LookUpEdit))
                {
                    item.Text = string.Empty;
                }
            }
            txtMaNCC.Text = EmployessCde();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSDTNCC.Text) || string.IsNullOrEmpty(txtDiaChiNCC.Text))
            {
                XtraMessageBox.Show(Commons.FullData, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dtCheckInsert ; 
            dtCheckInsert = ncc.InsertEmployess(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDTNCC.Text);

            if (dtCheckInsert.Rows.Count > 0 && dtCheckInsert != null)
            {
                XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                txtMaNCC.Text = EmployessCde();
                LoadGridNhaCC();
                return;
            }
            XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)gridnhacc.GetRow(gridnhacc.GetSelectedRows()[0]);
            bool checkDelete = ncc.DeleteEmployess(row["MaNCC"].ToString());
            if (checkDelete == false)
            {
                XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
            LoadGridNhaCC();
        }

        private void gridnhacc_DoubleClick(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)gridnhacc.GetRow(gridnhacc.GetSelectedRows()[0]);
            txtMaNCC.Text = row[0].ToString();
            txtTenNCC.Text = row[1].ToString();
            txtSDTNCC.Text = row[3].ToString();
            txtDiaChiNCC.Text = row[2].ToString();
        }
    }
}
