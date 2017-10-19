using Meellyy.TestingConsoleClient.RetrieveData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meellyy.TestingConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RetrieveDataClient client = new RetrieveDataClient();
            string result = client.retrieveFromTestTable();
            Console.WriteLine(result);
            Console.Read();
            client.Close();
        }
    }
}
