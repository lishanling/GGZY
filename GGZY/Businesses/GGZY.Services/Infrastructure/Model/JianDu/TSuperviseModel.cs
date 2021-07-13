using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_SUPERVISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TSuperviseModel
    {
        private string _ENTITY_TYPE_NAME;

        #region Model


        /// <summary>
        /// 主键
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 督查内容
        /// </summary>
        public string CONTENT { get; set; }
        /// <summary>
        /// 督查附件
        /// </summary>
        public string FILES { get; set; }
        /// <summary>
        /// 督查码
        /// </summary>
        [Display(Name = "督察编号", Order = 10)]
        public string CODE { get; set; }
        /// <summary>
        /// 督查标题
        /// </summary>
        [Display(Name = "督察标题", Order = 20)]
        public string NAME { get; set; }

        /// <summary>
        /// 督查对象名称
        /// </summary>
        [Display(Name = "督察对象", Order = 30)]
        public string OBJ_NAME { get; set; }
        /// <summary>
        /// 实体对象名称
        /// </summary>
        [Display(Name = "事项名称", Order = 40)]
        public string ENTITY_NAME { get; set; }
        /// <summary>
        /// 督查时间
        /// </summary>
        public DateTime? TIME { get; set; }
        /// <summary>
        /// 督查时间
        /// </summary>
        [Display(Name = "发起时间", Order = 70)]
        public string TIME_FORMAT => TIME?.ToString("yyyy-MM-dd HH:mm") ?? "";

        /// <summary>
        /// 督查人
        /// </summary>
        public string OP_ID { get; set; }
        /// <summary>
        /// 督查人员名称
        /// </summary>
        public string OP_NAME { get; set; }
        /// <summary>
        /// 督查人员部门id
        /// </summary>
        public string DEP_ID { get; set; }
        /// <summary>
        /// 督查人员部门名称
        /// </summary>
        public string DEP_NAME { get; set; }
        /// <summary>
        /// 督查对象
        /// </summary>
        public string OBJ { get; set; }
       
        /// <summary>
        /// 督查对象部门id
        /// </summary>
        public string OBJ_DEP_ID { get; set; }
        /// <summary>
        /// 督查对象部门名称
        /// </summary>
        public string OBJDEP_NAME { get; set; }
        /// <summary>
        /// 招标计划主键
        /// </summary>
        public string ENTITY_ID { get; set; }
        /// <summary>
        /// 实体对象名称T_AFC_PROJECT PT_ZXTS
        /// </summary>
        public string ENTITY_TYPE_NAME
        {
            get => _ENTITY_TYPE_NAME;
            set => _ENTITY_TYPE_NAME = value;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public decimal? STATUS { get; set; }
        /// <summary>
        /// 归属地
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 行业
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        public string TENDER_PROJECT_CODE { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }
        #endregion


    }
}