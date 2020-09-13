using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Data;
using TradeMicroservices.Domain.Models.Traders;
using TradeMicroservices.Services;

namespace TradeMicroservices.Repositories
{
    public class TradesRepo : ITrade
    {
        private ApplicationDbContext _context;
        public TradesRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Trade> AddTrade(Trade Trade)
        {
            _context.Trades.Add(Trade);
            await _context.SaveChangesAsync();
            return Trade;
        }

        public async Task<Trade> DeleteTrade(int id)
        {
            Trade Trade = _context.Trades.Find(id);
            if (Trade != null)
            {
                _context.Trades.Remove(Trade);
                await _context.SaveChangesAsync();
            }
            return Trade;
        }

        public async Task<IEnumerable<Trade>> GetTrades()
        {
            return await _context.Trades.ToListAsync();
        }

        public async Task<Trade> GetTrade(int id)
        {
            return await _context.Trades.FindAsync(id);
        }

        public async Task<Trade> UpdateTrade(Trade Trade)
        {
            var TradeChanges = _context.Trades.Attach(Trade);
            TradeChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Trade;
        }
    }
}
