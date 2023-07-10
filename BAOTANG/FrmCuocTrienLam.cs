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
    public partial class FrmCuocTrienLam : Form
    {
        public FrmCuocTrienLam()
        {
            InitializeComponent();
        }

        private void FrmCuocTrienLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.bAOTANGDataSet.TPNT);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.CUOCTRIENLAM' table. You can move, or remove it, as needed.
            this.cUOCTRIENLAMTableAdapter.Fill(this.bAOTANGDataSet.CUOCTRIENLAM);
            if (Program.mGroup == "ADMIN" || Program.mGroup == "MANAGER")
            {
                btnSua.Enabled = btnXoa.Enabled = true;
            }
            string IDTL = ((DataRowView)cUOCTRIENLAMBindingSource[0])["IDCTL"].ToString();
            if (Program.Connect() == 0) return;
            //lấy mã triển lãm bảng TPNT
            using (SqlCommand command = new SqlCommand("SP_GETTPNTBYIDCTL", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Truyền các tham số nếu có
                command.Parameters.AddWithValue("@IDTrienLam", IDTL);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    //Gắn data vào bảng TPNT
                    gcnTPNT.DataSource = dataTable;


                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cUOCTRIENLAMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cUOCTRIENLAMTableAdapter.Fill(this.bAOTANGDataSet.CUOCTRIENLAM);
                gcnCTL_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pcnDetail.Enabled = btnGhi.Enabled = true;
            txtIDCLT.Enabled = false;
        }

        private void gcnCTL_Click(object sender, EventArgs e)
        {
            int i = gridView1.FocusedRowHandle;
            string IDTL = ((DataRowView)cUOCTRIENLAMBindingSource[i])["IDCTL"].ToString();
            if (Program.Connect() == 0) return;
            //lấy mã triển lãm bảng TPNT
            using (SqlCommand command = new SqlCommand("SP_GETTPNTBYIDCTL", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Truyền các tham số nếu có
                command.Parameters.AddWithValue("@IDTrienLam", IDTL);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    //Gắn data vào bảng TPNT
                    gcnTPNT.DataSource = dataTable;


                }


            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.Connect() == 0) return;
            try
            {
                string query_1 = "DELETE FROM CT_CUOCTRIENLAM WHERE IDCTL = @IDTL";
                SqlCommand command_1 = new SqlCommand(query_1, Program.conn);
                command_1.Parameters.AddWithValue("@IDTL", txtIDCLT.Text);

                command_1.ExecuteNonQuery();
                string query_2 = "DELETE FROM CUOCTRIENLAM WHERE IDCTL = @IDTL";
                SqlCommand command_2 = new SqlCommand(query_2, Program.conn);
                command_2.Parameters.AddWithValue("@IDTL", txtIDCLT.Text);

                command_2.ExecuteNonQuery();

                //load lại dữ liệu
                btnReload_ItemClick(sender, e);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.Connect() == 0) return;
            try
            {
                if (string.IsNullOrWhiteSpace(txtIDCLT.Text) || string.IsNullOrWhiteSpace(txtTenTL.Text) || string.IsNullOrWhiteSpace(deFrom.Text) || string.IsNullOrWhiteSpace(deTo.Text))
                {
                    MessageBox.Show("Không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    string query = "UPDATE CUOCTRIENLAM SET TENTRIENLAM = @TENTL, NGAYBATDAU = @NgayBD, NGAYKETTHUC = @NgayKT WHERE IDCTL = @IDTL";
                    SqlCommand command = new SqlCommand(query, Program.conn);
                    command.Parameters.AddWithValue("@TENTL", txtTenTL.Text);
                    command.Parameters.AddWithValue("@NgayBD", deFrom.DateTime);
                    command.Parameters.AddWithValue("@NgayKT", deTo.DateTime);
                    command.Parameters.AddWithValue("@IDTL", txtIDCLT.Text);


                    command.ExecuteNonQuery();

                    //load lại dữ liệu
                    btnReload_ItemClick(sender, e);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGhi.Enabled = pcnDetail.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
