using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
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
    public partial class FrmThemCTL : Form
    {
        public FrmThemCTL()
        {
            InitializeComponent();
        }

        private void FrmThemCTL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.bAOTANGDataSet.TPNT);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.CUOCTRIENLAM' table. You can move, or remove it, as needed.
            this.cUOCTRIENLAMTableAdapter.Fill(this.bAOTANGDataSet.CUOCTRIENLAM);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.VIEW_TPNT' table. You can move, or remove it, as needed.
            this.vIEW_TPNTTableAdapter.Fill(this.bAOTANGDataSet.VIEW_TPNT);
            createColumngcnTP();
            if (Program.mGroup == "ADMIN" || Program.mGroup == "MANAGER")
            {
                pcnDetail.Enabled = btnThem.Enabled = btnXoaTPNT.Enabled = btnThemTPNT.Enabled = true;
            }
        }

        private void createColumngcnTP()
        {
            var cl1 = new DataGridViewTextBoxColumn();
            var cl2 = new DataGridViewTextBoxColumn();
            var cl3= new DataGridViewTextBoxColumn();
            var cl4 = new DataGridViewTextBoxColumn();

            cl1.HeaderText = "MATPNT";
            cl2.HeaderText = "TENTPNT";
            cl3.HeaderText = "TENTACGIA";
            cl4.HeaderText = "CHUDE";

            cl1.Width = 100;
            cl2.Width = 100;
            cl3.Width = 100; 
            cl4.Width = 100;

            gcnTP.Columns.Clear();
            gcnTP.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3, cl4 });
        }
        private void btnThemTPNT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.Connect() == 0) return;
            // Tạo một bảng tạm thời để lưu trữ kết quả từ stored procedure
            DataTable tempTable = new DataTable();
            int i = gridView1.FocusedRowHandle;
            string MaTP = ((DataRowView)vIEWTPNTBindingSource[i])["MATPNT"].ToString();
            gcnTP.Columns.Clear();
            //tạo một table để lưu các data đã có
            DataTable existingData = (DataTable)gcnTP.DataSource;
            //tạo một table để tạo mới table
            DataTable newData = new DataTable();

            //kết nối và gọi sp
            SqlCommand command = new SqlCommand("SP_GETTPNT", Program.conn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm tham số và gán giá trị từ column1Value
            command.Parameters.AddWithValue("@MaTP", MaTP);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(newData);


            // Kết hợp dữ liệu hiện có và dữ liệu mới
            DataTable combinedData = new DataTable();

            if (existingData == null)
            {
                combinedData.Merge(newData);
            }
            else
            {
                // Kiểm tra sự tồn tại của mã TPNT
                DataRow[] rows = existingData.Select("MATPNT = '" + MaTP + "'");

                if (rows.Length > 0)
                {
                    combinedData.Merge(existingData);
                    string errorMessage = "Tác phẩm nghệ thuật đã được chọn";
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    combinedData.Merge(existingData);
                    combinedData.Merge(newData);
                }


            }



            // Cập nhật dữ liệu trong GridView2
            gcnTP.DataSource = combinedData;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnXoaTPNT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có dòng được chọn không
            if (gcnTP.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = gcnTP.SelectedRows[0];

                // Xóa dòng khỏi GridView2
                gcnTP.Rows.Remove(selectedRow);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.Connect() == 0) return;
            try
            {

                if (gcnTP == null || gcnTP.RowCount == 0)
                {
                    MessageBox.Show("Phải chọn TPNT cho cuộc triển lãm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtIDCTL.Text) || string.IsNullOrWhiteSpace(txtTenTL.Text) || string.IsNullOrWhiteSpace(deFrom.Text) || string.IsNullOrWhiteSpace(deTo.Text))
                    {
                        MessageBox.Show("Không được để trống thông tin của cuộc triển lãm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        //thêm các thông tin về triển lãm
                        string query = "INSERT INTO CUOCTRIENLAM (IDCTL, TENTRIENLAM, NGAYBATDAU, NGAYKETTHUC) " +
                        "VALUES (@IDTL, @TENTL, @NGAYBD, @NGAYKT)";
                        SqlCommand command = new SqlCommand(query, Program.conn);
                        command.Parameters.AddWithValue("@IDTL", txtIDCTL.Text);
                        command.Parameters.AddWithValue("@TENTL", txtTenTL.Text);
                        command.Parameters.AddWithValue("@NGAYBD", deFrom.DateTime);
                        command.Parameters.AddWithValue("@NGAYKT", deTo.DateTime);

                        command.ExecuteNonQuery();

                        //thêm các thông tin về ct_triển lãm
                        string idtl = txtIDCTL.Text;

                        for (int i = 0; i < gcnTP.RowCount; i++)
                        {
                            string matpnt = gcnTP.Rows[i].Cells["MATPNT"].Value.ToString();  

                            // Thực hiện câu lệnh INSERT vào bảng CT_TRIENLAM
                            string query1 = "INSERT INTO CT_CUOCTRIENLAM (IDCTL, MATPNT) VALUES (@IDTL, @MATP)";
                            SqlCommand command1 = new SqlCommand(query1, Program.conn);
                            command1.Parameters.AddWithValue("@IDTL", idtl);
                            command1.Parameters.AddWithValue("@MATP", matpnt);
                            command1.ExecuteNonQuery();
                        }

                        btnReload_ItemClick(sender, e);

                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vIEW_TPNTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vIEW_TPNTTableAdapter.Fill(this.bAOTANGDataSet.VIEW_TPNT);
                //Xoa het du lieu trong GridView2
                gcnTP.DataSource = null;
                createColumngcnTP();
                // Đặt giá trị trắng cho các textbox
                txtIDCTL.Text = string.Empty;
                txtTenTL.Text = string.Empty;

                // Đặt giá trị trắng cho các dateEdit
                deFrom.EditValue = null;
                deTo.EditValue = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
