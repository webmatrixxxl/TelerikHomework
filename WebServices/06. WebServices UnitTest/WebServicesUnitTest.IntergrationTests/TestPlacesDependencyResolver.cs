using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;
using WebServicesUnitTest.Repositories;
using WebServicesUnitTest.Model;
using WebServicesUnitTest.WebAPI.Controllers;

namespace WebServicesUnitTest.IntergrationTests
{
    class TestPlacesDependencyResolver<T> : IDependencyResolver
    {
        private IRepository<T> repository;

        public IRepository<T> Repository
        {
            get
            {
                return this.repository;
            }
            set
            {
                this.repository = value;
            }
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(SchoolsController))
            {
                return new SchoolsController(this.Repository as IRepository<Schools>);
            }
            else if (serviceType == typeof(SchoolsController))
            {
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {

        }
    }
}
