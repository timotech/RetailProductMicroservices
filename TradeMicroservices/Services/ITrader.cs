using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Services
{
    public interface ITrader
    {
        Task<IEnumerable<Trader>> GetTraders();
        Task<Trader> GetTrader(int id);
        Task<Trader> AddTrader(Trader Trader);
        Task<Trader> UpdateTrader(Trader Trader);
        Task<Trader> DeleteTrader(int id);
    }
}
