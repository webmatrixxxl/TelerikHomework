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
using MusicStore.Data;

namespace MusicStore.WebAPI.Controllers
{
    public class ArtistsController : ApiController
    {
        private MusicStoreEntities db = new MusicStoreEntities();

        public ArtistsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/Artists
        public IEnumerable<Artist> GetArtists()
        {
            return db.Artists.AsEnumerable();
        }

        // GET api/Artists/5
        public Artist GetArtist(int id)
        {
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return artist;
        }

        // PUT api/Artists/5
        public HttpResponseMessage PutArtist(int id, Artist artist)
        {
            var artistToUpdate = db.Artists.Find(id);

            if (ModelState.IsValid && artistToUpdate.Id == id)
            {
                db.Entry(artistToUpdate).State = EntityState.Modified;

                try
                {
                    artistToUpdate.Albums = artist.Albums;
                    artistToUpdate.DateOfBirth = artist.DateOfBirth;
                    artistToUpdate.Name = artist.Name;

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

        // POST api/Artists
        public HttpResponseMessage PostArtist(Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, artist);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = artist.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Artists/5
        public HttpResponseMessage DeleteArtist(int id)
        {
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Artists.Remove(artist);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, artist);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}