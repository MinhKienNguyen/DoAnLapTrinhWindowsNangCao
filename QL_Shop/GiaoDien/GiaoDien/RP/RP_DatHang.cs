using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GiaoDien.RP
{
    public partial class RP_DatHang : DevExpress.XtraEditors.XtraForm
    {
        DataTable iDataSource = null;
        DataTable dtHeader = null;
        public RP_DatHang( DataTable iData, DataTable dt)
        {
            InitializeComponent();
            iDataSource = iData;
            dtHeader = dt;
        }

     
        private void RP_ThongKeKho_Load(object sender, EventArgs e)
        {

            Rpt_DatHang rpt_PrintPacking = new Rpt_DatHang();
            rpt_PrintPacking.DataSource = iDataSource;
            rpt_PrintPacking.BindHeader(dtHeader);
            rpt_PrintPacking.BindData();
            documentViewer1.PrintingSystem = rpt_PrintPacking.PrintingSystem;
            rpt_PrintPacking.CreateDocument();
        }
    }
}