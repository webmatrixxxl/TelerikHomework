using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServicesUnitTest.Model;

namespace ConsoleApplicationEntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsEntities db = new StudentsEntities();

            Schools school = new Schools{Name ="Ivan Vazov", Location = "Ivan susanin str"};

            db.Schools.Add(school);
            db.SaveChanges();
        }
    }
}
