using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormNhapThongTin : Form
    {
        public FormNhapThongTin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=Belphegor0813;Initial Catalog=DatabaseQLDiemSV;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private bool check;

        private void openconn()
        { 
            if(conn.State ==ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void closeconn()
        {
            if (conn.State == ConnectionState.Open)
            { 
                conn.Close();
            }
        }
        private Boolean Exe(string cmd)
        {
            openconn();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch(Exception ex) 
            {
                check = false;
            }
            closeconn();
            return check;
        }

        private DataTable Red(string cmd)
        {
            openconn();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            closeconn();
            return dt;
        }
        private void load()
        {
            DataTable dt = Red("SELECT * FROM Infomation");
            if(dt!=null)
            {
                dtgrv.DataSource = dt;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormNhapThongTin_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
