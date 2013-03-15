using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that from a given array of students finds all students
//whose first name is before its last name alphabetically. Use LINQ query operators.


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
            
            var newList  = from names  in all where names.FirstName.CompareTo(names.LastName) < 0 select names;

            foreach (var item in newList)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}