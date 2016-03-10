using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Controller
{
    public sealed class ADODBConnection
    {
        private static volatile SqlConnection instance;

        public static SqlConnection Connection()
        {
            if (instance == null)
            {
                instance = new SqlConnection("Data Source=PAR209617;Initial Catalog=dbcantina;Persist Security Info=True;User ID=sa;Password=123@senha");
            }
            return instance;
        }
    }
}
