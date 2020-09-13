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
    public class OffersRepo : IOffer
    {
        private ApplicationDbContext _context;
        public OffersRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Offer> AddOffer(Offer Offer)
        {
            _context.Offers.Add(Offer);
            await _context.SaveChangesAsync();
            return Offer;
        }

        public async Task<Offer> DeleteOffer(int id)
        {
            Offer Offer = _context.Offers.Find(id);
            if (Offer != null)
            {
                _context.Offers.Remove(Offer);
                await _context.SaveChangesAsync();
            }
            return Offer;
        }

        public async Task<IEnumerable<Offer>> GetOffers()
        {
            return await _context.Offers.ToListAsync();
        }

        public async Task<Offer> GetOffer(int id)
        {
            return await _context.Offers.FindAsync(id);
        }

        public async Task<Offer> UpdateOffer(Offer Offer)
        {
            var OfferChanges = _context.Offers.Attach(Offer);
            OfferChanges.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Offer;
        }
    }
}
