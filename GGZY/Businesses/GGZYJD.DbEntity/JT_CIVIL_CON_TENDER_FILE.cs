using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_CIVIL_CON_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_CIVIL_CON_TENDER_FILE")]
    [Serializable]
    public partial class JT_CIVIL_CON_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _DEFECT_LIABILITY_PERIOD1;
		private decimal? _BID_SECTION;
		private decimal? _TENDERER_BID_SECTION;
		private decimal? _CONTRACT_SEGMENT;
		private string _OTHER_MATTERS;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _OTHER;
		private string _OTHER_CONTENT;
		private string _FUND_IMPLEMENTATION;
		private DateTime? _BEGIN_ALL_DATE;
		private string _UNIT_SELECTION;
		private DateTime? _END_DATE;
		private string _SECURITY_TARGET;
		private DateTime? _MARGIN_TIME;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private DateTime? _PROJECT_YEAR_REQUIRED_TIME;
		private DateTime? _LITIGATION_YEAR_REQUIRED_TIME;
		private string _EVALUATING_METHOD_STANDARD;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_TELE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_EXTRACT;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _QUALIFICATION_REQUIRE;
		private decimal? _WIN_CANDIDATE_NUM;
		private string _SUBC_NAME;
		private string _SUBC_ADDRESS;
		private decimal? _SUBC_ZIP_CODE;
		private string _CONVENTION;
		private string _MATERIAL;
		private string _DISPUTE_RESOLUTION;
		private string _ARBITRATION_COMMISSION;
		private decimal? _DOCUMENT_CHARGES;
		private decimal? _MINIMUM_LIMIT;
		private string _BILL_OF_QUANTITIES;
		private string _DRAWING;
		private string _TECHNICAL_SPECIFICATIONS;
		private string _SUPPLY_TECHNICAL_STANDARD;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _PROJECT_PROFILE;
		private decimal? _CONTRACT_SECTION;
		private string _ACHIEVEMENT_CONDITIONS;
		private decimal? _TENDER_NUMBER;
		private string _QUALITY_TARGET;
		private decimal? _LOAN_RATIO;
		private decimal? _CAPITAL_RATIO;
		private DateTime? _ACHI_REQUIRE_YEAR;
		private DateTime? _REPU_REQUIRE_YEAR;
		private string _FINANCIAL_REQUIRE_YEAR;
		private string _TECH_REQUIREMENTS;
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
		/// 本项目路基土建工程施工划分标段数
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
		/// 本次招标标段数
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
		/// 投标人允许参投标段数量
		/// </summary>
		public decimal? CONTRACT_SEGMENT
		{
			get{ return _CONTRACT_SEGMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SEGMENT, _CONTRACT_SEGMENT, value);
				this._CONTRACT_SEGMENT = value;
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
		/// 其他
		/// </summary>
		public string OTHER
		{
			get{ return _OTHER; }
			set
			{
				this.OnPropertyValueChange(_.OTHER, _OTHER, value);
				this._OTHER = value;
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
		/// 工期单位
		/// </summary>
		public string UNIT_SELECTION
		{
			get{ return _UNIT_SELECTION; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_SELECTION, _UNIT_SELECTION, value);
				this._UNIT_SELECTION = value;
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
		/// 本标段的安全目标
		/// </summary>
		public string SECURITY_TARGET
		{
			get{ return _SECURITY_TARGET; }
			set
			{
				this.OnPropertyValueChange(_.SECURITY_TARGET, _SECURITY_TARGET, value);
				this._SECURITY_TARGET = value;
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
		/// 近年完成的类似项目的年份要求
		/// </summary>
		public DateTime? PROJECT_YEAR_REQUIRED_TIME
		{
			get{ return _PROJECT_YEAR_REQUIRED_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_YEAR_REQUIRED_TIME, _PROJECT_YEAR_REQUIRED_TIME, value);
				this._PROJECT_YEAR_REQUIRED_TIME = value;
			}
		}
		/// <summary>
		/// 近年发生的诉讼及仲裁情况的年份要求
		/// </summary>
		public DateTime? LITIGATION_YEAR_REQUIRED_TIME
		{
			get{ return _LITIGATION_YEAR_REQUIRED_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_YEAR_REQUIRED_TIME, _LITIGATION_YEAR_REQUIRED_TIME, value);
				this._LITIGATION_YEAR_REQUIRED_TIME = value;
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
		public string EXPERT_EXTRACT
		{
			get{ return _EXPERT_EXTRACT; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_EXTRACT, _EXPERT_EXTRACT, value);
				this._EXPERT_EXTRACT = value;
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
		/// 项目经理和项目总工资格
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
		public string SUBC_ADDRESS
		{
			get{ return _SUBC_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_ADDRESS, _SUBC_ADDRESS, value);
				this._SUBC_ADDRESS = value;
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
		/// 因物价波动引起的价格调整按照第几项约定的原则处理
		/// </summary>
		public string CONVENTION
		{
			get{ return _CONVENTION; }
			set
			{
				this.OnPropertyValueChange(_.CONVENTION, _CONVENTION, value);
				this._CONVENTION = value;
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
		/// 单据所列费用
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
		/// 进度付款证书最低限额
		/// </summary>
		public decimal? MINIMUM_LIMIT
		{
			get{ return _MINIMUM_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_LIMIT, _MINIMUM_LIMIT, value);
				this._MINIMUM_LIMIT = value;
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
		/// 本项目勘察设计招标合同段个数
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
		/// 投标人业绩条件
		/// </summary>
		public string ACHIEVEMENT_CONDITIONS
		{
			get{ return _ACHIEVEMENT_CONDITIONS; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT_CONDITIONS, _ACHIEVEMENT_CONDITIONS, value);
				this._ACHIEVEMENT_CONDITIONS = value;
			}
		}
		/// <summary>
		/// 每个投标人最多可中标数量
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
		/// 质量目标
		/// </summary>
		public string QUALITY_TARGET
		{
			get{ return _QUALITY_TARGET; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_TARGET, _QUALITY_TARGET, value);
				this._QUALITY_TARGET = value;
			}
		}
		/// <summary>
		/// 银行贷款占出资比例的百分比
		/// </summary>
		public decimal? LOAN_RATIO
		{
			get{ return _LOAN_RATIO; }
			set
			{
				this.OnPropertyValueChange(_.LOAN_RATIO, _LOAN_RATIO, value);
				this._LOAN_RATIO = value;
			}
		}
		/// <summary>
		/// 自筹资金占出资比例的百分比
		/// </summary>
		public decimal? CAPITAL_RATIO
		{
			get{ return _CAPITAL_RATIO; }
			set
			{
				this.OnPropertyValueChange(_.CAPITAL_RATIO, _CAPITAL_RATIO, value);
				this._CAPITAL_RATIO = value;
			}
		}
		/// <summary>
		/// 近5年完成的类似项目业绩时间
		/// </summary>
		public DateTime? ACHI_REQUIRE_YEAR
		{
			get{ return _ACHI_REQUIRE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.ACHI_REQUIRE_YEAR, _ACHI_REQUIRE_YEAR, value);
				this._ACHI_REQUIRE_YEAR = value;
			}
		}
		/// <summary>
		/// 近3年信誉要求
		/// </summary>
		public DateTime? REPU_REQUIRE_YEAR
		{
			get{ return _REPU_REQUIRE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.REPU_REQUIRE_YEAR, _REPU_REQUIRE_YEAR, value);
				this._REPU_REQUIRE_YEAR = value;
			}
		}
		/// <summary>
		/// 近年完成的类似项目的年份要求
		/// </summary>
		public string FINANCIAL_REQUIRE_YEAR
		{
			get{ return _FINANCIAL_REQUIRE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE_YEAR, _FINANCIAL_REQUIRE_YEAR, value);
				this._FINANCIAL_REQUIRE_YEAR = value;
			}
		}
		/// <summary>
		/// 勘察设计技术要求
		/// </summary>
		public string TECH_REQUIREMENTS
		{
			get{ return _TECH_REQUIREMENTS; }
			set
			{
				this.OnPropertyValueChange(_.TECH_REQUIREMENTS, _TECH_REQUIREMENTS, value);
				this._TECH_REQUIREMENTS = value;
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
				_.DEFECT_LIABILITY_PERIOD1,
				_.BID_SECTION,
				_.TENDERER_BID_SECTION,
				_.CONTRACT_SEGMENT,
				_.OTHER_MATTERS,
				_.MEDIA1,
				_.MEDIA2,
				_.OTHER,
				_.OTHER_CONTENT,
				_.FUND_IMPLEMENTATION,
				_.BEGIN_ALL_DATE,
				_.UNIT_SELECTION,
				_.END_DATE,
				_.SECURITY_TARGET,
				_.MARGIN_TIME,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.PROJECT_YEAR_REQUIRED_TIME,
				_.LITIGATION_YEAR_REQUIRED_TIME,
				_.EVALUATING_METHOD_STANDARD,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_TELE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_EXTRACT,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.QUALIFICATION_REQUIRE,
				_.WIN_CANDIDATE_NUM,
				_.SUBC_NAME,
				_.SUBC_ADDRESS,
				_.SUBC_ZIP_CODE,
				_.CONVENTION,
				_.MATERIAL,
				_.DISPUTE_RESOLUTION,
				_.ARBITRATION_COMMISSION,
				_.DOCUMENT_CHARGES,
				_.MINIMUM_LIMIT,
				_.BILL_OF_QUANTITIES,
				_.DRAWING,
				_.TECHNICAL_SPECIFICATIONS,
				_.SUPPLY_TECHNICAL_STANDARD,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DATA_TIMESTAMP,
				_.PROJECT_PROFILE,
				_.CONTRACT_SECTION,
				_.ACHIEVEMENT_CONDITIONS,
				_.TENDER_NUMBER,
				_.QUALITY_TARGET,
				_.LOAN_RATIO,
				_.CAPITAL_RATIO,
				_.ACHI_REQUIRE_YEAR,
				_.REPU_REQUIRE_YEAR,
				_.FINANCIAL_REQUIRE_YEAR,
				_.TECH_REQUIREMENTS,
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
				this._DEFECT_LIABILITY_PERIOD1,
				this._BID_SECTION,
				this._TENDERER_BID_SECTION,
				this._CONTRACT_SEGMENT,
				this._OTHER_MATTERS,
				this._MEDIA1,
				this._MEDIA2,
				this._OTHER,
				this._OTHER_CONTENT,
				this._FUND_IMPLEMENTATION,
				this._BEGIN_ALL_DATE,
				this._UNIT_SELECTION,
				this._END_DATE,
				this._SECURITY_TARGET,
				this._MARGIN_TIME,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._PROJECT_YEAR_REQUIRED_TIME,
				this._LITIGATION_YEAR_REQUIRED_TIME,
				this._EVALUATING_METHOD_STANDARD,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_TELE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_EXTRACT,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._QUALIFICATION_REQUIRE,
				this._WIN_CANDIDATE_NUM,
				this._SUBC_NAME,
				this._SUBC_ADDRESS,
				this._SUBC_ZIP_CODE,
				this._CONVENTION,
				this._MATERIAL,
				this._DISPUTE_RESOLUTION,
				this._ARBITRATION_COMMISSION,
				this._DOCUMENT_CHARGES,
				this._MINIMUM_LIMIT,
				this._BILL_OF_QUANTITIES,
				this._DRAWING,
				this._TECHNICAL_SPECIFICATIONS,
				this._SUPPLY_TECHNICAL_STANDARD,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DATA_TIMESTAMP,
				this._PROJECT_PROFILE,
				this._CONTRACT_SECTION,
				this._ACHIEVEMENT_CONDITIONS,
				this._TENDER_NUMBER,
				this._QUALITY_TARGET,
				this._LOAN_RATIO,
				this._CAPITAL_RATIO,
				this._ACHI_REQUIRE_YEAR,
				this._REPU_REQUIRE_YEAR,
				this._FINANCIAL_REQUIRE_YEAR,
				this._TECH_REQUIREMENTS,
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
			public readonly static Field All = new Field("*", "JT_CIVIL_CON_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_CIVIL_CON_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_CIVIL_CON_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD1 = new Field("DEFECT_LIABILITY_PERIOD1", "JT_CIVIL_CON_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 本项目路基土建工程施工划分标段数
			/// </summary>
			public readonly static Field BID_SECTION = new Field("BID_SECTION", "JT_CIVIL_CON_TENDER_FILE", "本项目路基土建工程施工划分标段数");
            /// <summary>
			/// 本次招标标段数
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION = new Field("TENDERER_BID_SECTION", "JT_CIVIL_CON_TENDER_FILE", "本次招标标段数");
            /// <summary>
			/// 投标人允许参投标段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_CIVIL_CON_TENDER_FILE", "投标人允许参投标段数量");
            /// <summary>
			/// 其他事项
			/// </summary>
			public readonly static Field OTHER_MATTERS = new Field("OTHER_MATTERS", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "其他事项");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_CIVIL_CON_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_CIVIL_CON_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER = new Field("OTHER", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 需要补充的其他内容
			/// </summary>
			public readonly static Field OTHER_CONTENT = new Field("OTHER_CONTENT", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "需要补充的其他内容");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_CIVIL_CON_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 总计划开工日期
			/// </summary>
			public readonly static Field BEGIN_ALL_DATE = new Field("BEGIN_ALL_DATE", "JT_CIVIL_CON_TENDER_FILE", "总计划开工日期");
            /// <summary>
			/// 工期单位
			/// </summary>
			public readonly static Field UNIT_SELECTION = new Field("UNIT_SELECTION", "JT_CIVIL_CON_TENDER_FILE", "工期单位");
            /// <summary>
			/// 计划交工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "JT_CIVIL_CON_TENDER_FILE", "计划交工日期");
            /// <summary>
			/// 本标段的安全目标
			/// </summary>
			public readonly static Field SECURITY_TARGET = new Field("SECURITY_TARGET", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "本标段的安全目标");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_CIVIL_CON_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 招标人账户
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_CIVIL_CON_TENDER_FILE", "招标人账户");
            /// <summary>
			/// 招标人账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_CIVIL_CON_TENDER_FILE", "招标人账号");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_CIVIL_CON_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 近年完成的类似项目的年份要求
			/// </summary>
			public readonly static Field PROJECT_YEAR_REQUIRED_TIME = new Field("PROJECT_YEAR_REQUIRED_TIME", "JT_CIVIL_CON_TENDER_FILE", "近年完成的类似项目的年份要求");
            /// <summary>
			/// 近年发生的诉讼及仲裁情况的年份要求
			/// </summary>
			public readonly static Field LITIGATION_YEAR_REQUIRED_TIME = new Field("LITIGATION_YEAR_REQUIRED_TIME", "JT_CIVIL_CON_TENDER_FILE", "近年发生的诉讼及仲裁情况的年份要求");
            /// <summary>
			/// 评标办法评审因素和评审标准
			/// </summary>
			public readonly static Field EVALUATING_METHOD_STANDARD = new Field("EVALUATING_METHOD_STANDARD", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "评标办法评审因素和评审标准");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_CIVIL_CON_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_TELE = new Field("SUPERVISE_DEPT_TELE", "JT_CIVIL_CON_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_CIVIL_CON_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_CIVIL_CON_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_CIVIL_CON_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_CIVIL_CON_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_CIVIL_CON_TENDER_FILE", "专家人数");
            /// <summary>
			/// 评标专家确定方式
			/// </summary>
			public readonly static Field EXPERT_EXTRACT = new Field("EXPERT_EXTRACT", "JT_CIVIL_CON_TENDER_FILE", "评标专家确定方式");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 项目经理和项目总工资格
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "项目经理和项目总工资格");
            /// <summary>
			/// 评标委员会推荐中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "JT_CIVIL_CON_TENDER_FILE", "评标委员会推荐中标候选人人数");
            /// <summary>
			/// 发包人
			/// </summary>
			public readonly static Field SUBC_NAME = new Field("SUBC_NAME", "JT_CIVIL_CON_TENDER_FILE", "发包人");
            /// <summary>
			/// 发包人地址
			/// </summary>
			public readonly static Field SUBC_ADDRESS = new Field("SUBC_ADDRESS", "JT_CIVIL_CON_TENDER_FILE", "发包人地址");
            /// <summary>
			/// 发包人邮政编码
			/// </summary>
			public readonly static Field SUBC_ZIP_CODE = new Field("SUBC_ZIP_CODE", "JT_CIVIL_CON_TENDER_FILE", "发包人邮政编码");
            /// <summary>
			/// 因物价波动引起的价格调整按照第几项约定的原则处理
			/// </summary>
			public readonly static Field CONVENTION = new Field("CONVENTION", "JT_CIVIL_CON_TENDER_FILE", "因物价波动引起的价格调整按照第几项约定的原则处理");
            /// <summary>
			/// 材料名称
			/// </summary>
			public readonly static Field MATERIAL = new Field("MATERIAL", "JT_CIVIL_CON_TENDER_FILE", "材料名称");
            /// <summary>
			/// 争议的最终解决方式
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_CIVIL_CON_TENDER_FILE", "争议的最终解决方式");
            /// <summary>
			/// 仲裁委员会名称
			/// </summary>
			public readonly static Field ARBITRATION_COMMISSION = new Field("ARBITRATION_COMMISSION", "JT_CIVIL_CON_TENDER_FILE", "仲裁委员会名称");
            /// <summary>
			/// 单据所列费用
			/// </summary>
			public readonly static Field DOCUMENT_CHARGES = new Field("DOCUMENT_CHARGES", "JT_CIVIL_CON_TENDER_FILE", "单据所列费用");
            /// <summary>
			/// 进度付款证书最低限额
			/// </summary>
			public readonly static Field MINIMUM_LIMIT = new Field("MINIMUM_LIMIT", "JT_CIVIL_CON_TENDER_FILE", "进度付款证书最低限额");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_CIVIL_CON_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_CIVIL_CON_TENDER_FILE", "图纸");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_CIVIL_CON_TENDER_FILE", "技术规范");
            /// <summary>
			/// 补充技术规范
			/// </summary>
			public readonly static Field SUPPLY_TECHNICAL_STANDARD = new Field("SUPPLY_TECHNICAL_STANDARD", "JT_CIVIL_CON_TENDER_FILE", "补充技术规范");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_CIVIL_CON_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_CIVIL_CON_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_CIVIL_CON_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_CIVIL_CON_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_CIVIL_CON_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_CIVIL_CON_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_CIVIL_CON_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_CIVIL_CON_TENDER_FILE", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_CIVIL_CON_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 项目概况
			/// </summary>
			public readonly static Field PROJECT_PROFILE = new Field("PROJECT_PROFILE", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "项目概况");
            /// <summary>
			/// 本项目勘察设计招标合同段个数
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_CIVIL_CON_TENDER_FILE", "本项目勘察设计招标合同段个数");
            /// <summary>
			/// 投标人业绩条件
			/// </summary>
			public readonly static Field ACHIEVEMENT_CONDITIONS = new Field("ACHIEVEMENT_CONDITIONS", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "投标人业绩条件");
            /// <summary>
			/// 每个投标人最多可中标数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_CIVIL_CON_TENDER_FILE", "每个投标人最多可中标数量");
            /// <summary>
			/// 质量目标
			/// </summary>
			public readonly static Field QUALITY_TARGET = new Field("QUALITY_TARGET", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "质量目标");
            /// <summary>
			/// 银行贷款占出资比例的百分比
			/// </summary>
			public readonly static Field LOAN_RATIO = new Field("LOAN_RATIO", "JT_CIVIL_CON_TENDER_FILE", "银行贷款占出资比例的百分比");
            /// <summary>
			/// 自筹资金占出资比例的百分比
			/// </summary>
			public readonly static Field CAPITAL_RATIO = new Field("CAPITAL_RATIO", "JT_CIVIL_CON_TENDER_FILE", "自筹资金占出资比例的百分比");
            /// <summary>
			/// 近5年完成的类似项目业绩时间
			/// </summary>
			public readonly static Field ACHI_REQUIRE_YEAR = new Field("ACHI_REQUIRE_YEAR", "JT_CIVIL_CON_TENDER_FILE", "近5年完成的类似项目业绩时间");
            /// <summary>
			/// 近3年信誉要求
			/// </summary>
			public readonly static Field REPU_REQUIRE_YEAR = new Field("REPU_REQUIRE_YEAR", "JT_CIVIL_CON_TENDER_FILE", "近3年信誉要求");
            /// <summary>
			/// 近年完成的类似项目的年份要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_YEAR = new Field("FINANCIAL_REQUIRE_YEAR", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "近年完成的类似项目的年份要求");
            /// <summary>
			/// 勘察设计技术要求
			/// </summary>
			public readonly static Field TECH_REQUIREMENTS = new Field("TECH_REQUIREMENTS", "JT_CIVIL_CON_TENDER_FILE",DbType.AnsiString, null, "勘察设计技术要求");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_CIVIL_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_CIVIL_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_CIVIL_CON_TENDER_FILE", "");
        }
        #endregion
	}
}