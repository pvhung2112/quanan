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
    public partial class frmtaikhoan : Form
    {
        public frmtaikhoan()
        {
          
            InitializeComponent();
            load();
        }
        void load()
        {
            
            //string query = "Exec USP_GetAccountUsername @username";
            ////DataProvider provider = new DataProvider();
            //dataacc.DataSource = DataProvider.Singleton.ExeCuteQuery(query , new object[] {"QuyDuong"} );
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
