using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn1.DAO;

namespace QuanLyQuanAn1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kt = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không!",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (kt == DialogResult.No) e.Cancel = true;
        }
        bool login(string username , string password)
        {
           return Account.Singleton.login(username, password);
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string user = txttendangnhap.Text;
            string pass = txtpassword.Text;

            if (login(user , pass))
            {
                frmtable frmtable = new frmtable();
                this.Hide();
                frmtable.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn nhập sai rồi!");
            
        }
    }
}
