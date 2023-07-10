using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraRichEdit.Import.Html;
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
    public partial class FrmBoSuuTap : Form
    {

        int vitri = 0;
        string flag = "";

        public FrmBoSuuTap()
        {
            InitializeComponent();
        }

        private void bOSUUTAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBST.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDataSet);

        }

        

        private void FrmBoSuuTap_Load(object sender, EventArgs e)
        {
            

            BAOTANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'BAOTANGDataSet.BOSUUTAP' table. You can move, or remove it, as needed.
            this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.LOAIDIMUON' table. You can move, or remove it, as needed.
            this.LOAIDIMUONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOAIDIMUONTableAdapter.Fill(this.BAOTANGDataSet.LOAIDIMUON);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.BAOTANGDataSet.NHANVIEN);

            if (Program.mGroup == "ADMIN" || Program.mGroup == "MANAGER")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = true;
            }

            if (bdsBST.Count == 0)
                btnItemDelete.Enabled = false;

        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBST.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctBST.Enabled = false;
            bdsBST.AddNew();
            txtIDBST.Focus();
            //cmbMANV.Focus();
            flag = "add";
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBST.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctBST.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";
        }

        private void btnItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idbst = "";
            idbst = ((DataRowView)bdsBST[bdsBST.Position])["IDBST"].ToString().Trim();

            

            if (MessageBox.Show("Bạn có thật sự muốn xóa bộ sưu tập có mã " + txtIDBST.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string cmd = string.Format("EXEC SP_Delete_Infor_BoSuuTap '" + txtIDBST.Text + "'", idbst);
                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    Program.conn.Close();
                    BOSUUTAPTableAdapter.Fill(BAOTANGDataSet.BOSUUTAP);

                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);
                    bdsBST.Position = bdsBST.Find("IDBST", idbst);
                    return;
                }

                //try
                //{
                //    bdsBST.RemoveCurrent();
                //    this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
                //    this.BOSUUTAPTableAdapter.Update(this.BAOTANGDataSet.BOSUUTAP);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi xóa bộ sưu tập. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                //    this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);
                //    bdsBST.Position = bdsBST.Find("IDBST", idbst);
                //    return;
                //}
            }
            if (bdsBST.Count == 0) btnItemDelete.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBST.CancelEdit();
            if (btnItemAdd.Enabled == false)
                bdsBST.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctBST.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIDBST.Text.Trim() == "")
            {
                MessageBox.Show("Mã bộ sưu tập không được để trống !", "", MessageBoxButtons.OK);
                txtIDBST.Focus();
                return;
            }

            if (txtTenBST.Text.Trim() == "")
            {
                MessageBox.Show("Tên bộ sưu tập không được để trống !", "", MessageBoxButtons.OK);
                txtTenBST.Focus();
                return;
            }


            if (txtHTST.Text.Trim() == "")
            {
                MessageBox.Show("Hình thức sưu tập không được để trống !", "", MessageBoxButtons.OK);
                txtHTST.Focus();
                return;
            }

            if (cmbMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống !", "", MessageBoxButtons.OK);
                cmbMANV.Focus();
                return;
            }

            if (flag == "add")
            {

                string queryCheckIDBST = "EXEC SP_IDBST '" + txtIDBST.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckIDBST);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int checkIDBST = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (checkIDBST == 1)
                {
                    MessageBox.Show("Mã bộ sưu tập này đã tồn tại !", "", MessageBoxButtons.OK);
                    txtIDBST.Focus();
                    return;
                }

                

                try
                {
                    bdsBST.EndEdit();
                    bdsBST.ResetCurrentItem();
                    this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.BOSUUTAPTableAdapter.Update(this.BAOTANGDataSet.BOSUUTAP);
                }
                catch (Exception ex)
                {
                    bdsBST.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm bộ sưu tập.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {

                try
                {
                    bdsBST.EndEdit();
                    bdsBST.ResetCurrentItem();
                    this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.BOSUUTAPTableAdapter.Update(this.BAOTANGDataSet.BOSUUTAP);
                }
                catch (Exception ex)
                {
                    bdsBST.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa bộ sưu tập.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctBST.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }
    }
}
