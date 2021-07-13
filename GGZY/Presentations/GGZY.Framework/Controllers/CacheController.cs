using System.Web.Caching;
using System.Web.Mvc;
using GGZY.Core.Models;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 缓存
    /// </summary>
    [AllowAnonymous]
    public class CacheController:BaseController
    {
        /// <summary>
        /// 读取所有缓存
        /// </summary>
        /// <returns></returns>
        //[AllowAnonymous]
        public ActionResult Caches(SearchCondition search)
        {
            var allCaches = Cache.AllCaches();
            if (search.RspType == SearchCondition.RES_TYPE_VIEW)
            {
                return View(allCaches);
            }
            return JResult(allCaches);
        }
        /// <summary>
        /// 读取缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        //[AllowAnonymous]
        public ActionResult GetCache(string key)
        {
            return JResult(Cache.Get<string>(key));
        }
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        //[AllowAnonymous]
        public ActionResult RemoveCache(string key)
        {
            Cache.Remove(key);
            return RedirectToAction("Caches");
        }
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <returns></returns>
        //[AllowAnonymous]
        public ActionResult ClearCache()
        {
            Cache.Clear();
            return RedirectToAction("Caches");
        }
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SetCache(string key, string value)
        {
            var r = Cache.Set(key, value, 5);
            return JResult(r);
        }
    }
}