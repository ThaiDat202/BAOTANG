using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOTANG
{
    public partial class FrmThongKeTPNTCTL : Form
    {
        public FrmThongKeTPNTCTL()
        {
            InitializeComponent();
        }

        private void tPNTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tPNTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAOTANGDataSet);

        }

        private void FrmThongKeTPNTCTL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.bAOTANGDataSet.TPNT);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (deFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian bắt đầu !", "", MessageBoxButtons.OK);
                deFrom.Focus();
                return;
            }
            if (deTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc !", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            string from = ((DateTime)deFrom.EditValue).ToString("yyyyMMdd");
            string to = ((DateTime)deTo.EditValue).AddDays(1).ToString("yyyyMMdd");
            XR_DSCTL rp = new XR_DSCTL(from, to);
            rp.lblTIeuDe.Text = "DANH SÁCH CÁC CUỘC TRIỂN LÃM " + deFrom.Text.ToString().Trim() + " ĐẾN " + deTo.Text.ToString().Trim();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
