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
using System.Data.Common;
using System.Data.SqlClient;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormThemTaiKhoan : Form
    {


        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string p_taikhoan = tbx_TaiKhoan.Text.Trim();
            string p_matkhau = tbx_MatKhau.Text.Trim();
            string p_chucvu = cbx_ChucVu.Text.Trim();
            string p_trangthai = cbx_TrangThai.Text.Trim();

            string nameCollum = "[User]";
            string[] collums = { "tai_khoan", "mat_khau", "idPer", "status" };

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
            sql += $") VALUES (N'{p_taikhoan}', N'{p_matkhau}', N'{p_chucvu}',N'{p_trangthai}');";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            GetDataUser();
        }
        private void LoadDataToComboBox()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT idPer, status FROM [User]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            conn.Close ();
            cbx_ChucVu.DataSource = table;
            cbx_ChucVu.Refresh();

        }


        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            GetDataUser();
        }
        private void GetDataUser()
        {
            string nameTable = "[User]";
            string[] collums = { "tai_khoan", "mat_khau", "idPer", "status" };

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"SELECT * FROM {nameTable}";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmd.Dispose();
            conn.Close();

            dtgrv_TaiKhoan.DataSource = dt;
            dtgrv_TaiKhoan.Refresh();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string p_taikhoan = tbx_TaiKhoan.Text.Trim();
            string p_matkhau = tbx_MatKhau.Text.Trim();
            string p_chucvu = cbx_ChucVu.Text.Trim();
            string p_trangthai = cbx_TrangThai.Text.Trim();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string nameTable = "[User]";
            string[] collums = { "tai_khoan", "mat_khau", "idPer", "status" };
            string query = $"UPDATE {nameTable} SET";
            query += $" tai_khoan = N'{p_taikhoan}', mat_khau= N'{p_matkhau}', idPer ={cbx_ChucVu}, status=N'{cbx_TrangThai}'";
            query += $" WHERE = '{dtgrv_TaiKhoan.Rows[dtgrv_TaiKhoan.CurrentRow.Index].Cells[0].Value.ToString()}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            GetDataUser();
        }

        private void dtgrv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexCurrent = e.RowIndex;

            tbx_TaiKhoan.Text = dtgrv_TaiKhoan.Rows[indexCurrent].Cells[0].Value.ToString();
            tbx_MatKhau.Text = dtgrv_TaiKhoan.Rows[indexCurrent].Cells[0].Value.ToString();
            cbx_ChucVu.Text = dtgrv_TaiKhoan.Rows[indexCurrent].Cells[0].Value.ToString();
            cbx_TrangThai.Text = dtgrv_TaiKhoan.Rows[indexCurrent].Cells[0].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string p_taikhoan= dtgrv_TaiKhoan.Rows[dtgrv_TaiKhoan.CurrentRow.Index].Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"DELETE FROM [User] WHERE tai_khoan ='{p_taikhoan}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            GetDataUser();

        }

        private void pbx_TimKiem_Click(object sender, EventArgs e)
        {
            string p_tk= tbx_TimKiem.Text;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = $"SELECT [User].tai_khoan, [User].mat_khau, [User].idPer, [User].status FROM [User] WHERE tai_khoan LIKE '{p_tk}';";
            SqlCommand cmd = new SqlCommand (query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dtgrv_TaiKhoan.DataSource = dt;
            dtgrv_TaiKhoan.Refresh();
            
        }

        private void cbx_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
