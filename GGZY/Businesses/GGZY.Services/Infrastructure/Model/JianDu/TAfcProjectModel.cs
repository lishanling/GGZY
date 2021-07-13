using System;
using System.ComponentModel.DataAnnotations;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_AFC_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TAfcProjectModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 报建编号
        /// </summary>
        [Display(Name = "招标计划编号", Order = 10)]
        public string CODE { get; set; }
        /// <summary>
        /// 投资项目统一代码
        /// </summary>
        public string TZ_CODE { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string PROJECT_CODE { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [Display(Name = "招标计划编号", Order = 20)]
        public string PROJECT_NAME { get; set; }
        /// <summary>
        /// 工程类别
        /// </summary>
        public string PROJECT_TYPE { get; set; }
        /// <summary>
        /// 项目地址
        /// </summary>
        public string PROJECT_ADDRESS { get; set; }
        /// <summary>
        /// 项目所在市
        /// </summary>
        public string REGION_CITY { get; set; }
        /// <summary>
        /// 项目所在县
        /// </summary>
        public string REGION_COUNTY { get; set; }
        /// <summary>
        /// 建设单位
        /// </summary>
        public string JS_DEP { get; set; }
        /// <summary>
        /// 法定代表人
        /// </summary>
        public string JS_LEGAL_PERSON { get; set; }
        /// <summary>
        /// 建设单位社会统一信用代码
        /// </summary>
        public string JS_CODE { get; set; }
        /// <summary>
        /// 组织机构代码证书
        /// </summary>
        public string JS_CODE_AIDS { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        public string UNIT_ADDRESS { get; set; }
        /// <summary>
        /// 项目负责人
        /// </summary>
        public string MANAGER { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string MANAGER_PHONE { get; set; }
        /// <summary>
        /// 项目立项或批准文件_文件名称
        /// </summary>
        public string APPROVAL_NAME { get; set; }
        /// <summary>
        /// 项目立项或批准文件
        /// </summary>
        public string APPROVAL_AIDS { get; set; }
        /// <summary>
        /// 项目立项或批准文件_文号
        /// </summary>
        public string APPROVAL_NUMBER { get; set; }
        /// <summary>
        /// 项目立项或批准文件_发文单位
        /// </summary>
        public string APPROVAL_AUTHORITY { get; set; }
        /// <summary>
        /// 工程规模及内容
        /// </summary>
        public string GCGMJNR { get; set; }
        /// <summary>
        /// 投资总额
        /// </summary>
        public decimal? TOTAL_INVEST { get; set; }
        /// <summary>
        /// 投资总额-建安工程费
        /// </summary>
        public decimal? TOTAL_INVEST_JA { get; set; }
        /// <summary>
        /// 资金来源
        /// </summary>
        public string FUND_SOURCE { get; set; }
        /// <summary>
        /// 出资比例—财政
        /// </summary>
        public decimal? CONTRIBUTION_SCALE_CZ { get; set; }
        /// <summary>
        /// 出资比例—自筹
        /// </summary>
        public decimal? CONTRIBUTION_SCALE_ZC { get; set; }
        /// <summary>
        /// 出资比例—其他
        /// </summary>
        public decimal? CONTRIBUTION_SCALE_QT { get; set; }
        /// <summary>
        /// 发包内容及方式-勘察
        /// </summary>
        public string FBFS_SURVEY { get; set; }
        /// <summary>
        /// 发包内容及方式-设计
        /// </summary>
        public string FBFS_DESIGN { get; set; }
        /// <summary>
        /// 发包内容及方式-施工
        /// </summary>
        public string FBFS_CONSTRUCT { get; set; }
        /// <summary>
        /// 发包内容及方式-监理
        /// </summary>
        public string FBFS_SUPERVISION { get; set; }
        /// <summary>
        /// 发包内容及方式-重要设备和材料
        /// </summary>
        public string FBFS_SBCL { get; set; }
        /// <summary>
        /// 发包内容及方式-工程总承包
        /// </summary>
        public string FBFS_CONTRACT { get; set; }
        /// <summary>
        /// 招标组织形式
        /// </summary>
        public string TENDER_ORGANIZE_FORM { get; set; }
        /// <summary>
        /// 是否采用代建制
        /// </summary>
        public decimal? IS_DJZ { get; set; }
        /// <summary>
        /// 工程项目立项登记表
        /// </summary>
        public string REGISTER_AIDS { get; set; }
        /// <summary>
        /// 其他文件
        /// </summary>
        public string OTHER_AIDS { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 填报人
        /// </summary>
        public decimal? U_ID { get; set; }
        /// <summary>
        /// 填报单位
        /// </summary>
        public string DEP_NAME { get; set; }
        /// <summary>
        /// 填报日期
        /// </summary>
        public DateTime? TM { get; set; }
        /// <summary>
        /// 审查状态(1提交2待审批3通过4不通过5撤回6报废)
        /// </summary>
        public decimal? APPROVAL_STATE { get; set; }
        /// <summary>
        /// 审查人员
        /// </summary>
        public decimal? APPROVAL_UID { get; set; }
        /// <summary>
        /// 审查意见
        /// </summary>
        public string APPROVAL_REMARK { get; set; }
        /// <summary>
        /// 审查日期
        /// </summary>
        public DateTime? APPROVAL_TM { get; set; }
        [Display(Name = "填报日期", Order = 60)]
        public string APPROVAL_TM_FROMAT => APPROVAL_TM?.ToString("yyyy-MM-dd HH : mm : ss") ?? "";
        /// <summary>
        /// 数据时间戳
        /// </summary>
        public DateTime? DATA_TIMESTAMP { get; set; }
        /// <summary>
        /// 审查单位
        /// </summary>
        public string APPROVAL_DEPID { get; set; }
        /// <summary>
        /// 审查环节（1初建2变更申请3报建变更4补录）
        /// </summary>
        public decimal? APPROVAL_TACHE { get; set; }
        /// <summary>
        /// 招标事项核准意见书
        /// </summary>
        public string ZBHZYJS_AIDS { get; set; }
        /// <summary>
        /// 审查人员-姓名
        /// </summary>
        public string APPROVAL_UNAME { get; set; }
        /// <summary>
        /// 审查人员-联系方式
        /// </summary>
        public string APPROVAL_CONTACT_INFORMATION { get; set; }
        /// <summary>
        /// 报建类别
        /// </summary>
        public string KIND { get; set; }
        /// <summary>
        /// 发包内容及方式-勘察设计
        /// </summary>
        public string FBFS_CKSJ { get; set; }
        /// <summary>
        /// 发包内容及方式-试验检测
        /// </summary>
        public string FBFS_SYJC { get; set; }
        /// <summary>
        /// 发包内容及方式-设计咨询
        /// </summary>
        public string FBFS_SJZX { get; set; }
        /// <summary>
        /// 发包内容及方式-其他
        /// </summary>
        public string FBFS_OTHER { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string M_DATA_SOURCE { get; set; }
        /// <summary>
        /// 超时时间(最后处理时间)
        /// </summary>
        public DateTime? OVER_TM { get; set; }
        /// <summary>
        /// 建设性质
        /// </summary>
        public string JSXZ { get; set; }
        /// <summary>
        /// 工程用途
        /// </summary>
        public string GCYT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ISMAJOR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CXXMINFO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string JZJNINFO { get; set; }
        /// <summary>
        /// 立项级别
        /// </summary>
        public string APPROVAL_LEVEL { get; set; }
        /// <summary>
        /// 立项批复时间
        /// </summary>
        public DateTime? APPROVAL_DATE { get; set; }
        /// <summary>
        /// 国有资金出资比例
        /// </summary>
        public decimal? GOVERNMENT_INVEST_FINANCE { get; set; }

        /// <summary>
        /// 出资比例—数办皮肤资金投资比例 仅“信息”行业中增加其他行业不变
        /// </summary>
        public decimal? CONTRIBUTION_SCALE_SB { get; set; }
    }
}