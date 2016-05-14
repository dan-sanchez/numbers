using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatCounting
{
    public class GreatCounting
    {
        /// <summary>
        /// Retrieve formatted string of numbers from 1-100 replaced when divisble by a 
        /// supplied keys with corresponding supplied values
        /// </summary>
        /// <param name="values">Dictionary of key-value pairs (int,string) of divisible number, and replacement string</param>
        /// <returns>A formatted string of numbers 1-100 replaced by specified values</returns>
        public static string GetNumbers(Dictionary<int, string> values)
        {
            var s = new StringBuilder();
            var isDivisible = false;

            for (int i = 1; i <= 100; i++)
            {
                foreach (var item in values)
                {
                    if (i % item.Key == 0)
                    {
                        // Display divisible items in line, and set divisible flag
                        s.Append(item.Value);
                        isDivisible = true;
                    }
                }
                     
                // If 'i' was not divisible by any of the supplied values, display 'i'.          
                if (!isDivisible)
                {
                    s.Append(i.ToString());
                }
                
                // Reset divisible flag for next iteration
                isDivisible = false;
                s.AppendLine("");
            }

            return s.ToString();
        }
    }
}
