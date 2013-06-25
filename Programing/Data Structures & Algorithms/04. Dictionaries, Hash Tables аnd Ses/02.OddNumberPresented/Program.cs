using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddNumberPresented
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

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
                if (value.Value % 2 == 1)
                {
                    Console.WriteLine(value.Key);
                }
            }
        }
    }
}
