﻿using DevExpress.XtraEditors;
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
    public partial class UC_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        UnityClass _unityClass = new UnityClass();
        private DataTable dtEmployess = null;
        public UC_NhanVien()
        {
            InitializeComponent();
            LoadComboboxDuty();
            txtMaNV.Text = EmployessCde();
            LoadGridEmployess();
             txtMaNV.ReadOnly = true;
        }

        /// <summary>
        /// btnChon_Click -- chọn hình ảnh để lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChon_Click(object sender, EventArgs e)
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

        /// <summary>
        /// LoadGridEmployess -- Load dữ liệu nhân viên lên gridview nhân viên
        /// </summary>
        public void LoadGridEmployess()
        {
            DataTable dt = _nhanvienModel.GetEmployees(txtEmployessName.Text);
            this.dtEmployess = dt.Copy();
            grdNhanVien.DataSource = dtEmployess;
        }

        /// <summary>
        /// EmployessCde -- lấy mã nhân viên tự tăng
        /// </summary>
        /// <returns></returns>
        public string EmployessCde()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _nhanvienModel.GetEmployessCde("NV0000" + i).Rows.Count; 
                if (dtCout == 0)
                {
                    strCode = "NV0000" + i;
                    break;
                }
            }
            return strCode;
        }

        /// <summary>
        /// LoadComboboxDuty -- Load combobox chức vụ
        /// </summary>
        public void LoadComboboxDuty()
        {
            DataTable dtDuty = _nhanvienModel.GetComboboxDuty();
            lkuChucVu.Properties.DataSource = dtDuty.Copy();
            lkuChucVu.Properties.DisplayMember = "TenNhom";
            lkuChucVu.Properties.ValueMember = "MaNhom";
        }

        /// <summary>
        /// btnLuu_Click -- thực hiện chức năng lưu nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(imgChonAnh.ImageLocation))
                {
                    XtraMessageBox.Show(Commons.ChooseImage, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                else if (string.IsNullOrEmpty(txtUser.Text))
                {
                    XtraMessageBox.Show(Commons.WriteUset, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                else if (string.IsNullOrEmpty(txtPass.Text))
                {
                    XtraMessageBox.Show(Commons.WritePass, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                else if (string.IsNullOrEmpty(lkuChucVu.EditValue.ToString()))
                {
                    XtraMessageBox.Show(Commons.ChonQuyen, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                if (InsertEmployess())
                {
                    XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                    txtMaNV.Text = EmployessCde();
                    LoadGridEmployess();
                    return;
                }
                XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            
        }


        private bool InsertEmployess()
        {
            try
            {
                using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
                {
                    DataTable dtCheckInsert;

                    byte[] image = _unityClass.CoverFilltoByte(imgChonAnh.ImageLocation);
                    if (rdoNam.Checked == true)
                    {
                        dtCheckInsert = _nhanvienModel.InsertEmployess(txtMaNV.Text, txtTenNV.Text, rdoNam.Text, txtDiaChi.Text, txtUser.Text, txtPass.Text, txtSDT.Text, image, lkuChucVu.EditValue.ToString());
                    }
                    else
                    {
                        dtCheckInsert = _nhanvienModel.InsertEmployess(txtMaNV.Text, txtTenNV.Text, rdoNu.Text, txtDiaChi.Text, txtUser.Text, txtPass.Text, txtSDT.Text, image, lkuChucVu.EditValue.ToString());
                    }
                    if (dtCheckInsert.Rows.Count <= 0 || dtCheckInsert == null)
                    {
                        return false;
                    }
                    DataTable dtCheckUpdate;
                    dtCheckUpdate = _nhanvienModel.UpdateNhomND(txtUser.Text, lkuChucVu.EditValue.ToString());
                    if (dtCheckUpdate.Rows.Count <= 0 || dtCheckUpdate == null)
                    {
                        return false;
                    }
                    tran.Complete();
                }
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            return true;
        }

        /// <summary>
        /// btnThem_Click -- làm mới lại tất cả các control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in this.groupThongtinnhanvien.Controls)
                {
                    if (item.GetType() == typeof(TextEdit) || item.GetType() == typeof(LookUpEdit) || item.GetType() == typeof(Image))
                    {
                        item.Text = string.Empty;
                    }
                }
                txtMaNV.Text = EmployessCde();
                LoadComboboxDuty();
                Image image = Image.FromFile(@"C:\Users\HUY\Desktop\ShopThoiTrang\DoAnLapTrinhWindowsNangCao\QL_Shop\GiaoDien\GiaoDien\Resources\bb87c06b8cb8fad5ffe9abab11679fae.jpg");
                imgChonAnh.Image = image;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)tileViewNhanVien.GetRow(tileViewNhanVien.GetSelectedRows()[0]);
                bool checkDelete = _nhanvienModel.DeleteEmployess(row["MaNhanVien"].ToString(), row["Username"].ToString());
                if (checkDelete == false)
                {
                    XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
                XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
                LoadGridEmployess();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridEmployess();
        }

        private void tileViewNhanVien_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)tileViewNhanVien.GetRow(tileViewNhanVien.GetSelectedRows()[0]);
                txtMaNV.Text = row[0].ToString();
                txtTenNV.Text = row[1].ToString();
                txtSDT.Text = row[6].ToString();
                txtDiaChi.Text = row[3].ToString();
                txtUser.Text = row[4].ToString();
                txtPass.Text = row[5].ToString();
                if (row[2].ToString().Trim() == Set.Nam)
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = true;
                }
                lkuChucVu.Properties.NullText = row[9].ToString();
                if (row[7] == null || string.IsNullOrEmpty(row[7].ToString()))
                    return;
                byte[] data = new byte[0];
                data = (byte[])(row[7]);
                MemoryStream ms = new MemoryStream(data);
                imgChonAnh.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Commons.Notify, MessageBoxButtons.OK);
            }
            
        }

        private void txtEmployessName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();

            }
        }
    }
}
