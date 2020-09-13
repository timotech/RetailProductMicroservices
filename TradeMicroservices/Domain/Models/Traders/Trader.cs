using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Currencies;

namespace TradeMicroservices.Domain.Models.Traders
{
    public class Trader
    {
        public int Id { get; set; }
        public string UserId { get; set; } //User Id from single sign on or registration
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; } //Id of Country Trader is from
        public int CurrencyId { get; set; } //Id of Currency Trader is trading in
        public DateTime DateRegistered { get; set; }
    }
}
