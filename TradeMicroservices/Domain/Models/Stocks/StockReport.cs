using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Stocks
{
    public class StockReport
    {
        public int Id { get; set; }
        public DateTime TradingDate { get; set; }
        public int StockItemId { get; set; }
        public int CurrencyId { get; set; }
        public decimal FirstPrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Quantity { get; set; }
    }
}
