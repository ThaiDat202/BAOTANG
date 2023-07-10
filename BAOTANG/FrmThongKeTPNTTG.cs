using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOTANG
{
    
    public partial class FrmThongKeTPNTTG : Form
    {
        public FrmThongKeTPNTTG()
        {
            InitializeComponent();
        }

        private void tPNTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tPNTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAOTANGDataSet);
        }

        private void FrmThongKeTPNTTG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.bAOTANGDataSet.TACGIA);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.bAOTANGDataSet.TPNT);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XR_DSTPNT rp = new XR_DSTPNT(cbxIDTG.SelectedValue.ToString());
            rp.lblTieuDe.Text = "DANH SÁCH TPNT CỦA TÁC GIẢ " + cbxIDTG.SelectedValue.ToString().Trim().ToUpper();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
