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
using QuanLyQuanAn1.DAO;

namespace QuanLyQuanAn1
{
    public partial class frmdangky : Form
    {
        public frmdangky()
        {
            InitializeComponent();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtdangnhap.Text;
            string queryKTra = "select count(*) from Account where username = @username ";
            object KiemTra = DataProvider.Singleton.ExeCuteS(queryKTra, new object[] { tendangnhap });
            if (KiemTra != null && (int)KiemTra > 0)
            {
                MessageBox.Show("Ten Dang nhap da co!");
            }
            else
            {
                try
                {
                    string queryInsert = "INSERT INTO Account (username) VALUES ( @username )";
                    int kt = DataProvider.Singleton.ExeCuteNon(queryInsert, new object[] { tendangnhap });

                    if (kt != 0)
                    {
                        MessageBox.Show("Dang ky thanh cong");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
        }
    }
}
