using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_View
{
    static class SqlHelper
    {
        private static SqlConnection _cnn;
        public static SqlConnection cnn
        {
            get { return SqlHelper._cnn; }
            set { SqlHelper._cnn = value; }
        }
        static string stringConnection = "server=.;database=Northwind;Integrated Security=true;";

        static SqlHelper()
        {
            _cnn = new SqlConnection();
            _cnn.ConnectionString = stringConnection;
        }
    }
}
