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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgrv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dtgrv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] row1 = { "Data1", "Data2", "Data3" };
            string[] row2 = { "Data4", "Data5", "Data6" };

            // Thêm dữ liệu vào DataGridView
            dtgrv.Rows.Add(row1);
            dtgrv.Rows.Add(row2);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = tbx_TimKiem.Text;
            PerformSearch(keyword);
        }

       

        private void PerformSearch(string keyword1)
        {
            if(!string.IsNullOrEmpty(keyword1))
            {
                MessageBox.Show($"Đang tìm kiếm: {keyword1}");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
            }
        }
    }
}
