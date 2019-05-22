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
    public partial class UC_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        BanHangModel _BanHangModel = new BanHangModel();
        public UC_BanHang()
        {
            InitializeComponent();
            txt_mahd.Text = Getincreaseinvoicecode();
        }
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            txt_matkh.Enabled = false;
            txt_makh.Enabled = false;
            txt_diachi.Enabled = false;
            txt_sdt.Enabled = false;
            txt_tenkh.Enabled = false;

        }
 
        private void chek_thanhvien_CheckedChanged(object sender, EventArgs e)
        {
            if(chek_thanhvien.Checked==true)
            {
                txt_matkh.Enabled = true;
                txt_makh.Enabled = true;
                txt_diachi.Enabled = true;
                txt_sdt.Enabled = true;
                txt_tenkh.Enabled = true;
            }
            else
            {
                txt_matkh.Enabled = false;
                txt_makh.Enabled = false;
                txt_diachi.Enabled = false;
                txt_sdt.Enabled = false;
                txt_tenkh.Enabled = false;
            }
         
        }
        #region "các hàm con"
        /// <summary>
        /// tăng mã hóa đơn
        /// 
        /// </summary>
        /// <returns></returns>
        public string Getincreaseinvoicecode()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _BanHangModel.Getsell("HD0000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "HD0000" + i;
                    break;
                }
            }
            return strCode;
        }

        #endregion
    }
}
