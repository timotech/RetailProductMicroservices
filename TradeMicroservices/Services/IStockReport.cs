using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Stocks;

namespace TradeMicroservices.Services
{
    public interface IStockReport
    {
        Task<IEnumerable<StockReport>> GetStockReports();
        Task<StockReport> GetStockReport(int id);
        Task<StockReport> AddStockReport(StockReport stockReport);
        Task<StockReport> UpdateStockReport(StockReport stockReport);
        Task<StockReport> DeleteStockReport(int id);
    }
}
