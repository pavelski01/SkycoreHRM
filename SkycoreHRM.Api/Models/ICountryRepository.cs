using SkycoreHRM.Shared;
using System.Collections.Generic;

namespace SkycoreHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
