using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public class CalculatorService : ICalculator
        {
            public double Add(double n1, double n2)
            {
                double result = n1 + n2;
                Console.WriteLine("Received Add({0},{1})", n1, n2);
                Console.WriteLine("Return: {0}", result);
                return result;
            }
        }
        public class DataRetriever : IRetrieveData
        {
            public string retrieveFromTestTable()
            {
                string result = "";
                //List<string> stringList = new List<string>();
                using (var db = new LocalDB())
                {
                    var query = from t in db.Tables
                                orderby t.Id
                                select t;

                    foreach(var item in query)
                    {
                        result = result + string.Format("{0}, {1}, {2}", item.Id, item.Foo, item.Bar) + System.Environment.NewLine;
                    }
                }
                    return result;
            }

        }
    }
}
