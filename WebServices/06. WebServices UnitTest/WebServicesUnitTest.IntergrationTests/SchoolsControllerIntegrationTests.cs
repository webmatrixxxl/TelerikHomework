using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using WebServicesUnitTest.Model;
using Telerik.JustMock;
using WebServicesUnitTest.Repositories;

namespace WebServicesUnitTest.IntergrationTests
{
    [TestClass]
    public class schoolsControllerIntegrationTests
    {
        [TestMethod]
        public void GetAll_WhenOneSchools_ShouldReturnStatusCode200AndNotNullContent()
        {
            var mockRepository = Mock.Create<IRepository<Schools>>();
            var models = new List<Schools>();
            models.Add(new Schools()
            {
                Name = "Test Cat"
            });

            Mock.Arrange(() => mockRepository.All())
                .Returns(() => models.AsQueryable());

            var server = new InMemoryHttpServer<Schools>("http://localhost/",
                mockRepository);

            var response = server.CreateGetRequest("api/schools");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
        }

        [TestMethod]
        public void PostSchools_WhenNameIsNull_ShouldReturnStatusCode400()
        {
            var mockRepository = Mock.Create<IRepository<Schools>>();

            Mock.Arrange(() => mockRepository
                .Add(Arg.Matches<Schools>(cat => cat.Name == null)))
                    .Throws<NullReferenceException>();


            var server =
                new InMemoryHttpServer<Schools>("http://localhost/", mockRepository);

            var response = server.CreatePostRequest("api/schools",
                new Schools()
                {
                    Name = null
                });

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
