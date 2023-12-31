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
    public partial class FormHocKi : Form
    {
        private void GetDataHocKi()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "SELECT hoc_ki, ghi_chu FROM HocKi";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            DataColumn sttColumn = new DataColumn("STT");
            sttColumn.DataType = typeof(int);
            sttColumn.AutoIncrement = true;
            sttColumn.AutoIncrementSeed = 1;
            sttColumn.AutoIncrementStep = 1;

            dt.Columns.Add(sttColumn);

            dt.Columns["STT"].SetOrdinal(0);

            cmd.Dispose();
            conn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
            }


            dtgrv_BangHocKi.DataSource = dt;
            dtgrv_BangHocKi.Refresh();
        }
        public FormHocKi()
        {
            InitializeComponent();
        }

        private void FormHocKi_Load(object sender, EventArgs e)
        {
            GetDataHocKi();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string o_hoc_ki = tbx_HK.Text.Trim();
            string o_ghi_chu = tbx_GhiChu.Text.Trim();

            if (string.IsNullOrEmpty(o_hoc_ki))
            {
                MessageBox.Show("Không được để rỗng học kì");
                tbx_HK.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "INSERT INTO HocKi (hoc_ki, ghi_chu) VALUES (@hoc_ki, @ghi_chu)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hoc_ki", hoc_ki);
            cmd.Parameters.AddWithValue("@ghi_chu", ghi_chu);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            GetDataHocKi();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string o_hoc_ki = tbx_HK.Text.Trim();
            string o_ghi_chu = tbx_GhiChu.Text.Trim();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = $"UPDATE HocKi SET hoc_ki = N'{o_hoc_ki}', ghi_chu = N'{o_ghi_chu}' WHERE hoc_ki='{o_hoc_ki}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            GetDataHocKi();

        }

        private void dtgrv_BangHocKi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexCurrent = e.RowIndex;

            tbx_HK.Text = dtgrv_BangHocKi.Rows[indexCurrent].Cells[1].Value.ToString();
            tbx_GhiChu.Text = dtgrv_BangHocKi.Rows[indexCurrent].Cells[2].Value.ToString();

        }
    }
}
