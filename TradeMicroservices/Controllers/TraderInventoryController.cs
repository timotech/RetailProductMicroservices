using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeMicroservices.Domain.Models.Traders;
using TradeMicroservices.Services;

namespace TradeMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraderInventoryController : ControllerBase
    {
        private ITraderInventory _traderInventory;

        public TraderInventoryController(ITraderInventory traderInventory)
        {
            _traderInventory = traderInventory;
        }

        // GET: api/TraderInventory
        [HttpGet]
        public async Task<IEnumerable<TraderInventory>> GetTrader()
        {
            return await _traderInventory.GetTraderInventory();
        }

        // GET: api/TraderInventory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TraderInventory>> GetTraderInventory(int id)
        {
            var TraderInventory = await _traderInventory.GetTraderInventory(id);

            if (TraderInventory == null)
            {
                return NotFound();
            }

            return TraderInventory;
        }

        // PUT: api/TraderInventory
        [HttpPut]
        public async Task<ActionResult<TraderInventory>> PutTraderInventory(TraderInventory TraderInventory)
        {
            var update = await _traderInventory.UpdateTraderInventory(TraderInventory);
            return update;
        }

        // POST: api/TraderInventory
        [HttpPost]
        public async Task<ActionResult<TraderInventory>> PostTraderInventory(TraderInventory TraderInventory)
        {
            return await _traderInventory.AddTraderInventory(TraderInventory);
        }

        // DELETE: api/TraderInventory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TraderInventory>> DeleteTraderInventory(int id)
        {
            var TraderInventory = await _traderInventory.DeleteTraderInventory(id);
            if (TraderInventory == null)
            {
                return NotFound();
            }

            return TraderInventory;
        }
    }
}
