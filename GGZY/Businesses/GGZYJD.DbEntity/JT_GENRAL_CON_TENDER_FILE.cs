using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_GENRAL_CON_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_GENRAL_CON_TENDER_FILE")]
    [Serializable]
    public partial class JT_GENRAL_CON_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private string _LIMITE_TIME_UNIT;
		private string _FIRST_ENVELOPES_CONFIRM;
		private decimal? _WIN_BID_NUMBER;
		private string _QUALI_REQUIRE1;
		private string _QUALI_REQUIRE2;
		private DateTime? _REPUTATION_TIME1;
		private DateTime? _REPUTATION_TIME2;
		private string _MANAGER_TITLE;
		private string _MANAGER_TITLE_LEVEL;
		private string _CONSTRUCTOR_MAJOR;
		private string _CONSTRUCTOR_MAJOR_LEVEL;
		private decimal? _MANAGER_AGE;
		private string _TECH_TITLE;
		private string _TECH_TITLE_LEVEL;
		private decimal? _TECH_AGE;
		private string _DELAY_PENALTY;
		private string _LIQUID_DAMAGE_RATE;
		private string _MINIMUM_LIMIT;
		private decimal? _DEFECT_LIABILITY_PERIOD;
		private DateTime? _BEGIN_ALL_DATE;
		private DateTime? _END_DATE;
		private string _FUND_IMPLEMENTATION;
		private decimal? _TOTAL_SECTION_NUMBER;
		private decimal? _TENDERER_BID_SECTION;
		private decimal? _CONSTRUCTION_BUDGET_PRICE;
		private decimal? _CONTRACT_PRICE;
		private string _CONTRACT_SEGMENT;
		private string _TENDER_NUMBER;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private DateTime? _MARGIN_TIME;
		private string _INTEREST_MODE;
		private decimal? _INTEREST_CALCULATION_CYCLE;
		private decimal? _MONEY_RATE;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _EVALUATING_METHOD_STANDARD;
		private string _MATERIAL_PRICE_ADJUSTED;
		private string _BASE_PRICE_CITY;
		private string _RELEASE_PRICE_CITY;
		private string _NO_RELEASE_PRICE_CITY;
		private decimal? _DEFECT_LIABILITY_PERIOD1;
		private string _OPEN_BID_REQURE_CHOOSE;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_PHONE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private string _QUALITY_REQUIRE1;
		private string _QUALITY_REQUIRE2;
		private decimal? _SYNDICATED_NUMBER;
		private DateTime? _QUESTION_TIME;
		private string _BIDDER_NOTICE_TIME;
		private string _SUBCONTRACT;
		private DateTime? _TENDER_NOTICE_TIME;
		private string _MODIFICATION_TIME;
		private string _FINANCIAL_YEAR_REQUIRE;
		private string _SIMILAR_PROJECT_YEAR_REQUIRE;
		private DateTime? _LITIGATION_REQUIRE;
		private DateTime? _BRIBERY_RECORD_YEAR;
		private decimal? _COPY_NUMBER;
		private string _DECRYPTION_TYPE;
		private string _SEC_ENVELOPES_OPEN;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_LIBRARY;
		private string _K_NUMBER;
		private decimal? _HIGHEST_PRICE_DATE;
		private decimal? _LOWEST_PRICE_DATE;
		private decimal? _PREMIUM_RATE1;
		private decimal? _PREMIUM_RATE2;
		private decimal? _INSURED_AMOUNT;
		private string _DISPUTE_DEAL_METHOD;
		private string _ARB_COMMISSION_NAME;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _QUALIFICATION_REQUIRE;
		private string _OTHER_QUALIFICATION_REQUIRE;
		private string _EQUIPMENT_REQUIRE;
		private decimal? _BID_EVALUATION;
		private decimal? _CREDIT;
		private decimal? _CREDIT_RATING_AA_YEAR;
		private decimal? _CREDIT_RATING_A_YEAR;
		private decimal? _CREDIT_RATING_B_YEAR;
		private decimal? _CREDIT_RATING_W_YEAR;
		private decimal? _CREDIT_RATING_BW_YEAR;
		private decimal? _CREDIT_RATING_CD_YEAR;
		private decimal? _CREDIT_RATING_AAAW_YEAR;
		private decimal? _CREDIT_RATING_AAA_YEAR;
		private string _CHANGE;
		private string _GENERAL_CONTRACT;
		private string _SUPERVISOR;
		private string _CONTRACTOR;
		private string _MATERIAL_PROJECT_EQUIPMENT;
		private string _CONSTRUCT_EQUIP_TEMP_FACIL;
		private string _TRANSPORTATION;
		private string _SAFE_SECURITY_ENVIRON_PRO;
		private string _SCHEDULE;
		private string _COMMENCEMENT_COMPLETION;
		private string _PROJECT_QUALITY;
		private string _MODIFICATION;
		private string _PRICE_REGULATION;
		private string _MEASUREMENT_PAYMENT;
		private string _COMPLETION_ACCEPTANCE;
		private string _INSURANCE;
		private string _BREACH_CONTRACT;
		private string _DISPUTE_RESOLUTION;
		private string _LAND_PROTECTION;
		private string _DELIVERY_TIME_LIMIT;
		private string _OTHER_CONVENTIONS;
		private string _SUPPLY_ITEM;
		private string _BILL_OF_QUANTITIES;
		private string _DRAWING;
		private string _TECHNICAL_SPECIFICATIONS;
		private string _SUPPLY_TECHNICAL_STANDARD;
		private string _ENCLOSURE1;
		private string _ENCLOSURE2;
		private string _ENCLOSURE3;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _E1_NUMBER;
		private string _E2_NUMBER;
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
		/// 工期单位
		/// </summary>
		public string LIMITE_TIME_UNIT
		{
			get{ return _LIMITE_TIME_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_TIME_UNIT, _LIMITE_TIME_UNIT, value);
				this._LIMITE_TIME_UNIT = value;
			}
		}
		/// <summary>
		/// 第一信封随机确认方式
		/// </summary>
		public string FIRST_ENVELOPES_CONFIRM
		{
			get{ return _FIRST_ENVELOPES_CONFIRM; }
			set
			{
				this.OnPropertyValueChange(_.FIRST_ENVELOPES_CONFIRM, _FIRST_ENVELOPES_CONFIRM, value);
				this._FIRST_ENVELOPES_CONFIRM = value;
			}
		}
		/// <summary>
		/// 中标候选人个数
		/// </summary>
		public decimal? WIN_BID_NUMBER
		{
			get{ return _WIN_BID_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_NUMBER, _WIN_BID_NUMBER, value);
				this._WIN_BID_NUMBER = value;
			}
		}
		/// <summary>
		/// 是否须施工资质企业名录
		/// </summary>
		public string QUALI_REQUIRE1
		{
			get{ return _QUALI_REQUIRE1; }
			set
			{
				this.OnPropertyValueChange(_.QUALI_REQUIRE1, _QUALI_REQUIRE1, value);
				this._QUALI_REQUIRE1 = value;
			}
		}
		/// <summary>
		/// 是否须提供企业资质信息
		/// </summary>
		public string QUALI_REQUIRE2
		{
			get{ return _QUALI_REQUIRE2; }
			set
			{
				this.OnPropertyValueChange(_.QUALI_REQUIRE2, _QUALI_REQUIRE2, value);
				this._QUALI_REQUIRE2 = value;
			}
		}
		/// <summary>
		/// 未发生安全事故的时间要求
		/// </summary>
		public DateTime? REPUTATION_TIME1
		{
			get{ return _REPUTATION_TIME1; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_TIME1, _REPUTATION_TIME1, value);
				this._REPUTATION_TIME1 = value;
			}
		}
		/// <summary>
		/// 未出现不良记录时间要求
		/// </summary>
		public DateTime? REPUTATION_TIME2
		{
			get{ return _REPUTATION_TIME2; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_TIME2, _REPUTATION_TIME2, value);
				this._REPUTATION_TIME2 = value;
			}
		}
		/// <summary>
		/// 项目经理职称专业
		/// </summary>
		public string MANAGER_TITLE
		{
			get{ return _MANAGER_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_TITLE, _MANAGER_TITLE, value);
				this._MANAGER_TITLE = value;
			}
		}
		/// <summary>
		/// 项目经理职称等级
		/// </summary>
		public string MANAGER_TITLE_LEVEL
		{
			get{ return _MANAGER_TITLE_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_TITLE_LEVEL, _MANAGER_TITLE_LEVEL, value);
				this._MANAGER_TITLE_LEVEL = value;
			}
		}
		/// <summary>
		/// 注册建造师专业名称
		/// </summary>
		public string CONSTRUCTOR_MAJOR
		{
			get{ return _CONSTRUCTOR_MAJOR; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTOR_MAJOR, _CONSTRUCTOR_MAJOR, value);
				this._CONSTRUCTOR_MAJOR = value;
			}
		}
		/// <summary>
		/// 注册建造师等级
		/// </summary>
		public string CONSTRUCTOR_MAJOR_LEVEL
		{
			get{ return _CONSTRUCTOR_MAJOR_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTOR_MAJOR_LEVEL, _CONSTRUCTOR_MAJOR_LEVEL, value);
				this._CONSTRUCTOR_MAJOR_LEVEL = value;
			}
		}
		/// <summary>
		/// 项目经理年龄
		/// </summary>
		public decimal? MANAGER_AGE
		{
			get{ return _MANAGER_AGE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_AGE, _MANAGER_AGE, value);
				this._MANAGER_AGE = value;
			}
		}
		/// <summary>
		/// 技术负责人职称专业
		/// </summary>
		public string TECH_TITLE
		{
			get{ return _TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_TITLE, _TECH_TITLE, value);
				this._TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 技术负责人职称等级
		/// </summary>
		public string TECH_TITLE_LEVEL
		{
			get{ return _TECH_TITLE_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.TECH_TITLE_LEVEL, _TECH_TITLE_LEVEL, value);
				this._TECH_TITLE_LEVEL = value;
			}
		}
		/// <summary>
		/// 技术负责人年龄
		/// </summary>
		public decimal? TECH_AGE
		{
			get{ return _TECH_AGE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_AGE, _TECH_AGE, value);
				this._TECH_AGE = value;
			}
		}
		/// <summary>
		/// 工期延误的违约金
		/// </summary>
		public string DELAY_PENALTY
		{
			get{ return _DELAY_PENALTY; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_PENALTY, _DELAY_PENALTY, value);
				this._DELAY_PENALTY = value;
			}
		}
		/// <summary>
		/// 逾期付款违约金的利率
		/// </summary>
		public string LIQUID_DAMAGE_RATE
		{
			get{ return _LIQUID_DAMAGE_RATE; }
			set
			{
				this.OnPropertyValueChange(_.LIQUID_DAMAGE_RATE, _LIQUID_DAMAGE_RATE, value);
				this._LIQUID_DAMAGE_RATE = value;
			}
		}
		/// <summary>
		/// 进度付款证书最低限额
		/// </summary>
		public string MINIMUM_LIMIT
		{
			get{ return _MINIMUM_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_LIMIT, _MINIMUM_LIMIT, value);
				this._MINIMUM_LIMIT = value;
			}
		}
		/// <summary>
		/// 缺陷责任期
		/// </summary>
		public decimal? DEFECT_LIABILITY_PERIOD
		{
			get{ return _DEFECT_LIABILITY_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_LIABILITY_PERIOD, _DEFECT_LIABILITY_PERIOD, value);
				this._DEFECT_LIABILITY_PERIOD = value;
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
		/// 项目总标段个数
		/// </summary>
		public decimal? TOTAL_SECTION_NUMBER
		{
			get{ return _TOTAL_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_SECTION_NUMBER, _TOTAL_SECTION_NUMBER, value);
				this._TOTAL_SECTION_NUMBER = value;
			}
		}
		/// <summary>
		/// 本次招标标段个数
		/// </summary>
		public decimal? TENDERER_BID_SECTION
		{
			get{ return _TENDERER_BID_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BID_SECTION, _TENDERER_BID_SECTION, value);
				this._TENDERER_BID_SECTION = value;
			}
		}
		/// <summary>
		/// 工程预算审核价
		/// </summary>
		public decimal? CONSTRUCTION_BUDGET_PRICE
		{
			get{ return _CONSTRUCTION_BUDGET_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_BUDGET_PRICE, _CONSTRUCTION_BUDGET_PRICE, value);
				this._CONSTRUCTION_BUDGET_PRICE = value;
			}
		}
		/// <summary>
		/// 发包价
		/// </summary>
		public decimal? CONTRACT_PRICE
		{
			get{ return _CONTRACT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PRICE, _CONTRACT_PRICE, value);
				this._CONTRACT_PRICE = value;
			}
		}
		/// <summary>
		/// 每个投标人最多投标标段数
		/// </summary>
		public string CONTRACT_SEGMENT
		{
			get{ return _CONTRACT_SEGMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SEGMENT, _CONTRACT_SEGMENT, value);
				this._CONTRACT_SEGMENT = value;
			}
		}
		/// <summary>
		/// 每个投标人最多中标标段数
		/// </summary>
		public string TENDER_NUMBER
		{
			get{ return _TENDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NUMBER, _TENDER_NUMBER, value);
				this._TENDER_NUMBER = value;
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
		/// 采用电汇形式保证金计息方式
		/// </summary>
		public string INTEREST_MODE
		{
			get{ return _INTEREST_MODE; }
			set
			{
				this.OnPropertyValueChange(_.INTEREST_MODE, _INTEREST_MODE, value);
				this._INTEREST_MODE = value;
			}
		}
		/// <summary>
		/// 保证金利息计算周期
		/// </summary>
		public decimal? INTEREST_CALCULATION_CYCLE
		{
			get{ return _INTEREST_CALCULATION_CYCLE; }
			set
			{
				this.OnPropertyValueChange(_.INTEREST_CALCULATION_CYCLE, _INTEREST_CALCULATION_CYCLE, value);
				this._INTEREST_CALCULATION_CYCLE = value;
			}
		}
		/// <summary>
		/// 年化利率
		/// </summary>
		public decimal? MONEY_RATE
		{
			get{ return _MONEY_RATE; }
			set
			{
				this.OnPropertyValueChange(_.MONEY_RATE, _MONEY_RATE, value);
				this._MONEY_RATE = value;
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
		/// 材料价格是否调整
		/// </summary>
		public string MATERIAL_PRICE_ADJUSTED
		{
			get{ return _MATERIAL_PRICE_ADJUSTED; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL_PRICE_ADJUSTED, _MATERIAL_PRICE_ADJUSTED, value);
				this._MATERIAL_PRICE_ADJUSTED = value;
			}
		}
		/// <summary>
		/// 基期价格参考城市
		/// </summary>
		public string BASE_PRICE_CITY
		{
			get{ return _BASE_PRICE_CITY; }
			set
			{
				this.OnPropertyValueChange(_.BASE_PRICE_CITY, _BASE_PRICE_CITY, value);
				this._BASE_PRICE_CITY = value;
			}
		}
		/// <summary>
		/// 发布价参考城市
		/// </summary>
		public string RELEASE_PRICE_CITY
		{
			get{ return _RELEASE_PRICE_CITY; }
			set
			{
				this.OnPropertyValueChange(_.RELEASE_PRICE_CITY, _RELEASE_PRICE_CITY, value);
				this._RELEASE_PRICE_CITY = value;
			}
		}
		/// <summary>
		/// 未涉及材料发布价参考城市
		/// </summary>
		public string NO_RELEASE_PRICE_CITY
		{
			get{ return _NO_RELEASE_PRICE_CITY; }
			set
			{
				this.OnPropertyValueChange(_.NO_RELEASE_PRICE_CITY, _NO_RELEASE_PRICE_CITY, value);
				this._NO_RELEASE_PRICE_CITY = value;
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
		/// 是否需要人员到场
		/// </summary>
		public string OPEN_BID_REQURE_CHOOSE
		{
			get{ return _OPEN_BID_REQURE_CHOOSE; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_BID_REQURE_CHOOSE, _OPEN_BID_REQURE_CHOOSE, value);
				this._OPEN_BID_REQURE_CHOOSE = value;
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
		public string SUPERVISE_DEPT_PHONE
		{
			get{ return _SUPERVISE_DEPT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_PHONE, _SUPERVISE_DEPT_PHONE, value);
				this._SUPERVISE_DEPT_PHONE = value;
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
		/// 交工验收质量要求
		/// </summary>
		public string QUALITY_REQUIRE1
		{
			get{ return _QUALITY_REQUIRE1; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_REQUIRE1, _QUALITY_REQUIRE1, value);
				this._QUALITY_REQUIRE1 = value;
			}
		}
		/// <summary>
		/// 竣工验收质量要求
		/// </summary>
		public string QUALITY_REQUIRE2
		{
			get{ return _QUALITY_REQUIRE2; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_REQUIRE2, _QUALITY_REQUIRE2, value);
				this._QUALITY_REQUIRE2 = value;
			}
		}
		/// <summary>
		/// 联合体成员数量要求
		/// </summary>
		public decimal? SYNDICATED_NUMBER
		{
			get{ return _SYNDICATED_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATED_NUMBER, _SYNDICATED_NUMBER, value);
				this._SYNDICATED_NUMBER = value;
			}
		}
		/// <summary>
		/// 投标人提出问题的截止时间
		/// </summary>
		public DateTime? QUESTION_TIME
		{
			get{ return _QUESTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.QUESTION_TIME, _QUESTION_TIME, value);
				this._QUESTION_TIME = value;
			}
		}
		/// <summary>
		/// 投标人要求澄清招标文件的截止时间
		/// </summary>
		public string BIDDER_NOTICE_TIME
		{
			get{ return _BIDDER_NOTICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NOTICE_TIME, _BIDDER_NOTICE_TIME, value);
				this._BIDDER_NOTICE_TIME = value;
			}
		}
		/// <summary>
		/// 是否允许分包
		/// </summary>
		public string SUBCONTRACT
		{
			get{ return _SUBCONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.SUBCONTRACT, _SUBCONTRACT, value);
				this._SUBCONTRACT = value;
			}
		}
		/// <summary>
		/// 招标人书面澄清的时间
		/// </summary>
		public DateTime? TENDER_NOTICE_TIME
		{
			get{ return _TENDER_NOTICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NOTICE_TIME, _TENDER_NOTICE_TIME, value);
				this._TENDER_NOTICE_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件修改截止时间
		/// </summary>
		public string MODIFICATION_TIME
		{
			get{ return _MODIFICATION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFICATION_TIME, _MODIFICATION_TIME, value);
				this._MODIFICATION_TIME = value;
			}
		}
		/// <summary>
		/// 近年财务状况的年份要求
		/// </summary>
		public string FINANCIAL_YEAR_REQUIRE
		{
			get{ return _FINANCIAL_YEAR_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_YEAR_REQUIRE, _FINANCIAL_YEAR_REQUIRE, value);
				this._FINANCIAL_YEAR_REQUIRE = value;
			}
		}
		/// <summary>
		/// 近年完成的类似项目的年份要求
		/// </summary>
		public string SIMILAR_PROJECT_YEAR_REQUIRE
		{
			get{ return _SIMILAR_PROJECT_YEAR_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_YEAR_REQUIRE, _SIMILAR_PROJECT_YEAR_REQUIRE, value);
				this._SIMILAR_PROJECT_YEAR_REQUIRE = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况的起始年份要求
		/// </summary>
		public DateTime? LITIGATION_REQUIRE
		{
			get{ return _LITIGATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_REQUIRE, _LITIGATION_REQUIRE, value);
				this._LITIGATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 近年发生的行贿犯罪记录查询的年份要求
		/// </summary>
		public DateTime? BRIBERY_RECORD_YEAR
		{
			get{ return _BRIBERY_RECORD_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.BRIBERY_RECORD_YEAR, _BRIBERY_RECORD_YEAR, value);
				this._BRIBERY_RECORD_YEAR = value;
			}
		}
		/// <summary>
		/// 投标文件副本份数
		/// </summary>
		public decimal? COPY_NUMBER
		{
			get{ return _COPY_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.COPY_NUMBER, _COPY_NUMBER, value);
				this._COPY_NUMBER = value;
			}
		}
		/// <summary>
		/// 投标文件解密方式
		/// </summary>
		public string DECRYPTION_TYPE
		{
			get{ return _DECRYPTION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.DECRYPTION_TYPE, _DECRYPTION_TYPE, value);
				this._DECRYPTION_TYPE = value;
			}
		}
		/// <summary>
		/// 第二封信开标程序
		/// </summary>
		public string SEC_ENVELOPES_OPEN
		{
			get{ return _SEC_ENVELOPES_OPEN; }
			set
			{
				this.OnPropertyValueChange(_.SEC_ENVELOPES_OPEN, _SEC_ENVELOPES_OPEN, value);
				this._SEC_ENVELOPES_OPEN = value;
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
		/// 评标专家确定方式
		/// </summary>
		public string EXPERT_LIBRARY
		{
			get{ return _EXPERT_LIBRARY; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_LIBRARY, _EXPERT_LIBRARY, value);
				this._EXPERT_LIBRARY = value;
			}
		}
		/// <summary>
		/// K值选定
		/// </summary>
		public string K_NUMBER
		{
			get{ return _K_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.K_NUMBER, _K_NUMBER, value);
				this._K_NUMBER = value;
			}
		}
		/// <summary>
		/// 最高限价公布截止时间
		/// </summary>
		public decimal? HIGHEST_PRICE_DATE
		{
			get{ return _HIGHEST_PRICE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.HIGHEST_PRICE_DATE, _HIGHEST_PRICE_DATE, value);
				this._HIGHEST_PRICE_DATE = value;
			}
		}
		/// <summary>
		/// 进入评标基准价计算的下限发布截止时间
		/// </summary>
		public decimal? LOWEST_PRICE_DATE
		{
			get{ return _LOWEST_PRICE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.LOWEST_PRICE_DATE, _LOWEST_PRICE_DATE, value);
				this._LOWEST_PRICE_DATE = value;
			}
		}
		/// <summary>
		/// 工程保险费率
		/// </summary>
		public decimal? PREMIUM_RATE1
		{
			get{ return _PREMIUM_RATE1; }
			set
			{
				this.OnPropertyValueChange(_.PREMIUM_RATE1, _PREMIUM_RATE1, value);
				this._PREMIUM_RATE1 = value;
			}
		}
		/// <summary>
		/// 第三方责任保险费率
		/// </summary>
		public decimal? PREMIUM_RATE2
		{
			get{ return _PREMIUM_RATE2; }
			set
			{
				this.OnPropertyValueChange(_.PREMIUM_RATE2, _PREMIUM_RATE2, value);
				this._PREMIUM_RATE2 = value;
			}
		}
		/// <summary>
		/// 最低投保金额
		/// </summary>
		public decimal? INSURED_AMOUNT
		{
			get{ return _INSURED_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.INSURED_AMOUNT, _INSURED_AMOUNT, value);
				this._INSURED_AMOUNT = value;
			}
		}
		/// <summary>
		/// 争议的最终解决方式
		/// </summary>
		public string DISPUTE_DEAL_METHOD
		{
			get{ return _DISPUTE_DEAL_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.DISPUTE_DEAL_METHOD, _DISPUTE_DEAL_METHOD, value);
				this._DISPUTE_DEAL_METHOD = value;
			}
		}
		/// <summary>
		/// 仲裁委员会名称
		/// </summary>
		public string ARB_COMMISSION_NAME
		{
			get{ return _ARB_COMMISSION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ARB_COMMISSION_NAME, _ARB_COMMISSION_NAME, value);
				this._ARB_COMMISSION_NAME = value;
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
		/// 项目经理和技术负责人最低要求
		/// </summary>
		public string QUALIFICATION_REQUIRE
		{
			get{ return _QUALIFICATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_REQUIRE, _QUALIFICATION_REQUIRE, value);
				this._QUALIFICATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 其他主要管理人员和技术人员最低要求
		/// </summary>
		public string OTHER_QUALIFICATION_REQUIRE
		{
			get{ return _OTHER_QUALIFICATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_QUALIFICATION_REQUIRE, _OTHER_QUALIFICATION_REQUIRE, value);
				this._OTHER_QUALIFICATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 机械设备最低要求
		/// </summary>
		public string EQUIPMENT_REQUIRE
		{
			get{ return _EQUIPMENT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_REQUIRE, _EQUIPMENT_REQUIRE, value);
				this._EQUIPMENT_REQUIRE = value;
			}
		}
		/// <summary>
		/// 评标价
		/// </summary>
		public decimal? BID_EVALUATION
		{
			get{ return _BID_EVALUATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVALUATION, _BID_EVALUATION, value);
				this._BID_EVALUATION = value;
			}
		}
		/// <summary>
		/// 信用分
		/// </summary>
		public decimal? CREDIT
		{
			get{ return _CREDIT; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT, _CREDIT, value);
				this._CREDIT = value;
			}
		}
		/// <summary>
		/// 施工企业被评为信用等级AA的年度
		/// </summary>
		public decimal? CREDIT_RATING_AA_YEAR
		{
			get{ return _CREDIT_RATING_AA_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_AA_YEAR, _CREDIT_RATING_AA_YEAR, value);
				this._CREDIT_RATING_AA_YEAR = value;
			}
		}
		/// <summary>
		/// 施工企业被评为信用等级A的年度
		/// </summary>
		public decimal? CREDIT_RATING_A_YEAR
		{
			get{ return _CREDIT_RATING_A_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_A_YEAR, _CREDIT_RATING_A_YEAR, value);
				this._CREDIT_RATING_A_YEAR = value;
			}
		}
		/// <summary>
		/// 施工企业被评为信用等级B的年度
		/// </summary>
		public decimal? CREDIT_RATING_B_YEAR
		{
			get{ return _CREDIT_RATING_B_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_B_YEAR, _CREDIT_RATING_B_YEAR, value);
				this._CREDIT_RATING_B_YEAR = value;
			}
		}
		/// <summary>
		/// 施工企业未参加福建省交通建设市场信用考核的年度
		/// </summary>
		public decimal? CREDIT_RATING_W_YEAR
		{
			get{ return _CREDIT_RATING_W_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_W_YEAR, _CREDIT_RATING_W_YEAR, value);
				this._CREDIT_RATING_W_YEAR = value;
			}
		}
		/// <summary>
		/// 项目经理未参加福建省交通建设市场信用考核的年度
		/// </summary>
		public decimal? CREDIT_RATING_BW_YEAR
		{
			get{ return _CREDIT_RATING_BW_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_BW_YEAR, _CREDIT_RATING_BW_YEAR, value);
				this._CREDIT_RATING_BW_YEAR = value;
			}
		}
		/// <summary>
		/// 施工企业被评为信用等级为C、D级的年度
		/// </summary>
		public decimal? CREDIT_RATING_CD_YEAR
		{
			get{ return _CREDIT_RATING_CD_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_CD_YEAR, _CREDIT_RATING_CD_YEAR, value);
				this._CREDIT_RATING_CD_YEAR = value;
			}
		}
		/// <summary>
		/// 高速公路路基土建施工工程评为A级或AA级且未参与同年普通公路考核的年度
		/// </summary>
		public decimal? CREDIT_RATING_AAAW_YEAR
		{
			get{ return _CREDIT_RATING_AAAW_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_AAAW_YEAR, _CREDIT_RATING_AAAW_YEAR, value);
				this._CREDIT_RATING_AAAW_YEAR = value;
			}
		}
		/// <summary>
		/// 普通公路建设项目或高速公路工程项目（未参与普通公路养护工程考核）信用考核被评为A、AA级的年度
		/// </summary>
		public decimal? CREDIT_RATING_AAA_YEAR
		{
			get{ return _CREDIT_RATING_AAA_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATING_AAA_YEAR, _CREDIT_RATING_AAA_YEAR, value);
				this._CREDIT_RATING_AAA_YEAR = value;
			}
		}
		/// <summary>
		/// 是否更改专用合同条款
		/// </summary>
		public string CHANGE
		{
			get{ return _CHANGE; }
			set
			{
				this.OnPropertyValueChange(_.CHANGE, _CHANGE, value);
				this._CHANGE = value;
			}
		}
		/// <summary>
		/// 一般约定
		/// </summary>
		public string GENERAL_CONTRACT
		{
			get{ return _GENERAL_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.GENERAL_CONTRACT, _GENERAL_CONTRACT, value);
				this._GENERAL_CONTRACT = value;
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
		/// 承包人
		/// </summary>
		public string CONTRACTOR
		{
			get{ return _CONTRACTOR; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTOR, _CONTRACTOR, value);
				this._CONTRACTOR = value;
			}
		}
		/// <summary>
		/// 材料和工程设备
		/// </summary>
		public string MATERIAL_PROJECT_EQUIPMENT
		{
			get{ return _MATERIAL_PROJECT_EQUIPMENT; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL_PROJECT_EQUIPMENT, _MATERIAL_PROJECT_EQUIPMENT, value);
				this._MATERIAL_PROJECT_EQUIPMENT = value;
			}
		}
		/// <summary>
		/// 施工设备和临时设施
		/// </summary>
		public string CONSTRUCT_EQUIP_TEMP_FACIL
		{
			get{ return _CONSTRUCT_EQUIP_TEMP_FACIL; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_EQUIP_TEMP_FACIL, _CONSTRUCT_EQUIP_TEMP_FACIL, value);
				this._CONSTRUCT_EQUIP_TEMP_FACIL = value;
			}
		}
		/// <summary>
		/// 交通运输
		/// </summary>
		public string TRANSPORTATION
		{
			get{ return _TRANSPORTATION; }
			set
			{
				this.OnPropertyValueChange(_.TRANSPORTATION, _TRANSPORTATION, value);
				this._TRANSPORTATION = value;
			}
		}
		/// <summary>
		/// 施工安全、治安保卫和环境保护
		/// </summary>
		public string SAFE_SECURITY_ENVIRON_PRO
		{
			get{ return _SAFE_SECURITY_ENVIRON_PRO; }
			set
			{
				this.OnPropertyValueChange(_.SAFE_SECURITY_ENVIRON_PRO, _SAFE_SECURITY_ENVIRON_PRO, value);
				this._SAFE_SECURITY_ENVIRON_PRO = value;
			}
		}
		/// <summary>
		/// 进度计划
		/// </summary>
		public string SCHEDULE
		{
			get{ return _SCHEDULE; }
			set
			{
				this.OnPropertyValueChange(_.SCHEDULE, _SCHEDULE, value);
				this._SCHEDULE = value;
			}
		}
		/// <summary>
		/// 开工和交工
		/// </summary>
		public string COMMENCEMENT_COMPLETION
		{
			get{ return _COMMENCEMENT_COMPLETION; }
			set
			{
				this.OnPropertyValueChange(_.COMMENCEMENT_COMPLETION, _COMMENCEMENT_COMPLETION, value);
				this._COMMENCEMENT_COMPLETION = value;
			}
		}
		/// <summary>
		/// 工程质量
		/// </summary>
		public string PROJECT_QUALITY
		{
			get{ return _PROJECT_QUALITY; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_QUALITY, _PROJECT_QUALITY, value);
				this._PROJECT_QUALITY = value;
			}
		}
		/// <summary>
		/// 变更
		/// </summary>
		public string MODIFICATION
		{
			get{ return _MODIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.MODIFICATION, _MODIFICATION, value);
				this._MODIFICATION = value;
			}
		}
		/// <summary>
		/// 价格调整
		/// </summary>
		public string PRICE_REGULATION
		{
			get{ return _PRICE_REGULATION; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_REGULATION, _PRICE_REGULATION, value);
				this._PRICE_REGULATION = value;
			}
		}
		/// <summary>
		/// 计量与支付
		/// </summary>
		public string MEASUREMENT_PAYMENT
		{
			get{ return _MEASUREMENT_PAYMENT; }
			set
			{
				this.OnPropertyValueChange(_.MEASUREMENT_PAYMENT, _MEASUREMENT_PAYMENT, value);
				this._MEASUREMENT_PAYMENT = value;
			}
		}
		/// <summary>
		/// 交工验收
		/// </summary>
		public string COMPLETION_ACCEPTANCE
		{
			get{ return _COMPLETION_ACCEPTANCE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLETION_ACCEPTANCE, _COMPLETION_ACCEPTANCE, value);
				this._COMPLETION_ACCEPTANCE = value;
			}
		}
		/// <summary>
		/// 保险
		/// </summary>
		public string INSURANCE
		{
			get{ return _INSURANCE; }
			set
			{
				this.OnPropertyValueChange(_.INSURANCE, _INSURANCE, value);
				this._INSURANCE = value;
			}
		}
		/// <summary>
		/// 违约
		/// </summary>
		public string BREACH_CONTRACT
		{
			get{ return _BREACH_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.BREACH_CONTRACT, _BREACH_CONTRACT, value);
				this._BREACH_CONTRACT = value;
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
		/// 耕地保护
		/// </summary>
		public string LAND_PROTECTION
		{
			get{ return _LAND_PROTECTION; }
			set
			{
				this.OnPropertyValueChange(_.LAND_PROTECTION, _LAND_PROTECTION, value);
				this._LAND_PROTECTION = value;
			}
		}
		/// <summary>
		/// 资料的份量与送交时限
		/// </summary>
		public string DELIVERY_TIME_LIMIT
		{
			get{ return _DELIVERY_TIME_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.DELIVERY_TIME_LIMIT, _DELIVERY_TIME_LIMIT, value);
				this._DELIVERY_TIME_LIMIT = value;
			}
		}
		/// <summary>
		/// 其他文件与规定
		/// </summary>
		public string OTHER_CONVENTIONS
		{
			get{ return _OTHER_CONVENTIONS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONVENTIONS, _OTHER_CONVENTIONS, value);
				this._OTHER_CONVENTIONS = value;
			}
		}
		/// <summary>
		/// 其他补充条款
		/// </summary>
		public string SUPPLY_ITEM
		{
			get{ return _SUPPLY_ITEM; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_ITEM, _SUPPLY_ITEM, value);
				this._SUPPLY_ITEM = value;
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
		/// 技术规范
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
		/// 补充技术规范
		/// </summary>
		public string SUPPLY_TECHNICAL_STANDARD
		{
			get{ return _SUPPLY_TECHNICAL_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_TECHNICAL_STANDARD, _SUPPLY_TECHNICAL_STANDARD, value);
				this._SUPPLY_TECHNICAL_STANDARD = value;
			}
		}
		/// <summary>
		/// 标后监管指南
		/// </summary>
		public string ENCLOSURE1
		{
			get{ return _ENCLOSURE1; }
			set
			{
				this.OnPropertyValueChange(_.ENCLOSURE1, _ENCLOSURE1, value);
				this._ENCLOSURE1 = value;
			}
		}
		/// <summary>
		/// 招标代理合同
		/// </summary>
		public string ENCLOSURE2
		{
			get{ return _ENCLOSURE2; }
			set
			{
				this.OnPropertyValueChange(_.ENCLOSURE2, _ENCLOSURE2, value);
				this._ENCLOSURE2 = value;
			}
		}
		/// <summary>
		/// 招标人授权招标代理签章协议书
		/// </summary>
		public string ENCLOSURE3
		{
			get{ return _ENCLOSURE3; }
			set
			{
				this.OnPropertyValueChange(_.ENCLOSURE3, _ENCLOSURE3, value);
				this._ENCLOSURE3 = value;
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
		/// E1值
		/// </summary>
		public string E1_NUMBER
		{
			get{ return _E1_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.E1_NUMBER, _E1_NUMBER, value);
				this._E1_NUMBER = value;
			}
		}
		/// <summary>
		/// E2值
		/// </summary>
		public string E2_NUMBER
		{
			get{ return _E2_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.E2_NUMBER, _E2_NUMBER, value);
				this._E2_NUMBER = value;
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
				_.LIMITE_TIME_UNIT,
				_.FIRST_ENVELOPES_CONFIRM,
				_.WIN_BID_NUMBER,
				_.QUALI_REQUIRE1,
				_.QUALI_REQUIRE2,
				_.REPUTATION_TIME1,
				_.REPUTATION_TIME2,
				_.MANAGER_TITLE,
				_.MANAGER_TITLE_LEVEL,
				_.CONSTRUCTOR_MAJOR,
				_.CONSTRUCTOR_MAJOR_LEVEL,
				_.MANAGER_AGE,
				_.TECH_TITLE,
				_.TECH_TITLE_LEVEL,
				_.TECH_AGE,
				_.DELAY_PENALTY,
				_.LIQUID_DAMAGE_RATE,
				_.MINIMUM_LIMIT,
				_.DEFECT_LIABILITY_PERIOD,
				_.BEGIN_ALL_DATE,
				_.END_DATE,
				_.FUND_IMPLEMENTATION,
				_.TOTAL_SECTION_NUMBER,
				_.TENDERER_BID_SECTION,
				_.CONSTRUCTION_BUDGET_PRICE,
				_.CONTRACT_PRICE,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.MARGIN_TIME,
				_.INTEREST_MODE,
				_.INTEREST_CALCULATION_CYCLE,
				_.MONEY_RATE,
				_.MEDIA1,
				_.MEDIA2,
				_.EVALUATING_METHOD_STANDARD,
				_.MATERIAL_PRICE_ADJUSTED,
				_.BASE_PRICE_CITY,
				_.RELEASE_PRICE_CITY,
				_.NO_RELEASE_PRICE_CITY,
				_.DEFECT_LIABILITY_PERIOD1,
				_.OPEN_BID_REQURE_CHOOSE,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_PHONE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.QUALITY_REQUIRE1,
				_.QUALITY_REQUIRE2,
				_.SYNDICATED_NUMBER,
				_.QUESTION_TIME,
				_.BIDDER_NOTICE_TIME,
				_.SUBCONTRACT,
				_.TENDER_NOTICE_TIME,
				_.MODIFICATION_TIME,
				_.FINANCIAL_YEAR_REQUIRE,
				_.SIMILAR_PROJECT_YEAR_REQUIRE,
				_.LITIGATION_REQUIRE,
				_.BRIBERY_RECORD_YEAR,
				_.COPY_NUMBER,
				_.DECRYPTION_TYPE,
				_.SEC_ENVELOPES_OPEN,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_LIBRARY,
				_.K_NUMBER,
				_.HIGHEST_PRICE_DATE,
				_.LOWEST_PRICE_DATE,
				_.PREMIUM_RATE1,
				_.PREMIUM_RATE2,
				_.INSURED_AMOUNT,
				_.DISPUTE_DEAL_METHOD,
				_.ARB_COMMISSION_NAME,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.QUALIFICATION_REQUIRE,
				_.OTHER_QUALIFICATION_REQUIRE,
				_.EQUIPMENT_REQUIRE,
				_.BID_EVALUATION,
				_.CREDIT,
				_.CREDIT_RATING_AA_YEAR,
				_.CREDIT_RATING_A_YEAR,
				_.CREDIT_RATING_B_YEAR,
				_.CREDIT_RATING_W_YEAR,
				_.CREDIT_RATING_BW_YEAR,
				_.CREDIT_RATING_CD_YEAR,
				_.CREDIT_RATING_AAAW_YEAR,
				_.CREDIT_RATING_AAA_YEAR,
				_.CHANGE,
				_.GENERAL_CONTRACT,
				_.SUPERVISOR,
				_.CONTRACTOR,
				_.MATERIAL_PROJECT_EQUIPMENT,
				_.CONSTRUCT_EQUIP_TEMP_FACIL,
				_.TRANSPORTATION,
				_.SAFE_SECURITY_ENVIRON_PRO,
				_.SCHEDULE,
				_.COMMENCEMENT_COMPLETION,
				_.PROJECT_QUALITY,
				_.MODIFICATION,
				_.PRICE_REGULATION,
				_.MEASUREMENT_PAYMENT,
				_.COMPLETION_ACCEPTANCE,
				_.INSURANCE,
				_.BREACH_CONTRACT,
				_.DISPUTE_RESOLUTION,
				_.LAND_PROTECTION,
				_.DELIVERY_TIME_LIMIT,
				_.OTHER_CONVENTIONS,
				_.SUPPLY_ITEM,
				_.BILL_OF_QUANTITIES,
				_.DRAWING,
				_.TECHNICAL_SPECIFICATIONS,
				_.SUPPLY_TECHNICAL_STANDARD,
				_.ENCLOSURE1,
				_.ENCLOSURE2,
				_.ENCLOSURE3,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.E1_NUMBER,
				_.E2_NUMBER,
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
				this._LIMITE_TIME_UNIT,
				this._FIRST_ENVELOPES_CONFIRM,
				this._WIN_BID_NUMBER,
				this._QUALI_REQUIRE1,
				this._QUALI_REQUIRE2,
				this._REPUTATION_TIME1,
				this._REPUTATION_TIME2,
				this._MANAGER_TITLE,
				this._MANAGER_TITLE_LEVEL,
				this._CONSTRUCTOR_MAJOR,
				this._CONSTRUCTOR_MAJOR_LEVEL,
				this._MANAGER_AGE,
				this._TECH_TITLE,
				this._TECH_TITLE_LEVEL,
				this._TECH_AGE,
				this._DELAY_PENALTY,
				this._LIQUID_DAMAGE_RATE,
				this._MINIMUM_LIMIT,
				this._DEFECT_LIABILITY_PERIOD,
				this._BEGIN_ALL_DATE,
				this._END_DATE,
				this._FUND_IMPLEMENTATION,
				this._TOTAL_SECTION_NUMBER,
				this._TENDERER_BID_SECTION,
				this._CONSTRUCTION_BUDGET_PRICE,
				this._CONTRACT_PRICE,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._MARGIN_TIME,
				this._INTEREST_MODE,
				this._INTEREST_CALCULATION_CYCLE,
				this._MONEY_RATE,
				this._MEDIA1,
				this._MEDIA2,
				this._EVALUATING_METHOD_STANDARD,
				this._MATERIAL_PRICE_ADJUSTED,
				this._BASE_PRICE_CITY,
				this._RELEASE_PRICE_CITY,
				this._NO_RELEASE_PRICE_CITY,
				this._DEFECT_LIABILITY_PERIOD1,
				this._OPEN_BID_REQURE_CHOOSE,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_PHONE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._QUALITY_REQUIRE1,
				this._QUALITY_REQUIRE2,
				this._SYNDICATED_NUMBER,
				this._QUESTION_TIME,
				this._BIDDER_NOTICE_TIME,
				this._SUBCONTRACT,
				this._TENDER_NOTICE_TIME,
				this._MODIFICATION_TIME,
				this._FINANCIAL_YEAR_REQUIRE,
				this._SIMILAR_PROJECT_YEAR_REQUIRE,
				this._LITIGATION_REQUIRE,
				this._BRIBERY_RECORD_YEAR,
				this._COPY_NUMBER,
				this._DECRYPTION_TYPE,
				this._SEC_ENVELOPES_OPEN,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_LIBRARY,
				this._K_NUMBER,
				this._HIGHEST_PRICE_DATE,
				this._LOWEST_PRICE_DATE,
				this._PREMIUM_RATE1,
				this._PREMIUM_RATE2,
				this._INSURED_AMOUNT,
				this._DISPUTE_DEAL_METHOD,
				this._ARB_COMMISSION_NAME,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._QUALIFICATION_REQUIRE,
				this._OTHER_QUALIFICATION_REQUIRE,
				this._EQUIPMENT_REQUIRE,
				this._BID_EVALUATION,
				this._CREDIT,
				this._CREDIT_RATING_AA_YEAR,
				this._CREDIT_RATING_A_YEAR,
				this._CREDIT_RATING_B_YEAR,
				this._CREDIT_RATING_W_YEAR,
				this._CREDIT_RATING_BW_YEAR,
				this._CREDIT_RATING_CD_YEAR,
				this._CREDIT_RATING_AAAW_YEAR,
				this._CREDIT_RATING_AAA_YEAR,
				this._CHANGE,
				this._GENERAL_CONTRACT,
				this._SUPERVISOR,
				this._CONTRACTOR,
				this._MATERIAL_PROJECT_EQUIPMENT,
				this._CONSTRUCT_EQUIP_TEMP_FACIL,
				this._TRANSPORTATION,
				this._SAFE_SECURITY_ENVIRON_PRO,
				this._SCHEDULE,
				this._COMMENCEMENT_COMPLETION,
				this._PROJECT_QUALITY,
				this._MODIFICATION,
				this._PRICE_REGULATION,
				this._MEASUREMENT_PAYMENT,
				this._COMPLETION_ACCEPTANCE,
				this._INSURANCE,
				this._BREACH_CONTRACT,
				this._DISPUTE_RESOLUTION,
				this._LAND_PROTECTION,
				this._DELIVERY_TIME_LIMIT,
				this._OTHER_CONVENTIONS,
				this._SUPPLY_ITEM,
				this._BILL_OF_QUANTITIES,
				this._DRAWING,
				this._TECHNICAL_SPECIFICATIONS,
				this._SUPPLY_TECHNICAL_STANDARD,
				this._ENCLOSURE1,
				this._ENCLOSURE2,
				this._ENCLOSURE3,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._E1_NUMBER,
				this._E2_NUMBER,
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
			public readonly static Field All = new Field("*", "JT_GENRAL_CON_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_GENRAL_CON_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_GENRAL_CON_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 工期单位
			/// </summary>
			public readonly static Field LIMITE_TIME_UNIT = new Field("LIMITE_TIME_UNIT", "JT_GENRAL_CON_TENDER_FILE", "工期单位");
            /// <summary>
			/// 第一信封随机确认方式
			/// </summary>
			public readonly static Field FIRST_ENVELOPES_CONFIRM = new Field("FIRST_ENVELOPES_CONFIRM", "JT_GENRAL_CON_TENDER_FILE", "第一信封随机确认方式");
            /// <summary>
			/// 中标候选人个数
			/// </summary>
			public readonly static Field WIN_BID_NUMBER = new Field("WIN_BID_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "中标候选人个数");
            /// <summary>
			/// 是否须施工资质企业名录
			/// </summary>
			public readonly static Field QUALI_REQUIRE1 = new Field("QUALI_REQUIRE1", "JT_GENRAL_CON_TENDER_FILE", "是否须施工资质企业名录");
            /// <summary>
			/// 是否须提供企业资质信息
			/// </summary>
			public readonly static Field QUALI_REQUIRE2 = new Field("QUALI_REQUIRE2", "JT_GENRAL_CON_TENDER_FILE", "是否须提供企业资质信息");
            /// <summary>
			/// 未发生安全事故的时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME1 = new Field("REPUTATION_TIME1", "JT_GENRAL_CON_TENDER_FILE", "未发生安全事故的时间要求");
            /// <summary>
			/// 未出现不良记录时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME2 = new Field("REPUTATION_TIME2", "JT_GENRAL_CON_TENDER_FILE", "未出现不良记录时间要求");
            /// <summary>
			/// 项目经理职称专业
			/// </summary>
			public readonly static Field MANAGER_TITLE = new Field("MANAGER_TITLE", "JT_GENRAL_CON_TENDER_FILE", "项目经理职称专业");
            /// <summary>
			/// 项目经理职称等级
			/// </summary>
			public readonly static Field MANAGER_TITLE_LEVEL = new Field("MANAGER_TITLE_LEVEL", "JT_GENRAL_CON_TENDER_FILE", "项目经理职称等级");
            /// <summary>
			/// 注册建造师专业名称
			/// </summary>
			public readonly static Field CONSTRUCTOR_MAJOR = new Field("CONSTRUCTOR_MAJOR", "JT_GENRAL_CON_TENDER_FILE", "注册建造师专业名称");
            /// <summary>
			/// 注册建造师等级
			/// </summary>
			public readonly static Field CONSTRUCTOR_MAJOR_LEVEL = new Field("CONSTRUCTOR_MAJOR_LEVEL", "JT_GENRAL_CON_TENDER_FILE", "注册建造师等级");
            /// <summary>
			/// 项目经理年龄
			/// </summary>
			public readonly static Field MANAGER_AGE = new Field("MANAGER_AGE", "JT_GENRAL_CON_TENDER_FILE", "项目经理年龄");
            /// <summary>
			/// 技术负责人职称专业
			/// </summary>
			public readonly static Field TECH_TITLE = new Field("TECH_TITLE", "JT_GENRAL_CON_TENDER_FILE", "技术负责人职称专业");
            /// <summary>
			/// 技术负责人职称等级
			/// </summary>
			public readonly static Field TECH_TITLE_LEVEL = new Field("TECH_TITLE_LEVEL", "JT_GENRAL_CON_TENDER_FILE", "技术负责人职称等级");
            /// <summary>
			/// 技术负责人年龄
			/// </summary>
			public readonly static Field TECH_AGE = new Field("TECH_AGE", "JT_GENRAL_CON_TENDER_FILE", "技术负责人年龄");
            /// <summary>
			/// 工期延误的违约金
			/// </summary>
			public readonly static Field DELAY_PENALTY = new Field("DELAY_PENALTY", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "工期延误的违约金");
            /// <summary>
			/// 逾期付款违约金的利率
			/// </summary>
			public readonly static Field LIQUID_DAMAGE_RATE = new Field("LIQUID_DAMAGE_RATE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "逾期付款违约金的利率");
            /// <summary>
			/// 进度付款证书最低限额
			/// </summary>
			public readonly static Field MINIMUM_LIMIT = new Field("MINIMUM_LIMIT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "进度付款证书最低限额");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD = new Field("DEFECT_LIABILITY_PERIOD", "JT_GENRAL_CON_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 总计划开工日期
			/// </summary>
			public readonly static Field BEGIN_ALL_DATE = new Field("BEGIN_ALL_DATE", "JT_GENRAL_CON_TENDER_FILE", "总计划开工日期");
            /// <summary>
			/// 计划交工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "JT_GENRAL_CON_TENDER_FILE", "计划交工日期");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_GENRAL_CON_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 项目总标段个数
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "项目总标段个数");
            /// <summary>
			/// 本次招标标段个数
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION = new Field("TENDERER_BID_SECTION", "JT_GENRAL_CON_TENDER_FILE", "本次招标标段个数");
            /// <summary>
			/// 工程预算审核价
			/// </summary>
			public readonly static Field CONSTRUCTION_BUDGET_PRICE = new Field("CONSTRUCTION_BUDGET_PRICE", "JT_GENRAL_CON_TENDER_FILE", "工程预算审核价");
            /// <summary>
			/// 发包价
			/// </summary>
			public readonly static Field CONTRACT_PRICE = new Field("CONTRACT_PRICE", "JT_GENRAL_CON_TENDER_FILE", "发包价");
            /// <summary>
			/// 每个投标人最多投标标段数
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_GENRAL_CON_TENDER_FILE", "每个投标人最多投标标段数");
            /// <summary>
			/// 每个投标人最多中标标段数
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "每个投标人最多中标标段数");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_GENRAL_CON_TENDER_FILE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_GENRAL_CON_TENDER_FILE", "开户银行");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_GENRAL_CON_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 采用电汇形式保证金计息方式
			/// </summary>
			public readonly static Field INTEREST_MODE = new Field("INTEREST_MODE", "JT_GENRAL_CON_TENDER_FILE", "采用电汇形式保证金计息方式");
            /// <summary>
			/// 保证金利息计算周期
			/// </summary>
			public readonly static Field INTEREST_CALCULATION_CYCLE = new Field("INTEREST_CALCULATION_CYCLE", "JT_GENRAL_CON_TENDER_FILE", "保证金利息计算周期");
            /// <summary>
			/// 年化利率
			/// </summary>
			public readonly static Field MONEY_RATE = new Field("MONEY_RATE", "JT_GENRAL_CON_TENDER_FILE", "年化利率");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_GENRAL_CON_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_GENRAL_CON_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 评标办法评审因素和评审标准
			/// </summary>
			public readonly static Field EVALUATING_METHOD_STANDARD = new Field("EVALUATING_METHOD_STANDARD", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "评标办法评审因素和评审标准");
            /// <summary>
			/// 材料价格是否调整
			/// </summary>
			public readonly static Field MATERIAL_PRICE_ADJUSTED = new Field("MATERIAL_PRICE_ADJUSTED", "JT_GENRAL_CON_TENDER_FILE", "材料价格是否调整");
            /// <summary>
			/// 基期价格参考城市
			/// </summary>
			public readonly static Field BASE_PRICE_CITY = new Field("BASE_PRICE_CITY", "JT_GENRAL_CON_TENDER_FILE", "基期价格参考城市");
            /// <summary>
			/// 发布价参考城市
			/// </summary>
			public readonly static Field RELEASE_PRICE_CITY = new Field("RELEASE_PRICE_CITY", "JT_GENRAL_CON_TENDER_FILE", "发布价参考城市");
            /// <summary>
			/// 未涉及材料发布价参考城市
			/// </summary>
			public readonly static Field NO_RELEASE_PRICE_CITY = new Field("NO_RELEASE_PRICE_CITY", "JT_GENRAL_CON_TENDER_FILE", "未涉及材料发布价参考城市");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD1 = new Field("DEFECT_LIABILITY_PERIOD1", "JT_GENRAL_CON_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 是否需要人员到场
			/// </summary>
			public readonly static Field OPEN_BID_REQURE_CHOOSE = new Field("OPEN_BID_REQURE_CHOOSE", "JT_GENRAL_CON_TENDER_FILE", "是否需要人员到场");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_GENRAL_CON_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE = new Field("SUPERVISE_DEPT_PHONE", "JT_GENRAL_CON_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_GENRAL_CON_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_GENRAL_CON_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 交工验收质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE1 = new Field("QUALITY_REQUIRE1", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "交工验收质量要求");
            /// <summary>
			/// 竣工验收质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE2 = new Field("QUALITY_REQUIRE2", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "竣工验收质量要求");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field SYNDICATED_NUMBER = new Field("SYNDICATED_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 投标人提出问题的截止时间
			/// </summary>
			public readonly static Field QUESTION_TIME = new Field("QUESTION_TIME", "JT_GENRAL_CON_TENDER_FILE", "投标人提出问题的截止时间");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field BIDDER_NOTICE_TIME = new Field("BIDDER_NOTICE_TIME", "JT_GENRAL_CON_TENDER_FILE", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 是否允许分包
			/// </summary>
			public readonly static Field SUBCONTRACT = new Field("SUBCONTRACT", "JT_GENRAL_CON_TENDER_FILE", "是否允许分包");
            /// <summary>
			/// 招标人书面澄清的时间
			/// </summary>
			public readonly static Field TENDER_NOTICE_TIME = new Field("TENDER_NOTICE_TIME", "JT_GENRAL_CON_TENDER_FILE", "招标人书面澄清的时间");
            /// <summary>
			/// 招标文件修改截止时间
			/// </summary>
			public readonly static Field MODIFICATION_TIME = new Field("MODIFICATION_TIME", "JT_GENRAL_CON_TENDER_FILE", "招标文件修改截止时间");
            /// <summary>
			/// 近年财务状况的年份要求
			/// </summary>
			public readonly static Field FINANCIAL_YEAR_REQUIRE = new Field("FINANCIAL_YEAR_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "近年财务状况的年份要求");
            /// <summary>
			/// 近年完成的类似项目的年份要求
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_YEAR_REQUIRE = new Field("SIMILAR_PROJECT_YEAR_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "近年完成的类似项目的年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况的起始年份要求
			/// </summary>
			public readonly static Field LITIGATION_REQUIRE = new Field("LITIGATION_REQUIRE", "JT_GENRAL_CON_TENDER_FILE", "发生的诉讼及仲裁情况的起始年份要求");
            /// <summary>
			/// 近年发生的行贿犯罪记录查询的年份要求
			/// </summary>
			public readonly static Field BRIBERY_RECORD_YEAR = new Field("BRIBERY_RECORD_YEAR", "JT_GENRAL_CON_TENDER_FILE", "近年发生的行贿犯罪记录查询的年份要求");
            /// <summary>
			/// 投标文件副本份数
			/// </summary>
			public readonly static Field COPY_NUMBER = new Field("COPY_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "投标文件副本份数");
            /// <summary>
			/// 投标文件解密方式
			/// </summary>
			public readonly static Field DECRYPTION_TYPE = new Field("DECRYPTION_TYPE", "JT_GENRAL_CON_TENDER_FILE", "投标文件解密方式");
            /// <summary>
			/// 第二封信开标程序
			/// </summary>
			public readonly static Field SEC_ENVELOPES_OPEN = new Field("SEC_ENVELOPES_OPEN", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "第二封信开标程序");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_GENRAL_CON_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_GENRAL_CON_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_GENRAL_CON_TENDER_FILE", "专家人数");
            /// <summary>
			/// 评标专家确定方式
			/// </summary>
			public readonly static Field EXPERT_LIBRARY = new Field("EXPERT_LIBRARY", "JT_GENRAL_CON_TENDER_FILE", "评标专家确定方式");
            /// <summary>
			/// K值选定
			/// </summary>
			public readonly static Field K_NUMBER = new Field("K_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "K值选定");
            /// <summary>
			/// 最高限价公布截止时间
			/// </summary>
			public readonly static Field HIGHEST_PRICE_DATE = new Field("HIGHEST_PRICE_DATE", "JT_GENRAL_CON_TENDER_FILE", "最高限价公布截止时间");
            /// <summary>
			/// 进入评标基准价计算的下限发布截止时间
			/// </summary>
			public readonly static Field LOWEST_PRICE_DATE = new Field("LOWEST_PRICE_DATE", "JT_GENRAL_CON_TENDER_FILE", "进入评标基准价计算的下限发布截止时间");
            /// <summary>
			/// 工程保险费率
			/// </summary>
			public readonly static Field PREMIUM_RATE1 = new Field("PREMIUM_RATE1", "JT_GENRAL_CON_TENDER_FILE", "工程保险费率");
            /// <summary>
			/// 第三方责任保险费率
			/// </summary>
			public readonly static Field PREMIUM_RATE2 = new Field("PREMIUM_RATE2", "JT_GENRAL_CON_TENDER_FILE", "第三方责任保险费率");
            /// <summary>
			/// 最低投保金额
			/// </summary>
			public readonly static Field INSURED_AMOUNT = new Field("INSURED_AMOUNT", "JT_GENRAL_CON_TENDER_FILE", "最低投保金额");
            /// <summary>
			/// 争议的最终解决方式
			/// </summary>
			public readonly static Field DISPUTE_DEAL_METHOD = new Field("DISPUTE_DEAL_METHOD", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "争议的最终解决方式");
            /// <summary>
			/// 仲裁委员会名称
			/// </summary>
			public readonly static Field ARB_COMMISSION_NAME = new Field("ARB_COMMISSION_NAME", "JT_GENRAL_CON_TENDER_FILE", "仲裁委员会名称");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 项目经理和技术负责人最低要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "项目经理和技术负责人最低要求");
            /// <summary>
			/// 其他主要管理人员和技术人员最低要求
			/// </summary>
			public readonly static Field OTHER_QUALIFICATION_REQUIRE = new Field("OTHER_QUALIFICATION_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "其他主要管理人员和技术人员最低要求");
            /// <summary>
			/// 机械设备最低要求
			/// </summary>
			public readonly static Field EQUIPMENT_REQUIRE = new Field("EQUIPMENT_REQUIRE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "机械设备最低要求");
            /// <summary>
			/// 评标价
			/// </summary>
			public readonly static Field BID_EVALUATION = new Field("BID_EVALUATION", "JT_GENRAL_CON_TENDER_FILE", "评标价");
            /// <summary>
			/// 信用分
			/// </summary>
			public readonly static Field CREDIT = new Field("CREDIT", "JT_GENRAL_CON_TENDER_FILE", "信用分");
            /// <summary>
			/// 施工企业被评为信用等级AA的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_AA_YEAR = new Field("CREDIT_RATING_AA_YEAR", "JT_GENRAL_CON_TENDER_FILE", "施工企业被评为信用等级AA的年度");
            /// <summary>
			/// 施工企业被评为信用等级A的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_A_YEAR = new Field("CREDIT_RATING_A_YEAR", "JT_GENRAL_CON_TENDER_FILE", "施工企业被评为信用等级A的年度");
            /// <summary>
			/// 施工企业被评为信用等级B的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_B_YEAR = new Field("CREDIT_RATING_B_YEAR", "JT_GENRAL_CON_TENDER_FILE", "施工企业被评为信用等级B的年度");
            /// <summary>
			/// 施工企业未参加福建省交通建设市场信用考核的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_W_YEAR = new Field("CREDIT_RATING_W_YEAR", "JT_GENRAL_CON_TENDER_FILE", "施工企业未参加福建省交通建设市场信用考核的年度");
            /// <summary>
			/// 项目经理未参加福建省交通建设市场信用考核的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_BW_YEAR = new Field("CREDIT_RATING_BW_YEAR", "JT_GENRAL_CON_TENDER_FILE", "项目经理未参加福建省交通建设市场信用考核的年度");
            /// <summary>
			/// 施工企业被评为信用等级为C、D级的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_CD_YEAR = new Field("CREDIT_RATING_CD_YEAR", "JT_GENRAL_CON_TENDER_FILE", "施工企业被评为信用等级为C、D级的年度");
            /// <summary>
			/// 高速公路路基土建施工工程评为A级或AA级且未参与同年普通公路考核的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_AAAW_YEAR = new Field("CREDIT_RATING_AAAW_YEAR", "JT_GENRAL_CON_TENDER_FILE", "高速公路路基土建施工工程评为A级或AA级且未参与同年普通公路考核的年度");
            /// <summary>
			/// 普通公路建设项目或高速公路工程项目（未参与普通公路养护工程考核）信用考核被评为A、AA级的年度
			/// </summary>
			public readonly static Field CREDIT_RATING_AAA_YEAR = new Field("CREDIT_RATING_AAA_YEAR", "JT_GENRAL_CON_TENDER_FILE", "普通公路建设项目或高速公路工程项目（未参与普通公路养护工程考核）信用考核被评为A、AA级的年度");
            /// <summary>
			/// 是否更改专用合同条款
			/// </summary>
			public readonly static Field CHANGE = new Field("CHANGE", "JT_GENRAL_CON_TENDER_FILE", "是否更改专用合同条款");
            /// <summary>
			/// 一般约定
			/// </summary>
			public readonly static Field GENERAL_CONTRACT = new Field("GENERAL_CONTRACT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "一般约定");
            /// <summary>
			/// 监理人
			/// </summary>
			public readonly static Field SUPERVISOR = new Field("SUPERVISOR", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "监理人");
            /// <summary>
			/// 承包人
			/// </summary>
			public readonly static Field CONTRACTOR = new Field("CONTRACTOR", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "承包人");
            /// <summary>
			/// 材料和工程设备
			/// </summary>
			public readonly static Field MATERIAL_PROJECT_EQUIPMENT = new Field("MATERIAL_PROJECT_EQUIPMENT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "材料和工程设备");
            /// <summary>
			/// 施工设备和临时设施
			/// </summary>
			public readonly static Field CONSTRUCT_EQUIP_TEMP_FACIL = new Field("CONSTRUCT_EQUIP_TEMP_FACIL", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "施工设备和临时设施");
            /// <summary>
			/// 交通运输
			/// </summary>
			public readonly static Field TRANSPORTATION = new Field("TRANSPORTATION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "交通运输");
            /// <summary>
			/// 施工安全、治安保卫和环境保护
			/// </summary>
			public readonly static Field SAFE_SECURITY_ENVIRON_PRO = new Field("SAFE_SECURITY_ENVIRON_PRO", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "施工安全、治安保卫和环境保护");
            /// <summary>
			/// 进度计划
			/// </summary>
			public readonly static Field SCHEDULE = new Field("SCHEDULE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "进度计划");
            /// <summary>
			/// 开工和交工
			/// </summary>
			public readonly static Field COMMENCEMENT_COMPLETION = new Field("COMMENCEMENT_COMPLETION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "开工和交工");
            /// <summary>
			/// 工程质量
			/// </summary>
			public readonly static Field PROJECT_QUALITY = new Field("PROJECT_QUALITY", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "工程质量");
            /// <summary>
			/// 变更
			/// </summary>
			public readonly static Field MODIFICATION = new Field("MODIFICATION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "变更");
            /// <summary>
			/// 价格调整
			/// </summary>
			public readonly static Field PRICE_REGULATION = new Field("PRICE_REGULATION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "价格调整");
            /// <summary>
			/// 计量与支付
			/// </summary>
			public readonly static Field MEASUREMENT_PAYMENT = new Field("MEASUREMENT_PAYMENT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "计量与支付");
            /// <summary>
			/// 交工验收
			/// </summary>
			public readonly static Field COMPLETION_ACCEPTANCE = new Field("COMPLETION_ACCEPTANCE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "交工验收");
            /// <summary>
			/// 保险
			/// </summary>
			public readonly static Field INSURANCE = new Field("INSURANCE", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "保险");
            /// <summary>
			/// 违约
			/// </summary>
			public readonly static Field BREACH_CONTRACT = new Field("BREACH_CONTRACT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "违约");
            /// <summary>
			/// 争议的解决
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "争议的解决");
            /// <summary>
			/// 耕地保护
			/// </summary>
			public readonly static Field LAND_PROTECTION = new Field("LAND_PROTECTION", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "耕地保护");
            /// <summary>
			/// 资料的份量与送交时限
			/// </summary>
			public readonly static Field DELIVERY_TIME_LIMIT = new Field("DELIVERY_TIME_LIMIT", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "资料的份量与送交时限");
            /// <summary>
			/// 其他文件与规定
			/// </summary>
			public readonly static Field OTHER_CONVENTIONS = new Field("OTHER_CONVENTIONS", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "其他文件与规定");
            /// <summary>
			/// 其他补充条款
			/// </summary>
			public readonly static Field SUPPLY_ITEM = new Field("SUPPLY_ITEM", "JT_GENRAL_CON_TENDER_FILE",DbType.AnsiString, null, "其他补充条款");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_GENRAL_CON_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_GENRAL_CON_TENDER_FILE", "图纸");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_GENRAL_CON_TENDER_FILE", "技术规范");
            /// <summary>
			/// 补充技术规范
			/// </summary>
			public readonly static Field SUPPLY_TECHNICAL_STANDARD = new Field("SUPPLY_TECHNICAL_STANDARD", "JT_GENRAL_CON_TENDER_FILE", "补充技术规范");
            /// <summary>
			/// 标后监管指南
			/// </summary>
			public readonly static Field ENCLOSURE1 = new Field("ENCLOSURE1", "JT_GENRAL_CON_TENDER_FILE", "标后监管指南");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field ENCLOSURE2 = new Field("ENCLOSURE2", "JT_GENRAL_CON_TENDER_FILE", "招标代理合同");
            /// <summary>
			/// 招标人授权招标代理签章协议书
			/// </summary>
			public readonly static Field ENCLOSURE3 = new Field("ENCLOSURE3", "JT_GENRAL_CON_TENDER_FILE", "招标人授权招标代理签章协议书");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_GENRAL_CON_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_GENRAL_CON_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_GENRAL_CON_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_GENRAL_CON_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_GENRAL_CON_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_GENRAL_CON_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_GENRAL_CON_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_GENRAL_CON_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_GENRAL_CON_TENDER_FILE", "M_TM");
            /// <summary>
			/// E1值
			/// </summary>
			public readonly static Field E1_NUMBER = new Field("E1_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "E1值");
            /// <summary>
			/// E2值
			/// </summary>
			public readonly static Field E2_NUMBER = new Field("E2_NUMBER", "JT_GENRAL_CON_TENDER_FILE", "E2值");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_GENRAL_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_GENRAL_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_GENRAL_CON_TENDER_FILE", "");
        }
        #endregion
	}
}