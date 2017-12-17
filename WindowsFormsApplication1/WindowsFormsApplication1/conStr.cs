using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class conStr
    {
        public static SqlConnection GetDBConnection()
        {

            // Data Source=DESKTOP-38C3K9H\SQLEXPRESS;Initial Catalog=TuVanTuyenSinh;Persist Security Info=True

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7U0MIE1\SQLExpress;Initial Catalog=TuVanTuyenSinh;Integrated Security=True");

            return conn;
        }
    }
}
