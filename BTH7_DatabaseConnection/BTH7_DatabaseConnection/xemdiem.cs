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

namespace BTH7_DatabaseConnection
{
    public partial class frmxemdiem : Form
    {
        public frmxemdiem()
        {
            InitializeComponent();
        }

        private void xemdiem_Load(object sender, EventArgs e)
        {
/*            //dataGridView_xemdiem.DataSource = GetXemdiem().Tables[0];
            ConnectioningString a = new ConnectioningString();
            // string query = "select *from KetQua";
            string query = "SELECT Mon.TenMH, KetQua.Diem " +
                           "FROM KetQua INNER JOIN " +
                           "Mon ON KetQua.MaMH = Mon.MaMH";
            DataSet ds = a.Getlist(query, "KetQua");

            dataGridView_xemdiem.DataSource = ds.Tables[0];*/
        }

       /* DataSet GetXemdiem()
        //{
            //DataSet dataxemdiem = new DataSet();
            string query = "SELECT KetQua.MaMH, Mon.TenMH, KetQua.Diem" +
                           "FROM  KetQua INNER JOIN" +
                           "Mon ON KetQua.MaMH = Mon.MaMH";
            using (SqlConnection con = new SqlConnection(ConnectioningString.connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
             
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataxemdiem);
                con.Close();

            }

            return dataxemdiem;
        } */
    }
}
