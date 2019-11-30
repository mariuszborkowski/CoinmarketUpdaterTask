using System;
using System.Collections.Generic;

namespace CoinmarketUpdaterTask.Models
{
    public partial class Cryptocurrency
    {
        public int Id { get; set; }
        public string CryptocurrencyName { get; set; }
        public string CryptocurrencySymbol { get; set; }
        public string CryptocurrencyRank { get; set; }
        public string CirculatingSupply { get; set; }
        public string TotalSupply { get; set; }
        public string MaxSupply { get; set; }
        public string Price { get; set; }
        public string Volume24h { get; set; }
        public string MarketCap { get; set; }
        public string PercentChange1h { get; set; }
        public string PercentChange24h { get; set; }
        public string PercentChange7d { get; set; }
        public string LastUpdateTime { get; set; }
    }
}
