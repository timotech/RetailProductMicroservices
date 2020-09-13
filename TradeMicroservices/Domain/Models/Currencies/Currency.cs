using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Domain.Models.Currencies
{
    public class Currency
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Code { get; set; } //e.g USD
        public string Name { get; set; }
        public decimal Rate { get; set; } //as against the price of 1 dollar
        public bool IsBaseCurrency { get; set; } //USD should be our base currency
        public bool IsActive { get; set; }
    }
}
