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

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormNhapMonHoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=Belphegor0813;Initial Catalog=DatabaseQLDiemSV;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from MonHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgrv.DataSource = table;
        }
        public FormNhapMonHoc()
        {
            InitializeComponent();
        }

        private void FormNhapMonHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrv.CurrentRow.Index;
            tbx_MaMonHoc.Text = dtgrv.Rows[i].Cells[0].ToString();
            tbx_MaGiaoVien.Text = dtgrv.Rows[i].Cells[1].ToString();
            tbx_DiemID.Text = dtgrv.Rows[i].Cells[2].ToString();
            tbx_TenMonHoc.Text = dtgrv.Rows[i].Cells[3].ToString();
            tbx_ThoiGian.Text = dtgrv.Rows[i].Cells[4].ToString();
            tbx_DiaDiem.Text = dtgrv.Rows[i].Cells[5].ToString();
            tbx_HocPhi.Text = dtgrv.Rows[i].Cells[9].ToString();
            tbx_GhiChu.Text = dtgrv.Rows[i].Cells[10].ToString();
            tbx_SoTinChi.Text = dtgrv.Rows[i].Cells[6].ToString();
            tbx_SoTiet.Text = dtgrv.Rows[i].Cells[7].ToString();
            tbx_SoDangKi.Text = dtgrv.Rows[i].Cells[8].ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into MonHoc values('"+tbx_MaMonHoc.Text+"', N'"+tbx_MaGiaoVien.Text+ "', N'"+tbx_DiemID.Text+ "', N'"+tbx_TenMonHoc.Text+ "', N'"+tbx_ThoiGian.Text+ "', N'"+tbx_DiaDiem.Text+ "', N'"+tbx_SoTinChi.Text+ "',N'"+tbx_SoTiet.Text+ "', N'"+tbx_SoDangKi.Text+ "', N'"+tbx_HocPhi.Text+ "',N'"+tbx_GhiChu.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
