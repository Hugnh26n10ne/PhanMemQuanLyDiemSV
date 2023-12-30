using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormHocKi : Form
    {
        public SqlConnection conn;

        private void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = $"SELECT hoc_ki, ghi_chu FROM HocKi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();

            dtgrv_HocKi.DataSource = dt;
            dtgrv_HocKi.Refresh();
            dtgrv_HocKi.RowPostPaint += (sender, e) =>
            {
                using (SolidBrush b = new SolidBrush(dtgrv_HocKi.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
                }
            };
        }

        public FormHocKi()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        private void FormHocKi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string o_hoc_ki = tbx_HK.Text.Trim();
            string o_ghi_chu = tbx_GhiChu.Text.Trim();
            if (string.IsNullOrEmpty(o_hoc_ki))
            {
                MessageBox.Show("Không được để rỗng");
                tbx_HK.Focus();
                return;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = $"INSERT INTO HocKi (hoc_ki, ghi_chu) VALUES (N'{o_hoc_ki}', N'{o_ghi_chu}')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dtgrv_HocKi.CurrentRow.Index;
            string o_hoc_ki = dtgrv_HocKi.Rows[index].Cells[0].Value.ToString();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = $"DELETE FROM HocKi WHERE hoc_ki = '{o_hoc_ki}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            LoadData();
        }

        private void dtgrv_HocKi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbx_HK.Text = dtgrv_HocKi.Rows[index].Cells[0].Value.ToString();
            tbx_GhiChu.Text = dtgrv_HocKi.Rows[index].Cells[1].Value.ToString();
        }

        private void pbx_TimKiem_Click(object sender, EventArgs e)
        {
            string o_timkiem = tbx_TimKiem.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = $"SELECT  hoc_ki, ghi_chu FROM HocKi WHERE hoc_ki LIKE '{o_timkiem}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dtgrv_HocKi.DataSource = dt;
            dtgrv_HocKi.Refresh();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int index = dtgrv_HocKi.CurrentRow.Index;
            string o_hoc_ki = dtgrv_HocKi.Rows[index].Cells[0].Value.ToString();

            string hoc_ki_moi = tbx_HK.Text.Trim();
            string ghi_chu_moi = tbx_GhiChu.Text.Trim();

            if (string.IsNullOrEmpty(hoc_ki_moi))
            {
                MessageBox.Show("Không được để rỗng");
                tbx_HK.Focus();
                return;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = $"UPDATE HocKi SET hoc_ki = N'{hoc_ki_moi}', ghi_chu = N'{ghi_chu_moi}' WHERE hoc_ki = '{o_hoc_ki}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            LoadData();
        }
    }
}
