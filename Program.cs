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
            countriesDict.Add("Canad�", "Canada");
            countriesDict.Add("Espa�a", "Spain");
            Console.WriteLine(countriesDict["Canad�"]);
            Console.WriteLine(countriesDict["Espa�a"]);
            Console.ReadLine();
        }
    }
}
