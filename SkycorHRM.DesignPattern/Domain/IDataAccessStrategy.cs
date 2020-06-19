using System.Data;

namespace SkycorHRM.DesignPattern.Domain
{
    public interface IDataAccessStrategy
    {
        IDbDataAdapter Prepare(IDbDataAdapter adapter);
    }
}
