using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Currencies;

namespace TradeMicroservices.Services
{
    public interface ICountries
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<Country> GetCountry(int id);
        Task<Country> AddCountry(Country country);
        Task<Country> UpdateCountry(Country country);
        Task<Country> DeleteCountry(int id);
    }
}
