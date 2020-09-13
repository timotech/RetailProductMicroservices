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
    public class TradersRepo : ITrader
    {
        private ApplicationDbContext _context;
        public TradersRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Trader> AddTrader(Trader Trader)
        {
            _context.Traders.Add(Trader);
            await _context.SaveChangesAsync();
            return Trader;
        }

        public async Task<Trader> DeleteTrader(int id)
        {
            Trader Trader = _context.Traders.Find(id);
            if (Trader != null)
            {
                _context.Traders.Remove(Trader);
                await _context.SaveChangesAsync();
            }
            return Trader;
        }

        public async Task<IEnumerable<Trader>> GetTraders()
        {
            return await _context.Traders.ToListAsync();
        }

        public async Task<Trader> GetTrader(int id)
        {
            return await _context.Traders.FindAsync(id);
        }

        public async Task<Trader> UpdateTrader(Trader Trader)
        {
            var TraderChanges = _context.Traders.Attach(Trader);
            TraderChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Trader;
        }
    }
}
