using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Web.Caching;

namespace Xjsaber.Web.Utils
{
    /// <summary>
    /// 获取当前应用程序指定CacheKey的Cache值
    /// </summary>
    /// <param name="CacheKey"></param>
    /// <returns></returns>
    public class DataCache
    {
        /// <summary>
        /// 获取当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        public static object GetCache(string CacheKey)
        {
            Cache objCache = HttpRuntime.Cache;
            return objCache[CacheKey];

        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        public static void SetCache(string CacheKey, object objObject)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        /// <param name="CacheTime">多少分钟后过期</param>
        public static void SetCache(string CacheKey, object objObject, int CacheTime)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject, null, DateTime.UtcNow.AddMinutes(CacheTime), Cache.NoSlidingExpiration);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveCache(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }
    }
}
