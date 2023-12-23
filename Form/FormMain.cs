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

        private void pn_GhiChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_ThongTinCaNhan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_CaiDat_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pn_Diem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_NhapDiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_MonHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_NhapMonHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_NhapThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_DiemTB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_ThemTK_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
