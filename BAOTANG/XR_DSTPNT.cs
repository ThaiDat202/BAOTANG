using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BAOTANG
{
    public partial class XR_DSTPNT : DevExpress.XtraReports.UI.XtraReport
    {
        public XR_DSTPNT()
        {
            
        }
        public XR_DSTPNT (string IDTG)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = IDTG;
            this.sqlDataSource1.Fill();
        }
    }
}
