using AdapterDemo.Test;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;

namespace SkycorHRM.DesignPattern.Domain
{
    public class SqliteDataAccessStrategy : IDataAccessStrategy
    {
        public IDbDataAdapter Prepare(IDbDataAdapter adapter)
        {
            adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = new SQLiteCommand("SELECT * FROM Departments");
            adapter.SelectCommand.Connection =
                new SQLiteConnection(
                    @"Data Source=C:\Users\skycore\source\repos\SkycoreHRMsolution\SqlLite.db"
                );
            return adapter;
        }
    }
}
