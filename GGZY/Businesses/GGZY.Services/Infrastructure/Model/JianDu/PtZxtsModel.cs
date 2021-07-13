using System;
using System.Data;
using System.Web;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
	/// <summary>
	/// 实体类PT_ZXTS。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public partial class PtZxtsModel
	{
        private string _COMPLAINT_CONTENT;

        #region Model

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID { get; set; }
		/// <summary>
		/// 投诉编号
		/// </summary>
		public string CODE { get; set; }
		/// <summary>
		/// 投诉类型(1线上 2线下 type=79) 3 闽政通
		/// </summary>
		public string TYPE { get; set; }
		/// <summary>
		/// 状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
		/// </summary>
		public string STATE { get; set; }
		/// <summary>
		/// 投诉人（1法人，2自然人 type=71）
		/// </summary>
		public string COMPLAINT_TYPE { get; set; }
		/// <summary>
		/// 投诉人
		/// </summary>
		public string COMPLAINT_NAME { get; set; }
		/// <summary>
		/// 投诉人代码（统一社会信用代码证/身份证号码）
		/// </summary>
		public string COMPLAINT_CODE { get; set; }
		/// <summary>
		/// 投诉人_单位
		/// </summary>
		public string COMPLAINT_DNAME { get; set; }
		/// <summary>
		/// 投诉人_单位地址
		/// </summary>
		public string COMPLAINT_ADRESS { get; set; }
		/// <summary>
		/// 投诉人_单位职务
		/// </summary>
		public string COMPLAINT_ZW { get; set; }
		/// <summary>
		/// 投诉人_传真
		/// </summary>
		public string COMPLAINT_FAX { get; set; }
		/// <summary>
		/// 投诉人_邮编
		/// </summary>
		public string COMPLAINT_PC { get; set; }
		/// <summary>
		/// 投诉人_联系人
		/// </summary>
		public string COMPLAINT_CONTACT { get; set; }
		/// <summary>
		/// 投诉人_手机
		/// </summary>
		public string COMPLAINT_PHONE { get; set; }
		/// <summary>
		/// 投诉人_邮箱
		/// </summary>
		public string COMPLAINT_EMAIL { get; set; }
		/// <summary>
		/// 投诉人_联系人身份证号码
		/// </summary>
		public string COMPLAINT_CONTACT_IDCARD { get; set; }
		/// <summary>
		/// 投诉人_联系电话
		/// </summary>
		public string COMPLAINT_CONTACT_PHONE { get; set; }
		/// <summary>
		/// 投诉人_联系人邮箱
		/// </summary>
		public string COMPLAINT_CONTACT_EMAIL { get; set; }
		/// <summary>
		/// 投诉人_法定代表人
		/// </summary>
		public string COMPLAINT_LEGAL { get; set; }
		/// <summary>
		/// 投诉人_法定代表人身份证
		/// </summary>
		public string COMPLAINT_LEGAL_IDCARD { get; set; }
		/// <summary>
		/// 投诉人_法定代表人手机号码
		/// </summary>
		public string COMPLAINT_LEGAL_PHONE { get; set; }
		/// <summary>
		/// 投诉人_法人是否授权委托
		/// </summary>
		public decimal? COMPLAINT_LEGAL_ISWT { get; set; }
		/// <summary>
		/// 投诉人_被委托人姓名
		/// </summary>
		public string COMPLAINT_BWTR { get; set; }
		/// <summary>
		/// 投诉人_被委托人身份证号
		/// </summary>
		public string COMPLAINT_BWTR_IDCARD { get; set; }
		/// <summary>
		/// 投诉人_被委托人所在部门与职务
		/// </summary>
		public string COMPLAINT_BWTR_BMZW { get; set; }
		/// <summary>
		/// 投诉人_被委托人手机号
		/// </summary>
		public string COMPLAINT_BWTR_PHONE { get; set; }
		/// <summary>
		/// 投诉人_是否委托代理投诉
		/// </summary>
		public string COMPLAINT_ISAGENCY { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构
		/// </summary>
		public string COMPLAINT_AGENCY { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构统一社会信用代码证
		/// </summary>
		public string COMPLAINT_AGENCY_CODE { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构传真
		/// </summary>
		public string COMPLAINT_AGENCY_FAX { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构邮编
		/// </summary>
		public string COMPLAINT_AGENCY_PC { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构联系人
		/// </summary>
		public string COMPLAINT_AGENCY_LXR { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构手机
		/// </summary>
		public string COMPLAINT_AGENCY_PHONE { get; set; }
		/// <summary>
		/// 投诉人_委托代理机构地址
		/// </summary>
		public string COMPLAINT_AGENCY_ADRESS { get; set; }
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE { get; set; }
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME { get; set; }
		/// <summary>
		/// 工程类型（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（A01规划，A02投资策划与决策，A03勘察，A04设计，A05监理，A06工程造价，A07项目管理，A09其他工程 type=85）
		/// </summary>
		public string TENDER_CLASS { get; set; }
		/// <summary>
		/// 投诉事项（1对招标文件的投诉，2对资格预审文件的投诉，3对资格预审结果的投诉，4对评标结果的投诉，5对开标过程的投诉，6其他 type=82）
		/// </summary>
		public string COMPLAINT_SX { get; set; }
		/// <summary>
		/// 投诉标题
		/// </summary>
		public string COMPLAINT_TITLE { get; set; }
		/// <summary>
		/// 附件_投诉书
		/// </summary>
		public string TSS_AIDS { get; set; }
		/// <summary>
		/// 附件_异议证明文件
		/// </summary>
		public string YYZM_AIDS { get; set; }
		/// <summary>
		/// 附件_有效线索和相关证明材料
		/// </summary>
		public string ZMCL_AIDS { get; set; }
		/// <summary>
		/// 附件_其他材料
		/// </summary>
		public string OTHER_AIDS { get; set; }
		/// <summary>
		/// 附件_法人身份证扫描件
		/// </summary>
		public string FR_SFZ_AIDS { get; set; }
		/// <summary>
		/// 附件_被授权委托人身份扫描件
		/// </summary>
		public string WTR_SFZ_AIDS { get; set; }
		/// <summary>
		/// 附件_授权委托书
		/// </summary>
		public string SQWTS_AIDS { get; set; }
		/// <summary>
		/// 附件_委托代理合同
		/// </summary>
		public string WTDLHT_AIDS { get; set; }
		/// <summary>
		/// 附件_委托代理机构统一社会信用代码证
		/// </summary>
		public string AGENCY_CODE_AIDS { get; set; }
		/// <summary>
		/// 附件_委托代理联系人身份证扫描件
		/// </summary>
		public string AGENCY_SFZ_AIDS2 { get; set; }
		/// <summary>
		/// 附件_自然人身份证扫描件
		/// </summary>
		public string SFZ_AIDS { get; set; }
		/// <summary>
		/// 填报日期
		/// </summary>
		public DateTime? CREATE_TM { get; set; }
		/// <summary>
		/// 受理部门/线下投诉部门
		/// </summary>
		public string ACCEPT_DEPID { get; set; }
		/// <summary>
		/// 签收状态（1待签收2已签收3不予受理type=80）
		/// </summary>
		public string SIGN_STATE { get; set; }
		/// <summary>
		/// 签收人员
		/// </summary>
		public decimal? SIGN_UID { get; set; }
		/// <summary>
		/// 签收时间
		/// </summary>
		public DateTime? SIGN_TM { get; set; }
		/// <summary>
		/// 签收意见
		/// </summary>
		public string SIGN_REMARK { get; set; }
		/// <summary>
		/// 受理状态（1待受理2已受理3不予受理type=73）
		/// </summary>
		public string ACCEPT_STATE { get; set; }
		/// <summary>
		/// 受理人员
		/// </summary>
		public decimal? ACCEPT_UID { get; set; }
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? ACCEPT_TM { get; set; }
		/// <summary>
		/// 受理意见
		/// </summary>
		public string ACCEPT_REMARK { get; set; }
		/// <summary>
		/// 受理相关附件
		/// </summary>
		public string ACCEPT_AIDS { get; set; }
		/// <summary>
		/// 审查存在问题
		/// </summary>
		public string SCCZWT { get; set; }
		/// <summary>
		/// 不予受理通知书
		/// </summary>
		public string ACCEPT_TZS { get; set; }
		/// <summary>
		/// 处理状态(1待处理2已处理type=74)
		/// </summary>
		public string HANDLE_STATE { get; set; }
		/// <summary>
		/// 处理人员
		/// </summary>
		public decimal? HANDLE_UID { get; set; }
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? HANDLE_TM { get; set; }
		/// <summary>
		/// 处理结论（1投诉内容属实，2投诉内容部分属实，3投诉内容不属实 type=81）
		/// </summary>
		public string HANDLE_JL { get; set; }
		/// <summary>
		/// 处理意见
		/// </summary>
		public string HANDLE_REMARK { get; set; }
		/// <summary>
		/// 处理相关附件
		/// </summary>
		public string HANDLE_AIDS { get; set; }
		/// <summary>
		/// 处理决定书
		/// </summary>
		public string HANDLE_JDS { get; set; }
		/// <summary>
		/// 是否延期
		/// </summary>
		public string IS_DELAY { get; set; }
		/// <summary>
		/// 延期时间
		/// </summary>
		public decimal? DELAY_UID { get; set; }
		/// <summary>
		/// 延期说明
		/// </summary>
		public string DELAY_REMARK { get; set; }
		/// <summary>
		/// 延期-相关附件
		/// </summary>
		public string DELAY_AIDS { get; set; }
		/// <summary>
		/// 延期时间
		/// </summary>
		public DateTime? DELAY_TM { get; set; }
		/// <summary>
		/// 超时时间(最后处理时间)
		/// </summary>
		public DateTime? OVER_TM { get; set; }
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP { get; set; }
		/// <summary>
		/// 签收相关附件(不予受理时添加)
		/// </summary>
		public string SIGN_AIDS { get; set; }
		/// <summary>
		/// 延期说明书
		/// </summary>
		public string DELAY_SMS { get; set; }
		/// <summary>
		/// 投诉撤回意见书
		/// </summary>
		public string REVOKE_YJS { get; set; }
		/// <summary>
		/// 投诉人_角色
		/// </summary>
		public string COMPLAINT_ROLE { get; set; }
		/// <summary>
		/// 投诉创建人（线下投诉）
		/// </summary>
		public decimal? CREATE_UID { get; set; }
		/// <summary>
		/// 投诉部门（线下投诉）
		/// </summary>
		public string CREATE_DEPID { get; set; }

        /// <summary>
        /// 投诉内容
        /// </summary>
        public string COMPLAINT_CONTENT
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_COMPLAINT_CONTENT))
                {
                    _COMPLAINT_CONTENT = HttpUtility.HtmlDecode(_COMPLAINT_CONTENT);

                }
                return _COMPLAINT_CONTENT;
            }
            set => _COMPLAINT_CONTENT = value;
        }

        #endregion
	}
}