using System;
using Dos.ORM;
using GGZY.Core.Log;

namespace GGZY.Services.Base
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public partial class DbContext
    {
        
        /// <summary>
        /// 公共资源服务
        /// </summary>
        public readonly static DbSession Fw ;
        /// <summary>
        /// 公共资源监督
        /// </summary>
        public readonly static DbSession Jd ;
        /// <summary>
        /// 招标采购网
        /// </summary>
        public readonly static DbSession Jh ;

       

        static DbContext()
        {

            try
            {
                Fw = new DbSession("ggzyfw");
                Fw?.RegisterSqlLogger((s) =>
                {
                    if (!string.IsNullOrWhiteSpace(s) && !s.ToLower().Contains("mgr_log") && !s.ToLower().Contains("sys_log"))
                    {
                        Logger.Debug(new LogMessage(s, "GGZYFW", "CMS_SQL"));
                    }
                });
            }
            catch (Exception e)
            {
                Logger.Error($"{e.Message}",e);
            }
            try
            {
                Jd = new DbSession("ggzyjd");
                Jd?.RegisterSqlLogger((s) =>
                {
                    if (!string.IsNullOrWhiteSpace(s) && !s.ToLower().Contains("mgr_log"))
                    {
                        Logger.Debug(new LogMessage(s, "GGZYJD", "CMS_SQL"));
                    }
                });
            }
            catch (Exception e)
            {
                Logger.Error($"{e.Message}", e);
            }
            try
            {
                Jh = new DbSession("ggzyjh");
                Jh?.RegisterSqlLogger((s) =>
                {
                    if (!string.IsNullOrWhiteSpace(s) && !s.ToLower().Contains("mgr_log"))
                    {
                        Logger.Debug(new LogMessage(s, "GGZYJD", "CMS_SQL"));
                    }
                });
            }
            catch (Exception e)
            {
                Logger.Error($"{e.Message}", e);
            }
        }
    }
}