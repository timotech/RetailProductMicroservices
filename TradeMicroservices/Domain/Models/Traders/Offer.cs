using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Traders
{
    public class Offer
    {
        public int Id { get; set; }
        public int TraderId { get; set; }
        public int StockItemId { get; set; }
        public decimal Quantity { get; set; }
        public bool Buy { get; set; }
        public bool Sell { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime OfferDate { get; set; }
    }
}
