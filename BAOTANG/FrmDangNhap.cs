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
    public partial class FrmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private int KetNoi_CSDL()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("\nLỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại Tên Server và tên của Publisher, và tên CSDL trong chuỗi kết nối.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            
            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.Connect() == 0) return; //Thử kết nối, nếu k log dc thì return

            //Kết nối thành công thì gán cho DN
            
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String strLenh = "EXEC SP_DangNhap '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh); ;
            if (Program.myReader == null) return;

            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản bạn nhập không có quyền truy cập dữ liệu.\nVui lòng xem lại username và password.", "", MessageBoxButtons.OK);
                return;
            }
            Program.username = Program.myReader.GetString(0);
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmMain.MANV.Text = "Mã NV: " + Program.username;
            Program.frmMain.HOTEN.Text = "Họ Tên: " + Program.mHoten;
            Program.frmMain.NHOM.Text = "Nhóm: " + Program.mGroup;


            Program.frmMain.btnDangNhap.Enabled = false;
            Program.frmMain.btnDangXuat.Enabled = true;
            Program.frmMain.HienThiMenu();

            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDL() == 0) return;
        }
    }
}
