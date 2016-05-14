using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> vals = new Dictionary<int, string>();
            vals.Add(7, "seven");
            vals.Add(11, "eleven");
            vals.Add(3, "fizz");
            vals.Add(5, "buzz");


            Console.Write(GreatCounting.GreatCounting.GetNumbers(vals));
        }
    }
}
