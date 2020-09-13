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
    public class StockItemsRepo : IStockItem
    {
        private ApplicationDbContext _context;
        public StockItemsRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<StockItem> AddStockItem(StockItem StockItem)
        {
            _context.StockItems.Add(StockItem);
            await _context.SaveChangesAsync();
            return StockItem;
        }

        public async Task<StockItem> DeleteStockItem(int id)
        {
            StockItem StockItem = _context.StockItems.Find(id);
            if (StockItem != null)
            {
                _context.StockItems.Remove(StockItem);
                await _context.SaveChangesAsync();
            }
            return StockItem;
        }

        public async Task<IEnumerable<StockItem>> GetStockItems()
        {
            return await _context.StockItems.ToListAsync();
        }

        public async Task<StockItem> GetStockItem(int id)
        {
            return await _context.StockItems.FindAsync(id);
        }

        public async Task<StockItem> UpdateStockItem(StockItem StockItem)
        {
            var StockItemChanges = _context.StockItems.Attach(StockItem);
            StockItemChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return StockItem;
        }
    }
}
