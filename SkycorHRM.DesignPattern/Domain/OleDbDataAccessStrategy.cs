using AdapterDemo.Test;
using System.Data;
using System.Data.OleDb;

namespace SkycorHRM.DesignPattern.Domain
{
    public class OleDbDataAccessStrategy : IDataAccessStrategy
    {
        public IDbDataAdapter Prepare(IDbDataAdapter adapter)
        {
            adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM Departments");
            adapter.SelectCommand.Connection =
                new OleDbConnection(
                    @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=C:\Users\skycore\source\repos\SkycoreHRMsolution\SqlCompact.sdf"
                );
            return adapter;
        }
    }
}
