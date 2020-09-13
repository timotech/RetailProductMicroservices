using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Data;
using TradeMicroservices.Domain.Models.Currencies;
using TradeMicroservices.Services;

namespace TradeMicroservices.Repositories
{
    public class CurrencyRepo : ICurrency
    {
        private ApplicationDbContext _context;
        public CurrencyRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Currency> AddCurrency(Currency Currency)
        {
            _context.Currencies.Add(Currency);
            await _context.SaveChangesAsync();
            return Currency;
        }

        public async Task<Currency> DeleteCurrency(int id)
        {
            Currency Currency = _context.Currencies.Find(id);
            if (Currency != null)
            {
                _context.Currencies.Remove(Currency);
                await _context.SaveChangesAsync();
            }
            return Currency;
        }

        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return await _context.Currencies.ToListAsync();
        }

        public async Task<Currency> GetCurrency(int id)
        {
            return await _context.Currencies.FindAsync(id);
        }

        public async Task<Currency> UpdateCurrency(Currency Currency)
        {
            var CurrencyChanges = _context.Currencies.Attach(Currency);
            CurrencyChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Currency;
        }
    }
}
