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
    public partial class FrmLoaiDiMuon : Form
    {
        public FrmLoaiDiMuon(String MATPNT)
        {
            InitializeComponent();
            LoadData(MATPNT);
        }

        public FrmLoaiDiMuon()
        {
            InitializeComponent();
        }
        private void LoadData(String MATPNT)
        {
            if (Program.Connect() == 0) return;
            string query = "SELECT * FROM LOAIDIMUON WHERE MATPNT = @MATPNT";

            SqlCommand command = new SqlCommand(query, Program.conn);
            command.Parameters.AddWithValue("@MATPNT", MATPNT);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string idbst = reader.GetString(1);
                    DateTime ngayMuon = reader.GetDateTime(2);
                    DateTime ngayTra = reader.GetDateTime(3);

                    txtMATPNT.Text = MATPNT.ToString();
                    cmbBST.Text = idbst.ToString();
                    dtNgayMuon.Text = ngayMuon.ToString("yyyy/MM/dd");
                    dtNgayTra.Text = ngayTra.ToString("yyyy/MM/dd");

                   


                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho MATPNT: " + MATPNT, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lOAIDIMUONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.BAOTANGDataSet);

        }

        private void FrmLoaiDiMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BAOTANGDataSet.LOAIDIMUON' table. You can move, or remove it, as needed.
            this.lOAIDIMUONTableAdapter.Fill(this.BAOTANGDataSet.LOAIDIMUON);
            // TODO: This line of code loads data into the 'bAOTANGDataSet.BOSUUTAP' table. You can move, or remove it, as needed.
            this.BOSUUTAPTableAdapter.Fill(this.BAOTANGDataSet.BOSUUTAP);

        }
    }
}
