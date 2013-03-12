using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNames
{
    class Program
    {
        static void Main(string[] args)
        {
            students Kiro = new students("Kiril", "Daskalov");
            students Go6o = new students("Go6ko", "Petrov");
            students Rami = new students("Rami", "Popov");
            
            List<students> all = new List<students>();

            all.Add(Kiro);
            all.Add(Go6o);
            all.Add(Rami);
            
            var newList  = from names  in all orderby students.FirstName;

            
        }
    }
}