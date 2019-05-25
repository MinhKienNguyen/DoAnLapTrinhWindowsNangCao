using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GiaoDien.Models;

namespace GiaoDien.Views
{
    public partial class UC_PhieuDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable iGirDataSource = null;
        PhieuDatModel _phieuDatModel = new PhieuDatModel();
        public UC_PhieuDatHang()
        {
            InitializeComponent();
            LoadGridKhoHang();
        }

        private void UC_PhieuDatHang_Load(object sender, EventArgs e)
        {

        }
        #region "Các hàm con"
        private void LoadGridKhoHang()
        {
            DataTable dt = _phieuDatModel.GetKhoHang();
            this.iGirDataSource = dt.Copy();
            gridkho.DataSource = this.iGirDataSource.Copy();
        }
        #endregion
    }

}

