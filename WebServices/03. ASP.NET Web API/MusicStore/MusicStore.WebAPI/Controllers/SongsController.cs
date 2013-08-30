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
    public class SongsController : ApiController
    {
        private MusicStoreEntities db = new MusicStoreEntities();

        public SongsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/Songs
        public IEnumerable<Song> GetSongs()
        {
            var songs = db.Songs.Include(s => s.Album).Include(s => s.Artist);
            return songs.AsEnumerable();
        }

        // GET api/Songs/5
        public Song GetSong(int id)
        {
            Song song = db.Songs.Find(id);
            if (song == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return song;
        }

        // PUT api/Songs/5
        public HttpResponseMessage PutSong(int id, Song song)
        {
            var songToUpdate = db.Songs.Find(id);

            if (ModelState.IsValid && id == songToUpdate.Id)
            {
                db.Entry(songToUpdate).State = EntityState.Modified;

                try
                {
                    songToUpdate.Album = song.Album;
                    songToUpdate.Artist = song.Artist;
                    songToUpdate.Genre = song.Genre;
                    songToUpdate.Title = song.Title;
                    songToUpdate.Year = song.Year;

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

        // POST api/Songs
        public HttpResponseMessage PostSong(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(song);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, song);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = song.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Songs/5
        public HttpResponseMessage DeleteSong(int id)
        {
            Song song = db.Songs.Find(id);
            if (song == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Songs.Remove(song);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, song);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}