using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_PORT_CON_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_PORT_CON_TENDER_FILE")]
    [Serializable]
    public partial class JT_PORT_CON_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _TOTAL_SECTION_NUMBER;
		private decimal? _TENDERER_SECTION_NUMBER;
		private decimal? _LIMITE_ALL_TIME;
		private string _MANAGER_QUAL_LEVEL;
		private string _MANAGER_TECH_TITLE;
		private string _CHARGE_TECH_TITLE;
		private string _CONSTRUCTION_PERFORMANCE;
		private string _MARGIN_NAME1;
		private string _MARGIN_NUMBER1;
		private string _MARGIN_BANK1;
		private string _MARGIN_NAME2;
		private string _MARGIN_NUMBER2;
		private string _MARGIN_BANK2;
		private string _MARGIN_NAME3;
		private string _MARGIN_NUMBER3;
		private string _MARGIN_BANK3;
		private string _NOTICE_MEDIA4;
		private string _FUND_IMPLEMENTATION;
		private DateTime? _BEGIN_ALL_DATE;
		private DateTime? _END_DATE;
		private decimal? _IMPORTANT_LIMITE_TIME;
		private DateTime? _QUESTION_TIME;
		private DateTime? _TENDER_NOTICE_TIME;
		private string _SUBCONTRACT;
		private string _SUBCONTRACT_CONTENT_REQUIRE;
		private string _SUB_QUALIFI_REQUIRE;
		private DateTime? _BIDDER_NOTICE_TIME;
		private string _TRADING_CENTER_NAME;
		private decimal? _FINANCIAL_REQUIRE_BEGIN;
		private decimal? _FINANCIAL_REQUIRE_END;
		private decimal? _SIMILAR_PROJECT_REQUIRE_BEGIN;
		private decimal? _SIMILAR_PROJECT_REQUIRE_END;
		private decimal? _LITIGATION_REQUIRE_BEGIN;
		private decimal? _LITIGATION_REQUIRE_END;
		private string _ALTERNATIVE_TENDER_SCHEME;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_DETERMIN_BIDDER;
		private string _PERFORM_PRICE_TYPE;
		private decimal? _PERFORM_PRICE;
		private string _SUPERVISE_DEPT_NAME1;
		private string _SUPERVISE_DEPT_PHONE1;
		private string _SUPERVISE_DEPT_ADDRESS1;
		private string _SUPERVISE_DEPT_FAX1;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE1;
		private string _SUPERVISE_DEPT_NAME2;
		private string _SUPERVISE_DEPT_PHONE2;
		private string _SUPERVISE_DEPT_ADDRESS2;
		private string _SUPERVISE_DEPT_FAX2;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE2;
		private string _OTHER_REQUIREMENTS;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _QUALIFICATION_REQUIRE;
		private string _OTHER_REQUIRE;
		private string _MANAGE_TECHNOLOGY_REQUIRE;
		private string _DEALING_UNIT;
		private string _COMPLAINT_ADDRESS;
		private string _COMPLAINT_PHONE;
		private string _COMPLAINT_POSTCODE;
		private string _CHANGE;
		private string _GENERAL_CONTRACT;
		private string _EMPLOYER_DUTY;
		private string _SUPERVISOR;
		private string _CONTRACTOR;
		private string _CONSTRUCT_EQUIP_TEMP_FACIL;
		private string _TRANSPORTATION;
		private string _SURVEYING;
		private string _SAFE_SECURITY_ENVIRON_PRO;
		private string _SCHEDULE;
		private string _COMMENCEMENT_COMPLETION;
		private string _SUSPENSION_OF_WORKS;
		private string _PROJECT_QUALITY;
		private string _TEST_INSPECTION;
		private string _MODIFICATION;
		private string _PRICE_REGULATION;
		private string _MEASUREMENT_PAYMENT;
		private string _COMPLETION_ACCEPTANCE;
		private string _LIABILITY_DEFECTS_WARRANTY;
		private string _FORCE_MAJEURE;
		private string _BREACH_CONTRACT;
		private string _OTHER_CONVENTIONS;
		private string _SUPPLY_ITEM;
		private string _BILL_OF_QUANTITIES;
		private string _DRAWING;
		private string _TECHNICAL_STANDARD_REQUIRE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _DATA_TIMESTAMP;
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
		public decimal? TENDERER_SECTION_NUMBER
		{
			get{ return _TENDERER_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_SECTION_NUMBER, _TENDERER_SECTION_NUMBER, value);
				this._TENDERER_SECTION_NUMBER = value;
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
		/// 项目经理资质等级
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
		/// 主要负责人职称
		/// </summary>
		public string CHARGE_TECH_TITLE
		{
			get{ return _CHARGE_TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.CHARGE_TECH_TITLE, _CHARGE_TECH_TITLE, value);
				this._CHARGE_TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 类似项目业绩要求
		/// </summary>
		public string CONSTRUCTION_PERFORMANCE
		{
			get{ return _CONSTRUCTION_PERFORMANCE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_PERFORMANCE, _CONSTRUCTION_PERFORMANCE, value);
				this._CONSTRUCTION_PERFORMANCE = value;
			}
		}
		/// <summary>
		/// 保证金户名一
		/// </summary>
		public string MARGIN_NAME1
		{
			get{ return _MARGIN_NAME1; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME1, _MARGIN_NAME1, value);
				this._MARGIN_NAME1 = value;
			}
		}
		/// <summary>
		/// 保证金账号一
		/// </summary>
		public string MARGIN_NUMBER1
		{
			get{ return _MARGIN_NUMBER1; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER1, _MARGIN_NUMBER1, value);
				this._MARGIN_NUMBER1 = value;
			}
		}
		/// <summary>
		/// 开户银行一
		/// </summary>
		public string MARGIN_BANK1
		{
			get{ return _MARGIN_BANK1; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK1, _MARGIN_BANK1, value);
				this._MARGIN_BANK1 = value;
			}
		}
		/// <summary>
		/// 保证金户名二
		/// </summary>
		public string MARGIN_NAME2
		{
			get{ return _MARGIN_NAME2; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME2, _MARGIN_NAME2, value);
				this._MARGIN_NAME2 = value;
			}
		}
		/// <summary>
		/// 保证金账号二
		/// </summary>
		public string MARGIN_NUMBER2
		{
			get{ return _MARGIN_NUMBER2; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER2, _MARGIN_NUMBER2, value);
				this._MARGIN_NUMBER2 = value;
			}
		}
		/// <summary>
		/// 开户银行二
		/// </summary>
		public string MARGIN_BANK2
		{
			get{ return _MARGIN_BANK2; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK2, _MARGIN_BANK2, value);
				this._MARGIN_BANK2 = value;
			}
		}
		/// <summary>
		/// 保证金户名三
		/// </summary>
		public string MARGIN_NAME3
		{
			get{ return _MARGIN_NAME3; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME3, _MARGIN_NAME3, value);
				this._MARGIN_NAME3 = value;
			}
		}
		/// <summary>
		/// 保证金账号三
		/// </summary>
		public string MARGIN_NUMBER3
		{
			get{ return _MARGIN_NUMBER3; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER3, _MARGIN_NUMBER3, value);
				this._MARGIN_NUMBER3 = value;
			}
		}
		/// <summary>
		/// 开户银行三
		/// </summary>
		public string MARGIN_BANK3
		{
			get{ return _MARGIN_BANK3; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK3, _MARGIN_BANK3, value);
				this._MARGIN_BANK3 = value;
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
		/// 重要节点工期
		/// </summary>
		public decimal? IMPORTANT_LIMITE_TIME
		{
			get{ return _IMPORTANT_LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTANT_LIMITE_TIME, _IMPORTANT_LIMITE_TIME, value);
				this._IMPORTANT_LIMITE_TIME = value;
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
		/// 是否分包
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
		/// 接受分包的第三人资质要求
		/// </summary>
		public string SUB_QUALIFI_REQUIRE
		{
			get{ return _SUB_QUALIFI_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SUB_QUALIFI_REQUIRE, _SUB_QUALIFI_REQUIRE, value);
				this._SUB_QUALIFI_REQUIRE = value;
			}
		}
		/// <summary>
		/// 投标人要求澄清招标文件的截止时间
		/// </summary>
		public DateTime? BIDDER_NOTICE_TIME
		{
			get{ return _BIDDER_NOTICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NOTICE_TIME, _BIDDER_NOTICE_TIME, value);
				this._BIDDER_NOTICE_TIME = value;
			}
		}
		/// <summary>
		/// 公共资源交易中心名称
		/// </summary>
		public string TRADING_CENTER_NAME
		{
			get{ return _TRADING_CENTER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_CENTER_NAME, _TRADING_CENTER_NAME, value);
				this._TRADING_CENTER_NAME = value;
			}
		}
		/// <summary>
		/// 近年财务状况起始年份
		/// </summary>
		public decimal? FINANCIAL_REQUIRE_BEGIN
		{
			get{ return _FINANCIAL_REQUIRE_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE_BEGIN, _FINANCIAL_REQUIRE_BEGIN, value);
				this._FINANCIAL_REQUIRE_BEGIN = value;
			}
		}
		/// <summary>
		/// 近年财务状况结束年份
		/// </summary>
		public decimal? FINANCIAL_REQUIRE_END
		{
			get{ return _FINANCIAL_REQUIRE_END; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE_END, _FINANCIAL_REQUIRE_END, value);
				this._FINANCIAL_REQUIRE_END = value;
			}
		}
		/// <summary>
		/// 完成的类似项目的起始年份
		/// </summary>
		public decimal? SIMILAR_PROJECT_REQUIRE_BEGIN
		{
			get{ return _SIMILAR_PROJECT_REQUIRE_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_REQUIRE_BEGIN, _SIMILAR_PROJECT_REQUIRE_BEGIN, value);
				this._SIMILAR_PROJECT_REQUIRE_BEGIN = value;
			}
		}
		/// <summary>
		/// 完成的类似项目的结束年份
		/// </summary>
		public decimal? SIMILAR_PROJECT_REQUIRE_END
		{
			get{ return _SIMILAR_PROJECT_REQUIRE_END; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_REQUIRE_END, _SIMILAR_PROJECT_REQUIRE_END, value);
				this._SIMILAR_PROJECT_REQUIRE_END = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况的起始年份
		/// </summary>
		public decimal? LITIGATION_REQUIRE_BEGIN
		{
			get{ return _LITIGATION_REQUIRE_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_REQUIRE_BEGIN, _LITIGATION_REQUIRE_BEGIN, value);
				this._LITIGATION_REQUIRE_BEGIN = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况的结束年份
		/// </summary>
		public decimal? LITIGATION_REQUIRE_END
		{
			get{ return _LITIGATION_REQUIRE_END; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_REQUIRE_END, _LITIGATION_REQUIRE_END, value);
				this._LITIGATION_REQUIRE_END = value;
			}
		}
		/// <summary>
		/// 是否允许递交备选投标方案
		/// </summary>
		public string ALTERNATIVE_TENDER_SCHEME
		{
			get{ return _ALTERNATIVE_TENDER_SCHEME; }
			set
			{
				this.OnPropertyValueChange(_.ALTERNATIVE_TENDER_SCHEME, _ALTERNATIVE_TENDER_SCHEME, value);
				this._ALTERNATIVE_TENDER_SCHEME = value;
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
		/// 是否授权评标委员会确定中标人
		/// </summary>
		public string EXPERT_DETERMIN_BIDDER
		{
			get{ return _EXPERT_DETERMIN_BIDDER; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_DETERMIN_BIDDER, _EXPERT_DETERMIN_BIDDER, value);
				this._EXPERT_DETERMIN_BIDDER = value;
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
		/// 监督部门名称一
		/// </summary>
		public string SUPERVISE_DEPT_NAME1
		{
			get{ return _SUPERVISE_DEPT_NAME1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME1, _SUPERVISE_DEPT_NAME1, value);
				this._SUPERVISE_DEPT_NAME1 = value;
			}
		}
		/// <summary>
		/// 监督部门联系电话一
		/// </summary>
		public string SUPERVISE_DEPT_PHONE1
		{
			get{ return _SUPERVISE_DEPT_PHONE1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_PHONE1, _SUPERVISE_DEPT_PHONE1, value);
				this._SUPERVISE_DEPT_PHONE1 = value;
			}
		}
		/// <summary>
		/// 监督部门地址一
		/// </summary>
		public string SUPERVISE_DEPT_ADDRESS1
		{
			get{ return _SUPERVISE_DEPT_ADDRESS1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ADDRESS1, _SUPERVISE_DEPT_ADDRESS1, value);
				this._SUPERVISE_DEPT_ADDRESS1 = value;
			}
		}
		/// <summary>
		/// 监督部门传真一
		/// </summary>
		public string SUPERVISE_DEPT_FAX1
		{
			get{ return _SUPERVISE_DEPT_FAX1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_FAX1, _SUPERVISE_DEPT_FAX1, value);
				this._SUPERVISE_DEPT_FAX1 = value;
			}
		}
		/// <summary>
		/// 监督部门邮编一
		/// </summary>
		public decimal? SUPERVISE_DEPT_ZIP_CODE1
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE1, _SUPERVISE_DEPT_ZIP_CODE1, value);
				this._SUPERVISE_DEPT_ZIP_CODE1 = value;
			}
		}
		/// <summary>
		/// 监督部门名称二
		/// </summary>
		public string SUPERVISE_DEPT_NAME2
		{
			get{ return _SUPERVISE_DEPT_NAME2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME2, _SUPERVISE_DEPT_NAME2, value);
				this._SUPERVISE_DEPT_NAME2 = value;
			}
		}
		/// <summary>
		/// 监督部门联系电话二
		/// </summary>
		public string SUPERVISE_DEPT_PHONE2
		{
			get{ return _SUPERVISE_DEPT_PHONE2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_PHONE2, _SUPERVISE_DEPT_PHONE2, value);
				this._SUPERVISE_DEPT_PHONE2 = value;
			}
		}
		/// <summary>
		/// 监督部门地址二
		/// </summary>
		public string SUPERVISE_DEPT_ADDRESS2
		{
			get{ return _SUPERVISE_DEPT_ADDRESS2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ADDRESS2, _SUPERVISE_DEPT_ADDRESS2, value);
				this._SUPERVISE_DEPT_ADDRESS2 = value;
			}
		}
		/// <summary>
		/// 监督部门传真二
		/// </summary>
		public string SUPERVISE_DEPT_FAX2
		{
			get{ return _SUPERVISE_DEPT_FAX2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_FAX2, _SUPERVISE_DEPT_FAX2, value);
				this._SUPERVISE_DEPT_FAX2 = value;
			}
		}
		/// <summary>
		/// 监督部门邮编二
		/// </summary>
		public decimal? SUPERVISE_DEPT_ZIP_CODE2
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE2, _SUPERVISE_DEPT_ZIP_CODE2, value);
				this._SUPERVISE_DEPT_ZIP_CODE2 = value;
			}
		}
		/// <summary>
		/// 其他要求
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
		/// 主要人员最低要求
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
		/// 其他最低要求
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
		/// 其他主要管理人员和技术人员最低要求
		/// </summary>
		public string MANAGE_TECHNOLOGY_REQUIRE
		{
			get{ return _MANAGE_TECHNOLOGY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGE_TECHNOLOGY_REQUIRE, _MANAGE_TECHNOLOGY_REQUIRE, value);
				this._MANAGE_TECHNOLOGY_REQUIRE = value;
			}
		}
		/// <summary>
		/// 接收投诉单位名称
		/// </summary>
		public string DEALING_UNIT
		{
			get{ return _DEALING_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.DEALING_UNIT, _DEALING_UNIT, value);
				this._DEALING_UNIT = value;
			}
		}
		/// <summary>
		/// 接收投诉单位地址
		/// </summary>
		public string COMPLAINT_ADDRESS
		{
			get{ return _COMPLAINT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ADDRESS, _COMPLAINT_ADDRESS, value);
				this._COMPLAINT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 接收投诉单位电话
		/// </summary>
		public string COMPLAINT_PHONE
		{
			get{ return _COMPLAINT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_PHONE, _COMPLAINT_PHONE, value);
				this._COMPLAINT_PHONE = value;
			}
		}
		/// <summary>
		/// 接收投诉单位邮编
		/// </summary>
		public string COMPLAINT_POSTCODE
		{
			get{ return _COMPLAINT_POSTCODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_POSTCODE, _COMPLAINT_POSTCODE, value);
				this._COMPLAINT_POSTCODE = value;
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
		/// 发包人义务
		/// </summary>
		public string EMPLOYER_DUTY
		{
			get{ return _EMPLOYER_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.EMPLOYER_DUTY, _EMPLOYER_DUTY, value);
				this._EMPLOYER_DUTY = value;
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
		/// 测量放线
		/// </summary>
		public string SURVEYING
		{
			get{ return _SURVEYING; }
			set
			{
				this.OnPropertyValueChange(_.SURVEYING, _SURVEYING, value);
				this._SURVEYING = value;
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
		/// 开工和竣工
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
		/// 暂停施工
		/// </summary>
		public string SUSPENSION_OF_WORKS
		{
			get{ return _SUSPENSION_OF_WORKS; }
			set
			{
				this.OnPropertyValueChange(_.SUSPENSION_OF_WORKS, _SUSPENSION_OF_WORKS, value);
				this._SUSPENSION_OF_WORKS = value;
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
		/// 试验和检验
		/// </summary>
		public string TEST_INSPECTION
		{
			get{ return _TEST_INSPECTION; }
			set
			{
				this.OnPropertyValueChange(_.TEST_INSPECTION, _TEST_INSPECTION, value);
				this._TEST_INSPECTION = value;
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
		/// 竣工验收
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
		/// 缺陷责任与保修责任
		/// </summary>
		public string LIABILITY_DEFECTS_WARRANTY
		{
			get{ return _LIABILITY_DEFECTS_WARRANTY; }
			set
			{
				this.OnPropertyValueChange(_.LIABILITY_DEFECTS_WARRANTY, _LIABILITY_DEFECTS_WARRANTY, value);
				this._LIABILITY_DEFECTS_WARRANTY = value;
			}
		}
		/// <summary>
		/// 不可抗力
		/// </summary>
		public string FORCE_MAJEURE
		{
			get{ return _FORCE_MAJEURE; }
			set
			{
				this.OnPropertyValueChange(_.FORCE_MAJEURE, _FORCE_MAJEURE, value);
				this._FORCE_MAJEURE = value;
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
		/// 其他约定
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
		/// 技术标准和要求
		/// </summary>
		public string TECHNICAL_STANDARD_REQUIRE
		{
			get{ return _TECHNICAL_STANDARD_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_STANDARD_REQUIRE, _TECHNICAL_STANDARD_REQUIRE, value);
				this._TECHNICAL_STANDARD_REQUIRE = value;
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
				_.TOTAL_SECTION_NUMBER,
				_.TENDERER_SECTION_NUMBER,
				_.LIMITE_ALL_TIME,
				_.MANAGER_QUAL_LEVEL,
				_.MANAGER_TECH_TITLE,
				_.CHARGE_TECH_TITLE,
				_.CONSTRUCTION_PERFORMANCE,
				_.MARGIN_NAME1,
				_.MARGIN_NUMBER1,
				_.MARGIN_BANK1,
				_.MARGIN_NAME2,
				_.MARGIN_NUMBER2,
				_.MARGIN_BANK2,
				_.MARGIN_NAME3,
				_.MARGIN_NUMBER3,
				_.MARGIN_BANK3,
				_.NOTICE_MEDIA4,
				_.FUND_IMPLEMENTATION,
				_.BEGIN_ALL_DATE,
				_.END_DATE,
				_.IMPORTANT_LIMITE_TIME,
				_.QUESTION_TIME,
				_.TENDER_NOTICE_TIME,
				_.SUBCONTRACT,
				_.SUBCONTRACT_CONTENT_REQUIRE,
				_.SUB_QUALIFI_REQUIRE,
				_.BIDDER_NOTICE_TIME,
				_.TRADING_CENTER_NAME,
				_.FINANCIAL_REQUIRE_BEGIN,
				_.FINANCIAL_REQUIRE_END,
				_.SIMILAR_PROJECT_REQUIRE_BEGIN,
				_.SIMILAR_PROJECT_REQUIRE_END,
				_.LITIGATION_REQUIRE_BEGIN,
				_.LITIGATION_REQUIRE_END,
				_.ALTERNATIVE_TENDER_SCHEME,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_DETERMIN_BIDDER,
				_.PERFORM_PRICE_TYPE,
				_.PERFORM_PRICE,
				_.SUPERVISE_DEPT_NAME1,
				_.SUPERVISE_DEPT_PHONE1,
				_.SUPERVISE_DEPT_ADDRESS1,
				_.SUPERVISE_DEPT_FAX1,
				_.SUPERVISE_DEPT_ZIP_CODE1,
				_.SUPERVISE_DEPT_NAME2,
				_.SUPERVISE_DEPT_PHONE2,
				_.SUPERVISE_DEPT_ADDRESS2,
				_.SUPERVISE_DEPT_FAX2,
				_.SUPERVISE_DEPT_ZIP_CODE2,
				_.OTHER_REQUIREMENTS,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.QUALIFICATION_REQUIRE,
				_.OTHER_REQUIRE,
				_.MANAGE_TECHNOLOGY_REQUIRE,
				_.DEALING_UNIT,
				_.COMPLAINT_ADDRESS,
				_.COMPLAINT_PHONE,
				_.COMPLAINT_POSTCODE,
				_.CHANGE,
				_.GENERAL_CONTRACT,
				_.EMPLOYER_DUTY,
				_.SUPERVISOR,
				_.CONTRACTOR,
				_.CONSTRUCT_EQUIP_TEMP_FACIL,
				_.TRANSPORTATION,
				_.SURVEYING,
				_.SAFE_SECURITY_ENVIRON_PRO,
				_.SCHEDULE,
				_.COMMENCEMENT_COMPLETION,
				_.SUSPENSION_OF_WORKS,
				_.PROJECT_QUALITY,
				_.TEST_INSPECTION,
				_.MODIFICATION,
				_.PRICE_REGULATION,
				_.MEASUREMENT_PAYMENT,
				_.COMPLETION_ACCEPTANCE,
				_.LIABILITY_DEFECTS_WARRANTY,
				_.FORCE_MAJEURE,
				_.BREACH_CONTRACT,
				_.OTHER_CONVENTIONS,
				_.SUPPLY_ITEM,
				_.BILL_OF_QUANTITIES,
				_.DRAWING,
				_.TECHNICAL_STANDARD_REQUIRE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DATA_TIMESTAMP,
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
				this._TOTAL_SECTION_NUMBER,
				this._TENDERER_SECTION_NUMBER,
				this._LIMITE_ALL_TIME,
				this._MANAGER_QUAL_LEVEL,
				this._MANAGER_TECH_TITLE,
				this._CHARGE_TECH_TITLE,
				this._CONSTRUCTION_PERFORMANCE,
				this._MARGIN_NAME1,
				this._MARGIN_NUMBER1,
				this._MARGIN_BANK1,
				this._MARGIN_NAME2,
				this._MARGIN_NUMBER2,
				this._MARGIN_BANK2,
				this._MARGIN_NAME3,
				this._MARGIN_NUMBER3,
				this._MARGIN_BANK3,
				this._NOTICE_MEDIA4,
				this._FUND_IMPLEMENTATION,
				this._BEGIN_ALL_DATE,
				this._END_DATE,
				this._IMPORTANT_LIMITE_TIME,
				this._QUESTION_TIME,
				this._TENDER_NOTICE_TIME,
				this._SUBCONTRACT,
				this._SUBCONTRACT_CONTENT_REQUIRE,
				this._SUB_QUALIFI_REQUIRE,
				this._BIDDER_NOTICE_TIME,
				this._TRADING_CENTER_NAME,
				this._FINANCIAL_REQUIRE_BEGIN,
				this._FINANCIAL_REQUIRE_END,
				this._SIMILAR_PROJECT_REQUIRE_BEGIN,
				this._SIMILAR_PROJECT_REQUIRE_END,
				this._LITIGATION_REQUIRE_BEGIN,
				this._LITIGATION_REQUIRE_END,
				this._ALTERNATIVE_TENDER_SCHEME,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_DETERMIN_BIDDER,
				this._PERFORM_PRICE_TYPE,
				this._PERFORM_PRICE,
				this._SUPERVISE_DEPT_NAME1,
				this._SUPERVISE_DEPT_PHONE1,
				this._SUPERVISE_DEPT_ADDRESS1,
				this._SUPERVISE_DEPT_FAX1,
				this._SUPERVISE_DEPT_ZIP_CODE1,
				this._SUPERVISE_DEPT_NAME2,
				this._SUPERVISE_DEPT_PHONE2,
				this._SUPERVISE_DEPT_ADDRESS2,
				this._SUPERVISE_DEPT_FAX2,
				this._SUPERVISE_DEPT_ZIP_CODE2,
				this._OTHER_REQUIREMENTS,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._QUALIFICATION_REQUIRE,
				this._OTHER_REQUIRE,
				this._MANAGE_TECHNOLOGY_REQUIRE,
				this._DEALING_UNIT,
				this._COMPLAINT_ADDRESS,
				this._COMPLAINT_PHONE,
				this._COMPLAINT_POSTCODE,
				this._CHANGE,
				this._GENERAL_CONTRACT,
				this._EMPLOYER_DUTY,
				this._SUPERVISOR,
				this._CONTRACTOR,
				this._CONSTRUCT_EQUIP_TEMP_FACIL,
				this._TRANSPORTATION,
				this._SURVEYING,
				this._SAFE_SECURITY_ENVIRON_PRO,
				this._SCHEDULE,
				this._COMMENCEMENT_COMPLETION,
				this._SUSPENSION_OF_WORKS,
				this._PROJECT_QUALITY,
				this._TEST_INSPECTION,
				this._MODIFICATION,
				this._PRICE_REGULATION,
				this._MEASUREMENT_PAYMENT,
				this._COMPLETION_ACCEPTANCE,
				this._LIABILITY_DEFECTS_WARRANTY,
				this._FORCE_MAJEURE,
				this._BREACH_CONTRACT,
				this._OTHER_CONVENTIONS,
				this._SUPPLY_ITEM,
				this._BILL_OF_QUANTITIES,
				this._DRAWING,
				this._TECHNICAL_STANDARD_REQUIRE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "JT_PORT_CON_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_PORT_CON_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总标段个数
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_PORT_CON_TENDER_FILE", "项目总标段个数");
            /// <summary>
			/// 本次招标标段个数
			/// </summary>
			public readonly static Field TENDERER_SECTION_NUMBER = new Field("TENDERER_SECTION_NUMBER", "JT_PORT_CON_TENDER_FILE", "本次招标标段个数");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_PORT_CON_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 项目经理资质等级
			/// </summary>
			public readonly static Field MANAGER_QUAL_LEVEL = new Field("MANAGER_QUAL_LEVEL", "JT_PORT_CON_TENDER_FILE", "项目经理资质等级");
            /// <summary>
			/// 项目经理职称
			/// </summary>
			public readonly static Field MANAGER_TECH_TITLE = new Field("MANAGER_TECH_TITLE", "JT_PORT_CON_TENDER_FILE", "项目经理职称");
            /// <summary>
			/// 主要负责人职称
			/// </summary>
			public readonly static Field CHARGE_TECH_TITLE = new Field("CHARGE_TECH_TITLE", "JT_PORT_CON_TENDER_FILE", "主要负责人职称");
            /// <summary>
			/// 类似项目业绩要求
			/// </summary>
			public readonly static Field CONSTRUCTION_PERFORMANCE = new Field("CONSTRUCTION_PERFORMANCE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "类似项目业绩要求");
            /// <summary>
			/// 保证金户名一
			/// </summary>
			public readonly static Field MARGIN_NAME1 = new Field("MARGIN_NAME1", "JT_PORT_CON_TENDER_FILE", "保证金户名一");
            /// <summary>
			/// 保证金账号一
			/// </summary>
			public readonly static Field MARGIN_NUMBER1 = new Field("MARGIN_NUMBER1", "JT_PORT_CON_TENDER_FILE", "保证金账号一");
            /// <summary>
			/// 开户银行一
			/// </summary>
			public readonly static Field MARGIN_BANK1 = new Field("MARGIN_BANK1", "JT_PORT_CON_TENDER_FILE", "开户银行一");
            /// <summary>
			/// 保证金户名二
			/// </summary>
			public readonly static Field MARGIN_NAME2 = new Field("MARGIN_NAME2", "JT_PORT_CON_TENDER_FILE", "保证金户名二");
            /// <summary>
			/// 保证金账号二
			/// </summary>
			public readonly static Field MARGIN_NUMBER2 = new Field("MARGIN_NUMBER2", "JT_PORT_CON_TENDER_FILE", "保证金账号二");
            /// <summary>
			/// 开户银行二
			/// </summary>
			public readonly static Field MARGIN_BANK2 = new Field("MARGIN_BANK2", "JT_PORT_CON_TENDER_FILE", "开户银行二");
            /// <summary>
			/// 保证金户名三
			/// </summary>
			public readonly static Field MARGIN_NAME3 = new Field("MARGIN_NAME3", "JT_PORT_CON_TENDER_FILE", "保证金户名三");
            /// <summary>
			/// 保证金账号三
			/// </summary>
			public readonly static Field MARGIN_NUMBER3 = new Field("MARGIN_NUMBER3", "JT_PORT_CON_TENDER_FILE", "保证金账号三");
            /// <summary>
			/// 开户银行三
			/// </summary>
			public readonly static Field MARGIN_BANK3 = new Field("MARGIN_BANK3", "JT_PORT_CON_TENDER_FILE", "开户银行三");
            /// <summary>
			/// 其他发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA4 = new Field("NOTICE_MEDIA4", "JT_PORT_CON_TENDER_FILE", "其他发布媒体");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_PORT_CON_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 总计划开工日期
			/// </summary>
			public readonly static Field BEGIN_ALL_DATE = new Field("BEGIN_ALL_DATE", "JT_PORT_CON_TENDER_FILE", "总计划开工日期");
            /// <summary>
			/// 计划交工日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "JT_PORT_CON_TENDER_FILE", "计划交工日期");
            /// <summary>
			/// 重要节点工期
			/// </summary>
			public readonly static Field IMPORTANT_LIMITE_TIME = new Field("IMPORTANT_LIMITE_TIME", "JT_PORT_CON_TENDER_FILE", "重要节点工期");
            /// <summary>
			/// 投标人提出问题的截止时间
			/// </summary>
			public readonly static Field QUESTION_TIME = new Field("QUESTION_TIME", "JT_PORT_CON_TENDER_FILE", "投标人提出问题的截止时间");
            /// <summary>
			/// 招标人书面澄清的时间
			/// </summary>
			public readonly static Field TENDER_NOTICE_TIME = new Field("TENDER_NOTICE_TIME", "JT_PORT_CON_TENDER_FILE", "招标人书面澄清的时间");
            /// <summary>
			/// 是否分包
			/// </summary>
			public readonly static Field SUBCONTRACT = new Field("SUBCONTRACT", "JT_PORT_CON_TENDER_FILE", "是否分包");
            /// <summary>
			/// 分包内容要求
			/// </summary>
			public readonly static Field SUBCONTRACT_CONTENT_REQUIRE = new Field("SUBCONTRACT_CONTENT_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "分包内容要求");
            /// <summary>
			/// 接受分包的第三人资质要求
			/// </summary>
			public readonly static Field SUB_QUALIFI_REQUIRE = new Field("SUB_QUALIFI_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "接受分包的第三人资质要求");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field BIDDER_NOTICE_TIME = new Field("BIDDER_NOTICE_TIME", "JT_PORT_CON_TENDER_FILE", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 公共资源交易中心名称
			/// </summary>
			public readonly static Field TRADING_CENTER_NAME = new Field("TRADING_CENTER_NAME", "JT_PORT_CON_TENDER_FILE", "公共资源交易中心名称");
            /// <summary>
			/// 近年财务状况起始年份
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_BEGIN = new Field("FINANCIAL_REQUIRE_BEGIN", "JT_PORT_CON_TENDER_FILE", "近年财务状况起始年份");
            /// <summary>
			/// 近年财务状况结束年份
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_END = new Field("FINANCIAL_REQUIRE_END", "JT_PORT_CON_TENDER_FILE", "近年财务状况结束年份");
            /// <summary>
			/// 完成的类似项目的起始年份
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_REQUIRE_BEGIN = new Field("SIMILAR_PROJECT_REQUIRE_BEGIN", "JT_PORT_CON_TENDER_FILE", "完成的类似项目的起始年份");
            /// <summary>
			/// 完成的类似项目的结束年份
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_REQUIRE_END = new Field("SIMILAR_PROJECT_REQUIRE_END", "JT_PORT_CON_TENDER_FILE", "完成的类似项目的结束年份");
            /// <summary>
			/// 发生的诉讼及仲裁情况的起始年份
			/// </summary>
			public readonly static Field LITIGATION_REQUIRE_BEGIN = new Field("LITIGATION_REQUIRE_BEGIN", "JT_PORT_CON_TENDER_FILE", "发生的诉讼及仲裁情况的起始年份");
            /// <summary>
			/// 发生的诉讼及仲裁情况的结束年份
			/// </summary>
			public readonly static Field LITIGATION_REQUIRE_END = new Field("LITIGATION_REQUIRE_END", "JT_PORT_CON_TENDER_FILE", "发生的诉讼及仲裁情况的结束年份");
            /// <summary>
			/// 是否允许递交备选投标方案
			/// </summary>
			public readonly static Field ALTERNATIVE_TENDER_SCHEME = new Field("ALTERNATIVE_TENDER_SCHEME", "JT_PORT_CON_TENDER_FILE", "是否允许递交备选投标方案");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_PORT_CON_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_PORT_CON_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_PORT_CON_TENDER_FILE", "专家人数");
            /// <summary>
			/// 是否授权评标委员会确定中标人
			/// </summary>
			public readonly static Field EXPERT_DETERMIN_BIDDER = new Field("EXPERT_DETERMIN_BIDDER", "JT_PORT_CON_TENDER_FILE", "是否授权评标委员会确定中标人");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_PRICE_TYPE = new Field("PERFORM_PRICE_TYPE", "JT_PORT_CON_TENDER_FILE", "履约担保形式");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "JT_PORT_CON_TENDER_FILE", "履约担保金额");
            /// <summary>
			/// 监督部门名称一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME1 = new Field("SUPERVISE_DEPT_NAME1", "JT_PORT_CON_TENDER_FILE", "监督部门名称一");
            /// <summary>
			/// 监督部门联系电话一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE1 = new Field("SUPERVISE_DEPT_PHONE1", "JT_PORT_CON_TENDER_FILE", "监督部门联系电话一");
            /// <summary>
			/// 监督部门地址一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS1 = new Field("SUPERVISE_DEPT_ADDRESS1", "JT_PORT_CON_TENDER_FILE", "监督部门地址一");
            /// <summary>
			/// 监督部门传真一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX1 = new Field("SUPERVISE_DEPT_FAX1", "JT_PORT_CON_TENDER_FILE", "监督部门传真一");
            /// <summary>
			/// 监督部门邮编一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE1 = new Field("SUPERVISE_DEPT_ZIP_CODE1", "JT_PORT_CON_TENDER_FILE", "监督部门邮编一");
            /// <summary>
			/// 监督部门名称二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME2 = new Field("SUPERVISE_DEPT_NAME2", "JT_PORT_CON_TENDER_FILE", "监督部门名称二");
            /// <summary>
			/// 监督部门联系电话二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE2 = new Field("SUPERVISE_DEPT_PHONE2", "JT_PORT_CON_TENDER_FILE", "监督部门联系电话二");
            /// <summary>
			/// 监督部门地址二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS2 = new Field("SUPERVISE_DEPT_ADDRESS2", "JT_PORT_CON_TENDER_FILE", "监督部门地址二");
            /// <summary>
			/// 监督部门传真二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX2 = new Field("SUPERVISE_DEPT_FAX2", "JT_PORT_CON_TENDER_FILE", "监督部门传真二");
            /// <summary>
			/// 监督部门邮编二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE2 = new Field("SUPERVISE_DEPT_ZIP_CODE2", "JT_PORT_CON_TENDER_FILE", "监督部门邮编二");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIREMENTS = new Field("OTHER_REQUIREMENTS", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 主要人员最低要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "主要人员最低要求");
            /// <summary>
			/// 其他最低要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "其他最低要求");
            /// <summary>
			/// 其他主要管理人员和技术人员最低要求
			/// </summary>
			public readonly static Field MANAGE_TECHNOLOGY_REQUIRE = new Field("MANAGE_TECHNOLOGY_REQUIRE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "其他主要管理人员和技术人员最低要求");
            /// <summary>
			/// 接收投诉单位名称
			/// </summary>
			public readonly static Field DEALING_UNIT = new Field("DEALING_UNIT", "JT_PORT_CON_TENDER_FILE", "接收投诉单位名称");
            /// <summary>
			/// 接收投诉单位地址
			/// </summary>
			public readonly static Field COMPLAINT_ADDRESS = new Field("COMPLAINT_ADDRESS", "JT_PORT_CON_TENDER_FILE", "接收投诉单位地址");
            /// <summary>
			/// 接收投诉单位电话
			/// </summary>
			public readonly static Field COMPLAINT_PHONE = new Field("COMPLAINT_PHONE", "JT_PORT_CON_TENDER_FILE", "接收投诉单位电话");
            /// <summary>
			/// 接收投诉单位邮编
			/// </summary>
			public readonly static Field COMPLAINT_POSTCODE = new Field("COMPLAINT_POSTCODE", "JT_PORT_CON_TENDER_FILE", "接收投诉单位邮编");
            /// <summary>
			/// 是否更改专用合同条款
			/// </summary>
			public readonly static Field CHANGE = new Field("CHANGE", "JT_PORT_CON_TENDER_FILE", "是否更改专用合同条款");
            /// <summary>
			/// 一般约定
			/// </summary>
			public readonly static Field GENERAL_CONTRACT = new Field("GENERAL_CONTRACT", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "一般约定");
            /// <summary>
			/// 发包人义务
			/// </summary>
			public readonly static Field EMPLOYER_DUTY = new Field("EMPLOYER_DUTY", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "发包人义务");
            /// <summary>
			/// 监理人
			/// </summary>
			public readonly static Field SUPERVISOR = new Field("SUPERVISOR", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "监理人");
            /// <summary>
			/// 承包人
			/// </summary>
			public readonly static Field CONTRACTOR = new Field("CONTRACTOR", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "承包人");
            /// <summary>
			/// 施工设备和临时设施
			/// </summary>
			public readonly static Field CONSTRUCT_EQUIP_TEMP_FACIL = new Field("CONSTRUCT_EQUIP_TEMP_FACIL", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "施工设备和临时设施");
            /// <summary>
			/// 交通运输
			/// </summary>
			public readonly static Field TRANSPORTATION = new Field("TRANSPORTATION", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "交通运输");
            /// <summary>
			/// 测量放线
			/// </summary>
			public readonly static Field SURVEYING = new Field("SURVEYING", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "测量放线");
            /// <summary>
			/// 施工安全、治安保卫和环境保护
			/// </summary>
			public readonly static Field SAFE_SECURITY_ENVIRON_PRO = new Field("SAFE_SECURITY_ENVIRON_PRO", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "施工安全、治安保卫和环境保护");
            /// <summary>
			/// 进度计划
			/// </summary>
			public readonly static Field SCHEDULE = new Field("SCHEDULE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "进度计划");
            /// <summary>
			/// 开工和竣工
			/// </summary>
			public readonly static Field COMMENCEMENT_COMPLETION = new Field("COMMENCEMENT_COMPLETION", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "开工和竣工");
            /// <summary>
			/// 暂停施工
			/// </summary>
			public readonly static Field SUSPENSION_OF_WORKS = new Field("SUSPENSION_OF_WORKS", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "暂停施工");
            /// <summary>
			/// 工程质量
			/// </summary>
			public readonly static Field PROJECT_QUALITY = new Field("PROJECT_QUALITY", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "工程质量");
            /// <summary>
			/// 试验和检验
			/// </summary>
			public readonly static Field TEST_INSPECTION = new Field("TEST_INSPECTION", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "试验和检验");
            /// <summary>
			/// 变更
			/// </summary>
			public readonly static Field MODIFICATION = new Field("MODIFICATION", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "变更");
            /// <summary>
			/// 价格调整
			/// </summary>
			public readonly static Field PRICE_REGULATION = new Field("PRICE_REGULATION", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "价格调整");
            /// <summary>
			/// 计量与支付
			/// </summary>
			public readonly static Field MEASUREMENT_PAYMENT = new Field("MEASUREMENT_PAYMENT", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "计量与支付");
            /// <summary>
			/// 竣工验收
			/// </summary>
			public readonly static Field COMPLETION_ACCEPTANCE = new Field("COMPLETION_ACCEPTANCE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "竣工验收");
            /// <summary>
			/// 缺陷责任与保修责任
			/// </summary>
			public readonly static Field LIABILITY_DEFECTS_WARRANTY = new Field("LIABILITY_DEFECTS_WARRANTY", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "缺陷责任与保修责任");
            /// <summary>
			/// 不可抗力
			/// </summary>
			public readonly static Field FORCE_MAJEURE = new Field("FORCE_MAJEURE", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "不可抗力");
            /// <summary>
			/// 违约
			/// </summary>
			public readonly static Field BREACH_CONTRACT = new Field("BREACH_CONTRACT", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "违约");
            /// <summary>
			/// 其他约定
			/// </summary>
			public readonly static Field OTHER_CONVENTIONS = new Field("OTHER_CONVENTIONS", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "其他约定");
            /// <summary>
			/// 其他补充条款
			/// </summary>
			public readonly static Field SUPPLY_ITEM = new Field("SUPPLY_ITEM", "JT_PORT_CON_TENDER_FILE",DbType.AnsiString, null, "其他补充条款");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_PORT_CON_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_PORT_CON_TENDER_FILE", "图纸");
            /// <summary>
			/// 技术标准和要求
			/// </summary>
			public readonly static Field TECHNICAL_STANDARD_REQUIRE = new Field("TECHNICAL_STANDARD_REQUIRE", "JT_PORT_CON_TENDER_FILE", "技术标准和要求");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_PORT_CON_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_PORT_CON_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_PORT_CON_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_PORT_CON_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_PORT_CON_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_PORT_CON_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_PORT_CON_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_PORT_CON_TENDER_FILE", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_PORT_CON_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_PORT_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_PORT_CON_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_PORT_CON_TENDER_FILE", "");
        }
        #endregion
	}
}