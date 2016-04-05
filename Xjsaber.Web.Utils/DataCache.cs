using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Xjsaber.Web.Utils
{
    public class DataCache
    {
        public static GetCache(string cacheKey)
        {
            Cache objCache = HttpRuntime.Cache;
            return objCache[cacheKey];
        }
    }
}
