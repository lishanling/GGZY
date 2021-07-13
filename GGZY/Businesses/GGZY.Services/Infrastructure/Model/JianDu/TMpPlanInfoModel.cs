using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
	/// <summary>
    /// 实体类T_MP_PLAN_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TMpPlanInfoModel
    {
        #region Model


        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 监督点名称
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 归属方案ID
        /// </summary>
        public decimal? ASC_ID { get; set; }
        /// <summary>
        /// 项目阶段
        /// </summary>
        public string STAGE_TYPE { get; set; }
        /// <summary>
        /// 是否人工监督
        /// </summary>
        public decimal? ISUSER { get; set; }
        /// <summary>
        /// 监督单位
        /// </summary>
        public string SUNIT { get; set; }
        /// <summary>
        /// 公开范围
        /// </summary>
        public string OPEN_RANGE { get; set; }
        /// <summary>
        /// 监督点描述
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 监督点分类
        /// </summary>
        public string KIND { get; set; }
        /// <summary>
        /// 监督点类型
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// 监督执行编码
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATE_TM { get; set; }
        /// <summary>
        /// 内容URL
        /// </summary>
        public string CONTENT_URL { get; set; }
        /// <summary>
        /// 异常预警
        /// </summary>
        public string LEVEL_TYPE { get; set; }
        /// <summary>
        /// 监督单位所属地区
        /// </summary>
        public string SU_AREACODE { get; set; }
        /// <summary>
        /// 归属环节节点编码
        /// </summary>
        public string NODE_CODE { get; set; }
        /// <summary>
        /// 规则表达式
        /// </summary>
        public string JUDGE_DESC { get; set; }
        /// <summary>
        /// 规则表达式(特殊)
        /// </summary>
        public string JUDGE_DESC2 { get; set; }
        /// <summary>
        /// 互斥监督点：【互斥监督点】状态为无时且【当前监督点】状态不为无，【互斥监督点】不可用;多个节点用‘,’分割。
        /// </summary>
        public string MUTEX_MP { get; set; }
        /// <summary>
        /// 是否隐藏：当监督点未启动时是否隐藏展示
        /// </summary>
        public string IS_HIDE { get; set; }
        #endregion


    }
}