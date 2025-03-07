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
   
    public partial class frmthucan : Form
    {
        ketnoi db = new ketnoi();
        public frmthucan()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmthucan_Load(object sender, EventArgs e)
        {
           DataTable dt = db.dsquanan("select * from  FoodCetagory");
            dataviewthucdon.DataSource = dt;
        }
    }
}
