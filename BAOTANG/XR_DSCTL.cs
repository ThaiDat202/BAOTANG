using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BAOTANG
{
    public partial class XR_DSCTL : DevExpress.XtraReports.UI.XtraReport
    {
        public XR_DSCTL()
        {
            
        }

        public XR_DSCTL(string tuNgay,string denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Fill();
        }
        
    }
}
