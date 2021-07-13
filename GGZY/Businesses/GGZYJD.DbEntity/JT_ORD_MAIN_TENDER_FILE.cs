using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_ORD_MAIN_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_ORD_MAIN_TENDER_FILE")]
    [Serializable]
    public partial class JT_ORD_MAIN_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _DEFECT_LIABILITY_PERIOD;
		private DateTime? _BEGIN_ALL_DATE;
		private DateTime? _END_DATE;
		private string _LIMITE_TIME_UNIT;
		private decimal? _SYNDICATED_NUMBER;
		private string _OPEN_BID_REQURE_CHOOSE;
		private string _OPEN_BID_REQURE_CERT;
		private string _FINANCE_YEAR;
		private DateTime? _REPUTATION_TIME1;
		private DateTime? _REPUTATION_TIME2;
		private string _MANAGER_TITLE;
		private string _MANAGER_TITLE_LEVEL;
		private decimal? _MANAGER_AGE;
		private string _CONSTRUCTOR_MAJOR;
		private string _CONSTRUCTOR_MAJOR_LEVEL;
		private string _TECH_TITLE;
		private string _TECH_TITLE_LEVEL;
		private decimal? _TECH_AGE;
		private decimal? _SECURITY_SELECTION_NUM;
		private decimal? _SECURITY_SELECTION_AGE;
		private string _MATERIAL_PRICE_ADJUSTED;
		private string _CONTR_SUPPLE_CLAUSE;
		private string _STANDARD_REQUIRE;
		private string _ENGINEER_QUALITY_REQUIRE;
		private string _PROVI_SUM;
		private string _BASE_PRICE_CITY;
		private string _RELEASE_PRICE_CITY;
		private string _NO_RELEASE_PRICE_CITY;
		private string _ADVANCE_AMOUNT_CONTENT;
		private string _PROJECT_RISKS_NAME;
		private string _PROJECT_RISKS_APPOINT;
		private string _LIABILITY_RISKS_NAME;
		private string _LIABILITY_RISKS_APPOINT;
		private decimal? _LIQUIDATED_DAMAGES1;
		private decimal? _LIQUIDATED_DAMAGES2;
		private decimal? _LIQUIDATED_DAMAGES3;
		private decimal? _LIQUIDATED_DAMAGES4;
		private decimal? _LIQUIDATED_DAMAGES5;
		private decimal? _LIQUIDATED_DAMAGES6;
		private decimal? _LIQUIDATED_DAMAGES7;
		private decimal? _LIQUIDATED_DAMAGES8;
		private string _KEY_CONST_EQUIPMENT;
		private decimal? _KEY_EQUIPMENT_AMOUNT;
		private decimal? _OTHER_EQUIPMENT_AMOUNT;
		private string _IF_CONSTRUCTOR;
		private string _ENCLOSURE1;
		private string _ENCLOSURE2;
		private string _ENCLOSURE3;
		private string _FUND_IMPLEMENTATION;
		private decimal? _TOTAL_SECTION_NUMBER;
		private decimal? _TENDERER_BID_SECTION;
		private decimal? _TENDER_NUMBER;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private DateTime? _MARGIN_TIME;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_PHONE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private string _QUALITY_REQUIRE1;
		private string _QUALITY_REQUIRE2;
		private string _SECURITY_SELECTION;
		private string _SOCIAL_SECURITY_REQUIRE;
		private string _SUBCONTRACT;
		private string _MODIFICATION_TIME;
		private string _INTEREST_MODE;
		private string _INTEREST_REQUIRE;
		private string _ANNUAL_DEPOSIT_REQUIRE;
		private DateTime? _BRIBERY_RECORD_YEAR;
		private DateTime? _LITIGATION_REQUIRE;
		private decimal? _COPY_NUMBER;
		private string _TENDER_OFFER_REQUIRE;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_LIBRARY;
		private decimal? _WINNING_BIDDER_NUMBER;
		private decimal? _BOND_PRICE;
		private decimal? _SIGN_CONTRACT_TIME;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _QUALIFICATION_REQUIRE;
		private string _OTHER_QUALIFICATION_REQUIRE;
		private string _EQUIPMENT_REQUIRE;
		private string _EVALUATING_METHOD_STANDARD;
		private decimal? _E1_SCORE;
		private decimal? _E2_SCORE;
		private string _CREDIT_REQUIRE;
		private string _DISPUTE_DEAL_METHOD;
		private string _ARB_COMMISSION_NAME;
		private string _SUBC_NAME;
		private string _SUBC_NAME_ADDRESS;
		private decimal? _SUBC_ZIP_CODE;
		private decimal? _DEFECT_LIABILITY_PERIOD1;
		private decimal? _DRAWING_MODIFICATION;
		private string _PROVIDE_MATERIALS;
		private string _MATERIAL_REGULATION;
		private string _SUPPLY_EQUIPMENT;
		private string _EQUIPMEN_REGULATION;
		private decimal? _DATA_PERIOD;
		private decimal? _APPROVAL_PERIOD;
		private decimal? _DELAY_PENALTY;
		private decimal? _PENALTY_QUOTA;
		private decimal? _COMPLETION_BONUS;
		private decimal? _BONUS_LIMIT;
		private decimal? _COST_SAVING;
		private decimal? _INCREASE_INCOME;
		private decimal? _ADVANCE_AMOUNT;
		private string _MATERIAL;
		private decimal? _DOCUMENT_CHARGES;
		private decimal? _SUBMIT_REQUISITION;
		private decimal? _MONTHLY_PAYMENT;
		private decimal? _QUALITY_MARGIN_LIMIT;
		private decimal? _PAYMENT_APPLICATION;
		private decimal? _APPLICATION_NUM;
		private decimal? _COMPLETION_DATA;
		private string _CONSTRUCTION_PERIOD_OPERATION;
		private string _OPERATING_REGULATIONS;
		private string _TEST_RUN;
		private string _TEST_RUN_REGULATIONS;
		private decimal? _DEFECTS_LIABILITY_PERIOD;
		private decimal? _PREMIUM_RATE1;
		private decimal? _MINIMUM_INSURANCE_AMOUNT;
		private decimal? _PREMIUM_RATE2;
		private string _BILL_OF_QUANTITIES;
		private string _DRAWING;
		private string _TECHNICAL_SPECIFICATIONS;
		private string _SUPPLY_TECHNICAL_STANDARD;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _MINIMUM_LIMIT;
		private string _CONTRACT_SEGMENT;
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
		/// 到场持有证件
		/// </summary>
		public string OPEN_BID_REQURE_CERT
		{
			get{ return _OPEN_BID_REQURE_CERT; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_BID_REQURE_CERT, _OPEN_BID_REQURE_CERT, value);
				this._OPEN_BID_REQURE_CERT = value;
			}
		}
		/// <summary>
		/// 财务年份要求
		/// </summary>
		public string FINANCE_YEAR
		{
			get{ return _FINANCE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_YEAR, _FINANCE_YEAR, value);
				this._FINANCE_YEAR = value;
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
		/// 专职人员人数
		/// </summary>
		public decimal? SECURITY_SELECTION_NUM
		{
			get{ return _SECURITY_SELECTION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.SECURITY_SELECTION_NUM, _SECURITY_SELECTION_NUM, value);
				this._SECURITY_SELECTION_NUM = value;
			}
		}
		/// <summary>
		/// 专职人员年龄
		/// </summary>
		public decimal? SECURITY_SELECTION_AGE
		{
			get{ return _SECURITY_SELECTION_AGE; }
			set
			{
				this.OnPropertyValueChange(_.SECURITY_SELECTION_AGE, _SECURITY_SELECTION_AGE, value);
				this._SECURITY_SELECTION_AGE = value;
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
		/// 承包人补充条款
		/// </summary>
		public string CONTR_SUPPLE_CLAUSE
		{
			get{ return _CONTR_SUPPLE_CLAUSE; }
			set
			{
				this.OnPropertyValueChange(_.CONTR_SUPPLE_CLAUSE, _CONTR_SUPPLE_CLAUSE, value);
				this._CONTR_SUPPLE_CLAUSE = value;
			}
		}
		/// <summary>
		/// 准化建设内容及验收标准要求
		/// </summary>
		public string STANDARD_REQUIRE
		{
			get{ return _STANDARD_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.STANDARD_REQUIRE, _STANDARD_REQUIRE, value);
				this._STANDARD_REQUIRE = value;
			}
		}
		/// <summary>
		/// 工程质量细化内容
		/// </summary>
		public string ENGINEER_QUALITY_REQUIRE
		{
			get{ return _ENGINEER_QUALITY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEER_QUALITY_REQUIRE, _ENGINEER_QUALITY_REQUIRE, value);
				this._ENGINEER_QUALITY_REQUIRE = value;
			}
		}
		/// <summary>
		/// 暂列金额细化内容
		/// </summary>
		public string PROVI_SUM
		{
			get{ return _PROVI_SUM; }
			set
			{
				this.OnPropertyValueChange(_.PROVI_SUM, _PROVI_SUM, value);
				this._PROVI_SUM = value;
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
		/// 预付款细化内容
		/// </summary>
		public string ADVANCE_AMOUNT_CONTENT
		{
			get{ return _ADVANCE_AMOUNT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.ADVANCE_AMOUNT_CONTENT, _ADVANCE_AMOUNT_CONTENT, value);
				this._ADVANCE_AMOUNT_CONTENT = value;
			}
		}
		/// <summary>
		/// 投保建筑工程一切险名义
		/// </summary>
		public string PROJECT_RISKS_NAME
		{
			get{ return _PROJECT_RISKS_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_RISKS_NAME, _PROJECT_RISKS_NAME, value);
				this._PROJECT_RISKS_NAME = value;
			}
		}
		/// <summary>
		/// 投保建筑工程一切险的其他约定
		/// </summary>
		public string PROJECT_RISKS_APPOINT
		{
			get{ return _PROJECT_RISKS_APPOINT; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_RISKS_APPOINT, _PROJECT_RISKS_APPOINT, value);
				this._PROJECT_RISKS_APPOINT = value;
			}
		}
		/// <summary>
		/// 投保第三方责任险名义
		/// </summary>
		public string LIABILITY_RISKS_NAME
		{
			get{ return _LIABILITY_RISKS_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LIABILITY_RISKS_NAME, _LIABILITY_RISKS_NAME, value);
				this._LIABILITY_RISKS_NAME = value;
			}
		}
		/// <summary>
		/// 投保第三方责任险的其他约定
		/// </summary>
		public string LIABILITY_RISKS_APPOINT
		{
			get{ return _LIABILITY_RISKS_APPOINT; }
			set
			{
				this.OnPropertyValueChange(_.LIABILITY_RISKS_APPOINT, _LIABILITY_RISKS_APPOINT, value);
				this._LIABILITY_RISKS_APPOINT = value;
			}
		}
		/// <summary>
		/// 更换为项目经理备选人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES1
		{
			get{ return _LIQUIDATED_DAMAGES1; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES1, _LIQUIDATED_DAMAGES1, value);
				this._LIQUIDATED_DAMAGES1 = value;
			}
		}
		/// <summary>
		/// 更换为技术负责人备选人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES2
		{
			get{ return _LIQUIDATED_DAMAGES2; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES2, _LIQUIDATED_DAMAGES2, value);
				this._LIQUIDATED_DAMAGES2 = value;
			}
		}
		/// <summary>
		/// 评标时更换为项目经理备选人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES3
		{
			get{ return _LIQUIDATED_DAMAGES3; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES3, _LIQUIDATED_DAMAGES3, value);
				this._LIQUIDATED_DAMAGES3 = value;
			}
		}
		/// <summary>
		/// 评标时更换为技术负责人备选人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES4
		{
			get{ return _LIQUIDATED_DAMAGES4; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES4, _LIQUIDATED_DAMAGES4, value);
				this._LIQUIDATED_DAMAGES4 = value;
			}
		}
		/// <summary>
		/// 更换为项目经理其他同等资历人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES5
		{
			get{ return _LIQUIDATED_DAMAGES5; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES5, _LIQUIDATED_DAMAGES5, value);
				this._LIQUIDATED_DAMAGES5 = value;
			}
		}
		/// <summary>
		/// 更换为技术负责人其他同等资历人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES6
		{
			get{ return _LIQUIDATED_DAMAGES6; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES6, _LIQUIDATED_DAMAGES6, value);
				this._LIQUIDATED_DAMAGES6 = value;
			}
		}
		/// <summary>
		/// 评标时更换为项目经理其他同等资历人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES7
		{
			get{ return _LIQUIDATED_DAMAGES7; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES7, _LIQUIDATED_DAMAGES7, value);
				this._LIQUIDATED_DAMAGES7 = value;
			}
		}
		/// <summary>
		/// 评标时更换为技术负责人其他同等资历人员违约金
		/// </summary>
		public decimal? LIQUIDATED_DAMAGES8
		{
			get{ return _LIQUIDATED_DAMAGES8; }
			set
			{
				this.OnPropertyValueChange(_.LIQUIDATED_DAMAGES8, _LIQUIDATED_DAMAGES8, value);
				this._LIQUIDATED_DAMAGES8 = value;
			}
		}
		/// <summary>
		/// 关键施工设备
		/// </summary>
		public string KEY_CONST_EQUIPMENT
		{
			get{ return _KEY_CONST_EQUIPMENT; }
			set
			{
				this.OnPropertyValueChange(_.KEY_CONST_EQUIPMENT, _KEY_CONST_EQUIPMENT, value);
				this._KEY_CONST_EQUIPMENT = value;
			}
		}
		/// <summary>
		/// 支付关键施工设备违约金
		/// </summary>
		public decimal? KEY_EQUIPMENT_AMOUNT
		{
			get{ return _KEY_EQUIPMENT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.KEY_EQUIPMENT_AMOUNT, _KEY_EQUIPMENT_AMOUNT, value);
				this._KEY_EQUIPMENT_AMOUNT = value;
			}
		}
		/// <summary>
		/// 支付其他主要设备违约金
		/// </summary>
		public decimal? OTHER_EQUIPMENT_AMOUNT
		{
			get{ return _OTHER_EQUIPMENT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_EQUIPMENT_AMOUNT, _OTHER_EQUIPMENT_AMOUNT, value);
				this._OTHER_EQUIPMENT_AMOUNT = value;
			}
		}
		/// <summary>
		/// 项目经理是否有注册建造师职称
		/// </summary>
		public string IF_CONSTRUCTOR
		{
			get{ return _IF_CONSTRUCTOR; }
			set
			{
				this.OnPropertyValueChange(_.IF_CONSTRUCTOR, _IF_CONSTRUCTOR, value);
				this._IF_CONSTRUCTOR = value;
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
		/// 每个投标人最多中标标段数
		/// </summary>
		public decimal? TENDER_NUMBER
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
		/// 本项目工程质量目标为交工验收质量评定
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
		/// 专职安全人员类型
		/// </summary>
		public string SECURITY_SELECTION
		{
			get{ return _SECURITY_SELECTION; }
			set
			{
				this.OnPropertyValueChange(_.SECURITY_SELECTION, _SECURITY_SELECTION, value);
				this._SECURITY_SELECTION = value;
			}
		}
		/// <summary>
		/// 人员社保要求
		/// </summary>
		public string SOCIAL_SECURITY_REQUIRE
		{
			get{ return _SOCIAL_SECURITY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SOCIAL_SECURITY_REQUIRE, _SOCIAL_SECURITY_REQUIRE, value);
				this._SOCIAL_SECURITY_REQUIRE = value;
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
		/// 利息约定
		/// </summary>
		public string INTEREST_REQUIRE
		{
			get{ return _INTEREST_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.INTEREST_REQUIRE, _INTEREST_REQUIRE, value);
				this._INTEREST_REQUIRE = value;
			}
		}
		/// <summary>
		/// 年度保证金
		/// </summary>
		public string ANNUAL_DEPOSIT_REQUIRE
		{
			get{ return _ANNUAL_DEPOSIT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.ANNUAL_DEPOSIT_REQUIRE, _ANNUAL_DEPOSIT_REQUIRE, value);
				this._ANNUAL_DEPOSIT_REQUIRE = value;
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
		/// 近年发生的诉讼及仲裁情况的年份要求
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
		/// 投标报价补充条款
		/// </summary>
		public string TENDER_OFFER_REQUIRE
		{
			get{ return _TENDER_OFFER_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_OFFER_REQUIRE, _TENDER_OFFER_REQUIRE, value);
				this._TENDER_OFFER_REQUIRE = value;
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
		/// 评标委员会确定中标人数
		/// </summary>
		public decimal? WINNING_BIDDER_NUMBER
		{
			get{ return _WINNING_BIDDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.WINNING_BIDDER_NUMBER, _WINNING_BIDDER_NUMBER, value);
				this._WINNING_BIDDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 履约担保金额
		/// </summary>
		public decimal? BOND_PRICE
		{
			get{ return _BOND_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BOND_PRICE, _BOND_PRICE, value);
				this._BOND_PRICE = value;
			}
		}
		/// <summary>
		/// 订立书面合同的时间为中标通知书发出后的天数
		/// </summary>
		public decimal? SIGN_CONTRACT_TIME
		{
			get{ return _SIGN_CONTRACT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_CONTRACT_TIME, _SIGN_CONTRACT_TIME, value);
				this._SIGN_CONTRACT_TIME = value;
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
		/// 项目经理、技术负责人、专职安全工程员最低要求
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
		/// E1值
		/// </summary>
		public decimal? E1_SCORE
		{
			get{ return _E1_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.E1_SCORE, _E1_SCORE, value);
				this._E1_SCORE = value;
			}
		}
		/// <summary>
		/// E2值
		/// </summary>
		public decimal? E2_SCORE
		{
			get{ return _E2_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.E2_SCORE, _E2_SCORE, value);
				this._E2_SCORE = value;
			}
		}
		/// <summary>
		/// 信用分使用要求
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
		/// 图纸修改和补充应在施工前
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
		/// 发包人是否提供材料或工程设备
		/// </summary>
		public string PROVIDE_MATERIALS
		{
			get{ return _PROVIDE_MATERIALS; }
			set
			{
				this.OnPropertyValueChange(_.PROVIDE_MATERIALS, _PROVIDE_MATERIALS, value);
				this._PROVIDE_MATERIALS = value;
			}
		}
		/// <summary>
		/// 提供材料或工程设备相关规定
		/// </summary>
		public string MATERIAL_REGULATION
		{
			get{ return _MATERIAL_REGULATION; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL_REGULATION, _MATERIAL_REGULATION, value);
				this._MATERIAL_REGULATION = value;
			}
		}
		/// <summary>
		/// 发包人是否提供施工设备或临时设施
		/// </summary>
		public string SUPPLY_EQUIPMENT
		{
			get{ return _SUPPLY_EQUIPMENT; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_EQUIPMENT, _SUPPLY_EQUIPMENT, value);
				this._SUPPLY_EQUIPMENT = value;
			}
		}
		/// <summary>
		/// 发包人提供临时设施相关规定
		/// </summary>
		public string EQUIPMEN_REGULATION
		{
			get{ return _EQUIPMEN_REGULATION; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMEN_REGULATION, _EQUIPMEN_REGULATION, value);
				this._EQUIPMEN_REGULATION = value;
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
		/// 工期延误的违约金
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
		/// 逾期交工违约金限额
		/// </summary>
		public decimal? PENALTY_QUOTA
		{
			get{ return _PENALTY_QUOTA; }
			set
			{
				this.OnPropertyValueChange(_.PENALTY_QUOTA, _PENALTY_QUOTA, value);
				this._PENALTY_QUOTA = value;
			}
		}
		/// <summary>
		/// 提前交工的奖金
		/// </summary>
		public decimal? COMPLETION_BONUS
		{
			get{ return _COMPLETION_BONUS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLETION_BONUS, _COMPLETION_BONUS, value);
				this._COMPLETION_BONUS = value;
			}
		}
		/// <summary>
		/// 提前交工的奖金限额
		/// </summary>
		public decimal? BONUS_LIMIT
		{
			get{ return _BONUS_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.BONUS_LIMIT, _BONUS_LIMIT, value);
				this._BONUS_LIMIT = value;
			}
		}
		/// <summary>
		/// 发包人给予奖励按所节约成本
		/// </summary>
		public decimal? COST_SAVING
		{
			get{ return _COST_SAVING; }
			set
			{
				this.OnPropertyValueChange(_.COST_SAVING, _COST_SAVING, value);
				this._COST_SAVING = value;
			}
		}
		/// <summary>
		/// 发包人给予奖励按增加收益
		/// </summary>
		public decimal? INCREASE_INCOME
		{
			get{ return _INCREASE_INCOME; }
			set
			{
				this.OnPropertyValueChange(_.INCREASE_INCOME, _INCREASE_INCOME, value);
				this._INCREASE_INCOME = value;
			}
		}
		/// <summary>
		/// 开工预付款金额为签约合同价
		/// </summary>
		public decimal? ADVANCE_AMOUNT
		{
			get{ return _ADVANCE_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.ADVANCE_AMOUNT, _ADVANCE_AMOUNT, value);
				this._ADVANCE_AMOUNT = value;
			}
		}
		/// <summary>
		/// 材料名称
		/// </summary>
		public string MATERIAL
		{
			get{ return _MATERIAL; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL, _MATERIAL, value);
				this._MATERIAL = value;
			}
		}
		/// <summary>
		/// 按单据所列费用
		/// </summary>
		public decimal? DOCUMENT_CHARGES
		{
			get{ return _DOCUMENT_CHARGES; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CHARGES, _DOCUMENT_CHARGES, value);
				this._DOCUMENT_CHARGES = value;
			}
		}
		/// <summary>
		/// 承包人每个付款周期提交的申请单份数
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
		/// 质量保证金百分比为月支付额
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
		/// 质量保证金限额为合同价格
		/// </summary>
		public decimal? QUALITY_MARGIN_LIMIT
		{
			get{ return _QUALITY_MARGIN_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_MARGIN_LIMIT, _QUALITY_MARGIN_LIMIT, value);
				this._QUALITY_MARGIN_LIMIT = value;
			}
		}
		/// <summary>
		/// 承包人提交交工付款申请单的份数
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
		/// 需要施工期运行的规定
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
		/// 是否进行试运行
		/// </summary>
		public string TEST_RUN
		{
			get{ return _TEST_RUN; }
			set
			{
				this.OnPropertyValueChange(_.TEST_RUN, _TEST_RUN, value);
				this._TEST_RUN = value;
			}
		}
		/// <summary>
		/// 试运行的具体规定
		/// </summary>
		public string TEST_RUN_REGULATIONS
		{
			get{ return _TEST_RUN_REGULATIONS; }
			set
			{
				this.OnPropertyValueChange(_.TEST_RUN_REGULATIONS, _TEST_RUN_REGULATIONS, value);
				this._TEST_RUN_REGULATIONS = value;
			}
		}
		/// <summary>
		/// 保修期
		/// </summary>
		public decimal? DEFECTS_LIABILITY_PERIOD
		{
			get{ return _DEFECTS_LIABILITY_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.DEFECTS_LIABILITY_PERIOD, _DEFECTS_LIABILITY_PERIOD, value);
				this._DEFECTS_LIABILITY_PERIOD = value;
			}
		}
		/// <summary>
		/// 建筑工程一切险的保险费率
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
		/// 第三者责任险的最低投保金额
		/// </summary>
		public decimal? MINIMUM_INSURANCE_AMOUNT
		{
			get{ return _MINIMUM_INSURANCE_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_INSURANCE_AMOUNT, _MINIMUM_INSURANCE_AMOUNT, value);
				this._MINIMUM_INSURANCE_AMOUNT = value;
			}
		}
		/// <summary>
		/// 保险费率
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
				_.DEFECT_LIABILITY_PERIOD,
				_.BEGIN_ALL_DATE,
				_.END_DATE,
				_.LIMITE_TIME_UNIT,
				_.SYNDICATED_NUMBER,
				_.OPEN_BID_REQURE_CHOOSE,
				_.OPEN_BID_REQURE_CERT,
				_.FINANCE_YEAR,
				_.REPUTATION_TIME1,
				_.REPUTATION_TIME2,
				_.MANAGER_TITLE,
				_.MANAGER_TITLE_LEVEL,
				_.MANAGER_AGE,
				_.CONSTRUCTOR_MAJOR,
				_.CONSTRUCTOR_MAJOR_LEVEL,
				_.TECH_TITLE,
				_.TECH_TITLE_LEVEL,
				_.TECH_AGE,
				_.SECURITY_SELECTION_NUM,
				_.SECURITY_SELECTION_AGE,
				_.MATERIAL_PRICE_ADJUSTED,
				_.CONTR_SUPPLE_CLAUSE,
				_.STANDARD_REQUIRE,
				_.ENGINEER_QUALITY_REQUIRE,
				_.PROVI_SUM,
				_.BASE_PRICE_CITY,
				_.RELEASE_PRICE_CITY,
				_.NO_RELEASE_PRICE_CITY,
				_.ADVANCE_AMOUNT_CONTENT,
				_.PROJECT_RISKS_NAME,
				_.PROJECT_RISKS_APPOINT,
				_.LIABILITY_RISKS_NAME,
				_.LIABILITY_RISKS_APPOINT,
				_.LIQUIDATED_DAMAGES1,
				_.LIQUIDATED_DAMAGES2,
				_.LIQUIDATED_DAMAGES3,
				_.LIQUIDATED_DAMAGES4,
				_.LIQUIDATED_DAMAGES5,
				_.LIQUIDATED_DAMAGES6,
				_.LIQUIDATED_DAMAGES7,
				_.LIQUIDATED_DAMAGES8,
				_.KEY_CONST_EQUIPMENT,
				_.KEY_EQUIPMENT_AMOUNT,
				_.OTHER_EQUIPMENT_AMOUNT,
				_.IF_CONSTRUCTOR,
				_.ENCLOSURE1,
				_.ENCLOSURE2,
				_.ENCLOSURE3,
				_.FUND_IMPLEMENTATION,
				_.TOTAL_SECTION_NUMBER,
				_.TENDERER_BID_SECTION,
				_.TENDER_NUMBER,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.MARGIN_TIME,
				_.MEDIA1,
				_.MEDIA2,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_PHONE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.QUALITY_REQUIRE1,
				_.QUALITY_REQUIRE2,
				_.SECURITY_SELECTION,
				_.SOCIAL_SECURITY_REQUIRE,
				_.SUBCONTRACT,
				_.MODIFICATION_TIME,
				_.INTEREST_MODE,
				_.INTEREST_REQUIRE,
				_.ANNUAL_DEPOSIT_REQUIRE,
				_.BRIBERY_RECORD_YEAR,
				_.LITIGATION_REQUIRE,
				_.COPY_NUMBER,
				_.TENDER_OFFER_REQUIRE,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_LIBRARY,
				_.WINNING_BIDDER_NUMBER,
				_.BOND_PRICE,
				_.SIGN_CONTRACT_TIME,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.QUALIFICATION_REQUIRE,
				_.OTHER_QUALIFICATION_REQUIRE,
				_.EQUIPMENT_REQUIRE,
				_.EVALUATING_METHOD_STANDARD,
				_.E1_SCORE,
				_.E2_SCORE,
				_.CREDIT_REQUIRE,
				_.DISPUTE_DEAL_METHOD,
				_.ARB_COMMISSION_NAME,
				_.SUBC_NAME,
				_.SUBC_NAME_ADDRESS,
				_.SUBC_ZIP_CODE,
				_.DEFECT_LIABILITY_PERIOD1,
				_.DRAWING_MODIFICATION,
				_.PROVIDE_MATERIALS,
				_.MATERIAL_REGULATION,
				_.SUPPLY_EQUIPMENT,
				_.EQUIPMEN_REGULATION,
				_.DATA_PERIOD,
				_.APPROVAL_PERIOD,
				_.DELAY_PENALTY,
				_.PENALTY_QUOTA,
				_.COMPLETION_BONUS,
				_.BONUS_LIMIT,
				_.COST_SAVING,
				_.INCREASE_INCOME,
				_.ADVANCE_AMOUNT,
				_.MATERIAL,
				_.DOCUMENT_CHARGES,
				_.SUBMIT_REQUISITION,
				_.MONTHLY_PAYMENT,
				_.QUALITY_MARGIN_LIMIT,
				_.PAYMENT_APPLICATION,
				_.APPLICATION_NUM,
				_.COMPLETION_DATA,
				_.CONSTRUCTION_PERIOD_OPERATION,
				_.OPERATING_REGULATIONS,
				_.TEST_RUN,
				_.TEST_RUN_REGULATIONS,
				_.DEFECTS_LIABILITY_PERIOD,
				_.PREMIUM_RATE1,
				_.MINIMUM_INSURANCE_AMOUNT,
				_.PREMIUM_RATE2,
				_.BILL_OF_QUANTITIES,
				_.DRAWING,
				_.TECHNICAL_SPECIFICATIONS,
				_.SUPPLY_TECHNICAL_STANDARD,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.MINIMUM_LIMIT,
				_.CONTRACT_SEGMENT,
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
				this._DEFECT_LIABILITY_PERIOD,
				this._BEGIN_ALL_DATE,
				this._END_DATE,
				this._LIMITE_TIME_UNIT,
				this._SYNDICATED_NUMBER,
				this._OPEN_BID_REQURE_CHOOSE,
				this._OPEN_BID_REQURE_CERT,
				this._FINANCE_YEAR,
				this._REPUTATION_TIME1,
				this._REPUTATION_TIME2,
				this._MANAGER_TITLE,
				this._MANAGER_TITLE_LEVEL,
				this._MANAGER_AGE,
				this._CONSTRUCTOR_MAJOR,
				this._CONSTRUCTOR_MAJOR_LEVEL,
				this._TECH_TITLE,
				this._TECH_TITLE_LEVEL,
				this._TECH_AGE,
				this._SECURITY_SELECTION_NUM,
				this._SECURITY_SELECTION_AGE,
				this._MATERIAL_PRICE_ADJUSTED,
				this._CONTR_SUPPLE_CLAUSE,
				this._STANDARD_REQUIRE,
				this._ENGINEER_QUALITY_REQUIRE,
				this._PROVI_SUM,
				this._BASE_PRICE_CITY,
				this._RELEASE_PRICE_CITY,
				this._NO_RELEASE_PRICE_CITY,
				this._ADVANCE_AMOUNT_CONTENT,
				this._PROJECT_RISKS_NAME,
				this._PROJECT_RISKS_APPOINT,
				this._LIABILITY_RISKS_NAME,
				this._LIABILITY_RISKS_APPOINT,
				this._LIQUIDATED_DAMAGES1,
				this._LIQUIDATED_DAMAGES2,
				this._LIQUIDATED_DAMAGES3,
				this._LIQUIDATED_DAMAGES4,
				this._LIQUIDATED_DAMAGES5,
				this._LIQUIDATED_DAMAGES6,
				this._LIQUIDATED_DAMAGES7,
				this._LIQUIDATED_DAMAGES8,
				this._KEY_CONST_EQUIPMENT,
				this._KEY_EQUIPMENT_AMOUNT,
				this._OTHER_EQUIPMENT_AMOUNT,
				this._IF_CONSTRUCTOR,
				this._ENCLOSURE1,
				this._ENCLOSURE2,
				this._ENCLOSURE3,
				this._FUND_IMPLEMENTATION,
				this._TOTAL_SECTION_NUMBER,
				this._TENDERER_BID_SECTION,
				this._TENDER_NUMBER,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._MARGIN_TIME,
				this._MEDIA1,
				this._MEDIA2,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_PHONE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._QUALITY_REQUIRE1,
				this._QUALITY_REQUIRE2,
				this._SECURITY_SELECTION,
				this._SOCIAL_SECURITY_REQUIRE,
				this._SUBCONTRACT,
				this._MODIFICATION_TIME,
				this._INTEREST_MODE,
				this._INTEREST_REQUIRE,
				this._ANNUAL_DEPOSIT_REQUIRE,
				this._BRIBERY_RECORD_YEAR,
				this._LITIGATION_REQUIRE,
				this._COPY_NUMBER,
				this._TENDER_OFFER_REQUIRE,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_LIBRARY,
				this._WINNING_BIDDER_NUMBER,
				this._BOND_PRICE,
				this._SIGN_CONTRACT_TIME,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._QUALIFICATION_REQUIRE,
				this._OTHER_QUALIFICATION_REQUIRE,
				this._EQUIPMENT_REQUIRE,
				this._EVALUATING_METHOD_STANDARD,
				this._E1_SCORE,
				this._E2_SCORE,
				this._CREDIT_REQUIRE,
				this._DISPUTE_DEAL_METHOD,
				this._ARB_COMMISSION_NAME,
				this._SUBC_NAME,
				this._SUBC_NAME_ADDRESS,
				this._SUBC_ZIP_CODE,
				this._DEFECT_LIABILITY_PERIOD1,
				this._DRAWING_MODIFICATION,
				this._PROVIDE_MATERIALS,
				this._MATERIAL_REGULATION,
				this._SUPPLY_EQUIPMENT,
				this._EQUIPMEN_REGULATION,
				this._DATA_PERIOD,
				this._APPROVAL_PERIOD,
				this._DELAY_PENALTY,
				this._PENALTY_QUOTA,
				this._COMPLETION_BONUS,
				this._BONUS_LIMIT,
				this._COST_SAVING,
				this._INCREASE_INCOME,
				this._ADVANCE_AMOUNT,
				this._MATERIAL,
				this._DOCUMENT_CHARGES,
				this._SUBMIT_REQUISITION,
				this._MONTHLY_PAYMENT,
				this._QUALITY_MARGIN_LIMIT,
				this._PAYMENT_APPLICATION,
				this._APPLICATION_NUM,
				this._COMPLETION_DATA,
				this._CONSTRUCTION_PERIOD_OPERATION,
				this._OPERATING_REGULATIONS,
				this._TEST_RUN,
				this._TEST_RUN_REGULATIONS,
				this._DEFECTS_LIABILITY_PERIOD,
				this._PREMIUM_RATE1,
				this._MINIMUM_INSURANCE_AMOUNT,
				this._PREMIUM_RATE2,
				this._BILL_OF_QUANTITIES,
				this._DRAWING,
				this._TECHNICAL_SPECIFICATIONS,
				this._SUPPLY_TECHNICAL_STANDARD,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._MINIMUM_LIMIT,
				this._CONTRACT_SEGMENT,
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
			public readonly static Field All = new Field("*", "JT_ORD_MAIN_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_ORD_MAIN_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_ORD_MAIN_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD = new Field("DEFECT_LIABILITY_PERIOD", "JT_ORD_MAIN_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 总计划开工日期
			/// </summary>
			public readonly static Field BEGIN_ALL_DATE = new Field("BEGIN_ALL_DATE", "JT_ORD_MAIN_TENDER_FILE", "总计划开工日期");
            /// <summary>
			/// 计划交工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "JT_ORD_MAIN_TENDER_FILE", "计划交工日期");
            /// <summary>
			/// 工期单位
			/// </summary>
			public readonly static Field LIMITE_TIME_UNIT = new Field("LIMITE_TIME_UNIT", "JT_ORD_MAIN_TENDER_FILE", "工期单位");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field SYNDICATED_NUMBER = new Field("SYNDICATED_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 是否需要人员到场
			/// </summary>
			public readonly static Field OPEN_BID_REQURE_CHOOSE = new Field("OPEN_BID_REQURE_CHOOSE", "JT_ORD_MAIN_TENDER_FILE", "是否需要人员到场");
            /// <summary>
			/// 到场持有证件
			/// </summary>
			public readonly static Field OPEN_BID_REQURE_CERT = new Field("OPEN_BID_REQURE_CERT", "JT_ORD_MAIN_TENDER_FILE", "到场持有证件");
            /// <summary>
			/// 财务年份要求
			/// </summary>
			public readonly static Field FINANCE_YEAR = new Field("FINANCE_YEAR", "JT_ORD_MAIN_TENDER_FILE", "财务年份要求");
            /// <summary>
			/// 未发生安全事故的时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME1 = new Field("REPUTATION_TIME1", "JT_ORD_MAIN_TENDER_FILE", "未发生安全事故的时间要求");
            /// <summary>
			/// 未出现不良记录时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME2 = new Field("REPUTATION_TIME2", "JT_ORD_MAIN_TENDER_FILE", "未出现不良记录时间要求");
            /// <summary>
			/// 项目经理职称专业
			/// </summary>
			public readonly static Field MANAGER_TITLE = new Field("MANAGER_TITLE", "JT_ORD_MAIN_TENDER_FILE", "项目经理职称专业");
            /// <summary>
			/// 项目经理职称等级
			/// </summary>
			public readonly static Field MANAGER_TITLE_LEVEL = new Field("MANAGER_TITLE_LEVEL", "JT_ORD_MAIN_TENDER_FILE", "项目经理职称等级");
            /// <summary>
			/// 项目经理年龄
			/// </summary>
			public readonly static Field MANAGER_AGE = new Field("MANAGER_AGE", "JT_ORD_MAIN_TENDER_FILE", "项目经理年龄");
            /// <summary>
			/// 注册建造师专业名称
			/// </summary>
			public readonly static Field CONSTRUCTOR_MAJOR = new Field("CONSTRUCTOR_MAJOR", "JT_ORD_MAIN_TENDER_FILE", "注册建造师专业名称");
            /// <summary>
			/// 注册建造师等级
			/// </summary>
			public readonly static Field CONSTRUCTOR_MAJOR_LEVEL = new Field("CONSTRUCTOR_MAJOR_LEVEL", "JT_ORD_MAIN_TENDER_FILE", "注册建造师等级");
            /// <summary>
			/// 技术负责人职称专业
			/// </summary>
			public readonly static Field TECH_TITLE = new Field("TECH_TITLE", "JT_ORD_MAIN_TENDER_FILE", "技术负责人职称专业");
            /// <summary>
			/// 技术负责人职称等级
			/// </summary>
			public readonly static Field TECH_TITLE_LEVEL = new Field("TECH_TITLE_LEVEL", "JT_ORD_MAIN_TENDER_FILE", "技术负责人职称等级");
            /// <summary>
			/// 技术负责人年龄
			/// </summary>
			public readonly static Field TECH_AGE = new Field("TECH_AGE", "JT_ORD_MAIN_TENDER_FILE", "技术负责人年龄");
            /// <summary>
			/// 专职人员人数
			/// </summary>
			public readonly static Field SECURITY_SELECTION_NUM = new Field("SECURITY_SELECTION_NUM", "JT_ORD_MAIN_TENDER_FILE", "专职人员人数");
            /// <summary>
			/// 专职人员年龄
			/// </summary>
			public readonly static Field SECURITY_SELECTION_AGE = new Field("SECURITY_SELECTION_AGE", "JT_ORD_MAIN_TENDER_FILE", "专职人员年龄");
            /// <summary>
			/// 材料价格是否调整
			/// </summary>
			public readonly static Field MATERIAL_PRICE_ADJUSTED = new Field("MATERIAL_PRICE_ADJUSTED", "JT_ORD_MAIN_TENDER_FILE", "材料价格是否调整");
            /// <summary>
			/// 承包人补充条款
			/// </summary>
			public readonly static Field CONTR_SUPPLE_CLAUSE = new Field("CONTR_SUPPLE_CLAUSE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "承包人补充条款");
            /// <summary>
			/// 准化建设内容及验收标准要求
			/// </summary>
			public readonly static Field STANDARD_REQUIRE = new Field("STANDARD_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "准化建设内容及验收标准要求");
            /// <summary>
			/// 工程质量细化内容
			/// </summary>
			public readonly static Field ENGINEER_QUALITY_REQUIRE = new Field("ENGINEER_QUALITY_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "工程质量细化内容");
            /// <summary>
			/// 暂列金额细化内容
			/// </summary>
			public readonly static Field PROVI_SUM = new Field("PROVI_SUM", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "暂列金额细化内容");
            /// <summary>
			/// 基期价格参考城市
			/// </summary>
			public readonly static Field BASE_PRICE_CITY = new Field("BASE_PRICE_CITY", "JT_ORD_MAIN_TENDER_FILE", "基期价格参考城市");
            /// <summary>
			/// 发布价参考城市
			/// </summary>
			public readonly static Field RELEASE_PRICE_CITY = new Field("RELEASE_PRICE_CITY", "JT_ORD_MAIN_TENDER_FILE", "发布价参考城市");
            /// <summary>
			/// 未涉及材料发布价参考城市
			/// </summary>
			public readonly static Field NO_RELEASE_PRICE_CITY = new Field("NO_RELEASE_PRICE_CITY", "JT_ORD_MAIN_TENDER_FILE", "未涉及材料发布价参考城市");
            /// <summary>
			/// 预付款细化内容
			/// </summary>
			public readonly static Field ADVANCE_AMOUNT_CONTENT = new Field("ADVANCE_AMOUNT_CONTENT", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "预付款细化内容");
            /// <summary>
			/// 投保建筑工程一切险名义
			/// </summary>
			public readonly static Field PROJECT_RISKS_NAME = new Field("PROJECT_RISKS_NAME", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "投保建筑工程一切险名义");
            /// <summary>
			/// 投保建筑工程一切险的其他约定
			/// </summary>
			public readonly static Field PROJECT_RISKS_APPOINT = new Field("PROJECT_RISKS_APPOINT", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "投保建筑工程一切险的其他约定");
            /// <summary>
			/// 投保第三方责任险名义
			/// </summary>
			public readonly static Field LIABILITY_RISKS_NAME = new Field("LIABILITY_RISKS_NAME", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "投保第三方责任险名义");
            /// <summary>
			/// 投保第三方责任险的其他约定
			/// </summary>
			public readonly static Field LIABILITY_RISKS_APPOINT = new Field("LIABILITY_RISKS_APPOINT", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "投保第三方责任险的其他约定");
            /// <summary>
			/// 更换为项目经理备选人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES1 = new Field("LIQUIDATED_DAMAGES1", "JT_ORD_MAIN_TENDER_FILE", "更换为项目经理备选人员违约金");
            /// <summary>
			/// 更换为技术负责人备选人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES2 = new Field("LIQUIDATED_DAMAGES2", "JT_ORD_MAIN_TENDER_FILE", "更换为技术负责人备选人员违约金");
            /// <summary>
			/// 评标时更换为项目经理备选人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES3 = new Field("LIQUIDATED_DAMAGES3", "JT_ORD_MAIN_TENDER_FILE", "评标时更换为项目经理备选人员违约金");
            /// <summary>
			/// 评标时更换为技术负责人备选人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES4 = new Field("LIQUIDATED_DAMAGES4", "JT_ORD_MAIN_TENDER_FILE", "评标时更换为技术负责人备选人员违约金");
            /// <summary>
			/// 更换为项目经理其他同等资历人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES5 = new Field("LIQUIDATED_DAMAGES5", "JT_ORD_MAIN_TENDER_FILE", "更换为项目经理其他同等资历人员违约金");
            /// <summary>
			/// 更换为技术负责人其他同等资历人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES6 = new Field("LIQUIDATED_DAMAGES6", "JT_ORD_MAIN_TENDER_FILE", "更换为技术负责人其他同等资历人员违约金");
            /// <summary>
			/// 评标时更换为项目经理其他同等资历人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES7 = new Field("LIQUIDATED_DAMAGES7", "JT_ORD_MAIN_TENDER_FILE", "评标时更换为项目经理其他同等资历人员违约金");
            /// <summary>
			/// 评标时更换为技术负责人其他同等资历人员违约金
			/// </summary>
			public readonly static Field LIQUIDATED_DAMAGES8 = new Field("LIQUIDATED_DAMAGES8", "JT_ORD_MAIN_TENDER_FILE", "评标时更换为技术负责人其他同等资历人员违约金");
            /// <summary>
			/// 关键施工设备
			/// </summary>
			public readonly static Field KEY_CONST_EQUIPMENT = new Field("KEY_CONST_EQUIPMENT", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "关键施工设备");
            /// <summary>
			/// 支付关键施工设备违约金
			/// </summary>
			public readonly static Field KEY_EQUIPMENT_AMOUNT = new Field("KEY_EQUIPMENT_AMOUNT", "JT_ORD_MAIN_TENDER_FILE", "支付关键施工设备违约金");
            /// <summary>
			/// 支付其他主要设备违约金
			/// </summary>
			public readonly static Field OTHER_EQUIPMENT_AMOUNT = new Field("OTHER_EQUIPMENT_AMOUNT", "JT_ORD_MAIN_TENDER_FILE", "支付其他主要设备违约金");
            /// <summary>
			/// 项目经理是否有注册建造师职称
			/// </summary>
			public readonly static Field IF_CONSTRUCTOR = new Field("IF_CONSTRUCTOR", "JT_ORD_MAIN_TENDER_FILE", "项目经理是否有注册建造师职称");
            /// <summary>
			/// 标后监管指南
			/// </summary>
			public readonly static Field ENCLOSURE1 = new Field("ENCLOSURE1", "JT_ORD_MAIN_TENDER_FILE", "标后监管指南");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field ENCLOSURE2 = new Field("ENCLOSURE2", "JT_ORD_MAIN_TENDER_FILE", "招标代理合同");
            /// <summary>
			/// 招标人授权招标代理签章协议书
			/// </summary>
			public readonly static Field ENCLOSURE3 = new Field("ENCLOSURE3", "JT_ORD_MAIN_TENDER_FILE", "招标人授权招标代理签章协议书");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_ORD_MAIN_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 项目总标段个数
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "项目总标段个数");
            /// <summary>
			/// 本次招标标段个数
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION = new Field("TENDERER_BID_SECTION", "JT_ORD_MAIN_TENDER_FILE", "本次招标标段个数");
            /// <summary>
			/// 每个投标人最多中标标段数
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "每个投标人最多中标标段数");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_ORD_MAIN_TENDER_FILE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_ORD_MAIN_TENDER_FILE", "开户银行");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_ORD_MAIN_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_ORD_MAIN_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_ORD_MAIN_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_ORD_MAIN_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE = new Field("SUPERVISE_DEPT_PHONE", "JT_ORD_MAIN_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_ORD_MAIN_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_ORD_MAIN_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 本项目工程质量目标为交工验收质量评定
			/// </summary>
			public readonly static Field QUALITY_REQUIRE1 = new Field("QUALITY_REQUIRE1", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "本项目工程质量目标为交工验收质量评定");
            /// <summary>
			/// 竣工验收质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE2 = new Field("QUALITY_REQUIRE2", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "竣工验收质量要求");
            /// <summary>
			/// 专职安全人员类型
			/// </summary>
			public readonly static Field SECURITY_SELECTION = new Field("SECURITY_SELECTION", "JT_ORD_MAIN_TENDER_FILE", "专职安全人员类型");
            /// <summary>
			/// 人员社保要求
			/// </summary>
			public readonly static Field SOCIAL_SECURITY_REQUIRE = new Field("SOCIAL_SECURITY_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "人员社保要求");
            /// <summary>
			/// 是否允许分包
			/// </summary>
			public readonly static Field SUBCONTRACT = new Field("SUBCONTRACT", "JT_ORD_MAIN_TENDER_FILE", "是否允许分包");
            /// <summary>
			/// 招标文件修改截止时间
			/// </summary>
			public readonly static Field MODIFICATION_TIME = new Field("MODIFICATION_TIME", "JT_ORD_MAIN_TENDER_FILE", "招标文件修改截止时间");
            /// <summary>
			/// 采用电汇形式保证金计息方式
			/// </summary>
			public readonly static Field INTEREST_MODE = new Field("INTEREST_MODE", "JT_ORD_MAIN_TENDER_FILE", "采用电汇形式保证金计息方式");
            /// <summary>
			/// 利息约定
			/// </summary>
			public readonly static Field INTEREST_REQUIRE = new Field("INTEREST_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "利息约定");
            /// <summary>
			/// 年度保证金
			/// </summary>
			public readonly static Field ANNUAL_DEPOSIT_REQUIRE = new Field("ANNUAL_DEPOSIT_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "年度保证金");
            /// <summary>
			/// 近年发生的行贿犯罪记录查询的年份要求
			/// </summary>
			public readonly static Field BRIBERY_RECORD_YEAR = new Field("BRIBERY_RECORD_YEAR", "JT_ORD_MAIN_TENDER_FILE", "近年发生的行贿犯罪记录查询的年份要求");
            /// <summary>
			/// 近年发生的诉讼及仲裁情况的年份要求
			/// </summary>
			public readonly static Field LITIGATION_REQUIRE = new Field("LITIGATION_REQUIRE", "JT_ORD_MAIN_TENDER_FILE", "近年发生的诉讼及仲裁情况的年份要求");
            /// <summary>
			/// 投标文件副本份数
			/// </summary>
			public readonly static Field COPY_NUMBER = new Field("COPY_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "投标文件副本份数");
            /// <summary>
			/// 投标报价补充条款
			/// </summary>
			public readonly static Field TENDER_OFFER_REQUIRE = new Field("TENDER_OFFER_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "投标报价补充条款");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_ORD_MAIN_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_ORD_MAIN_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_ORD_MAIN_TENDER_FILE", "专家人数");
            /// <summary>
			/// 评标专家确定方式
			/// </summary>
			public readonly static Field EXPERT_LIBRARY = new Field("EXPERT_LIBRARY", "JT_ORD_MAIN_TENDER_FILE", "评标专家确定方式");
            /// <summary>
			/// 评标委员会确定中标人数
			/// </summary>
			public readonly static Field WINNING_BIDDER_NUMBER = new Field("WINNING_BIDDER_NUMBER", "JT_ORD_MAIN_TENDER_FILE", "评标委员会确定中标人数");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field BOND_PRICE = new Field("BOND_PRICE", "JT_ORD_MAIN_TENDER_FILE", "履约担保金额");
            /// <summary>
			/// 订立书面合同的时间为中标通知书发出后的天数
			/// </summary>
			public readonly static Field SIGN_CONTRACT_TIME = new Field("SIGN_CONTRACT_TIME", "JT_ORD_MAIN_TENDER_FILE", "订立书面合同的时间为中标通知书发出后的天数");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 项目经理、技术负责人、专职安全工程员最低要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "项目经理、技术负责人、专职安全工程员最低要求");
            /// <summary>
			/// 其他主要管理人员和技术人员最低要求
			/// </summary>
			public readonly static Field OTHER_QUALIFICATION_REQUIRE = new Field("OTHER_QUALIFICATION_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "其他主要管理人员和技术人员最低要求");
            /// <summary>
			/// 机械设备最低要求
			/// </summary>
			public readonly static Field EQUIPMENT_REQUIRE = new Field("EQUIPMENT_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "机械设备最低要求");
            /// <summary>
			/// 评标办法评审因素和评审标准
			/// </summary>
			public readonly static Field EVALUATING_METHOD_STANDARD = new Field("EVALUATING_METHOD_STANDARD", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "评标办法评审因素和评审标准");
            /// <summary>
			/// E1值
			/// </summary>
			public readonly static Field E1_SCORE = new Field("E1_SCORE", "JT_ORD_MAIN_TENDER_FILE", "E1值");
            /// <summary>
			/// E2值
			/// </summary>
			public readonly static Field E2_SCORE = new Field("E2_SCORE", "JT_ORD_MAIN_TENDER_FILE", "E2值");
            /// <summary>
			/// 信用分使用要求
			/// </summary>
			public readonly static Field CREDIT_REQUIRE = new Field("CREDIT_REQUIRE", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "信用分使用要求");
            /// <summary>
			/// 争议的最终解决方式
			/// </summary>
			public readonly static Field DISPUTE_DEAL_METHOD = new Field("DISPUTE_DEAL_METHOD", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "争议的最终解决方式");
            /// <summary>
			/// 仲裁委员会名称
			/// </summary>
			public readonly static Field ARB_COMMISSION_NAME = new Field("ARB_COMMISSION_NAME", "JT_ORD_MAIN_TENDER_FILE", "仲裁委员会名称");
            /// <summary>
			/// 发包人
			/// </summary>
			public readonly static Field SUBC_NAME = new Field("SUBC_NAME", "JT_ORD_MAIN_TENDER_FILE", "发包人");
            /// <summary>
			/// 发包人地址
			/// </summary>
			public readonly static Field SUBC_NAME_ADDRESS = new Field("SUBC_NAME_ADDRESS", "JT_ORD_MAIN_TENDER_FILE", "发包人地址");
            /// <summary>
			/// 发包人邮政编码
			/// </summary>
			public readonly static Field SUBC_ZIP_CODE = new Field("SUBC_ZIP_CODE", "JT_ORD_MAIN_TENDER_FILE", "发包人邮政编码");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD1 = new Field("DEFECT_LIABILITY_PERIOD1", "JT_ORD_MAIN_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 图纸修改和补充应在施工前
			/// </summary>
			public readonly static Field DRAWING_MODIFICATION = new Field("DRAWING_MODIFICATION", "JT_ORD_MAIN_TENDER_FILE", "图纸修改和补充应在施工前");
            /// <summary>
			/// 发包人是否提供材料或工程设备
			/// </summary>
			public readonly static Field PROVIDE_MATERIALS = new Field("PROVIDE_MATERIALS", "JT_ORD_MAIN_TENDER_FILE", "发包人是否提供材料或工程设备");
            /// <summary>
			/// 提供材料或工程设备相关规定
			/// </summary>
			public readonly static Field MATERIAL_REGULATION = new Field("MATERIAL_REGULATION", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "提供材料或工程设备相关规定");
            /// <summary>
			/// 发包人是否提供施工设备或临时设施
			/// </summary>
			public readonly static Field SUPPLY_EQUIPMENT = new Field("SUPPLY_EQUIPMENT", "JT_ORD_MAIN_TENDER_FILE", "发包人是否提供施工设备或临时设施");
            /// <summary>
			/// 发包人提供临时设施相关规定
			/// </summary>
			public readonly static Field EQUIPMEN_REGULATION = new Field("EQUIPMEN_REGULATION", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "发包人提供临时设施相关规定");
            /// <summary>
			/// 发包人提供资料的期限
			/// </summary>
			public readonly static Field DATA_PERIOD = new Field("DATA_PERIOD", "JT_ORD_MAIN_TENDER_FILE", "发包人提供资料的期限");
            /// <summary>
			/// 承包人报送审批的期限
			/// </summary>
			public readonly static Field APPROVAL_PERIOD = new Field("APPROVAL_PERIOD", "JT_ORD_MAIN_TENDER_FILE", "承包人报送审批的期限");
            /// <summary>
			/// 工期延误的违约金
			/// </summary>
			public readonly static Field DELAY_PENALTY = new Field("DELAY_PENALTY", "JT_ORD_MAIN_TENDER_FILE", "工期延误的违约金");
            /// <summary>
			/// 逾期交工违约金限额
			/// </summary>
			public readonly static Field PENALTY_QUOTA = new Field("PENALTY_QUOTA", "JT_ORD_MAIN_TENDER_FILE", "逾期交工违约金限额");
            /// <summary>
			/// 提前交工的奖金
			/// </summary>
			public readonly static Field COMPLETION_BONUS = new Field("COMPLETION_BONUS", "JT_ORD_MAIN_TENDER_FILE", "提前交工的奖金");
            /// <summary>
			/// 提前交工的奖金限额
			/// </summary>
			public readonly static Field BONUS_LIMIT = new Field("BONUS_LIMIT", "JT_ORD_MAIN_TENDER_FILE", "提前交工的奖金限额");
            /// <summary>
			/// 发包人给予奖励按所节约成本
			/// </summary>
			public readonly static Field COST_SAVING = new Field("COST_SAVING", "JT_ORD_MAIN_TENDER_FILE", "发包人给予奖励按所节约成本");
            /// <summary>
			/// 发包人给予奖励按增加收益
			/// </summary>
			public readonly static Field INCREASE_INCOME = new Field("INCREASE_INCOME", "JT_ORD_MAIN_TENDER_FILE", "发包人给予奖励按增加收益");
            /// <summary>
			/// 开工预付款金额为签约合同价
			/// </summary>
			public readonly static Field ADVANCE_AMOUNT = new Field("ADVANCE_AMOUNT", "JT_ORD_MAIN_TENDER_FILE", "开工预付款金额为签约合同价");
            /// <summary>
			/// 材料名称
			/// </summary>
			public readonly static Field MATERIAL = new Field("MATERIAL", "JT_ORD_MAIN_TENDER_FILE", "材料名称");
            /// <summary>
			/// 按单据所列费用
			/// </summary>
			public readonly static Field DOCUMENT_CHARGES = new Field("DOCUMENT_CHARGES", "JT_ORD_MAIN_TENDER_FILE", "按单据所列费用");
            /// <summary>
			/// 承包人每个付款周期提交的申请单份数
			/// </summary>
			public readonly static Field SUBMIT_REQUISITION = new Field("SUBMIT_REQUISITION", "JT_ORD_MAIN_TENDER_FILE", "承包人每个付款周期提交的申请单份数");
            /// <summary>
			/// 质量保证金百分比为月支付额
			/// </summary>
			public readonly static Field MONTHLY_PAYMENT = new Field("MONTHLY_PAYMENT", "JT_ORD_MAIN_TENDER_FILE", "质量保证金百分比为月支付额");
            /// <summary>
			/// 质量保证金限额为合同价格
			/// </summary>
			public readonly static Field QUALITY_MARGIN_LIMIT = new Field("QUALITY_MARGIN_LIMIT", "JT_ORD_MAIN_TENDER_FILE", "质量保证金限额为合同价格");
            /// <summary>
			/// 承包人提交交工付款申请单的份数
			/// </summary>
			public readonly static Field PAYMENT_APPLICATION = new Field("PAYMENT_APPLICATION", "JT_ORD_MAIN_TENDER_FILE", "承包人提交交工付款申请单的份数");
            /// <summary>
			/// 承包人提交最终结清申请单份数
			/// </summary>
			public readonly static Field APPLICATION_NUM = new Field("APPLICATION_NUM", "JT_ORD_MAIN_TENDER_FILE", "承包人提交最终结清申请单份数");
            /// <summary>
			/// 竣工资料的份数
			/// </summary>
			public readonly static Field COMPLETION_DATA = new Field("COMPLETION_DATA", "JT_ORD_MAIN_TENDER_FILE", "竣工资料的份数");
            /// <summary>
			/// 是否需投入施工期运行
			/// </summary>
			public readonly static Field CONSTRUCTION_PERIOD_OPERATION = new Field("CONSTRUCTION_PERIOD_OPERATION", "JT_ORD_MAIN_TENDER_FILE", "是否需投入施工期运行");
            /// <summary>
			/// 需要施工期运行的规定
			/// </summary>
			public readonly static Field OPERATING_REGULATIONS = new Field("OPERATING_REGULATIONS", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "需要施工期运行的规定");
            /// <summary>
			/// 是否进行试运行
			/// </summary>
			public readonly static Field TEST_RUN = new Field("TEST_RUN", "JT_ORD_MAIN_TENDER_FILE", "是否进行试运行");
            /// <summary>
			/// 试运行的具体规定
			/// </summary>
			public readonly static Field TEST_RUN_REGULATIONS = new Field("TEST_RUN_REGULATIONS", "JT_ORD_MAIN_TENDER_FILE",DbType.AnsiString, null, "试运行的具体规定");
            /// <summary>
			/// 保修期
			/// </summary>
			public readonly static Field DEFECTS_LIABILITY_PERIOD = new Field("DEFECTS_LIABILITY_PERIOD", "JT_ORD_MAIN_TENDER_FILE", "保修期");
            /// <summary>
			/// 建筑工程一切险的保险费率
			/// </summary>
			public readonly static Field PREMIUM_RATE1 = new Field("PREMIUM_RATE1", "JT_ORD_MAIN_TENDER_FILE", "建筑工程一切险的保险费率");
            /// <summary>
			/// 第三者责任险的最低投保金额
			/// </summary>
			public readonly static Field MINIMUM_INSURANCE_AMOUNT = new Field("MINIMUM_INSURANCE_AMOUNT", "JT_ORD_MAIN_TENDER_FILE", "第三者责任险的最低投保金额");
            /// <summary>
			/// 保险费率
			/// </summary>
			public readonly static Field PREMIUM_RATE2 = new Field("PREMIUM_RATE2", "JT_ORD_MAIN_TENDER_FILE", "保险费率");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_ORD_MAIN_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_ORD_MAIN_TENDER_FILE", "图纸");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_ORD_MAIN_TENDER_FILE", "技术规范");
            /// <summary>
			/// 补充技术规范
			/// </summary>
			public readonly static Field SUPPLY_TECHNICAL_STANDARD = new Field("SUPPLY_TECHNICAL_STANDARD", "JT_ORD_MAIN_TENDER_FILE", "补充技术规范");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_ORD_MAIN_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_ORD_MAIN_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_ORD_MAIN_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_ORD_MAIN_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_ORD_MAIN_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_ORD_MAIN_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_ORD_MAIN_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_ORD_MAIN_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_ORD_MAIN_TENDER_FILE", "M_TM");
            /// <summary>
			/// 进度付款证书最低限额
			/// </summary>
			public readonly static Field MINIMUM_LIMIT = new Field("MINIMUM_LIMIT", "JT_ORD_MAIN_TENDER_FILE", "进度付款证书最低限额");
            /// <summary>
			/// 每个投标人最多投标标段数
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_ORD_MAIN_TENDER_FILE", "每个投标人最多投标标段数");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_ORD_MAIN_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_ORD_MAIN_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_ORD_MAIN_TENDER_FILE", "");
        }
        #endregion
	}
}