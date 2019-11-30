using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;

namespace CoinmarketUpdaterTask
{
    public class ApiQueryEngine
    {
        private string _url = "https://api.coinmarketcap.com";
        
        public IList<ApiModel> Query()
        {
            var client = new RestClient(_url);
            var request = new RestRequest("/v2/ticker/", Method.GET);

            var result = client.Execute(request);

            JObject dynamicContent = JObject.Parse(result.Content);

            var list = new List<ApiModel>();
            foreach (var item in dynamicContent["data"])
            {
                list.Add(JsonConvert.DeserializeObject<ApiModel>(item.First.ToString()));
            }
            return list;
        }
    }
}
