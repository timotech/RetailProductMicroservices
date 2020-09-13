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
    public class TraderController : ControllerBase
    {
        private ITrader _trader;

        public TraderController(ITrader trader)
        {
            _trader = trader;
        }

        // GET: api/Trader
        [HttpGet]
        public async Task<IEnumerable<Trader>> GetTrader()
        {
            return await _trader.GetTraders();
        }

        // GET: api/Trader/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trader>> GetTrader(int id)
        {
            var Trader = await _trader.GetTrader(id);

            if (Trader == null)
            {
                return NotFound();
            }

            return Trader;
        }

        // PUT: api/Trader
        [HttpPut]
        public async Task<ActionResult<Trader>> PutTrader(Trader Trader)
        {
            var update = await _trader.UpdateTrader(Trader);
            return update;
        }

        // POST: api/Trader
        [HttpPost]
        public async Task<ActionResult<Trader>> PostTrader(Trader Trader)
        {
            return await _trader.AddTrader(Trader);
        }

        // DELETE: api/Trader/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trader>> DeleteTrader(int id)
        {
            var Trader = await _trader.DeleteTrader(id);
            if (Trader == null)
            {
                return NotFound();
            }

            return Trader;
        }
    }
}
