using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        bool active = false;
        private void pbx_Menu_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                pn_Bar.Size = new Size(230, 618);
            }
            else
            {
                pn_Bar.Size = new Size(70, 618);
            }
            
        }

       

        private void pn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void pn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void lb_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void pbx_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }

        private void pn_Diem_Click(object sender, EventArgs e)
        {

        }

        private void pbx_Diem_Click(object sender, EventArgs e)
        {

        }

        private void lb_Diem_Click(object sender, EventArgs e)
        {

        }

        private void pn_MonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc fmh = new FormMonHoc();
            fmh.Show();
        }

        private void pbx_MonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc fmh = new FormMonHoc();
            fmh.Show();
        }

        private void lb_MonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc fmh = new FormMonHoc();
            fmh.Show();
        }

        private void pn_ThongTin_Click(object sender, EventArgs e)
        {
            FormThongTin ftt = new FormThongTin();
            ftt.Show();
        }

        private void pbx_ThongTin_Click(object sender, EventArgs e)
        {
            FormThongTin ftt = new FormThongTin();
            ftt.Show();
        }

        private void lb_ThongTin_Click(object sender, EventArgs e)
        {
            FormThongTin ftt = new FormThongTin();
            ftt.Show();
        }

        private void pn_DiemTB_Click(object sender, EventArgs e)
        {

        }

        private void pbx_DTB_Click(object sender, EventArgs e)
        {

        }

        private void lb_DTB_Click(object sender, EventArgs e)
        {

        }

        private void pn_NhapDiem_Click(object sender, EventArgs e)
        {
            FormNhapDiem fnd = new FormNhapDiem();
            fnd.Show();
        }

        private void pbx_NhapDiem_Click(object sender, EventArgs e)
        {
            FormNhapDiem fnd = new FormNhapDiem();
            fnd.Show();
        }

        private void lb_NhapDiem_Click(object sender, EventArgs e)
        {
            FormNhapDiem fnd = new FormNhapDiem();
            fnd.Show();
        }

        private void pn_NhapMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void pbx_NhapMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void lb_NhapMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void pn_NhapThongTin_Click(object sender, EventArgs e)
        {

        }

        private void pbx_NhapThongTin_Click(object sender, EventArgs e)
        {

        }

        private void lb_NhapThongTin_Click(object sender, EventArgs e)
        {

        }

        private void pn_ThemTK_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan fttk = new FormThemTaiKhoan();
            fttk.Show();
        }

        private void pbx_ThemTK_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan fttk = new FormThemTaiKhoan();
            fttk.Show();
        }

        private void lb_ThemTK_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan fttk = new FormThemTaiKhoan();
            fttk.Show();
        }
    }
}
