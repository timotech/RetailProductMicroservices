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
    public class TradersInventoryRepo : ITraderInventory
    {
        private ApplicationDbContext _context;
        public TradersInventoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TraderInventory> AddTraderInventory(TraderInventory TraderInventory)
        {
            _context.TraderInventories.Add(TraderInventory);
            await _context.SaveChangesAsync();
            return TraderInventory;
        }

        public async Task<TraderInventory> DeleteTraderInventory(int id)
        {
            TraderInventory TraderInventory = _context.TraderInventories.Find(id);
            if (TraderInventory != null)
            {
                _context.TraderInventories.Remove(TraderInventory);
                await _context.SaveChangesAsync();
            }
            return TraderInventory;
        }

        public async Task<IEnumerable<TraderInventory>> GetTraderInventory()
        {
            return await _context.TraderInventories.ToListAsync();
        }

        public async Task<TraderInventory> GetTraderInventory(int id)
        {
            return await _context.TraderInventories.FindAsync(id);
        }

        public async Task<TraderInventory> UpdateTraderInventory(TraderInventory TraderInventory)
        {
            var TraderInventoryChanges = _context.TraderInventories.Attach(TraderInventory);
            TraderInventoryChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return TraderInventory;
        }
    }
}
