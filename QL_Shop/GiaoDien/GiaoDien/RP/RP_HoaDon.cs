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
        DataTable iDataSourceHeader = null;
        public RP_HoaDon( DataTable iData, DataTable DataHeader)
        {
            InitializeComponent();
            iDataSource = iData;
            iDataSourceHeader = DataHeader;
        }

        private void RP_HoaDon_Load(object sender, EventArgs e)
        {
            Rpt_HoaDon rpt = new Rpt_HoaDon();
            rpt.DataSource = iDataSource;
            rpt.BindHeader(iDataSourceHeader);
            rpt.BindData();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}