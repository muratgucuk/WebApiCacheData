using CacheData.Cacher;
using CacheData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CacheData.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IMainDBContext _context;
        private readonly ICacher _cacher;

        public AuthorRepository(IMainDBContext context, ICacher cacher)
        {
            _context = context;
            _cacher = cacher;
        }

        public Authors Get(string name)
        {
            return _cacher.Get(name) as Authors;
        }

        public async Task Create(Authors author)
        {
            _context.Authors.Add(author);
            _cacher.Add(author.Name, author, DateTimeOffset.UtcNow.AddDays(1));

            await _context.SaveChangesAsync();
        }

        public async Task Delete(string name)
        {
            Authors author = Get(name);

            _context.Authors.Remove(author);
            _cacher.Delete(name);
            await _context.SaveChangesAsync();
        }

        public bool AuthorsExists(string name)
        {
            return _context.Authors.Count(f => f.Name == name) > 0;
        }
    }
}