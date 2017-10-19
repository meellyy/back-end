using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;
using static WcfServiceLibrary.Service1;

namespace Meellyy.TestingConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            //GlobWeather.GlobalWeatherSoapClient client = new GlobWeather.GlobalWeatherSoapClient();
            //var cities = client.GetCitiesByCountry("Uzbekistan");
            Uri baseAddress = new Uri("http://localhost:4567/GettingStarted/");
            ServiceHost selfHost = new ServiceHost(typeof(DataRetriever), baseAddress);
            try
            {
                //selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");
                selfHost.AddServiceEndpoint(typeof(IRetrieveData), new WSHttpBinding(), "DataRetriever");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();


                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
            Console.ReadLine();
            //fuck github
        }
    }
}
