using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_NguoiDungNhomNguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        NguoiDungNhomNgDungModel _ngDungModel = new NguoiDungNhomNgDungModel();
        private DataTable dtNgDNhomND = null;
        private DataTable dtTaiKhoan = null;
        public UC_NguoiDungNhomNguoiDung()
        {
            InitializeComponent();
            btnXoa.Click += BtnXoa_Click;
            btnChuyen.Click += BtnChuyen_Click;
        }

        private void BtnChuyen_Click(object sender, EventArgs e)
        {
            btnThem();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
            string _maNhom = row["MaNhom"].ToString();
            string _user = row["Username"].ToString();
            if (XoaNgDungNhomND(_maNhom.ToString(), _user.ToString()))
            {
                XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
                LoadGridNND();
            }
            else
            {
                XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
            }
        }

        public bool XoaNgDungNhomND(string _maNhom, string _user)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
           new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtCheckInsert = _ngDungModel.DeleteNguoiDungNhomNgDung(_maNhom.ToString(), _user.ToString());
                if (dtCheckInsert.Rows.Count <= 0 || Convert.ToInt16(dtCheckInsert.Rows[0][0].ToString()) < 0)
                {
                    return false;
                }
                DataTable dtCheckDel = _ngDungModel.UpdateMaNhomWhenDel(_maNhom.ToString(), _user.ToString());
                if (dtCheckDel.Rows.Count <= 0 || Convert.ToInt16(dtCheckDel.Rows[0][0].ToString()) < 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
        }

        private void UC_NguoiDungNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadLookupDuty();
            LoadGridNhomND();
        }

        public void LoadLookupDuty()
        {
            DataTable dtDuty = _nhanvienModel.GetComboboxDuty();
            lkNhomQuyen.Properties.DataSource = dtDuty.Copy();
            lkNhomQuyen.Properties.ValueMember = "MaNhom";
            lkNhomQuyen.Properties.DisplayMember = "TenNhom";
        }

        public void LoadGridNhomND()
        {
            dtTaiKhoan = _ngDungModel.GetNhomND();
            gridControl1.DataSource = dtTaiKhoan.Copy();
        }

        public void LoadGridNND()
        {
            dtNgDNhomND = _ngDungModel.GetNgDNhomND(lkNhomQuyen.EditValue.ToString());
            grdNND.DataSource = dtNgDNhomND.Copy();
        }

        private void lkNhomQuyen_EditValueChanged(object sender, EventArgs e)
        {
            LoadGridNND();
        }

        private void btnThem()
        {
            DataRowView row = (DataRowView)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
            if(lkNhomQuyen.EditValue == null)
            {
                XtraMessageBox.Show(Commons.ChooseNhomND, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataRow[] drRows = this.dtNgDNhomND.Select("Username='" + row["Username"].ToString() + "'");
            if(drRows == null || drRows.Length <= 0)
            {
                string _maNhom = lkNhomQuyen.EditValue.ToString();
                string _user = row[1].ToString();
                if (ThemngDungNhomND(_maNhom,_user))
                {
                    XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                    LoadGridNND();
                    return;
                }
                else
                {
                    XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
            }
            XtraMessageBox.Show(Commons.Exist, Commons.Notify, MessageBoxButtons.OK);
        }

        public bool ThemngDungNhomND(string _maNhom,string _user)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
           new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                
                DataTable dtCheckInsert = _ngDungModel.InsertNguoiDungNhomNgDung(_maNhom.ToString(), _user.ToString());
                if (dtCheckInsert.Rows.Count <= 0 || Convert.ToInt16(dtCheckInsert.Rows[0][0].ToString()) < 0)
                {
                    return false;
                }
                DataTable dtCheckUpdateNV = _ngDungModel.UpdateMaNhomInNV(_maNhom.ToString(), _user.ToString());
                if (dtCheckUpdateNV.Rows.Count <= 0 || Convert.ToInt16(dtCheckUpdateNV.Rows[0][0].ToString()) < 0)
                {
                    return false;
                }
                tran.Complete();
                return true;
            }
        }
    }
}
