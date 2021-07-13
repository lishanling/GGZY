using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_GEN_SUPER_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_GEN_SUPER_TENDER_FILE")]
    [Serializable]
    public partial class JT_GEN_SUPER_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private string _TENDER_PROJECT_PART;
		private decimal? _TOTAL_SECTION_NUMBER;
		private string _CONTRACT_SECTION;
		private string _TENDERER_CONTRACT_SECTION;
		private string _SUPERVISION_PRICE_ADJUST;
		private decimal? _OFFICE_NUMBER1;
		private decimal? _OFFICE_NUMBER2;
		private string _SUPERVISION_ORGA;
		private string _MANAGE_MEASURES_CONTENT;
		private string _ACHIEVEMENT_TIME;
		private string _ACHIEVEMENT_CONDITIONS;
		private string _ACHI_PERSON_CONDITIONS;
		private decimal? _CONTRACT_SEGMENT;
		private decimal? _TENDER_NUMBER;
		private decimal? _TENDER_DOC_PRICE;
		private decimal? _SYNDICATED_NUMBER;
		private string _LIMITE_TIME_UNIT;
		private string _SET_LABORATORY;
		private string _IF_ACHIEVEMENT;
		private string _IF_ACHI_PERSON;
		private string _OPEN_BID_REQURE_CHOOSE;
		private string _BID_OPEN_TYPE;
		private string _UPPER_LOWER_LIMIT;
		private string _ENGINEER_TITLE;
		private decimal? _ENGINEER_WORK_YEAR;
		private decimal? _ENGINEER_AGE;
		private string _TEST_DIRECTOR_MAGOR;
		private decimal? _TEST_DIRECTOR_WORK_YEAR;
		private decimal? _TEST_DIRECTOR_AGE;
		private string _TEST_DIRECTOR_EXPER;
		private DateTime? _OTHER_PERSON_YEAR_BEGIN;
		private string _OTHER_PERSON_YEAR;
		private decimal? _FINANCE_YEAR1;
		private decimal? _FINANCE_YEAR2;
		private decimal? _FINANCE_YEAR3;
		private decimal? _AVE_TURNOVER;
		private DateTime? _REPUTATION_TIME1;
		private DateTime? _REPUTATION_TIME2;
		private DateTime? _REPUTATION_TIME4;
		private decimal? _REPUTATION_LEVEL;
		private string _SUBC_NAME;
		private string _PROJECT_APPROVAL;
		private string _FUND_PLACE;
		private string _DRAWING;
		private string _ENCLOSURE1;
		private string _ENCLOSURE2;
		private string _ENCLOSURE3;
		private string _QUALIFICATION_REQUIRE;
		private string _REMARK;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private DateTime? _MARGIN_TIME;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _SECTION_DIVIDE_CONTENT;
		private string _CONST_MANAGEMENT;
		private DateTime? _ANSWER_QUESTION_TIME;
		private decimal? _DOC_NUMBER;
		private decimal? _COPY_NUM;
		private decimal? _BID_CONFIDENTIAL_TIME;
		private decimal? _NOTIFICATION_TIME;
		private string _MAIN_ENGINEER_QUANTITY_LIST;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_PHONE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private string _SUPERVISE_DEPT_FAX;
		private DateTime? _QUESTION_TIME;
		private DateTime? _TENDER_NOTICE_TIME;
		private decimal? _BIDDER_NOTICE_TIME;
		private string _OTHER_REQUIREMENTS;
		private string _PROJECT_DESCRIPTION;
		private string _SKETCH_MAP;
		private string _PERIOD_SERVICE_TIME;
		private string _MINIMUM_QUALIFICATIONS;
		private string _ACHIEVEMENT_REQUIRE;
		private string _OTHER_PERSON_REQUIRE;
		private string _EQUIPMENT_REQUIRE;
		private string _FINANCIAL_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private decimal? _REVIEW_AAAW_YEAR;
		private decimal? _AA_BID_NUMBER;
		private decimal? _A_BID_NUMBER;
		private string _SUPERVISION_STANDARD;
		private DateTime? _BOND_SUBMIT_TIME;
		private DateTime? _PERFORM_PRICE_TIME;
		private string _MARGIN_RETURN_TYPE;
		private decimal? _PERFORM_PRICE;
		private decimal? _ACHIE_YEAR;
		private DateTime? _ACHIE_YEAR_BEGIN;
		private string _CHANGE;
		private string _DEFINITION_EXPLANATION;
		private string _SUPERVISOR_OBLIGATIONS;
		private string _EMPLOYER_DUTY;
		private string _RESPONSIBILITY;
		private string _CONTRACT_OPERATION;
		private string _MEASUREMENT_PAYMENT;
		private string _DISPUTE_RESOLUTION;
		private string _OTHER_CONVENTIONS;
		private string _SUPPLY_ITEM;
		private string _UPERVISION_STANDARD;
		private string _ENGINEERING_SPECIFICATIONS;
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
		/// 公告招标项目
		/// </summary>
		public string TENDER_PROJECT_PART
		{
			get{ return _TENDER_PROJECT_PART; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_PART, _TENDER_PROJECT_PART, value);
				this._TENDER_PROJECT_PART = value;
			}
		}
		/// <summary>
		/// 施工监理合同段数量
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
		/// 标段名称
		/// </summary>
		public string CONTRACT_SECTION
		{
			get{ return _CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SECTION, _CONTRACT_SECTION, value);
				this._CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 本次招标的合同段
		/// </summary>
		public string TENDERER_CONTRACT_SECTION
		{
			get{ return _TENDERER_CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTRACT_SECTION, _TENDERER_CONTRACT_SECTION, value);
				this._TENDERER_CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 建设工期延长监理费是否调整
		/// </summary>
		public string SUPERVISION_PRICE_ADJUST
		{
			get{ return _SUPERVISION_PRICE_ADJUST; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_PRICE_ADJUST, _SUPERVISION_PRICE_ADJUST, value);
				this._SUPERVISION_PRICE_ADJUST = value;
			}
		}
		/// <summary>
		/// 总监理工程师办公室数量
		/// </summary>
		public decimal? OFFICE_NUMBER1
		{
			get{ return _OFFICE_NUMBER1; }
			set
			{
				this.OnPropertyValueChange(_.OFFICE_NUMBER1, _OFFICE_NUMBER1, value);
				this._OFFICE_NUMBER1 = value;
			}
		}
		/// <summary>
		/// 驻地监理工程师办公室数量
		/// </summary>
		public decimal? OFFICE_NUMBER2
		{
			get{ return _OFFICE_NUMBER2; }
			set
			{
				this.OnPropertyValueChange(_.OFFICE_NUMBER2, _OFFICE_NUMBER2, value);
				this._OFFICE_NUMBER2 = value;
			}
		}
		/// <summary>
		/// 本项目设置的监理机构级别
		/// </summary>
		public string SUPERVISION_ORGA
		{
			get{ return _SUPERVISION_ORGA; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_ORGA, _SUPERVISION_ORGA, value);
				this._SUPERVISION_ORGA = value;
			}
		}
		/// <summary>
		/// 主要建设内容
		/// </summary>
		public string MANAGE_MEASURES_CONTENT
		{
			get{ return _MANAGE_MEASURES_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.MANAGE_MEASURES_CONTENT, _MANAGE_MEASURES_CONTENT, value);
				this._MANAGE_MEASURES_CONTENT = value;
			}
		}
		/// <summary>
		/// 企业业绩年份要求
		/// </summary>
		public string ACHIEVEMENT_TIME
		{
			get{ return _ACHIEVEMENT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT_TIME, _ACHIEVEMENT_TIME, value);
				this._ACHIEVEMENT_TIME = value;
			}
		}
		/// <summary>
		/// 企业业绩要求
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
		/// 主要人员业绩要求
		/// </summary>
		public string ACHI_PERSON_CONDITIONS
		{
			get{ return _ACHI_PERSON_CONDITIONS; }
			set
			{
				this.OnPropertyValueChange(_.ACHI_PERSON_CONDITIONS, _ACHI_PERSON_CONDITIONS, value);
				this._ACHI_PERSON_CONDITIONS = value;
			}
		}
		/// <summary>
		/// 投标人可参投监理合同段数量
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
		/// 投标人最多可中标数量
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
		/// 线上递交投标文件费用
		/// </summary>
		public decimal? TENDER_DOC_PRICE
		{
			get{ return _TENDER_DOC_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_PRICE, _TENDER_DOC_PRICE, value);
				this._TENDER_DOC_PRICE = value;
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
		/// 是否按照惯例办法设置中心实验室
		/// </summary>
		public string SET_LABORATORY
		{
			get{ return _SET_LABORATORY; }
			set
			{
				this.OnPropertyValueChange(_.SET_LABORATORY, _SET_LABORATORY, value);
				this._SET_LABORATORY = value;
			}
		}
		/// <summary>
		/// 是否要求企业业绩
		/// </summary>
		public string IF_ACHIEVEMENT
		{
			get{ return _IF_ACHIEVEMENT; }
			set
			{
				this.OnPropertyValueChange(_.IF_ACHIEVEMENT, _IF_ACHIEVEMENT, value);
				this._IF_ACHIEVEMENT = value;
			}
		}
		/// <summary>
		/// 是否要求个人业绩
		/// </summary>
		public string IF_ACHI_PERSON
		{
			get{ return _IF_ACHI_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.IF_ACHI_PERSON, _IF_ACHI_PERSON, value);
				this._IF_ACHI_PERSON = value;
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
		/// 开标方式
		/// </summary>
		public string BID_OPEN_TYPE
		{
			get{ return _BID_OPEN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TYPE, _BID_OPEN_TYPE, value);
				this._BID_OPEN_TYPE = value;
			}
		}
		/// <summary>
		/// 是否设定投标控制价上、下限
		/// </summary>
		public string UPPER_LOWER_LIMIT
		{
			get{ return _UPPER_LOWER_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.UPPER_LOWER_LIMIT, _UPPER_LOWER_LIMIT, value);
				this._UPPER_LOWER_LIMIT = value;
			}
		}
		/// <summary>
		/// 总监理工程师职称
		/// </summary>
		public string ENGINEER_TITLE
		{
			get{ return _ENGINEER_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEER_TITLE, _ENGINEER_TITLE, value);
				this._ENGINEER_TITLE = value;
			}
		}
		/// <summary>
		/// 总监理工程师工作年限
		/// </summary>
		public decimal? ENGINEER_WORK_YEAR
		{
			get{ return _ENGINEER_WORK_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEER_WORK_YEAR, _ENGINEER_WORK_YEAR, value);
				this._ENGINEER_WORK_YEAR = value;
			}
		}
		/// <summary>
		/// 总监理工程师年龄
		/// </summary>
		public decimal? ENGINEER_AGE
		{
			get{ return _ENGINEER_AGE; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEER_AGE, _ENGINEER_AGE, value);
				this._ENGINEER_AGE = value;
			}
		}
		/// <summary>
		/// 试验室主任专业
		/// </summary>
		public string TEST_DIRECTOR_MAGOR
		{
			get{ return _TEST_DIRECTOR_MAGOR; }
			set
			{
				this.OnPropertyValueChange(_.TEST_DIRECTOR_MAGOR, _TEST_DIRECTOR_MAGOR, value);
				this._TEST_DIRECTOR_MAGOR = value;
			}
		}
		/// <summary>
		/// 试验室主任工作年限
		/// </summary>
		public decimal? TEST_DIRECTOR_WORK_YEAR
		{
			get{ return _TEST_DIRECTOR_WORK_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.TEST_DIRECTOR_WORK_YEAR, _TEST_DIRECTOR_WORK_YEAR, value);
				this._TEST_DIRECTOR_WORK_YEAR = value;
			}
		}
		/// <summary>
		/// 试验室主任年龄
		/// </summary>
		public decimal? TEST_DIRECTOR_AGE
		{
			get{ return _TEST_DIRECTOR_AGE; }
			set
			{
				this.OnPropertyValueChange(_.TEST_DIRECTOR_AGE, _TEST_DIRECTOR_AGE, value);
				this._TEST_DIRECTOR_AGE = value;
			}
		}
		/// <summary>
		/// 试验室主任工作经历
		/// </summary>
		public string TEST_DIRECTOR_EXPER
		{
			get{ return _TEST_DIRECTOR_EXPER; }
			set
			{
				this.OnPropertyValueChange(_.TEST_DIRECTOR_EXPER, _TEST_DIRECTOR_EXPER, value);
				this._TEST_DIRECTOR_EXPER = value;
			}
		}
		/// <summary>
		/// 近年其他人员时间要求
		/// </summary>
		public DateTime? OTHER_PERSON_YEAR_BEGIN
		{
			get{ return _OTHER_PERSON_YEAR_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_PERSON_YEAR_BEGIN, _OTHER_PERSON_YEAR_BEGIN, value);
				this._OTHER_PERSON_YEAR_BEGIN = value;
			}
		}
		/// <summary>
		/// 其他人员年份数要求
		/// </summary>
		public string OTHER_PERSON_YEAR
		{
			get{ return _OTHER_PERSON_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_PERSON_YEAR, _OTHER_PERSON_YEAR, value);
				this._OTHER_PERSON_YEAR = value;
			}
		}
		/// <summary>
		/// 财务年份1
		/// </summary>
		public decimal? FINANCE_YEAR1
		{
			get{ return _FINANCE_YEAR1; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_YEAR1, _FINANCE_YEAR1, value);
				this._FINANCE_YEAR1 = value;
			}
		}
		/// <summary>
		/// 财务年份2
		/// </summary>
		public decimal? FINANCE_YEAR2
		{
			get{ return _FINANCE_YEAR2; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_YEAR2, _FINANCE_YEAR2, value);
				this._FINANCE_YEAR2 = value;
			}
		}
		/// <summary>
		/// 财务年份3
		/// </summary>
		public decimal? FINANCE_YEAR3
		{
			get{ return _FINANCE_YEAR3; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_YEAR3, _FINANCE_YEAR3, value);
				this._FINANCE_YEAR3 = value;
			}
		}
		/// <summary>
		/// 同年平均营业额不少于
		/// </summary>
		public decimal? AVE_TURNOVER
		{
			get{ return _AVE_TURNOVER; }
			set
			{
				this.OnPropertyValueChange(_.AVE_TURNOVER, _AVE_TURNOVER, value);
				this._AVE_TURNOVER = value;
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
		/// 未被认定时间要求
		/// </summary>
		public DateTime? REPUTATION_TIME4
		{
			get{ return _REPUTATION_TIME4; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_TIME4, _REPUTATION_TIME4, value);
				this._REPUTATION_TIME4 = value;
			}
		}
		/// <summary>
		/// 未被认定等级
		/// </summary>
		public decimal? REPUTATION_LEVEL
		{
			get{ return _REPUTATION_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_LEVEL, _REPUTATION_LEVEL, value);
				this._REPUTATION_LEVEL = value;
			}
		}
		/// <summary>
		/// 发包人名称
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
		/// 立项审批情况
		/// </summary>
		public string PROJECT_APPROVAL
		{
			get{ return _PROJECT_APPROVAL; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_APPROVAL, _PROJECT_APPROVAL, value);
				this._PROJECT_APPROVAL = value;
			}
		}
		/// <summary>
		/// 资金组成及到位情况
		/// </summary>
		public string FUND_PLACE
		{
			get{ return _FUND_PLACE; }
			set
			{
				this.OnPropertyValueChange(_.FUND_PLACE, _FUND_PLACE, value);
				this._FUND_PLACE = value;
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
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
		/// 标段划分
		/// </summary>
		public string SECTION_DIVIDE_CONTENT
		{
			get{ return _SECTION_DIVIDE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_DIVIDE_CONTENT, _SECTION_DIVIDE_CONTENT, value);
				this._SECTION_DIVIDE_CONTENT = value;
			}
		}
		/// <summary>
		/// 建设单位的管理机构
		/// </summary>
		public string CONST_MANAGEMENT
		{
			get{ return _CONST_MANAGEMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONST_MANAGEMENT, _CONST_MANAGEMENT, value);
				this._CONST_MANAGEMENT = value;
			}
		}
		/// <summary>
		/// 招标人答疑截止时间
		/// </summary>
		public DateTime? ANSWER_QUESTION_TIME
		{
			get{ return _ANSWER_QUESTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ANSWER_QUESTION_TIME, _ANSWER_QUESTION_TIME, value);
				this._ANSWER_QUESTION_TIME = value;
			}
		}
		/// <summary>
		/// 投标文件纸质版份数
		/// </summary>
		public decimal? DOC_NUMBER
		{
			get{ return _DOC_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.DOC_NUMBER, _DOC_NUMBER, value);
				this._DOC_NUMBER = value;
			}
		}
		/// <summary>
		/// 投标文件副本份数
		/// </summary>
		public decimal? COPY_NUM
		{
			get{ return _COPY_NUM; }
			set
			{
				this.OnPropertyValueChange(_.COPY_NUM, _COPY_NUM, value);
				this._COPY_NUM = value;
			}
		}
		/// <summary>
		/// 投标资料保密时间
		/// </summary>
		public decimal? BID_CONFIDENTIAL_TIME
		{
			get{ return _BID_CONFIDENTIAL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_CONFIDENTIAL_TIME, _BID_CONFIDENTIAL_TIME, value);
				this._BID_CONFIDENTIAL_TIME = value;
			}
		}
		/// <summary>
		/// 投标人收到中标通知书告知时间
		/// </summary>
		public decimal? NOTIFICATION_TIME
		{
			get{ return _NOTIFICATION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTIFICATION_TIME, _NOTIFICATION_TIME, value);
				this._NOTIFICATION_TIME = value;
			}
		}
		/// <summary>
		/// 主要工程数量表
		/// </summary>
		public string MAIN_ENGINEER_QUANTITY_LIST
		{
			get{ return _MAIN_ENGINEER_QUANTITY_LIST; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_ENGINEER_QUANTITY_LIST, _MAIN_ENGINEER_QUANTITY_LIST, value);
				this._MAIN_ENGINEER_QUANTITY_LIST = value;
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
		public decimal? BIDDER_NOTICE_TIME
		{
			get{ return _BIDDER_NOTICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NOTICE_TIME, _BIDDER_NOTICE_TIME, value);
				this._BIDDER_NOTICE_TIME = value;
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
		/// 项目说明
		/// </summary>
		public string PROJECT_DESCRIPTION
		{
			get{ return _PROJECT_DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_DESCRIPTION, _PROJECT_DESCRIPTION, value);
				this._PROJECT_DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 地理位置示意图
		/// </summary>
		public string SKETCH_MAP
		{
			get{ return _SKETCH_MAP; }
			set
			{
				this.OnPropertyValueChange(_.SKETCH_MAP, _SKETCH_MAP, value);
				this._SKETCH_MAP = value;
			}
		}
		/// <summary>
		/// 施工工期及监理服务时间
		/// </summary>
		public string PERIOD_SERVICE_TIME
		{
			get{ return _PERIOD_SERVICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PERIOD_SERVICE_TIME, _PERIOD_SERVICE_TIME, value);
				this._PERIOD_SERVICE_TIME = value;
			}
		}
		/// <summary>
		/// 资质要求
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
		/// 其他人员要求
		/// </summary>
		public string OTHER_PERSON_REQUIRE
		{
			get{ return _OTHER_PERSON_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_PERSON_REQUIRE, _OTHER_PERSON_REQUIRE, value);
				this._OTHER_PERSON_REQUIRE = value;
			}
		}
		/// <summary>
		/// 试验、检测设备
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
		/// 信誉和履约要求
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
		/// 评A级或AA级企业的年度
		/// </summary>
		public decimal? REVIEW_AAAW_YEAR
		{
			get{ return _REVIEW_AAAW_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_AAAW_YEAR, _REVIEW_AAAW_YEAR, value);
				this._REVIEW_AAAW_YEAR = value;
			}
		}
		/// <summary>
		/// AA级单位中标数量
		/// </summary>
		public decimal? AA_BID_NUMBER
		{
			get{ return _AA_BID_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.AA_BID_NUMBER, _AA_BID_NUMBER, value);
				this._AA_BID_NUMBER = value;
			}
		}
		/// <summary>
		/// A级单位中标数量
		/// </summary>
		public decimal? A_BID_NUMBER
		{
			get{ return _A_BID_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.A_BID_NUMBER, _A_BID_NUMBER, value);
				this._A_BID_NUMBER = value;
			}
		}
		/// <summary>
		/// 监理规范
		/// </summary>
		public string SUPERVISION_STANDARD
		{
			get{ return _SUPERVISION_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_STANDARD, _SUPERVISION_STANDARD, value);
				this._SUPERVISION_STANDARD = value;
			}
		}
		/// <summary>
		/// 履约担保提交时间
		/// </summary>
		public DateTime? BOND_SUBMIT_TIME
		{
			get{ return _BOND_SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BOND_SUBMIT_TIME, _BOND_SUBMIT_TIME, value);
				this._BOND_SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 履约担保签订合同时间
		/// </summary>
		public DateTime? PERFORM_PRICE_TIME
		{
			get{ return _PERFORM_PRICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_PRICE_TIME, _PERFORM_PRICE_TIME, value);
				this._PERFORM_PRICE_TIME = value;
			}
		}
		/// <summary>
		/// 履约保证金返还是否计息
		/// </summary>
		public string MARGIN_RETURN_TYPE
		{
			get{ return _MARGIN_RETURN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_RETURN_TYPE, _MARGIN_RETURN_TYPE, value);
				this._MARGIN_RETURN_TYPE = value;
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
		/// 监理业绩年份数要求
		/// </summary>
		public decimal? ACHIE_YEAR
		{
			get{ return _ACHIE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.ACHIE_YEAR, _ACHIE_YEAR, value);
				this._ACHIE_YEAR = value;
			}
		}
		/// <summary>
		/// 近年监理业绩要求年份
		/// </summary>
		public DateTime? ACHIE_YEAR_BEGIN
		{
			get{ return _ACHIE_YEAR_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.ACHIE_YEAR_BEGIN, _ACHIE_YEAR_BEGIN, value);
				this._ACHIE_YEAR_BEGIN = value;
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
		/// 定义与解释
		/// </summary>
		public string DEFINITION_EXPLANATION
		{
			get{ return _DEFINITION_EXPLANATION; }
			set
			{
				this.OnPropertyValueChange(_.DEFINITION_EXPLANATION, _DEFINITION_EXPLANATION, value);
				this._DEFINITION_EXPLANATION = value;
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
		/// 发包人的义务
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
		/// 责任和保障
		/// </summary>
		public string RESPONSIBILITY
		{
			get{ return _RESPONSIBILITY; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSIBILITY, _RESPONSIBILITY, value);
				this._RESPONSIBILITY = value;
			}
		}
		/// <summary>
		/// 监理合同的生效、终止、变更、暂停与解除
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
		/// 监理服务的费用与支付
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
		/// 争端的解决
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
		/// 监理规范
		/// </summary>
		public string UPERVISION_STANDARD
		{
			get{ return _UPERVISION_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.UPERVISION_STANDARD, _UPERVISION_STANDARD, value);
				this._UPERVISION_STANDARD = value;
			}
		}
		/// <summary>
		/// 工程专用规范
		/// </summary>
		public string ENGINEERING_SPECIFICATIONS
		{
			get{ return _ENGINEERING_SPECIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEERING_SPECIFICATIONS, _ENGINEERING_SPECIFICATIONS, value);
				this._ENGINEERING_SPECIFICATIONS = value;
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
				_.TENDER_PROJECT_PART,
				_.TOTAL_SECTION_NUMBER,
				_.CONTRACT_SECTION,
				_.TENDERER_CONTRACT_SECTION,
				_.SUPERVISION_PRICE_ADJUST,
				_.OFFICE_NUMBER1,
				_.OFFICE_NUMBER2,
				_.SUPERVISION_ORGA,
				_.MANAGE_MEASURES_CONTENT,
				_.ACHIEVEMENT_TIME,
				_.ACHIEVEMENT_CONDITIONS,
				_.ACHI_PERSON_CONDITIONS,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.TENDER_DOC_PRICE,
				_.SYNDICATED_NUMBER,
				_.LIMITE_TIME_UNIT,
				_.SET_LABORATORY,
				_.IF_ACHIEVEMENT,
				_.IF_ACHI_PERSON,
				_.OPEN_BID_REQURE_CHOOSE,
				_.BID_OPEN_TYPE,
				_.UPPER_LOWER_LIMIT,
				_.ENGINEER_TITLE,
				_.ENGINEER_WORK_YEAR,
				_.ENGINEER_AGE,
				_.TEST_DIRECTOR_MAGOR,
				_.TEST_DIRECTOR_WORK_YEAR,
				_.TEST_DIRECTOR_AGE,
				_.TEST_DIRECTOR_EXPER,
				_.OTHER_PERSON_YEAR_BEGIN,
				_.OTHER_PERSON_YEAR,
				_.FINANCE_YEAR1,
				_.FINANCE_YEAR2,
				_.FINANCE_YEAR3,
				_.AVE_TURNOVER,
				_.REPUTATION_TIME1,
				_.REPUTATION_TIME2,
				_.REPUTATION_TIME4,
				_.REPUTATION_LEVEL,
				_.SUBC_NAME,
				_.PROJECT_APPROVAL,
				_.FUND_PLACE,
				_.DRAWING,
				_.ENCLOSURE1,
				_.ENCLOSURE2,
				_.ENCLOSURE3,
				_.QUALIFICATION_REQUIRE,
				_.REMARK,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.MARGIN_TIME,
				_.MEDIA1,
				_.MEDIA2,
				_.SECTION_DIVIDE_CONTENT,
				_.CONST_MANAGEMENT,
				_.ANSWER_QUESTION_TIME,
				_.DOC_NUMBER,
				_.COPY_NUM,
				_.BID_CONFIDENTIAL_TIME,
				_.NOTIFICATION_TIME,
				_.MAIN_ENGINEER_QUANTITY_LIST,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_PHONE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.SUPERVISE_DEPT_FAX,
				_.QUESTION_TIME,
				_.TENDER_NOTICE_TIME,
				_.BIDDER_NOTICE_TIME,
				_.OTHER_REQUIREMENTS,
				_.PROJECT_DESCRIPTION,
				_.SKETCH_MAP,
				_.PERIOD_SERVICE_TIME,
				_.MINIMUM_QUALIFICATIONS,
				_.ACHIEVEMENT_REQUIRE,
				_.OTHER_PERSON_REQUIRE,
				_.EQUIPMENT_REQUIRE,
				_.FINANCIAL_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.REVIEW_AAAW_YEAR,
				_.AA_BID_NUMBER,
				_.A_BID_NUMBER,
				_.SUPERVISION_STANDARD,
				_.BOND_SUBMIT_TIME,
				_.PERFORM_PRICE_TIME,
				_.MARGIN_RETURN_TYPE,
				_.PERFORM_PRICE,
				_.ACHIE_YEAR,
				_.ACHIE_YEAR_BEGIN,
				_.CHANGE,
				_.DEFINITION_EXPLANATION,
				_.SUPERVISOR_OBLIGATIONS,
				_.EMPLOYER_DUTY,
				_.RESPONSIBILITY,
				_.CONTRACT_OPERATION,
				_.MEASUREMENT_PAYMENT,
				_.DISPUTE_RESOLUTION,
				_.OTHER_CONVENTIONS,
				_.SUPPLY_ITEM,
				_.UPERVISION_STANDARD,
				_.ENGINEERING_SPECIFICATIONS,
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
				this._TENDER_PROJECT_PART,
				this._TOTAL_SECTION_NUMBER,
				this._CONTRACT_SECTION,
				this._TENDERER_CONTRACT_SECTION,
				this._SUPERVISION_PRICE_ADJUST,
				this._OFFICE_NUMBER1,
				this._OFFICE_NUMBER2,
				this._SUPERVISION_ORGA,
				this._MANAGE_MEASURES_CONTENT,
				this._ACHIEVEMENT_TIME,
				this._ACHIEVEMENT_CONDITIONS,
				this._ACHI_PERSON_CONDITIONS,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._TENDER_DOC_PRICE,
				this._SYNDICATED_NUMBER,
				this._LIMITE_TIME_UNIT,
				this._SET_LABORATORY,
				this._IF_ACHIEVEMENT,
				this._IF_ACHI_PERSON,
				this._OPEN_BID_REQURE_CHOOSE,
				this._BID_OPEN_TYPE,
				this._UPPER_LOWER_LIMIT,
				this._ENGINEER_TITLE,
				this._ENGINEER_WORK_YEAR,
				this._ENGINEER_AGE,
				this._TEST_DIRECTOR_MAGOR,
				this._TEST_DIRECTOR_WORK_YEAR,
				this._TEST_DIRECTOR_AGE,
				this._TEST_DIRECTOR_EXPER,
				this._OTHER_PERSON_YEAR_BEGIN,
				this._OTHER_PERSON_YEAR,
				this._FINANCE_YEAR1,
				this._FINANCE_YEAR2,
				this._FINANCE_YEAR3,
				this._AVE_TURNOVER,
				this._REPUTATION_TIME1,
				this._REPUTATION_TIME2,
				this._REPUTATION_TIME4,
				this._REPUTATION_LEVEL,
				this._SUBC_NAME,
				this._PROJECT_APPROVAL,
				this._FUND_PLACE,
				this._DRAWING,
				this._ENCLOSURE1,
				this._ENCLOSURE2,
				this._ENCLOSURE3,
				this._QUALIFICATION_REQUIRE,
				this._REMARK,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._MARGIN_TIME,
				this._MEDIA1,
				this._MEDIA2,
				this._SECTION_DIVIDE_CONTENT,
				this._CONST_MANAGEMENT,
				this._ANSWER_QUESTION_TIME,
				this._DOC_NUMBER,
				this._COPY_NUM,
				this._BID_CONFIDENTIAL_TIME,
				this._NOTIFICATION_TIME,
				this._MAIN_ENGINEER_QUANTITY_LIST,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_PHONE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._SUPERVISE_DEPT_FAX,
				this._QUESTION_TIME,
				this._TENDER_NOTICE_TIME,
				this._BIDDER_NOTICE_TIME,
				this._OTHER_REQUIREMENTS,
				this._PROJECT_DESCRIPTION,
				this._SKETCH_MAP,
				this._PERIOD_SERVICE_TIME,
				this._MINIMUM_QUALIFICATIONS,
				this._ACHIEVEMENT_REQUIRE,
				this._OTHER_PERSON_REQUIRE,
				this._EQUIPMENT_REQUIRE,
				this._FINANCIAL_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._REVIEW_AAAW_YEAR,
				this._AA_BID_NUMBER,
				this._A_BID_NUMBER,
				this._SUPERVISION_STANDARD,
				this._BOND_SUBMIT_TIME,
				this._PERFORM_PRICE_TIME,
				this._MARGIN_RETURN_TYPE,
				this._PERFORM_PRICE,
				this._ACHIE_YEAR,
				this._ACHIE_YEAR_BEGIN,
				this._CHANGE,
				this._DEFINITION_EXPLANATION,
				this._SUPERVISOR_OBLIGATIONS,
				this._EMPLOYER_DUTY,
				this._RESPONSIBILITY,
				this._CONTRACT_OPERATION,
				this._MEASUREMENT_PAYMENT,
				this._DISPUTE_RESOLUTION,
				this._OTHER_CONVENTIONS,
				this._SUPPLY_ITEM,
				this._UPERVISION_STANDARD,
				this._ENGINEERING_SPECIFICATIONS,
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
			public readonly static Field All = new Field("*", "JT_GEN_SUPER_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_GEN_SUPER_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_GEN_SUPER_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 公告招标项目
			/// </summary>
			public readonly static Field TENDER_PROJECT_PART = new Field("TENDER_PROJECT_PART", "JT_GEN_SUPER_TENDER_FILE", "公告招标项目");
            /// <summary>
			/// 施工监理合同段数量
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "施工监理合同段数量");
            /// <summary>
			/// 标段名称
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "标段名称");
            /// <summary>
			/// 本次招标的合同段
			/// </summary>
			public readonly static Field TENDERER_CONTRACT_SECTION = new Field("TENDERER_CONTRACT_SECTION", "JT_GEN_SUPER_TENDER_FILE", "本次招标的合同段");
            /// <summary>
			/// 建设工期延长监理费是否调整
			/// </summary>
			public readonly static Field SUPERVISION_PRICE_ADJUST = new Field("SUPERVISION_PRICE_ADJUST", "JT_GEN_SUPER_TENDER_FILE", "建设工期延长监理费是否调整");
            /// <summary>
			/// 总监理工程师办公室数量
			/// </summary>
			public readonly static Field OFFICE_NUMBER1 = new Field("OFFICE_NUMBER1", "JT_GEN_SUPER_TENDER_FILE", "总监理工程师办公室数量");
            /// <summary>
			/// 驻地监理工程师办公室数量
			/// </summary>
			public readonly static Field OFFICE_NUMBER2 = new Field("OFFICE_NUMBER2", "JT_GEN_SUPER_TENDER_FILE", "驻地监理工程师办公室数量");
            /// <summary>
			/// 本项目设置的监理机构级别
			/// </summary>
			public readonly static Field SUPERVISION_ORGA = new Field("SUPERVISION_ORGA", "JT_GEN_SUPER_TENDER_FILE", "本项目设置的监理机构级别");
            /// <summary>
			/// 主要建设内容
			/// </summary>
			public readonly static Field MANAGE_MEASURES_CONTENT = new Field("MANAGE_MEASURES_CONTENT", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "主要建设内容");
            /// <summary>
			/// 企业业绩年份要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_TIME = new Field("ACHIEVEMENT_TIME", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "企业业绩年份要求");
            /// <summary>
			/// 企业业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_CONDITIONS = new Field("ACHIEVEMENT_CONDITIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "企业业绩要求");
            /// <summary>
			/// 主要人员业绩要求
			/// </summary>
			public readonly static Field ACHI_PERSON_CONDITIONS = new Field("ACHI_PERSON_CONDITIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "主要人员业绩要求");
            /// <summary>
			/// 投标人可参投监理合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_GEN_SUPER_TENDER_FILE", "投标人可参投监理合同段数量");
            /// <summary>
			/// 投标人最多可中标数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "投标人最多可中标数量");
            /// <summary>
			/// 线上递交投标文件费用
			/// </summary>
			public readonly static Field TENDER_DOC_PRICE = new Field("TENDER_DOC_PRICE", "JT_GEN_SUPER_TENDER_FILE", "线上递交投标文件费用");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field SYNDICATED_NUMBER = new Field("SYNDICATED_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 工期单位
			/// </summary>
			public readonly static Field LIMITE_TIME_UNIT = new Field("LIMITE_TIME_UNIT", "JT_GEN_SUPER_TENDER_FILE", "工期单位");
            /// <summary>
			/// 是否按照惯例办法设置中心实验室
			/// </summary>
			public readonly static Field SET_LABORATORY = new Field("SET_LABORATORY", "JT_GEN_SUPER_TENDER_FILE", "是否按照惯例办法设置中心实验室");
            /// <summary>
			/// 是否要求企业业绩
			/// </summary>
			public readonly static Field IF_ACHIEVEMENT = new Field("IF_ACHIEVEMENT", "JT_GEN_SUPER_TENDER_FILE", "是否要求企业业绩");
            /// <summary>
			/// 是否要求个人业绩
			/// </summary>
			public readonly static Field IF_ACHI_PERSON = new Field("IF_ACHI_PERSON", "JT_GEN_SUPER_TENDER_FILE", "是否要求个人业绩");
            /// <summary>
			/// 是否需要人员到场
			/// </summary>
			public readonly static Field OPEN_BID_REQURE_CHOOSE = new Field("OPEN_BID_REQURE_CHOOSE", "JT_GEN_SUPER_TENDER_FILE", "是否需要人员到场");
            /// <summary>
			/// 开标方式
			/// </summary>
			public readonly static Field BID_OPEN_TYPE = new Field("BID_OPEN_TYPE", "JT_GEN_SUPER_TENDER_FILE", "开标方式");
            /// <summary>
			/// 是否设定投标控制价上、下限
			/// </summary>
			public readonly static Field UPPER_LOWER_LIMIT = new Field("UPPER_LOWER_LIMIT", "JT_GEN_SUPER_TENDER_FILE", "是否设定投标控制价上、下限");
            /// <summary>
			/// 总监理工程师职称
			/// </summary>
			public readonly static Field ENGINEER_TITLE = new Field("ENGINEER_TITLE", "JT_GEN_SUPER_TENDER_FILE", "总监理工程师职称");
            /// <summary>
			/// 总监理工程师工作年限
			/// </summary>
			public readonly static Field ENGINEER_WORK_YEAR = new Field("ENGINEER_WORK_YEAR", "JT_GEN_SUPER_TENDER_FILE", "总监理工程师工作年限");
            /// <summary>
			/// 总监理工程师年龄
			/// </summary>
			public readonly static Field ENGINEER_AGE = new Field("ENGINEER_AGE", "JT_GEN_SUPER_TENDER_FILE", "总监理工程师年龄");
            /// <summary>
			/// 试验室主任专业
			/// </summary>
			public readonly static Field TEST_DIRECTOR_MAGOR = new Field("TEST_DIRECTOR_MAGOR", "JT_GEN_SUPER_TENDER_FILE", "试验室主任专业");
            /// <summary>
			/// 试验室主任工作年限
			/// </summary>
			public readonly static Field TEST_DIRECTOR_WORK_YEAR = new Field("TEST_DIRECTOR_WORK_YEAR", "JT_GEN_SUPER_TENDER_FILE", "试验室主任工作年限");
            /// <summary>
			/// 试验室主任年龄
			/// </summary>
			public readonly static Field TEST_DIRECTOR_AGE = new Field("TEST_DIRECTOR_AGE", "JT_GEN_SUPER_TENDER_FILE", "试验室主任年龄");
            /// <summary>
			/// 试验室主任工作经历
			/// </summary>
			public readonly static Field TEST_DIRECTOR_EXPER = new Field("TEST_DIRECTOR_EXPER", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "试验室主任工作经历");
            /// <summary>
			/// 近年其他人员时间要求
			/// </summary>
			public readonly static Field OTHER_PERSON_YEAR_BEGIN = new Field("OTHER_PERSON_YEAR_BEGIN", "JT_GEN_SUPER_TENDER_FILE", "近年其他人员时间要求");
            /// <summary>
			/// 其他人员年份数要求
			/// </summary>
			public readonly static Field OTHER_PERSON_YEAR = new Field("OTHER_PERSON_YEAR", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "其他人员年份数要求");
            /// <summary>
			/// 财务年份1
			/// </summary>
			public readonly static Field FINANCE_YEAR1 = new Field("FINANCE_YEAR1", "JT_GEN_SUPER_TENDER_FILE", "财务年份1");
            /// <summary>
			/// 财务年份2
			/// </summary>
			public readonly static Field FINANCE_YEAR2 = new Field("FINANCE_YEAR2", "JT_GEN_SUPER_TENDER_FILE", "财务年份2");
            /// <summary>
			/// 财务年份3
			/// </summary>
			public readonly static Field FINANCE_YEAR3 = new Field("FINANCE_YEAR3", "JT_GEN_SUPER_TENDER_FILE", "财务年份3");
            /// <summary>
			/// 同年平均营业额不少于
			/// </summary>
			public readonly static Field AVE_TURNOVER = new Field("AVE_TURNOVER", "JT_GEN_SUPER_TENDER_FILE", "同年平均营业额不少于");
            /// <summary>
			/// 未发生安全事故的时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME1 = new Field("REPUTATION_TIME1", "JT_GEN_SUPER_TENDER_FILE", "未发生安全事故的时间要求");
            /// <summary>
			/// 未出现不良记录时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME2 = new Field("REPUTATION_TIME2", "JT_GEN_SUPER_TENDER_FILE", "未出现不良记录时间要求");
            /// <summary>
			/// 未被认定时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME4 = new Field("REPUTATION_TIME4", "JT_GEN_SUPER_TENDER_FILE", "未被认定时间要求");
            /// <summary>
			/// 未被认定等级
			/// </summary>
			public readonly static Field REPUTATION_LEVEL = new Field("REPUTATION_LEVEL", "JT_GEN_SUPER_TENDER_FILE", "未被认定等级");
            /// <summary>
			/// 发包人名称
			/// </summary>
			public readonly static Field SUBC_NAME = new Field("SUBC_NAME", "JT_GEN_SUPER_TENDER_FILE", "发包人名称");
            /// <summary>
			/// 立项审批情况
			/// </summary>
			public readonly static Field PROJECT_APPROVAL = new Field("PROJECT_APPROVAL", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "立项审批情况");
            /// <summary>
			/// 资金组成及到位情况
			/// </summary>
			public readonly static Field FUND_PLACE = new Field("FUND_PLACE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "资金组成及到位情况");
            /// <summary>
			/// 图纸和资料
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_GEN_SUPER_TENDER_FILE", "图纸和资料");
            /// <summary>
			/// 标后监管指南
			/// </summary>
			public readonly static Field ENCLOSURE1 = new Field("ENCLOSURE1", "JT_GEN_SUPER_TENDER_FILE", "标后监管指南");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field ENCLOSURE2 = new Field("ENCLOSURE2", "JT_GEN_SUPER_TENDER_FILE", "招标代理合同");
            /// <summary>
			/// 招标人授权招标代理签章协议书
			/// </summary>
			public readonly static Field ENCLOSURE3 = new Field("ENCLOSURE3", "JT_GEN_SUPER_TENDER_FILE", "招标人授权招标代理签章协议书");
            /// <summary>
			/// 主要人员最低要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "主要人员最低要求");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_GEN_SUPER_TENDER_FILE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_GEN_SUPER_TENDER_FILE", "开户银行");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_GEN_SUPER_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_GEN_SUPER_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_GEN_SUPER_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 标段划分
			/// </summary>
			public readonly static Field SECTION_DIVIDE_CONTENT = new Field("SECTION_DIVIDE_CONTENT", "JT_GEN_SUPER_TENDER_FILE", "标段划分");
            /// <summary>
			/// 建设单位的管理机构
			/// </summary>
			public readonly static Field CONST_MANAGEMENT = new Field("CONST_MANAGEMENT", "JT_GEN_SUPER_TENDER_FILE", "建设单位的管理机构");
            /// <summary>
			/// 招标人答疑截止时间
			/// </summary>
			public readonly static Field ANSWER_QUESTION_TIME = new Field("ANSWER_QUESTION_TIME", "JT_GEN_SUPER_TENDER_FILE", "招标人答疑截止时间");
            /// <summary>
			/// 投标文件纸质版份数
			/// </summary>
			public readonly static Field DOC_NUMBER = new Field("DOC_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "投标文件纸质版份数");
            /// <summary>
			/// 投标文件副本份数
			/// </summary>
			public readonly static Field COPY_NUM = new Field("COPY_NUM", "JT_GEN_SUPER_TENDER_FILE", "投标文件副本份数");
            /// <summary>
			/// 投标资料保密时间
			/// </summary>
			public readonly static Field BID_CONFIDENTIAL_TIME = new Field("BID_CONFIDENTIAL_TIME", "JT_GEN_SUPER_TENDER_FILE", "投标资料保密时间");
            /// <summary>
			/// 投标人收到中标通知书告知时间
			/// </summary>
			public readonly static Field NOTIFICATION_TIME = new Field("NOTIFICATION_TIME", "JT_GEN_SUPER_TENDER_FILE", "投标人收到中标通知书告知时间");
            /// <summary>
			/// 主要工程数量表
			/// </summary>
			public readonly static Field MAIN_ENGINEER_QUANTITY_LIST = new Field("MAIN_ENGINEER_QUANTITY_LIST", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "主要工程数量表");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_GEN_SUPER_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE = new Field("SUPERVISE_DEPT_PHONE", "JT_GEN_SUPER_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_GEN_SUPER_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_GEN_SUPER_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 监督部门传真
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX = new Field("SUPERVISE_DEPT_FAX", "JT_GEN_SUPER_TENDER_FILE", "监督部门传真");
            /// <summary>
			/// 投标人提出问题的截止时间
			/// </summary>
			public readonly static Field QUESTION_TIME = new Field("QUESTION_TIME", "JT_GEN_SUPER_TENDER_FILE", "投标人提出问题的截止时间");
            /// <summary>
			/// 招标人书面澄清的时间
			/// </summary>
			public readonly static Field TENDER_NOTICE_TIME = new Field("TENDER_NOTICE_TIME", "JT_GEN_SUPER_TENDER_FILE", "招标人书面澄清的时间");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field BIDDER_NOTICE_TIME = new Field("BIDDER_NOTICE_TIME", "JT_GEN_SUPER_TENDER_FILE", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIREMENTS = new Field("OTHER_REQUIREMENTS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 项目说明
			/// </summary>
			public readonly static Field PROJECT_DESCRIPTION = new Field("PROJECT_DESCRIPTION", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "项目说明");
            /// <summary>
			/// 地理位置示意图
			/// </summary>
			public readonly static Field SKETCH_MAP = new Field("SKETCH_MAP", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "地理位置示意图");
            /// <summary>
			/// 施工工期及监理服务时间
			/// </summary>
			public readonly static Field PERIOD_SERVICE_TIME = new Field("PERIOD_SERVICE_TIME", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "施工工期及监理服务时间");
            /// <summary>
			/// 资质要求
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "资质要求");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "业绩要求");
            /// <summary>
			/// 其他人员要求
			/// </summary>
			public readonly static Field OTHER_PERSON_REQUIRE = new Field("OTHER_PERSON_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "其他人员要求");
            /// <summary>
			/// 试验、检测设备
			/// </summary>
			public readonly static Field EQUIPMENT_REQUIRE = new Field("EQUIPMENT_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "试验、检测设备");
            /// <summary>
			/// 财务要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "财务要求");
            /// <summary>
			/// 信誉和履约要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "信誉和履约要求");
            /// <summary>
			/// 评A级或AA级企业的年度
			/// </summary>
			public readonly static Field REVIEW_AAAW_YEAR = new Field("REVIEW_AAAW_YEAR", "JT_GEN_SUPER_TENDER_FILE", "评A级或AA级企业的年度");
            /// <summary>
			/// AA级单位中标数量
			/// </summary>
			public readonly static Field AA_BID_NUMBER = new Field("AA_BID_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "AA级单位中标数量");
            /// <summary>
			/// A级单位中标数量
			/// </summary>
			public readonly static Field A_BID_NUMBER = new Field("A_BID_NUMBER", "JT_GEN_SUPER_TENDER_FILE", "A级单位中标数量");
            /// <summary>
			/// 监理规范
			/// </summary>
			public readonly static Field SUPERVISION_STANDARD = new Field("SUPERVISION_STANDARD", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "监理规范");
            /// <summary>
			/// 履约担保提交时间
			/// </summary>
			public readonly static Field BOND_SUBMIT_TIME = new Field("BOND_SUBMIT_TIME", "JT_GEN_SUPER_TENDER_FILE", "履约担保提交时间");
            /// <summary>
			/// 履约担保签订合同时间
			/// </summary>
			public readonly static Field PERFORM_PRICE_TIME = new Field("PERFORM_PRICE_TIME", "JT_GEN_SUPER_TENDER_FILE", "履约担保签订合同时间");
            /// <summary>
			/// 履约保证金返还是否计息
			/// </summary>
			public readonly static Field MARGIN_RETURN_TYPE = new Field("MARGIN_RETURN_TYPE", "JT_GEN_SUPER_TENDER_FILE", "履约保证金返还是否计息");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "JT_GEN_SUPER_TENDER_FILE", "履约担保金额");
            /// <summary>
			/// 监理业绩年份数要求
			/// </summary>
			public readonly static Field ACHIE_YEAR = new Field("ACHIE_YEAR", "JT_GEN_SUPER_TENDER_FILE", "监理业绩年份数要求");
            /// <summary>
			/// 近年监理业绩要求年份
			/// </summary>
			public readonly static Field ACHIE_YEAR_BEGIN = new Field("ACHIE_YEAR_BEGIN", "JT_GEN_SUPER_TENDER_FILE", "近年监理业绩要求年份");
            /// <summary>
			/// 是否更改专用合同条款
			/// </summary>
			public readonly static Field CHANGE = new Field("CHANGE", "JT_GEN_SUPER_TENDER_FILE", "是否更改专用合同条款");
            /// <summary>
			/// 定义与解释
			/// </summary>
			public readonly static Field DEFINITION_EXPLANATION = new Field("DEFINITION_EXPLANATION", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "定义与解释");
            /// <summary>
			/// 监理人的义务
			/// </summary>
			public readonly static Field SUPERVISOR_OBLIGATIONS = new Field("SUPERVISOR_OBLIGATIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "监理人的义务");
            /// <summary>
			/// 发包人的义务
			/// </summary>
			public readonly static Field EMPLOYER_DUTY = new Field("EMPLOYER_DUTY", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "发包人的义务");
            /// <summary>
			/// 责任和保障
			/// </summary>
			public readonly static Field RESPONSIBILITY = new Field("RESPONSIBILITY", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "责任和保障");
            /// <summary>
			/// 监理合同的生效、终止、变更、暂停与解除
			/// </summary>
			public readonly static Field CONTRACT_OPERATION = new Field("CONTRACT_OPERATION", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "监理合同的生效、终止、变更、暂停与解除");
            /// <summary>
			/// 监理服务的费用与支付
			/// </summary>
			public readonly static Field MEASUREMENT_PAYMENT = new Field("MEASUREMENT_PAYMENT", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "监理服务的费用与支付");
            /// <summary>
			/// 争端的解决
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "争端的解决");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER_CONVENTIONS = new Field("OTHER_CONVENTIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 其他补充条款
			/// </summary>
			public readonly static Field SUPPLY_ITEM = new Field("SUPPLY_ITEM", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "其他补充条款");
            /// <summary>
			/// 监理规范
			/// </summary>
			public readonly static Field UPERVISION_STANDARD = new Field("UPERVISION_STANDARD", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "监理规范");
            /// <summary>
			/// 工程专用规范
			/// </summary>
			public readonly static Field ENGINEERING_SPECIFICATIONS = new Field("ENGINEERING_SPECIFICATIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "工程专用规范");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_GEN_SUPER_TENDER_FILE",DbType.AnsiString, null, "技术规范");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_GEN_SUPER_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_GEN_SUPER_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_GEN_SUPER_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_GEN_SUPER_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_GEN_SUPER_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_GEN_SUPER_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_GEN_SUPER_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_GEN_SUPER_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_GEN_SUPER_TENDER_FILE", "M_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_GEN_SUPER_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_GEN_SUPER_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_GEN_SUPER_TENDER_FILE", "");
        }
        #endregion
	}
}