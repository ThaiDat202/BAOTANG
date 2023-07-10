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
    public partial class FrmLoaiHinhKhac : Form
    {
        public FrmLoaiHinhKhac()
        {
            InitializeComponent();
        }

        private void FrmLoaiHinhKhac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.VIEW_LOAIHINHKHAC' table. You can move, or remove it, as needed.
            this.vIEW_LOAIHINHKHACTableAdapter.Fill(this.bAOTANGDataSet.VIEW_LOAIHINHKHAC);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.bAOTANGDataSet.TACGIA);
            

        }

        
    }
}
