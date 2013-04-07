using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divided_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Въведеге число, което да проверим дали се дели на 7 и 5 едновременно:");
            a = Console.ReadLine();
            int b;
            b = Convert.ToInt32(a);
          
            Console.WriteLine("Числато \"{0}\" се дале на 5 и 7 ? : {1}", b, b%5 & b%7);
        }
    }
}
