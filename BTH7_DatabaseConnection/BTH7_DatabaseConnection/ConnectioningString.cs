using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH7_DatabaseConnection
{
    internal class ConnectioningString
    {
 /*       SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R4O4KCT\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        DataSet dt = new DataSet();

        public DataSet getlist(string query, string tenbang)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dt, tenbang);

            connection.Close();
            return dt;*/
        }

        public void EXCUTE(string Tsx)
        {
            /*try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Tsx, connection);
                int lsx = cmd.ExecuteNonQuery();
                if (lsx > 0)
                {
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }*/
        }
}
