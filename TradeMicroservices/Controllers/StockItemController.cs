using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeMicroservices.Domain.Models.Stocks;
using TradeMicroservices.Services;

namespace TradeMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockItemController : ControllerBase
    {
        private IStockItem _stockItem;

        public StockItemController(IStockItem stockItem)
        {
            _stockItem = stockItem;
        }

        // GET: api/StockItem
        [HttpGet]
        public async Task<IEnumerable<StockItem>> GetStockItem()
        {
            return await _stockItem.GetStockItems();
        }

        // GET: api/StockItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockItem>> GetStockItem(int id)
        {
            var StockItem = await _stockItem.GetStockItem(id);

            if (StockItem == null)
            {
                return NotFound();
            }

            return StockItem;
        }

        // PUT: api/StockItem
        [HttpPut]
        public async Task<ActionResult<StockItem>> PutStockItem(StockItem StockItem)
        {
            var update = await _stockItem.UpdateStockItem(StockItem);
            return update;
        }

        // POST: api/StockItem
        [HttpPost]
        public async Task<ActionResult<StockItem>> PostStockItem(StockItem StockItem)
        {
            return await _stockItem.AddStockItem(StockItem);
        }

        // DELETE: api/StockItem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StockItem>> DeleteStockItem(int id)
        {
            var StockItem = await _stockItem.DeleteStockItem(id);
            if (StockItem == null)
            {
                return NotFound();
            }

            return StockItem;
        }
    }
}
