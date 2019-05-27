using GiaoDien.Models;
using GiaoDien.Unity;
using System;
using System.Data;

namespace GiaoDien.Views
{
    public partial class UC_MangHinh : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable dtMangHinh = null;
        MangHinhModel _mangHinhModel= new MangHinhModel();
        UnityClass _unityClass = new UnityClass();
        public UC_MangHinh()
        {
            InitializeComponent();
        }

        public void LoadGridData()
        {
            DataTable dt = _mangHinhModel.GetData(txtMa.Text);
            this.dtMangHinh = dt.Copy();
            grdMangHinh.DataSource = dtMangHinh;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}
