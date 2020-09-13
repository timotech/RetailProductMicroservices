using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Traders
{
    public class TraderInventory
    {
        public int Id { get; set; }
        public int TraderId { get; set; }
        public int StockItemId { get; set; }
        public decimal Quantity { get; set; }
    }
}
