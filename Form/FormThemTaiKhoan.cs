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

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormThemTaiKhoan : Form
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        DataSet ds;
        DataAdapter da;


        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                int CurrentIndex = dtgrv_BangThongTin.CurrentCell.RowIndex;
                string tai_khoan = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[0].Value.ToString());
                string mat_khau = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[1].Value.ToString());
                string idPer = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[2].Value.ToString());
                string status = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[3].Value.ToString());

                string insertStr = "Insert into [User] Values('" + tai_khoan + "','" + mat_khau + "','" + idPer + "','" + status + "')";
                SqlCommand insertCmd = new SqlCommand(insertStr, conn);
                insertCmd.CommandType = CommandType.Text;
                insertCmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormThemTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadData()
        {
            ds = new DataSet();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "select * from [DatabaseQLDiemSV].[dbo].[User]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dtgrv_BangThongTin.DataSource = dt;
            dtgrv_BangThongTin.Refresh();

        }
        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int CurrentIndex = dtgrv_BangThongTin.CurrentCell.RowIndex;
                string tai_khoan = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[0].Value.ToString());
                string mat_khau = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[1].Value.ToString());
                string idPer = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[2].Value.ToString());
                string status = Convert.ToString(dtgrv_BangThongTin.Rows[CurrentIndex].Cells[3].Value.ToString());
                string DeleteStr = "Delete from [User] where tai_khoan='" + tai_khoan + "'";
                SqlCommand deletecmd = new SqlCommand(DeleteStr, conn);
                deletecmd.CommandType = CommandType.Text;
                deletecmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
        