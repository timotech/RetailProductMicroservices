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
    public class StockPriceRepo : IStockPrice
    {
        private ApplicationDbContext _context;
        public StockPriceRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<StockPrice> AddStockPrice(StockPrice StockPrice)
        {
            _context.StockPrices.Add(StockPrice);
            await _context.SaveChangesAsync();
            return StockPrice;
        }

        public async Task<StockPrice> DeleteStockPrice(int id)
        {
            StockPrice StockPrice = _context.StockPrices.Find(id);
            if (StockPrice != null)
            {
                _context.StockPrices.Remove(StockPrice);
                await _context.SaveChangesAsync();
            }
            return StockPrice;
        }

        public async Task<IEnumerable<StockPrice>> GetStockPrices()
        {
            return await _context.StockPrices.ToListAsync();
        }

        public async Task<StockPrice> GetStockPrice(int id)
        {
            return await _context.StockPrices.FindAsync(id);
        }

        public async Task<StockPrice> UpdateStockPrice(StockPrice StockPrice)
        {
            var StockPriceChanges = _context.StockPrices.Attach(StockPrice);
            StockPriceChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return StockPrice;
        }
    }
}
