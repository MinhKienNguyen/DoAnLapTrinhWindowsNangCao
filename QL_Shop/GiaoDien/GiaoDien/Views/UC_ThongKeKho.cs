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
    public partial class UC_ThongKeKho : DevExpress.XtraEditors.XtraUserControl
    {
        HangHoaModel _hangHoaModel = new HangHoaModel();
        private DataTable iDataSource = null;

        public UC_ThongKeKho()
        {
            InitializeComponent();
            LoadGridProduct();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }
        #region "các hàm con"
        private void LoadGridProduct()
        {
            DataTable dt = _hangHoaModel.GetDataProduct(txt_mahh.Text);
            iDataSource = dt.Copy();
            bt_xuatexcel.DataSource = iDataSource.Copy();
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void txt_mahh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_timkiem.PerformClick();
            }
        }
    }
}
