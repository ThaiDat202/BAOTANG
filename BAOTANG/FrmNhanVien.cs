using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOTANG
{
    public partial class FrmNhanVien : Form
    {
        int vitri = 0;
        string flag = "";
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDataSet);

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            BAOTANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'bAOTANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.BAOTANGDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.BOSUUTAP' table. You can move, or remove it, as needed.
            this.BOSUUTAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);

            if (Program.mGroup == "ADMIN")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = true;
            }

            else if (Program.mGroup == "MANAGER")
            {
                btnItemAdd.Enabled = btnItemDelete.Enabled = true;
            }

            if (bdsNV.Count == 0)
                btnItemDelete.Enabled = false;

            cmbChucVu.Items.Insert(0, "Nhân Viên");
            cmbChucVu.Items.Insert(1, "Quản Lý");
            cmbChucVu.Items.Insert(2, "Admin");

            
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = cmbChucVu.Visible = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = false;
            bdsNV.AddNew();
            txtMANV.Focus();
            flag = "add";

            cmbChucVu.SelectedIndex = 0;

            
            
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";

            
        }

        private void btnItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = "";
            manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString().Trim();

            if (manv == Program.username.ToString().Trim())
            {
                MessageBox.Show("Bạn không thể xóa bản thân!.\nVui lòng chọn nhân viên khác để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            

            if (BOSUUTAPBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên bạn muốn xóa đã nằm trong bộ sưu tập, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có mã " + txtMANV.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = string.Format("EXEC SP_Delete_Infor_NhanVien '" + txtMANV.Text + "'", manv);
                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    Program.conn.Close();
                    NHANVIENTableAdapter.Fill(BAOTANGDataSet.NHANVIEN);

                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //try
                //{

                //    bdsNV.RemoveCurrent();
                //    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                //    this.NHANVIENTableAdapter.Update(this.BAOTANGDataSet.NHANVIEN);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                //    this.NHANVIENTableAdapter.Fill(this.BAOTANGDataSet.NHANVIEN);
                //    bdsNV.Position = bdsNV.Find("MANV", manv);
                //    return;
                //}
            }
            if (bdsNV.Count == 0) btnItemDelete.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.BAOTANGDataSet.NHANVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnItemAdd.Enabled == false)
                bdsNV.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;

            if (Program.mGroup == "MANAGER")
            {
                btnItemEdit.Enabled = btnItemDelete.Enabled = false;
            }
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            if (!ValidatePhoneNumber(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng ở Việt Nam.\nHãy chắc chắn SDT có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "" || txtCMND.Text.Trim().Length != 9)
            {
                MessageBox.Show("CMND không được để trống ! \nCMND phải đủ 9 số", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            

            if (flag == "add")
            {
                if (Program.mGroup == "MANAGER")
                {
                    if (cmbChucVu.SelectedIndex == 1 || cmbChucVu.SelectedIndex == 2)
                    {
                        MessageBox.Show("Bạn không có quyền tạo chức vụ cao hơn hoặc bằng bản thân!", "Xác nhận", MessageBoxButtons.OK);
                        return;
                    }
                }


                string queryCheckMANV = "EXEC SP_MANV '" + txtMANV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckMANV);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int checkMANV = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (checkMANV == 1)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại !", "", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }

                string queryCheckCMND = "EXEC SP_CMND '" + txtCMND.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckCMND);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int checkCMND = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (checkCMND == 1)
                {
                    MessageBox.Show("CMND này đã tồn tại !", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }

                string queryCheckSDT = "EXEC SP_SDT '" + txtSDT.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckSDT);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int checkSDT = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (checkSDT == 1)
                {
                    MessageBox.Show("SDT này đã tồn tại !", "", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return;
                }


                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.BAOTANGDataSet.NHANVIEN);
                }
                catch (Exception ex)
                {
                    bdsNV.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {
                string currentMANV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString().Trim();
                string currentChucVu = ((DataRowView)bdsNV[bdsNV.Position])["CHUCVU"].ToString().Trim();

                if (Program.mGroup == "ADMIN" && currentMANV == Program.username && cmbChucVu.SelectedIndex != 2)
                {
                    MessageBox.Show("Bạn không được phép chuyển chức vụ bản thân sang chức vụ khác!", "Xác nhận", MessageBoxButtons.OK);
                    return;
                }



                //if (Program.mGroup == "MANAGER" && currentChucVu == "Admin")
                //{
                //    MessageBox.Show("Bạn không có quyền sửa thông tin của người dùng có quyền ADMIN!", "Xác nhận", MessageBoxButtons.OK);
                //    return;
                //}

                //if (Program.mGroup == "MANAGER" && currentMANV == Program.username && cmbChucVu.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Bạn không được phép chuyển chức vụ bản thân sang chức vụ khác!", "Xác nhận", MessageBoxButtons.OK);
                //    return;
                //}

                //if (Program.mGroup == "MANAGER")
                //{

                //    if (cmbChucVu.SelectedIndex != 0)
                //    {
                //        MessageBox.Show("Bạn không có quyền sửa chức vụ cao hơn hoặc bằng bản thân!", "Xác nhận", MessageBoxButtons.OK);
                //        return;
                //    }
                //}

                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.BAOTANGDataSet.NHANVIEN);
                }
                catch (Exception ex)
                {
                    bdsNV.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
            if (Program.mGroup == "MANAGER")
            {
                btnItemEdit.Enabled = btnItemDelete.Enabled = false;
            }
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Pattern for validating phone number in Vietnam
            string pattern = @"^(0[2-9]|84[2-9])(\d{8}|\d{9})$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the phone number matches the pattern
            Match match = regex.Match(phoneNumber);

            // Return true if there is a match, indicating a valid phone number
            return match.Success;
        }
    }
}
