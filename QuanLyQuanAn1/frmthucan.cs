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
           DataTable dt = db.dsquanan("select * from Food,FoodCetagory where Food.idCategory = FoodCetagory.id;");
            dataviewthucdon.DataSource = dt;
            dataviewthucdon.Columns[2].Visible = false;
            dataviewthucdon.Columns[4].Visible = false;
            DataTable ds = db.dsquanan("select * from Food ");
            cbtimfood.DataSource = ds;
            cbtimfood.DisplayMember = "name";
            cbtimfood.ValueMember = "id";
            DataTable dss = db.dsquanan("select * from FoodCetagory ");
            cbdanhmuc.DataSource = dss;
            cbdanhmuc.DisplayMember = "name";
            cbdanhmuc.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = db.dsquanan("select id from FoodCetagory where name = N'" + cbdanhmuc.Text + "'");
            string x = dt.Rows[0]["id"].ToString();
            int g = Convert.ToInt32(x);
            MessageBox.Show(g.ToString());
            db.dsupdate("insert into Food (name, idCategory, price) values(N'" + tbten.Text + "','" + g+ "','" + tbgia.Text + "')");
            DataTable dtt = db.dsquanan("select * from Food,FoodCetagory where Food.idCategory = FoodCetagory.id;");
            dataviewthucdon.DataSource = dtt;
            dataviewthucdon.Columns[2].Visible = false;
            dataviewthucdon.Columns[4].Visible = false;
        }

        private void cbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataviewthucdon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dataviewthucdon.CurrentRow.Cells[0].Value.ToString();
            tbten.Text = dataviewthucdon.CurrentRow.Cells[1].Value.ToString();
            tbgia.Text = dataviewthucdon.CurrentRow.Cells[3].Value.ToString();
            cbdanhmuc.Text = dataviewthucdon.CurrentRow.Cells[5].Value.ToString();
        }

        private void lbtim_Click(object sender, EventArgs e)
        {
           

            DataTable dt = db.dsquanan("select * from Food,FoodCetagory where Food.idCategory = FoodCetagory.id and Food.name = N'"+cbtimfood.Text+"'");
            dataviewthucdon.DataSource = dt;
        }
    }
}
