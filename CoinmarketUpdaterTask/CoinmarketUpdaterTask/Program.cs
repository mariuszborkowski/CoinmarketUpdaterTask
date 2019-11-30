using CoinmarketUpdaterTask.Db;
using CoinmarketUpdaterTask.Models;
using System;
using System.Linq;

namespace CoinmarketUpdaterTask
{
    public class Program
    {
        private static ApiQueryEngine apiQueryEngine = new ApiQueryEngine();
        private static DbManager _dbManager = new DbManager();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = apiQueryEngine.Query();
            _dbManager.SaveAll(list);

        }
    }
}