using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_CONSTRUCT_BIDOC_REQUIRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_CONSTRUCT_BIDOC_REQUIRE")]
    [Serializable]
    public partial class SL_CONSTRUCT_BIDOC_REQUIRE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private decimal? _PROJECT_SCALE_MONEY;
		private decimal? _ALL_LIMIT_ITME;
		private string _PRICE_UNIT;
		private decimal? _BID_SECTION;
		private string _QUALITY_REQUIRE;
		private string _BIDDER_NAME;
		private string _SITE_MANAGEMENT_ORGANIZATION;
		private string _DESIGNER;
		private string _SUPERVISOR;
		private string _PROJECT_AGENCY_NAME;
		private DateTime? _END_DATE;
		private decimal? _MARGIN_AMOUNT_DIFFERENCE;
		private decimal? _SOCIAL_SECURITY_MONTH;
		private DateTime? _SOCIAL_SECURITY_TIME;
		private string _IS_RECONNAISSANCE;
		private DateTime? _RECONNAISSANCE_TIME;
		private string _RECONNAISSANCE_ADDRESS;
		private string _IS_PREPARATORY_MEETING;
		private DateTime? _PREPARATORY_MEETING_TIME;
		private string _PREPARATORY_MEETING_ADDRESS;
		private string _IS_SUBCONTRACT;
		private string _SUBCONTRACT_CONTENT_REQUIRE;
		private string _SUBCONTRACT_MONEY_REQUIRE;
		private string _THIRD_QUAL_REQUIRE;
		private string _DEVIATE_PROCESSING_METHOD;
		private string _VEHICLE;
		private string _MARGIN_NAME;
		private string _MARGINNUMBER;
		private string _MARGIN_BANK;
		private decimal? _BID_DOC_NUM;
		private string _BID_DOC_OTHER_REQUIRE;
		private decimal? _WIN_CANDIDATE_NUM;
		private decimal? _PERFORM_PRICE;
		private string _PERFORM_PRICE_TYPE;
		private string _SIMILAR_PROJECT;
		private string _MANAGER_TECH_TITLE;
		private string _MANAGER_QUAL_TYPE;
		private string _MANAGER_QUAL_LEVEL;
		private string _ACHIEVEMENT;
		private string _NOTICE_MEDIA_OTHER;
		private string _ACHIEVEMENT_REQUIRE_CONTENT;
		private string _FINANCIAL_REQUIRE_CONTENT;
		private string _REPUTATION_REQUIRE_CONTENT;
		private string _REGION_CODE;
		private decimal? _NOT_EXCEED_PERCENTILE;
		private decimal? _DEVIATE_PERCENTILE;
		private decimal? _VALID_PERIOD_NOT_EXCEEDING;
		private string _OTHER_REQUIRE;
		private decimal? _EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _BUSINESS_EXPERT_NUM;
		private decimal? _TECHNICIAN_EXPERT_NUM;
		private decimal? _K_BEGIN_NUM;
		private decimal? _K_END_NUM;
		private string _TECHNICAL_DOC_RESPON_REVIEW;
		private string _CONSTRUCTION_DESIGN_REVIEW;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _IMPORTANT_LIMITE_TIME;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _MARGIN_NUMBER;

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
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 工程总投资
		/// </summary>
		public decimal? PROJECT_SCALE_MONEY
		{
			get{ return _PROJECT_SCALE_MONEY; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_SCALE_MONEY, _PROJECT_SCALE_MONEY, value);
				this._PROJECT_SCALE_MONEY = value;
			}
		}
		/// <summary>
		/// 总工期
		/// </summary>
		public decimal? ALL_LIMIT_ITME
		{
			get{ return _ALL_LIMIT_ITME; }
			set
			{
				this.OnPropertyValueChange(_.ALL_LIMIT_ITME, _ALL_LIMIT_ITME, value);
				this._ALL_LIMIT_ITME = value;
			}
		}
		/// <summary>
		/// 工程总投资金额单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 标段（包）个数
		/// </summary>
		public decimal? BID_SECTION
		{
			get{ return _BID_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION, _BID_SECTION, value);
				this._BID_SECTION = value;
			}
		}
		/// <summary>
		/// 质量要求
		/// </summary>
		public string QUALITY_REQUIRE
		{
			get{ return _QUALITY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_REQUIRE, _QUALITY_REQUIRE, value);
				this._QUALITY_REQUIRE = value;
			}
		}
		/// <summary>
		/// 被邀请单位名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 现场管理机构
		/// </summary>
		public string SITE_MANAGEMENT_ORGANIZATION
		{
			get{ return _SITE_MANAGEMENT_ORGANIZATION; }
			set
			{
				this.OnPropertyValueChange(_.SITE_MANAGEMENT_ORGANIZATION, _SITE_MANAGEMENT_ORGANIZATION, value);
				this._SITE_MANAGEMENT_ORGANIZATION = value;
			}
		}
		/// <summary>
		/// 设计人
		/// </summary>
		public string DESIGNER
		{
			get{ return _DESIGNER; }
			set
			{
				this.OnPropertyValueChange(_.DESIGNER, _DESIGNER, value);
				this._DESIGNER = value;
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
		/// 代建机构
		/// </summary>
		public string PROJECT_AGENCY_NAME
		{
			get{ return _PROJECT_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_AGENCY_NAME, _PROJECT_AGENCY_NAME, value);
				this._PROJECT_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 计划完工日期
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
		/// 已缴纳年度保证金补差额
		/// </summary>
		public decimal? MARGIN_AMOUNT_DIFFERENCE
		{
			get{ return _MARGIN_AMOUNT_DIFFERENCE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNT_DIFFERENCE, _MARGIN_AMOUNT_DIFFERENCE, value);
				this._MARGIN_AMOUNT_DIFFERENCE = value;
			}
		}
		/// <summary>
		/// 提供近几个月的社保缴纳凭证
		/// </summary>
		public decimal? SOCIAL_SECURITY_MONTH
		{
			get{ return _SOCIAL_SECURITY_MONTH; }
			set
			{
				this.OnPropertyValueChange(_.SOCIAL_SECURITY_MONTH, _SOCIAL_SECURITY_MONTH, value);
				this._SOCIAL_SECURITY_MONTH = value;
			}
		}
		/// <summary>
		/// 社保缴纳凭证缴纳起始
		/// </summary>
		public DateTime? SOCIAL_SECURITY_TIME
		{
			get{ return _SOCIAL_SECURITY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SOCIAL_SECURITY_TIME, _SOCIAL_SECURITY_TIME, value);
				this._SOCIAL_SECURITY_TIME = value;
			}
		}
		/// <summary>
		/// 是否踏勘现场
		/// </summary>
		public string IS_RECONNAISSANCE
		{
			get{ return _IS_RECONNAISSANCE; }
			set
			{
				this.OnPropertyValueChange(_.IS_RECONNAISSANCE, _IS_RECONNAISSANCE, value);
				this._IS_RECONNAISSANCE = value;
			}
		}
		/// <summary>
		/// 踏勘时间
		/// </summary>
		public DateTime? RECONNAISSANCE_TIME
		{
			get{ return _RECONNAISSANCE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE_TIME, _RECONNAISSANCE_TIME, value);
				this._RECONNAISSANCE_TIME = value;
			}
		}
		/// <summary>
		/// 踏勘地点
		/// </summary>
		public string RECONNAISSANCE_ADDRESS
		{
			get{ return _RECONNAISSANCE_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE_ADDRESS, _RECONNAISSANCE_ADDRESS, value);
				this._RECONNAISSANCE_ADDRESS = value;
			}
		}
		/// <summary>
		/// 是否召开投标预备会
		/// </summary>
		public string IS_PREPARATORY_MEETING
		{
			get{ return _IS_PREPARATORY_MEETING; }
			set
			{
				this.OnPropertyValueChange(_.IS_PREPARATORY_MEETING, _IS_PREPARATORY_MEETING, value);
				this._IS_PREPARATORY_MEETING = value;
			}
		}
		/// <summary>
		/// 投标预备会召开时间
		/// </summary>
		public DateTime? PREPARATORY_MEETING_TIME
		{
			get{ return _PREPARATORY_MEETING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING_TIME, _PREPARATORY_MEETING_TIME, value);
				this._PREPARATORY_MEETING_TIME = value;
			}
		}
		/// <summary>
		/// 投标预备会召开地点
		/// </summary>
		public string PREPARATORY_MEETING_ADDRESS
		{
			get{ return _PREPARATORY_MEETING_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING_ADDRESS, _PREPARATORY_MEETING_ADDRESS, value);
				this._PREPARATORY_MEETING_ADDRESS = value;
			}
		}
		/// <summary>
		/// 是否分包
		/// </summary>
		public string IS_SUBCONTRACT
		{
			get{ return _IS_SUBCONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.IS_SUBCONTRACT, _IS_SUBCONTRACT, value);
				this._IS_SUBCONTRACT = value;
			}
		}
		/// <summary>
		/// 分包内容要求
		/// </summary>
		public string SUBCONTRACT_CONTENT_REQUIRE
		{
			get{ return _SUBCONTRACT_CONTENT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SUBCONTRACT_CONTENT_REQUIRE, _SUBCONTRACT_CONTENT_REQUIRE, value);
				this._SUBCONTRACT_CONTENT_REQUIRE = value;
			}
		}
		/// <summary>
		/// 分包金额要求
		/// </summary>
		public string SUBCONTRACT_MONEY_REQUIRE
		{
			get{ return _SUBCONTRACT_MONEY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SUBCONTRACT_MONEY_REQUIRE, _SUBCONTRACT_MONEY_REQUIRE, value);
				this._SUBCONTRACT_MONEY_REQUIRE = value;
			}
		}
		/// <summary>
		/// 接受分包的第三人资质要求
		/// </summary>
		public string THIRD_QUAL_REQUIRE
		{
			get{ return _THIRD_QUAL_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.THIRD_QUAL_REQUIRE, _THIRD_QUAL_REQUIRE, value);
				this._THIRD_QUAL_REQUIRE = value;
			}
		}
		/// <summary>
		/// 投标人偏离处理方法
		/// </summary>
		public string DEVIATE_PROCESSING_METHOD
		{
			get{ return _DEVIATE_PROCESSING_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.DEVIATE_PROCESSING_METHOD, _DEVIATE_PROCESSING_METHOD, value);
				this._DEVIATE_PROCESSING_METHOD = value;
			}
		}
		/// <summary>
		/// 参加使用交通工具
		/// </summary>
		public string VEHICLE
		{
			get{ return _VEHICLE; }
			set
			{
				this.OnPropertyValueChange(_.VEHICLE, _VEHICLE, value);
				this._VEHICLE = value;
			}
		}
		/// <summary>
		/// 保证金户名
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
		/// 保证金账号
		/// </summary>
		public string MARGINNUMBER
		{
			get{ return _MARGINNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.MARGINNUMBER, _MARGINNUMBER, value);
				this._MARGINNUMBER = value;
			}
		}
		/// <summary>
		/// 开户银行
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
		/// 投标文件纸质份数
		/// </summary>
		public decimal? BID_DOC_NUM
		{
			get{ return _BID_DOC_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_NUM, _BID_DOC_NUM, value);
				this._BID_DOC_NUM = value;
			}
		}
		/// <summary>
		/// 投标技术文件其他要求
		/// </summary>
		public string BID_DOC_OTHER_REQUIRE
		{
			get{ return _BID_DOC_OTHER_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_OTHER_REQUIRE, _BID_DOC_OTHER_REQUIRE, value);
				this._BID_DOC_OTHER_REQUIRE = value;
			}
		}
		/// <summary>
		/// 推选中标候选人人数
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
		/// 履约担保金额
		/// </summary>
		public decimal? PERFORM_PRICE
		{
			get{ return _PERFORM_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_PRICE, _PERFORM_PRICE, value);
				this._PERFORM_PRICE = value;
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
		/// 类似项目
		/// </summary>
		public string SIMILAR_PROJECT
		{
			get{ return _SIMILAR_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT, _SIMILAR_PROJECT, value);
				this._SIMILAR_PROJECT = value;
			}
		}
		/// <summary>
		/// 项目经理职称
		/// </summary>
		public string MANAGER_TECH_TITLE
		{
			get{ return _MANAGER_TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_TECH_TITLE, _MANAGER_TECH_TITLE, value);
				this._MANAGER_TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 项目经理专业
		/// </summary>
		public string MANAGER_QUAL_TYPE
		{
			get{ return _MANAGER_QUAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_QUAL_TYPE, _MANAGER_QUAL_TYPE, value);
				this._MANAGER_QUAL_TYPE = value;
			}
		}
		/// <summary>
		/// 项目经理注册建造师执业资格等级
		/// </summary>
		public string MANAGER_QUAL_LEVEL
		{
			get{ return _MANAGER_QUAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_QUAL_LEVEL, _MANAGER_QUAL_LEVEL, value);
				this._MANAGER_QUAL_LEVEL = value;
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
		/// 发布公告媒介
		/// </summary>
		public string NOTICE_MEDIA_OTHER
		{
			get{ return _NOTICE_MEDIA_OTHER; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_MEDIA_OTHER, _NOTICE_MEDIA_OTHER, value);
				this._NOTICE_MEDIA_OTHER = value;
			}
		}
		/// <summary>
		/// 业绩基本情况
		/// </summary>
		public string ACHIEVEMENT_REQUIRE_CONTENT
		{
			get{ return _ACHIEVEMENT_REQUIRE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT_REQUIRE_CONTENT, _ACHIEVEMENT_REQUIRE_CONTENT, value);
				this._ACHIEVEMENT_REQUIRE_CONTENT = value;
			}
		}
		/// <summary>
		/// 财务要求
		/// </summary>
		public string FINANCIAL_REQUIRE_CONTENT
		{
			get{ return _FINANCIAL_REQUIRE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE_CONTENT, _FINANCIAL_REQUIRE_CONTENT, value);
				this._FINANCIAL_REQUIRE_CONTENT = value;
			}
		}
		/// <summary>
		/// 信誉要求
		/// </summary>
		public string REPUTATION_REQUIRE_CONTENT
		{
			get{ return _REPUTATION_REQUIRE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_REQUIRE_CONTENT, _REPUTATION_REQUIRE_CONTENT, value);
				this._REPUTATION_REQUIRE_CONTENT = value;
			}
		}
		/// <summary>
		/// 对严重失信行为作出裁决火行政处罚的主管部门行政区域
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 主要清单项目的单价不得超出控制价的幅度
		/// </summary>
		public decimal? NOT_EXCEED_PERCENTILE
		{
			get{ return _NOT_EXCEED_PERCENTILE; }
			set
			{
				this.OnPropertyValueChange(_.NOT_EXCEED_PERCENTILE, _NOT_EXCEED_PERCENTILE, value);
				this._NOT_EXCEED_PERCENTILE = value;
			}
		}
		/// <summary>
		/// 主要清单项目的单价的偏差的幅度
		/// </summary>
		public decimal? DEVIATE_PERCENTILE
		{
			get{ return _DEVIATE_PERCENTILE; }
			set
			{
				this.OnPropertyValueChange(_.DEVIATE_PERCENTILE, _DEVIATE_PERCENTILE, value);
				this._DEVIATE_PERCENTILE = value;
			}
		}
		/// <summary>
		/// 投标人延长投标有效期期限
		/// </summary>
		public decimal? VALID_PERIOD_NOT_EXCEEDING
		{
			get{ return _VALID_PERIOD_NOT_EXCEEDING; }
			set
			{
				this.OnPropertyValueChange(_.VALID_PERIOD_NOT_EXCEEDING, _VALID_PERIOD_NOT_EXCEEDING, value);
				this._VALID_PERIOD_NOT_EXCEEDING = value;
			}
		}
		/// <summary>
		/// 需要补充的其他要求
		/// </summary>
		public string OTHER_REQUIRE
		{
			get{ return _OTHER_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_REQUIRE, _OTHER_REQUIRE, value);
				this._OTHER_REQUIRE = value;
			}
		}
		/// <summary>
		/// 评标委员会人数
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
		/// 商务专家人数
		/// </summary>
		public decimal? BUSINESS_EXPERT_NUM
		{
			get{ return _BUSINESS_EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_EXPERT_NUM, _BUSINESS_EXPERT_NUM, value);
				this._BUSINESS_EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 技术专家人数
		/// </summary>
		public decimal? TECHNICIAN_EXPERT_NUM
		{
			get{ return _TECHNICIAN_EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICIAN_EXPERT_NUM, _TECHNICIAN_EXPERT_NUM, value);
				this._TECHNICIAN_EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// K值最小值
		/// </summary>
		public decimal? K_BEGIN_NUM
		{
			get{ return _K_BEGIN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.K_BEGIN_NUM, _K_BEGIN_NUM, value);
				this._K_BEGIN_NUM = value;
			}
		}
		/// <summary>
		/// K值最大值
		/// </summary>
		public decimal? K_END_NUM
		{
			get{ return _K_END_NUM; }
			set
			{
				this.OnPropertyValueChange(_.K_END_NUM, _K_END_NUM, value);
				this._K_END_NUM = value;
			}
		}
		/// <summary>
		/// 技术文件响应性评审
		/// </summary>
		public string TECHNICAL_DOC_RESPON_REVIEW
		{
			get{ return _TECHNICAL_DOC_RESPON_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_DOC_RESPON_REVIEW, _TECHNICAL_DOC_RESPON_REVIEW, value);
				this._TECHNICAL_DOC_RESPON_REVIEW = value;
			}
		}
		/// <summary>
		/// 技术文件评审
		/// </summary>
		public string CONSTRUCTION_DESIGN_REVIEW
		{
			get{ return _CONSTRUCTION_DESIGN_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_DESIGN_REVIEW, _CONSTRUCTION_DESIGN_REVIEW, value);
				this._CONSTRUCTION_DESIGN_REVIEW = value;
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
		/// 重要节点工期
		/// </summary>
		public string IMPORTANT_LIMITE_TIME
		{
			get{ return _IMPORTANT_LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTANT_LIMITE_TIME, _IMPORTANT_LIMITE_TIME, value);
				this._IMPORTANT_LIMITE_TIME = value;
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
		/// <summary>
		/// 保证金账号
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
				_.BID_SECTION_CODE,
				_.PROJECT_SCALE_MONEY,
				_.ALL_LIMIT_ITME,
				_.PRICE_UNIT,
				_.BID_SECTION,
				_.QUALITY_REQUIRE,
				_.BIDDER_NAME,
				_.SITE_MANAGEMENT_ORGANIZATION,
				_.DESIGNER,
				_.SUPERVISOR,
				_.PROJECT_AGENCY_NAME,
				_.END_DATE,
				_.MARGIN_AMOUNT_DIFFERENCE,
				_.SOCIAL_SECURITY_MONTH,
				_.SOCIAL_SECURITY_TIME,
				_.IS_RECONNAISSANCE,
				_.RECONNAISSANCE_TIME,
				_.RECONNAISSANCE_ADDRESS,
				_.IS_PREPARATORY_MEETING,
				_.PREPARATORY_MEETING_TIME,
				_.PREPARATORY_MEETING_ADDRESS,
				_.IS_SUBCONTRACT,
				_.SUBCONTRACT_CONTENT_REQUIRE,
				_.SUBCONTRACT_MONEY_REQUIRE,
				_.THIRD_QUAL_REQUIRE,
				_.DEVIATE_PROCESSING_METHOD,
				_.VEHICLE,
				_.MARGIN_NAME,
				_.MARGINNUMBER,
				_.MARGIN_BANK,
				_.BID_DOC_NUM,
				_.BID_DOC_OTHER_REQUIRE,
				_.WIN_CANDIDATE_NUM,
				_.PERFORM_PRICE,
				_.PERFORM_PRICE_TYPE,
				_.SIMILAR_PROJECT,
				_.MANAGER_TECH_TITLE,
				_.MANAGER_QUAL_TYPE,
				_.MANAGER_QUAL_LEVEL,
				_.ACHIEVEMENT,
				_.NOTICE_MEDIA_OTHER,
				_.ACHIEVEMENT_REQUIRE_CONTENT,
				_.FINANCIAL_REQUIRE_CONTENT,
				_.REPUTATION_REQUIRE_CONTENT,
				_.REGION_CODE,
				_.NOT_EXCEED_PERCENTILE,
				_.DEVIATE_PERCENTILE,
				_.VALID_PERIOD_NOT_EXCEEDING,
				_.OTHER_REQUIRE,
				_.EXPERT_NUM,
				_.TENDERER_NUM,
				_.BUSINESS_EXPERT_NUM,
				_.TECHNICIAN_EXPERT_NUM,
				_.K_BEGIN_NUM,
				_.K_END_NUM,
				_.TECHNICAL_DOC_RESPON_REVIEW,
				_.CONSTRUCTION_DESIGN_REVIEW,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.IMPORTANT_LIMITE_TIME,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.MARGIN_NUMBER,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._PROJECT_SCALE_MONEY,
				this._ALL_LIMIT_ITME,
				this._PRICE_UNIT,
				this._BID_SECTION,
				this._QUALITY_REQUIRE,
				this._BIDDER_NAME,
				this._SITE_MANAGEMENT_ORGANIZATION,
				this._DESIGNER,
				this._SUPERVISOR,
				this._PROJECT_AGENCY_NAME,
				this._END_DATE,
				this._MARGIN_AMOUNT_DIFFERENCE,
				this._SOCIAL_SECURITY_MONTH,
				this._SOCIAL_SECURITY_TIME,
				this._IS_RECONNAISSANCE,
				this._RECONNAISSANCE_TIME,
				this._RECONNAISSANCE_ADDRESS,
				this._IS_PREPARATORY_MEETING,
				this._PREPARATORY_MEETING_TIME,
				this._PREPARATORY_MEETING_ADDRESS,
				this._IS_SUBCONTRACT,
				this._SUBCONTRACT_CONTENT_REQUIRE,
				this._SUBCONTRACT_MONEY_REQUIRE,
				this._THIRD_QUAL_REQUIRE,
				this._DEVIATE_PROCESSING_METHOD,
				this._VEHICLE,
				this._MARGIN_NAME,
				this._MARGINNUMBER,
				this._MARGIN_BANK,
				this._BID_DOC_NUM,
				this._BID_DOC_OTHER_REQUIRE,
				this._WIN_CANDIDATE_NUM,
				this._PERFORM_PRICE,
				this._PERFORM_PRICE_TYPE,
				this._SIMILAR_PROJECT,
				this._MANAGER_TECH_TITLE,
				this._MANAGER_QUAL_TYPE,
				this._MANAGER_QUAL_LEVEL,
				this._ACHIEVEMENT,
				this._NOTICE_MEDIA_OTHER,
				this._ACHIEVEMENT_REQUIRE_CONTENT,
				this._FINANCIAL_REQUIRE_CONTENT,
				this._REPUTATION_REQUIRE_CONTENT,
				this._REGION_CODE,
				this._NOT_EXCEED_PERCENTILE,
				this._DEVIATE_PERCENTILE,
				this._VALID_PERIOD_NOT_EXCEEDING,
				this._OTHER_REQUIRE,
				this._EXPERT_NUM,
				this._TENDERER_NUM,
				this._BUSINESS_EXPERT_NUM,
				this._TECHNICIAN_EXPERT_NUM,
				this._K_BEGIN_NUM,
				this._K_END_NUM,
				this._TECHNICAL_DOC_RESPON_REVIEW,
				this._CONSTRUCTION_DESIGN_REVIEW,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._IMPORTANT_LIMITE_TIME,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._MARGIN_NUMBER,
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
			public readonly static Field All = new Field("*", "SL_CONSTRUCT_BIDOC_REQUIRE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_CONSTRUCT_BIDOC_REQUIRE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_CONSTRUCT_BIDOC_REQUIRE", "标段（包）编号");
            /// <summary>
			/// 工程总投资
			/// </summary>
			public readonly static Field PROJECT_SCALE_MONEY = new Field("PROJECT_SCALE_MONEY", "SL_CONSTRUCT_BIDOC_REQUIRE", "工程总投资");
            /// <summary>
			/// 总工期
			/// </summary>
			public readonly static Field ALL_LIMIT_ITME = new Field("ALL_LIMIT_ITME", "SL_CONSTRUCT_BIDOC_REQUIRE", "总工期");
            /// <summary>
			/// 工程总投资金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "SL_CONSTRUCT_BIDOC_REQUIRE", "工程总投资金额单位");
            /// <summary>
			/// 标段（包）个数
			/// </summary>
			public readonly static Field BID_SECTION = new Field("BID_SECTION", "SL_CONSTRUCT_BIDOC_REQUIRE", "标段（包）个数");
            /// <summary>
			/// 质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE = new Field("QUALITY_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "质量要求");
            /// <summary>
			/// 被邀请单位名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "SL_CONSTRUCT_BIDOC_REQUIRE", "被邀请单位名称");
            /// <summary>
			/// 现场管理机构
			/// </summary>
			public readonly static Field SITE_MANAGEMENT_ORGANIZATION = new Field("SITE_MANAGEMENT_ORGANIZATION", "SL_CONSTRUCT_BIDOC_REQUIRE", "现场管理机构");
            /// <summary>
			/// 设计人
			/// </summary>
			public readonly static Field DESIGNER = new Field("DESIGNER", "SL_CONSTRUCT_BIDOC_REQUIRE", "设计人");
            /// <summary>
			/// 监理人
			/// </summary>
			public readonly static Field SUPERVISOR = new Field("SUPERVISOR", "SL_CONSTRUCT_BIDOC_REQUIRE", "监理人");
            /// <summary>
			/// 代建机构
			/// </summary>
			public readonly static Field PROJECT_AGENCY_NAME = new Field("PROJECT_AGENCY_NAME", "SL_CONSTRUCT_BIDOC_REQUIRE", "代建机构");
            /// <summary>
			/// 计划完工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "SL_CONSTRUCT_BIDOC_REQUIRE", "计划完工日期");
            /// <summary>
			/// 已缴纳年度保证金补差额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT_DIFFERENCE = new Field("MARGIN_AMOUNT_DIFFERENCE", "SL_CONSTRUCT_BIDOC_REQUIRE", "已缴纳年度保证金补差额");
            /// <summary>
			/// 提供近几个月的社保缴纳凭证
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_MONTH = new Field("SOCIAL_SECURITY_MONTH", "SL_CONSTRUCT_BIDOC_REQUIRE", "提供近几个月的社保缴纳凭证");
            /// <summary>
			/// 社保缴纳凭证缴纳起始
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_TIME = new Field("SOCIAL_SECURITY_TIME", "SL_CONSTRUCT_BIDOC_REQUIRE", "社保缴纳凭证缴纳起始");
            /// <summary>
			/// 是否踏勘现场
			/// </summary>
			public readonly static Field IS_RECONNAISSANCE = new Field("IS_RECONNAISSANCE", "SL_CONSTRUCT_BIDOC_REQUIRE", "是否踏勘现场");
            /// <summary>
			/// 踏勘时间
			/// </summary>
			public readonly static Field RECONNAISSANCE_TIME = new Field("RECONNAISSANCE_TIME", "SL_CONSTRUCT_BIDOC_REQUIRE", "踏勘时间");
            /// <summary>
			/// 踏勘地点
			/// </summary>
			public readonly static Field RECONNAISSANCE_ADDRESS = new Field("RECONNAISSANCE_ADDRESS", "SL_CONSTRUCT_BIDOC_REQUIRE", "踏勘地点");
            /// <summary>
			/// 是否召开投标预备会
			/// </summary>
			public readonly static Field IS_PREPARATORY_MEETING = new Field("IS_PREPARATORY_MEETING", "SL_CONSTRUCT_BIDOC_REQUIRE", "是否召开投标预备会");
            /// <summary>
			/// 投标预备会召开时间
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_TIME = new Field("PREPARATORY_MEETING_TIME", "SL_CONSTRUCT_BIDOC_REQUIRE", "投标预备会召开时间");
            /// <summary>
			/// 投标预备会召开地点
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_ADDRESS = new Field("PREPARATORY_MEETING_ADDRESS", "SL_CONSTRUCT_BIDOC_REQUIRE", "投标预备会召开地点");
            /// <summary>
			/// 是否分包
			/// </summary>
			public readonly static Field IS_SUBCONTRACT = new Field("IS_SUBCONTRACT", "SL_CONSTRUCT_BIDOC_REQUIRE", "是否分包");
            /// <summary>
			/// 分包内容要求
			/// </summary>
			public readonly static Field SUBCONTRACT_CONTENT_REQUIRE = new Field("SUBCONTRACT_CONTENT_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "分包内容要求");
            /// <summary>
			/// 分包金额要求
			/// </summary>
			public readonly static Field SUBCONTRACT_MONEY_REQUIRE = new Field("SUBCONTRACT_MONEY_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "分包金额要求");
            /// <summary>
			/// 接受分包的第三人资质要求
			/// </summary>
			public readonly static Field THIRD_QUAL_REQUIRE = new Field("THIRD_QUAL_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "接受分包的第三人资质要求");
            /// <summary>
			/// 投标人偏离处理方法
			/// </summary>
			public readonly static Field DEVIATE_PROCESSING_METHOD = new Field("DEVIATE_PROCESSING_METHOD", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "投标人偏离处理方法");
            /// <summary>
			/// 参加使用交通工具
			/// </summary>
			public readonly static Field VEHICLE = new Field("VEHICLE", "SL_CONSTRUCT_BIDOC_REQUIRE", "参加使用交通工具");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "SL_CONSTRUCT_BIDOC_REQUIRE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGINNUMBER = new Field("MARGINNUMBER", "SL_CONSTRUCT_BIDOC_REQUIRE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "SL_CONSTRUCT_BIDOC_REQUIRE", "开户银行");
            /// <summary>
			/// 投标文件纸质份数
			/// </summary>
			public readonly static Field BID_DOC_NUM = new Field("BID_DOC_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "投标文件纸质份数");
            /// <summary>
			/// 投标技术文件其他要求
			/// </summary>
			public readonly static Field BID_DOC_OTHER_REQUIRE = new Field("BID_DOC_OTHER_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "投标技术文件其他要求");
            /// <summary>
			/// 推选中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "推选中标候选人人数");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "SL_CONSTRUCT_BIDOC_REQUIRE", "履约担保金额");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_PRICE_TYPE = new Field("PERFORM_PRICE_TYPE", "SL_CONSTRUCT_BIDOC_REQUIRE", "履约担保形式");
            /// <summary>
			/// 类似项目
			/// </summary>
			public readonly static Field SIMILAR_PROJECT = new Field("SIMILAR_PROJECT", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "类似项目");
            /// <summary>
			/// 项目经理职称
			/// </summary>
			public readonly static Field MANAGER_TECH_TITLE = new Field("MANAGER_TECH_TITLE", "SL_CONSTRUCT_BIDOC_REQUIRE", "项目经理职称");
            /// <summary>
			/// 项目经理专业
			/// </summary>
			public readonly static Field MANAGER_QUAL_TYPE = new Field("MANAGER_QUAL_TYPE", "SL_CONSTRUCT_BIDOC_REQUIRE", "项目经理专业");
            /// <summary>
			/// 项目经理注册建造师执业资格等级
			/// </summary>
			public readonly static Field MANAGER_QUAL_LEVEL = new Field("MANAGER_QUAL_LEVEL", "SL_CONSTRUCT_BIDOC_REQUIRE", "项目经理注册建造师执业资格等级");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT = new Field("ACHIEVEMENT", "SL_CONSTRUCT_BIDOC_REQUIRE", "业绩要求");
            /// <summary>
			/// 发布公告媒介
			/// </summary>
			public readonly static Field NOTICE_MEDIA_OTHER = new Field("NOTICE_MEDIA_OTHER", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "发布公告媒介");
            /// <summary>
			/// 业绩基本情况
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE_CONTENT = new Field("ACHIEVEMENT_REQUIRE_CONTENT", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "业绩基本情况");
            /// <summary>
			/// 财务要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_CONTENT = new Field("FINANCIAL_REQUIRE_CONTENT", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "财务要求");
            /// <summary>
			/// 信誉要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE_CONTENT = new Field("REPUTATION_REQUIRE_CONTENT", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "信誉要求");
            /// <summary>
			/// 对严重失信行为作出裁决火行政处罚的主管部门行政区域
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "对严重失信行为作出裁决火行政处罚的主管部门行政区域");
            /// <summary>
			/// 主要清单项目的单价不得超出控制价的幅度
			/// </summary>
			public readonly static Field NOT_EXCEED_PERCENTILE = new Field("NOT_EXCEED_PERCENTILE", "SL_CONSTRUCT_BIDOC_REQUIRE", "主要清单项目的单价不得超出控制价的幅度");
            /// <summary>
			/// 主要清单项目的单价的偏差的幅度
			/// </summary>
			public readonly static Field DEVIATE_PERCENTILE = new Field("DEVIATE_PERCENTILE", "SL_CONSTRUCT_BIDOC_REQUIRE", "主要清单项目的单价的偏差的幅度");
            /// <summary>
			/// 投标人延长投标有效期期限
			/// </summary>
			public readonly static Field VALID_PERIOD_NOT_EXCEEDING = new Field("VALID_PERIOD_NOT_EXCEEDING", "SL_CONSTRUCT_BIDOC_REQUIRE", "投标人延长投标有效期期限");
            /// <summary>
			/// 需要补充的其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "需要补充的其他要求");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "招标人代表人数");
            /// <summary>
			/// 商务专家人数
			/// </summary>
			public readonly static Field BUSINESS_EXPERT_NUM = new Field("BUSINESS_EXPERT_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "商务专家人数");
            /// <summary>
			/// 技术专家人数
			/// </summary>
			public readonly static Field TECHNICIAN_EXPERT_NUM = new Field("TECHNICIAN_EXPERT_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "技术专家人数");
            /// <summary>
			/// K值最小值
			/// </summary>
			public readonly static Field K_BEGIN_NUM = new Field("K_BEGIN_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "K值最小值");
            /// <summary>
			/// K值最大值
			/// </summary>
			public readonly static Field K_END_NUM = new Field("K_END_NUM", "SL_CONSTRUCT_BIDOC_REQUIRE", "K值最大值");
            /// <summary>
			/// 技术文件响应性评审
			/// </summary>
			public readonly static Field TECHNICAL_DOC_RESPON_REVIEW = new Field("TECHNICAL_DOC_RESPON_REVIEW", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "技术文件响应性评审");
            /// <summary>
			/// 技术文件评审
			/// </summary>
			public readonly static Field CONSTRUCTION_DESIGN_REVIEW = new Field("CONSTRUCTION_DESIGN_REVIEW", "SL_CONSTRUCT_BIDOC_REQUIRE",DbType.AnsiString, null, "技术文件评审");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_CONSTRUCT_BIDOC_REQUIRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_CONSTRUCT_BIDOC_REQUIRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_CONSTRUCT_BIDOC_REQUIRE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_CONSTRUCT_BIDOC_REQUIRE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_CONSTRUCT_BIDOC_REQUIRE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_CONSTRUCT_BIDOC_REQUIRE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_CONSTRUCT_BIDOC_REQUIRE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_CONSTRUCT_BIDOC_REQUIRE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_CONSTRUCT_BIDOC_REQUIRE", "M_TM");
            /// <summary>
			/// 重要节点工期
			/// </summary>
			public readonly static Field IMPORTANT_LIMITE_TIME = new Field("IMPORTANT_LIMITE_TIME", "SL_CONSTRUCT_BIDOC_REQUIRE", "重要节点工期");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_CONSTRUCT_BIDOC_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_CONSTRUCT_BIDOC_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_CONSTRUCT_BIDOC_REQUIRE", "");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "SL_CONSTRUCT_BIDOC_REQUIRE", "保证金账号");
        }
        #endregion
	}
}