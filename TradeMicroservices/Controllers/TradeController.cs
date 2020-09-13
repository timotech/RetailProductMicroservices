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
    public class TradeController : ControllerBase
    {
        private ITrade _trade;

        public TradeController(ITrade trade)
        {
            _trade = trade;
        }

        // GET: api/Trade
        [HttpGet]
        public async Task<IEnumerable<Trade>> GetTrade()
        {
            return await _trade.GetTrades();
        }

        // GET: api/Trade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trade>> GetTrade(int id)
        {
            var Trade = await _trade.GetTrade(id);

            if (Trade == null)
            {
                return NotFound();
            }

            return Trade;
        }

        // PUT: api/Trade/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Trade>> PutTrade(Trade Trade)
        {
            var update = await _trade.UpdateTrade(Trade);
            return update;
        }

        // POST: api/Trade
        [HttpPost]
        public async Task<ActionResult<Trade>> PostTrade(Trade Trade)
        {
            return await _trade.AddTrade(Trade);
        }

        // DELETE: api/Trade/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trade>> DeleteTrade(int id)
        {
            var Trade = await _trade.DeleteTrade(id);
            if (Trade == null)
            {
                return NotFound();
            }

            return Trade;
        }
    }
}
