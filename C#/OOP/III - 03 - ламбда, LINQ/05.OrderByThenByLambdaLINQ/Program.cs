using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the extension methods OrderBy() and ThenBy() with lambda expressions
//sort the students by first name and last name in descending order. Rewrite the same with LINQ.


namespace _05.OrderByThenByLambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            students Kiro = new students("Kiril", "Daskalov", 6);
            students Go6o = new students("Go6ko", "Petrov", 18);
            students Rami = new students("Rami", "Popov", 24);

            List<students> all = new List<students>();

            all.Add(Kiro);
            all.Add(Go6o);
            all.Add(Rami);

            var sortLambda = all.OrderByDescending(x=>x.FirstName).ThenByDescending(x=>x.LastName);

            foreach (var item in sortLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            var sortLINQ = from names in all orderby names.FirstName descending, names.LastName descending select names;
            foreach (var item in sortLINQ)
            {
                Console.WriteLine(item.FirstName +" "+ item.LastName);
            }
        }
    }
}