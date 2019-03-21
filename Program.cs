using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary countriesDict = new ListDictionary(
                StringComparer.InvariantCultureIgnoreCase);
            countriesDict.Add("Estados Unidos", "United States");
            countriesDict.Add("Canadá", "Canada");
            countriesDict.Add("España", "Spain");
            Console.WriteLine(countriesDict["Canadá"]);
            Console.WriteLine(countriesDict["España"]);
            Console.ReadLine();
        }
    }
}
