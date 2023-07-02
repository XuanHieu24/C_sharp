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
    public partial class frmthongtinsv : Form
    {

        public frmthongtinsv()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void frmthongtinsv_Load(object sender, EventArgs e)
        {
            connectData a = new connectData();
            string query = "select *from Sinhvien";
            DataSet dtset = a.getlist(query, "Sinhvien");
            dataGridView_Nhapthongtinsv.DataSource = dtset.Tables[0];


        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            int b = 0;
            if (checkBox1.Checked == false)
            {
                b = 0;
            }
            else
            {
                b = 1;
            }
            connectData a = new connectData();

            string insert = $"INSERT INTO Sinhvien VALUES ({txtmaso.Text},N'{txthoten.Text}',{dateTimePicker1.Text},{b},N'{txtdiachi.Text}',{txtsdt.Text},N'{txtKhoa.Text}') ";
            a.Excute(insert);
            txtmaso.Text = "";
            txthoten.Text = "";
            dateTimePicker1.Text = "";
            checkBox1.Checked = false;
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtKhoa.Text = "";

            connectData them = new connectData();
            string query = "SELECT *from Sinhvien";
            DataSet ds = them.getlist(query, "Sinhvien");
            dataGridView_Nhapthongtinsv.DataSource = ds.Tables[0];
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            connectData a = new connectData();
            string Dell = "delete from Sinhvien Where MaSo = '" + txtmaso.Text + "'";
            a.Excute(Dell);

            connectData remove = new connectData();
            string query = "Select * from Sinhvien";
            DataSet ds = remove.getlist(query, "Sinhvien");
            dataGridView_Nhapthongtinsv.DataSource = ds.Tables[0];


        }

        private void dataGridView_Nhapthongtinsv_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            txtmaso.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[2].Value.ToString();
            checkBox1.Checked = (bool)dataGridView_Nhapthongtinsv.CurrentRow.Cells[3].Value;
            txtdiachi.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[5].Value.ToString();
            txtKhoa.Text = dataGridView_Nhapthongtinsv.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            connectData a = new connectData();
            string sua = "update sinhvien "
                            + $"set MaSo={txtmaso.Text},HoTen=N'{txthoten.Text}',NgaySinh='{dateTimePicker1.Value.ToShortDateString()}',GioiTinh='{1}',DiaChi=N'{txtdiachi.Text}',DienThoai='{txtsdt.Text}',MaKhoa=N'{txtKhoa.Text}'"
                            + " where MaSo = " + $"'{txtmaso.Text}'";
            a.Excute(sua);
            connectData edit = new connectData();
            string query = "Select * from Sinhvien";
            DataSet ds = edit.getlist(query, "Sinhvien");
            dataGridView_Nhapthongtinsv.DataSource = ds.Tables[0];
        }
    }
}
