using DevExpress.Xpo;
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
    public partial class FrmLoaiSoHuu : Form
    {
        public FrmLoaiSoHuu(String MATPNT)
        {
            InitializeComponent();
            LoadData(MATPNT);
        }

        public FrmLoaiSoHuu()
        {
            InitializeComponent();
        }

        private void LoadData(String MATPNT)
        {
            if (Program.Connect() == 0) return;
            string query = "SELECT * FROM LOAISOHUU WHERE MATPNT = @MATPNT";  /**/

            SqlCommand command = new SqlCommand(query, Program.conn);
            command.Parameters.AddWithValue("@MATPNT", MATPNT);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime ngaySoHuu = reader.GetDateTime(1);
                    string tinhTrang = reader.GetString(2);
                    decimal triGia = reader.GetDecimal(3);

                    
                    dtNgaySoHuu.Text = ngaySoHuu.ToString("yyyy/MM/dd");
                    txtTinhTrang.Text = tinhTrang.ToString();
                    txtTriGia.Text = triGia.ToString();
                    txtMATPNT.Text = MATPNT.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho Mã TPNT: " + MATPNT, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void FrmLoaiSoHuu_Load(object sender, EventArgs e)
        {
            

        }
    }
}
