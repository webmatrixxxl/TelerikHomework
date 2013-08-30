using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebServicesUnitTest.Model;
using WebServicesUnitTest.Repositories;

namespace WebServicesUnitTest.WebAPI.Controllers
{
    public class SchoolsController : ApiController
    {
        private StudentsEntities db = new StudentsEntities();
        private IRepository<Schools> schoolsRepository;


        public SchoolsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        public SchoolsController(IRepository<Schools> categoriesRepository)
        {
            this.schoolsRepository = schoolsRepository;
        }

        // GET api/Schools
        public IEnumerable<Schools> GetSchools()
        {
            return db.Schools.AsEnumerable();
        }

        // GET api/Schools/5
        public Schools GetSchools(int id)
        {
            Schools schools = db.Schools.Find(id);
            if (schools == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return schools;
        }

        // PUT api/Schools/5
        public HttpResponseMessage PutSchools(int id, Schools schools)
        {
            var schoolToUpdate = db.Schools.Find(id);

            if (ModelState.IsValid && schoolToUpdate.Id == id)
            {
                db.Entry(schoolToUpdate).State = EntityState.Modified;

                try
                {
                    schoolToUpdate.Name = schools.Name;
                    schoolToUpdate.Location = schools.Location;

                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Schools
        public HttpResponseMessage PostSchools(Schools schools)
        {
            if (ModelState.IsValid)
            {
                db.Schools.Add(schools);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, schools);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = schools.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Schools/5
        public HttpResponseMessage DeleteSchools(int id)
        {
            Schools schools = db.Schools.Find(id);
            if (schools == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Schools.Remove(schools);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, schools);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}