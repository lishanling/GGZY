using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_GEN_SURVEY_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_GEN_SURVEY_TENDER_FILE")]
    [Serializable]
    public partial class JT_GEN_SURVEY_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private string _TECHNICAL_STANDARD;
		private string _BID_SECTION_DIVISION;
		private string _SURVEY_DESIGN_CYCLE;
		private decimal? _SYNDICATED_NUMBER;
		private decimal? _CONTRACT_SEGMENT;
		private decimal? _TENDER_NUMBER;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private DateTime? _MARGIN_TIME;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _FUND_IMPLEMENTATION;
		private string _TENDER_OTHER_CONTENT;
		private string _SAME_INFORMATION;
		private string _TENDER_CONTEN_COMPONENT;
		private DateTime? _REPUTATION_TIME2;
		private DateTime? _REPUTATION_TIME3;
		private string _TENDER_CONTENT_ENCLOSURE;
		private string _SURVEY_DESIGN_ENCLOSURE;
		private string _TENDER_OFFER_REQUIRE;
		private decimal? _EFFECTIVE_BID_FLOAT;
		private decimal? _E1_NUMBER;
		private decimal? _E2_NUMBER;
		private string _SUBC_NUMBER;
		private string _SURVEY_REPORT;
		private string _DESIGN_DOC;
		private decimal? _CONSTRUCTION_PERIOD;
		private decimal? _PRE_DESIGN_DAY;
		private decimal? _CON_DRAW_DESIGN_DAY;
		private decimal? _SUBMIT_FIRST_TEST_TIME;
		private decimal? _SUBMIT_FIRST_TEST_NUMBER;
		private decimal? _PRESENT_DESIGN_TIME;
		private decimal? _PRESENT_DESIGN_NUMBER;
		private decimal? _COMPLETE_DESIGN_TIME;
		private decimal? _SUBMIT_SURVAY_PRESENT_TIME;
		private decimal? _SUBMIT_SURVAY_PRESENT_NUMBER;
		private decimal? _SUBMIT_DRAW_DESIGN_TIME;
		private decimal? _SUBMIT_DRAW_DESIGN_NUMBER;
		private decimal? _COM_DRAW_DESIGN_TIME;
		private decimal? _SUBMIT_STUDY_PRESENT_TIME;
		private decimal? _SUBMIT_STUDY_PRESENT_NUMBER;
		private decimal? _SUBMIT_FINAL_TIME;
		private decimal? _SUBMIT_FINAL_NUMBER;
		private decimal? _FINAL_SECTION_NUMBER;
		private decimal? _FILE_DOCUMENT_NUMBER;
		private decimal? _FINAL_DOCUMENT_NUMBER;
		private decimal? _TENDER_SECTION_NUMBER;
		private decimal? _TENER_DOCUMENT_NUMBER;
		private decimal? _SUBMIT_LAND_DECLARE_TIME;
		private decimal? _RETENT_MONEY;
		private string _DISPUTE_SOLUTION;
		private string _ENCLOSURE1;
		private string _ENCLOSURE2;
		private string _ENCLOSURE3;
		private string _CREDIT_USE_REQUIRE1;
		private string _CREDIT_USE_REQUIRE2;
		private string _DECRYPTION_TYPE;
		private string _ACHIEVEMENT_CONDITIONS;
		private string _QUALIFICATION_REQUIRE;
		private string _MINIMUM_QUALIFICATIONS;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _OTHER_REQUIRE;
		private string _SUBCONTRACT;
		private DateTime? _SERIOUS_BREACH_TIME;
		private string _TENDER_DOC_FORM;
		private decimal? _FIXED_BID_PRICE;
		private string _OPEN_BID_REQURE_CHOOSE;
		private string _DECRYPTION_ADDRESS;
		private decimal? _PROVISIONAL_SUM;
		private string _BID_FIXED_UNIT_PRICE_REQURE;
		private decimal? _MARGIN_AMOUNT;
		private string _ANNUAL_DEPOSIT;
		private string _MARGIN_RETURN_TYPE;
		private string _MARGIN_RETURN_CONTENT;
		private decimal? _COPY_NUM;
		private string _BID_DOC_ENVELOPE;
		private string _BID_OPEN_TIMES;
		private string _DECRYPTION_FLOW;
		private string _BID_OPEN_CONTENT;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_EXTRACT;
		private decimal? _CANDIDATE_PERIOD;
		private decimal? _RESULTS_PERIOD;
		private string _TECH_DOC_REVIEW_TYPE;
		private decimal? _CANDIDATE_NUMBER;
		private decimal? _PERFORM_PRICE;
		private decimal? _PERFORM_PRICE_TIME;
		private decimal? _SIGN_CONTRACT_TIME;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_PHONE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private string _SUPERVISE_DEPT_FAX;
		private string _TECH_REQUIRE;
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
		/// 技术标准
		/// </summary>
		public string TECHNICAL_STANDARD
		{
			get{ return _TECHNICAL_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_STANDARD, _TECHNICAL_STANDARD, value);
				this._TECHNICAL_STANDARD = value;
			}
		}
		/// <summary>
		/// 标段划分
		/// </summary>
		public string BID_SECTION_DIVISION
		{
			get{ return _BID_SECTION_DIVISION; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_DIVISION, _BID_SECTION_DIVISION, value);
				this._BID_SECTION_DIVISION = value;
			}
		}
		/// <summary>
		/// 勘察设计周期
		/// </summary>
		public string SURVEY_DESIGN_CYCLE
		{
			get{ return _SURVEY_DESIGN_CYCLE; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_CYCLE, _SURVEY_DESIGN_CYCLE, value);
				this._SURVEY_DESIGN_CYCLE = value;
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
		/// 投标人最多可投标段数量
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
		/// 招标范围其它
		/// </summary>
		public string TENDER_OTHER_CONTENT
		{
			get{ return _TENDER_OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_OTHER_CONTENT, _TENDER_OTHER_CONTENT, value);
				this._TENDER_OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 投标人信息与信用管理系统是否要保持一致
		/// </summary>
		public string SAME_INFORMATION
		{
			get{ return _SAME_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.SAME_INFORMATION, _SAME_INFORMATION, value);
				this._SAME_INFORMATION = value;
			}
		}
		/// <summary>
		/// 招标范围的组成部分
		/// </summary>
		public string TENDER_CONTEN_COMPONENT
		{
			get{ return _TENDER_CONTEN_COMPONENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTEN_COMPONENT, _TENDER_CONTEN_COMPONENT, value);
				this._TENDER_CONTEN_COMPONENT = value;
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
		/// 未出现未履约的合同时间要求
		/// </summary>
		public DateTime? REPUTATION_TIME3
		{
			get{ return _REPUTATION_TIME3; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_TIME3, _REPUTATION_TIME3, value);
				this._REPUTATION_TIME3 = value;
			}
		}
		/// <summary>
		/// 工程概况及招标范围附件
		/// </summary>
		public string TENDER_CONTENT_ENCLOSURE
		{
			get{ return _TENDER_CONTENT_ENCLOSURE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTENT_ENCLOSURE, _TENDER_CONTENT_ENCLOSURE, value);
				this._TENDER_CONTENT_ENCLOSURE = value;
			}
		}
		/// <summary>
		/// 勘察设计原始资料附件
		/// </summary>
		public string SURVEY_DESIGN_ENCLOSURE
		{
			get{ return _SURVEY_DESIGN_ENCLOSURE; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_DESIGN_ENCLOSURE, _SURVEY_DESIGN_ENCLOSURE, value);
				this._SURVEY_DESIGN_ENCLOSURE = value;
			}
		}
		/// <summary>
		/// 算术性修正后的投标报价要求
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
		/// 有效最低报价的下浮系数
		/// </summary>
		public decimal? EFFECTIVE_BID_FLOAT
		{
			get{ return _EFFECTIVE_BID_FLOAT; }
			set
			{
				this.OnPropertyValueChange(_.EFFECTIVE_BID_FLOAT, _EFFECTIVE_BID_FLOAT, value);
				this._EFFECTIVE_BID_FLOAT = value;
			}
		}
		/// <summary>
		/// E1值
		/// </summary>
		public decimal? E1_NUMBER
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
		public decimal? E2_NUMBER
		{
			get{ return _E2_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.E2_NUMBER, _E2_NUMBER, value);
				this._E2_NUMBER = value;
			}
		}
		/// <summary>
		/// 发包人
		/// </summary>
		public string SUBC_NUMBER
		{
			get{ return _SUBC_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_NUMBER, _SUBC_NUMBER, value);
				this._SUBC_NUMBER = value;
			}
		}
		/// <summary>
		/// 勘察报告
		/// </summary>
		public string SURVEY_REPORT
		{
			get{ return _SURVEY_REPORT; }
			set
			{
				this.OnPropertyValueChange(_.SURVEY_REPORT, _SURVEY_REPORT, value);
				this._SURVEY_REPORT = value;
			}
		}
		/// <summary>
		/// 设计文件
		/// </summary>
		public string DESIGN_DOC
		{
			get{ return _DESIGN_DOC; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_DOC, _DESIGN_DOC, value);
				this._DESIGN_DOC = value;
			}
		}
		/// <summary>
		/// 施工期
		/// </summary>
		public decimal? CONSTRUCTION_PERIOD
		{
			get{ return _CONSTRUCTION_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_PERIOD, _CONSTRUCTION_PERIOD, value);
				this._CONSTRUCTION_PERIOD = value;
			}
		}
		/// <summary>
		/// 初步设计天数
		/// </summary>
		public decimal? PRE_DESIGN_DAY
		{
			get{ return _PRE_DESIGN_DAY; }
			set
			{
				this.OnPropertyValueChange(_.PRE_DESIGN_DAY, _PRE_DESIGN_DAY, value);
				this._PRE_DESIGN_DAY = value;
			}
		}
		/// <summary>
		/// 施工图纸设计天数
		/// </summary>
		public decimal? CON_DRAW_DESIGN_DAY
		{
			get{ return _CON_DRAW_DESIGN_DAY; }
			set
			{
				this.OnPropertyValueChange(_.CON_DRAW_DESIGN_DAY, _CON_DRAW_DESIGN_DAY, value);
				this._CON_DRAW_DESIGN_DAY = value;
			}
		}
		/// <summary>
		/// 提交初测、初勘报告时间
		/// </summary>
		public decimal? SUBMIT_FIRST_TEST_TIME
		{
			get{ return _SUBMIT_FIRST_TEST_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_FIRST_TEST_TIME, _SUBMIT_FIRST_TEST_TIME, value);
				this._SUBMIT_FIRST_TEST_TIME = value;
			}
		}
		/// <summary>
		/// 提交初测、初勘报告份数
		/// </summary>
		public decimal? SUBMIT_FIRST_TEST_NUMBER
		{
			get{ return _SUBMIT_FIRST_TEST_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_FIRST_TEST_NUMBER, _SUBMIT_FIRST_TEST_NUMBER, value);
				this._SUBMIT_FIRST_TEST_NUMBER = value;
			}
		}
		/// <summary>
		/// 提交初步设计文件时间
		/// </summary>
		public decimal? PRESENT_DESIGN_TIME
		{
			get{ return _PRESENT_DESIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PRESENT_DESIGN_TIME, _PRESENT_DESIGN_TIME, value);
				this._PRESENT_DESIGN_TIME = value;
			}
		}
		/// <summary>
		/// 提交初步设计文件份数
		/// </summary>
		public decimal? PRESENT_DESIGN_NUMBER
		{
			get{ return _PRESENT_DESIGN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PRESENT_DESIGN_NUMBER, _PRESENT_DESIGN_NUMBER, value);
				this._PRESENT_DESIGN_NUMBER = value;
			}
		}
		/// <summary>
		/// 完成初步设计文件的修编和审批时间
		/// </summary>
		public decimal? COMPLETE_DESIGN_TIME
		{
			get{ return _COMPLETE_DESIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLETE_DESIGN_TIME, _COMPLETE_DESIGN_TIME, value);
				this._COMPLETE_DESIGN_TIME = value;
			}
		}
		/// <summary>
		/// 提交详勘、定测报告时间
		/// </summary>
		public decimal? SUBMIT_SURVAY_PRESENT_TIME
		{
			get{ return _SUBMIT_SURVAY_PRESENT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_SURVAY_PRESENT_TIME, _SUBMIT_SURVAY_PRESENT_TIME, value);
				this._SUBMIT_SURVAY_PRESENT_TIME = value;
			}
		}
		/// <summary>
		/// 提交详勘、定测报告份数
		/// </summary>
		public decimal? SUBMIT_SURVAY_PRESENT_NUMBER
		{
			get{ return _SUBMIT_SURVAY_PRESENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_SURVAY_PRESENT_NUMBER, _SUBMIT_SURVAY_PRESENT_NUMBER, value);
				this._SUBMIT_SURVAY_PRESENT_NUMBER = value;
			}
		}
		/// <summary>
		/// 提交施工图设计文件时间
		/// </summary>
		public decimal? SUBMIT_DRAW_DESIGN_TIME
		{
			get{ return _SUBMIT_DRAW_DESIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_DRAW_DESIGN_TIME, _SUBMIT_DRAW_DESIGN_TIME, value);
				this._SUBMIT_DRAW_DESIGN_TIME = value;
			}
		}
		/// <summary>
		/// 提交施工图设计文件份数
		/// </summary>
		public decimal? SUBMIT_DRAW_DESIGN_NUMBER
		{
			get{ return _SUBMIT_DRAW_DESIGN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_DRAW_DESIGN_NUMBER, _SUBMIT_DRAW_DESIGN_NUMBER, value);
				this._SUBMIT_DRAW_DESIGN_NUMBER = value;
			}
		}
		/// <summary>
		/// 完成施工图设计文件的修编和审批时间
		/// </summary>
		public decimal? COM_DRAW_DESIGN_TIME
		{
			get{ return _COM_DRAW_DESIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COM_DRAW_DESIGN_TIME, _COM_DRAW_DESIGN_TIME, value);
				this._COM_DRAW_DESIGN_TIME = value;
			}
		}
		/// <summary>
		/// 提交各专题研究报告时间
		/// </summary>
		public decimal? SUBMIT_STUDY_PRESENT_TIME
		{
			get{ return _SUBMIT_STUDY_PRESENT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_STUDY_PRESENT_TIME, _SUBMIT_STUDY_PRESENT_TIME, value);
				this._SUBMIT_STUDY_PRESENT_TIME = value;
			}
		}
		/// <summary>
		/// 提交各专题研究报告份数
		/// </summary>
		public decimal? SUBMIT_STUDY_PRESENT_NUMBER
		{
			get{ return _SUBMIT_STUDY_PRESENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_STUDY_PRESENT_NUMBER, _SUBMIT_STUDY_PRESENT_NUMBER, value);
				this._SUBMIT_STUDY_PRESENT_NUMBER = value;
			}
		}
		/// <summary>
		/// 提交最终稿时间
		/// </summary>
		public decimal? SUBMIT_FINAL_TIME
		{
			get{ return _SUBMIT_FINAL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_FINAL_TIME, _SUBMIT_FINAL_TIME, value);
				this._SUBMIT_FINAL_TIME = value;
			}
		}
		/// <summary>
		/// 提交最终稿份数
		/// </summary>
		public decimal? SUBMIT_FINAL_NUMBER
		{
			get{ return _SUBMIT_FINAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_FINAL_NUMBER, _SUBMIT_FINAL_NUMBER, value);
				this._SUBMIT_FINAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 最终稿每标段份数
		/// </summary>
		public decimal? FINAL_SECTION_NUMBER
		{
			get{ return _FINAL_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.FINAL_SECTION_NUMBER, _FINAL_SECTION_NUMBER, value);
				this._FINAL_SECTION_NUMBER = value;
			}
		}
		/// <summary>
		/// 存档电子（光盘）文件套数
		/// </summary>
		public decimal? FILE_DOCUMENT_NUMBER
		{
			get{ return _FILE_DOCUMENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.FILE_DOCUMENT_NUMBER, _FILE_DOCUMENT_NUMBER, value);
				this._FILE_DOCUMENT_NUMBER = value;
			}
		}
		/// <summary>
		/// 最终稿存档电子（光盘）文件套数
		/// </summary>
		public decimal? FINAL_DOCUMENT_NUMBER
		{
			get{ return _FINAL_DOCUMENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.FINAL_DOCUMENT_NUMBER, _FINAL_DOCUMENT_NUMBER, value);
				this._FINAL_DOCUMENT_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标资料每个标段份数
		/// </summary>
		public decimal? TENDER_SECTION_NUMBER
		{
			get{ return _TENDER_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_SECTION_NUMBER, _TENDER_SECTION_NUMBER, value);
				this._TENDER_SECTION_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标资料存档电子（光盘）文件套数
		/// </summary>
		public decimal? TENER_DOCUMENT_NUMBER
		{
			get{ return _TENER_DOCUMENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENER_DOCUMENT_NUMBER, _TENER_DOCUMENT_NUMBER, value);
				this._TENER_DOCUMENT_NUMBER = value;
			}
		}
		/// <summary>
		/// 提交征地报批所需的图纸、资料时间
		/// </summary>
		public decimal? SUBMIT_LAND_DECLARE_TIME
		{
			get{ return _SUBMIT_LAND_DECLARE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_LAND_DECLARE_TIME, _SUBMIT_LAND_DECLARE_TIME, value);
				this._SUBMIT_LAND_DECLARE_TIME = value;
			}
		}
		/// <summary>
		/// 质量保证金
		/// </summary>
		public decimal? RETENT_MONEY
		{
			get{ return _RETENT_MONEY; }
			set
			{
				this.OnPropertyValueChange(_.RETENT_MONEY, _RETENT_MONEY, value);
				this._RETENT_MONEY = value;
			}
		}
		/// <summary>
		/// 争议的解决方式
		/// </summary>
		public string DISPUTE_SOLUTION
		{
			get{ return _DISPUTE_SOLUTION; }
			set
			{
				this.OnPropertyValueChange(_.DISPUTE_SOLUTION, _DISPUTE_SOLUTION, value);
				this._DISPUTE_SOLUTION = value;
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
		/// 企业信用分使用要求
		/// </summary>
		public string CREDIT_USE_REQUIRE1
		{
			get{ return _CREDIT_USE_REQUIRE1; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_USE_REQUIRE1, _CREDIT_USE_REQUIRE1, value);
				this._CREDIT_USE_REQUIRE1 = value;
			}
		}
		/// <summary>
		/// 项目负责人信用分使用要求
		/// </summary>
		public string CREDIT_USE_REQUIRE2
		{
			get{ return _CREDIT_USE_REQUIRE2; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_USE_REQUIRE2, _CREDIT_USE_REQUIRE2, value);
				this._CREDIT_USE_REQUIRE2 = value;
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
		/// 业绩要求
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
		/// 投标人骗取中标或严重违约的年份要求
		/// </summary>
		public DateTime? SERIOUS_BREACH_TIME
		{
			get{ return _SERIOUS_BREACH_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERIOUS_BREACH_TIME, _SERIOUS_BREACH_TIME, value);
				this._SERIOUS_BREACH_TIME = value;
			}
		}
		/// <summary>
		/// 投标文件形式
		/// </summary>
		public string TENDER_DOC_FORM
		{
			get{ return _TENDER_DOC_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_FORM, _TENDER_DOC_FORM, value);
				this._TENDER_DOC_FORM = value;
			}
		}
		/// <summary>
		/// 投标固定总价
		/// </summary>
		public decimal? FIXED_BID_PRICE
		{
			get{ return _FIXED_BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.FIXED_BID_PRICE, _FIXED_BID_PRICE, value);
				this._FIXED_BID_PRICE = value;
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
		/// 解密地点
		/// </summary>
		public string DECRYPTION_ADDRESS
		{
			get{ return _DECRYPTION_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.DECRYPTION_ADDRESS, _DECRYPTION_ADDRESS, value);
				this._DECRYPTION_ADDRESS = value;
			}
		}
		/// <summary>
		/// 投标固定总价含暂列金额
		/// </summary>
		public decimal? PROVISIONAL_SUM
		{
			get{ return _PROVISIONAL_SUM; }
			set
			{
				this.OnPropertyValueChange(_.PROVISIONAL_SUM, _PROVISIONAL_SUM, value);
				this._PROVISIONAL_SUM = value;
			}
		}
		/// <summary>
		/// 固定单价（或取费）约定
		/// </summary>
		public string BID_FIXED_UNIT_PRICE_REQURE
		{
			get{ return _BID_FIXED_UNIT_PRICE_REQURE; }
			set
			{
				this.OnPropertyValueChange(_.BID_FIXED_UNIT_PRICE_REQURE, _BID_FIXED_UNIT_PRICE_REQURE, value);
				this._BID_FIXED_UNIT_PRICE_REQURE = value;
			}
		}
		/// <summary>
		/// 每个标段投标保证金金额
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
		/// 年度保证金应符合的规定
		/// </summary>
		public string ANNUAL_DEPOSIT
		{
			get{ return _ANNUAL_DEPOSIT; }
			set
			{
				this.OnPropertyValueChange(_.ANNUAL_DEPOSIT, _ANNUAL_DEPOSIT, value);
				this._ANNUAL_DEPOSIT = value;
			}
		}
		/// <summary>
		/// 保证金是否计息
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
		/// 利息约定
		/// </summary>
		public string MARGIN_RETURN_CONTENT
		{
			get{ return _MARGIN_RETURN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_RETURN_CONTENT, _MARGIN_RETURN_CONTENT, value);
				this._MARGIN_RETURN_CONTENT = value;
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
		/// 投标文件封套信封是否显示第三信封
		/// </summary>
		public string BID_DOC_ENVELOPE
		{
			get{ return _BID_DOC_ENVELOPE; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_ENVELOPE, _BID_DOC_ENVELOPE, value);
				this._BID_DOC_ENVELOPE = value;
			}
		}
		/// <summary>
		/// 投标文件开标次数
		/// </summary>
		public string BID_OPEN_TIMES
		{
			get{ return _BID_OPEN_TIMES; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIMES, _BID_OPEN_TIMES, value);
				this._BID_OPEN_TIMES = value;
			}
		}
		/// <summary>
		/// 解密流程
		/// </summary>
		public string DECRYPTION_FLOW
		{
			get{ return _DECRYPTION_FLOW; }
			set
			{
				this.OnPropertyValueChange(_.DECRYPTION_FLOW, _DECRYPTION_FLOW, value);
				this._DECRYPTION_FLOW = value;
			}
		}
		/// <summary>
		/// 解密完成后电子交易平台自动显示的内容
		/// </summary>
		public string BID_OPEN_CONTENT
		{
			get{ return _BID_OPEN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_CONTENT, _BID_OPEN_CONTENT, value);
				this._BID_OPEN_CONTENT = value;
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
		/// 中标候选人公示期
		/// </summary>
		public decimal? CANDIDATE_PERIOD
		{
			get{ return _CANDIDATE_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.CANDIDATE_PERIOD, _CANDIDATE_PERIOD, value);
				this._CANDIDATE_PERIOD = value;
			}
		}
		/// <summary>
		/// 中标结果公示期
		/// </summary>
		public decimal? RESULTS_PERIOD
		{
			get{ return _RESULTS_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.RESULTS_PERIOD, _RESULTS_PERIOD, value);
				this._RESULTS_PERIOD = value;
			}
		}
		/// <summary>
		/// 技术文件评审方法
		/// </summary>
		public string TECH_DOC_REVIEW_TYPE
		{
			get{ return _TECH_DOC_REVIEW_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_DOC_REVIEW_TYPE, _TECH_DOC_REVIEW_TYPE, value);
				this._TECH_DOC_REVIEW_TYPE = value;
			}
		}
		/// <summary>
		/// 专家推荐的中标候选人数
		/// </summary>
		public decimal? CANDIDATE_NUMBER
		{
			get{ return _CANDIDATE_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CANDIDATE_NUMBER, _CANDIDATE_NUMBER, value);
				this._CANDIDATE_NUMBER = value;
			}
		}
		/// <summary>
		/// 履约担保额为合同价（含不可预见费）
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
		/// 履约担保额提交在收到中标通知书后
		/// </summary>
		public decimal? PERFORM_PRICE_TIME
		{
			get{ return _PERFORM_PRICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_PRICE_TIME, _PERFORM_PRICE_TIME, value);
				this._PERFORM_PRICE_TIME = value;
			}
		}
		/// <summary>
		/// 订立书面合同的时间在中标通知书发出后的天数
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
		/// 勘察设计技术要求
		/// </summary>
		public string TECH_REQUIRE
		{
			get{ return _TECH_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_REQUIRE, _TECH_REQUIRE, value);
				this._TECH_REQUIRE = value;
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
				_.LIMITE_ALL_TIME,
				_.TECHNICAL_STANDARD,
				_.BID_SECTION_DIVISION,
				_.SURVEY_DESIGN_CYCLE,
				_.SYNDICATED_NUMBER,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.MARGIN_TIME,
				_.MEDIA1,
				_.MEDIA2,
				_.FUND_IMPLEMENTATION,
				_.TENDER_OTHER_CONTENT,
				_.SAME_INFORMATION,
				_.TENDER_CONTEN_COMPONENT,
				_.REPUTATION_TIME2,
				_.REPUTATION_TIME3,
				_.TENDER_CONTENT_ENCLOSURE,
				_.SURVEY_DESIGN_ENCLOSURE,
				_.TENDER_OFFER_REQUIRE,
				_.EFFECTIVE_BID_FLOAT,
				_.E1_NUMBER,
				_.E2_NUMBER,
				_.SUBC_NUMBER,
				_.SURVEY_REPORT,
				_.DESIGN_DOC,
				_.CONSTRUCTION_PERIOD,
				_.PRE_DESIGN_DAY,
				_.CON_DRAW_DESIGN_DAY,
				_.SUBMIT_FIRST_TEST_TIME,
				_.SUBMIT_FIRST_TEST_NUMBER,
				_.PRESENT_DESIGN_TIME,
				_.PRESENT_DESIGN_NUMBER,
				_.COMPLETE_DESIGN_TIME,
				_.SUBMIT_SURVAY_PRESENT_TIME,
				_.SUBMIT_SURVAY_PRESENT_NUMBER,
				_.SUBMIT_DRAW_DESIGN_TIME,
				_.SUBMIT_DRAW_DESIGN_NUMBER,
				_.COM_DRAW_DESIGN_TIME,
				_.SUBMIT_STUDY_PRESENT_TIME,
				_.SUBMIT_STUDY_PRESENT_NUMBER,
				_.SUBMIT_FINAL_TIME,
				_.SUBMIT_FINAL_NUMBER,
				_.FINAL_SECTION_NUMBER,
				_.FILE_DOCUMENT_NUMBER,
				_.FINAL_DOCUMENT_NUMBER,
				_.TENDER_SECTION_NUMBER,
				_.TENER_DOCUMENT_NUMBER,
				_.SUBMIT_LAND_DECLARE_TIME,
				_.RETENT_MONEY,
				_.DISPUTE_SOLUTION,
				_.ENCLOSURE1,
				_.ENCLOSURE2,
				_.ENCLOSURE3,
				_.CREDIT_USE_REQUIRE1,
				_.CREDIT_USE_REQUIRE2,
				_.DECRYPTION_TYPE,
				_.ACHIEVEMENT_CONDITIONS,
				_.QUALIFICATION_REQUIRE,
				_.MINIMUM_QUALIFICATIONS,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.OTHER_REQUIRE,
				_.SUBCONTRACT,
				_.SERIOUS_BREACH_TIME,
				_.TENDER_DOC_FORM,
				_.FIXED_BID_PRICE,
				_.OPEN_BID_REQURE_CHOOSE,
				_.DECRYPTION_ADDRESS,
				_.PROVISIONAL_SUM,
				_.BID_FIXED_UNIT_PRICE_REQURE,
				_.MARGIN_AMOUNT,
				_.ANNUAL_DEPOSIT,
				_.MARGIN_RETURN_TYPE,
				_.MARGIN_RETURN_CONTENT,
				_.COPY_NUM,
				_.BID_DOC_ENVELOPE,
				_.BID_OPEN_TIMES,
				_.DECRYPTION_FLOW,
				_.BID_OPEN_CONTENT,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_EXTRACT,
				_.CANDIDATE_PERIOD,
				_.RESULTS_PERIOD,
				_.TECH_DOC_REVIEW_TYPE,
				_.CANDIDATE_NUMBER,
				_.PERFORM_PRICE,
				_.PERFORM_PRICE_TIME,
				_.SIGN_CONTRACT_TIME,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_PHONE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.SUPERVISE_DEPT_FAX,
				_.TECH_REQUIRE,
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
				this._LIMITE_ALL_TIME,
				this._TECHNICAL_STANDARD,
				this._BID_SECTION_DIVISION,
				this._SURVEY_DESIGN_CYCLE,
				this._SYNDICATED_NUMBER,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._MARGIN_TIME,
				this._MEDIA1,
				this._MEDIA2,
				this._FUND_IMPLEMENTATION,
				this._TENDER_OTHER_CONTENT,
				this._SAME_INFORMATION,
				this._TENDER_CONTEN_COMPONENT,
				this._REPUTATION_TIME2,
				this._REPUTATION_TIME3,
				this._TENDER_CONTENT_ENCLOSURE,
				this._SURVEY_DESIGN_ENCLOSURE,
				this._TENDER_OFFER_REQUIRE,
				this._EFFECTIVE_BID_FLOAT,
				this._E1_NUMBER,
				this._E2_NUMBER,
				this._SUBC_NUMBER,
				this._SURVEY_REPORT,
				this._DESIGN_DOC,
				this._CONSTRUCTION_PERIOD,
				this._PRE_DESIGN_DAY,
				this._CON_DRAW_DESIGN_DAY,
				this._SUBMIT_FIRST_TEST_TIME,
				this._SUBMIT_FIRST_TEST_NUMBER,
				this._PRESENT_DESIGN_TIME,
				this._PRESENT_DESIGN_NUMBER,
				this._COMPLETE_DESIGN_TIME,
				this._SUBMIT_SURVAY_PRESENT_TIME,
				this._SUBMIT_SURVAY_PRESENT_NUMBER,
				this._SUBMIT_DRAW_DESIGN_TIME,
				this._SUBMIT_DRAW_DESIGN_NUMBER,
				this._COM_DRAW_DESIGN_TIME,
				this._SUBMIT_STUDY_PRESENT_TIME,
				this._SUBMIT_STUDY_PRESENT_NUMBER,
				this._SUBMIT_FINAL_TIME,
				this._SUBMIT_FINAL_NUMBER,
				this._FINAL_SECTION_NUMBER,
				this._FILE_DOCUMENT_NUMBER,
				this._FINAL_DOCUMENT_NUMBER,
				this._TENDER_SECTION_NUMBER,
				this._TENER_DOCUMENT_NUMBER,
				this._SUBMIT_LAND_DECLARE_TIME,
				this._RETENT_MONEY,
				this._DISPUTE_SOLUTION,
				this._ENCLOSURE1,
				this._ENCLOSURE2,
				this._ENCLOSURE3,
				this._CREDIT_USE_REQUIRE1,
				this._CREDIT_USE_REQUIRE2,
				this._DECRYPTION_TYPE,
				this._ACHIEVEMENT_CONDITIONS,
				this._QUALIFICATION_REQUIRE,
				this._MINIMUM_QUALIFICATIONS,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._OTHER_REQUIRE,
				this._SUBCONTRACT,
				this._SERIOUS_BREACH_TIME,
				this._TENDER_DOC_FORM,
				this._FIXED_BID_PRICE,
				this._OPEN_BID_REQURE_CHOOSE,
				this._DECRYPTION_ADDRESS,
				this._PROVISIONAL_SUM,
				this._BID_FIXED_UNIT_PRICE_REQURE,
				this._MARGIN_AMOUNT,
				this._ANNUAL_DEPOSIT,
				this._MARGIN_RETURN_TYPE,
				this._MARGIN_RETURN_CONTENT,
				this._COPY_NUM,
				this._BID_DOC_ENVELOPE,
				this._BID_OPEN_TIMES,
				this._DECRYPTION_FLOW,
				this._BID_OPEN_CONTENT,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_EXTRACT,
				this._CANDIDATE_PERIOD,
				this._RESULTS_PERIOD,
				this._TECH_DOC_REVIEW_TYPE,
				this._CANDIDATE_NUMBER,
				this._PERFORM_PRICE,
				this._PERFORM_PRICE_TIME,
				this._SIGN_CONTRACT_TIME,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_PHONE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._SUPERVISE_DEPT_FAX,
				this._TECH_REQUIRE,
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
			public readonly static Field All = new Field("*", "JT_GEN_SURVEY_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_GEN_SURVEY_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_GEN_SURVEY_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 技术标准
			/// </summary>
			public readonly static Field TECHNICAL_STANDARD = new Field("TECHNICAL_STANDARD", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "技术标准");
            /// <summary>
			/// 标段划分
			/// </summary>
			public readonly static Field BID_SECTION_DIVISION = new Field("BID_SECTION_DIVISION", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "标段划分");
            /// <summary>
			/// 勘察设计周期
			/// </summary>
			public readonly static Field SURVEY_DESIGN_CYCLE = new Field("SURVEY_DESIGN_CYCLE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "勘察设计周期");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field SYNDICATED_NUMBER = new Field("SYNDICATED_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 投标人最多可投标段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_GEN_SURVEY_TENDER_FILE", "投标人最多可投标段数量");
            /// <summary>
			/// 投标人最多可中标数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "投标人最多可中标数量");
            /// <summary>
			/// 保证金户名
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_GEN_SURVEY_TENDER_FILE", "保证金户名");
            /// <summary>
			/// 保证金账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "保证金账号");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_GEN_SURVEY_TENDER_FILE", "开户银行");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_GEN_SURVEY_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_GEN_SURVEY_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_GEN_SURVEY_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_GEN_SURVEY_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 招标范围其它
			/// </summary>
			public readonly static Field TENDER_OTHER_CONTENT = new Field("TENDER_OTHER_CONTENT", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "招标范围其它");
            /// <summary>
			/// 投标人信息与信用管理系统是否要保持一致
			/// </summary>
			public readonly static Field SAME_INFORMATION = new Field("SAME_INFORMATION", "JT_GEN_SURVEY_TENDER_FILE", "投标人信息与信用管理系统是否要保持一致");
            /// <summary>
			/// 招标范围的组成部分
			/// </summary>
			public readonly static Field TENDER_CONTEN_COMPONENT = new Field("TENDER_CONTEN_COMPONENT", "JT_GEN_SURVEY_TENDER_FILE", "招标范围的组成部分");
            /// <summary>
			/// 未出现不良记录时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME2 = new Field("REPUTATION_TIME2", "JT_GEN_SURVEY_TENDER_FILE", "未出现不良记录时间要求");
            /// <summary>
			/// 未出现未履约的合同时间要求
			/// </summary>
			public readonly static Field REPUTATION_TIME3 = new Field("REPUTATION_TIME3", "JT_GEN_SURVEY_TENDER_FILE", "未出现未履约的合同时间要求");
            /// <summary>
			/// 工程概况及招标范围附件
			/// </summary>
			public readonly static Field TENDER_CONTENT_ENCLOSURE = new Field("TENDER_CONTENT_ENCLOSURE", "JT_GEN_SURVEY_TENDER_FILE", "工程概况及招标范围附件");
            /// <summary>
			/// 勘察设计原始资料附件
			/// </summary>
			public readonly static Field SURVEY_DESIGN_ENCLOSURE = new Field("SURVEY_DESIGN_ENCLOSURE", "JT_GEN_SURVEY_TENDER_FILE", "勘察设计原始资料附件");
            /// <summary>
			/// 算术性修正后的投标报价要求
			/// </summary>
			public readonly static Field TENDER_OFFER_REQUIRE = new Field("TENDER_OFFER_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE", "算术性修正后的投标报价要求");
            /// <summary>
			/// 有效最低报价的下浮系数
			/// </summary>
			public readonly static Field EFFECTIVE_BID_FLOAT = new Field("EFFECTIVE_BID_FLOAT", "JT_GEN_SURVEY_TENDER_FILE", "有效最低报价的下浮系数");
            /// <summary>
			/// E1值
			/// </summary>
			public readonly static Field E1_NUMBER = new Field("E1_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "E1值");
            /// <summary>
			/// E2值
			/// </summary>
			public readonly static Field E2_NUMBER = new Field("E2_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "E2值");
            /// <summary>
			/// 发包人
			/// </summary>
			public readonly static Field SUBC_NUMBER = new Field("SUBC_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "发包人");
            /// <summary>
			/// 勘察报告
			/// </summary>
			public readonly static Field SURVEY_REPORT = new Field("SURVEY_REPORT", "JT_GEN_SURVEY_TENDER_FILE", "勘察报告");
            /// <summary>
			/// 设计文件
			/// </summary>
			public readonly static Field DESIGN_DOC = new Field("DESIGN_DOC", "JT_GEN_SURVEY_TENDER_FILE", "设计文件");
            /// <summary>
			/// 施工期
			/// </summary>
			public readonly static Field CONSTRUCTION_PERIOD = new Field("CONSTRUCTION_PERIOD", "JT_GEN_SURVEY_TENDER_FILE", "施工期");
            /// <summary>
			/// 初步设计天数
			/// </summary>
			public readonly static Field PRE_DESIGN_DAY = new Field("PRE_DESIGN_DAY", "JT_GEN_SURVEY_TENDER_FILE", "初步设计天数");
            /// <summary>
			/// 施工图纸设计天数
			/// </summary>
			public readonly static Field CON_DRAW_DESIGN_DAY = new Field("CON_DRAW_DESIGN_DAY", "JT_GEN_SURVEY_TENDER_FILE", "施工图纸设计天数");
            /// <summary>
			/// 提交初测、初勘报告时间
			/// </summary>
			public readonly static Field SUBMIT_FIRST_TEST_TIME = new Field("SUBMIT_FIRST_TEST_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交初测、初勘报告时间");
            /// <summary>
			/// 提交初测、初勘报告份数
			/// </summary>
			public readonly static Field SUBMIT_FIRST_TEST_NUMBER = new Field("SUBMIT_FIRST_TEST_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交初测、初勘报告份数");
            /// <summary>
			/// 提交初步设计文件时间
			/// </summary>
			public readonly static Field PRESENT_DESIGN_TIME = new Field("PRESENT_DESIGN_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交初步设计文件时间");
            /// <summary>
			/// 提交初步设计文件份数
			/// </summary>
			public readonly static Field PRESENT_DESIGN_NUMBER = new Field("PRESENT_DESIGN_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交初步设计文件份数");
            /// <summary>
			/// 完成初步设计文件的修编和审批时间
			/// </summary>
			public readonly static Field COMPLETE_DESIGN_TIME = new Field("COMPLETE_DESIGN_TIME", "JT_GEN_SURVEY_TENDER_FILE", "完成初步设计文件的修编和审批时间");
            /// <summary>
			/// 提交详勘、定测报告时间
			/// </summary>
			public readonly static Field SUBMIT_SURVAY_PRESENT_TIME = new Field("SUBMIT_SURVAY_PRESENT_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交详勘、定测报告时间");
            /// <summary>
			/// 提交详勘、定测报告份数
			/// </summary>
			public readonly static Field SUBMIT_SURVAY_PRESENT_NUMBER = new Field("SUBMIT_SURVAY_PRESENT_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交详勘、定测报告份数");
            /// <summary>
			/// 提交施工图设计文件时间
			/// </summary>
			public readonly static Field SUBMIT_DRAW_DESIGN_TIME = new Field("SUBMIT_DRAW_DESIGN_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交施工图设计文件时间");
            /// <summary>
			/// 提交施工图设计文件份数
			/// </summary>
			public readonly static Field SUBMIT_DRAW_DESIGN_NUMBER = new Field("SUBMIT_DRAW_DESIGN_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交施工图设计文件份数");
            /// <summary>
			/// 完成施工图设计文件的修编和审批时间
			/// </summary>
			public readonly static Field COM_DRAW_DESIGN_TIME = new Field("COM_DRAW_DESIGN_TIME", "JT_GEN_SURVEY_TENDER_FILE", "完成施工图设计文件的修编和审批时间");
            /// <summary>
			/// 提交各专题研究报告时间
			/// </summary>
			public readonly static Field SUBMIT_STUDY_PRESENT_TIME = new Field("SUBMIT_STUDY_PRESENT_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交各专题研究报告时间");
            /// <summary>
			/// 提交各专题研究报告份数
			/// </summary>
			public readonly static Field SUBMIT_STUDY_PRESENT_NUMBER = new Field("SUBMIT_STUDY_PRESENT_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交各专题研究报告份数");
            /// <summary>
			/// 提交最终稿时间
			/// </summary>
			public readonly static Field SUBMIT_FINAL_TIME = new Field("SUBMIT_FINAL_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交最终稿时间");
            /// <summary>
			/// 提交最终稿份数
			/// </summary>
			public readonly static Field SUBMIT_FINAL_NUMBER = new Field("SUBMIT_FINAL_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "提交最终稿份数");
            /// <summary>
			/// 最终稿每标段份数
			/// </summary>
			public readonly static Field FINAL_SECTION_NUMBER = new Field("FINAL_SECTION_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "最终稿每标段份数");
            /// <summary>
			/// 存档电子（光盘）文件套数
			/// </summary>
			public readonly static Field FILE_DOCUMENT_NUMBER = new Field("FILE_DOCUMENT_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "存档电子（光盘）文件套数");
            /// <summary>
			/// 最终稿存档电子（光盘）文件套数
			/// </summary>
			public readonly static Field FINAL_DOCUMENT_NUMBER = new Field("FINAL_DOCUMENT_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "最终稿存档电子（光盘）文件套数");
            /// <summary>
			/// 招标资料每个标段份数
			/// </summary>
			public readonly static Field TENDER_SECTION_NUMBER = new Field("TENDER_SECTION_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "招标资料每个标段份数");
            /// <summary>
			/// 招标资料存档电子（光盘）文件套数
			/// </summary>
			public readonly static Field TENER_DOCUMENT_NUMBER = new Field("TENER_DOCUMENT_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "招标资料存档电子（光盘）文件套数");
            /// <summary>
			/// 提交征地报批所需的图纸、资料时间
			/// </summary>
			public readonly static Field SUBMIT_LAND_DECLARE_TIME = new Field("SUBMIT_LAND_DECLARE_TIME", "JT_GEN_SURVEY_TENDER_FILE", "提交征地报批所需的图纸、资料时间");
            /// <summary>
			/// 质量保证金
			/// </summary>
			public readonly static Field RETENT_MONEY = new Field("RETENT_MONEY", "JT_GEN_SURVEY_TENDER_FILE", "质量保证金");
            /// <summary>
			/// 争议的解决方式
			/// </summary>
			public readonly static Field DISPUTE_SOLUTION = new Field("DISPUTE_SOLUTION", "JT_GEN_SURVEY_TENDER_FILE", "争议的解决方式");
            /// <summary>
			/// 标后监管指南
			/// </summary>
			public readonly static Field ENCLOSURE1 = new Field("ENCLOSURE1", "JT_GEN_SURVEY_TENDER_FILE", "标后监管指南");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field ENCLOSURE2 = new Field("ENCLOSURE2", "JT_GEN_SURVEY_TENDER_FILE", "招标代理合同");
            /// <summary>
			/// 招标人授权招标代理签章协议书
			/// </summary>
			public readonly static Field ENCLOSURE3 = new Field("ENCLOSURE3", "JT_GEN_SURVEY_TENDER_FILE", "招标人授权招标代理签章协议书");
            /// <summary>
			/// 企业信用分使用要求
			/// </summary>
			public readonly static Field CREDIT_USE_REQUIRE1 = new Field("CREDIT_USE_REQUIRE1", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "企业信用分使用要求");
            /// <summary>
			/// 项目负责人信用分使用要求
			/// </summary>
			public readonly static Field CREDIT_USE_REQUIRE2 = new Field("CREDIT_USE_REQUIRE2", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "项目负责人信用分使用要求");
            /// <summary>
			/// 投标文件解密方式
			/// </summary>
			public readonly static Field DECRYPTION_TYPE = new Field("DECRYPTION_TYPE", "JT_GEN_SURVEY_TENDER_FILE", "投标文件解密方式");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_CONDITIONS = new Field("ACHIEVEMENT_CONDITIONS", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "业绩要求");
            /// <summary>
			/// 主要人员最低要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "主要人员最低要求");
            /// <summary>
			/// 资质最低条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "资质最低条件");
            /// <summary>
			/// 业绩最低要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "业绩最低要求");
            /// <summary>
			/// 信誉最低要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "信誉最低要求");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 是否分包
			/// </summary>
			public readonly static Field SUBCONTRACT = new Field("SUBCONTRACT", "JT_GEN_SURVEY_TENDER_FILE", "是否分包");
            /// <summary>
			/// 投标人骗取中标或严重违约的年份要求
			/// </summary>
			public readonly static Field SERIOUS_BREACH_TIME = new Field("SERIOUS_BREACH_TIME", "JT_GEN_SURVEY_TENDER_FILE", "投标人骗取中标或严重违约的年份要求");
            /// <summary>
			/// 投标文件形式
			/// </summary>
			public readonly static Field TENDER_DOC_FORM = new Field("TENDER_DOC_FORM", "JT_GEN_SURVEY_TENDER_FILE", "投标文件形式");
            /// <summary>
			/// 投标固定总价
			/// </summary>
			public readonly static Field FIXED_BID_PRICE = new Field("FIXED_BID_PRICE", "JT_GEN_SURVEY_TENDER_FILE", "投标固定总价");
            /// <summary>
			/// 是否需要人员到场
			/// </summary>
			public readonly static Field OPEN_BID_REQURE_CHOOSE = new Field("OPEN_BID_REQURE_CHOOSE", "JT_GEN_SURVEY_TENDER_FILE", "是否需要人员到场");
            /// <summary>
			/// 解密地点
			/// </summary>
			public readonly static Field DECRYPTION_ADDRESS = new Field("DECRYPTION_ADDRESS", "JT_GEN_SURVEY_TENDER_FILE", "解密地点");
            /// <summary>
			/// 投标固定总价含暂列金额
			/// </summary>
			public readonly static Field PROVISIONAL_SUM = new Field("PROVISIONAL_SUM", "JT_GEN_SURVEY_TENDER_FILE", "投标固定总价含暂列金额");
            /// <summary>
			/// 固定单价（或取费）约定
			/// </summary>
			public readonly static Field BID_FIXED_UNIT_PRICE_REQURE = new Field("BID_FIXED_UNIT_PRICE_REQURE", "JT_GEN_SURVEY_TENDER_FILE", "固定单价（或取费）约定");
            /// <summary>
			/// 每个标段投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "JT_GEN_SURVEY_TENDER_FILE", "每个标段投标保证金金额");
            /// <summary>
			/// 年度保证金应符合的规定
			/// </summary>
			public readonly static Field ANNUAL_DEPOSIT = new Field("ANNUAL_DEPOSIT", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "年度保证金应符合的规定");
            /// <summary>
			/// 保证金是否计息
			/// </summary>
			public readonly static Field MARGIN_RETURN_TYPE = new Field("MARGIN_RETURN_TYPE", "JT_GEN_SURVEY_TENDER_FILE", "保证金是否计息");
            /// <summary>
			/// 利息约定
			/// </summary>
			public readonly static Field MARGIN_RETURN_CONTENT = new Field("MARGIN_RETURN_CONTENT", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "利息约定");
            /// <summary>
			/// 投标文件副本份数
			/// </summary>
			public readonly static Field COPY_NUM = new Field("COPY_NUM", "JT_GEN_SURVEY_TENDER_FILE", "投标文件副本份数");
            /// <summary>
			/// 投标文件封套信封是否显示第三信封
			/// </summary>
			public readonly static Field BID_DOC_ENVELOPE = new Field("BID_DOC_ENVELOPE", "JT_GEN_SURVEY_TENDER_FILE", "投标文件封套信封是否显示第三信封");
            /// <summary>
			/// 投标文件开标次数
			/// </summary>
			public readonly static Field BID_OPEN_TIMES = new Field("BID_OPEN_TIMES", "JT_GEN_SURVEY_TENDER_FILE", "投标文件开标次数");
            /// <summary>
			/// 解密流程
			/// </summary>
			public readonly static Field DECRYPTION_FLOW = new Field("DECRYPTION_FLOW", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "解密流程");
            /// <summary>
			/// 解密完成后电子交易平台自动显示的内容
			/// </summary>
			public readonly static Field BID_OPEN_CONTENT = new Field("BID_OPEN_CONTENT", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "解密完成后电子交易平台自动显示的内容");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_GEN_SURVEY_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_GEN_SURVEY_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_GEN_SURVEY_TENDER_FILE", "专家人数");
            /// <summary>
			/// 评标专家确定方式
			/// </summary>
			public readonly static Field EXPERT_EXTRACT = new Field("EXPERT_EXTRACT", "JT_GEN_SURVEY_TENDER_FILE", "评标专家确定方式");
            /// <summary>
			/// 中标候选人公示期
			/// </summary>
			public readonly static Field CANDIDATE_PERIOD = new Field("CANDIDATE_PERIOD", "JT_GEN_SURVEY_TENDER_FILE", "中标候选人公示期");
            /// <summary>
			/// 中标结果公示期
			/// </summary>
			public readonly static Field RESULTS_PERIOD = new Field("RESULTS_PERIOD", "JT_GEN_SURVEY_TENDER_FILE", "中标结果公示期");
            /// <summary>
			/// 技术文件评审方法
			/// </summary>
			public readonly static Field TECH_DOC_REVIEW_TYPE = new Field("TECH_DOC_REVIEW_TYPE", "JT_GEN_SURVEY_TENDER_FILE",DbType.AnsiString, null, "技术文件评审方法");
            /// <summary>
			/// 专家推荐的中标候选人数
			/// </summary>
			public readonly static Field CANDIDATE_NUMBER = new Field("CANDIDATE_NUMBER", "JT_GEN_SURVEY_TENDER_FILE", "专家推荐的中标候选人数");
            /// <summary>
			/// 履约担保额为合同价（含不可预见费）
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "JT_GEN_SURVEY_TENDER_FILE", "履约担保额为合同价（含不可预见费）");
            /// <summary>
			/// 履约担保额提交在收到中标通知书后
			/// </summary>
			public readonly static Field PERFORM_PRICE_TIME = new Field("PERFORM_PRICE_TIME", "JT_GEN_SURVEY_TENDER_FILE", "履约担保额提交在收到中标通知书后");
            /// <summary>
			/// 订立书面合同的时间在中标通知书发出后的天数
			/// </summary>
			public readonly static Field SIGN_CONTRACT_TIME = new Field("SIGN_CONTRACT_TIME", "JT_GEN_SURVEY_TENDER_FILE", "订立书面合同的时间在中标通知书发出后的天数");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_GEN_SURVEY_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE = new Field("SUPERVISE_DEPT_PHONE", "JT_GEN_SURVEY_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_GEN_SURVEY_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_GEN_SURVEY_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 监督部门传真
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX = new Field("SUPERVISE_DEPT_FAX", "JT_GEN_SURVEY_TENDER_FILE", "监督部门传真");
            /// <summary>
			/// 勘察设计技术要求
			/// </summary>
			public readonly static Field TECH_REQUIRE = new Field("TECH_REQUIRE", "JT_GEN_SURVEY_TENDER_FILE", "勘察设计技术要求");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_GEN_SURVEY_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_GEN_SURVEY_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_GEN_SURVEY_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_GEN_SURVEY_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_GEN_SURVEY_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_GEN_SURVEY_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_GEN_SURVEY_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_GEN_SURVEY_TENDER_FILE", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_GEN_SURVEY_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_GEN_SURVEY_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_GEN_SURVEY_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_GEN_SURVEY_TENDER_FILE", "");
        }
        #endregion
	}
}