using DevExpress.XtraPrinting.Export.Pdf;
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
    public partial class FrmTacGia : Form
    {
        int vitri = 0;
        string flag = "";
        public FrmTacGia()
        {
            InitializeComponent();
        }

        private void tACGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDataSet);

        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            BAOTANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.TACGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.TACGIATableAdapter.Fill(this.BAOTANGDataSet.TACGIA);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TPNTTableAdapter.Fill(this.BAOTANGDataSet.TPNT);

            if (Program.mGroup == "ADMIN" || Program.mGroup == "MANAGER")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = true;
            }

            if (bdsTG.Count == 0)
                btnItemDelete.Enabled = false;

            
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTG.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctTG.Enabled = false;
            bdsTG.AddNew();
            txtIDTG.Focus();
            flag = "add";

            
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTG.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctTG.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";

            
        }

        private void btnItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idtg = "";
            idtg = ((DataRowView)bdsTG[bdsTG.Position])["IDTACGIA"].ToString().Trim();


            if (TPNTBindingSource.Count > 0)
            {
                MessageBox.Show("Tác giả bạn muốn xóa đã nằm trong TPNT, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa tác giả có mã " + txtIDTG.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    bdsTG.RemoveCurrent();
                    this.TACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TACGIATableAdapter.Update(this.BAOTANGDataSet.TACGIA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tác giả. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.TACGIATableAdapter.Fill(this.BAOTANGDataSet.TACGIA);
                    bdsTG.Position = bdsTG.Find("IDTG", idtg);
                    return;
                }
            }
            if (bdsTG.Count == 0) btnItemDelete.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.TACGIATableAdapter.Fill(this.BAOTANGDataSet.TACGIA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTG.CancelEdit();
            if (btnItemAdd.Enabled == false)
                bdsTG.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctTG.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            if (txtIDTG.Text.Trim() == "")
            {
                MessageBox.Show("Mã tác giả không được để trống !", "", MessageBoxButtons.OK);
                txtIDTG.Focus();
                return;
            }

            if (txtTenTG.Text.Trim() == "")
            {
                MessageBox.Show("Tên tác giả không được để trống !", "", MessageBoxButtons.OK);
                txtTenTG.Focus();
                return;
            }

            if (dtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được để trống !", "", MessageBoxButtons.OK);
                dtNgaySinh.Focus();
                return;
            }

            if (txtQuocTich.Text.Trim() == "")
            {
                MessageBox.Show("Quốc tịch không được để trống !", "", MessageBoxButtons.OK);
                txtQuocTich.Focus();
                return;
            }

            if (txtThoiDai.Text.Trim() == "")
            {
                MessageBox.Show("Thời đại không được để trống !", "", MessageBoxButtons.OK);
                txtThoiDai.Focus();
                return;
            }

            if (txtPhongCach.Text.Trim() == "")
            {
                MessageBox.Show("Phong cách không được để trống !", "", MessageBoxButtons.OK);
                txtPhongCach.Focus();
                return;
            }

            if (txtLoiDienGiai.Text.Trim() == "")
            {
                MessageBox.Show("Lời diễn giải không được để trống !", "", MessageBoxButtons.OK);
                txtLoiDienGiai.Focus();
                return;
            }

            if (flag == "add")
            {

                string queryCheckIDTG = "EXEC SP_IDTG '" + txtIDTG.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckIDTG);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int checkIDTG = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (checkIDTG == 1)
                {
                    MessageBox.Show("Mã tác giả này đã tồn tại !", "", MessageBoxButtons.OK);
                    txtIDTG.Focus();
                    return;
                }

                try
                {

                    bdsTG.EndEdit();
                    bdsTG.ResetCurrentItem();
                    this.TACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TACGIATableAdapter.Update(this.BAOTANGDataSet.TACGIA);
                }
                catch (Exception ex)
                {
                    bdsTG.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm tác giả.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {

                try
                {
                    bdsTG.EndEdit();
                    bdsTG.ResetCurrentItem();
                    this.TACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TACGIATableAdapter.Update(this.BAOTANGDataSet.TACGIA);
                }
                catch (Exception ex)
                {
                    bdsTG.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa tác giả.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctTG.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }
    }
    
}
