using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 监督首页-查询参数对象
    /// </summary>
    public class MonitorHomePageModel
    {
        public string REGION_CODE { get; set; }
        public string HY_TYPE { get; set; }
        public DateTime?  BeginTime{ get; set; }
        public DateTime? EndTime { get; set; }
    }
}