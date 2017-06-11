using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheData.Cacher
{
    public interface ICacher
    {
        object Get(string key);
        bool Add(string key, object value, DateTimeOffset absExpiration);
        void Delete(string key);
    }
}