using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CacheData.Models;

namespace CacheData.Controllers
{
    public class AuthorsController : ApiController
    {
        private MainDBContext db = new MainDBContext();

        // GET: api/Authors
        public IQueryable<Authors> GetAuthors()
        {
            return db.Authors;
        }

        // GET: api/Authors/5
        [ResponseType(typeof(Authors))]
        public async Task<IHttpActionResult> GetAuthors(int id)
        {
            Authors authors = await db.Authors.FindAsync(id);
            if (authors == null)
            {
                return NotFound();
            }

            return Ok(authors);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAuthors(int id, Authors authors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != authors.Id)
            {
                return BadRequest();
            }

            db.Entry(authors).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Authors
        [ResponseType(typeof(Authors))]
        public async Task<IHttpActionResult> PostAuthors(Authors authors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Authors.Add(authors);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = authors.Id }, authors);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(Authors))]
        public async Task<IHttpActionResult> DeleteAuthors(int id)
        {
            Authors authors = await db.Authors.FindAsync(id);
            if (authors == null)
            {
                return NotFound();
            }

            db.Authors.Remove(authors);
            await db.SaveChangesAsync();

            return Ok(authors);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuthorsExists(int id)
        {
            return db.Authors.Count(e => e.Id == id) > 0;
        }
    }
}