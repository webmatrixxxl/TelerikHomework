//  Task 01. Using c0de first approach, create database for student system with the following tables:
//  Students (with Id, Name, Number, etc.)
//  Courses (Name, Description, Materials, etc.)
//  StudentsInCourses (many-to-many relationship)
//  Homework (one-to-many relationship with students and courses), fields: Content, TimeSent
//  Annotate the data models with the appropriate attributes and enable code first migrations

//  Task 02. Write a console application that uses the data

//  Task 03 .Seed the data with random values



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
    internal class Client
    {
        static void Main(string[] args)
        {
            // All tasks: 
            var db = new University_CodeFirstContext();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<University_CodeFirstContext, Configuration>());

            var course = new Course
            {
                Description = "Шопско хоро",
                Materials = "Video of playing",
                Name = "Хоро Курс"
            };

            db.Course.Add(course);

            var student = new Student();

            student.Name = "Димитър божков";
            student.Number = 123;
            student.Courses.Add(course);
            student.Homeworks.Add(new Homework
            {
                Content = "Дайкино хоро",
                TimeSent = new DateTime(2012, 02, 01),
                DeadLine = new DateTime(2013, 01, 15)
            });

            db.Student.Add(student);
            db.SaveChanges();
        }
    }
}