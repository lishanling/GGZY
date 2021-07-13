using System;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    /// <summary>
    /// 工程领域数据查询模型
    /// </summary>
    public class EngineerSearchModel:SearchCondition
    {
        private DateTime? _BEGIN_TIME;
        private DateTime? _END_TIME;

        /// <summary>
        /// 归属地编码
        /// </summary>
        public string AREACODE { get; set; }
        /// <summary>
        /// 归属地名称
        /// </summary>
        public string AREANAME { get; set; }
        /// <summary>
        /// 行业类型 住建 水利 交通 农业 渔港 信息 工业
        /// </summary>
        public string INDUSTRY_TYPE { get; set; }
        /// <summary>
        /// 招标项目类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }

        public override DateTime? BeginTime
        {
            get { return _BEGIN_TIME ?? (_BEGIN_TIME = DateTime.Today.AddDays(1 - DateTime.Today.Day)); }
            set => _BEGIN_TIME = value;
        }

        public override DateTime? EndTime
        {
            get { return _END_TIME ?? (_END_TIME = DateTime.Today); }
            set => _END_TIME = value;
        }

        /// <summary>
        /// 当天 23:59:59
        /// </summary>
        public DateTime? EndDateTime => EndTime?.AddDays(1).AddSeconds(-1);
    }
}