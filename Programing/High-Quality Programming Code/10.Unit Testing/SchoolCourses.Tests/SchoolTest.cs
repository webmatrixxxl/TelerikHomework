using SchoolCourses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolCourses.Tests
{

    /// <summary>
    ///This is a test class for SchoolTest and is intended
    ///to contain all SchoolTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SchoolTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            School newSchool = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            School newSchool = new School(name);
        }



        /// <summary>
        ///A test for School Constructor
        ///</summary>
        [TestMethod()]
        public void SchoolConstructorTest()
        {
            string name = "Ivan Vazov"; // TODO: Initialize to an appropriate value
            School target = new School(name);
            Assert.AreEqual(name, target.Name);
        }

        /// <summary>
        ///A test for School Constructor
        ///</summary>
        [TestMethod()]
        public void SchoolConstructorTest1()
        {
            string name = "Ivan Vazov"; // TODO: Initialize to an appropriate value
            List<Student> students = null; // TODO: Initialize to an appropriate value
            School target = new School(name, students);
            Assert.AreEqual(name, target.Name);
        }

        /// <summary>
        ///A test for School Constructor
        ///</summary>
        [TestMethod()]
        public void SchoolConstructorTest2()
        {
            bool isFound;
            string name = "Ivan Gorki"; 
            List<Student> students = new List<Student>() ;
            Student a = new Student("Petur Petkov");
            students.Add(a);
            School target = new School(name, students);

         
        }

        /// <summary>
        ///A test for Courses
        ///</summary>
        [TestMethod()]
        public void CoursesTest()
        {
            string name = "Banica SOU"; // TODO: Initialize to an appropriate value
            School target = new School(name); // TODO: Initialize to an appropriate value
            string courseName = "Information Technologies";
            Course ItCourse = new Course(courseName);
            target.Courses.Add(ItCourse);

            Assert.IsTrue(target.Courses.Any(course => course.Name == courseName));
        }

        /// <summary>
        ///A test for SchoolStudents
        ///</summary>
        [TestMethod()]
        public void SchoolStudentsTest()
        {
            string name = "Pen4o Ivanov 05"; // TODO: Initialize to an appropriate value
            School target = new School(name); // TODO: Initialize to an appropriate value
            string studentName = "Ivan Grigorov";
            Student expected = new Student(studentName);
            target.SchoolStudents.Add(expected);
            Assert.AreEqual(expected.Name, studentName);
        }

        /// <summary>
        ///A test for School Constructor
        ///</summary>
        [TestMethod()]
        public void SchoolConstructorTest3()
        {
            string name = "Student"; // TODO: Initialize to an appropriate value
            Student students = new Student("Peter"); // TODO: Initialize to an appropriate value
            School target = new School(name, students);
            Assert.AreEqual(target.Name, name);
        }
    }
}