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
    public partial class FrmTaoTaiKhoan : Form
    {
        public FrmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            BAOTANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TAO_LOGIN' table. You can move, or remove it, as needed.
            this.TAO_LOGINTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TAO_LOGINTableAdapter.Fill(this.BAOTANGDataSet.TAO_LOGIN);

            if(Program.mGroup == "ADMIN")
            {
                cmbRole.Items.Insert(0, "EMPLOYEE");
                cmbRole.Items.Insert(1, "MANAGER");
                
                cmbRole.SelectedIndex = 0;
            }
            else
            {
                cmbRole.Items.Insert(0, "EMPLOYEE");
                cmbRole.SelectedIndex = 0;
            }

            
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống !", "", MessageBoxButtons.OK);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống !", "", MessageBoxButtons.OK);
                    txtMatKhau.Focus();
                    return;
                }

                string queryTaoTaiKhoan = "EXEC SP_TaoTaiKhoan '" + txtTenDangNhap.Text.Trim() + "', '"
                                                                    + txtMatKhau.Text.Trim() + "', '"
                                                                    + txtUser.Text.Trim() + "', '"
                                                                    + cmbRole.SelectedItem.ToString().Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(queryTaoTaiKhoan);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Tài khoản đăng nhập đã tồn tại !", "", MessageBoxButtons.OK);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (check == 2)
                {
                    MessageBox.Show("User đã tồn tại !", "", MessageBoxButtons.OK);
                    cmbNV.Focus();
                    return;
                }
                if (check == 0)
                {
                    MessageBox.Show("Tạo tài khoản mới thành công", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản. Vui lòng thử lại !\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
