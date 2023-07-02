using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace BTH7_DatabaseConnection
{
    class connectData
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VJBO20NI;Initial Catalog=QLSinhVien;Integrated Security=True");
        DataSet dtset = new DataSet();
        public DataSet getlist(string query, string tenbang)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtset, tenbang);
            con.Close();
            return dtset;
        }
        public void Excute(string ex)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(ex, con);
                int check = cmd.ExecuteNonQuery();
                if(check > 0 )
                {
                    MessageBox.Show("Thành công nha");
                }
                else
                {
                    MessageBox.Show("Lỗi rồi");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Lỗi" + error.Message);
            }
        }
    }
}
