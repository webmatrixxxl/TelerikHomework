﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            School Vazov = new School("05 SOU Ivan Vazov");
            Course ItCourse = new Course("Information Technologies");

            Student studentIvo = new Student("Ivo Popov", 1001);

            ItCourse.AddStudent(studentIvo);
        }
    }
}
