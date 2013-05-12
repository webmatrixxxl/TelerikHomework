using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolCourses;
using System.Collections.Generic;

namespace SchoolCourses.Tests
{
    [TestClass]
    public class CourseTest
    {
        /// <summary>
        ///A test for Course Constructor
        ///</summary>
        [TestMethod()]
        public void CourseConstructorTest()
        {
            string name = "КПК"; // TODO: Initialize to an appropriate value
            Course target = new Course(name);
            Assert.AreEqual(name, target.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        /// <summary>
        ///A test for AddStudent
        ///</summary>
        [TestMethod()]
        public void AddStudentTest()
        {
            string name = "Иван Петров"; // TODO: Initialize to an appropriate value
            Student student = new Student("Maria Petrova");
            Course target = new Course(name,student); // TODO: Initialize to an appropriate value
            Student studentIvo = new Student("Ivo Popov");
            target.AddStudent(studentIvo);
            Assert.AreEqual(2, target.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(new Student("Maria Petroa"));
            course.AddStudent(new Student("Maria Petrova"));
            course.AddStudent(new Student("Maria etrova"));
            course.AddStudent(new Student("Maria Pva"));
            course.AddStudent(new Student("Maria Petrov"));
            course.AddStudent(new Student("Maria Ptroval"));
            course.AddStudent(new Student("Maria Prova"));
            course.AddStudent(new Student("Maria Goheva"));
            course.AddStudent(new Student("Maria"));
            course.AddStudent(new Student("Maria Geva"));
            course.AddStudent(new Student("Maria Tova"));
            course.AddStudent(new Student("Maria Gecheva"));
            course.AddStudent(new Student("Maria Gacva"));
            course.AddStudent(new Student("Maria Donkva"));
            course.AddStudent(new Student("Maria Vrankova"));
            course.AddStudent(new Student("Maria Draknova"));
            course.AddStudent(new Student("Maria Bobeva"));
            course.AddStudent(new Student("Maria Kateva"));
            course.AddStudent(new Student("Maria Bonkova"));
            course.AddStudent(new Student("Maria Kolovas"));
            course.AddStudent(new Student("Maria Simova"));
            course.AddStudent(new Student("Maria KolevaZ"));
            course.AddStudent(new Student("Maria Popovaa"));
            course.AddStudent(new Student("Maria Tsolova"));
            course.AddStudent(new Student("Maria Doneva1"));
            course.AddStudent(new Student("Maria Dakova2"));
            course.AddStudent(new Student("Maria Makova3"));
            course.AddStudent(new Student("Maria Petkova3"));
            course.AddStudent(new Student("Maria Kamenova4"));
            course.AddStudent(new Student("Maria Vuchkova5"));
            course.AddStudent(new Student("Maria Komnina5"));
        }

        /// <summary>
        ///A test for RemoveStudent
        ///</summary>
        [TestMethod()]
        public void RemoveStudentTest()
        {
            string name = "IT"; // TODO: Initialize to an appropriate value
            Course target = new Course(name); // TODO: Initialize to an appropriate value
            Student students = new Student("Pe6o Kirov"); // TODO: Initialize to an appropriate value
            target.AddStudent(students);
            target.RemoveStudent(students);
            Assert.AreEqual(target.SchoolStudents.Count, 0);
        }

        /// <summary>
        ///A test for AddStudent
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTest1()
        {
            string name = "IT"; // TODO: Initialize to an appropriate value
            Course target = new Course(name); // TODO: Initialize to an appropriate value
            Student students = new Student("Ivan Petrov"); // TODO: Initialize to an appropriate value
            Student students2 = new Student("Ivan Petrov"); // TODO: Initialize to an appropriate value
            
            target.AddStudent(students);
            target.AddStudent(students2);

            bool studentFound = false;

            for (int i = 0; i < target.Students.Count; i++)
            {
                if (target.Students[i].Name == students.Name)
                {
                    studentFound = true;
                }
            }
        }
    }
}