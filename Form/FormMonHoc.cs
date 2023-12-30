using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string p_SoTC = tbx_SoTC.Text.Trim();
            string p_LanHoc = tbx_LanHoc.Text.Trim();
            string p_LanThi = tbx_LanThi.Text.Trim();
            string p_DanhGia = tbx_DanhGia.Text.Trim();
            string p_ChuyenCan = tbx_ChuyenCan.Text.Trim();
            string p_DiemTH = tbx_DiemTH.Text.Trim();
            string p_DiemTL = tbx_DiemTL.Text.Trim();
            string p_KTGK = tbx_KTGK.Text.Trim();
            string p_ThiKT = tbx_ThiKT.Text.Trim();

            if (string.IsNullOrEmpty(p_SoTC))
            {
                MessageBox.Show("Không được để rỗng số tín chỉ");
                tbx_SoTC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(p_LanHoc))
            {
                MessageBox.Show("Không được để rỗng lần học");
                tbx_LanHoc.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }

            string sql = $"INSERT INTO MonHoc (SoTC, LanHoc, LanThi, DanhGia, DiemTH, ChuyenCan, DiemTL, KTGK,ThiKT) VALUES (N'{p_SoTC}', N'{p_LanHoc}', '{p_LanThi}', N'{p_DanhGia}','{p_DiemTH}','{p_ChuyenCan}','{p_DiemTL}','{p_KTGK}','{p_ThiKT}');";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            
        }
    }
}
