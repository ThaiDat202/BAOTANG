using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;
//using Microsoft.SqlServer.Management.Common;
//using Microsoft.SqlServer.Management.Smo;



namespace BAOTANG
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        public FrmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void HienThiMenu()
        {

            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên: " + Program.mHoten.Trim('\r', '\n');//remove newlines from both sides of a string
            NHOM.Text = "Nhóm: " + Program.mGroup;

            //phân quyền
            if (Program.mGroup == "ADMIN")
            {
                Program.frmMain.rbNV.Visible = Program.frmMain.rbNghiepVu.Visible = Program.frmMain.rbTK.Visible = Program.frmMain.rbCaiDat.Visible = true;
                Program.frmMain.btnTaoTK.Enabled = Program.frmMain.btnXoaTK.Enabled = Program.frmMain.btnDangXuat.Enabled = true;
            }
            else if(Program.mGroup == "MANAGER")
            {
                Program.frmMain.rbNV.Visible = Program.frmMain.rbNghiepVu.Visible = Program.frmMain.rbTK.Visible = true;
                Program.frmMain.btnTaoTK.Enabled = Program.frmMain.btnDangXuat.Enabled = true;
            }
            else
            {
                Program.frmMain.rbNghiepVu.Visible = Program.frmMain.rbTK.Visible = true;
                Program.frmMain.btnDangXuat.Enabled = true;
            }

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FrmTaoTaiKhoan f = new FrmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                Program.mloginDN = "";
                Program.passwordDN = "";
                this.MANV.Text = "";
                this.HOTEN.Text = "";
                this.NHOM.Text = "";
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }

                Program.frmMain.rbNV.Visible = Program.frmMain.rbNghiepVu.Visible = Program.frmMain.rbTK.Visible = Program.frmMain.rbCaiDat.Visible = false;
                Program.frmMain.btnDangNhap.Enabled = true;
                Program.frmMain.btnTaoTK.Enabled = Program.frmMain.btnXoaTK.Enabled = Program.frmMain.btnDangXuat.Enabled = false;
            }
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmNhanVien f = new FrmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDKTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDieuKhacTacTuong));
            if (frm != null) frm.Activate();
            else
            {
                FrmDieuKhacTacTuong f = new FrmDieuKhacTacTuong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHoiHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmHoiHoa));
            if (frm != null) frm.Activate();
            else
            {
                FrmHoiHoa f = new FrmHoiHoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLoaiHinhKhac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLoaiHinhKhac));
            if (frm != null) frm.Activate();
            else
            {
                FrmLoaiHinhKhac f = new FrmLoaiHinhKhac();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmCuocTrienLam));
            if (frm != null) frm.Activate();
            else
            {
                FrmCuocTrienLam f = new FrmCuocTrienLam();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBST_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmBoSuuTap));
            if (frm != null) frm.Activate();
            else
            {
                FrmBoSuuTap f = new FrmBoSuuTap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTacGia));
            if (frm != null) frm.Activate();
            else
            {
                FrmTacGia f = new FrmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongKeTPNTTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmThongKeTPNTTG));
            if (frm != null) frm.Activate();
            else
            {
                FrmThongKeTPNTTG f = new FrmThongKeTPNTTG();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongKeTPNTCTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmThongKeTPNTCTL));
            if (frm != null) frm.Activate();
            else
            {
                FrmThongKeTPNTCTL f = new FrmThongKeTPNTCTL();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnAddCTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmThemCTL));
            if (frm != null) frm.Activate();
            else
            {
                FrmThemCTL f = new FrmThemCTL();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
            openFileDialog.Title = "Chọn tệp tin backup";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                    
                //    string filePath = openFileDialog.FileName;

                //    // Tiến hành khôi phục dữ liệu từ tệp tin được chọn
                //    // Viết code ở đây để thực hiện việc khôi phục dữ liệu từ tệp tin
                //    // Ví dụ: sử dụng SQL Server Management Objects (SMO) để khôi phục

                //    // Ví dụ: SMO Restore
                //    ServerConnection connection = new ServerConnection("DESKTOP-H0GEECA\\SERVER");
                //    Server server = new Server(connection);

                //    Restore restore = new Restore();
                //    restore.Database = "BAOTANG";
                //    restore.Action = RestoreActionType.Database;
                //    restore.Devices.AddDevice(filePath, DeviceType.File);
                //    restore.ReplaceDatabase = true;

                //    string dataFilePath = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SERVER\MSSQL\DATA\BAOTANG.mdf";
                //    string logFilePath = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SERVER\MSSQL\DATA\BAOTANG_log.ldf";

                //    RelocateFile dataFile = new RelocateFile();
                //    dataFile.LogicalFileName = "BAOTANG";
                //    dataFile.PhysicalFileName = dataFilePath;

                //    RelocateFile logFile = new RelocateFile();
                //    logFile.LogicalFileName = "BAOTANG_log";
                //    logFile.PhysicalFileName = logFilePath;

                //    restore.RelocateFiles.Add(dataFile);
                //    restore.RelocateFiles.Add(logFile);

                //    restore.SqlRestore(server);

                //    // Sau khi khôi phục xong, thông báo cho người dùng
                //    MessageBox.Show("Đã khôi phục dữ liệu từ tệp tin backup.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //catch (SqlException ex)
                //{
                //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    Close();
                //}

            }
        }

        //private void btnLoaiSoHuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Form frm = this.CheckExists(typeof(FrmLoaiSoHuu));
        //    if (frm != null) frm.Activate();
        //    else
        //    {
        //        FrmLoaiSoHuu f = new FrmLoaiSoHuu();
        //        f.MdiParent = this;
        //        f.Show();

        //    }
        //}

        //private void btnLoaiDiMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Form frm = this.CheckExists(typeof(FrmLoaiDiMuon));
        //    if (frm != null) frm.Activate();
        //    else
        //    {
        //        FrmLoaiDiMuon f = new FrmLoaiDiMuon();
        //        f.MdiParent = this;
        //        f.Show();

        //    }
        //}

        private void btnXoaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmXoaTK));
            if (frm != null) frm.Activate();
            else
            {
                FrmXoaTK f = new FrmXoaTK();
                f.MdiParent = this;
                f.Show();

            }
        }
    }
}
