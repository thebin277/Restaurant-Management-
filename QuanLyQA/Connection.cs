using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQA
{
    class Connection
    {
        private static string stringConnection = @"Data Source=THEBIN\THEBIN;Initial Catalog=QuanLyQuanAn; User Id=" + Global.username + ";Password=" + Global.password + ";";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
