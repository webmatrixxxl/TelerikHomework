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

namespace WebServicesUnitTest.WebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        private StudentsEntities db = new StudentsEntities();

        public StudentsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }


        // GET api/Students
        public IEnumerable<Students> GetStudents()
        {
            var students = db.Students.Include(s => s.Schools);
            return students.AsEnumerable();
        }

        // GET api/Students/5
        public Students GetStudents(int id)
        {
            Students students = db.Students.Find(id);
            if (students == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return students;
        }

        // PUT api/Students/5
        public HttpResponseMessage PutStudents(int id, Students students)
        {
            var studentToUpdate = db.Students.Find(id);

            if (ModelState.IsValid && studentToUpdate.Id == id)
            {
                db.Entry(studentToUpdate).State = EntityState.Modified;

                try
                {
                    studentToUpdate.FirstName = students.FirstName;
                    studentToUpdate.LastName = students.LastName;
                    studentToUpdate.Age = students.Age;
                    studentToUpdate.Grade = students.Grade;
                    studentToUpdate.Marks = students.Marks;
                    studentToUpdate.Schools = students.Schools;

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

        // POST api/Students
        public HttpResponseMessage PostStudents(Students students)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(students);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, students);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = students.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Students/5
        public HttpResponseMessage DeleteStudents(int id)
        {
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Students.Remove(students);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, students);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}