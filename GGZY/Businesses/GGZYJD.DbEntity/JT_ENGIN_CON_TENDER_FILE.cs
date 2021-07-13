using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_ENGIN_CON_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_ENGIN_CON_TENDER_FILE")]
    [Serializable]
    public partial class JT_ENGIN_CON_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _TOTAL_CONTRACT_SECTION;
		private decimal? _CONTRACT_SECTION;
		private decimal? _CONTRACT_SECTION_NUMBER;
		private string _ACHIEVEMENT;
		private string _OTHER_MATTERS;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _FUND_IMPLEMENTATION;
		private DateTime? _BEGIN_ALL_DATE;
		private DateTime? _END_DATE;
		private string _PROJECT_QUALITY_TARGET;
		private string _BID_SAFETY_OBJECTIVES;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _TENDER_DOC_OTHER;
		private DateTime? _MARGIN_TIME;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private string _PROJECT_YEAR_REQUIRED;
		private string _LITIGATION_YEAR_REQUIRED;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _PERFORM_PRICE_TYPE;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_TELE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private string _SUPERVISE_DEPT_FAX;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private decimal? _WIN_CANDIDATE_NUM;
		private string _OTHER_CONTENT;
		private string _EVALUATING_METHOD_STANDARD;
		private string _SUBC_NAME;
		private string _SUBC_NAME_ADDRESS;
		private decimal? _SUBC_ZIP_CODE;
		private string _SUPERVISOR;
		private string _SUPERVISOR_ADDRESS;
		private decimal? _SUPERVISOR_ZIP_CODE;
		private decimal? _DEFECT_LIABILITY_PERIOD1;
		private decimal? _DRAWING_MODIFICATION;
		private decimal? _DATA_PERIOD;
		private decimal? _APPROVAL_PERIOD;
		private decimal? _DELAY_PENALTY;
		private decimal? _SUBMIT_REQUISITION;
		private decimal? _MONTHLY_PAYMENT;
		private decimal? _PAYMENT_APPLICATION;
		private decimal? _APPLICATION_NUM;
		private decimal? _COMPLETION_DATA;
		private string _CONSTRUCTION_PERIOD_OPERATION;
		private string _OPERATING_REGULATIONS;
		private string _DISPUTE_RESOLUTION;
		private string _ARBITRATION_COMMISSION;
		private string _PUBLISH_WEBSITE;
		private string _PROVICE_NETWORKING;
		private string _CONTRACT_CLAUSE;
		private string _BILL_OF_QUANTITIES;
		private string _DRAWING;
		private string _TECHNICAL_SPECIFICATIONS;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 项目总工期
		/// </summary>
		public decimal? LIMITE_ALL_TIME
		{
			get{ return _LIMITE_ALL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_ALL_TIME, _LIMITE_ALL_TIME, value);
				this._LIMITE_ALL_TIME = value;
			}
		}
		/// <summary>
		/// 本项目共设置的合同段数量
		/// </summary>
		public decimal? TOTAL_CONTRACT_SECTION
		{
			get{ return _TOTAL_CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_CONTRACT_SECTION, _TOTAL_CONTRACT_SECTION, value);
				this._TOTAL_CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 本次招标合同段数量
		/// </summary>
		public decimal? CONTRACT_SECTION
		{
			get{ return _CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SECTION, _CONTRACT_SECTION, value);
				this._CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 本次招标合同段组数量
		/// </summary>
		public decimal? CONTRACT_SECTION_NUMBER
		{
			get{ return _CONTRACT_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SECTION_NUMBER, _CONTRACT_SECTION_NUMBER, value);
				this._CONTRACT_SECTION_NUMBER = value;
			}
		}
		/// <summary>
		/// 业绩要求
		/// </summary>
		public string ACHIEVEMENT
		{
			get{ return _ACHIEVEMENT; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT, _ACHIEVEMENT, value);
				this._ACHIEVEMENT = value;
			}
		}
		/// <summary>
		/// 其他事项
		/// </summary>
		public string OTHER_MATTERS
		{
			get{ return _OTHER_MATTERS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_MATTERS, _OTHER_MATTERS, value);
				this._OTHER_MATTERS = value;
			}
		}
		/// <summary>
		/// 其他发布媒体1
		/// </summary>
		public string MEDIA1
		{
			get{ return _MEDIA1; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA1, _MEDIA1, value);
				this._MEDIA1 = value;
			}
		}
		/// <summary>
		/// 其他发布媒体2
		/// </summary>
		public string MEDIA2
		{
			get{ return _MEDIA2; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA2, _MEDIA2, value);
				this._MEDIA2 = value;
			}
		}
		/// <summary>
		/// 资金落实情况
		/// </summary>
		public string FUND_IMPLEMENTATION
		{
			get{ return _FUND_IMPLEMENTATION; }
			set
			{
				this.OnPropertyValueChange(_.FUND_IMPLEMENTATION, _FUND_IMPLEMENTATION, value);
				this._FUND_IMPLEMENTATION = value;
			}
		}
		/// <summary>
		/// 总计划开工日期
		/// </summary>
		public DateTime? BEGIN_ALL_DATE
		{
			get{ return _BEGIN_ALL_DATE; }
			set
			{
				this.OnPropertyValueChange(_.BEGIN_ALL_DATE, _BEGIN_ALL_DATE, value);
				this._BEGIN_ALL_DATE = value;
			}
		}
		/// <summary>
		/// 计划交工日期
		/// </summary>
		public DateTime? END_DATE
		{
			get{ return _END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.END_DATE, _END_DATE, value);
				this._END_DATE = value;
			}
		}
		/// <summary>
		/// 工程质量目标
		/// </summary>
		public string PROJECT_QUALITY_TARGET
		{
			get{ return _PROJECT_QUALITY_TARGET; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_QUALITY_TARGET, _PROJECT_QUALITY_TARGET, value);
				this._PROJECT_QUALITY_TARGET = value;
			}
		}
		/// <summary>
		/// 本标段的安全目标
		/// </summary>
		public string BID_SAFETY_OBJECTIVES
		{
			get{ return _BID_SAFETY_OBJECTIVES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SAFETY_OBJECTIVES, _BID_SAFETY_OBJECTIVES, value);
				this._BID_SAFETY_OBJECTIVES = value;
			}
		}
		/// <summary>
		/// 资质最低条件
		/// </summary>
		public string MINIMUM_QUALIFICATIONS
		{
			get{ return _MINIMUM_QUALIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_QUALIFICATIONS, _MINIMUM_QUALIFICATIONS, value);
				this._MINIMUM_QUALIFICATIONS = value;
			}
		}
		/// <summary>
		/// 财务最低要求
		/// </summary>
		public string FINANCIAL_REQUIRE
		{
			get{ return _FINANCIAL_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE, _FINANCIAL_REQUIRE, value);
				this._FINANCIAL_REQUIRE = value;
			}
		}
		/// <summary>
		/// 业绩最低要求
		/// </summary>
		public string ACHIEVEMENT_REQUIRE
		{
			get{ return _ACHIEVEMENT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT_REQUIRE, _ACHIEVEMENT_REQUIRE, value);
				this._ACHIEVEMENT_REQUIRE = value;
			}
		}
		/// <summary>
		/// 信誉最低要求
		/// </summary>
		public string REPUTATION_REQUIRE
		{
			get{ return _REPUTATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_REQUIRE, _REPUTATION_REQUIRE, value);
				this._REPUTATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 构成招标文件的其他材料
		/// </summary>
		public string TENDER_DOC_OTHER
		{
			get{ return _TENDER_DOC_OTHER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_OTHER, _TENDER_DOC_OTHER, value);
				this._TENDER_DOC_OTHER = value;
			}
		}
		/// <summary>
		/// 投标保证金递交截止时间
		/// </summary>
		public DateTime? MARGIN_TIME
		{
			get{ return _MARGIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_TIME, _MARGIN_TIME, value);
				this._MARGIN_TIME = value;
			}
		}
		/// <summary>
		/// 招标人账户
		/// </summary>
		public string MARGIN_NAME
		{
			get{ return _MARGIN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME, _MARGIN_NAME, value);
				this._MARGIN_NAME = value;
			}
		}
		/// <summary>
		/// 招标人账号
		/// </summary>
		public string MARGIN_NUMBER
		{
			get{ return _MARGIN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER, _MARGIN_NUMBER, value);
				this._MARGIN_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标人开户行
		/// </summary>
		public string MARGIN_BANK
		{
			get{ return _MARGIN_BANK; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK, _MARGIN_BANK, value);
				this._MARGIN_BANK = value;
			}
		}
		/// <summary>
		/// 完成的类似项目年份要求
		/// </summary>
		public string PROJECT_YEAR_REQUIRED
		{
			get{ return _PROJECT_YEAR_REQUIRED; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_YEAR_REQUIRED, _PROJECT_YEAR_REQUIRED, value);
				this._PROJECT_YEAR_REQUIRED = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况年份要求
		/// </summary>
		public string LITIGATION_YEAR_REQUIRED
		{
			get{ return _LITIGATION_YEAR_REQUIRED; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_YEAR_REQUIRED, _LITIGATION_YEAR_REQUIRED, value);
				this._LITIGATION_YEAR_REQUIRED = value;
			}
		}
		/// <summary>
		/// 评标委员会人数
		/// </summary>
		public decimal? ALL_EXPERT_NUM
		{
			get{ return _ALL_EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ALL_EXPERT_NUM, _ALL_EXPERT_NUM, value);
				this._ALL_EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 招标人代表人数
		/// </summary>
		public decimal? TENDERER_NUM
		{
			get{ return _TENDERER_NUM; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NUM, _TENDERER_NUM, value);
				this._TENDERER_NUM = value;
			}
		}
		/// <summary>
		/// 专家人数
		/// </summary>
		public decimal? EXPERT_NUM
		{
			get{ return _EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NUM, _EXPERT_NUM, value);
				this._EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 履约担保形式
		/// </summary>
		public string PERFORM_PRICE_TYPE
		{
			get{ return _PERFORM_PRICE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_PRICE_TYPE, _PERFORM_PRICE_TYPE, value);
				this._PERFORM_PRICE_TYPE = value;
			}
		}
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 监督部门联系电话
		/// </summary>
		public string SUPERVISE_DEPT_TELE
		{
			get{ return _SUPERVISE_DEPT_TELE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_TELE, _SUPERVISE_DEPT_TELE, value);
				this._SUPERVISE_DEPT_TELE = value;
			}
		}
		/// <summary>
		/// 监督部门地址
		/// </summary>
		public string SUPERVISE_DEPT_ADDRESS
		{
			get{ return _SUPERVISE_DEPT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ADDRESS, _SUPERVISE_DEPT_ADDRESS, value);
				this._SUPERVISE_DEPT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 监督部门传真
		/// </summary>
		public string SUPERVISE_DEPT_FAX
		{
			get{ return _SUPERVISE_DEPT_FAX; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_FAX, _SUPERVISE_DEPT_FAX, value);
				this._SUPERVISE_DEPT_FAX = value;
			}
		}
		/// <summary>
		/// 监督部门邮编
		/// </summary>
		public decimal? SUPERVISE_DEPT_ZIP_CODE
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE, _SUPERVISE_DEPT_ZIP_CODE, value);
				this._SUPERVISE_DEPT_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 评标委员会推荐中标候选人人数
		/// </summary>
		public decimal? WIN_CANDIDATE_NUM
		{
			get{ return _WIN_CANDIDATE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_NUM, _WIN_CANDIDATE_NUM, value);
				this._WIN_CANDIDATE_NUM = value;
			}
		}
		/// <summary>
		/// 需要补充的其他内容
		/// </summary>
		public string OTHER_CONTENT
		{
			get{ return _OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONTENT, _OTHER_CONTENT, value);
				this._OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 评标办法评审因素和评审标准
		/// </summary>
		public string EVALUATING_METHOD_STANDARD
		{
			get{ return _EVALUATING_METHOD_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_METHOD_STANDARD, _EVALUATING_METHOD_STANDARD, value);
				this._EVALUATING_METHOD_STANDARD = value;
			}
		}
		/// <summary>
		/// 发包人
		/// </summary>
		public string SUBC_NAME
		{
			get{ return _SUBC_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_NAME, _SUBC_NAME, value);
				this._SUBC_NAME = value;
			}
		}
		/// <summary>
		/// 发包人地址
		/// </summary>
		public string SUBC_NAME_ADDRESS
		{
			get{ return _SUBC_NAME_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_NAME_ADDRESS, _SUBC_NAME_ADDRESS, value);
				this._SUBC_NAME_ADDRESS = value;
			}
		}
		/// <summary>
		/// 发包人邮政编码
		/// </summary>
		public decimal? SUBC_ZIP_CODE
		{
			get{ return _SUBC_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_ZIP_CODE, _SUBC_ZIP_CODE, value);
				this._SUBC_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 监理人
		/// </summary>
		public string SUPERVISOR
		{
			get{ return _SUPERVISOR; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR, _SUPERVISOR, value);
				this._SUPERVISOR = value;
			}
		}
		/// <summary>
		/// 监理人地址
		/// </summary>
		public string SUPERVISOR_ADDRESS
		{
			get{ return _SUPERVISOR_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_ADDRESS, _SUPERVISOR_ADDRESS, value);
				this._SUPERVISOR_ADDRESS = value;
			}
		}
		/// <summary>
		/// 监理人邮政编码
		/// </summary>
		public decimal? SUPERVISOR_ZIP_CODE
		{
			get{ return _SUPERVISOR_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_ZIP_CODE, _SUPERVISOR_ZIP_CODE, value);
				this._SUPERVISOR_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 缺陷责任期
		/// </summary>
		public decimal? DEFECT_LIABILITY_PERIOD1
		{
			get{ return _DEFECT_LIABILITY_PERIOD1; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_LIABILITY_PERIOD1, _DEFECT_LIABILITY_PERIOD1, value);
				this._DEFECT_LIABILITY_PERIOD1 = value;
			}
		}
		/// <summary>
		/// 签发图纸修改图时间
		/// </summary>
		public decimal? DRAWING_MODIFICATION
		{
			get{ return _DRAWING_MODIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.DRAWING_MODIFICATION, _DRAWING_MODIFICATION, value);
				this._DRAWING_MODIFICATION = value;
			}
		}
		/// <summary>
		/// 发包人提供资料的期限
		/// </summary>
		public decimal? DATA_PERIOD
		{
			get{ return _DATA_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.DATA_PERIOD, _DATA_PERIOD, value);
				this._DATA_PERIOD = value;
			}
		}
		/// <summary>
		/// 承包人报送审批的期限
		/// </summary>
		public decimal? APPROVAL_PERIOD
		{
			get{ return _APPROVAL_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_PERIOD, _APPROVAL_PERIOD, value);
				this._APPROVAL_PERIOD = value;
			}
		}
		/// <summary>
		/// 逾期交工违约金
		/// </summary>
		public decimal? DELAY_PENALTY
		{
			get{ return _DELAY_PENALTY; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_PENALTY, _DELAY_PENALTY, value);
				this._DELAY_PENALTY = value;
			}
		}
		/// <summary>
		/// 承包人提交进度付款申请单份数
		/// </summary>
		public decimal? SUBMIT_REQUISITION
		{
			get{ return _SUBMIT_REQUISITION; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_REQUISITION, _SUBMIT_REQUISITION, value);
				this._SUBMIT_REQUISITION = value;
			}
		}
		/// <summary>
		/// 质量保证金百分比为月支付额的（%）
		/// </summary>
		public decimal? MONTHLY_PAYMENT
		{
			get{ return _MONTHLY_PAYMENT; }
			set
			{
				this.OnPropertyValueChange(_.MONTHLY_PAYMENT, _MONTHLY_PAYMENT, value);
				this._MONTHLY_PAYMENT = value;
			}
		}
		/// <summary>
		/// 承包人提交交工付款申请单份数
		/// </summary>
		public decimal? PAYMENT_APPLICATION
		{
			get{ return _PAYMENT_APPLICATION; }
			set
			{
				this.OnPropertyValueChange(_.PAYMENT_APPLICATION, _PAYMENT_APPLICATION, value);
				this._PAYMENT_APPLICATION = value;
			}
		}
		/// <summary>
		/// 承包人提交最终结清申请单份数
		/// </summary>
		public decimal? APPLICATION_NUM
		{
			get{ return _APPLICATION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.APPLICATION_NUM, _APPLICATION_NUM, value);
				this._APPLICATION_NUM = value;
			}
		}
		/// <summary>
		/// 竣工资料的份数
		/// </summary>
		public decimal? COMPLETION_DATA
		{
			get{ return _COMPLETION_DATA; }
			set
			{
				this.OnPropertyValueChange(_.COMPLETION_DATA, _COMPLETION_DATA, value);
				this._COMPLETION_DATA = value;
			}
		}
		/// <summary>
		/// 是否需投入施工期运行
		/// </summary>
		public string CONSTRUCTION_PERIOD_OPERATION
		{
			get{ return _CONSTRUCTION_PERIOD_OPERATION; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_PERIOD_OPERATION, _CONSTRUCTION_PERIOD_OPERATION, value);
				this._CONSTRUCTION_PERIOD_OPERATION = value;
			}
		}
		/// <summary>
		/// 投入施工期运行规定
		/// </summary>
		public string OPERATING_REGULATIONS
		{
			get{ return _OPERATING_REGULATIONS; }
			set
			{
				this.OnPropertyValueChange(_.OPERATING_REGULATIONS, _OPERATING_REGULATIONS, value);
				this._OPERATING_REGULATIONS = value;
			}
		}
		/// <summary>
		/// 争议的最终解决方式
		/// </summary>
		public string DISPUTE_RESOLUTION
		{
			get{ return _DISPUTE_RESOLUTION; }
			set
			{
				this.OnPropertyValueChange(_.DISPUTE_RESOLUTION, _DISPUTE_RESOLUTION, value);
				this._DISPUTE_RESOLUTION = value;
			}
		}
		/// <summary>
		/// 仲裁委员会名称
		/// </summary>
		public string ARBITRATION_COMMISSION
		{
			get{ return _ARBITRATION_COMMISSION; }
			set
			{
				this.OnPropertyValueChange(_.ARBITRATION_COMMISSION, _ARBITRATION_COMMISSION, value);
				this._ARBITRATION_COMMISSION = value;
			}
		}
		/// <summary>
		/// 下载附件的发布网站
		/// </summary>
		public string PUBLISH_WEBSITE
		{
			get{ return _PUBLISH_WEBSITE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_WEBSITE, _PUBLISH_WEBSITE, value);
				this._PUBLISH_WEBSITE = value;
			}
		}
		/// <summary>
		/// 全省联网
		/// </summary>
		public string PROVICE_NETWORKING
		{
			get{ return _PROVICE_NETWORKING; }
			set
			{
				this.OnPropertyValueChange(_.PROVICE_NETWORKING, _PROVICE_NETWORKING, value);
				this._PROVICE_NETWORKING = value;
			}
		}
		/// <summary>
		/// 项目专用合同条款
		/// </summary>
		public string CONTRACT_CLAUSE
		{
			get{ return _CONTRACT_CLAUSE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CLAUSE, _CONTRACT_CLAUSE, value);
				this._CONTRACT_CLAUSE = value;
			}
		}
		/// <summary>
		/// 工程量清单
		/// </summary>
		public string BILL_OF_QUANTITIES
		{
			get{ return _BILL_OF_QUANTITIES; }
			set
			{
				this.OnPropertyValueChange(_.BILL_OF_QUANTITIES, _BILL_OF_QUANTITIES, value);
				this._BILL_OF_QUANTITIES = value;
			}
		}
		/// <summary>
		/// 图纸
		/// </summary>
		public string DRAWING
		{
			get{ return _DRAWING; }
			set
			{
				this.OnPropertyValueChange(_.DRAWING, _DRAWING, value);
				this._DRAWING = value;
			}
		}
		/// <summary>
		/// 技术标准和要求
		/// </summary>
		public string TECHNICAL_SPECIFICATIONS
		{
			get{ return _TECHNICAL_SPECIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_SPECIFICATIONS, _TECHNICAL_SPECIFICATIONS, value);
				this._TECHNICAL_SPECIFICATIONS = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 数据自增长ID
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 数据DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// M_CREATEBY
		/// </summary>
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// M_CREATE_TM
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// M_TM
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_PLAT
		{
			get{ return _TRADE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLAT, _TRADE_PLAT, value);
				this._TRADE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PUB_SERVICE_PLAT
		{
			get{ return _PUB_SERVICE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT, _PUB_SERVICE_PLAT, value);
				this._PUB_SERVICE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODES,
				_.LIMITE_ALL_TIME,
				_.TOTAL_CONTRACT_SECTION,
				_.CONTRACT_SECTION,
				_.CONTRACT_SECTION_NUMBER,
				_.ACHIEVEMENT,
				_.OTHER_MATTERS,
				_.MEDIA1,
				_.MEDIA2,
				_.FUND_IMPLEMENTATION,
				_.BEGIN_ALL_DATE,
				_.END_DATE,
				_.PROJECT_QUALITY_TARGET,
				_.BID_SAFETY_OBJECTIVES,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.TENDER_DOC_OTHER,
				_.MARGIN_TIME,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.PROJECT_YEAR_REQUIRED,
				_.LITIGATION_YEAR_REQUIRED,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.PERFORM_PRICE_TYPE,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_TELE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_FAX,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.WIN_CANDIDATE_NUM,
				_.OTHER_CONTENT,
				_.EVALUATING_METHOD_STANDARD,
				_.SUBC_NAME,
				_.SUBC_NAME_ADDRESS,
				_.SUBC_ZIP_CODE,
				_.SUPERVISOR,
				_.SUPERVISOR_ADDRESS,
				_.SUPERVISOR_ZIP_CODE,
				_.DEFECT_LIABILITY_PERIOD1,
				_.DRAWING_MODIFICATION,
				_.DATA_PERIOD,
				_.APPROVAL_PERIOD,
				_.DELAY_PENALTY,
				_.SUBMIT_REQUISITION,
				_.MONTHLY_PAYMENT,
				_.PAYMENT_APPLICATION,
				_.APPLICATION_NUM,
				_.COMPLETION_DATA,
				_.CONSTRUCTION_PERIOD_OPERATION,
				_.OPERATING_REGULATIONS,
				_.DISPUTE_RESOLUTION,
				_.ARBITRATION_COMMISSION,
				_.PUBLISH_WEBSITE,
				_.PROVICE_NETWORKING,
				_.CONTRACT_CLAUSE,
				_.BILL_OF_QUANTITIES,
				_.DRAWING,
				_.TECHNICAL_SPECIFICATIONS,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODES,
				this._LIMITE_ALL_TIME,
				this._TOTAL_CONTRACT_SECTION,
				this._CONTRACT_SECTION,
				this._CONTRACT_SECTION_NUMBER,
				this._ACHIEVEMENT,
				this._OTHER_MATTERS,
				this._MEDIA1,
				this._MEDIA2,
				this._FUND_IMPLEMENTATION,
				this._BEGIN_ALL_DATE,
				this._END_DATE,
				this._PROJECT_QUALITY_TARGET,
				this._BID_SAFETY_OBJECTIVES,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._TENDER_DOC_OTHER,
				this._MARGIN_TIME,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._PROJECT_YEAR_REQUIRED,
				this._LITIGATION_YEAR_REQUIRED,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._PERFORM_PRICE_TYPE,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_TELE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_FAX,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._WIN_CANDIDATE_NUM,
				this._OTHER_CONTENT,
				this._EVALUATING_METHOD_STANDARD,
				this._SUBC_NAME,
				this._SUBC_NAME_ADDRESS,
				this._SUBC_ZIP_CODE,
				this._SUPERVISOR,
				this._SUPERVISOR_ADDRESS,
				this._SUPERVISOR_ZIP_CODE,
				this._DEFECT_LIABILITY_PERIOD1,
				this._DRAWING_MODIFICATION,
				this._DATA_PERIOD,
				this._APPROVAL_PERIOD,
				this._DELAY_PENALTY,
				this._SUBMIT_REQUISITION,
				this._MONTHLY_PAYMENT,
				this._PAYMENT_APPLICATION,
				this._APPLICATION_NUM,
				this._COMPLETION_DATA,
				this._CONSTRUCTION_PERIOD_OPERATION,
				this._OPERATING_REGULATIONS,
				this._DISPUTE_RESOLUTION,
				this._ARBITRATION_COMMISSION,
				this._PUBLISH_WEBSITE,
				this._PROVICE_NETWORKING,
				this._CONTRACT_CLAUSE,
				this._BILL_OF_QUANTITIES,
				this._DRAWING,
				this._TECHNICAL_SPECIFICATIONS,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "JT_ENGIN_CON_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_ENGIN_CON_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_ENGIN_CON_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 本项目共设置的合同段数量
			/// </summary>
			public readonly static Field TOTAL_CONTRACT_SECTION = new Field("TOTAL_CONTRACT_SECTION", "JT_ENGIN_CON_TENDER_FILE", "本项目共设置的合同段数量");
            /// <summary>
			/// 本次招标合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_ENGIN_CON_TENDER_FILE", "本次招标合同段数量");
            /// <summary>
			/// 本次招标合同段组数量
			/// </summary>
			public readonly static Field CONTRACT_SECTION_NUMBER = new Field("CONTRACT_SECTION_NUMBER", "JT_ENGIN_CON_TENDER_FILE", "本次招标合同段组数量");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT = new Field("ACHIEVEMENT", "JT_ENGIN_CON_TENDER_FILE", "业绩要求");
            /// <summary>
			/// 其他事项
			/// </summary>
			public readonly static Field OTHER_MATTERS = new Field("OTHER_MATTERS", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "其他事项");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_ENGIN_CON_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_ENGIN_CON_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_ENGIN_CON_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 总计划开工日期
			/// </summary>
			public readonly static Field BEGIN_ALL_DATE = new Field("BEGIN_ALL_DATE", "JT_ENGIN_CON_TENDER_FILE", "总计划开工日期");
            /// <summary>
			/// 计划交工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "JT_ENGIN_CON_TENDER_FILE", "计划交工日期");
            /// <summary>
			/// 工程质量目标
			/// </summary>
			public readonly static Field PROJECT_QUALITY_TARGET = new Field("PROJECT_QUALITY_TARGET", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "工程质量目标");
            /// <summary>
			/// 本标段的安全目标
			/// </summary>
			public readonly static Field BID_SAFETY_OBJECTIVES = new Field("BID_SAFETY_OBJECTIVES", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "本标段的安全目标");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 构成招标文件的其他材料
			/// </summary>
			public readonly static Field TENDER_DOC_OTHER = new Field("TENDER_DOC_OTHER", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "构成招标文件的其他材料");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_ENGIN_CON_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 招标人账户
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_ENGIN_CON_TENDER_FILE", "招标人账户");
            /// <summary>
			/// 招标人账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_ENGIN_CON_TENDER_FILE", "招标人账号");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_ENGIN_CON_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 完成的类似项目年份要求
			/// </summary>
			public readonly static Field PROJECT_YEAR_REQUIRED = new Field("PROJECT_YEAR_REQUIRED", "JT_ENGIN_CON_TENDER_FILE", "完成的类似项目年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况年份要求
			/// </summary>
			public readonly static Field LITIGATION_YEAR_REQUIRED = new Field("LITIGATION_YEAR_REQUIRED", "JT_ENGIN_CON_TENDER_FILE", "发生的诉讼及仲裁情况年份要求");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_ENGIN_CON_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_ENGIN_CON_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_ENGIN_CON_TENDER_FILE", "专家人数");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_PRICE_TYPE = new Field("PERFORM_PRICE_TYPE", "JT_ENGIN_CON_TENDER_FILE", "履约担保形式");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_ENGIN_CON_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_TELE = new Field("SUPERVISE_DEPT_TELE", "JT_ENGIN_CON_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_ENGIN_CON_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门传真
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX = new Field("SUPERVISE_DEPT_FAX", "JT_ENGIN_CON_TENDER_FILE", "监督部门传真");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_ENGIN_CON_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 评标委员会推荐中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "JT_ENGIN_CON_TENDER_FILE", "评标委员会推荐中标候选人人数");
            /// <summary>
			/// 需要补充的其他内容
			/// </summary>
			public readonly static Field OTHER_CONTENT = new Field("OTHER_CONTENT", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "需要补充的其他内容");
            /// <summary>
			/// 评标办法评审因素和评审标准
			/// </summary>
			public readonly static Field EVALUATING_METHOD_STANDARD = new Field("EVALUATING_METHOD_STANDARD", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "评标办法评审因素和评审标准");
            /// <summary>
			/// 发包人
			/// </summary>
			public readonly static Field SUBC_NAME = new Field("SUBC_NAME", "JT_ENGIN_CON_TENDER_FILE", "发包人");
            /// <summary>
			/// 发包人地址
			/// </summary>
			public readonly static Field SUBC_NAME_ADDRESS = new Field("SUBC_NAME_ADDRESS", "JT_ENGIN_CON_TENDER_FILE", "发包人地址");
            /// <summary>
			/// 发包人邮政编码
			/// </summary>
			public readonly static Field SUBC_ZIP_CODE = new Field("SUBC_ZIP_CODE", "JT_ENGIN_CON_TENDER_FILE", "发包人邮政编码");
            /// <summary>
			/// 监理人
			/// </summary>
			public readonly static Field SUPERVISOR = new Field("SUPERVISOR", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "监理人");
            /// <summary>
			/// 监理人地址
			/// </summary>
			public readonly static Field SUPERVISOR_ADDRESS = new Field("SUPERVISOR_ADDRESS", "JT_ENGIN_CON_TENDER_FILE", "监理人地址");
            /// <summary>
			/// 监理人邮政编码
			/// </summary>
			public readonly static Field SUPERVISOR_ZIP_CODE = new Field("SUPERVISOR_ZIP_CODE", "JT_ENGIN_CON_TENDER_FILE", "监理人邮政编码");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD1 = new Field("DEFECT_LIABILITY_PERIOD1", "JT_ENGIN_CON_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 签发图纸修改图时间
			/// </summary>
			public readonly static Field DRAWING_MODIFICATION = new Field("DRAWING_MODIFICATION", "JT_ENGIN_CON_TENDER_FILE", "签发图纸修改图时间");
            /// <summary>
			/// 发包人提供资料的期限
			/// </summary>
			public readonly static Field DATA_PERIOD = new Field("DATA_PERIOD", "JT_ENGIN_CON_TENDER_FILE", "发包人提供资料的期限");
            /// <summary>
			/// 承包人报送审批的期限
			/// </summary>
			public readonly static Field APPROVAL_PERIOD = new Field("APPROVAL_PERIOD", "JT_ENGIN_CON_TENDER_FILE", "承包人报送审批的期限");
            /// <summary>
			/// 逾期交工违约金
			/// </summary>
			public readonly static Field DELAY_PENALTY = new Field("DELAY_PENALTY", "JT_ENGIN_CON_TENDER_FILE", "逾期交工违约金");
            /// <summary>
			/// 承包人提交进度付款申请单份数
			/// </summary>
			public readonly static Field SUBMIT_REQUISITION = new Field("SUBMIT_REQUISITION", "JT_ENGIN_CON_TENDER_FILE", "承包人提交进度付款申请单份数");
            /// <summary>
			/// 质量保证金百分比为月支付额的（%）
			/// </summary>
			public readonly static Field MONTHLY_PAYMENT = new Field("MONTHLY_PAYMENT", "JT_ENGIN_CON_TENDER_FILE", "质量保证金百分比为月支付额的（%）");
            /// <summary>
			/// 承包人提交交工付款申请单份数
			/// </summary>
			public readonly static Field PAYMENT_APPLICATION = new Field("PAYMENT_APPLICATION", "JT_ENGIN_CON_TENDER_FILE", "承包人提交交工付款申请单份数");
            /// <summary>
			/// 承包人提交最终结清申请单份数
			/// </summary>
			public readonly static Field APPLICATION_NUM = new Field("APPLICATION_NUM", "JT_ENGIN_CON_TENDER_FILE", "承包人提交最终结清申请单份数");
            /// <summary>
			/// 竣工资料的份数
			/// </summary>
			public readonly static Field COMPLETION_DATA = new Field("COMPLETION_DATA", "JT_ENGIN_CON_TENDER_FILE", "竣工资料的份数");
            /// <summary>
			/// 是否需投入施工期运行
			/// </summary>
			public readonly static Field CONSTRUCTION_PERIOD_OPERATION = new Field("CONSTRUCTION_PERIOD_OPERATION", "JT_ENGIN_CON_TENDER_FILE", "是否需投入施工期运行");
            /// <summary>
			/// 投入施工期运行规定
			/// </summary>
			public readonly static Field OPERATING_REGULATIONS = new Field("OPERATING_REGULATIONS", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "投入施工期运行规定");
            /// <summary>
			/// 争议的最终解决方式
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_ENGIN_CON_TENDER_FILE", "争议的最终解决方式");
            /// <summary>
			/// 仲裁委员会名称
			/// </summary>
			public readonly static Field ARBITRATION_COMMISSION = new Field("ARBITRATION_COMMISSION", "JT_ENGIN_CON_TENDER_FILE", "仲裁委员会名称");
            /// <summary>
			/// 下载附件的发布网站
			/// </summary>
			public readonly static Field PUBLISH_WEBSITE = new Field("PUBLISH_WEBSITE", "JT_ENGIN_CON_TENDER_FILE", "下载附件的发布网站");
            /// <summary>
			/// 全省联网
			/// </summary>
			public readonly static Field PROVICE_NETWORKING = new Field("PROVICE_NETWORKING", "JT_ENGIN_CON_TENDER_FILE",DbType.AnsiString, null, "全省联网");
            /// <summary>
			/// 项目专用合同条款
			/// </summary>
			public readonly static Field CONTRACT_CLAUSE = new Field("CONTRACT_CLAUSE", "JT_ENGIN_CON_TENDER_FILE", "项目专用合同条款");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_ENGIN_CON_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_ENGIN_CON_TENDER_FILE", "图纸");
            /// <summary>
			/// 技术标准和要求
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_ENGIN_CON_TENDER_FILE", "技术标准和要求");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_ENGIN_CON_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_ENGIN_CON_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_ENGIN_CON_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_ENGIN_CON_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_ENGIN_CON_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_ENGIN_CON_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_ENGIN_CON_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_ENGIN_CON_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_ENGIN_CON_TENDER_FILE", "M_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_ENGIN_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_ENGIN_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_ENGIN_CON_TENDER_FILE", "");
        }
        #endregion
	}
}