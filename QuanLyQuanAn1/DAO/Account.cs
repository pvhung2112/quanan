using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn1.DAO
{
    internal class Account
    {
        private static Account instance;

        internal static Account Instance
        {
            get
            {
                if (instance == null) instance = new Account();
                return instance;
            }
            private set { instance = value; }
        }
        private Account()
        {
            // khởi tạo hàm mặc định
        }
        public bool login(string username, string password)
        {
            string query = "SELECT * FROM Account WHERE Username = @Username AND Password = @Password";

            DataTable kt = DataProvider.Instance.ExeCuteQuery(query, new object[] { username, password });

            return kt.Rows.Count > 0;
        }


    }
}
