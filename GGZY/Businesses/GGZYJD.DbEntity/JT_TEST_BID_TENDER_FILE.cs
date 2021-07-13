using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_TEST_BID_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_TEST_BID_TENDER_FILE")]
    [Serializable]
    public partial class JT_TEST_BID_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _PERIOD_SERVICE;
		private decimal? _TOTAL_SECTION_NUMBER;
		private decimal? _TENDERER_SECTION_NUMBER;
		private string _DETECT_PARAMETER;
		private string _CHARGE_QUAL_LEVEL;
		private string _CHARGE_TECH_TITLE;
		private string _TRADING_CENTER_NAME;
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
		private string _WORK_RANGE;
		private string _MINIMUM_QUALIFICATIONS;
		private string _FINANCIAL_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _OTHER_REQUIRE;
		private DateTime? _BIDDER_NOTICE_TIME;
		private decimal? _FINANCIAL_REQUIRE_BEGIN;
		private decimal? _FINANCIAL_REQUIRE_END;
		private decimal? _LITIGATION_BEGIN;
		private decimal? _LITIGATION_END;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _EXPERT_DETERMIN_BIDDER;
		private string _PERFORM_TYPE;
		private decimal? _PERFORM_PRICE;
		private string _SUPERVISE_DEPT_NAME1;
		private string _SUPERVISE_DEPT_ADDRESS1;
		private string _SUPERVISE_DEPT_PHONE1;
		private string _SUPERVISE_DEPT_FAX1;
		private string _SUPERVISE_DEPT_ZIP_CODE1;
		private string _SUPERVISE_DEPT_NAME2;
		private string _SUPERVISE_DEPT_ADDRESS2;
		private string _SUPERVISE_DEPT_PHONE2;
		private string _SUPERVISE_DEPT_FAX2;
		private string _SUPERVISE_DEPT_ZIP_CODE2;
		private string _OTHER_REQUIREMENTS;
		private string _SERVICE_CHARGE_QUOTATION;
		private string _DRAWING_DATA;
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
		/// 服务期
		/// </summary>
		public decimal? PERIOD_SERVICE
		{
			get{ return _PERIOD_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.PERIOD_SERVICE, _PERIOD_SERVICE, value);
				this._PERIOD_SERVICE = value;
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
		/// 检测参数
		/// </summary>
		public string DETECT_PARAMETER
		{
			get{ return _DETECT_PARAMETER; }
			set
			{
				this.OnPropertyValueChange(_.DETECT_PARAMETER, _DETECT_PARAMETER, value);
				this._DETECT_PARAMETER = value;
			}
		}
		/// <summary>
		/// 项目负责人资格要求
		/// </summary>
		public string CHARGE_QUAL_LEVEL
		{
			get{ return _CHARGE_QUAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.CHARGE_QUAL_LEVEL, _CHARGE_QUAL_LEVEL, value);
				this._CHARGE_QUAL_LEVEL = value;
			}
		}
		/// <summary>
		/// 项目负责人技术职称
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
		/// 其他发布媒体1
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
		/// 工作范围
		/// </summary>
		public string WORK_RANGE
		{
			get{ return _WORK_RANGE; }
			set
			{
				this.OnPropertyValueChange(_.WORK_RANGE, _WORK_RANGE, value);
				this._WORK_RANGE = value;
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
		/// 近年财务状况起始年份要求
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
		/// 近年财务状况结束年份要求
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
		/// 发生的诉讼及仲裁情况的起始年份要求
		/// </summary>
		public decimal? LITIGATION_BEGIN
		{
			get{ return _LITIGATION_BEGIN; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_BEGIN, _LITIGATION_BEGIN, value);
				this._LITIGATION_BEGIN = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况的结束年份要求
		/// </summary>
		public decimal? LITIGATION_END
		{
			get{ return _LITIGATION_END; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_END, _LITIGATION_END, value);
				this._LITIGATION_END = value;
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
		/// 投诉单位名称1
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
		/// 投诉单位电话1
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
		/// 投诉单位名称2
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
		/// 投诉单位电话2
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
		/// 价格总表
		/// </summary>
		public string SERVICE_CHARGE_QUOTATION
		{
			get{ return _SERVICE_CHARGE_QUOTATION; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_CHARGE_QUOTATION, _SERVICE_CHARGE_QUOTATION, value);
				this._SERVICE_CHARGE_QUOTATION = value;
			}
		}
		/// <summary>
		/// 图纸和资料
		/// </summary>
		public string DRAWING_DATA
		{
			get{ return _DRAWING_DATA; }
			set
			{
				this.OnPropertyValueChange(_.DRAWING_DATA, _DRAWING_DATA, value);
				this._DRAWING_DATA = value;
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
				_.PERIOD_SERVICE,
				_.TOTAL_SECTION_NUMBER,
				_.TENDERER_SECTION_NUMBER,
				_.DETECT_PARAMETER,
				_.CHARGE_QUAL_LEVEL,
				_.CHARGE_TECH_TITLE,
				_.TRADING_CENTER_NAME,
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
				_.WORK_RANGE,
				_.MINIMUM_QUALIFICATIONS,
				_.FINANCIAL_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.OTHER_REQUIRE,
				_.BIDDER_NOTICE_TIME,
				_.FINANCIAL_REQUIRE_BEGIN,
				_.FINANCIAL_REQUIRE_END,
				_.LITIGATION_BEGIN,
				_.LITIGATION_END,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.EXPERT_DETERMIN_BIDDER,
				_.PERFORM_TYPE,
				_.PERFORM_PRICE,
				_.SUPERVISE_DEPT_NAME1,
				_.SUPERVISE_DEPT_ADDRESS1,
				_.SUPERVISE_DEPT_PHONE1,
				_.SUPERVISE_DEPT_FAX1,
				_.SUPERVISE_DEPT_ZIP_CODE1,
				_.SUPERVISE_DEPT_NAME2,
				_.SUPERVISE_DEPT_ADDRESS2,
				_.SUPERVISE_DEPT_PHONE2,
				_.SUPERVISE_DEPT_FAX2,
				_.SUPERVISE_DEPT_ZIP_CODE2,
				_.OTHER_REQUIREMENTS,
				_.SERVICE_CHARGE_QUOTATION,
				_.DRAWING_DATA,
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
				this._PERIOD_SERVICE,
				this._TOTAL_SECTION_NUMBER,
				this._TENDERER_SECTION_NUMBER,
				this._DETECT_PARAMETER,
				this._CHARGE_QUAL_LEVEL,
				this._CHARGE_TECH_TITLE,
				this._TRADING_CENTER_NAME,
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
				this._WORK_RANGE,
				this._MINIMUM_QUALIFICATIONS,
				this._FINANCIAL_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._OTHER_REQUIRE,
				this._BIDDER_NOTICE_TIME,
				this._FINANCIAL_REQUIRE_BEGIN,
				this._FINANCIAL_REQUIRE_END,
				this._LITIGATION_BEGIN,
				this._LITIGATION_END,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._EXPERT_DETERMIN_BIDDER,
				this._PERFORM_TYPE,
				this._PERFORM_PRICE,
				this._SUPERVISE_DEPT_NAME1,
				this._SUPERVISE_DEPT_ADDRESS1,
				this._SUPERVISE_DEPT_PHONE1,
				this._SUPERVISE_DEPT_FAX1,
				this._SUPERVISE_DEPT_ZIP_CODE1,
				this._SUPERVISE_DEPT_NAME2,
				this._SUPERVISE_DEPT_ADDRESS2,
				this._SUPERVISE_DEPT_PHONE2,
				this._SUPERVISE_DEPT_FAX2,
				this._SUPERVISE_DEPT_ZIP_CODE2,
				this._OTHER_REQUIREMENTS,
				this._SERVICE_CHARGE_QUOTATION,
				this._DRAWING_DATA,
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
			public readonly static Field All = new Field("*", "JT_TEST_BID_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_TEST_BID_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_TEST_BID_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 服务期
			/// </summary>
			public readonly static Field PERIOD_SERVICE = new Field("PERIOD_SERVICE", "JT_TEST_BID_TENDER_FILE", "服务期");
            /// <summary>
			/// 总标段个数
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_TEST_BID_TENDER_FILE", "总标段个数");
            /// <summary>
			/// 本次招标标段个数
			/// </summary>
			public readonly static Field TENDERER_SECTION_NUMBER = new Field("TENDERER_SECTION_NUMBER", "JT_TEST_BID_TENDER_FILE", "本次招标标段个数");
            /// <summary>
			/// 检测参数
			/// </summary>
			public readonly static Field DETECT_PARAMETER = new Field("DETECT_PARAMETER", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "检测参数");
            /// <summary>
			/// 项目负责人资格要求
			/// </summary>
			public readonly static Field CHARGE_QUAL_LEVEL = new Field("CHARGE_QUAL_LEVEL", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "项目负责人资格要求");
            /// <summary>
			/// 项目负责人技术职称
			/// </summary>
			public readonly static Field CHARGE_TECH_TITLE = new Field("CHARGE_TECH_TITLE", "JT_TEST_BID_TENDER_FILE", "项目负责人技术职称");
            /// <summary>
			/// 公共资源交易中心名称
			/// </summary>
			public readonly static Field TRADING_CENTER_NAME = new Field("TRADING_CENTER_NAME", "JT_TEST_BID_TENDER_FILE", "公共资源交易中心名称");
            /// <summary>
			/// 保证金户名一
			/// </summary>
			public readonly static Field MARGIN_NAME1 = new Field("MARGIN_NAME1", "JT_TEST_BID_TENDER_FILE", "保证金户名一");
            /// <summary>
			/// 保证金账号一
			/// </summary>
			public readonly static Field MARGIN_NUMBER1 = new Field("MARGIN_NUMBER1", "JT_TEST_BID_TENDER_FILE", "保证金账号一");
            /// <summary>
			/// 开户银行一
			/// </summary>
			public readonly static Field MARGIN_BANK1 = new Field("MARGIN_BANK1", "JT_TEST_BID_TENDER_FILE", "开户银行一");
            /// <summary>
			/// 保证金户名二
			/// </summary>
			public readonly static Field MARGIN_NAME2 = new Field("MARGIN_NAME2", "JT_TEST_BID_TENDER_FILE", "保证金户名二");
            /// <summary>
			/// 保证金账号二
			/// </summary>
			public readonly static Field MARGIN_NUMBER2 = new Field("MARGIN_NUMBER2", "JT_TEST_BID_TENDER_FILE", "保证金账号二");
            /// <summary>
			/// 开户银行二
			/// </summary>
			public readonly static Field MARGIN_BANK2 = new Field("MARGIN_BANK2", "JT_TEST_BID_TENDER_FILE", "开户银行二");
            /// <summary>
			/// 保证金户名三
			/// </summary>
			public readonly static Field MARGIN_NAME3 = new Field("MARGIN_NAME3", "JT_TEST_BID_TENDER_FILE", "保证金户名三");
            /// <summary>
			/// 保证金账号三
			/// </summary>
			public readonly static Field MARGIN_NUMBER3 = new Field("MARGIN_NUMBER3", "JT_TEST_BID_TENDER_FILE", "保证金账号三");
            /// <summary>
			/// 开户银行三
			/// </summary>
			public readonly static Field MARGIN_BANK3 = new Field("MARGIN_BANK3", "JT_TEST_BID_TENDER_FILE", "开户银行三");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field NOTICE_MEDIA4 = new Field("NOTICE_MEDIA4", "JT_TEST_BID_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 工作范围
			/// </summary>
			public readonly static Field WORK_RANGE = new Field("WORK_RANGE", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "工作范围");
            /// <summary>
			/// 资质条件
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "资质条件");
            /// <summary>
			/// 财务要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "财务要求");
            /// <summary>
			/// 信誉要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "信誉要求");
            /// <summary>
			/// 其他最低要求
			/// </summary>
			public readonly static Field OTHER_REQUIRE = new Field("OTHER_REQUIRE", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "其他最低要求");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field BIDDER_NOTICE_TIME = new Field("BIDDER_NOTICE_TIME", "JT_TEST_BID_TENDER_FILE", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 近年财务状况起始年份要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_BEGIN = new Field("FINANCIAL_REQUIRE_BEGIN", "JT_TEST_BID_TENDER_FILE", "近年财务状况起始年份要求");
            /// <summary>
			/// 近年财务状况结束年份要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_END = new Field("FINANCIAL_REQUIRE_END", "JT_TEST_BID_TENDER_FILE", "近年财务状况结束年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况的起始年份要求
			/// </summary>
			public readonly static Field LITIGATION_BEGIN = new Field("LITIGATION_BEGIN", "JT_TEST_BID_TENDER_FILE", "发生的诉讼及仲裁情况的起始年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况的结束年份要求
			/// </summary>
			public readonly static Field LITIGATION_END = new Field("LITIGATION_END", "JT_TEST_BID_TENDER_FILE", "发生的诉讼及仲裁情况的结束年份要求");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_TEST_BID_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_TEST_BID_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_TEST_BID_TENDER_FILE", "专家人数");
            /// <summary>
			/// 是否授权评标委员会确定中标人
			/// </summary>
			public readonly static Field EXPERT_DETERMIN_BIDDER = new Field("EXPERT_DETERMIN_BIDDER", "JT_TEST_BID_TENDER_FILE", "是否授权评标委员会确定中标人");
            /// <summary>
			/// 履约担保形式
			/// </summary>
			public readonly static Field PERFORM_TYPE = new Field("PERFORM_TYPE", "JT_TEST_BID_TENDER_FILE", "履约担保形式");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "JT_TEST_BID_TENDER_FILE", "履约担保金额");
            /// <summary>
			/// 投诉单位名称1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME1 = new Field("SUPERVISE_DEPT_NAME1", "JT_TEST_BID_TENDER_FILE", "投诉单位名称1");
            /// <summary>
			/// 投诉单位地址1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS1 = new Field("SUPERVISE_DEPT_ADDRESS1", "JT_TEST_BID_TENDER_FILE", "投诉单位地址1");
            /// <summary>
			/// 投诉单位电话1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE1 = new Field("SUPERVISE_DEPT_PHONE1", "JT_TEST_BID_TENDER_FILE", "投诉单位电话1");
            /// <summary>
			/// 投诉单位传真1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX1 = new Field("SUPERVISE_DEPT_FAX1", "JT_TEST_BID_TENDER_FILE", "投诉单位传真1");
            /// <summary>
			/// 投诉单位邮编1
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE1 = new Field("SUPERVISE_DEPT_ZIP_CODE1", "JT_TEST_BID_TENDER_FILE", "投诉单位邮编1");
            /// <summary>
			/// 投诉单位名称2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME2 = new Field("SUPERVISE_DEPT_NAME2", "JT_TEST_BID_TENDER_FILE", "投诉单位名称2");
            /// <summary>
			/// 投诉单位地址2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS2 = new Field("SUPERVISE_DEPT_ADDRESS2", "JT_TEST_BID_TENDER_FILE", "投诉单位地址2");
            /// <summary>
			/// 投诉单位电话2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE2 = new Field("SUPERVISE_DEPT_PHONE2", "JT_TEST_BID_TENDER_FILE", "投诉单位电话2");
            /// <summary>
			/// 投诉单位传真2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX2 = new Field("SUPERVISE_DEPT_FAX2", "JT_TEST_BID_TENDER_FILE", "投诉单位传真2");
            /// <summary>
			/// 投诉单位邮编2
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE2 = new Field("SUPERVISE_DEPT_ZIP_CODE2", "JT_TEST_BID_TENDER_FILE", "投诉单位邮编2");
            /// <summary>
			/// 其他要求
			/// </summary>
			public readonly static Field OTHER_REQUIREMENTS = new Field("OTHER_REQUIREMENTS", "JT_TEST_BID_TENDER_FILE",DbType.AnsiString, null, "其他要求");
            /// <summary>
			/// 价格总表
			/// </summary>
			public readonly static Field SERVICE_CHARGE_QUOTATION = new Field("SERVICE_CHARGE_QUOTATION", "JT_TEST_BID_TENDER_FILE", "价格总表");
            /// <summary>
			/// 图纸和资料
			/// </summary>
			public readonly static Field DRAWING_DATA = new Field("DRAWING_DATA", "JT_TEST_BID_TENDER_FILE", "图纸和资料");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_TEST_BID_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_TEST_BID_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_TEST_BID_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_TEST_BID_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_TEST_BID_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_TEST_BID_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_TEST_BID_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_TEST_BID_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_TEST_BID_TENDER_FILE", "M_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_TEST_BID_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_TEST_BID_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_TEST_BID_TENDER_FILE", "");
        }
        #endregion
	}
}