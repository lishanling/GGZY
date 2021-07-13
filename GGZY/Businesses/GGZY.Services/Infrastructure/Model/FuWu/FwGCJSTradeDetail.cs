using System;
using System.Collections.Generic;
using GGZY.Core.Models;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public class FwGCJSTradeInfo
    {
        public FwGCJSTradeDetailBase BaseInfo { get; set; }
        public List<GCJSTradeNode> Nodes { get; set; }
    }

    public class FwGCJSTradeDetailBase
    {
        private DateTime? _M_ZY_TM;
        private DateTime? _M_BZJ_TM;

        /// <summary>
        /// 公告标题
        /// </summary>
        public string NOTICE_NAME { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 标段编号
        /// </summary>
        public string BID_SECTION_CODES { get; set; }
        /// <summary>
        /// 交易平台名称
        /// </summary>
        public string PLATFORM_CODE_NAME { get; set; }
        /// <summary>
        /// 招标项目类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 招标文件/资格预审文件获取截至时间
        /// </summary>
        public DateTime? DOC_GET_END_TIME { get; set; }

        /// <summary>
        /// 质疑截至时间
        /// </summary>
        public DateTime? M_ZY_TM
        {
            get
            {
                if (_M_ZY_TM.HasValue && _M_ZY_TM.Value == DateTime.MinValue)
                {
                    _M_ZY_TM = null;
                }

                return _M_ZY_TM;
            }
            set => _M_ZY_TM = value;
        }

        /// <summary>
        /// 保证金缴纳截至时间
        /// </summary>
        public DateTime? M_BZJ_TM
        {
             get
            {
                if (_M_BZJ_TM.HasValue && _M_BZJ_TM.Value == DateTime.MinValue)
                {
                    _M_BZJ_TM = null;
                }
                return _M_ZY_TM;
            }
            set => _M_BZJ_TM = value;
        }

        /// <summary>
        /// 招标文件/资格预审申请文件递交截至时间
        /// </summary>
        public DateTime? BID_DOC_REFER_END_TIME { get; set; }
        /// <summary>
        /// 辅助属性 行业类别大类
        /// 医疗药品 全部类别 工程建设 政府采购 土地矿产 产权交易 其他交易
        /// </summary>
        public string TENDER_PROJECT_TYPE_CATEGORY { get; set; }
        /// <summary>
        /// 辅助属性 行业类别
        /// 医疗药品 交易统计 市政  公路 铁路 民航 水运 ...
        /// </summary>
        public string TENDER_PROJECT_TYPE_NAME { get; set; }
        /// <summary>
        /// 数据库入库时间 （交易平台推送的数据M_TM有值，服务平台门户不能质疑）
        /// </summary>
        public DateTime? M_TM { get; set; }
    }

    public class FwGCJSTradeDetail
    {
        public string Title { get; set; }
        public int Type { get; set; }
        public int Sort { get; set; }
        public string Contents { get; set; }
        public DateTime? Time { get; set; }
        [JsonIgnore]
        public int? Year { get; set; }

        public object Detail { get; set; }

        public string Attachment { get; set; }

        public string M_ID { get; set; }
    }


    public class GCJSTradeNode
    {
        public int? Year { get; set; }
        public List<FwGCJSTradeDetail> Children { get; set; }
    }
}