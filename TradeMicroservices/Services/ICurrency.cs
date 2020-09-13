using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Currencies;

namespace TradeMicroservices.Services
{
    public interface ICurrency
    {
        Task<IEnumerable<Currency>> GetCurrencies();
        Task<Currency> GetCurrency(int id);
        Task<Currency> AddCurrency(Currency currency);
        Task<Currency> UpdateCurrency(Currency currency);
        Task<Currency> DeleteCurrency(int id);
    }
}
