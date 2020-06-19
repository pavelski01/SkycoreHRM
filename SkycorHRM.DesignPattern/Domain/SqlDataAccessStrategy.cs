using System.Data;
using System.Data.SqlClient;

namespace SkycorHRM.DesignPattern.Domain
{
    public class SqlDataAccessStrategy : IDataAccessStrategy
    {
        public IDbDataAdapter Prepare(IDbDataAdapter adapter)
        {
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Departments");
            adapter.SelectCommand.Connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=SqlServer;User Id=sa;Password=qwerty12345;");
            return adapter;
        }
    }
}
