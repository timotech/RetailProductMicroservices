﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeMicroservices.Domain.Models.Stocks
{
    public class StockItem
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CurrencyId { get; set; }
        public string Details { get; set; }
    }
}
