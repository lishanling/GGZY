using System;
using GGZY.Core.Extensions;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 服务门户-搜索
    /// </summary>
    public class PortalSearchModel
    {
        private string _ID;
        /// <summary>
        /// 新闻类加密
        /// </summary>
        public string Id
        {
            get
            {
                if (string.Compare("NEWS", Kind, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    _ID = _ID.DesEncrypt();
                }
                return _ID;
            }
            set => _ID = value;
        }

        public string Title { get; set; }

        public DateTime? Tm { get; set; }
        public string Kind { get; set; }
    }
}