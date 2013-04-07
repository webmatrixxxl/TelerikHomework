using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int aa, bb;
            Console.WriteLine("Изчисление на лицето на правоъгълник по зададени страни \n Моля въведете страна \"a\":");
            a = Console.ReadLine();
            aa = Convert.ToInt32(a);
            Console.WriteLine("Моля въведете страна \"b\"");
            b = Console.ReadLine();
            bb = Convert.ToInt32(b);
            Console.WriteLine("Лицето на четериъгълника е: {0}", bb * aa);

            
        }
    }
}
