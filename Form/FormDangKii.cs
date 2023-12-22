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
    public partial class FormDangKi : Form
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public FormDangKi()
        {
            InitializeComponent();
        }
        private bool CheckNLMK()
        {
            if (tbx_MatKhau.Text == tbx_NhapLMK.Text) return true;
            return false;
        }
        private void CheckTrungTK(string m_tk, ref int m_kq)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungUSER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tai_khoan", SqlDbType.NVarChar, 50).Value = m_tk;
            SqlParameter kq = new SqlParameter("@ket_qua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            m_kq = (int)kq.Value;

            cmd.Dispose();
            conn.Close();
        }
        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_TaiKhoan.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_TaiKhoan.Focus();
            }
            if (string.IsNullOrEmpty(tbx_MatKhau.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_MatKhau.Focus();
            }
            if (string.IsNullOrEmpty(tbx_NhapLMK.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_NhapLMK.Focus();
            }

            int m_kq = 0;
            CheckTrungTK(tbx_TaiKhoan.Text, ref m_kq);
            if (m_kq == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                tbx_TaiKhoan.Text = "";
                tbx_TaiKhoan.Focus();
                return;
            }

            if (!CheckNLMK())
            {
                MessageBox.Show("Nhập lại mật khẩu!");
                tbx_NhapLMK.Text = "";
                tbx_NhapLMK.Focus();
                return;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }


            SqlCommand cmd = new SqlCommand("SP_InsertUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tai_khoan", SqlDbType.NVarChar, 50).Value = tbx_TaiKhoan.Text;
            cmd.Parameters.Add("@mat_khau", SqlDbType.NVarChar, 50).Value = tbx_MatKhau.Text;
            cmd.Parameters.Add("@idPer", SqlDbType.TinyInt).Value = 0;
            cmd.Parameters.Add("@status", SqlDbType.TinyInt).Value = 0;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();


            if (MessageBox.Show("Bạn đã tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                Dispose();
            };

            if (MessageBox.Show("Bạn có muốn chuyển qua ĐĂNG NHẬP", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                FormDangNhap fdn = new FormDangNhap();
                fdn.Show();
            };
        }
        private void lb_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void pbx_Show_Click(object sender, EventArgs e)
        {
            pbx_Show.Hide();
            pbx_Hide.Show();
            tbx_MatKhau.UseSystemPasswordChar = true;
            tbx_NhapLMK.UseSystemPasswordChar = true;
        }

        private void pbx_Hide_Click(object sender, EventArgs e)
        {
            pbx_Hide.Hide();
            pbx_Show.Show();
            tbx_MatKhau.UseSystemPasswordChar = false;
            tbx_NhapLMK.UseSystemPasswordChar = false;
        }

        private void pbx_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy gọi theo số 09xxxxxx90 hoặc nhắn tin zalo theo số 09xxxxxx90 để được hỗ trợ!");
        }
        private void tbx_TaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_TaiKhoan.SelectAll();
        }

        private void tbx_MatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_MatKhau.SelectAll();
        }
        private void tbx_NLMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_NhapLMK.SelectAll();
        }

        private void tbx_TaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btn_DangKi.PerformClick();
            }
        }

        private void tbx_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btn_DangKi.PerformClick();
            }
        }

        private void tbx_NhapLMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btn_DangKi.PerformClick();
            }
        }

        private void FormDangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDangNhap fdn =new FormDangNhap();
            fdn.Show();
        }
    }
}
