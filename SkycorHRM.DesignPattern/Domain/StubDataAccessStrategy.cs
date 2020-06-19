using AdapterDemo.Test;
using System.Data;

namespace SkycorHRM.DesignPattern.Domain
{
    public class StubDataAccessStrategy : IDataAccessStrategy
    {
        public IDbDataAdapter Prepare(IDbDataAdapter adapter)
        {
            return new StubDbAdapter();
        }
    }
}
