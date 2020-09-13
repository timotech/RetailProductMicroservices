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
    public class CountriesRepo : ICountries
    {
        private ApplicationDbContext _context;
        public CountriesRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Country> AddCountry(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return country;
        }

        public async Task<Country> DeleteCountry(int id)
        {
            Country country = _context.Countries.Find(id);
            if(country != null)
            {
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
            }
            return country;
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetCountry(int id)
        {
            return await _context.Countries.FindAsync(id);
        }

        public async Task<Country> UpdateCountry(Country country)
        {
            var countryChanges = _context.Countries.Attach(country);
            countryChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return country;
        }
    }
}
