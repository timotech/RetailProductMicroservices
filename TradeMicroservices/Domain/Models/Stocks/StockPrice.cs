using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Stocks
{
    public class StockPrice
    {
        public int Id { get; set; }
        public int StockItemId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public DateTime DateSaved { get; set; }
    }
}
