using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServicesUnitTest.WebAPI;
using WebServicesUnitTest.Model;
using WebServicesUnitTest.Repositories;
using System.Data.Entity;

namespace Places.Repositories.Tests
{
    [TestClass]
    public class DbCategoriesRepositoryTests
    {
        public DbContext dbContext { get; set; }

        static Random rand = new Random();

        public IRepository<Schools> categoriesRepository { get; set; }

        private static TransactionScope tranScope;

        public DbCategoriesRepositoryTests()
        {
            this.dbContext = new StudentsEntities();
            this.categoriesRepository = new DbCategoryRepository(this.dbContext);
        }

        [TestInitialize]
        public void TestInit()
        {
            tranScope = new TransactionScope();
        }

        [TestCleanup]
        public void TestTearDown()
        {
            tranScope.Dispose();
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            var cat = new Schools()
            {
                Name = "TEST EDI KVO SI "
            };
            dbContext.Set<Schools>().Add(cat);
            dbContext.SaveChanges();
            Assert.IsTrue(cat.Id > 0);
        }

        [TestMethod]
        public void Add_WhenNameIsValid_ShouldAddCategoryToDatabase()
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
            var categoryName = "Test category";
            var category = new Schools()
            {
                Name = categoryName
            };

            var createdCategory = this.categoriesRepository.Add(category);
            var foundCategory = this.dbContext.Set<Schools>().Find(createdCategory.Id);
            Assert.IsNotNull(foundCategory);
            Assert.AreEqual(categoryName, foundCategory.Name);
            //}
        }

        [TestMethod]
        public void Add_WhenNameIsValid_ShouldReturnNotZeroId()
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
            var SchoolsName = "Test Schools";
            var Schools = new Schools()
            {
                Name = SchoolsName
            };

            var createdCategory = this.categoriesRepository.Add(Schools);
            Assert.IsTrue(createdCategory.Id != 0);
            //}
        }

        [TestMethod]
        public void MyTestMethod()
        {
            int catId = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                var cat = new Schools()
                {
                    Name = "NEW Schools"
                };
                this.dbContext.Set<Schools>().Add(cat);
                this.dbContext.SaveChanges();
                scope.Complete();
                catId = cat.Id;
            }
            Assert.IsTrue(catId != 0);
            var catEntity = this.dbContext.Set<Schools>().Find(catId);
            Assert.IsNotNull(catEntity);
        }
    }
}