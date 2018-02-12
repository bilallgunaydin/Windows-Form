using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{ 
    class SqlHelper
    {
        
        private const string MHRSConnectionString = "Data Source=BILAL\\SQLEXPRESS; Initial Catalog=mhrs; Integrated Security=SSPI";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = MHRSConnectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
    }
}
