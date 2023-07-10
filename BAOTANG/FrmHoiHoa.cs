using DevExpress.XtraBars;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAOTANG
{
    public partial class FrmHoiHoa : Form
    {
        string flag = "";

        private FrmLoaiDiMuon loaiDiMuon;
        private FrmLoaiSoHuu loaiSoHuu;
        private FrmMenuLoai menuLoai;

        public FrmHoiHoa()
        {
            InitializeComponent();
            vIEW_HOIHOADataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmHoiHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDataSet.VIEW_HOIHOA' table. You can move, or remove it, as needed.
            this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);


            // TODO: This line of code loads data into the 'bAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.BAOTANGDataSet.TACGIA);

            if (Program.mGroup == "MANAGER" || Program.mGroup == "ADMIN")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = true;
            }
        }

        private void vIEW_HOIHOADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = vIEW_HOIHOADataGridView.SelectedRows[0];
            cmbTenTG.Text = selectedRow.Cells["TACGIA"].Value.ToString();
        }

        //btnItemReadMore
        private void btnItemReadMore_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataGridViewRow selectedRow = vIEW_HOIHOADataGridView.SelectedRows[0];
            String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

            if (Program.Connect() == 0) return;
            
            using (SqlCommand command = new SqlCommand("SP_MENULOAI", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                
                command.Parameters.AddWithValue("@MATPNT", MATPNT);

                // Thêm tham số đầu ra
                SqlParameter check = new SqlParameter("@Check", SqlDbType.Bit);
                check.Direction = ParameterDirection.Output;
                command.Parameters.Add(check);

                
                command.ExecuteNonQuery();

                // Lấy kết quả từ tham số đầu ra
                bool result = (bool)command.Parameters["@Check"].Value;

                if (result == true)
                {
                    FrmLoaiSoHuu frmLSH = new FrmLoaiSoHuu(MATPNT);
                    frmLSH.txtTriGia.ReadOnly = frmLSH.txtTinhTrang.ReadOnly = frmLSH.dtNgaySoHuu.ReadOnly = false;
                    frmLSH.ShowDialog();
                }
                else
                {
                    FrmLoaiDiMuon frmLDM = new FrmLoaiDiMuon(MATPNT);
                    /*frmLDM.cmbBST.Enabled = */frmLDM.dtNgayMuon.ReadOnly = frmLDM.dtNgayTra.ReadOnly = false;
                    frmLDM.ShowDialog();
                }



            }
        }

        //btnItemExit
        private void btnItemExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        //btnItemUndo
        private void btnItemUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            vIEW_HOIHOABindingSource.CancelEdit();
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = vIEW_HOIHOADataGridView.Enabled = btnItemReadMore.Enabled = true;
            btnItemUndo.Enabled = pnlDetail.Enabled = false;
            txtMATPNT.Enabled = true;
        }
        //btnItemReload
        private void btnItemReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.vIEW_HOIHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        //btnItemDelete
        private void btnItemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.Connect() == 0) return;
            try
            {
                DataGridViewRow selectedRow = vIEW_HOIHOADataGridView.SelectedRows[0];
                String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

                string query = "DELETE FROM TPNT WHERE MATPNT = @MATPNT";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MATPNT", MATPNT);

                command.ExecuteNonQuery();

                // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.VIEW_HOIHOA1' table. You can move, or remove it, as needed.
                this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnItemAdd
        private void btnItemAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = vIEW_HOIHOADataGridView.Enabled = false;
            vIEW_HOIHOABindingSource.AddNew();
            txtMATPNT.Focus();
            flag = "add";

        }

        private void btnItemEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = vIEW_HOIHOADataGridView.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            txtMATPNT.Enabled = false;
            flag = "edit";
        }

        private void btnItemSave_ItemClick(object s, ItemClickEventArgs eventArgs)
        {
            if (txtMATPNT.Text.Trim() == "")
            {
                MessageBox.Show("Mã TPNT không được để trống !", "", MessageBoxButtons.OK);
                txtMATPNT.Focus();
                return;
            }
            if (txtTENTPNT.Text.Trim() == "")
            {
                MessageBox.Show("Tên TPNT không được để trống !", "", MessageBoxButtons.OK);
                txtTENTPNT.Focus();
                return;
            }
            if (txtNamSangTac.Text.Trim() == "")
            {
                MessageBox.Show("Năm sáng tác không được để trống !", "", MessageBoxButtons.OK);
                txtNamSangTac.Focus();
                return;
            }
            if (txtChuDe.Text.Trim() == "")
            {
                MessageBox.Show("Chủ đề không được để trống !", "", MessageBoxButtons.OK);
                txtChuDe.Focus();
                return;
            }
            if (cmbTenTG.Text.Trim() == "")
            {
                MessageBox.Show("Tên tác giả không được để trống !", "", MessageBoxButtons.OK);
                cmbTenTG.Focus();
                return;
            }
            if (txtChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Chất liệu không được để trống !", "", MessageBoxButtons.OK);
                txtChatLieu.Focus();
                return;
            }
            if (txtVatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Vật liệu không được để trống !", "", MessageBoxButtons.OK);
                txtVatLieu.Focus();
                return;
            }
            if (txtTruongPhai.Text.Trim() == "")
            {
                MessageBox.Show("Trường phái không được để trống !", "", MessageBoxButtons.OK);
                txtTruongPhai.Focus();
                return;
            }

            if (flag == "add")
            {
                try
                {
                    FrmMenuLoai frmMenu = new FrmMenuLoai();
                    menuLoai = frmMenu;
                    frmMenu.btnLoaiSoHuu.Click += new EventHandler(addLoaiSoHuu);
                    frmMenu.btnLoaiDiMuon.Click += new EventHandler(addLoaiDiMuon);
                    frmMenu.ShowDialog();

                    /* loại sở hữu */
                    // add
                    void addLoaiSoHuu(object sender, EventArgs e)
                    {

                        FrmLoaiSoHuu frmLSH = new FrmLoaiSoHuu();
                        frmLSH.txtMATPNT.Text = txtMATPNT.Text;
                        loaiSoHuu = frmLSH;
                        frmLSH.btnAdd.Click += new EventHandler(saveLoaiSoHuu);

                        frmLSH.btnAdd.Visible = true;
                        frmLSH.btnUpdate.Visible = false;
                        frmLSH.ShowDialog();
                    }
                    // save
                    void saveLoaiSoHuu(object sender, EventArgs e)
                    {
                        if (Program.Connect() == 0) return;
                        try
                        {
                            
                            using (SqlCommand command = new SqlCommand("SP_HOIHOA_ADDLOAISOHUU", Program.conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                
                                command.Parameters.AddWithValue("@MATPNT", txtMATPNT.Text);
                                command.Parameters.AddWithValue("@TENTPNT", txtTENTPNT.Text);
                                command.Parameters.AddWithValue("@NAMSANGTAC", txtNamSangTac.Text);
                                command.Parameters.AddWithValue("@CHUDE", txtChuDe.Text);
                                command.Parameters.AddWithValue("@IDTACGIA", cmbTenTG.SelectedValue.ToString());

                                command.Parameters.AddWithValue("@CHATLIEU", txtChatLieu.Text);
                                command.Parameters.AddWithValue("@VATLIEU", txtVatLieu.Text);
                                command.Parameters.AddWithValue("@TRUONGPHAI", txtTruongPhai.Text);

                                command.Parameters.AddWithValue("@NGAYSOHUU", loaiSoHuu.dtNgaySoHuu.DateTime);
                                command.Parameters.AddWithValue("@TINHTRANG", loaiSoHuu.txtTinhTrang.Text);

                                // Chuyển đổi giá trị sang kiểu money
                                if (decimal.TryParse(loaiSoHuu.txtTriGia.Text, out decimal triGia))
                                {
                                    command.Parameters.AddWithValue("@TRIGIA", triGia);
                                }
                                else
                                {
                                    MessageBox.Show("Giá trị không hợp lệ!");
                                    return;
                                }

                                
                                command.ExecuteNonQuery();

                                loaiSoHuu.Close();
                                menuLoai.Close();


                            }
                            this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);
                            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            vIEW_HOIHOABindingSource.RemoveCurrent();
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    /* loại đi mượn */
                    // add
                    void addLoaiDiMuon(object sender, EventArgs e)
                    {

                        FrmLoaiDiMuon frmLDM = new FrmLoaiDiMuon();
                        frmLDM.txtMATPNT.Text = txtMATPNT.Text;

                        loaiDiMuon = frmLDM;
                        frmLDM.btnAdd.Click += new EventHandler(saveLoaiDiMuon);
                        frmLDM.btnAdd.Visible = true;
                        frmLDM.btnUpdate.Visible = false;
                        frmLDM.ShowDialog();
                    }
                    // save
                    void saveLoaiDiMuon(object sender, EventArgs e)
                    {
                        if (Program.Connect() == 0) return;
                        try
                        {
                            
                            using (SqlCommand command = new SqlCommand("SP_HOIHOA_ADDLOAIDIMUON", Program.conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                
                                command.Parameters.AddWithValue("@MATPNT", txtMATPNT.Text);
                                command.Parameters.AddWithValue("@TENTPNT", txtTENTPNT.Text);
                                command.Parameters.AddWithValue("@NAMSANGTAC", txtNamSangTac.Text);
                                command.Parameters.AddWithValue("@CHUDE", txtChuDe.Text);
                                command.Parameters.AddWithValue("@IDTACGIA", cmbTenTG.SelectedValue.ToString());

                                command.Parameters.AddWithValue("@CHATLIEU", txtChatLieu.Text);
                                command.Parameters.AddWithValue("@VATLIEU", txtVatLieu.Text);
                                command.Parameters.AddWithValue("@TRUONGPHAI", txtTruongPhai.Text);


                                command.Parameters.AddWithValue("@IDBST", loaiDiMuon.cmbBST.SelectedValue.ToString());
                                command.Parameters.AddWithValue("@NGAYMUON", loaiDiMuon.dtNgayMuon.DateTime);
                                command.Parameters.AddWithValue("@NGAYTRA", loaiDiMuon.dtNgayTra.DateTime);

                                
                                command.ExecuteNonQuery();

                                loaiDiMuon.Close();
                                menuLoai.Close();


                            }
                            this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);
                            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            vIEW_HOIHOABindingSource.RemoveCurrent();
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                    btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = vIEW_HOIHOADataGridView.Enabled = true;
                    pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = false;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (flag == "edit")
            {
                try
                {
                    DataGridViewRow selectedRow = vIEW_HOIHOADataGridView.SelectedRows[0];
                    String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

                    if (Program.Connect() == 0) return;
                    
                    using (SqlCommand cmd = new SqlCommand("SP_MENULOAI", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@MATPNT", MATPNT);

                        // Thêm tham số đầu ra
                        SqlParameter check = new SqlParameter("@Check", SqlDbType.Bit);
                        check.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(check);

                       
                        cmd.ExecuteNonQuery();

                        // Lấy kết quả từ tham số đầu ra
                        bool result = (bool)cmd.Parameters["@Check"].Value;

                        if (result == true)
                        {
                            FrmLoaiSoHuu frmLSH = new FrmLoaiSoHuu(MATPNT);
                            loaiSoHuu = frmLSH;
                            frmLSH.btnAdd.Visible = false;
                            frmLSH.btnUpdate.Visible = true;
                            frmLSH.btnUpdate.Click += new EventHandler(updateLoaiSoHuu);
                            frmLSH.ShowDialog();
                        }
                        else
                        {
                            FrmLoaiDiMuon frmLDM = new FrmLoaiDiMuon(MATPNT);
                            frmLDM.btnAdd.Visible = false;
                            frmLDM.btnUpdate.Visible = true;
                            frmLDM.btnUpdate.Click += new EventHandler(updateLoaiDiMuon);
                            frmLDM.ShowDialog();
                        }

                        //hàm để update loại riêng
                        void updateLoaiSoHuu(object sender, EventArgs e)
                        {
                            if (Program.Connect() == 0) return;
                            try
                            {
                                
                                using (SqlCommand command = new SqlCommand("[SP_HOIHOA_UPDATELOAISOHUU]", Program.conn))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                   
                                    command.Parameters.AddWithValue("@MATPNT", txtMATPNT.Text);
                                    command.Parameters.AddWithValue("@TENTPNT", txtTENTPNT.Text);
                                    command.Parameters.AddWithValue("@NAMSANGTAC", txtNamSangTac.Text);
                                    command.Parameters.AddWithValue("@CHUDE", txtChuDe.Text);
                                    command.Parameters.AddWithValue("@IDTACGIA", cmbTenTG.SelectedValue.ToString());

                                    command.Parameters.AddWithValue("@CHATLIEU", txtChatLieu.Text);
                                    command.Parameters.AddWithValue("@VATLIEU", txtVatLieu.Text);
                                    command.Parameters.AddWithValue("@TRUONGPHAI", txtTruongPhai.Text);

                                    command.Parameters.AddWithValue("@NGAYSOHUU", loaiSoHuu.dtNgaySoHuu.DateTime);
                                    command.Parameters.AddWithValue("@TINHTRANG", loaiSoHuu.txtTinhTrang.Text);

                                    // Chuyển đổi giá trị sang kiểu money
                                    if (decimal.TryParse(loaiSoHuu.txtTriGia.Text, out decimal triGia))
                                    {
                                        command.Parameters.AddWithValue("@TRIGIA", triGia);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Giá trị không hợp lệ!");
                                        return;
                                    }

                                    
                                    command.ExecuteNonQuery();

                                    loaiSoHuu.Close();


                                }

                                this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);

                                MessageBox.Show("Update dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                vIEW_HOIHOABindingSource.RemoveCurrent();
                                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                        //hàm update loại mượn
                        void updateLoaiDiMuon(object sender, EventArgs e)
                        {
                            if (Program.Connect() == 0) return;
                            try
                            {
                                
                                using (SqlCommand command = new SqlCommand("SP_HOIHOA_UPDATELOAIDIMUON", Program.conn))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                    
                                    command.Parameters.AddWithValue("@MATPNT", txtMATPNT.Text);
                                    command.Parameters.AddWithValue("@TENTPNT", txtTENTPNT.Text);
                                    command.Parameters.AddWithValue("@NAMSANGTAC", txtNamSangTac.Text);
                                    command.Parameters.AddWithValue("@CHUDE", txtChuDe.Text);
                                    command.Parameters.AddWithValue("@IDTACGIA", cmbTenTG.SelectedValue.ToString());

                                    command.Parameters.AddWithValue("@CHATLIEU", txtChatLieu.Text);
                                    command.Parameters.AddWithValue("@VATLIEU", txtVatLieu.Text);
                                    command.Parameters.AddWithValue("@TRUONGPHAI", txtTruongPhai.Text);

                                    command.Parameters.AddWithValue("@IDBST", loaiDiMuon.cmbBST.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@NGAYMUON", loaiDiMuon.dtNgayMuon.DateTime);
                                    command.Parameters.AddWithValue("@NGAYTRA", loaiDiMuon.dtNgayTra.DateTime);

                                    
                                    command.ExecuteNonQuery();

                                    loaiDiMuon.Close();



                                }

                                this.vIEW_HOIHOATableAdapter.Fill(this.BAOTANGDataSet.VIEW_HOIHOA);

                                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                vIEW_HOIHOABindingSource.RemoveCurrent();
                                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = vIEW_HOIHOADataGridView.Enabled = true;
                    pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = false;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        
    }
}
