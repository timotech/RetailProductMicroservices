using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeMicroservices.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rate = table.Column<decimal>(nullable: false),
                    IsBaseCurrency = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraderId = table.Column<int>(nullable: false),
                    StockItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Buy = table.Column<bool>(nullable: false),
                    Sell = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    OfferDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockPrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockItemId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    Buy = table.Column<decimal>(nullable: false),
                    Sell = table.Column<decimal>(nullable: false),
                    DateSaved = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradingDate = table.Column<DateTime>(nullable: false),
                    StockItemId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    FirstPrice = table.Column<decimal>(nullable: false),
                    LastPrice = table.Column<decimal>(nullable: false),
                    MinPrice = table.Column<decimal>(nullable: false),
                    MaxPrice = table.Column<decimal>(nullable: false),
                    AvgPrice = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TraderInventories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraderId = table.Column<int>(nullable: false),
                    StockItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderInventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockItemId = table.Column<int>(nullable: false),
                    SellerId = table.Column<string>(nullable: true),
                    BuyerId = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OfferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "StockItems");

            migrationBuilder.DropTable(
                name: "StockPrices");

            migrationBuilder.DropTable(
                name: "StockReports");

            migrationBuilder.DropTable(
                name: "TraderInventories");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
