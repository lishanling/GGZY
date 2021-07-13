using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_PROJECT")]
    [Serializable]
    public partial class ZJ_PROJECT : JdEntity
    {
        #region Model
		private string _REPROT_CODE;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _REGION_CODE;
		private string _INVEST_PROJECT_CODE;
		private string _LEGAL_PERSON;
		private string _LEGAL_REPRESENT;
		private string _LEGAL_CREDIT_CODE;
		private string _LEGAL_ADDRESS;
		private string _CONTACTOR;
		private string _CONTACT_INFORMATION;
		private string _APPROVAL_NAME;
		private string _APPROVAL_NUMBER;
		private string _APPROVAL_AUTHORITY;
		private string _PROJECT_SCALE;
		private decimal? _TOTLE_INVESTMENT;
		private decimal? _CONSTRUCTION_COST;
		private string _FUND_SOURCE;
		private decimal? _GOVERNMENT_INVEST_FINANCE;
		private decimal? _IS_STATE_FUND;
		private decimal? _NOT_STATE_FUND;
		private string _INVEST_CONTRACT_MODE;
		private string _DESIGN_CONTRACT_MODE;
		private string _CONSTRUCT_CONTRACT_MODE;
		private string _IMPORT_EQUIP_CONTRACT_MODE;
		private string _GENERAL_CONTRACT_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private string _IS_AGENT_CONSTRUCT;
		private string _REMARK;
		private string _PROJECT_APPROVAL_FILE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _INDUSTRIES_TYPE;
		private DateTime? _CREATE_TIME;
		private string _CONSTRUCT_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_ATT_PROJECT_APPROVAL_FILE;
		private string _ADDRESS;
		private string _CLASS_VER_CODE;
		private string _RELATE_CODE;
		private string _BUILDPLANNUM;
		private string _PROJECTPLANNUM;
		private string _PROPERTY_NUM;
		private string _FUNCTION_NUM;
		private decimal? _ISMAJOR;
		private string _CXXMINFO;
		private string _JZJNINFO;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _SUPERVISOR_CONTRACT_MODE;
		private string _OPERATION_NAME;

		/// <summary>
		/// 报建编号
		/// </summary>
		public string REPROT_CODE
		{
			get{ return _REPROT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REPROT_CODE, _REPROT_CODE, value);
				this._REPROT_CODE = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 项目所在行政区域代码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 投资项目统一代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get{ return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目法人（发包方）
		/// </summary>
		public string LEGAL_PERSON
		{
			get{ return _LEGAL_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON, _LEGAL_PERSON, value);
				this._LEGAL_PERSON = value;
			}
		}
		/// <summary>
		/// 法定代表人
		/// </summary>
		public string LEGAL_REPRESENT
		{
			get{ return _LEGAL_REPRESENT; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_REPRESENT, _LEGAL_REPRESENT, value);
				this._LEGAL_REPRESENT = value;
			}
		}
		/// <summary>
		/// 法人（发包方）社会统一信用代码
		/// </summary>
		public string LEGAL_CREDIT_CODE
		{
			get{ return _LEGAL_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CREDIT_CODE, _LEGAL_CREDIT_CODE, value);
				this._LEGAL_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 法人单位地址
		/// </summary>
		public string LEGAL_ADDRESS
		{
			get{ return _LEGAL_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_ADDRESS, _LEGAL_ADDRESS, value);
				this._LEGAL_ADDRESS = value;
			}
		}
		/// <summary>
		/// 联系人（项目负责人）
		/// </summary>
		public string CONTACTOR
		{
			get{ return _CONTACTOR; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTOR, _CONTACTOR, value);
				this._CONTACTOR = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT_INFORMATION
		{
			get{ return _CONTACT_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_INFORMATION, _CONTACT_INFORMATION, value);
				this._CONTACT_INFORMATION = value;
			}
		}
		/// <summary>
		/// 项目审批文件名称
		/// </summary>
		public string APPROVAL_NAME
		{
			get{ return _APPROVAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NAME, _APPROVAL_NAME, value);
				this._APPROVAL_NAME = value;
			}
		}
		/// <summary>
		/// 项目审批文号
		/// </summary>
		public string APPROVAL_NUMBER
		{
			get{ return _APPROVAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NUMBER, _APPROVAL_NUMBER, value);
				this._APPROVAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 项目审批单位
		/// </summary>
		public string APPROVAL_AUTHORITY
		{
			get{ return _APPROVAL_AUTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_AUTHORITY, _APPROVAL_AUTHORITY, value);
				this._APPROVAL_AUTHORITY = value;
			}
		}
		/// <summary>
		/// 项目规模/工程规模及内容
		/// </summary>
		public string PROJECT_SCALE
		{
			get{ return _PROJECT_SCALE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_SCALE, _PROJECT_SCALE, value);
				this._PROJECT_SCALE = value;
			}
		}
		/// <summary>
		/// 投资总额
		/// </summary>
		public decimal? TOTLE_INVESTMENT
		{
			get{ return _TOTLE_INVESTMENT; }
			set
			{
				this.OnPropertyValueChange(_.TOTLE_INVESTMENT, _TOTLE_INVESTMENT, value);
				this._TOTLE_INVESTMENT = value;
			}
		}
		/// <summary>
		/// 建安工程费
		/// </summary>
		public decimal? CONSTRUCTION_COST
		{
			get{ return _CONSTRUCTION_COST; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_COST, _CONSTRUCTION_COST, value);
				this._CONSTRUCTION_COST = value;
			}
		}
		/// <summary>
		/// 资金来源
		/// </summary>
		public string FUND_SOURCE
		{
			get{ return _FUND_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.FUND_SOURCE, _FUND_SOURCE, value);
				this._FUND_SOURCE = value;
			}
		}
		/// <summary>
		/// 财政资金
		/// </summary>
		public decimal? GOVERNMENT_INVEST_FINANCE
		{
			get{ return _GOVERNMENT_INVEST_FINANCE; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT_INVEST_FINANCE, _GOVERNMENT_INVEST_FINANCE, value);
				this._GOVERNMENT_INVEST_FINANCE = value;
			}
		}
		/// <summary>
		/// 自筹资金
		/// </summary>
		public decimal? IS_STATE_FUND
		{
			get{ return _IS_STATE_FUND; }
			set
			{
				this.OnPropertyValueChange(_.IS_STATE_FUND, _IS_STATE_FUND, value);
				this._IS_STATE_FUND = value;
			}
		}
		/// <summary>
		/// 其他资金
		/// </summary>
		public decimal? NOT_STATE_FUND
		{
			get{ return _NOT_STATE_FUND; }
			set
			{
				this.OnPropertyValueChange(_.NOT_STATE_FUND, _NOT_STATE_FUND, value);
				this._NOT_STATE_FUND = value;
			}
		}
		/// <summary>
		/// 勘察发包方式
		/// </summary>
		public string INVEST_CONTRACT_MODE
		{
			get{ return _INVEST_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_CONTRACT_MODE, _INVEST_CONTRACT_MODE, value);
				this._INVEST_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 设计发包方式
		/// </summary>
		public string DESIGN_CONTRACT_MODE
		{
			get{ return _DESIGN_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_CONTRACT_MODE, _DESIGN_CONTRACT_MODE, value);
				this._DESIGN_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 施工发包方式
		/// </summary>
		public string CONSTRUCT_CONTRACT_MODE
		{
			get{ return _CONSTRUCT_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_CONTRACT_MODE, _CONSTRUCT_CONTRACT_MODE, value);
				this._CONSTRUCT_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 重要设备和材料发包方式
		/// </summary>
		public string IMPORT_EQUIP_CONTRACT_MODE
		{
			get{ return _IMPORT_EQUIP_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.IMPORT_EQUIP_CONTRACT_MODE, _IMPORT_EQUIP_CONTRACT_MODE, value);
				this._IMPORT_EQUIP_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 工程总承包发包方式
		/// </summary>
		public string GENERAL_CONTRACT_MODE
		{
			get{ return _GENERAL_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.GENERAL_CONTRACT_MODE, _GENERAL_CONTRACT_MODE, value);
				this._GENERAL_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 招标组织形式
		/// </summary>
		public string TENDER_ORGANIZE_FORM
		{
			get{ return _TENDER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ORGANIZE_FORM, _TENDER_ORGANIZE_FORM, value);
				this._TENDER_ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 是否采用代建制
		/// </summary>
		public string IS_AGENT_CONSTRUCT
		{
			get{ return _IS_AGENT_CONSTRUCT; }
			set
			{
				this.OnPropertyValueChange(_.IS_AGENT_CONSTRUCT, _IS_AGENT_CONSTRUCT, value);
				this._IS_AGENT_CONSTRUCT = value;
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
		/// 立项批复文件（项目审批核准文件）
		/// </summary>
		public string PROJECT_APPROVAL_FILE
		{
			get{ return _PROJECT_APPROVAL_FILE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_APPROVAL_FILE, _PROJECT_APPROVAL_FILE, value);
				this._PROJECT_APPROVAL_FILE = value;
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
		/// 项目行业分类
		/// </summary>
		public string INDUSTRIES_TYPE
		{
			get{ return _INDUSTRIES_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRIES_TYPE, _INDUSTRIES_TYPE, value);
				this._INDUSTRIES_TYPE = value;
			}
		}
		/// <summary>
		/// 项目建立时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 报建编号
		/// </summary>
		public string CONSTRUCT_CODE
		{
			get{ return _CONSTRUCT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_CODE, _CONSTRUCT_CODE, value);
				this._CONSTRUCT_CODE = value;
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
		/// 附件立项批复文件（项目审批核准文件）
		/// </summary>
		public string M_ATT_PROJECT_APPROVAL_FILE
		{
			get{ return _M_ATT_PROJECT_APPROVAL_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROJECT_APPROVAL_FILE, _M_ATT_PROJECT_APPROVAL_FILE, value);
				this._M_ATT_PROJECT_APPROVAL_FILE = value;
			}
		}
		/// <summary>
		/// 项目地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 分类版本代码
		/// </summary>
		public string CLASS_VER_CODE
		{
			get{ return _CLASS_VER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CLASS_VER_CODE, _CLASS_VER_CODE, value);
				this._CLASS_VER_CODE = value;
			}
		}
		/// <summary>
		/// 项目类别关联代码
		/// </summary>
		public string RELATE_CODE
		{
			get{ return _RELATE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RELATE_CODE, _RELATE_CODE, value);
				this._RELATE_CODE = value;
			}
		}
		/// <summary>
		/// 建设用地规划许可证编号
		/// </summary>
		public string BUILDPLANNUM
		{
			get{ return _BUILDPLANNUM; }
			set
			{
				this.OnPropertyValueChange(_.BUILDPLANNUM, _BUILDPLANNUM, value);
				this._BUILDPLANNUM = value;
			}
		}
		/// <summary>
		/// 建设工程规划许可证编号
		/// </summary>
		public string PROJECTPLANNUM
		{
			get{ return _PROJECTPLANNUM; }
			set
			{
				this.OnPropertyValueChange(_.PROJECTPLANNUM, _PROJECTPLANNUM, value);
				this._PROJECTPLANNUM = value;
			}
		}
		/// <summary>
		/// 建设性质
		/// </summary>
		public string PROPERTY_NUM
		{
			get{ return _PROPERTY_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PROPERTY_NUM, _PROPERTY_NUM, value);
				this._PROPERTY_NUM = value;
			}
		}
		/// <summary>
		/// 工程用途
		/// </summary>
		public string FUNCTION_NUM
		{
			get{ return _FUNCTION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.FUNCTION_NUM, _FUNCTION_NUM, value);
				this._FUNCTION_NUM = value;
			}
		}
		/// <summary>
		/// 是否重点项目
		/// </summary>
		public decimal? ISMAJOR
		{
			get{ return _ISMAJOR; }
			set
			{
				this.OnPropertyValueChange(_.ISMAJOR, _ISMAJOR, value);
				this._ISMAJOR = value;
			}
		}
		/// <summary>
		/// 超限项目信息
		/// </summary>
		public string CXXMINFO
		{
			get{ return _CXXMINFO; }
			set
			{
				this.OnPropertyValueChange(_.CXXMINFO, _CXXMINFO, value);
				this._CXXMINFO = value;
			}
		}
		/// <summary>
		/// 建筑节能信息
		/// </summary>
		public string JZJNINFO
		{
			get{ return _JZJNINFO; }
			set
			{
				this.OnPropertyValueChange(_.JZJNINFO, _JZJNINFO, value);
				this._JZJNINFO = value;
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
		/// 监理发包方式
		/// </summary>
		public string SUPERVISOR_CONTRACT_MODE
		{
			get{ return _SUPERVISOR_CONTRACT_MODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_CONTRACT_MODE, _SUPERVISOR_CONTRACT_MODE, value);
				this._SUPERVISOR_CONTRACT_MODE = value;
			}
		}
		/// <summary>
		/// 信息录入人员
		/// </summary>
		public string OPERATION_NAME
		{
			get{ return _OPERATION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_NAME, _OPERATION_NAME, value);
				this._OPERATION_NAME = value;
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
				_.REPROT_CODE,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.REGION_CODE,
				_.INVEST_PROJECT_CODE,
				_.LEGAL_PERSON,
				_.LEGAL_REPRESENT,
				_.LEGAL_CREDIT_CODE,
				_.LEGAL_ADDRESS,
				_.CONTACTOR,
				_.CONTACT_INFORMATION,
				_.APPROVAL_NAME,
				_.APPROVAL_NUMBER,
				_.APPROVAL_AUTHORITY,
				_.PROJECT_SCALE,
				_.TOTLE_INVESTMENT,
				_.CONSTRUCTION_COST,
				_.FUND_SOURCE,
				_.GOVERNMENT_INVEST_FINANCE,
				_.IS_STATE_FUND,
				_.NOT_STATE_FUND,
				_.INVEST_CONTRACT_MODE,
				_.DESIGN_CONTRACT_MODE,
				_.CONSTRUCT_CONTRACT_MODE,
				_.IMPORT_EQUIP_CONTRACT_MODE,
				_.GENERAL_CONTRACT_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.IS_AGENT_CONSTRUCT,
				_.REMARK,
				_.PROJECT_APPROVAL_FILE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.INDUSTRIES_TYPE,
				_.CREATE_TIME,
				_.CONSTRUCT_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ATT_PROJECT_APPROVAL_FILE,
				_.ADDRESS,
				_.CLASS_VER_CODE,
				_.RELATE_CODE,
				_.BUILDPLANNUM,
				_.PROJECTPLANNUM,
				_.PROPERTY_NUM,
				_.FUNCTION_NUM,
				_.ISMAJOR,
				_.CXXMINFO,
				_.JZJNINFO,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.SUPERVISOR_CONTRACT_MODE,
				_.OPERATION_NAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._REPROT_CODE,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._REGION_CODE,
				this._INVEST_PROJECT_CODE,
				this._LEGAL_PERSON,
				this._LEGAL_REPRESENT,
				this._LEGAL_CREDIT_CODE,
				this._LEGAL_ADDRESS,
				this._CONTACTOR,
				this._CONTACT_INFORMATION,
				this._APPROVAL_NAME,
				this._APPROVAL_NUMBER,
				this._APPROVAL_AUTHORITY,
				this._PROJECT_SCALE,
				this._TOTLE_INVESTMENT,
				this._CONSTRUCTION_COST,
				this._FUND_SOURCE,
				this._GOVERNMENT_INVEST_FINANCE,
				this._IS_STATE_FUND,
				this._NOT_STATE_FUND,
				this._INVEST_CONTRACT_MODE,
				this._DESIGN_CONTRACT_MODE,
				this._CONSTRUCT_CONTRACT_MODE,
				this._IMPORT_EQUIP_CONTRACT_MODE,
				this._GENERAL_CONTRACT_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._IS_AGENT_CONSTRUCT,
				this._REMARK,
				this._PROJECT_APPROVAL_FILE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._INDUSTRIES_TYPE,
				this._CREATE_TIME,
				this._CONSTRUCT_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ATT_PROJECT_APPROVAL_FILE,
				this._ADDRESS,
				this._CLASS_VER_CODE,
				this._RELATE_CODE,
				this._BUILDPLANNUM,
				this._PROJECTPLANNUM,
				this._PROPERTY_NUM,
				this._FUNCTION_NUM,
				this._ISMAJOR,
				this._CXXMINFO,
				this._JZJNINFO,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._SUPERVISOR_CONTRACT_MODE,
				this._OPERATION_NAME,
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
			public readonly static Field All = new Field("*", "ZJ_PROJECT");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field REPROT_CODE = new Field("REPROT_CODE", "ZJ_PROJECT", "报建编号");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "ZJ_PROJECT", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "ZJ_PROJECT", "项目名称");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "ZJ_PROJECT", "项目所在行政区域代码");
            /// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "ZJ_PROJECT", "投资项目统一代码");
            /// <summary>
			/// 项目法人（发包方）
			/// </summary>
			public readonly static Field LEGAL_PERSON = new Field("LEGAL_PERSON", "ZJ_PROJECT", "项目法人（发包方）");
            /// <summary>
			/// 法定代表人
			/// </summary>
			public readonly static Field LEGAL_REPRESENT = new Field("LEGAL_REPRESENT", "ZJ_PROJECT", "法定代表人");
            /// <summary>
			/// 法人（发包方）社会统一信用代码
			/// </summary>
			public readonly static Field LEGAL_CREDIT_CODE = new Field("LEGAL_CREDIT_CODE", "ZJ_PROJECT", "法人（发包方）社会统一信用代码");
            /// <summary>
			/// 法人单位地址
			/// </summary>
			public readonly static Field LEGAL_ADDRESS = new Field("LEGAL_ADDRESS", "ZJ_PROJECT", "法人单位地址");
            /// <summary>
			/// 联系人（项目负责人）
			/// </summary>
			public readonly static Field CONTACTOR = new Field("CONTACTOR", "ZJ_PROJECT", "联系人（项目负责人）");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT_INFORMATION = new Field("CONTACT_INFORMATION", "ZJ_PROJECT", "联系电话");
            /// <summary>
			/// 项目审批文件名称
			/// </summary>
			public readonly static Field APPROVAL_NAME = new Field("APPROVAL_NAME", "ZJ_PROJECT", "项目审批文件名称");
            /// <summary>
			/// 项目审批文号
			/// </summary>
			public readonly static Field APPROVAL_NUMBER = new Field("APPROVAL_NUMBER", "ZJ_PROJECT", "项目审批文号");
            /// <summary>
			/// 项目审批单位
			/// </summary>
			public readonly static Field APPROVAL_AUTHORITY = new Field("APPROVAL_AUTHORITY", "ZJ_PROJECT", "项目审批单位");
            /// <summary>
			/// 项目规模/工程规模及内容
			/// </summary>
			public readonly static Field PROJECT_SCALE = new Field("PROJECT_SCALE", "ZJ_PROJECT", "项目规模/工程规模及内容");
            /// <summary>
			/// 投资总额
			/// </summary>
			public readonly static Field TOTLE_INVESTMENT = new Field("TOTLE_INVESTMENT", "ZJ_PROJECT", "投资总额");
            /// <summary>
			/// 建安工程费
			/// </summary>
			public readonly static Field CONSTRUCTION_COST = new Field("CONSTRUCTION_COST", "ZJ_PROJECT", "建安工程费");
            /// <summary>
			/// 资金来源
			/// </summary>
			public readonly static Field FUND_SOURCE = new Field("FUND_SOURCE", "ZJ_PROJECT", "资金来源");
            /// <summary>
			/// 财政资金
			/// </summary>
			public readonly static Field GOVERNMENT_INVEST_FINANCE = new Field("GOVERNMENT_INVEST_FINANCE", "ZJ_PROJECT", "财政资金");
            /// <summary>
			/// 自筹资金
			/// </summary>
			public readonly static Field IS_STATE_FUND = new Field("IS_STATE_FUND", "ZJ_PROJECT", "自筹资金");
            /// <summary>
			/// 其他资金
			/// </summary>
			public readonly static Field NOT_STATE_FUND = new Field("NOT_STATE_FUND", "ZJ_PROJECT", "其他资金");
            /// <summary>
			/// 勘察发包方式
			/// </summary>
			public readonly static Field INVEST_CONTRACT_MODE = new Field("INVEST_CONTRACT_MODE", "ZJ_PROJECT", "勘察发包方式");
            /// <summary>
			/// 设计发包方式
			/// </summary>
			public readonly static Field DESIGN_CONTRACT_MODE = new Field("DESIGN_CONTRACT_MODE", "ZJ_PROJECT", "设计发包方式");
            /// <summary>
			/// 施工发包方式
			/// </summary>
			public readonly static Field CONSTRUCT_CONTRACT_MODE = new Field("CONSTRUCT_CONTRACT_MODE", "ZJ_PROJECT", "施工发包方式");
            /// <summary>
			/// 重要设备和材料发包方式
			/// </summary>
			public readonly static Field IMPORT_EQUIP_CONTRACT_MODE = new Field("IMPORT_EQUIP_CONTRACT_MODE", "ZJ_PROJECT", "重要设备和材料发包方式");
            /// <summary>
			/// 工程总承包发包方式
			/// </summary>
			public readonly static Field GENERAL_CONTRACT_MODE = new Field("GENERAL_CONTRACT_MODE", "ZJ_PROJECT", "工程总承包发包方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "ZJ_PROJECT", "招标组织形式");
            /// <summary>
			/// 是否采用代建制
			/// </summary>
			public readonly static Field IS_AGENT_CONSTRUCT = new Field("IS_AGENT_CONSTRUCT", "ZJ_PROJECT", "是否采用代建制");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "ZJ_PROJECT",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 立项批复文件（项目审批核准文件）
			/// </summary>
			public readonly static Field PROJECT_APPROVAL_FILE = new Field("PROJECT_APPROVAL_FILE", "ZJ_PROJECT", "立项批复文件（项目审批核准文件）");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_PROJECT", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_PROJECT", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_PROJECT", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_PROJECT", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_PROJECT", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_PROJECT", "M_TM");
            /// <summary>
			/// 项目行业分类
			/// </summary>
			public readonly static Field INDUSTRIES_TYPE = new Field("INDUSTRIES_TYPE", "ZJ_PROJECT", "项目行业分类");
            /// <summary>
			/// 项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJ_PROJECT", "项目建立时间");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field CONSTRUCT_CODE = new Field("CONSTRUCT_CODE", "ZJ_PROJECT", "报建编号");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_PROJECT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_PROJECT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_PROJECT", "数据时间戳");
            /// <summary>
			/// 附件立项批复文件（项目审批核准文件）
			/// </summary>
			public readonly static Field M_ATT_PROJECT_APPROVAL_FILE = new Field("M_ATT_PROJECT_APPROVAL_FILE", "ZJ_PROJECT", "附件立项批复文件（项目审批核准文件）");
            /// <summary>
			/// 项目地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "ZJ_PROJECT", "项目地址");
            /// <summary>
			/// 分类版本代码
			/// </summary>
			public readonly static Field CLASS_VER_CODE = new Field("CLASS_VER_CODE", "ZJ_PROJECT", "分类版本代码");
            /// <summary>
			/// 项目类别关联代码
			/// </summary>
			public readonly static Field RELATE_CODE = new Field("RELATE_CODE", "ZJ_PROJECT", "项目类别关联代码");
            /// <summary>
			/// 建设用地规划许可证编号
			/// </summary>
			public readonly static Field BUILDPLANNUM = new Field("BUILDPLANNUM", "ZJ_PROJECT", "建设用地规划许可证编号");
            /// <summary>
			/// 建设工程规划许可证编号
			/// </summary>
			public readonly static Field PROJECTPLANNUM = new Field("PROJECTPLANNUM", "ZJ_PROJECT", "建设工程规划许可证编号");
            /// <summary>
			/// 建设性质
			/// </summary>
			public readonly static Field PROPERTY_NUM = new Field("PROPERTY_NUM", "ZJ_PROJECT", "建设性质");
            /// <summary>
			/// 工程用途
			/// </summary>
			public readonly static Field FUNCTION_NUM = new Field("FUNCTION_NUM", "ZJ_PROJECT", "工程用途");
            /// <summary>
			/// 是否重点项目
			/// </summary>
			public readonly static Field ISMAJOR = new Field("ISMAJOR", "ZJ_PROJECT", "是否重点项目");
            /// <summary>
			/// 超限项目信息
			/// </summary>
			public readonly static Field CXXMINFO = new Field("CXXMINFO", "ZJ_PROJECT", "超限项目信息");
            /// <summary>
			/// 建筑节能信息
			/// </summary>
			public readonly static Field JZJNINFO = new Field("JZJNINFO", "ZJ_PROJECT", "建筑节能信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_PROJECT", "");
            /// <summary>
			/// 监理发包方式
			/// </summary>
			public readonly static Field SUPERVISOR_CONTRACT_MODE = new Field("SUPERVISOR_CONTRACT_MODE", "ZJ_PROJECT", "监理发包方式");
            /// <summary>
			/// 信息录入人员
			/// </summary>
			public readonly static Field OPERATION_NAME = new Field("OPERATION_NAME", "ZJ_PROJECT", "信息录入人员");
        }
        #endregion
	}
}