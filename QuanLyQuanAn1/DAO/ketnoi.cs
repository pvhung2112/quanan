using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn1.DAO
{
    public class ketnoi
    {
        public DataTable dsquanan(string sql)
        {

            try
            {
                SqlConnection con = new SqlConnection("");
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex);
                return null;

            }
        }
    }
}
