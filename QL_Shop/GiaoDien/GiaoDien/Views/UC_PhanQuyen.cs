﻿using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        PhanQuyenModel _phanQuyenModel = new PhanQuyenModel();
        private DataTable iDataSourceNhomNgDung = null;
        private DataTable iGridDataSourceNgDungNhomNgD = null;
        public UC_PhanQuyen()
        {
            InitializeComponent();
            LoadGridNhomND();
            colCoQuyen.Visible = true;
        }

        public void LoadGridNhomND()
        {
            iDataSourceNhomNgDung = _phanQuyenModel.GetDataNhomND();
            grdNhomND.DataSource = iDataSourceNhomNgDung.Copy();
        }

        public void LoadGridNgDungNhomNgDung()
        {
            if(this.iDataSourceNhomNgDung == null || this.iDataSourceNhomNgDung.Rows.Count <= 0)
            {
                XtraMessageBox.Show(Commons.NoData, Commons.Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRowView row = (DataRowView)grdViewNhomND.GetRow(grdViewNhomND.GetSelectedRows()[0]);
            iGridDataSourceNgDungNhomNgD = _phanQuyenModel.GetDataNhomMangHinh(row["MaNhom"].ToString());
            grdNgDungNhomNgD.DataSource = iGridDataSourceNgDungNhomNgD.Copy();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(CheckUpdatePhanQuyen())
            {
                XtraMessageBox.Show(Commons.LuuThanhCong, Commons.Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show(Commons.LuuBai, Commons.Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CheckUpdatePhanQuyen()
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
           new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                for (int i = 0; i < grdViewNgDungNhomNgDung.DataRowCount; i++)
                {
                    int flag = -1;
                    if (grdViewNgDungNhomNgDung.GetRowCellValue(i, "CoQuyen").ToString() == "True")
                    {
                        string mamh = iGridDataSourceNgDungNhomNgD.Rows[i]["MaManHinh"].ToString();
                        DataRowView row = (DataRowView)grdViewNhomND.GetRow(grdViewNhomND.GetSelectedRows()[0]);
                        flag = 1;
                        string manhom = row["MaNhom"].ToString();
                        DataTable dtCheckUpdate = _phanQuyenModel.UpdatePhanQuyen(manhom.ToString(), mamh.ToString(), flag);
                        if (dtCheckUpdate.Rows.Count <= 0 || dtCheckUpdate == null)
                        {
                            return false;
                        }
                    }
                    if (grdViewNgDungNhomNgDung.GetRowCellValue(i, "CoQuyen").ToString() == "False")
                    {
                        string mamh = iGridDataSourceNgDungNhomNgD.Rows[i]["MaManHinh"].ToString();
                        DataRowView row = (DataRowView)grdViewNhomND.GetRow(grdViewNhomND.GetSelectedRows()[0]);

                        string manhom = row["MaNhom"].ToString();
                        DataTable dtCheckUpdate = _phanQuyenModel.UpdatePhanQuyen(manhom.ToString(), mamh.ToString(), flag);
                        if (dtCheckUpdate.Rows.Count <= 0 || dtCheckUpdate == null)
                        {
                            return false;
                        }
                    }
                }
                tran.Complete();
                return true;
            }
        }

        private void grdViewNhomND_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadGridNgDungNhomNgDung();
        }
    }
}
