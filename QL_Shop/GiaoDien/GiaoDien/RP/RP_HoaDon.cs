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
    public partial class RP_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        DataTable iDataSource = null;
        public RP_HoaDon( DataTable iData)
        {
            InitializeComponent();
            iDataSource = iData;
        }

        private void RP_HoaDon_Load(object sender, EventArgs e)
        {
            Rpt_PrintPacking rpt_PrintPacking = new Rpt_PrintPacking();
            rpt_PrintPacking.DataSource = iDataSource;
            rpt_PrintPacking.BindData();
            documentViewer1.PrintingSystem = rpt_PrintPacking.PrintingSystem;
            rpt_PrintPacking.CreateDocument();
        }
    }
}