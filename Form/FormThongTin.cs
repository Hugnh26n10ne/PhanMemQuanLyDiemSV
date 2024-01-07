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
    public partial class FormThongTin : Form
    {
        public FormThongTin()
        {
            InitializeComponent();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
           string p_taikhoan=tbx_TaiKhoan.Text.Trim();
           string p_hoten=tbx_HoVaTen.Text.Trim();
           string p_ngaysinh=dtp_NgaySinh.Text.Trim();
           string p_dantoc=tbx_DanToc.Text.Trim();
           string p_diachi=tbx_DiaChi.Text.Trim();
           string p_sdt=tbx_SoDT.Text.Trim();
           string p_email=tbx_Email.Text.Trim();
           string p_vaitro=tbx_VaiTro.Text.Trim();
           string p_trangthai=cbx_TrangThai.Text.Trim();
           string nameCollum = "[Information]";
           string[] collums = { "[stt], [tai_khoan], [ho_va_ten], [gioi_tinh], [dia_chi], [ngay_sinh], [dan_toc], [so_dien_thoai], [email], [vai_tro], [trang_thai]" };

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"INSERT INTO {nameCollum} (";
            for (int i =0; i < collums.Length; i++)
            {
                sql += collums[i];
                sql += ",";
            }
            sql=sql.TrimEnd(',');
            sql += $") VALUES(N'{p_taikhoan}', N{p_hoten}', {p_ngaysinh},N'{p_dantoc}', N'{p_diachi}', {p_sdt}, N'{p_email}', N'{p_vaitro}', N'{p_trangthai}';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            GetDataInformation();

        }
        private void LoadDataToComboBox()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT trang_thai FROM Information";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            conn.Close();
            cbx_TrangThai.DataSource = table;
            cbx_TrangThai.Refresh();
        }

        private void GetDataInformation()
        {
            string nametable = "[Infomation]";
            string[] collums = { "[stt]", "[tai_khoan]", "[ho_va_ten]", "[gioi_tinh]", "[dia_chi]", "[ngay_sinh]", "[dan_toc]", "[so_dien_thoai]", "[email]", "[vai_tro]", "[trang_thai]" };

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"SELECT * FROM {nametable}";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmd.Dispose();
            conn.Close();

            dtgrv_ThongTin.DataSource= dt;
            dtgrv_ThongTin.Refresh();
        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            GetDataInformation();

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string p_taikhoan = tbx_TaiKhoan.Text.Trim();
            string p_hoten = tbx_HoVaTen.Text.Trim();
            string p_ngaysinh = dtp_NgaySinh.Text.Trim();
            string p_dantoc = tbx_DanToc.Text.Trim();
            string p_diachi = tbx_DiaChi.Text.Trim();
            string p_sdt = tbx_SoDT.Text.Trim();
            string p_email = tbx_Email.Text.Trim();
            string p_vaitro = tbx_VaiTro.Text.Trim();
           
        }
    }
}
