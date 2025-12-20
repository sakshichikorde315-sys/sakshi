using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\sakshi\documents\visual studio 2010\Projects\SupermarketManagementSystem\SupermarketManagementSystem\SupermarketDB.mdf;Integrated Security=True;User Instance=True ");
        }
    }
}
