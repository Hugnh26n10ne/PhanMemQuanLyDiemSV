using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }

        private void tbx_MaLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string p_ma_lh = tbx_MaLopHoc.Text.Trim();
            string p_ma_nganh = cbx_ChonNganhHoc.Text.Trim();
            string p_ten_lh = tbx_TenLopHoc.Text.Trim();
            string p_ghi_chu = tbx_GhiChu.Text.Trim();

            string nameCollum = "MaLopHoc";
            string[] collums ={"MaLopHoc","TenLopHoc","MaNganh","GhiChu" };

            if (string.IsNullOrEmpty(p_ma_lh)) 
            {
                MessageBox.Show("Không được để rỗng mã lớp học!");
                tbx_MaLopHoc.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            string sql = $"INSERT INTO {nameCollum} (";
            for (int i = 0; i < collums.Length; i++)
            {
                sql += collums[i];
                sql += ",";
            }
            sql = sql.TrimEnd(',');
            sql += $")  VALUES (N'{p_ma_lh}', N'{p_ma_nganh}', {p_ghi_chu}, N'{p_ten_lh}');";
        }

        private void cbx_ChonNganhHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
