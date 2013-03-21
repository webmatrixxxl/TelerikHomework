using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbersBetweenNand0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please ENTER integer from 2 to \"n\" and see numbers between 0 and \"n\". n=");
            string n = Console.ReadLine();
            int n1;
            bool checkN = int.TryParse(n, out n1) && n1>1;
            while (checkN == false)
            {
                Console.Write("Plese enter again \"n\", but this time integer.  n=");
                n = Console.ReadLine();
                checkN = int.TryParse(n, out n1);
            }
            while (2<n1)
            {
                n1--;
                Console.WriteLine(n1);
                
                
            }
        }
    }
}
