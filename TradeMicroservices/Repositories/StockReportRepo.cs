using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Data;
using TradeMicroservices.Domain.Models.Stocks;
using TradeMicroservices.Services;

namespace TradeMicroservices.Repositories
{
    public class StockReportRepo : IStockReport
    {
        private ApplicationDbContext _context;
        public StockReportRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<StockReport> AddStockReport(StockReport StockReport)
        {
            _context.StockReports.Add(StockReport);
            await _context.SaveChangesAsync();
            return StockReport;
        }

        public async Task<StockReport> DeleteStockReport(int id)
        {
            StockReport StockReport = _context.StockReports.Find(id);
            if (StockReport != null)
            {
                _context.StockReports.Remove(StockReport);
                await _context.SaveChangesAsync();
            }
            return StockReport;
        }

        public async Task<IEnumerable<StockReport>> GetStockReports()
        {
            return await _context.StockReports.ToListAsync();
        }

        public async Task<StockReport> GetStockReport(int id)
        {
            return await _context.StockReports.FindAsync(id);
        }

        public async Task<StockReport> UpdateStockReport(StockReport StockReport)
        {
            var StockReportChanges = _context.StockReports.Attach(StockReport);
            StockReportChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return StockReport;
        }
    }
}
