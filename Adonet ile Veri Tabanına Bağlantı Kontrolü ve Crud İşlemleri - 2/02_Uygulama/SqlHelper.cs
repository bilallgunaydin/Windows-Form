using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Uygulama
{
    class SqlHelper
    {
        //1.Yöntem
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }
        static SqlHelper()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = "server=.;database=Northwind;Integrated Security=true;";
        }
    }
}
