﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meellyy.TestingConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
        	//asdasds
            Console.WriteLine("Hello World, this is development branch");
            Console.WriteLine("Hello World, this is Rusya");
            //GLobWeather.GlobalWeatherSoapClient client = new GLobWeather.GlobalWeatherSoapClient();
            //var cities = client.GetCitiesByCountry("Uzbekistan");
            //Console.ReadLine();
            //Console.WriteLine("Hello World");
            GlobWeather.GlobalWeatherSoapClient client = new GlobWeather.GlobalWeatherSoapClient();
            var cities = client.GetCitiesByCountry("Uzbekistan");
            Console.ReadLine();
        }
    }
}
