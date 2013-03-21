using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddOreven
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Въведете цяло число: ");
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            b = b % 2;
            Console.WriteLine("Числото четно \"{1}\" ли е ? : {0}",b==0,a);
           
        }
    }
}
