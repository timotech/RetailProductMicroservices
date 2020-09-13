using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Services
{
    public interface ITraderInventory
    {
        Task<IEnumerable<TraderInventory>> GetTraderInventory();
        Task<TraderInventory> GetTraderInventory(int id);
        Task<TraderInventory> AddTraderInventory(TraderInventory TraderInventory);
        Task<TraderInventory> UpdateTraderInventory(TraderInventory TraderInventory);
        Task<TraderInventory> DeleteTraderInventory(int id);
    }
}
