using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_CONSTRUCT_SUPER_REQUIRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_CONSTRUCT_SUPER_REQUIRE")]
    [Serializable]
    public partial class SL_CONSTRUCT_SUPER_REQUIRE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private decimal? _PROJECT_SCALE_MONEY;
		private decimal? _ALL_LIMIT_ITME;
		private string _PRICE_UNIT;
		private string _QUALITY_REQUIRE;
		private decimal? _SERVICE_TIME;
		private string _ACHIEVEMENT;
		private string _SIMILAR_PROJECT;
		private DateTime? _SIMILAR_PROJECT_TIME;
		private string _SUPER_ENGINEER_REQUIRE;
		private string _IS_RECONNAISSANCE;
		private DateTime? _RECONNAISSANCE_TIME;
		private string _RECONNAISSANCE_ADDRESS;
		private string _IS_PREPARATORY_MEETING;
		private DateTime? _PREPARATORY_MEETING_TIME;
		private string _PREPARATORY_MEETING_ADDRESS;
		private string _VEHICLE;
		private string _NOTICE_MEDIA4;
		private string _BIDDER_NAME;
		private string _CONTRACT_NAME;
		private string _CONTRACT_CODE;
		private string _DESIGNER;
		private string _PROJECT_OVERVIEW;
		private decimal? _SOCIAL_SECURITY_MONTH;
		private DateTime? _SOCIAL_SECURITY_TIME;
		private string _BID_PRICE_APPOINTMENT;
		private decimal? _VALID_PERIOD_NOT_EXCEEDING;
		private decimal? _MARGIN_AMOUNTDIFFERENCE;
		private string _MARGIN_NAME;
		private string _MARGINNUMBER;
		private string _MARGIN_BANK;
		private decimal? _MARGIN_AMOUNT;
		private decimal? _BID_DOC_NUM;
		private string _BID_DOC_OTHER_REQUIRE;
		private decimal? _WIN_CANDIDATE_NUM;
		private decimal? _PERFORM_PRICE;
		private string _PERFORM_PRICE_TYPE;
		private string _OTHER_REQUIRE;
		private decimal? _EXPERT_NUM;
		private decimal? _K_BEGIN_NUM;
		private decimal? _K_END_NUM;
		private string _QUALITY_CERTIFICATION_REQUIRE;
		private string _FINANCIAL_REQUIRE;
		private string _CREDIT_REQUIRE;
		private string _SUPERVISION_BASIS;
		private string _CLIENT_RIGHTS;
		private string _SUPERVISOR_RIGHTS;
		private string _CLIENT_OBLIGATIONS;
		private string _SUPERVISOR_OBLIGATIONS;
		private string _SUPERVISION_SERVICE_FEE;
		private string _BREACH_RESPONSIBILITY;
		private string _DISPUTE_RESOLUTION;
		private string _OTHER_CLAUSE;
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
		private decimal? _MARGIN_AMOUNT_DIFFERENCE;
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
		/// 服务工期
		/// </summary>
		public decimal? SERVICE_TIME
		{
			get{ return _SERVICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_TIME, _SERVICE_TIME, value);
				this._SERVICE_TIME = value;
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
		/// 承担过类似本工程项目的近10年时间
		/// </summary>
		public DateTime? SIMILAR_PROJECT_TIME
		{
			get{ return _SIMILAR_PROJECT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_TIME, _SIMILAR_PROJECT_TIME, value);
				this._SIMILAR_PROJECT_TIME = value;
			}
		}
		/// <summary>
		/// 拟派本工程项目的总监理工程师要求
		/// </summary>
		public string SUPER_ENGINEER_REQUIRE
		{
			get{ return _SUPER_ENGINEER_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SUPER_ENGINEER_REQUIRE, _SUPER_ENGINEER_REQUIRE, value);
				this._SUPER_ENGINEER_REQUIRE = value;
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
		/// 发布公告媒介
		/// </summary>
		public string NOTICE_MEDIA4
		{
			get{ return _NOTICE_MEDIA4; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_MEDIA4, _NOTICE_MEDIA4, value);
				this._NOTICE_MEDIA4 = value;
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
		/// 合同名称
		/// </summary>
		public string CONTRACT_NAME
		{
			get{ return _CONTRACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_NAME, _CONTRACT_NAME, value);
				this._CONTRACT_NAME = value;
			}
		}
		/// <summary>
		/// 合同编号
		/// </summary>
		public string CONTRACT_CODE
		{
			get{ return _CONTRACT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CODE, _CONTRACT_CODE, value);
				this._CONTRACT_CODE = value;
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
		/// 工程概况
		/// </summary>
		public string PROJECT_OVERVIEW
		{
			get{ return _PROJECT_OVERVIEW; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_OVERVIEW, _PROJECT_OVERVIEW, value);
				this._PROJECT_OVERVIEW = value;
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
		/// 根据招标项目具体情况约定
		/// </summary>
		public string BID_PRICE_APPOINTMENT
		{
			get{ return _BID_PRICE_APPOINTMENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_PRICE_APPOINTMENT, _BID_PRICE_APPOINTMENT, value);
				this._BID_PRICE_APPOINTMENT = value;
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
		/// 保证金差额
		/// </summary>
		public decimal? MARGIN_AMOUNTDIFFERENCE
		{
			get{ return _MARGIN_AMOUNTDIFFERENCE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNTDIFFERENCE, _MARGIN_AMOUNTDIFFERENCE, value);
				this._MARGIN_AMOUNTDIFFERENCE = value;
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
		/// 银行保函金额
		/// </summary>
		public decimal? MARGIN_AMOUNT
		{
			get{ return _MARGIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNT, _MARGIN_AMOUNT, value);
				this._MARGIN_AMOUNT = value;
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
		/// 质量管理认证体系满足招标文件的要求
		/// </summary>
		public string QUALITY_CERTIFICATION_REQUIRE
		{
			get{ return _QUALITY_CERTIFICATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_CERTIFICATION_REQUIRE, _QUALITY_CERTIFICATION_REQUIRE, value);
				this._QUALITY_CERTIFICATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 财务要求
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
		/// 信誉要求
		/// </summary>
		public string CREDIT_REQUIRE
		{
			get{ return _CREDIT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_REQUIRE, _CREDIT_REQUIRE, value);
				this._CREDIT_REQUIRE = value;
			}
		}
		/// <summary>
		/// 监理依据
		/// </summary>
		public string SUPERVISION_BASIS
		{
			get{ return _SUPERVISION_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_BASIS, _SUPERVISION_BASIS, value);
				this._SUPERVISION_BASIS = value;
			}
		}
		/// <summary>
		/// 委托人的权利
		/// </summary>
		public string CLIENT_RIGHTS
		{
			get{ return _CLIENT_RIGHTS; }
			set
			{
				this.OnPropertyValueChange(_.CLIENT_RIGHTS, _CLIENT_RIGHTS, value);
				this._CLIENT_RIGHTS = value;
			}
		}
		/// <summary>
		/// 监理人的权利
		/// </summary>
		public string SUPERVISOR_RIGHTS
		{
			get{ return _SUPERVISOR_RIGHTS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_RIGHTS, _SUPERVISOR_RIGHTS, value);
				this._SUPERVISOR_RIGHTS = value;
			}
		}
		/// <summary>
		/// 委托人的义务
		/// </summary>
		public string CLIENT_OBLIGATIONS
		{
			get{ return _CLIENT_OBLIGATIONS; }
			set
			{
				this.OnPropertyValueChange(_.CLIENT_OBLIGATIONS, _CLIENT_OBLIGATIONS, value);
				this._CLIENT_OBLIGATIONS = value;
			}
		}
		/// <summary>
		/// 监理人的义务
		/// </summary>
		public string SUPERVISOR_OBLIGATIONS
		{
			get{ return _SUPERVISOR_OBLIGATIONS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_OBLIGATIONS, _SUPERVISOR_OBLIGATIONS, value);
				this._SUPERVISOR_OBLIGATIONS = value;
			}
		}
		/// <summary>
		/// 监理服务酬金
		/// </summary>
		public string SUPERVISION_SERVICE_FEE
		{
			get{ return _SUPERVISION_SERVICE_FEE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_SERVICE_FEE, _SUPERVISION_SERVICE_FEE, value);
				this._SUPERVISION_SERVICE_FEE = value;
			}
		}
		/// <summary>
		/// 违约责任
		/// </summary>
		public string BREACH_RESPONSIBILITY
		{
			get{ return _BREACH_RESPONSIBILITY; }
			set
			{
				this.OnPropertyValueChange(_.BREACH_RESPONSIBILITY, _BREACH_RESPONSIBILITY, value);
				this._BREACH_RESPONSIBILITY = value;
			}
		}
		/// <summary>
		/// 争议的解决
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
		/// 其他
		/// </summary>
		public string OTHER_CLAUSE
		{
			get{ return _OTHER_CLAUSE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CLAUSE, _OTHER_CLAUSE, value);
				this._OTHER_CLAUSE = value;
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
		/// 保证金差额
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
				_.QUALITY_REQUIRE,
				_.SERVICE_TIME,
				_.ACHIEVEMENT,
				_.SIMILAR_PROJECT,
				_.SIMILAR_PROJECT_TIME,
				_.SUPER_ENGINEER_REQUIRE,
				_.IS_RECONNAISSANCE,
				_.RECONNAISSANCE_TIME,
				_.RECONNAISSANCE_ADDRESS,
				_.IS_PREPARATORY_MEETING,
				_.PREPARATORY_MEETING_TIME,
				_.PREPARATORY_MEETING_ADDRESS,
				_.VEHICLE,
				_.NOTICE_MEDIA4,
				_.BIDDER_NAME,
				_.CONTRACT_NAME,
				_.CONTRACT_CODE,
				_.DESIGNER,
				_.PROJECT_OVERVIEW,
				_.SOCIAL_SECURITY_MONTH,
				_.SOCIAL_SECURITY_TIME,
				_.BID_PRICE_APPOINTMENT,
				_.VALID_PERIOD_NOT_EXCEEDING,
				_.MARGIN_AMOUNTDIFFERENCE,
				_.MARGIN_NAME,
				_.MARGINNUMBER,
				_.MARGIN_BANK,
				_.MARGIN_AMOUNT,
				_.BID_DOC_NUM,
				_.BID_DOC_OTHER_REQUIRE,
				_.WIN_CANDIDATE_NUM,
				_.PERFORM_PRICE,
				_.PERFORM_PRICE_TYPE,
				_.OTHER_REQUIRE,
				_.EXPERT_NUM,
				_.K_BEGIN_NUM,
				_.K_END_NUM,
				_.QUALITY_CERTIFICATION_REQUIRE,
				_.FINANCIAL_REQUIRE,
				_.CREDIT_REQUIRE,
				_.SUPERVISION_BASIS,
				_.CLIENT_RIGHTS,
				_.SUPERVISOR_RIGHTS,
				_.CLIENT_OBLIGATIONS,
				_.SUPERVISOR_OBLIGATIONS,
				_.SUPERVISION_SERVICE_FEE,
				_.BREACH_RESPONSIBILITY,
				_.DISPUTE_RESOLUTION,
				_.OTHER_CLAUSE,
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
				_.MARGIN_AMOUNT_DIFFERENCE,
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
				this._QUALITY_REQUIRE,
				this._SERVICE_TIME,
				this._ACHIEVEMENT,
				this._SIMILAR_PROJECT,
				this._SIMILAR_PROJECT_TIME,
				this._SUPER_ENGINEER_REQUIRE,
				this._IS_RECONNAISSANCE,
				this._RECONNAISSANCE_TIME,
				this._RECONNAISSANCE_ADDRESS,
				this._IS_PREPARATORY_MEETING,
				this._PREPARATORY_MEETING_TIME,
				this._PREPARATORY_MEETING_ADDRESS,
				this._VEHICLE,
				this._NOTICE_MEDIA4,
				this._BIDDER_NAME,
				this._CONTRACT_NAME,
				this._CONTRACT_CODE,
				this._DESIGNER,
				this._PROJECT_OVERVIEW,
				this._SOCIAL_SECURITY_MONTH,
				this._SOCIAL_SECURITY_TIME,
				this._BID_PRICE_APPOINTMENT,
				this._VALID_PERIOD_NOT_EXCEEDING,
				this._MARGIN_AMOUNTDIFFERENCE,
				this._MARGIN_NAME,
				this._MARGINNUMBER,
				this._MARGIN_BANK,
				this._MARGIN_AMOUNT,
				this._BID_DOC_NUM,
				this._BID_DOC_OTHER_REQUIRE,
				this._WIN_CANDIDATE_NUM,
				this._PERFORM_PRICE,
				this._PERFORM_PRICE_TYPE,
				this._OTHER_REQUIRE,
				this._EXPERT_NUM,
				this._K_BEGIN_NUM,
				this._K_END_NUM,
				this._QUALITY_CERTIFICATION_REQUIRE,
				this._FINANCIAL_REQUIRE,
				this._CREDIT_REQUIRE,
				this._SUPERVISION_BASIS,
				this._CLIENT_RIGHTS,
				this._SUPERVISOR_RIGHTS,
				this._CLIENT_OBLIGATIONS,
				this._SUPERVISOR_OBLIGATIONS,
				this._SUPERVISION_SERVICE_FEE,
				this._BREACH_RESPONSIBILITY,
				this._DISPUTE_RESOLUTION,
				this._OTHER_CLAUSE,
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
				this._MARGIN_AMOUNT_DIFFERENCE,
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
			public readonly static Field All = new Field("*", "SL_CONSTRUCT_SUPER_REQUIRE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_CONSTRUCT_SUPER_REQUIRE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_CONSTRUCT_SUPER_REQUIRE", "标段（包）编号");
            /// <summary>
			/// 工程总投资
			/// </summary>
			public readonly static Field PROJECT_SCALE_MONEY = new Field("PROJECT_SCALE_MONEY", "SL_CONSTRUCT_SUPER_REQUIRE", "工程总投资");
            /// <summary>
			/// 总工期
			/// </summary>
			public readonly static Field ALL_LIMIT_ITME = new Field("ALL_LIMIT_ITME", "SL_CONSTRUCT_SUPER_REQUIRE", "总工期");
            /// <summary>
			/// 工程总投资金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "SL_CONSTRUCT_SUPER_REQUIRE", "工程总投资金额单位");
            /// <summary>
			/// 质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE = new Field("QUALITY_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "质量要求");
            /// <summary>
			/// 服务工期
			/// </summary>
			public readonly static Field SERVICE_TIME = new Field("SERVICE_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "服务工期");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT = new Field("ACHIEVEMENT", "SL_CONSTRUCT_SUPER_REQUIRE", "业绩要求");
            /// <summary>
			/// 类似项目
			/// </summary>
			public readonly static Field SIMILAR_PROJECT = new Field("SIMILAR_PROJECT", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "类似项目");
            /// <summary>
			/// 承担过类似本工程项目的近10年时间
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_TIME = new Field("SIMILAR_PROJECT_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "承担过类似本工程项目的近10年时间");
            /// <summary>
			/// 拟派本工程项目的总监理工程师要求
			/// </summary>
			public readonly static Field SUPER_ENGINEER_REQUIRE = new Field("SUPER_ENGINEER_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "拟派本工程项目的总监理工程师要求");
            /// <summary>
			/// 是否踏勘现场
			/// </summary>
			public readonly static Field IS_RECONNAISSANCE = new Field("IS_RECONNAISSANCE", "SL_CONSTRUCT_SUPER_REQUIRE", "是否踏勘现场");
            /// <summary>
			/// 踏勘时间
			/// </summary>
			public readonly static Field RECONNAISSANCE_TIME = new Field("RECONNAISSANCE_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "踏勘时间");
            /// <summary>
			/// 踏勘地点
			/// </summary>
			public readonly static Field RECONNAISSANCE_ADDRESS = new Field("RECONNAISSANCE_ADDRESS", "SL_CONSTRUCT_SUPER_REQUIRE", "踏勘地点");
            /// <summary>
			/// 是否召开投标预备会
			/// </summary>
			public readonly static Field IS_PREPARATORY_MEETING = new Field("IS_PREPARATORY_MEETING", "SL_CONSTRUCT_SUPER_REQUIRE", "是否召开投标预备会");
            /// <summary>
			/// 投标预备会召开时间
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_TIME = new Field("PREPARATORY_MEETING_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "投标预备会召开时间");
            /// <summary>
			/// 投标预备会召开地点
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_ADDRESS = new Field("PREPARATORY_MEETING_ADDRESS", "SL_CONSTRUCT_SUPER_REQUIRE", "投标预备会召开地点");
            /// <summary>
			/// 参加使用交通工具
			/// </summary>
			public readonly static Field VEHICLE = new Field("VEHICLE", "SL_CONSTRUCT_SUPER_REQUIRE", "参加使用交通工具");
            /// <summary>
			/// 发布公告媒介
			/// </summary>
			public readonly static Field NOTICE_MEDIA4 = new Field("NOTICE_MEDIA4", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "发布公告媒介");
            /// <summary>
			/// 被邀请单位名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "SL_CONSTRUCT_SUPER_REQUIRE", "被邀请单位名称");
            /// <summary>
			/// 合同名称
			/// </summary>
			public readonly static Field CONTRACT_NAME = new Field("CONTRACT_NAME", "SL_CONSTRUCT_SUPER_REQUIRE", "合同名称");
            /// <summary>
			/// 合同编号
			/// </summary>
			public readonly static Field CONTRACT_CODE = new Field("CONTRACT_CODE", "SL_CONSTRUCT_SUPER_REQUIRE", "合同编号");
            /// <summary>
			/// 设计人
			/// </summary>
			public readonly static Field DESIGNER = new Field("DESIGNER", "SL_CONSTRUCT_SUPER_REQUIRE", "设计人");
            /// <summary>
			/// 工程概况
			/// </summary>
			public readonly static Field PROJECT_OVERVIEW = new Field("PROJECT_OVERVIEW", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "工程概况");
            /// <summary>
			/// 提供近几个月的社保缴纳凭证
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_MONTH = new Field("SOCIAL_SECURITY_MONTH", "SL_CONSTRUCT_SUPER_REQUIRE", "提供近几个月的社保缴纳凭证");
            /// <summary>
			/// 社保缴纳凭证缴纳起始
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_TIME = new Field("SOCIAL_SECURITY_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "社保缴纳凭证缴纳起始");
            /// <summary>
			/// 根据招标项目具体情况约定
			/// </summary>
			public readonly static Field BID_PRICE_APPOINTMENT = new Field("BID_PRICE_APPOINTMENT", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "根据招标项目具体情况约定");
            /// <summary>
			/// 投标人延长投标有效期期限
			/// </summary>
			public readonly static Field VALID_PERIOD_NOT_EXCEEDING = new Field("VALID_PERIOD_NOT_EXCEEDING", "SL_CONSTRUCT_SUPER_REQUIRE", "投标人延长投标有效期期限");
            /// <summary>
			/// 保证金差额
			/// </summary>
			public readonly static Field MARGIN_AMOUNTDIFFERENCE = new Field("MARGIN_AMOUNTDIFFERENCE", "SL_CONSTRUCT_SUPER_REQUIRE", "保证金差额");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "SL_CONSTRUCT_SUPER_REQUIRE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGINNUMBER = new Field("MARGINNUMBER", "SL_CONSTRUCT_SUPER_REQUIRE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "SL_CONSTRUCT_SUPER_REQUIRE", "开户银行");
            /// <summary>
			/// 银行保函金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "SL_CONSTRUCT_SUPER_REQUIRE", "银行保函金额");
            /// <summary>
			/// 投标文件纸质份数
			/// </summary>
			public readonly static Field BID_DOC_NUM = new Field("BID_DOC_NUM", "SL_CONSTRUCT_SUPER_REQUIRE", "投标文件纸质份数");
            /// <summary>
			/// 投标技术文件其他要求
			/// </summary>
			public readonly static Field BID_DOC_OTHER_REQUIRE = new Field("BID_DOC_OTHER_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "投标技术文件其他要求");
            /// <summary>
			/// 推选中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "SL_CONSTRUCT_SUPER_REQUIRE", "推选中标候选人人数");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "SL_CONSTRUCT_SUPER_REQUIRE", "履约担保金额");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_PRICE_TYPE = new Field("PERFORM_PRICE_TYPE", "SL_CONSTRUCT_SUPER_REQUIRE", "履约担保形式");
            /// <summary>
			/// 需要补充的其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "需要补充的其他要求");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "SL_CONSTRUCT_SUPER_REQUIRE", "评标委员会人数");
            /// <summary>
			/// K值最小值
			/// </summary>
			public readonly static Field K_BEGIN_NUM = new Field("K_BEGIN_NUM", "SL_CONSTRUCT_SUPER_REQUIRE", "K值最小值");
            /// <summary>
			/// K值最大值
			/// </summary>
			public readonly static Field K_END_NUM = new Field("K_END_NUM", "SL_CONSTRUCT_SUPER_REQUIRE", "K值最大值");
            /// <summary>
			/// 质量管理认证体系满足招标文件的要求
			/// </summary>
			public readonly static Field QUALITY_CERTIFICATION_REQUIRE = new Field("QUALITY_CERTIFICATION_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "质量管理认证体系满足招标文件的要求");
            /// <summary>
			/// 财务要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "财务要求");
            /// <summary>
			/// 信誉要求
			/// </summary>
			public readonly static Field CREDIT_REQUIRE = new Field("CREDIT_REQUIRE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "信誉要求");
            /// <summary>
			/// 监理依据
			/// </summary>
			public readonly static Field SUPERVISION_BASIS = new Field("SUPERVISION_BASIS", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "监理依据");
            /// <summary>
			/// 委托人的权利
			/// </summary>
			public readonly static Field CLIENT_RIGHTS = new Field("CLIENT_RIGHTS", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "委托人的权利");
            /// <summary>
			/// 监理人的权利
			/// </summary>
			public readonly static Field SUPERVISOR_RIGHTS = new Field("SUPERVISOR_RIGHTS", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "监理人的权利");
            /// <summary>
			/// 委托人的义务
			/// </summary>
			public readonly static Field CLIENT_OBLIGATIONS = new Field("CLIENT_OBLIGATIONS", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "委托人的义务");
            /// <summary>
			/// 监理人的义务
			/// </summary>
			public readonly static Field SUPERVISOR_OBLIGATIONS = new Field("SUPERVISOR_OBLIGATIONS", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "监理人的义务");
            /// <summary>
			/// 监理服务酬金
			/// </summary>
			public readonly static Field SUPERVISION_SERVICE_FEE = new Field("SUPERVISION_SERVICE_FEE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "监理服务酬金");
            /// <summary>
			/// 违约责任
			/// </summary>
			public readonly static Field BREACH_RESPONSIBILITY = new Field("BREACH_RESPONSIBILITY", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "违约责任");
            /// <summary>
			/// 争议的解决
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "争议的解决");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER_CLAUSE = new Field("OTHER_CLAUSE", "SL_CONSTRUCT_SUPER_REQUIRE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_CONSTRUCT_SUPER_REQUIRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_CONSTRUCT_SUPER_REQUIRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_CONSTRUCT_SUPER_REQUIRE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_CONSTRUCT_SUPER_REQUIRE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_CONSTRUCT_SUPER_REQUIRE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_CONSTRUCT_SUPER_REQUIRE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_CONSTRUCT_SUPER_REQUIRE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_CONSTRUCT_SUPER_REQUIRE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_CONSTRUCT_SUPER_REQUIRE", "M_TM");
            /// <summary>
			/// 重要节点工期
			/// </summary>
			public readonly static Field IMPORTANT_LIMITE_TIME = new Field("IMPORTANT_LIMITE_TIME", "SL_CONSTRUCT_SUPER_REQUIRE", "重要节点工期");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_CONSTRUCT_SUPER_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_CONSTRUCT_SUPER_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_CONSTRUCT_SUPER_REQUIRE", "");
            /// <summary>
			/// 保证金差额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT_DIFFERENCE = new Field("MARGIN_AMOUNT_DIFFERENCE", "SL_CONSTRUCT_SUPER_REQUIRE", "保证金差额");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "SL_CONSTRUCT_SUPER_REQUIRE", "保证金账号");
        }
        #endregion
	}
}