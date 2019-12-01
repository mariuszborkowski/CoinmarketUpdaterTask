using CoinmarketUpdaterTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinmarketUpdaterTask.Db
{
    public class DbManager
    {

        public void SaveAll(IList<ApiModel> list)
        {
            var cryptocurencies = list.Select(x => new Cryptocurrency
            {
                CryptocurrencyId = x.Id,
                CryptocurrencyName = x.Name,
                CryptocurrencySymbol = x.Symbol,
                CryptocurrencyRank = x.Rank,
                CirculatingSupply = x.CirculatingSupply,
                TotalSupply = x.TotalSupply,
                MaxSupply = x.MaxSupply,
                Price = x.Quotes.Usd.Price,
                Volume24h = x.Quotes.Usd.Volume24h,
                MarketCap = x.Quotes.Usd.MarketCap,
                PercentChange1h = x.Quotes.Usd.PercentChange1h,
                PercentChange24h = x.Quotes.Usd.PercentChange24h,
                PercentChange7d = x.Quotes.Usd.PercentChange7d,
                LastUpdateTime = x.LastUpdated
            }).ToList();

            using var context = new lab360Context();
            context.AddRange(cryptocurencies);
            context.SaveChanges();
        }

        public void PurgeAll()
        {
            using var context = new lab360Context();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Cryptocurrency");
        }
    }
}
