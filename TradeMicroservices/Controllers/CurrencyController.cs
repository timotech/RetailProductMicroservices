using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeMicroservices.Domain.Models.Currencies;
using TradeMicroservices.Services;

namespace TradeMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrency _Currencies;

        public CurrencyController(ICurrency Currencies)
        {
            _Currencies = Currencies;
        }

        // GET: api/Currency
        [HttpGet]
        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return await _Currencies.GetCurrencies();
        }

        // GET: api/Currency/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Currency>> GetCurrency(int id)
        {
            var Currency = await _Currencies.GetCurrency(id);

            if (Currency == null)
            {
                return NotFound();
            }

            return Currency;
        }

        // PUT: api/Currency/5
        [HttpPut]
        public async Task<ActionResult<Currency>> PutCurrency(Currency Currency)
        {
            var update = await _Currencies.UpdateCurrency(Currency);
            return update;
        }

        // POST: api/Currency
        [HttpPost]
        public async Task<ActionResult<Currency>> PostCurrency(Currency Currency)
        {
            return await _Currencies.AddCurrency(Currency);
        }

        // DELETE: api/Currency/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Currency>> DeleteCurrency(int id)
        {
            var Currency = await _Currencies.DeleteCurrency(id);
            if (Currency == null)
            {
                return NotFound();
            }

            return Currency;
        }
    }
}
