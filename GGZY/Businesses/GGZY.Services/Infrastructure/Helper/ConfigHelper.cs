using GGZY.Core.Utils;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Helper
{
    /// <summary>
    /// 通用配置
    /// </summary>
    public partial class ConfigHelper
    {
        private static AppSettings _appSettings;

        /// <summary>
        /// Web.Config 或 App.Config 中 AppSettings节点
        /// </summary>
        public static AppSettings AppSettings => _appSettings ?? (_appSettings = new AppSettings());

     
    }
}