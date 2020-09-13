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
    public class StockReportController : ControllerBase
    {
        private IStockReport _stockReport;

        public StockReportController(IStockReport stockReport)
        {
            _stockReport = stockReport;
        }

        // GET: api/StockReport
        [HttpGet]
        public async Task<IEnumerable<StockReport>> GetStockReports()
        {
            return await _stockReport.GetStockReports();
        }

        // GET: api/StockReport/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockReport>> GetStockReport(int id)
        {
            var StockReport = await _stockReport.GetStockReport(id);

            if (StockReport == null)
            {
                return NotFound();
            }

            return StockReport;
        }

        // PUT: api/StockReport/5
        [HttpPut]
        public async Task<ActionResult<StockReport>> PutStockReport(StockReport StockReport)
        {
            var update = await _stockReport.UpdateStockReport(StockReport);
            return update;
        }

        // POST: api/StockReport
        [HttpPost]
        public async Task<ActionResult<StockReport>> PostStockReport(StockReport StockReport)
        {
            return await _stockReport.AddStockReport(StockReport);
        }

        // DELETE: api/StockReport/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StockReport>> DeleteStockReport(int id)
        {
            var StockReport = await _stockReport.DeleteStockReport(id);
            if (StockReport == null)
            {
                return NotFound();
            }

            return StockReport;
        }
    }
}
