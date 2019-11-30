using Newtonsoft.Json;

namespace CoinmarketUpdaterTask
{
    public class ApiModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "website_slug")]
        public string WebsiteSlug { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "circulating_supply")]
        public string CirculatingSupply { get; set; }

        [JsonProperty(PropertyName = "total_supply")]
        public string TotalSupply { get; set; }

        [JsonProperty(PropertyName = "max_supply")]
        public string MaxSupply { get; set; }

        [JsonProperty(PropertyName = "quotes")]
        public Quotes Quotes { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public string LastUpdated { get; set; }

    }

    public class Quotes
    {
        [JsonProperty(PropertyName = "usd")]
        public CurrencyModel Usd { get; set; }
    }

    public class CurrencyModel
    {
        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "volume_24h")]
        public string Volume24h { get; set; }

        [JsonProperty(PropertyName = "market_cap")]
        public string MarketCap { get; set; }

        [JsonProperty(PropertyName = "percent_change_1h")]
        public string PercentChange1h { get; set; }

        [JsonProperty(PropertyName = "percent_change_24h")]
        public string PercentChange24h { get; set; }

        [JsonProperty(PropertyName = "percent_change_7d")]
        public string PercentChange7d { get; set; }
    }
}