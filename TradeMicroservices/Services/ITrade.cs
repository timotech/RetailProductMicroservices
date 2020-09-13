using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Services
{
    public interface ITrade
    {
        Task<IEnumerable<Trade>> GetTrades();
        Task<Trade> GetTrade(int id);
        Task<Trade> AddTrade(Trade trade);
        Task<Trade> UpdateTrade(Trade trade);
        Task<Trade> DeleteTrade(int id);
    }
}
