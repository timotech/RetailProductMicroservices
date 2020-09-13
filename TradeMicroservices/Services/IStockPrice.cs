using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Stocks;

namespace TradeMicroservices.Services
{
    public interface IStockPrice
    {
        Task<IEnumerable<StockPrice>> GetStockPrices();
        Task<StockPrice> GetStockPrice(int id);
        Task<StockPrice> AddStockPrice(StockPrice stockPrice);
        Task<StockPrice> UpdateStockPrice(StockPrice stockPrice);
        Task<StockPrice> DeleteStockPrice(int id);
    }
}
