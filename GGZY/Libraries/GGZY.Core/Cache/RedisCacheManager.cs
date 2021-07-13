using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace GGZY.Core.Cache
{
    public class RedisCacheManager : ICacheManager
    {
        //public RedisCacheManager()
        //{
        //    RedisConn = ConnectionMultiplexer.Connect(Configuration);
        //    Db = RedisConn.GetDatabase();
        //    //Server = RedisConn.GetServer(RedisHost, RedisPort);
        //    Server = RedisConn.GetServer(RedisConn.GetEndPoints()[0]);
        //}

        protected string RedisHost => AppSettingUtils.GetString("reidsHost", "114.115.162.77");
        protected string RedisPort => AppSettingUtils.GetString("redisPort", "8099");
        protected string RedisPwd => AppSettingUtils.GetString("redisPwd", "foobared");
        protected int RedisDatabase => AppSettingUtils.GetInt("redisDb", 1);

        protected string RedisKeyFormat = "RedisKey:{0}";

        protected string RedisKey => RedisKeyFormat.Split(':')[0];
        protected string Configuration
        {
            get
            {
                if (string.IsNullOrWhiteSpace(RedisPwd))
                {
                    return $"{RedisHost}:{RedisPort},abortConnect=false";
                }
                return $"{RedisHost}:{RedisPort},password={RedisPwd},abortConnect=false";
            }
        }


        protected ConnectionMultiplexer RedisConn => ConnectionMultiplexer.Connect(Configuration);

        protected IServer Server => RedisConn.GetServer(RedisConn.GetEndPoints()[0]);
        protected IDatabase Db => RedisConn.GetDatabase(RedisDatabase);
        public void Dispose()
        {

        }

        public T Get<T>(string key)
        {
            var redisKey = RedisKeyBuilder(key);
            RedisValue value = Db.StringGet(redisKey);
            T data;
            try
            {
                //if (typeof(T).IsValueType || typeof(T) == typeof(string) || typeof(T) == typeof(object) || typeof(T) == typeof(bool))
                if(typeof(T).IsPrimitive|| typeof(T).IsValueType||typeof(T)==typeof(string) || typeof(T) == typeof(Decimal))
                {
                    //data = (T)(object)value.ToString();
                    data = (T) Convert.ChangeType(value.ToString(), typeof(T));
                }
                else
                {
                    data = JsonConvert.DeserializeObject<T>(value);
                }
                return data;
            }
            catch (Exception e)
            {
                Logger.Error($"{key}:{value} {typeof(T)}", e);
                return default(T);
            }
        }

        public bool Set(string key, object data, int cacheTime)
        {
            try
            {

                var redisKey = RedisKeyBuilder(key);
                var value = data is string ? data.ToString() : data.Serializer(NullValueHandling.Ignore, Formatting.None);

                var r = Db.StringSet(redisKey, value, TimeSpan.FromMinutes(cacheTime));
                return r;
            }
            catch (Exception e)
            {
                Logger.Error($"Redis Set Fail {e}", e);
                return false;
            }
        }

        public bool IsSet(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return false;
            }
            var redisKey = RedisKeyBuilder(key);
            var exists = Db.KeyExists(redisKey);
            return exists;
            //return Server.Keys().Any(c => c == redisKey);
        }

        protected string RedisKeyBuilder(string key)
        {
            var redisKey = key;
            if (!key.StartsWith(RedisKey))
            {
                redisKey = string.Format(RedisKeyFormat, key);
            }
            if (redisKey.EndsWith(".0"))
            {
                redisKey = redisKey.Substring(0, redisKey.Length - 2);
            }
            return redisKey;
        }

        public void Remove(string key)
        {
            var redisKey = RedisKeyBuilder(key);
            Db.KeyDelete(redisKey);
        }



        public void RemoveByPattern(string pattern)
        {
            try
            {
                var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
                var keysToRemove = Server.Keys(RedisDatabase).Where(item => regex.IsMatch(item)).Select(item => (string)item).ToList();

                foreach (string key in keysToRemove)
                {
                    Remove(key);
                }
            }
            catch (Exception e)
            {
               // Console.WriteLine(e);
            }
        }

        public void Clear()
        {
            foreach (var redisKey in Server.Keys(RedisDatabase))
            {
                Remove(redisKey);
            }
        }

        public Dictionary<string, object> AllCaches()
        {
            var dic = new Dictionary<string, object>();
            //Server.ke
            foreach (var redisKey in Server.Keys(RedisDatabase))
            {
                if (IsSet(redisKey) && !dic.ContainsKey(redisKey))
                {
                    var redisValue = Get<string>(redisKey);
                    dic.Add(redisKey, redisValue);
                }
            }
            return dic;
        }
    }
}