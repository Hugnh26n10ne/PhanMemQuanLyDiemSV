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
using Microsoft.Office.Interop.Excel;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormNhapMonHoc : Form
    {
        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;

        private void LoadData()
        {
            connectionString = "Data Source=Belphegor0813;Initial Catalog=DatabaseQLDiemSV;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            ds = new DataSet();
            string query = "Select * from MonHoc";
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "MonHoc");
                dtgrv.DataSource = ds.Tables["MonHoc"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public FormNhapMonHoc()
        {
            InitializeComponent();
        }

        private void FormNhapMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int CurrentIndex = dtgrv.CurrentCell.RowIndex;
                string ma_mh = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[0].Value.ToString());
                string ma_gv = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[1].Value.ToString());
                string diem_id = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[2].Value.ToString());
                string ten_mh = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[3].Value.ToString());
                string thoi_gian = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[4].Value.ToString());
                string dia_diem = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[5].Value.ToString());
                int so_tin_chi = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[6].Value.ToString());
                int so_tiet = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[7].Value.ToString());
                int so_dk = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[8].Value.ToString());
                string hoc_phi = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[9].Value.ToString());
                string ghi_chu = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[10].Value.ToString());
                string insertStr = "Insert into MonHoc Values('" + ma_mh + "','" + ma_gv + "','" + diem_id + "','" + ten_mh + "','" + thoi_gian + "','" + dia_diem + "','" + so_tin_chi + "','" + so_tiet + "','" + so_dk + "','" + hoc_phi + "','" + ghi_chu + "')";
                SqlCommand insertCmd = new SqlCommand(insertStr, conn);
                insertCmd.CommandType = CommandType.Text;
                insertCmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã lưu thành công rùi!!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int CurrentIndex = dtgrv.CurrentCell.RowIndex;
                string ma_mh = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[0].Value.ToString());
                string ma_gv = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[1].Value.ToString());
                string diem_id = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[2].Value.ToString());
                string ten_mh = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[3].Value.ToString());
                string thoi_gian = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[4].Value.ToString());
                string dia_diem = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[5].Value.ToString());
                int so_tin_chi = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[6].Value.ToString());
                int so_tiet = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[7].Value.ToString());
                int so_dk = Convert.ToInt32(dtgrv.Rows[CurrentIndex].Cells[8].Value.ToString());
                string hoc_phi = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[9].Value.ToString());
                string ghi_chu = Convert.ToString(dtgrv.Rows[CurrentIndex].Cells[10].Value.ToString());
                string DeleteStr = "Delete from MonHoc where ma_mh='" + ma_mh + "'";
                SqlCommand Deletecmd = new SqlCommand(DeleteStr, conn);
                Deletecmd.CommandType = CommandType.Text;
                Deletecmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xóa thành công!!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
            }
            catch(SqlException ex);
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
}
    

       
   
