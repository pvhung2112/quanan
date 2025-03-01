using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn1
{
    public partial class frmtable : Form
    {
        public frmtable()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccount frmaccount = new frmaccount();
            Hide();
            frmaccount.Show();
            Show();
           
        }

        

        

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoanhthu frmdoanhthu = new frmdoanhthu();
            frmdoanhthu.Show() ;
        }

        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthucan frmthucan = new frmthucan();
            frmthucan.Show();

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtaikhoan frmtaikhoan = new frmtaikhoan();
            frmtaikhoan.Show();
        }

        private void doanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdanhmuc frmdanhmuc = new frmdanhmuc();
            frmdanhmuc.Show();
        }
    }
}
