using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_CodeFirst.Data;
using University_CodeFirst.Data.Migrations;
using University_CodeFirst.Models;

namespace University_CodeFirst.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var db = new University_CodeFirstContext();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<University_CodeFirstContext, Configuration>());


            var course = new Course {
                Description = "Шопско хоро",
                Materials = "Video of playing",
                Name="Хоро Курс" 
            };

            db.Course.Add(course);

            var student = new Student();

            student.Name = "Димитър божков";
            student.Number = 123;
            student.Courses.Add(course);
            student.Homeworks.Add(new Homework {
                Content = "Дайкино хоро",
                TimeSent = new DateTime(2012,02,01),
                DeadLine = new DateTime(2013,01,15) 
            });

            db.Student.Add(student);
            db.SaveChanges();


        }


    }
}
