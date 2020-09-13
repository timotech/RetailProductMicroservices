using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Services
{
    public interface IOffer
    {
        Task<IEnumerable<Offer>> GetOffers();
        Task<Offer> GetOffer(int id);
        Task<Offer> AddOffer(Offer offer);
        Task<Offer> UpdateOffer(Offer offer);
        Task<Offer> DeleteOffer(int id);
    }
}
