using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheData.Cacher
{
    public class DbCacher
    {
        private MainDBContext _context = new MainDBContext();
        private Cacher _cacher = new Cacher();

        public bool CacheDb()
        {
            var authors = _context.Authors
                .Include("Books")
                .ToList();

            authors.ForEach(f => _cacher.Add(f.Name, f, DateTimeOffset.UtcNow.AddHours(2)));

            return true;
        }
    }
}