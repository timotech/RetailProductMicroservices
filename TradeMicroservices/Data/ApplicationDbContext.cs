using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeMicroservices.Domain.Models.Currencies;
using TradeMicroservices.Domain.Models.Stocks;
using TradeMicroservices.Domain.Models.Traders;

namespace TradeMicroservices.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<StockReport> StockReports { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<TraderInventory> TraderInventories { get; set; }
    }
}
