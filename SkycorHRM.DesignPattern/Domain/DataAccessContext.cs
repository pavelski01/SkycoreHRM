using System.Data;

namespace SkycorHRM.DesignPattern.Domain
{
    public class DataAccessContext
    {
        private readonly IDataAccessStrategy _dataAccessStrategy;
        public DataAccessContext(IDataAccessStrategy dataAccessStrategy)
        {
            _dataAccessStrategy = dataAccessStrategy;
        }
        public IDbDataAdapter EstablishDataAccess(IDbDataAdapter adapter)
        {
            return _dataAccessStrategy.Prepare(adapter);
        }
    }
}
