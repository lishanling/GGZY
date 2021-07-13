using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_SUPERVISE_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TSuperviseZBBAResultModel
    {
        #region Model
        /// <summary>
        /// 
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 实体对象名称T_AFC_PROJECT PT_ZXTS
        /// </summary>
        public string ENTITY_TYPE_NAME { get; set; }
        /// <summary>
        /// 实体记录主键值
        /// </summary>
        public string ENTITY_ID { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public decimal? STATUS { get; set; }
        
        /// <summary>
        /// 监察时间
        /// </summary>
        public DateTime? SUPERVISE_TIME { get; set; }
        /// <summary>
        /// 监察规则
        /// </summary>
        public string SUPERVISE_RULE { get; set; }
        /// <summary>
        /// 提交日期
        /// </summary>
        public DateTime? ENTITY_SUBMIT_TIME { get; set; }
        /// <summary>
        /// 审查日期
        /// </summary>
        public DateTime? ENTITY_HANDLE_TIME { get; set; }
        /// <summary>
        /// 监察人员id
        /// </summary>
        public string SUPERVISE_OP_ID { get; set; }
        /// <summary>
        /// 监察人员名称
        /// </summary>
        public string SUPERVISE_OP_NAME { get; set; }
        /// <summary>
        /// 实体记录归属地
        /// </summary>
        public string ENTITY_REGION_CODE { get; set; }
        /// <summary>
        /// 实体记录行业
        /// </summary>
        public string ENTITY_TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 是否预警（出现过红灯）
        /// </summary>
        public decimal? WARNING { get; set; }
        
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态", Order = 10)]
        public string STATUS_TEXT => STATUS == 1 ? "红" : "绿";
        /// <summary>
        /// 监察名称
        /// </summary>
        [Display(Name = "监察点", Order = 20)]
        public string SUPERVISE_NAME { get; set; }
        /// <summary>
        /// 监察类型
        /// </summary>
        [Display(Name = "监察点类型", Order = 30)]
        public string SUPERVISE_TYPE { get; set; }
        /// <summary>
        /// 监察方式
        /// </summary>
        [Display(Name = "监察方式", Order = 40)]
        public string SUPERVISE_WAY { get; set; }
        /// <summary>
        /// 实体记录招标项目名称
        /// </summary>
        public string ENTITY_TENDER_PROJECT_NAME { get; set; }

        [Display(Name = "提交日期", Order = 50)]

        public string ENTITY_SUBMIT_TIME_FORMAT => ENTITY_SUBMIT_TIME?.ToString("yyyy-MM-dd HH:mm") ?? "";
        /// <summary>
        /// 审查单位
        /// </summary>
        [Display(Name = "审查单位", Order = 60)]
        public string APPROVAL_DEPNAME { get; set; }
        /// <summary>
        /// 招标项目名称
        /// </summary>
        [Display(Name = "招标项目名称", Order = 70)]
        public string PROJECT_NAME { get; set; }
        /// <summary>
        /// 招标编号
        /// </summary>
        public string ENTITY_TENDER_PROJECT_CODE { get; set; }

        public List<string> Buttons
        {
            get
            {
                var btns = new List<string>() { "SUPERVISE", "CHANGE", "DETAIL" };
                if (STATUS != 1)
                {
                    btns = new List<string>() { "DETAIL" };
                }

                return btns;
            }
        }
        #endregion

        public string REGION_NAME { get; set; }
        public string DEPID { get; set; }
        [Display(Name = "招标编号", Order = 80)]
        public string CODE { get; set; }
    }
}
