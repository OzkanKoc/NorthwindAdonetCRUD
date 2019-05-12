using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCRUD.Utilities
{
    public class DbHelper
    {
        private const string NorthwindConnectionString = "Server=.; Database=Northwind; Integrated Security=true;";
        
        public static SqlCommand CreateCommand()
        {
            return CreateCommand(string.Empty);
        }

        public static SqlCommand CreateCommand(string commandText)
        {
            var sqlConnection = new SqlConnection(NorthwindConnectionString);
            var sqlCommand = new SqlCommand(commandText, sqlConnection);

            sqlConnection.Open();

            return sqlCommand;
        }
    }
}
