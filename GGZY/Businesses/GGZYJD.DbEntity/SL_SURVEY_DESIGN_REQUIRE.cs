using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_SURVEY_DESIGN_REQUIRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_SURVEY_DESIGN_REQUIRE")]
    [Serializable]
    public partial class SL_SURVEY_DESIGN_REQUIRE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private decimal? _PROJECT_SCALE_MONEY;
		private decimal? _ALL_LIMIT_ITME;
		private string _PRICE_UNIT;
		private string _SURVEY_DESIGN_STAGE;
		private string _SURVEY_DESIGN_CONTENT;
		private string _ACHIEVEMENT;
		private string _SIMILAR_PROJECT;
		private string _BID_MANAGER_REQUIREMENT;
		private decimal? _SURVEY_DESIGN_PRICE;
		private string _IS_RECONNAISSANCE;
		private DateTime? _RECONNAISSANCE_TIME;
		private string _RECONNAISSANCE_ADDRESS;
		private string _IS_PREPARATORY_MEETING;
		private DateTime? _PREPARATORY_MEETING_TIME;
		private string _PREPARATORY_MEETING_ADDRESS;
		private string _VEHICLE;
		private string _NOTICE_MEDIA4;
		private decimal? _BID_SECTION;
		private decimal? _SOCIAL_SECURITY_MONTH;
		private DateTime? _SOCIAL_SECURITY_TIME;
		private string _OTHER_REQUIREMENTS;
		private decimal? _TENDER_PRICE_APPOINT;
		private string _TENDER_PRICE_CONTENT;
		private decimal? _VALID_PERIOD_NOT_EXCEEDING;
		private string _BID_DOC_OTHER_REQUIRE;
		private decimal? _MARGIN_AMOUNTDIFFERENCE;
		private string _MARGIN_NAME;
		private string _MARGINNUMBER;
		private string _MARGIN_BANK;
		private decimal? _WIN_CANDIDATE_NUM;
		private decimal? _EXPERT_NUM;
		private decimal? _K_BEGIN_NUM;
		private decimal? _K_END_NUM;
		private DateTime? _SIMILAR_PROJECT_TIME;
		private decimal? _SIMILAR_PROJECT_SCORE;
		private decimal? _MEET_REQUIRE_SCORE;
		private decimal? _SURVEY_EXPERICE_SCORE;
		private string _PROJECT_PROFILE;
		private string _SURVEY_DESIGN_PROGRAM;
		private string _IS_PROVIDE;
		private string _SERVICE_REQUIREMENTS;
		private string _SURVEY_REQUIREMENTS;
		private string _OTHER_REQUIRE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _OTHER_ADD_SCORE;
		private string _IMPORTANT_LIMITE_TIME;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _MARGIN_NUMBER;
		private decimal? _MARGIN_AMOUNT_DIFFERENCE;

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
		/// 勘察设计阶段
		/// </summary>
		public string SURVEY_DESIGN_STAGE
		{
			get{ return _SURVEY_DESIGN_STAGE; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_STAGE, _SURVEY_DESIGN_STAGE, value);
				this._SURVEY_DESIGN_STAGE = value;
			}
		}
		/// <summary>
		/// 勘察设计内容
		/// </summary>
		public string SURVEY_DESIGN_CONTENT
		{
			get{ return _SURVEY_DESIGN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_CONTENT, _SURVEY_DESIGN_CONTENT, value);
				this._SURVEY_DESIGN_CONTENT = value;
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
		/// 拟派出担任项目负责人要求
		/// </summary>
		public string BID_MANAGER_REQUIREMENT
		{
			get{ return _BID_MANAGER_REQUIREMENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_MANAGER_REQUIREMENT, _BID_MANAGER_REQUIREMENT, value);
				this._BID_MANAGER_REQUIREMENT = value;
			}
		}
		/// <summary>
		/// 工程勘察费/工程设计费/工程勘察设计费
		/// </summary>
		public decimal? SURVEY_DESIGN_PRICE
		{
			get{ return _SURVEY_DESIGN_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_PRICE, _SURVEY_DESIGN_PRICE, value);
				this._SURVEY_DESIGN_PRICE = value;
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
		/// 其他发布媒体
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
		/// 其他
		/// </summary>
		public string OTHER_REQUIREMENTS
		{
			get{ return _OTHER_REQUIREMENTS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_REQUIREMENTS, _OTHER_REQUIREMENTS, value);
				this._OTHER_REQUIREMENTS = value;
			}
		}
		/// <summary>
		/// 勘察设计费
		/// </summary>
		public decimal? TENDER_PRICE_APPOINT
		{
			get{ return _TENDER_PRICE_APPOINT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PRICE_APPOINT, _TENDER_PRICE_APPOINT, value);
				this._TENDER_PRICE_APPOINT = value;
			}
		}
		/// <summary>
		/// 投标报价包括
		/// </summary>
		public string TENDER_PRICE_CONTENT
		{
			get{ return _TENDER_PRICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PRICE_CONTENT, _TENDER_PRICE_CONTENT, value);
				this._TENDER_PRICE_CONTENT = value;
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
		/// 类似工程业绩每项得分
		/// </summary>
		public decimal? SIMILAR_PROJECT_SCORE
		{
			get{ return _SIMILAR_PROJECT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_SCORE, _SIMILAR_PROJECT_SCORE, value);
				this._SIMILAR_PROJECT_SCORE = value;
			}
		}
		/// <summary>
		/// 人员符合最低配备要求的基础分
		/// </summary>
		public decimal? MEET_REQUIRE_SCORE
		{
			get{ return _MEET_REQUIRE_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.MEET_REQUIRE_SCORE, _MEET_REQUIRE_SCORE, value);
				this._MEET_REQUIRE_SCORE = value;
			}
		}
		/// <summary>
		/// 具有类似工程项目负责人每项得分
		/// </summary>
		public decimal? SURVEY_EXPERICE_SCORE
		{
			get{ return _SURVEY_EXPERICE_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_EXPERICE_SCORE, _SURVEY_EXPERICE_SCORE, value);
				this._SURVEY_EXPERICE_SCORE = value;
			}
		}
		/// <summary>
		/// 项目概况
		/// </summary>
		public string PROJECT_PROFILE
		{
			get{ return _PROJECT_PROFILE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PROFILE, _PROJECT_PROFILE, value);
				this._PROJECT_PROFILE = value;
			}
		}
		/// <summary>
		/// 勘察设计任务书
		/// </summary>
		public string SURVEY_DESIGN_PROGRAM
		{
			get{ return _SURVEY_DESIGN_PROGRAM; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_PROGRAM, _SURVEY_DESIGN_PROGRAM, value);
				this._SURVEY_DESIGN_PROGRAM = value;
			}
		}
		/// <summary>
		/// 是否另册提供
		/// </summary>
		public string IS_PROVIDE
		{
			get{ return _IS_PROVIDE; }
			set
			{
				this.OnPropertyValueChange(_.IS_PROVIDE, _IS_PROVIDE, value);
				this._IS_PROVIDE = value;
			}
		}
		/// <summary>
		/// 勘察设计服务要求
		/// </summary>
		public string SERVICE_REQUIREMENTS
		{
			get{ return _SERVICE_REQUIREMENTS; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_REQUIREMENTS, _SERVICE_REQUIREMENTS, value);
				this._SERVICE_REQUIREMENTS = value;
			}
		}
		/// <summary>
		/// 工程勘察要求
		/// </summary>
		public string SURVEY_REQUIREMENTS
		{
			get{ return _SURVEY_REQUIREMENTS; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_REQUIREMENTS, _SURVEY_REQUIREMENTS, value);
				this._SURVEY_REQUIREMENTS = value;
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
		/// 其他
		/// </summary>
		public string OTHER_ADD_SCORE
		{
			get{ return _OTHER_ADD_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_ADD_SCORE, _OTHER_ADD_SCORE, value);
				this._OTHER_ADD_SCORE = value;
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
				_.SURVEY_DESIGN_STAGE,
				_.SURVEY_DESIGN_CONTENT,
				_.ACHIEVEMENT,
				_.SIMILAR_PROJECT,
				_.BID_MANAGER_REQUIREMENT,
				_.SURVEY_DESIGN_PRICE,
				_.IS_RECONNAISSANCE,
				_.RECONNAISSANCE_TIME,
				_.RECONNAISSANCE_ADDRESS,
				_.IS_PREPARATORY_MEETING,
				_.PREPARATORY_MEETING_TIME,
				_.PREPARATORY_MEETING_ADDRESS,
				_.VEHICLE,
				_.NOTICE_MEDIA4,
				_.BID_SECTION,
				_.SOCIAL_SECURITY_MONTH,
				_.SOCIAL_SECURITY_TIME,
				_.OTHER_REQUIREMENTS,
				_.TENDER_PRICE_APPOINT,
				_.TENDER_PRICE_CONTENT,
				_.VALID_PERIOD_NOT_EXCEEDING,
				_.BID_DOC_OTHER_REQUIRE,
				_.MARGIN_AMOUNTDIFFERENCE,
				_.MARGIN_NAME,
				_.MARGINNUMBER,
				_.MARGIN_BANK,
				_.WIN_CANDIDATE_NUM,
				_.EXPERT_NUM,
				_.K_BEGIN_NUM,
				_.K_END_NUM,
				_.SIMILAR_PROJECT_TIME,
				_.SIMILAR_PROJECT_SCORE,
				_.MEET_REQUIRE_SCORE,
				_.SURVEY_EXPERICE_SCORE,
				_.PROJECT_PROFILE,
				_.SURVEY_DESIGN_PROGRAM,
				_.IS_PROVIDE,
				_.SERVICE_REQUIREMENTS,
				_.SURVEY_REQUIREMENTS,
				_.OTHER_REQUIRE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.OTHER_ADD_SCORE,
				_.IMPORTANT_LIMITE_TIME,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.MARGIN_NUMBER,
				_.MARGIN_AMOUNT_DIFFERENCE,
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
				this._SURVEY_DESIGN_STAGE,
				this._SURVEY_DESIGN_CONTENT,
				this._ACHIEVEMENT,
				this._SIMILAR_PROJECT,
				this._BID_MANAGER_REQUIREMENT,
				this._SURVEY_DESIGN_PRICE,
				this._IS_RECONNAISSANCE,
				this._RECONNAISSANCE_TIME,
				this._RECONNAISSANCE_ADDRESS,
				this._IS_PREPARATORY_MEETING,
				this._PREPARATORY_MEETING_TIME,
				this._PREPARATORY_MEETING_ADDRESS,
				this._VEHICLE,
				this._NOTICE_MEDIA4,
				this._BID_SECTION,
				this._SOCIAL_SECURITY_MONTH,
				this._SOCIAL_SECURITY_TIME,
				this._OTHER_REQUIREMENTS,
				this._TENDER_PRICE_APPOINT,
				this._TENDER_PRICE_CONTENT,
				this._VALID_PERIOD_NOT_EXCEEDING,
				this._BID_DOC_OTHER_REQUIRE,
				this._MARGIN_AMOUNTDIFFERENCE,
				this._MARGIN_NAME,
				this._MARGINNUMBER,
				this._MARGIN_BANK,
				this._WIN_CANDIDATE_NUM,
				this._EXPERT_NUM,
				this._K_BEGIN_NUM,
				this._K_END_NUM,
				this._SIMILAR_PROJECT_TIME,
				this._SIMILAR_PROJECT_SCORE,
				this._MEET_REQUIRE_SCORE,
				this._SURVEY_EXPERICE_SCORE,
				this._PROJECT_PROFILE,
				this._SURVEY_DESIGN_PROGRAM,
				this._IS_PROVIDE,
				this._SERVICE_REQUIREMENTS,
				this._SURVEY_REQUIREMENTS,
				this._OTHER_REQUIRE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._OTHER_ADD_SCORE,
				this._IMPORTANT_LIMITE_TIME,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._MARGIN_NUMBER,
				this._MARGIN_AMOUNT_DIFFERENCE,
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
			public readonly static Field All = new Field("*", "SL_SURVEY_DESIGN_REQUIRE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_SURVEY_DESIGN_REQUIRE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_SURVEY_DESIGN_REQUIRE", "标段（包）编号");
            /// <summary>
			/// 工程总投资
			/// </summary>
			public readonly static Field PROJECT_SCALE_MONEY = new Field("PROJECT_SCALE_MONEY", "SL_SURVEY_DESIGN_REQUIRE", "工程总投资");
            /// <summary>
			/// 总工期
			/// </summary>
			public readonly static Field ALL_LIMIT_ITME = new Field("ALL_LIMIT_ITME", "SL_SURVEY_DESIGN_REQUIRE", "总工期");
            /// <summary>
			/// 工程总投资金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "SL_SURVEY_DESIGN_REQUIRE", "工程总投资金额单位");
            /// <summary>
			/// 勘察设计阶段
			/// </summary>
			public readonly static Field SURVEY_DESIGN_STAGE = new Field("SURVEY_DESIGN_STAGE", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "勘察设计阶段");
            /// <summary>
			/// 勘察设计内容
			/// </summary>
			public readonly static Field SURVEY_DESIGN_CONTENT = new Field("SURVEY_DESIGN_CONTENT", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "勘察设计内容");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT = new Field("ACHIEVEMENT", "SL_SURVEY_DESIGN_REQUIRE", "业绩要求");
            /// <summary>
			/// 类似项目
			/// </summary>
			public readonly static Field SIMILAR_PROJECT = new Field("SIMILAR_PROJECT", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "类似项目");
            /// <summary>
			/// 拟派出担任项目负责人要求
			/// </summary>
			public readonly static Field BID_MANAGER_REQUIREMENT = new Field("BID_MANAGER_REQUIREMENT", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "拟派出担任项目负责人要求");
            /// <summary>
			/// 工程勘察费/工程设计费/工程勘察设计费
			/// </summary>
			public readonly static Field SURVEY_DESIGN_PRICE = new Field("SURVEY_DESIGN_PRICE", "SL_SURVEY_DESIGN_REQUIRE", "工程勘察费/工程设计费/工程勘察设计费");
            /// <summary>
			/// 是否踏勘现场
			/// </summary>
			public readonly static Field IS_RECONNAISSANCE = new Field("IS_RECONNAISSANCE", "SL_SURVEY_DESIGN_REQUIRE", "是否踏勘现场");
            /// <summary>
			/// 踏勘时间
			/// </summary>
			public readonly static Field RECONNAISSANCE_TIME = new Field("RECONNAISSANCE_TIME", "SL_SURVEY_DESIGN_REQUIRE", "踏勘时间");
            /// <summary>
			/// 踏勘地点
			/// </summary>
			public readonly static Field RECONNAISSANCE_ADDRESS = new Field("RECONNAISSANCE_ADDRESS", "SL_SURVEY_DESIGN_REQUIRE", "踏勘地点");
            /// <summary>
			/// 是否召开投标预备会
			/// </summary>
			public readonly static Field IS_PREPARATORY_MEETING = new Field("IS_PREPARATORY_MEETING", "SL_SURVEY_DESIGN_REQUIRE", "是否召开投标预备会");
            /// <summary>
			/// 投标预备会召开时间
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_TIME = new Field("PREPARATORY_MEETING_TIME", "SL_SURVEY_DESIGN_REQUIRE", "投标预备会召开时间");
            /// <summary>
			/// 投标预备会召开地点
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_ADDRESS = new Field("PREPARATORY_MEETING_ADDRESS", "SL_SURVEY_DESIGN_REQUIRE", "投标预备会召开地点");
            /// <summary>
			/// 参加使用交通工具
			/// </summary>
			public readonly static Field VEHICLE = new Field("VEHICLE", "SL_SURVEY_DESIGN_REQUIRE", "参加使用交通工具");
            /// <summary>
			/// 其他发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA4 = new Field("NOTICE_MEDIA4", "SL_SURVEY_DESIGN_REQUIRE", "其他发布媒体");
            /// <summary>
			/// 标段（包）个数
			/// </summary>
			public readonly static Field BID_SECTION = new Field("BID_SECTION", "SL_SURVEY_DESIGN_REQUIRE", "标段（包）个数");
            /// <summary>
			/// 提供近几个月的社保缴纳凭证
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_MONTH = new Field("SOCIAL_SECURITY_MONTH", "SL_SURVEY_DESIGN_REQUIRE", "提供近几个月的社保缴纳凭证");
            /// <summary>
			/// 社保缴纳凭证缴纳起始
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_TIME = new Field("SOCIAL_SECURITY_TIME", "SL_SURVEY_DESIGN_REQUIRE", "社保缴纳凭证缴纳起始");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER_REQUIREMENTS = new Field("OTHER_REQUIREMENTS", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 勘察设计费
			/// </summary>
			public readonly static Field TENDER_PRICE_APPOINT = new Field("TENDER_PRICE_APPOINT", "SL_SURVEY_DESIGN_REQUIRE", "勘察设计费");
            /// <summary>
			/// 投标报价包括
			/// </summary>
			public readonly static Field TENDER_PRICE_CONTENT = new Field("TENDER_PRICE_CONTENT", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "投标报价包括");
            /// <summary>
			/// 投标人延长投标有效期期限
			/// </summary>
			public readonly static Field VALID_PERIOD_NOT_EXCEEDING = new Field("VALID_PERIOD_NOT_EXCEEDING", "SL_SURVEY_DESIGN_REQUIRE", "投标人延长投标有效期期限");
            /// <summary>
			/// 投标技术文件其他要求
			/// </summary>
			public readonly static Field BID_DOC_OTHER_REQUIRE = new Field("BID_DOC_OTHER_REQUIRE", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "投标技术文件其他要求");
            /// <summary>
			/// 保证金差额
			/// </summary>
			public readonly static Field MARGIN_AMOUNTDIFFERENCE = new Field("MARGIN_AMOUNTDIFFERENCE", "SL_SURVEY_DESIGN_REQUIRE", "保证金差额");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "SL_SURVEY_DESIGN_REQUIRE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGINNUMBER = new Field("MARGINNUMBER", "SL_SURVEY_DESIGN_REQUIRE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "SL_SURVEY_DESIGN_REQUIRE", "开户银行");
            /// <summary>
			/// 推选中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "SL_SURVEY_DESIGN_REQUIRE", "推选中标候选人人数");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "SL_SURVEY_DESIGN_REQUIRE", "评标委员会人数");
            /// <summary>
			/// K值最小值
			/// </summary>
			public readonly static Field K_BEGIN_NUM = new Field("K_BEGIN_NUM", "SL_SURVEY_DESIGN_REQUIRE", "K值最小值");
            /// <summary>
			/// K值最大值
			/// </summary>
			public readonly static Field K_END_NUM = new Field("K_END_NUM", "SL_SURVEY_DESIGN_REQUIRE", "K值最大值");
            /// <summary>
			/// 承担过类似本工程项目的近10年时间
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_TIME = new Field("SIMILAR_PROJECT_TIME", "SL_SURVEY_DESIGN_REQUIRE", "承担过类似本工程项目的近10年时间");
            /// <summary>
			/// 类似工程业绩每项得分
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_SCORE = new Field("SIMILAR_PROJECT_SCORE", "SL_SURVEY_DESIGN_REQUIRE", "类似工程业绩每项得分");
            /// <summary>
			/// 人员符合最低配备要求的基础分
			/// </summary>
			public readonly static Field MEET_REQUIRE_SCORE = new Field("MEET_REQUIRE_SCORE", "SL_SURVEY_DESIGN_REQUIRE", "人员符合最低配备要求的基础分");
            /// <summary>
			/// 具有类似工程项目负责人每项得分
			/// </summary>
			public readonly static Field SURVEY_EXPERICE_SCORE = new Field("SURVEY_EXPERICE_SCORE", "SL_SURVEY_DESIGN_REQUIRE", "具有类似工程项目负责人每项得分");
            /// <summary>
			/// 项目概况
			/// </summary>
			public readonly static Field PROJECT_PROFILE = new Field("PROJECT_PROFILE", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "项目概况");
            /// <summary>
			/// 勘察设计任务书
			/// </summary>
			public readonly static Field SURVEY_DESIGN_PROGRAM = new Field("SURVEY_DESIGN_PROGRAM", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "勘察设计任务书");
            /// <summary>
			/// 是否另册提供
			/// </summary>
			public readonly static Field IS_PROVIDE = new Field("IS_PROVIDE", "SL_SURVEY_DESIGN_REQUIRE", "是否另册提供");
            /// <summary>
			/// 勘察设计服务要求
			/// </summary>
			public readonly static Field SERVICE_REQUIREMENTS = new Field("SERVICE_REQUIREMENTS", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "勘察设计服务要求");
            /// <summary>
			/// 工程勘察要求
			/// </summary>
			public readonly static Field SURVEY_REQUIREMENTS = new Field("SURVEY_REQUIREMENTS", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "工程勘察要求");
            /// <summary>
			/// 需要补充的其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "需要补充的其他要求");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_SURVEY_DESIGN_REQUIRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_SURVEY_DESIGN_REQUIRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_SURVEY_DESIGN_REQUIRE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_SURVEY_DESIGN_REQUIRE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_SURVEY_DESIGN_REQUIRE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_SURVEY_DESIGN_REQUIRE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_SURVEY_DESIGN_REQUIRE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_SURVEY_DESIGN_REQUIRE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_SURVEY_DESIGN_REQUIRE", "M_TM");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER_ADD_SCORE = new Field("OTHER_ADD_SCORE", "SL_SURVEY_DESIGN_REQUIRE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 重要节点工期
			/// </summary>
			public readonly static Field IMPORTANT_LIMITE_TIME = new Field("IMPORTANT_LIMITE_TIME", "SL_SURVEY_DESIGN_REQUIRE", "重要节点工期");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_SURVEY_DESIGN_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_SURVEY_DESIGN_REQUIRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_SURVEY_DESIGN_REQUIRE", "");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "SL_SURVEY_DESIGN_REQUIRE", "保证金账号");
            /// <summary>
			/// 保证金差额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT_DIFFERENCE = new Field("MARGIN_AMOUNT_DIFFERENCE", "SL_SURVEY_DESIGN_REQUIRE", "保证金差额");
        }
        #endregion
	}
}