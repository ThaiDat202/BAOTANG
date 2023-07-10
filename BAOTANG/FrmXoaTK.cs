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
    public partial class FrmXoaTK : Form
    {
        public FrmXoaTK()
        {
            InitializeComponent();
        }

        private void FrmXoaTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.XOA_LOGIN' table. You can move, or remove it, as needed.
            this.xOA_LOGINTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xOA_LOGINTableAdapter.Fill(this.bAOTANGDataSet.XOA_LOGIN);

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (xOA_LOGINBindingSource.Count == 0) { return; }
            string loginname = "";
            string username = "";
            DataRowView drv = (DataRowView)xOA_LOGINBindingSource[xOA_LOGINBindingSource.Position];
            username = drv["MANV"].ToString().Trim();
            String TimLoginName = "Lay_Login_Tu_Username '" + username + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(TimLoginName);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            loginname = Program.myReader.GetValue(0).ToString();

            Program.myReader.Close();
            string truyvan = "EXEC SP_XoaLogin" + "'" + loginname + "','" + username + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            Program.myReader.Close();
            MessageBox.Show("Xóa tài khoản của nhân viên có mã " + username + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.xOA_LOGINTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xOA_LOGINTableAdapter.Fill(this.bAOTANGDataSet.XOA_LOGIN);
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
