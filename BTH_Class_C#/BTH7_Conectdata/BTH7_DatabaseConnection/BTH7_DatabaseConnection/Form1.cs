using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH7_DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhapdiem nd = new nhapdiem();
            nd.MdiParent = this;
            nd.Show();
        }



        private void traCứuĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmxemdiem x = new frmxemdiem();
            x.MdiParent = this;
            x.Show();
        }

        private void toolStripLabel_xemdiem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmabout frm0 = new frmabout();
            frm0.MdiParent = this;
            frm0.Show();

        }

        private void toolStripLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripLabel_nhapdiem_Click_1(object sender, EventArgs e)
        {

            nhapdiem nd = new nhapdiem();
            nd.MdiParent = this;
            nd.Show();        
        }

        private void toolStripLabel_xemdiem_Click_1(object sender, EventArgs e)
        {
            frmxemdiem x = new frmxemdiem();
            x.MdiParent = this;
            x.Show();
        }

        private void toolStripLabel1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?");
           
        }

        private void toolStripLabel_sinhven_Click(object sender, EventArgs e)
        {
            frmthongtinsv ttsv = new frmthongtinsv();
            ttsv.MdiParent = this;
            ttsv.Show();
        }

        private void nhậpThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtinsv ttsv = new frmthongtinsv();
            ttsv.MdiParent = this;
            ttsv.Show();
        }
    }
}
