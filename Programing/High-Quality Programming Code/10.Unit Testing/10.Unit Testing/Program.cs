using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            School Vazov = new School("05 SOU Ivan Vazov");
            Course ItCourse = new Course("Information Technologies");
            Student studentIvo = new Student("Ivo Popov");
            Student studentGosho = new Student("Gosho Petkov");
            Student studentMinka = new Student("Minka Svirkata");

            Vazov.Courses.Add(ItCourse);
            Vazov.SchoolStudents.Add(studentIvo);
            Vazov.SchoolStudents.Add(studentGosho);
            Vazov.SchoolStudents.Add(studentMinka);

            ItCourse.AddStudent(studentIvo);
           

            
            Console.WriteLine(studentIvo.Id);
            Console.WriteLine(studentGosho.Id);
            Console.WriteLine(studentMinka.Id);
        }
    }
}
