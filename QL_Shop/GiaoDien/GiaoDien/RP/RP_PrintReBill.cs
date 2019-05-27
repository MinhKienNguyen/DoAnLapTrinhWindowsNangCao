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
    public partial class RP_PrintReBill : DevExpress.XtraEditors.XtraForm
    {
        DataTable iDataSource = null;
        DataTable iDataSourceHeader = null;
        public RP_PrintReBill( DataTable iData, DataTable DataHeader)
        {
            InitializeComponent();
            iDataSource = iData;
            iDataSourceHeader = DataHeader;
        }

        private void RP_HoaDon_Load(object sender, EventArgs e)
        {
            Rpt_PrintReBill rpt = new Rpt_PrintReBill();
            rpt.DataSource = iDataSource;
            rpt.BindHeader(iDataSourceHeader);
            rpt.BindData();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}