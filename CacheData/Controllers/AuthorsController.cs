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
using CacheData.Cacher;
using CacheData.Repositories;

namespace CacheData.Controllers
{
    [RoutePrefix("api/Authors")]
    public class AuthorsController : ApiController
    {
        private AuthorRepository _authorRepo;

        public AuthorsController()
        {

        }
        
        [HttpGet]
        [Route("Get")]
        public IHttpActionResult GetAuthors(string name)
        {
            Authors authors = _authorRepo.Get(name);
            return Ok(authors);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IHttpActionResult> PostAuthors(Authors author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _authorRepo.Create(author);
            return Ok();
        }

        [HttpGet]
        [Route("Delete")]
        public async Task<IHttpActionResult> DeleteAuthors(string name)
        {
            if (!_authorRepo.AuthorsExists(name))
            {
                return NotFound();
            }

            await _authorRepo.Delete(name);
            return Ok();
        }
    }
}