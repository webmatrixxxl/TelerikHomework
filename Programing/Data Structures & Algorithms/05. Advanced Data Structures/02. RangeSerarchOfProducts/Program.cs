using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.RangeSerarchOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<Product> catalog = new OrderedBag<Product>();

            Random random = new Random();
            for (int i = 0; i < 50000; i++)
            {
                catalog.Add(new Product("item" + i, random.Next(0, int.MaxValue)));
            }
            var prices = catalog.FindAll(x => x.Price > 100 && x.Price < 150);

            for (int i = 0; i < 10000; i++)
            {
                int min = random.Next(0, int.MaxValue);
                int max = random.Next(min, int.MaxValue);
                prices = catalog.FindAll(x => x.Price > min && x.Price < max);
            }

            //print only the result of the last search becouse printing is very slow operation
            int count = 20;
            foreach (var item in prices)
            {
                Console.WriteLine("name:" + item.Name + "-> price:" + item.Price);
                count -= 1;
                if (count <= 0)
                {
                    break;
                }
            }
        }
    }
}
