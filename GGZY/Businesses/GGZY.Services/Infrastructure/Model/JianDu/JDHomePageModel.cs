using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class JDHomePageModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }

        /// <summary>
        /// 单位ID
        /// </summary>
        public string DEPID { get; set; }
        /// <summary>
        /// 监督对象部门ID
        /// </summary>
        public string OBJ_DEP_ID { get; set; }

        /// <summary>
        /// 时间（本月）
        /// </summary>
        public string TIME { get; set; }

        /// <summary>
        ///归属地
        /// </summary>
        public string REGION_CODE{ get; set; }

        /// <summary>
        ///归属地编码
        /// </summary>
        public string AREACODE { get; set; }
        /// <summary>
        ///归属地名称
        /// </summary>
        public string AREANAME { get; set; }
        /// <summary>
        /// 行业类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 行业类型名称
        /// </summary>
        public string PROJECT_TYPE_NAME { get; set; }
        /// <summary>
        /// 行业类型个数
        /// </summary>
        public decimal? TENDER_PROJECT_TYPE_COUNT { get; set; }

        /// <summary>
        /// 督查人
        /// </summary>
        public string OP_ID { get; set; }
        /// <summary>
        /// 督查事项名称
        /// </summary>
        public string ENTITY_NAME { get; set; }


        /// <summary>
        /// 督查事项类型
        /// </summary>
        public string ENTITY_TYPE_NAME { get; set; }
        /// <summary>
        /// 督查事项类型个数
        /// </summary>
        public decimal? ENTITY_TYPE_NAME_COUNT { get; set; }

        /// <summary>
        /// 监察时间
        /// </summary>
        public string SUPERVISE_TIME { get; set; }
        /// <summary>
        /// 实体记录行业
        /// </summary>
        public string ENTITY_TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 实体记录归属地
        /// </summary>
        public string ENTITY_REGION_CODE { get; set; }
        /// <summary>
        /// 移送事项类型
        /// </summary>
        public string  TRANS_TYPE { get; set; }
        /// <summary>
        /// 移送事项类型个数
        /// </summary>
        public decimal? TRANS_TYPE_COUNT { get; set; }
        /// <summary>
        /// 处罚个数
        /// </summary>
        public string PUNISH_CODE_COUNT { get; set; }
        /// <summary>
        /// 异常检查点总数
        /// </summary>
        public decimal? T_SUPERVISE_COUNT { get; set; }
        /// <summary>
        /// 已发督查数
        /// </summary>
        public decimal? SEND_COUNT { get; set; }
        /// <summary>
        /// 未发督查数
        /// </summary>
        public decimal? NO_SEND_COUNT { get; set; }
        /// <summary>
        /// 督查事项总数
        /// </summary>
        public decimal? T_PROJECT_COUNT { get; set; }
        /// <summary>
        /// 招标计划总数
        /// </summary>
        public decimal? T_PROJECTT_AFC_PROJECT_COUNT { get; set; }
        /// <summary>
        /// 招标项目总数
        /// </summary>
        public decimal? TENDER_PROJECT_CODE_COUNT { get; set; }
        /// <summary>
        /// 投诉总数
        /// </summary>
        public decimal? PT_ZXTS_COUNT { get; set; }
        /// <summary>
        /// 督查已反馈数
        /// </summary>
        public decimal? Send { get; set; }
        /// <summary>
        /// 督查未反馈数
        /// </summary>
        public decimal? Upred { get; set; }
        /// <summary>
        /// 督查事项总数
        /// </summary>
        public decimal? ALL { get; set; }
        /// <summary>
        /// 红灯个数
        /// </summary>
        public decimal? red { get; set; }

        /// <summary>
        /// 红灯个数
        /// </summary>
        public decimal? USE_OPERATOR_COUNT { get; set; }
        /// <summary>
        /// 接收移送事项
        /// </summary>
        public decimal? Accept { get; set; }

    }
}
