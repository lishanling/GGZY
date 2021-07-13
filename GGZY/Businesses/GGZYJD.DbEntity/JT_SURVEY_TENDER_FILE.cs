using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_SURVEY_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_SURVEY_TENDER_FILE")]
    [Serializable]
    public partial class JT_SURVEY_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _FUND_IMPLEMENTATION;
		private string _QUALITY_REQUIRE;
		private string _SUR_DES_TYPE;
		private decimal? _LIMITE_ALL_TIME;
		private string _PROJECT_PROFILE;
		private decimal? _TOTAL_SECTION_NUMBER;
		private decimal? _TENDERER_SECTION_NUMBER;
		private decimal? _RECONNAISSANCE_CYCLE;
		private string _SURVEY_TENDER_CONTENT;
		private string _DESIGN_TENDER_CONTENT;
		private decimal? _NUMBER_UNIONS;
		private string _TRADING_CENTER_NAME;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _OTHER_REQUIRE;
		private string _MANAGE_TECHNOLOGY_REQUIRE;
		private decimal? _SUBMIT_DESIGN_DAYS;
		private decimal? _MODIFY_DESIGN_DAYS;
		private decimal? _SUBMIT_CONSTRUCT_DAYS;
		private decimal? _MODIFY_CONSTRUCT_DAYS;
		private string _DESIGN_PERFORMANCE;
		private string _MANAGER_QUALIFICAT_TITLE;
		private string _MARGIN_NAME1;
		private string _MARGIN_NUMBER1;
		private string _MARGIN_BANK1;
		private string _MARGIN_NAME2;
		private string _MARGIN_NUMBER2;
		private string _MARGIN_BANK2;
		private string _MARGIN_NAME3;
		private string _MARGIN_NUMBER3;
		private string _MARGIN_BANK3;
		private string _TENDERER_BANK;
		private string _TENDERER_ACCOUNT;
		private string _TENDER_AGENCY_BANK;
		private string _TENDER_AGENCY_ACCOUNT;
		private string _SUBCONTRACT;
		private string _SUBCONTRACT_CONTENT_REQUIRE;
		private string _SUB_QUALIFI_REQUIRE;
		private DateTime? _QUESTION_TIME;
		private DateTime? _TENDER_NOTICE_TIME;
		private DateTime? _BIDDER_NOTICE_TIME;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EVALUATING_METHOD;
		private string _EXPERT_DETERMIN_BIDDER;
		private string _IS_PERFORM_PRICE;
		private decimal? _PERFORM_PRICE;
		private string _PERFORMANCE_BOND_FORM;
		private string _SUPERVISE_DEPT_NAME1;
		private string _SUPERVISE_DEPT_PHONE1;
		private string _SUPERVISE_ADDRESS1;
		private string _SUPERVISE_FAX1;
		private decimal? _SUPERVISE_ZIP_CODE1;
		private string _SUPERVISE_DEPT_NAME2;
		private string _SUPERVISE_DEPT_PHONE2;
		private string _SUPERVISE_ADDRESS2;
		private string _SUPERVISE_FAX2;
		private decimal? _SUPERVISE_ZIP_CODE2;
		private string _ACCEPTING_INSTITUTION;
		private string _COMPLAINT_ADDRESS;
		private string _COMPLAINTS_HOTLINE;
		private string _COMPLAINT_POST_CODE;
		private string _OTHER_REQUIREMENTS;
		private string _BONUS_CONTENT;
		private string _CHANGE;
		private string _DEFINITION;
		private string _EMPLOYER_DUTY;
		private string _DESIGNER_DUTY;
		private string _SUBMISSION_RESULTS;
		private string _BREACH_CONTRACT;
		private string _PAYMENT;
		private string _OTHER_CONVENTIONS;
		private string _SUPPLY_ITEM;
		private string _BASIC_DATA;
		private string _TECHNICAL_REQUIRE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private decimal? _SUPERVISOR_DAYS;
		private string _SUPER_SIMILAR_PROJECT;
		private string _GENERAL_QUAL_LEVEL;
		private string _GENERAL_TECH_TITLE;
		private string _SUPERVISION_SERVICE_STAGE;
		private string _SCOPE_SUPER_WORK;
		private string _FINANCIAL_REQUIRE_YEAR;
		private string _SIMILAR_PROJECT_YEAR;
		private string _LITIGATION_YEAR;
		private string _PERFORM_TYPE;
		private string _PERFORM_CONTENT1;
		private string _PERFORM_CONTENT2;
		private string _SUPERVISE_DEPT_ADDRESS1;
		private string _SUPERVISE_DEPT_FAX1;
		private string _SUPERVISE_DEPT_ZIP_CODE1;
		private string _SUPERVISE_DEPT_ADDRESS2;
		private string _SUPERVISE_DEPT_FAX2;
		private string _SUPERVISE_DEPT_ZIP_CODE2;
		private string _GENERAL_CONTRACT;
		private string _SUPERVISION_SERVICE;
		private string _CONTRACT_OPERATION;
		private string _MEASUREMENT_PAYMENT;
		private string _DISPUTE_RESOLUTION;
		private string _SERVICE_CHARGE;
		private string _DRAWING;
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
		/// 项目类别
		/// </summary>
		public string SUR_DES_TYPE
		{
			get{ return _SUR_DES_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SUR_DES_TYPE, _SUR_DES_TYPE, value);
				this._SUR_DES_TYPE = value;
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
		/// 总标段个数
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
		/// 勘察周期
		/// </summary>
		public decimal? RECONNAISSANCE_CYCLE
		{
			get{ return _RECONNAISSANCE_CYCLE; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE_CYCLE, _RECONNAISSANCE_CYCLE, value);
				this._RECONNAISSANCE_CYCLE = value;
			}
		}
		/// <summary>
		/// 勘察招标范围
		/// </summary>
		public string SURVEY_TENDER_CONTENT
		{
			get{ return _SURVEY_TENDER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_TENDER_CONTENT, _SURVEY_TENDER_CONTENT, value);
				this._SURVEY_TENDER_CONTENT = value;
			}
		}
		/// <summary>
		/// 设计招标范围
		/// </summary>
		public string DESIGN_TENDER_CONTENT
		{
			get{ return _DESIGN_TENDER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_TENDER_CONTENT, _DESIGN_TENDER_CONTENT, value);
				this._DESIGN_TENDER_CONTENT = value;
			}
		}
		/// <summary>
		/// 联合体成员数量要求
		/// </summary>
		public decimal? NUMBER_UNIONS
		{
			get{ return _NUMBER_UNIONS; }
			set
			{
				this.OnPropertyValueChange(_.NUMBER_UNIONS, _NUMBER_UNIONS, value);
				this._NUMBER_UNIONS = value;
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
		/// 资质条件
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
		/// 业绩要求
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
		/// 信誉要求
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
		/// 其他要求
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
		/// 其他主要专业负责人最低要求
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
		/// 提交初步设计文件送审稿时间
		/// </summary>
		public decimal? SUBMIT_DESIGN_DAYS
		{
			get{ return _SUBMIT_DESIGN_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_DESIGN_DAYS, _SUBMIT_DESIGN_DAYS, value);
				this._SUBMIT_DESIGN_DAYS = value;
			}
		}
		/// <summary>
		/// 提交修改后的正式初步设计文件时间
		/// </summary>
		public decimal? MODIFY_DESIGN_DAYS
		{
			get{ return _MODIFY_DESIGN_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_DESIGN_DAYS, _MODIFY_DESIGN_DAYS, value);
				this._MODIFY_DESIGN_DAYS = value;
			}
		}
		/// <summary>
		/// 提交施工图纸设计文件送审稿时间
		/// </summary>
		public decimal? SUBMIT_CONSTRUCT_DAYS
		{
			get{ return _SUBMIT_CONSTRUCT_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_CONSTRUCT_DAYS, _SUBMIT_CONSTRUCT_DAYS, value);
				this._SUBMIT_CONSTRUCT_DAYS = value;
			}
		}
		/// <summary>
		/// 提交修改后的正式施工图设计文件时间
		/// </summary>
		public decimal? MODIFY_CONSTRUCT_DAYS
		{
			get{ return _MODIFY_CONSTRUCT_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_CONSTRUCT_DAYS, _MODIFY_CONSTRUCT_DAYS, value);
				this._MODIFY_CONSTRUCT_DAYS = value;
			}
		}
		/// <summary>
		/// 类似项目业绩要求
		/// </summary>
		public string DESIGN_PERFORMANCE
		{
			get{ return _DESIGN_PERFORMANCE; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_PERFORMANCE, _DESIGN_PERFORMANCE, value);
				this._DESIGN_PERFORMANCE = value;
			}
		}
		/// <summary>
		/// 项目负责人资格要求
		/// </summary>
		public string MANAGER_QUALIFICAT_TITLE
		{
			get{ return _MANAGER_QUALIFICAT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_QUALIFICAT_TITLE, _MANAGER_QUALIFICAT_TITLE, value);
				this._MANAGER_QUALIFICAT_TITLE = value;
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
		/// 招标人开户行
		/// </summary>
		public string TENDERER_BANK
		{
			get{ return _TENDERER_BANK; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK, _TENDERER_BANK, value);
				this._TENDERER_BANK = value;
			}
		}
		/// <summary>
		/// 招标人银行账号
		/// </summary>
		public string TENDERER_ACCOUNT
		{
			get{ return _TENDERER_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_ACCOUNT, _TENDERER_ACCOUNT, value);
				this._TENDERER_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 招标代理机构开户行
		/// </summary>
		public string TENDER_AGENCY_BANK
		{
			get{ return _TENDER_AGENCY_BANK; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_BANK, _TENDER_AGENCY_BANK, value);
				this._TENDER_AGENCY_BANK = value;
			}
		}
		/// <summary>
		/// 招标代理银行账号
		/// </summary>
		public string TENDER_AGENCY_ACCOUNT
		{
			get{ return _TENDER_AGENCY_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_ACCOUNT, _TENDER_AGENCY_ACCOUNT, value);
				this._TENDER_AGENCY_ACCOUNT = value;
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
		/// 评标办法
		/// </summary>
		public string EVALUATING_METHOD
		{
			get{ return _EVALUATING_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_METHOD, _EVALUATING_METHOD, value);
				this._EVALUATING_METHOD = value;
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
		/// 是否提交履约
		/// </summary>
		public string IS_PERFORM_PRICE
		{
			get{ return _IS_PERFORM_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.IS_PERFORM_PRICE, _IS_PERFORM_PRICE, value);
				this._IS_PERFORM_PRICE = value;
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
		public string PERFORMANCE_BOND_FORM
		{
			get{ return _PERFORMANCE_BOND_FORM; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_BOND_FORM, _PERFORMANCE_BOND_FORM, value);
				this._PERFORMANCE_BOND_FORM = value;
			}
		}
		/// <summary>
		/// 交通部门名称一
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
		/// 交通部门联系电话一
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
		/// 交通部门地址一
		/// </summary>
		public string SUPERVISE_ADDRESS1
		{
			get{ return _SUPERVISE_ADDRESS1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_ADDRESS1, _SUPERVISE_ADDRESS1, value);
				this._SUPERVISE_ADDRESS1 = value;
			}
		}
		/// <summary>
		/// 交通部门传真一
		/// </summary>
		public string SUPERVISE_FAX1
		{
			get{ return _SUPERVISE_FAX1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_FAX1, _SUPERVISE_FAX1, value);
				this._SUPERVISE_FAX1 = value;
			}
		}
		/// <summary>
		/// 交通部门邮编一
		/// </summary>
		public decimal? SUPERVISE_ZIP_CODE1
		{
			get{ return _SUPERVISE_ZIP_CODE1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_ZIP_CODE1, _SUPERVISE_ZIP_CODE1, value);
				this._SUPERVISE_ZIP_CODE1 = value;
			}
		}
		/// <summary>
		/// 交通部门名称二
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
		/// 交通部门联系电话二
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
		/// 交通部门地址二
		/// </summary>
		public string SUPERVISE_ADDRESS2
		{
			get{ return _SUPERVISE_ADDRESS2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_ADDRESS2, _SUPERVISE_ADDRESS2, value);
				this._SUPERVISE_ADDRESS2 = value;
			}
		}
		/// <summary>
		/// 交通部门传真二
		/// </summary>
		public string SUPERVISE_FAX2
		{
			get{ return _SUPERVISE_FAX2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_FAX2, _SUPERVISE_FAX2, value);
				this._SUPERVISE_FAX2 = value;
			}
		}
		/// <summary>
		/// 交通部门邮编二
		/// </summary>
		public decimal? SUPERVISE_ZIP_CODE2
		{
			get{ return _SUPERVISE_ZIP_CODE2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_ZIP_CODE2, _SUPERVISE_ZIP_CODE2, value);
				this._SUPERVISE_ZIP_CODE2 = value;
			}
		}
		/// <summary>
		/// 投诉单位名称
		/// </summary>
		public string ACCEPTING_INSTITUTION
		{
			get{ return _ACCEPTING_INSTITUTION; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPTING_INSTITUTION, _ACCEPTING_INSTITUTION, value);
				this._ACCEPTING_INSTITUTION = value;
			}
		}
		/// <summary>
		/// 投诉单位地址
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
		/// 投诉单位电话
		/// </summary>
		public string COMPLAINTS_HOTLINE
		{
			get{ return _COMPLAINTS_HOTLINE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTS_HOTLINE, _COMPLAINTS_HOTLINE, value);
				this._COMPLAINTS_HOTLINE = value;
			}
		}
		/// <summary>
		/// 投诉单位邮编
		/// </summary>
		public string COMPLAINT_POST_CODE
		{
			get{ return _COMPLAINT_POST_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_POST_CODE, _COMPLAINT_POST_CODE, value);
				this._COMPLAINT_POST_CODE = value;
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
		/// 业绩分每增加一项设计业绩加2分
		/// </summary>
		public string BONUS_CONTENT
		{
			get{ return _BONUS_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BONUS_CONTENT, _BONUS_CONTENT, value);
				this._BONUS_CONTENT = value;
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
		/// 定义和解释
		/// </summary>
		public string DEFINITION
		{
			get{ return _DEFINITION; }
			set
			{
				this.OnPropertyValueChange(_.DEFINITION, _DEFINITION, value);
				this._DEFINITION = value;
			}
		}
		/// <summary>
		/// 发包人的责任和义务
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
		/// 设计人的责任和义务
		/// </summary>
		public string DESIGNER_DUTY
		{
			get{ return _DESIGNER_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.DESIGNER_DUTY, _DESIGNER_DUTY, value);
				this._DESIGNER_DUTY = value;
			}
		}
		/// <summary>
		/// 勘察设计周期及提交成果
		/// </summary>
		public string SUBMISSION_RESULTS
		{
			get{ return _SUBMISSION_RESULTS; }
			set
			{
				this.OnPropertyValueChange(_.SUBMISSION_RESULTS, _SUBMISSION_RESULTS, value);
				this._SUBMISSION_RESULTS = value;
			}
		}
		/// <summary>
		/// 违约与赔偿
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
		/// 费用与支付
		/// </summary>
		public string PAYMENT
		{
			get{ return _PAYMENT; }
			set
			{
				this.OnPropertyValueChange(_.PAYMENT, _PAYMENT, value);
				this._PAYMENT = value;
			}
		}
		/// <summary>
		/// 其他
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
		/// 招标人提供的资料
		/// </summary>
		public string BASIC_DATA
		{
			get{ return _BASIC_DATA; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_DATA, _BASIC_DATA, value);
				this._BASIC_DATA = value;
			}
		}
		/// <summary>
		/// 勘察设计技术要求
		/// </summary>
		public string TECHNICAL_REQUIRE
		{
			get{ return _TECHNICAL_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_REQUIRE, _TECHNICAL_REQUIRE, value);
				this._TECHNICAL_REQUIRE = value;
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
		/// 监理服务期
		/// </summary>
		public decimal? SUPERVISOR_DAYS
		{
			get{ return _SUPERVISOR_DAYS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_DAYS, _SUPERVISOR_DAYS, value);
				this._SUPERVISOR_DAYS = value;
			}
		}
		/// <summary>
		/// 类似项目业绩要求
		/// </summary>
		public string SUPER_SIMILAR_PROJECT
		{
			get{ return _SUPER_SIMILAR_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.SUPER_SIMILAR_PROJECT, _SUPER_SIMILAR_PROJECT, value);
				this._SUPER_SIMILAR_PROJECT = value;
			}
		}
		/// <summary>
		/// 总监理工程师资质名称及等级
		/// </summary>
		public string GENERAL_QUAL_LEVEL
		{
			get{ return _GENERAL_QUAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.GENERAL_QUAL_LEVEL, _GENERAL_QUAL_LEVEL, value);
				this._GENERAL_QUAL_LEVEL = value;
			}
		}
		/// <summary>
		/// 总监理师技术职称
		/// </summary>
		public string GENERAL_TECH_TITLE
		{
			get{ return _GENERAL_TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.GENERAL_TECH_TITLE, _GENERAL_TECH_TITLE, value);
				this._GENERAL_TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 监理服务阶段
		/// </summary>
		public string SUPERVISION_SERVICE_STAGE
		{
			get{ return _SUPERVISION_SERVICE_STAGE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_SERVICE_STAGE, _SUPERVISION_SERVICE_STAGE, value);
				this._SUPERVISION_SERVICE_STAGE = value;
			}
		}
		/// <summary>
		/// 监理工作范围
		/// </summary>
		public string SCOPE_SUPER_WORK
		{
			get{ return _SCOPE_SUPER_WORK; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE_SUPER_WORK, _SCOPE_SUPER_WORK, value);
				this._SCOPE_SUPER_WORK = value;
			}
		}
		/// <summary>
		/// 近年财务状况年份要求
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
		/// 完成的类似项目年份要求
		/// </summary>
		public string SIMILAR_PROJECT_YEAR
		{
			get{ return _SIMILAR_PROJECT_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_YEAR, _SIMILAR_PROJECT_YEAR, value);
				this._SIMILAR_PROJECT_YEAR = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况的年份要求
		/// </summary>
		public string LITIGATION_YEAR
		{
			get{ return _LITIGATION_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_YEAR, _LITIGATION_YEAR, value);
				this._LITIGATION_YEAR = value;
			}
		}
		/// <summary>
		/// 履约担保形式
		/// </summary>
		public string PERFORM_TYPE
		{
			get{ return _PERFORM_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_TYPE, _PERFORM_TYPE, value);
				this._PERFORM_TYPE = value;
			}
		}
		/// <summary>
		/// 担保银行信息
		/// </summary>
		public string PERFORM_CONTENT1
		{
			get{ return _PERFORM_CONTENT1; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_CONTENT1, _PERFORM_CONTENT1, value);
				this._PERFORM_CONTENT1 = value;
			}
		}
		/// <summary>
		/// 其他金融机构信息
		/// </summary>
		public string PERFORM_CONTENT2
		{
			get{ return _PERFORM_CONTENT2; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_CONTENT2, _PERFORM_CONTENT2, value);
				this._PERFORM_CONTENT2 = value;
			}
		}
		/// <summary>
		/// 投诉单位地址1
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
		/// 投诉单位传真1
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
		/// 投诉单位邮编1
		/// </summary>
		public string SUPERVISE_DEPT_ZIP_CODE1
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE1; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE1, _SUPERVISE_DEPT_ZIP_CODE1, value);
				this._SUPERVISE_DEPT_ZIP_CODE1 = value;
			}
		}
		/// <summary>
		/// 投诉单位地址2
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
		/// 投诉单位传真2
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
		/// 投诉单位邮编2
		/// </summary>
		public string SUPERVISE_DEPT_ZIP_CODE2
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE2; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE2, _SUPERVISE_DEPT_ZIP_CODE2, value);
				this._SUPERVISE_DEPT_ZIP_CODE2 = value;
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
		/// 监理服务
		/// </summary>
		public string SUPERVISION_SERVICE
		{
			get{ return _SUPERVISION_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_SERVICE, _SUPERVISION_SERVICE, value);
				this._SUPERVISION_SERVICE = value;
			}
		}
		/// <summary>
		/// 合同的生效、终止、服务时间和期限、变更、暂停与解除
		/// </summary>
		public string CONTRACT_OPERATION
		{
			get{ return _CONTRACT_OPERATION; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_OPERATION, _CONTRACT_OPERATION, value);
				this._CONTRACT_OPERATION = value;
			}
		}
		/// <summary>
		/// 监理服务费计费与支付
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
		/// 监理服务费报价
		/// </summary>
		public string SERVICE_CHARGE
		{
			get{ return _SERVICE_CHARGE; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_CHARGE, _SERVICE_CHARGE, value);
				this._SERVICE_CHARGE = value;
			}
		}
		/// <summary>
		/// 图纸和资料
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
				_.FUND_IMPLEMENTATION,
				_.QUALITY_REQUIRE,
				_.SUR_DES_TYPE,
				_.LIMITE_ALL_TIME,
				_.PROJECT_PROFILE,
				_.TOTAL_SECTION_NUMBER,
				_.TENDERER_SECTION_NUMBER,
				_.RECONNAISSANCE_CYCLE,
				_.SURVEY_TENDER_CONTENT,
				_.DESIGN_TENDER_CONTENT,
				_.NUMBER_UNIONS,
				_.TRADING_CENTER_NAME,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.OTHER_REQUIRE,
				_.MANAGE_TECHNOLOGY_REQUIRE,
				_.SUBMIT_DESIGN_DAYS,
				_.MODIFY_DESIGN_DAYS,
				_.SUBMIT_CONSTRUCT_DAYS,
				_.MODIFY_CONSTRUCT_DAYS,
				_.DESIGN_PERFORMANCE,
				_.MANAGER_QUALIFICAT_TITLE,
				_.MARGIN_NAME1,
				_.MARGIN_NUMBER1,
				_.MARGIN_BANK1,
				_.MARGIN_NAME2,
				_.MARGIN_NUMBER2,
				_.MARGIN_BANK2,
				_.MARGIN_NAME3,
				_.MARGIN_NUMBER3,
				_.MARGIN_BANK3,
				_.TENDERER_BANK,
				_.TENDERER_ACCOUNT,
				_.TENDER_AGENCY_BANK,
				_.TENDER_AGENCY_ACCOUNT,
				_.SUBCONTRACT,
				_.SUBCONTRACT_CONTENT_REQUIRE,
				_.SUB_QUALIFI_REQUIRE,
				_.QUESTION_TIME,
				_.TENDER_NOTICE_TIME,
				_.BIDDER_NOTICE_TIME,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EVALUATING_METHOD,
				_.EXPERT_DETERMIN_BIDDER,
				_.IS_PERFORM_PRICE,
				_.PERFORM_PRICE,
				_.PERFORMANCE_BOND_FORM,
				_.SUPERVISE_DEPT_NAME1,
				_.SUPERVISE_DEPT_PHONE1,
				_.SUPERVISE_ADDRESS1,
				_.SUPERVISE_FAX1,
				_.SUPERVISE_ZIP_CODE1,
				_.SUPERVISE_DEPT_NAME2,
				_.SUPERVISE_DEPT_PHONE2,
				_.SUPERVISE_ADDRESS2,
				_.SUPERVISE_FAX2,
				_.SUPERVISE_ZIP_CODE2,
				_.ACCEPTING_INSTITUTION,
				_.COMPLAINT_ADDRESS,
				_.COMPLAINTS_HOTLINE,
				_.COMPLAINT_POST_CODE,
				_.OTHER_REQUIREMENTS,
				_.BONUS_CONTENT,
				_.CHANGE,
				_.DEFINITION,
				_.EMPLOYER_DUTY,
				_.DESIGNER_DUTY,
				_.SUBMISSION_RESULTS,
				_.BREACH_CONTRACT,
				_.PAYMENT,
				_.OTHER_CONVENTIONS,
				_.SUPPLY_ITEM,
				_.BASIC_DATA,
				_.TECHNICAL_REQUIRE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.SUPERVISOR_DAYS,
				_.SUPER_SIMILAR_PROJECT,
				_.GENERAL_QUAL_LEVEL,
				_.GENERAL_TECH_TITLE,
				_.SUPERVISION_SERVICE_STAGE,
				_.SCOPE_SUPER_WORK,
				_.FINANCIAL_REQUIRE_YEAR,
				_.SIMILAR_PROJECT_YEAR,
				_.LITIGATION_YEAR,
				_.PERFORM_TYPE,
				_.PERFORM_CONTENT1,
				_.PERFORM_CONTENT2,
				_.SUPERVISE_DEPT_ADDRESS1,
				_.SUPERVISE_DEPT_FAX1,
				_.SUPERVISE_DEPT_ZIP_CODE1,
				_.SUPERVISE_DEPT_ADDRESS2,
				_.SUPERVISE_DEPT_FAX2,
				_.SUPERVISE_DEPT_ZIP_CODE2,
				_.GENERAL_CONTRACT,
				_.SUPERVISION_SERVICE,
				_.CONTRACT_OPERATION,
				_.MEASUREMENT_PAYMENT,
				_.DISPUTE_RESOLUTION,
				_.SERVICE_CHARGE,
				_.DRAWING,
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
				this._FUND_IMPLEMENTATION,
				this._QUALITY_REQUIRE,
				this._SUR_DES_TYPE,
				this._LIMITE_ALL_TIME,
				this._PROJECT_PROFILE,
				this._TOTAL_SECTION_NUMBER,
				this._TENDERER_SECTION_NUMBER,
				this._RECONNAISSANCE_CYCLE,
				this._SURVEY_TENDER_CONTENT,
				this._DESIGN_TENDER_CONTENT,
				this._NUMBER_UNIONS,
				this._TRADING_CENTER_NAME,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._OTHER_REQUIRE,
				this._MANAGE_TECHNOLOGY_REQUIRE,
				this._SUBMIT_DESIGN_DAYS,
				this._MODIFY_DESIGN_DAYS,
				this._SUBMIT_CONSTRUCT_DAYS,
				this._MODIFY_CONSTRUCT_DAYS,
				this._DESIGN_PERFORMANCE,
				this._MANAGER_QUALIFICAT_TITLE,
				this._MARGIN_NAME1,
				this._MARGIN_NUMBER1,
				this._MARGIN_BANK1,
				this._MARGIN_NAME2,
				this._MARGIN_NUMBER2,
				this._MARGIN_BANK2,
				this._MARGIN_NAME3,
				this._MARGIN_NUMBER3,
				this._MARGIN_BANK3,
				this._TENDERER_BANK,
				this._TENDERER_ACCOUNT,
				this._TENDER_AGENCY_BANK,
				this._TENDER_AGENCY_ACCOUNT,
				this._SUBCONTRACT,
				this._SUBCONTRACT_CONTENT_REQUIRE,
				this._SUB_QUALIFI_REQUIRE,
				this._QUESTION_TIME,
				this._TENDER_NOTICE_TIME,
				this._BIDDER_NOTICE_TIME,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EVALUATING_METHOD,
				this._EXPERT_DETERMIN_BIDDER,
				this._IS_PERFORM_PRICE,
				this._PERFORM_PRICE,
				this._PERFORMANCE_BOND_FORM,
				this._SUPERVISE_DEPT_NAME1,
				this._SUPERVISE_DEPT_PHONE1,
				this._SUPERVISE_ADDRESS1,
				this._SUPERVISE_FAX1,
				this._SUPERVISE_ZIP_CODE1,
				this._SUPERVISE_DEPT_NAME2,
				this._SUPERVISE_DEPT_PHONE2,
				this._SUPERVISE_ADDRESS2,
				this._SUPERVISE_FAX2,
				this._SUPERVISE_ZIP_CODE2,
				this._ACCEPTING_INSTITUTION,
				this._COMPLAINT_ADDRESS,
				this._COMPLAINTS_HOTLINE,
				this._COMPLAINT_POST_CODE,
				this._OTHER_REQUIREMENTS,
				this._BONUS_CONTENT,
				this._CHANGE,
				this._DEFINITION,
				this._EMPLOYER_DUTY,
				this._DESIGNER_DUTY,
				this._SUBMISSION_RESULTS,
				this._BREACH_CONTRACT,
				this._PAYMENT,
				this._OTHER_CONVENTIONS,
				this._SUPPLY_ITEM,
				this._BASIC_DATA,
				this._TECHNICAL_REQUIRE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._SUPERVISOR_DAYS,
				this._SUPER_SIMILAR_PROJECT,
				this._GENERAL_QUAL_LEVEL,
				this._GENERAL_TECH_TITLE,
				this._SUPERVISION_SERVICE_STAGE,
				this._SCOPE_SUPER_WORK,
				this._FINANCIAL_REQUIRE_YEAR,
				this._SIMILAR_PROJECT_YEAR,
				this._LITIGATION_YEAR,
				this._PERFORM_TYPE,
				this._PERFORM_CONTENT1,
				this._PERFORM_CONTENT2,
				this._SUPERVISE_DEPT_ADDRESS1,
				this._SUPERVISE_DEPT_FAX1,
				this._SUPERVISE_DEPT_ZIP_CODE1,
				this._SUPERVISE_DEPT_ADDRESS2,
				this._SUPERVISE_DEPT_FAX2,
				this._SUPERVISE_DEPT_ZIP_CODE2,
				this._GENERAL_CONTRACT,
				this._SUPERVISION_SERVICE,
				this._CONTRACT_OPERATION,
				this._MEASUREMENT_PAYMENT,
				this._DISPUTE_RESOLUTION,
				this._SERVICE_CHARGE,
				this._DRAWING,
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
			public readonly static Field All = new Field("*", "JT_SURVEY_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_SURVEY_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_SURVEY_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE = new Field("QUALITY_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "质量要求");
            /// <summary>
			/// 项目类别
			/// </summary>
			public readonly static Field SUR_DES_TYPE = new Field("SUR_DES_TYPE", "JT_SURVEY_TENDER_FILE", "项目类别");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_SURVEY_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 项目概况
			/// </summary>
			public readonly static Field PROJECT_PROFILE = new Field("PROJECT_PROFILE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "项目概况");
            /// <summary>
			/// 总标段个数
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_SURVEY_TENDER_FILE", "总标段个数");
            /// <summary>
			/// 本次招标标段个数
			/// </summary>
			public readonly static Field TENDERER_SECTION_NUMBER = new Field("TENDERER_SECTION_NUMBER", "JT_SURVEY_TENDER_FILE", "本次招标标段个数");
            /// <summary>
			/// 勘察周期
			/// </summary>
			public readonly static Field RECONNAISSANCE_CYCLE = new Field("RECONNAISSANCE_CYCLE", "JT_SURVEY_TENDER_FILE", "勘察周期");
            /// <summary>
			/// 勘察招标范围
			/// </summary>
			public readonly static Field SURVEY_TENDER_CONTENT = new Field("SURVEY_TENDER_CONTENT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "勘察招标范围");
            /// <summary>
			/// 设计招标范围
			/// </summary>
			public readonly static Field DESIGN_TENDER_CONTENT = new Field("DESIGN_TENDER_CONTENT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "设计招标范围");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field NUMBER_UNIONS = new Field("NUMBER_UNIONS", "JT_SURVEY_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 公共资源交易中心名称
			/// </summary>
			public readonly static Field TRADING_CENTER_NAME = new Field("TRADING_CENTER_NAME", "JT_SURVEY_TENDER_FILE", "公共资源交易中心名称");
            /// <summary>
			/// 资质条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "资质条件");
            /// <summary>
			/// 财务要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "财务要求");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "业绩要求");
            /// <summary>
			/// 信誉要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "信誉要求");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 其他主要专业负责人最低要求
			/// </summary>
			public readonly static Field MANAGE_TECHNOLOGY_REQUIRE = new Field("MANAGE_TECHNOLOGY_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他主要专业负责人最低要求");
            /// <summary>
			/// 提交初步设计文件送审稿时间
			/// </summary>
			public readonly static Field SUBMIT_DESIGN_DAYS = new Field("SUBMIT_DESIGN_DAYS", "JT_SURVEY_TENDER_FILE", "提交初步设计文件送审稿时间");
            /// <summary>
			/// 提交修改后的正式初步设计文件时间
			/// </summary>
			public readonly static Field MODIFY_DESIGN_DAYS = new Field("MODIFY_DESIGN_DAYS", "JT_SURVEY_TENDER_FILE", "提交修改后的正式初步设计文件时间");
            /// <summary>
			/// 提交施工图纸设计文件送审稿时间
			/// </summary>
			public readonly static Field SUBMIT_CONSTRUCT_DAYS = new Field("SUBMIT_CONSTRUCT_DAYS", "JT_SURVEY_TENDER_FILE", "提交施工图纸设计文件送审稿时间");
            /// <summary>
			/// 提交修改后的正式施工图设计文件时间
			/// </summary>
			public readonly static Field MODIFY_CONSTRUCT_DAYS = new Field("MODIFY_CONSTRUCT_DAYS", "JT_SURVEY_TENDER_FILE", "提交修改后的正式施工图设计文件时间");
            /// <summary>
			/// 类似项目业绩要求
			/// </summary>
			public readonly static Field DESIGN_PERFORMANCE = new Field("DESIGN_PERFORMANCE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "类似项目业绩要求");
            /// <summary>
			/// 项目负责人资格要求
			/// </summary>
			public readonly static Field MANAGER_QUALIFICAT_TITLE = new Field("MANAGER_QUALIFICAT_TITLE", "JT_SURVEY_TENDER_FILE", "项目负责人资格要求");
            /// <summary>
			/// 保证金户名一
			/// </summary>
			public readonly static Field MARGIN_NAME1 = new Field("MARGIN_NAME1", "JT_SURVEY_TENDER_FILE", "保证金户名一");
            /// <summary>
			/// 保证金账号一
			/// </summary>
			public readonly static Field MARGIN_NUMBER1 = new Field("MARGIN_NUMBER1", "JT_SURVEY_TENDER_FILE", "保证金账号一");
            /// <summary>
			/// 开户银行一
			/// </summary>
			public readonly static Field MARGIN_BANK1 = new Field("MARGIN_BANK1", "JT_SURVEY_TENDER_FILE", "开户银行一");
            /// <summary>
			/// 保证金户名二
			/// </summary>
			public readonly static Field MARGIN_NAME2 = new Field("MARGIN_NAME2", "JT_SURVEY_TENDER_FILE", "保证金户名二");
            /// <summary>
			/// 保证金账号二
			/// </summary>
			public readonly static Field MARGIN_NUMBER2 = new Field("MARGIN_NUMBER2", "JT_SURVEY_TENDER_FILE", "保证金账号二");
            /// <summary>
			/// 开户银行二
			/// </summary>
			public readonly static Field MARGIN_BANK2 = new Field("MARGIN_BANK2", "JT_SURVEY_TENDER_FILE", "开户银行二");
            /// <summary>
			/// 保证金户名三
			/// </summary>
			public readonly static Field MARGIN_NAME3 = new Field("MARGIN_NAME3", "JT_SURVEY_TENDER_FILE", "保证金户名三");
            /// <summary>
			/// 保证金账号三
			/// </summary>
			public readonly static Field MARGIN_NUMBER3 = new Field("MARGIN_NUMBER3", "JT_SURVEY_TENDER_FILE", "保证金账号三");
            /// <summary>
			/// 开户银行三
			/// </summary>
			public readonly static Field MARGIN_BANK3 = new Field("MARGIN_BANK3", "JT_SURVEY_TENDER_FILE", "开户银行三");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field TENDERER_BANK = new Field("TENDERER_BANK", "JT_SURVEY_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 招标人银行账号
			/// </summary>
			public readonly static Field TENDERER_ACCOUNT = new Field("TENDERER_ACCOUNT", "JT_SURVEY_TENDER_FILE", "招标人银行账号");
            /// <summary>
			/// 招标代理机构开户行
			/// </summary>
			public readonly static Field TENDER_AGENCY_BANK = new Field("TENDER_AGENCY_BANK", "JT_SURVEY_TENDER_FILE", "招标代理机构开户行");
            /// <summary>
			/// 招标代理银行账号
			/// </summary>
			public readonly static Field TENDER_AGENCY_ACCOUNT = new Field("TENDER_AGENCY_ACCOUNT", "JT_SURVEY_TENDER_FILE", "招标代理银行账号");
            /// <summary>
			/// 是否允许分包
			/// </summary>
			public readonly static Field SUBCONTRACT = new Field("SUBCONTRACT", "JT_SURVEY_TENDER_FILE", "是否允许分包");
            /// <summary>
			/// 分包内容要求
			/// </summary>
			public readonly static Field SUBCONTRACT_CONTENT_REQUIRE = new Field("SUBCONTRACT_CONTENT_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "分包内容要求");
            /// <summary>
			/// 接受分包的第三人资质要求
			/// </summary>
			public readonly static Field SUB_QUALIFI_REQUIRE = new Field("SUB_QUALIFI_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "接受分包的第三人资质要求");
            /// <summary>
			/// 投标人提出问题的截止时间
			/// </summary>
			public readonly static Field QUESTION_TIME = new Field("QUESTION_TIME", "JT_SURVEY_TENDER_FILE", "投标人提出问题的截止时间");
            /// <summary>
			/// 招标人书面澄清的时间
			/// </summary>
			public readonly static Field TENDER_NOTICE_TIME = new Field("TENDER_NOTICE_TIME", "JT_SURVEY_TENDER_FILE", "招标人书面澄清的时间");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field BIDDER_NOTICE_TIME = new Field("BIDDER_NOTICE_TIME", "JT_SURVEY_TENDER_FILE", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_SURVEY_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_SURVEY_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_SURVEY_TENDER_FILE", "专家人数");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "JT_SURVEY_TENDER_FILE", "评标办法");
            /// <summary>
			/// 是否授权评标委员会确定中标人
			/// </summary>
			public readonly static Field EXPERT_DETERMIN_BIDDER = new Field("EXPERT_DETERMIN_BIDDER", "JT_SURVEY_TENDER_FILE", "是否授权评标委员会确定中标人");
            /// <summary>
			/// 是否提交履约
			/// </summary>
			public readonly static Field IS_PERFORM_PRICE = new Field("IS_PERFORM_PRICE", "JT_SURVEY_TENDER_FILE", "是否提交履约");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "JT_SURVEY_TENDER_FILE", "履约担保金额");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORMANCE_BOND_FORM = new Field("PERFORMANCE_BOND_FORM", "JT_SURVEY_TENDER_FILE", "履约担保形式");
            /// <summary>
			/// 交通部门名称一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME1 = new Field("SUPERVISE_DEPT_NAME1", "JT_SURVEY_TENDER_FILE", "交通部门名称一");
            /// <summary>
			/// 交通部门联系电话一
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE1 = new Field("SUPERVISE_DEPT_PHONE1", "JT_SURVEY_TENDER_FILE", "交通部门联系电话一");
            /// <summary>
			/// 交通部门地址一
			/// </summary>
			public readonly static Field SUPERVISE_ADDRESS1 = new Field("SUPERVISE_ADDRESS1", "JT_SURVEY_TENDER_FILE", "交通部门地址一");
            /// <summary>
			/// 交通部门传真一
			/// </summary>
			public readonly static Field SUPERVISE_FAX1 = new Field("SUPERVISE_FAX1", "JT_SURVEY_TENDER_FILE", "交通部门传真一");
            /// <summary>
			/// 交通部门邮编一
			/// </summary>
			public readonly static Field SUPERVISE_ZIP_CODE1 = new Field("SUPERVISE_ZIP_CODE1", "JT_SURVEY_TENDER_FILE", "交通部门邮编一");
            /// <summary>
			/// 交通部门名称二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME2 = new Field("SUPERVISE_DEPT_NAME2", "JT_SURVEY_TENDER_FILE", "交通部门名称二");
            /// <summary>
			/// 交通部门联系电话二
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE2 = new Field("SUPERVISE_DEPT_PHONE2", "JT_SURVEY_TENDER_FILE", "交通部门联系电话二");
            /// <summary>
			/// 交通部门地址二
			/// </summary>
			public readonly static Field SUPERVISE_ADDRESS2 = new Field("SUPERVISE_ADDRESS2", "JT_SURVEY_TENDER_FILE", "交通部门地址二");
            /// <summary>
			/// 交通部门传真二
			/// </summary>
			public readonly static Field SUPERVISE_FAX2 = new Field("SUPERVISE_FAX2", "JT_SURVEY_TENDER_FILE", "交通部门传真二");
            /// <summary>
			/// 交通部门邮编二
			/// </summary>
			public readonly static Field SUPERVISE_ZIP_CODE2 = new Field("SUPERVISE_ZIP_CODE2", "JT_SURVEY_TENDER_FILE", "交通部门邮编二");
            /// <summary>
			/// 投诉单位名称
			/// </summary>
			public readonly static Field ACCEPTING_INSTITUTION = new Field("ACCEPTING_INSTITUTION", "JT_SURVEY_TENDER_FILE", "投诉单位名称");
            /// <summary>
			/// 投诉单位地址
			/// </summary>
			public readonly static Field COMPLAINT_ADDRESS = new Field("COMPLAINT_ADDRESS", "JT_SURVEY_TENDER_FILE", "投诉单位地址");
            /// <summary>
			/// 投诉单位电话
			/// </summary>
			public readonly static Field COMPLAINTS_HOTLINE = new Field("COMPLAINTS_HOTLINE", "JT_SURVEY_TENDER_FILE", "投诉单位电话");
            /// <summary>
			/// 投诉单位邮编
			/// </summary>
			public readonly static Field COMPLAINT_POST_CODE = new Field("COMPLAINT_POST_CODE", "JT_SURVEY_TENDER_FILE", "投诉单位邮编");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIREMENTS = new Field("OTHER_REQUIREMENTS", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 业绩分每增加一项设计业绩加2分
			/// </summary>
			public readonly static Field BONUS_CONTENT = new Field("BONUS_CONTENT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "业绩分每增加一项设计业绩加2分");
            /// <summary>
			/// 是否更改专用合同条款
			/// </summary>
			public readonly static Field CHANGE = new Field("CHANGE", "JT_SURVEY_TENDER_FILE", "是否更改专用合同条款");
            /// <summary>
			/// 定义和解释
			/// </summary>
			public readonly static Field DEFINITION = new Field("DEFINITION", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "定义和解释");
            /// <summary>
			/// 发包人的责任和义务
			/// </summary>
			public readonly static Field EMPLOYER_DUTY = new Field("EMPLOYER_DUTY", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "发包人的责任和义务");
            /// <summary>
			/// 设计人的责任和义务
			/// </summary>
			public readonly static Field DESIGNER_DUTY = new Field("DESIGNER_DUTY", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "设计人的责任和义务");
            /// <summary>
			/// 勘察设计周期及提交成果
			/// </summary>
			public readonly static Field SUBMISSION_RESULTS = new Field("SUBMISSION_RESULTS", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "勘察设计周期及提交成果");
            /// <summary>
			/// 违约与赔偿
			/// </summary>
			public readonly static Field BREACH_CONTRACT = new Field("BREACH_CONTRACT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "违约与赔偿");
            /// <summary>
			/// 费用与支付
			/// </summary>
			public readonly static Field PAYMENT = new Field("PAYMENT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "费用与支付");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER_CONVENTIONS = new Field("OTHER_CONVENTIONS", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 其他补充条款
			/// </summary>
			public readonly static Field SUPPLY_ITEM = new Field("SUPPLY_ITEM", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他补充条款");
            /// <summary>
			/// 招标人提供的资料
			/// </summary>
			public readonly static Field BASIC_DATA = new Field("BASIC_DATA", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "招标人提供的资料");
            /// <summary>
			/// 勘察设计技术要求
			/// </summary>
			public readonly static Field TECHNICAL_REQUIRE = new Field("TECHNICAL_REQUIRE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "勘察设计技术要求");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_SURVEY_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_SURVEY_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_SURVEY_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_SURVEY_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_SURVEY_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_SURVEY_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_SURVEY_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_SURVEY_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_SURVEY_TENDER_FILE", "M_TM");
            /// <summary>
			/// 监理服务期
			/// </summary>
			public readonly static Field SUPERVISOR_DAYS = new Field("SUPERVISOR_DAYS", "JT_SURVEY_TENDER_FILE", "监理服务期");
            /// <summary>
			/// 类似项目业绩要求
			/// </summary>
			public readonly static Field SUPER_SIMILAR_PROJECT = new Field("SUPER_SIMILAR_PROJECT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "类似项目业绩要求");
            /// <summary>
			/// 总监理工程师资质名称及等级
			/// </summary>
			public readonly static Field GENERAL_QUAL_LEVEL = new Field("GENERAL_QUAL_LEVEL", "JT_SURVEY_TENDER_FILE", "总监理工程师资质名称及等级");
            /// <summary>
			/// 总监理师技术职称
			/// </summary>
			public readonly static Field GENERAL_TECH_TITLE = new Field("GENERAL_TECH_TITLE", "JT_SURVEY_TENDER_FILE", "总监理师技术职称");
            /// <summary>
			/// 监理服务阶段
			/// </summary>
			public readonly static Field SUPERVISION_SERVICE_STAGE = new Field("SUPERVISION_SERVICE_STAGE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "监理服务阶段");
            /// <summary>
			/// 监理工作范围
			/// </summary>
			public readonly static Field SCOPE_SUPER_WORK = new Field("SCOPE_SUPER_WORK", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "监理工作范围");
            /// <summary>
			/// 近年财务状况年份要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_YEAR = new Field("FINANCIAL_REQUIRE_YEAR", "JT_SURVEY_TENDER_FILE", "近年财务状况年份要求");
            /// <summary>
			/// 完成的类似项目年份要求
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_YEAR = new Field("SIMILAR_PROJECT_YEAR", "JT_SURVEY_TENDER_FILE", "完成的类似项目年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况的年份要求
			/// </summary>
			public readonly static Field LITIGATION_YEAR = new Field("LITIGATION_YEAR", "JT_SURVEY_TENDER_FILE", "发生的诉讼及仲裁情况的年份要求");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_TYPE = new Field("PERFORM_TYPE", "JT_SURVEY_TENDER_FILE", "履约担保形式");
            /// <summary>
			/// 担保银行信息
			/// </summary>
			public readonly static Field PERFORM_CONTENT1 = new Field("PERFORM_CONTENT1", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "担保银行信息");
            /// <summary>
			/// 其他金融机构信息
			/// </summary>
			public readonly static Field PERFORM_CONTENT2 = new Field("PERFORM_CONTENT2", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他金融机构信息");
            /// <summary>
			/// 投诉单位地址1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS1 = new Field("SUPERVISE_DEPT_ADDRESS1", "JT_SURVEY_TENDER_FILE", "投诉单位地址1");
            /// <summary>
			/// 投诉单位传真1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX1 = new Field("SUPERVISE_DEPT_FAX1", "JT_SURVEY_TENDER_FILE", "投诉单位传真1");
            /// <summary>
			/// 投诉单位邮编1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE1 = new Field("SUPERVISE_DEPT_ZIP_CODE1", "JT_SURVEY_TENDER_FILE", "投诉单位邮编1");
            /// <summary>
			/// 投诉单位地址2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS2 = new Field("SUPERVISE_DEPT_ADDRESS2", "JT_SURVEY_TENDER_FILE", "投诉单位地址2");
            /// <summary>
			/// 投诉单位传真2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX2 = new Field("SUPERVISE_DEPT_FAX2", "JT_SURVEY_TENDER_FILE", "投诉单位传真2");
            /// <summary>
			/// 投诉单位邮编2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE2 = new Field("SUPERVISE_DEPT_ZIP_CODE2", "JT_SURVEY_TENDER_FILE", "投诉单位邮编2");
            /// <summary>
			/// 一般约定
			/// </summary>
			public readonly static Field GENERAL_CONTRACT = new Field("GENERAL_CONTRACT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "一般约定");
            /// <summary>
			/// 监理服务
			/// </summary>
			public readonly static Field SUPERVISION_SERVICE = new Field("SUPERVISION_SERVICE", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "监理服务");
            /// <summary>
			/// 合同的生效、终止、服务时间和期限、变更、暂停与解除
			/// </summary>
			public readonly static Field CONTRACT_OPERATION = new Field("CONTRACT_OPERATION", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "合同的生效、终止、服务时间和期限、变更、暂停与解除");
            /// <summary>
			/// 监理服务费计费与支付
			/// </summary>
			public readonly static Field MEASUREMENT_PAYMENT = new Field("MEASUREMENT_PAYMENT", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "监理服务费计费与支付");
            /// <summary>
			/// 争议的解决
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_SURVEY_TENDER_FILE",DbType.AnsiString, null, "争议的解决");
            /// <summary>
			/// 监理服务费报价
			/// </summary>
			public readonly static Field SERVICE_CHARGE = new Field("SERVICE_CHARGE", "JT_SURVEY_TENDER_FILE", "监理服务费报价");
            /// <summary>
			/// 图纸和资料
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_SURVEY_TENDER_FILE", "图纸和资料");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_SURVEY_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_SURVEY_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_SURVEY_TENDER_FILE", "");
        }
        #endregion
	}
}