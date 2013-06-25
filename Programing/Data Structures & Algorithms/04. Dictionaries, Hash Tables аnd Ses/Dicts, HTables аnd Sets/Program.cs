using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurrencesWithDictionary
{
    public class NumberOfOccurrencesWithDictionary
    {
        static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var key in array)
            {
                int count = 0;

                if (dictionary.ContainsKey(key))
                {
                    count = dictionary[key];
                }

                dictionary[key] = count + 1;
            }

            foreach (var value in dictionary)
            {
                Console.WriteLine("{0} -> {1} times", value.Key, value.Value);
            }
        }
    }
}