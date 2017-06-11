using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace CacheData.Cacher
{
    public class Cacher : ICacher
    {
        private MemoryCache _cacher;
        
        public object Get(string key)
        {
            _cacher = MemoryCache.Default;
            return _cacher.Get(key);
        }

        public bool Add(string key, object value, DateTimeOffset absoluteExpiration)
        {
            _cacher = MemoryCache.Default;
            return _cacher.Add(key, value, absoluteExpiration);
        }

        public void Delete(string key)
        {
            _cacher = MemoryCache.Default;

            if (_cacher.Contains(key))
            {
                _cacher.Remove(key);
            }
        }

    }
}