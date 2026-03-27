using System.Data.SqlClient;

namespace InventarioTI.Infrastructure.Data
{
    public class DbConnection
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InventarioTI;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}