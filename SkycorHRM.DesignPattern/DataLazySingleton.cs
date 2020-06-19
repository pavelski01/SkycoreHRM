using AdapterDemo.Model;
using SkycorHRM.DesignPattern.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SkycorHRM.DesignPattern
{
    public class DataLazySingleton
    {
        private List<IDataAccessStrategy> Strategies { get; set; } =
            new List<IDataAccessStrategy>() 
            {
                null,
                new SqlDataAccessStrategy(),
                new SqliteDataAccessStrategy(),
                new OleDbDataAccessStrategy(),
                new StubDataAccessStrategy()                
            };
        private DataLazySingleton() {}
        public static DataLazySingleton Instance => Nested.instance;
        public IEnumerable<SkycoreHRM.Shared.Department> GetData()
        {
            foreach (var strategy in Strategies)
            {
                try
                {
                    IDbDataAdapter adapter = null;
                    var accessContext = new DataAccessContext(strategy);
                    adapter = accessContext.EstablishDataAccess(adapter);
                    var myRenderer = new DataRenderer(adapter);
                    var writer = new StringWriter();
                    myRenderer.Render(writer);
                    var result = writer.ToString().Replace(" ", string.Empty);
                    var rows = result.Split("\r\n").Where(e => !string.IsNullOrEmpty(e));
                    var departments = rows.Select(e => new SkycoreHRM.Shared.Department { Name = e });
                    return departments;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return null;
        }
        private class Nested
        {
            internal static readonly DataLazySingleton instance = new DataLazySingleton();
            static Nested() {}
        }
    }
}
