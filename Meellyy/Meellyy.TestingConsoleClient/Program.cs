using Meellyy.TestingConsoleClient.RetrieveData;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Models;

namespace Meellyy.TestingConsoleClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            MongoHelper<Meals> meals = new MongoHelper<Meals>();
            Meals meal = new Meals();
            meal.Date = DateTime.Now;
            meal.Author = "";
            meals.Collection.InsertOneAsync(meal);

        }
        private readonly MongoHelper<Meals> _meals;

        public void Create(Meals meal)
        {
            meal.Date = DateTime.Now;
            _meals.Collection.InsertOneAsync(meal);
        }
        public class MongoHelper<T> where T : class
        {
            public IMongoCollection<T> Collection { get; private set; }

            public MongoHelper()
            {
                var con = ConfigurationManager.AppSettings["MongoDB"];
                var server = new MongoClient(con);
                var database = server.GetDatabase(con);

                Collection = database.GetCollection<T>(typeof(T).Name.ToLower());
            }
        }
    }
}
