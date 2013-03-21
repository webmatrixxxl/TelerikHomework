using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  We are g1iven a school. In the school there are classes of students. Each class has a set of teachers. 
//  Each teacher teaches a set of disciplines. Students have name and unique class number. 
//  Classes have unique text identifier. Teachers have name. Disciplines have name, number 
//  of lectures and number of exercises. Both teachers and students are people. Students,
//  classes, teachers and disciplines could have optional comments (free text block).
//  Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
//  encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 
 
namespace _01.StudentsAndUni
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Disciplines Biology = new Disciplines("Биология", 1, 5);
            Disciplines Chemistry = new Disciplines("Химия", 1, 5);
            Disciplines Physics = new Disciplines("Физика", 1, 5);

            Teacher Jorge = new Teacher("Георги Петров").AddDiscipline(Biology,Chemistry,Physics);
            Student Pesho = new Student(1,"Пешо Вървев");
            Student Jon = new Student(2, "Джон Ленън");

            Grade A10 = new Grade("Klas 10a").AddStudent(Pesho).AddTeacher(Jorge);


          
        }
    }
}
