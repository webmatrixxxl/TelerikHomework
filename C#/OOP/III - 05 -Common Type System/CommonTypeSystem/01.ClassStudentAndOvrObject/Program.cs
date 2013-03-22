using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudentAndOvrObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Pe6o = new Student("Kiril", "Dimitrov", "Daskalov", 1535, "Sofia", 0878756132, "webmatrix@mail.bg", Enumeration.University.SU, Enumeration.Faculty.Philosophy, Enumeration.Specialty.Entrepreneurship);
            Student kon = new Student("Kirild", "Dimitrov", "Daskalov", 1535, "Sofia", 0878756132, "webmatrix@mail.bg", Enumeration.University.SU, Enumeration.Faculty.Philosophy, Enumeration.Specialty.Entrepreneurship);
            Console.WriteLine(Pe6o.Equals(kon));
        }
    }
}
