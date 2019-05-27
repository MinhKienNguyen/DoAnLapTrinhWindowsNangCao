namespace GiaoDien.RP
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
       private object mIDto;
        public object GetIDto
        {
            get
            {
                return mIDto;
            }
            set
            {
                mIDto = value;
            }
        }

        public virtual void BindData()
        {
            return;
        }

        public virtual void BindHeader(object dto)
        {
            return;
        }

    }
}
