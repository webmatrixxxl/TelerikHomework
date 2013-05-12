using SchoolCourses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SchoolCourses.Tests
{
    
    
    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
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


        /// <summary>
        ///A test for Student Constructor
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest()
        {
            string name = "Пешо Крика"; // TODO: Initialize to an appropriate value
            Student target = new Student(name);
            Assert.AreEqual(name,target.Name);
        }

        /// <summary>
        ///A test for Id
        ///</summary>
        [TestMethod()]
        public void IdTest()
        {
            string name = "Pe6o Krika"; // TODO: Initialize to an appropriate value
            Student target = new Student(name); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Id;
            Assert.AreEqual(actual, Student.CurrentId);
        }

        /// <summary>
        ///A test for Student Constructor
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentConstructorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Student target = new Student(name);
        }

        /// <summary>
        ///A test for CurrentId
        ///</summary>
        [TestMethod()]
        public void CurrentIdTest()
        {
            int actual;
            actual = Student.CurrentId;
            Assert.AreEqual(actual,Student.CurrentId);
        }

        /// <summary>
        ///A test for Id
        ///</summary>
        [TestMethod()]
        public void IdTest1()
        {
            string name = "Petko Karav"; // TODO: Initialize to an appropriate value
            Student target = new Student(name); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Id;
            Assert.AreEqual(actual, Student.CurrentId);
        }
    }
}