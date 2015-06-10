using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theaterTicket
{
    class connectDb
    {
        public static SqlConnection returnConn()
        {
               SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=(localdb)\\v11.0; Database=theater";
                conn.Open();
                return conn;
        }
    }
}
