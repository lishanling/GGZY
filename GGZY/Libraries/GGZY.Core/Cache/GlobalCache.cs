namespace GGZY.Core.Cache
{
    public class GlobalCache
    {
        private static ICacheManager _instance;
        public static ICacheManager Instance
        {
            get { return _instance ?? (_instance = new RedisCacheManager()); }
        }
    }
}