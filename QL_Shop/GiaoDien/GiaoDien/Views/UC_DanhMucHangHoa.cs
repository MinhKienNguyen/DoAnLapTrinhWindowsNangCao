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
using GiaoDien.DoMain;
using GiaoDien.Unity;

namespace GiaoDien.Views
{
    public partial class UC_DanhMucHangHoa : DevExpress.XtraEditors.XtraUserControl
    {

        HangHoaModel _hangHoaModel = new HangHoaModel();
        DataTable iDataSource = null;
        UnityClass _unityClass = new UnityClass();
        public UC_DanhMucHangHoa()
        {
            InitializeComponent();
        }

       
        private void LoadGridProduct()
        {
            DataTable dt = _hangHoaModel.GetDataProduct(txtMaHH.Text, txtTenHH.Text);
            iDataSource = dt.Copy();
            grdHangHoa.DataSource = iDataSource.Copy();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }

        private void tileViewHangHoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)tileViewHangHoa.GetRow(tileViewHangHoa.GetSelectedRows()[0]);
            txtMaHH.Text = row[0].ToString();
            txtTenHH.Text = row[1].ToString();
            txtSize.Text = row[10].ToString();        
            txtmausat.Text = row[8].ToString();
            txtGia.Text = row[3].ToString();
            txtdvt.Text = row[11].ToString();
            txtlhang.Text = row[5].ToString();
            txtSoLuong.Text = row[6].ToString();
            DataTable dt = _hangHoaModel.GetImage(txtMaHH.Text);       
          //  byte[] arrpic = (new UnicodeEncoding()).GetBytes(dt.Rows[0]["HinhAnh"].ToString());
           // pichinh.Image = _unityClass.CovertBytetoImage(arrpic);
        }


    }
}
