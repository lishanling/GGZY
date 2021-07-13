using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 处长门户 项目监督 行业部门 处理项目及事项 详情 项目基础信息
    /// </summary>
    public partial class ProjectSupervisionBaseInfoResponseModel
    {
        public decimal? M_ID { get; set; }// 282563,
        public string PROJECT_NAME { get; set; }//  "龙岩学院产品设计系实验室装修工程",
        public DateTime? CREATE_TIME { get; set; }//  "2020-10-20 17: 20:39",
        public string PROJECT_CODE { get; set; }//  "E3508010801800428001",
        public string REGION_CODE { get; set; }//  "350801",
        /// <summary>
        /// 来源平台 //  "91350800M0001QULXJ",
        /// </summary>
        public string PLATFORM_CODE { get; set; }
        /// <summary>
        /// 招标代理  //  "东霖工程管理有限公司",
        /// </summary>
        public string AGENCY_NAME { get; set; }
        /// <summary>
        /// 业主单位
        /// </summary>
        public string OWNER_NAME { get; set; }//  "龙岩学院",
        public string AREANAME { get; set; }//  "市本级",
        /// <summary>
        /// 来源平台编码
        /// </summary>
        public string SYSTEM_NAME { get; set; }//  "龙岩市公共资源交易中心",
        /// <summary>
        /// 招标公告
        /// </summary>
        public int? ZBGG { get; set; }//  1,
        /// <summary>
        /// 投标报名
        /// </summary>
        public int? TBBM { get; set; }//  0,
        /// <summary>
        /// 开标
        /// </summary>
        public int? KB { get; set; }//  0,
        /// <summary>
        /// 评标
        /// </summary>
        public int? PB { get; set; }//  0,
        /// <summary>
        /// 结果公告
        /// </summary>
        public int? JGGG { get; set; }//  0,
        /// <summary>
        /// 中标候选人
        /// </summary>
        public int? ZBHXR { get; set; }//  0,
        public string P_AREANAME { get; set; }//  "龙岩市",
        public string P_REGION_CODE { get; set; }//  "350800"
        /// <summary>
        /// 当前阶段
        /// </summary>
        public string CURRENT_STATE_NAME
        {
            get
            {
                var n = "项目进场";
                if (ZBHXR > 0 || JGGG > 0)
                {
                    n = "结果公告";
                }
                else if (PB > 0)
                {
                    n = "评标";
                }
                else if (KB > 0)
                {
                    n = "开标";
                }
                else if (TBBM > 0)
                {
                    n = "投标报名";
                }
                else if (ZBGG > 0)
                {
                    n = "招标公告";
                }
                return n;
            }
        }
        /// <summary>
        /// 招标人联系
        /// </summary>
        public string TENDERER_CONTRACT { get; set; }
        /// <summary>
        /// 招标人联系电话
        /// </summary>
        public string TENDERER_PHONE { get; set; }
        /// <summary>
        /// 招标代理联系人
        /// </summary>
        public string TENDER_AGENT_CONTRACT { get; set; }
        /// <summary>
        /// 招标代理联系电话
        /// </summary>
        public string TENDER_AGENT_PHONE { get; set; }
    }
}