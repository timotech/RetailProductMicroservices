using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Traders
{
    public class Trade
    {
        public int Id { get; set; }
        public int StockItemId { get; set; }
        public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int OfferId { get; set; }
    }
}
