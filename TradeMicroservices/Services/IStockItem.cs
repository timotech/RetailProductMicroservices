using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Stocks;

namespace TradeMicroservices.Services
{
    public interface IStockItem
    {
        Task<IEnumerable<StockItem>> GetStockItems();
        Task<StockItem> GetStockItem(int id);
        Task<StockItem> AddStockItem(StockItem stockItem);
        Task<StockItem> UpdateStockItem(StockItem stockItem);
        Task<StockItem> DeleteStockItem(int id);
    }
}
