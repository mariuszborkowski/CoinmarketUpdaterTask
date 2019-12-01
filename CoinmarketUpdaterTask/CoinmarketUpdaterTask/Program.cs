using CoinmarketUpdaterTask.Db;
using CoinmarketUpdaterTask.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace CoinmarketUpdaterTask
{
    public class Program
    {
        public Program()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();
            var configurationSection = configuration.GetSection("AppConfig").GetSection("FilePath");


        }

        private static ApiQueryEngine apiQueryEngine = new ApiQueryEngine();
        private static DbManager _dbManager = new DbManager();

        static void Main(string[] args)
        {
            while (true)
            {
                var list = apiQueryEngine.Query();
                _dbManager.PurgeAll();
                _dbManager.SaveAll(list);
                Console.WriteLine("Saved/Updated coinmarket data");
                Thread.Sleep(5 * 60 * 100);
            }
        }
    }
}