using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_IndexerTest
{
    class MyCache
    {
        // Directory : Key => Value
        private Dictionary<string, string> cache;
        
        // private Dictionary<string, string> extraCache;

        public MyCache()
        {
            cache = new Dictionary<string, string>();
            // Default Cache Values
            cache.Add("Debug", "false");
            cache.Add("Logging", "true");
        }

        private DateTime cacheExpires;

        public DateTime CacheExpires
        {
            get { return cacheExpires; }
            set { cacheExpires = value; }
        }

        // indexer
        public string this[string key]
        {
            get
            {
                if (cache.ContainsKey(key))
                {
                    return cache[key];

                }
                return null;
            }
            set
            {
                if (cache.ContainsKey(key))
                {
                    cache[key] = value;
                }
                else
                {
                    throw new ApplicationException("Key not found");
                }
            }
        }

        public void Add(string key, string value)
        {
            if (!cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("Key already exists");
            }
        }

        public string Get(string key)
        {
            if (cache.ContainsKey(key))
            {
                return cache[key];

            }
            return null;
        }

        public void Set(string key, string value)
        {
            if (cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("Key not found");
            }
        }

        // ... other methods...
    }
}
