using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PURCHASE_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PURCHASE_PROJECT")]
    [Serializable]
    public partial class PURCHASE_PROJECT : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _PURCHASE_PROJECT_NAME;
		private string _INVEST_PROJECT_CODE;
		private string _TENDER_PROJECT_TYPE;
		private string _PURCHASER_NAME;
		private string _PURCHASER_CODE;
		private string _PURCHASER_ROLE;
		private decimal? _PROGRAM_BUDGET;
		private string _BUDGET_CURRENCY;
		private string _UNIT_BUDGET;
		private decimal? _IS_PROJECT;
		private string _PURCHASER_MODE;
		private string _PURCHASER_CONTENT;
		private decimal? _PURCHASER_ORGANIZE_FORM;
		private string _PURCHASER_AGENCY_NAME;
		private string _PURCHASER_AGENCY_CODE;
		private string _PURCHASER_AGENCY_ROLE;
		private string _PURCHASER_AGENCY_CONNECTOR;
		private string _PURCHASER_AGENCY_INFORMATION;
		private string _PURCHASE_SECTION_CODE;
		private string _PURCHASE_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private DateTime? _CREATE_TIME;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REGION_CODE;
		private string _RELATE_CODE;
		private string _PRICE_FORM_CODE;
		private string _OTHER_PROGRAM_BUDGET;
		private string _TRA_PLACE_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 采购项目编号
		/// </summary>
		public string PURCHASE_PROJECT_CODE
		{
			get{ return _PURCHASE_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_CODE, _PURCHASE_PROJECT_CODE, value);
				this._PURCHASE_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 采购项目名称
		/// </summary>
		public string PURCHASE_PROJECT_NAME
		{
			get{ return _PURCHASE_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_NAME, _PURCHASE_PROJECT_NAME, value);
				this._PURCHASE_PROJECT_NAME = value;
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
		/// 采购项目类型
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get{ return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 采购人名称
		/// </summary>
		public string PURCHASER_NAME
		{
			get{ return _PURCHASER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_NAME, _PURCHASER_NAME, value);
				this._PURCHASER_NAME = value;
			}
		}
		/// <summary>
		/// 采购人代码
		/// </summary>
		public string PURCHASER_CODE
		{
			get{ return _PURCHASER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_CODE, _PURCHASER_CODE, value);
				this._PURCHASER_CODE = value;
			}
		}
		/// <summary>
		/// 采购人角色
		/// </summary>
		public string PURCHASER_ROLE
		{
			get{ return _PURCHASER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_ROLE, _PURCHASER_ROLE, value);
				this._PURCHASER_ROLE = value;
			}
		}
		/// <summary>
		/// 项目预算
		/// </summary>
		public decimal? PROGRAM_BUDGET
		{
			get{ return _PROGRAM_BUDGET; }
			set
			{
				this.OnPropertyValueChange(_.PROGRAM_BUDGET, _PROGRAM_BUDGET, value);
				this._PROGRAM_BUDGET = value;
			}
		}
		/// <summary>
		/// 预算金额币种
		/// </summary>
		public string BUDGET_CURRENCY
		{
			get{ return _BUDGET_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.BUDGET_CURRENCY, _BUDGET_CURRENCY, value);
				this._BUDGET_CURRENCY = value;
			}
		}
		/// <summary>
		/// 预算金额单位
		/// </summary>
		public string UNIT_BUDGET
		{
			get{ return _UNIT_BUDGET; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_BUDGET, _UNIT_BUDGET, value);
				this._UNIT_BUDGET = value;
			}
		}
		/// <summary>
		/// 是否PPP项目
		/// </summary>
		public decimal? IS_PROJECT
		{
			get{ return _IS_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.IS_PROJECT, _IS_PROJECT, value);
				this._IS_PROJECT = value;
			}
		}
		/// <summary>
		/// 采购方式
		/// </summary>
		public string PURCHASER_MODE
		{
			get{ return _PURCHASER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_MODE, _PURCHASER_MODE, value);
				this._PURCHASER_MODE = value;
			}
		}
		/// <summary>
		/// 采购内容
		/// </summary>
		public string PURCHASER_CONTENT
		{
			get{ return _PURCHASER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_CONTENT, _PURCHASER_CONTENT, value);
				this._PURCHASER_CONTENT = value;
			}
		}
		/// <summary>
		/// 采购组织形式
		/// </summary>
		public decimal? PURCHASER_ORGANIZE_FORM
		{
			get{ return _PURCHASER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_ORGANIZE_FORM, _PURCHASER_ORGANIZE_FORM, value);
				this._PURCHASER_ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 采购代理机构名称
		/// </summary>
		public string PURCHASER_AGENCY_NAME
		{
			get{ return _PURCHASER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_NAME, _PURCHASER_AGENCY_NAME, value);
				this._PURCHASER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 采购代理机构代码
		/// </summary>
		public string PURCHASER_AGENCY_CODE
		{
			get{ return _PURCHASER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_CODE, _PURCHASER_AGENCY_CODE, value);
				this._PURCHASER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 采购代理机构角色
		/// </summary>
		public string PURCHASER_AGENCY_ROLE
		{
			get{ return _PURCHASER_AGENCY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_ROLE, _PURCHASER_AGENCY_ROLE, value);
				this._PURCHASER_AGENCY_ROLE = value;
			}
		}
		/// <summary>
		/// 采购代理机构联系人
		/// </summary>
		public string PURCHASER_AGENCY_CONNECTOR
		{
			get{ return _PURCHASER_AGENCY_CONNECTOR; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_CONNECTOR, _PURCHASER_AGENCY_CONNECTOR, value);
				this._PURCHASER_AGENCY_CONNECTOR = value;
			}
		}
		/// <summary>
		/// 采购代理机构联系电话
		/// </summary>
		public string PURCHASER_AGENCY_INFORMATION
		{
			get{ return _PURCHASER_AGENCY_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_INFORMATION, _PURCHASER_AGENCY_INFORMATION, value);
				this._PURCHASER_AGENCY_INFORMATION = value;
			}
		}
		/// <summary>
		/// 采购项目子包编号
		/// </summary>
		public string PURCHASE_SECTION_CODE
		{
			get{ return _PURCHASE_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_SECTION_CODE, _PURCHASE_SECTION_CODE, value);
				this._PURCHASE_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 采购项目子包名称
		/// </summary>
		public string PURCHASE_SECTION_NAME
		{
			get{ return _PURCHASE_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_SECTION_NAME, _PURCHASE_SECTION_NAME, value);
				this._PURCHASE_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 项目创建时间
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
		/// ID
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
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 采购项目所在地
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
		/// 价款形式代码
		/// </summary>
		public string PRICE_FORM_CODE
		{
			get{ return _PRICE_FORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_FORM_CODE, _PRICE_FORM_CODE, value);
				this._PRICE_FORM_CODE = value;
			}
		}
		/// <summary>
		/// 优惠率或其它类型项目预算
		/// </summary>
		public string OTHER_PROGRAM_BUDGET
		{
			get{ return _OTHER_PROGRAM_BUDGET; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_PROGRAM_BUDGET, _OTHER_PROGRAM_BUDGET, value);
				this._OTHER_PROGRAM_BUDGET = value;
			}
		}
		/// <summary>
		/// 交易发生行政区域代码
		/// </summary>
		public string TRA_PLACE_CODE
		{
			get{ return _TRA_PLACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_PLACE_CODE, _TRA_PLACE_CODE, value);
				this._TRA_PLACE_CODE = value;
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
				_.PURCHASE_PROJECT_CODE,
				_.PURCHASE_PROJECT_NAME,
				_.INVEST_PROJECT_CODE,
				_.TENDER_PROJECT_TYPE,
				_.PURCHASER_NAME,
				_.PURCHASER_CODE,
				_.PURCHASER_ROLE,
				_.PROGRAM_BUDGET,
				_.BUDGET_CURRENCY,
				_.UNIT_BUDGET,
				_.IS_PROJECT,
				_.PURCHASER_MODE,
				_.PURCHASER_CONTENT,
				_.PURCHASER_ORGANIZE_FORM,
				_.PURCHASER_AGENCY_NAME,
				_.PURCHASER_AGENCY_CODE,
				_.PURCHASER_AGENCY_ROLE,
				_.PURCHASER_AGENCY_CONNECTOR,
				_.PURCHASER_AGENCY_INFORMATION,
				_.PURCHASE_SECTION_CODE,
				_.PURCHASE_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CREATE_TIME,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REGION_CODE,
				_.RELATE_CODE,
				_.PRICE_FORM_CODE,
				_.OTHER_PROGRAM_BUDGET,
				_.TRA_PLACE_CODE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PURCHASE_PROJECT_CODE,
				this._PURCHASE_PROJECT_NAME,
				this._INVEST_PROJECT_CODE,
				this._TENDER_PROJECT_TYPE,
				this._PURCHASER_NAME,
				this._PURCHASER_CODE,
				this._PURCHASER_ROLE,
				this._PROGRAM_BUDGET,
				this._BUDGET_CURRENCY,
				this._UNIT_BUDGET,
				this._IS_PROJECT,
				this._PURCHASER_MODE,
				this._PURCHASER_CONTENT,
				this._PURCHASER_ORGANIZE_FORM,
				this._PURCHASER_AGENCY_NAME,
				this._PURCHASER_AGENCY_CODE,
				this._PURCHASER_AGENCY_ROLE,
				this._PURCHASER_AGENCY_CONNECTOR,
				this._PURCHASER_AGENCY_INFORMATION,
				this._PURCHASE_SECTION_CODE,
				this._PURCHASE_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CREATE_TIME,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REGION_CODE,
				this._RELATE_CODE,
				this._PRICE_FORM_CODE,
				this._OTHER_PROGRAM_BUDGET,
				this._TRA_PLACE_CODE,
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
			public readonly static Field All = new Field("*", "PURCHASE_PROJECT");
            /// <summary>
			/// 采购项目编号
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "PURCHASE_PROJECT", "采购项目编号");
            /// <summary>
			/// 采购项目名称
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_NAME = new Field("PURCHASE_PROJECT_NAME", "PURCHASE_PROJECT", "采购项目名称");
            /// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "PURCHASE_PROJECT", "投资项目统一代码");
            /// <summary>
			/// 采购项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "PURCHASE_PROJECT", "采购项目类型");
            /// <summary>
			/// 采购人名称
			/// </summary>
			public readonly static Field PURCHASER_NAME = new Field("PURCHASER_NAME", "PURCHASE_PROJECT", "采购人名称");
            /// <summary>
			/// 采购人代码
			/// </summary>
			public readonly static Field PURCHASER_CODE = new Field("PURCHASER_CODE", "PURCHASE_PROJECT", "采购人代码");
            /// <summary>
			/// 采购人角色
			/// </summary>
			public readonly static Field PURCHASER_ROLE = new Field("PURCHASER_ROLE", "PURCHASE_PROJECT", "采购人角色");
            /// <summary>
			/// 项目预算
			/// </summary>
			public readonly static Field PROGRAM_BUDGET = new Field("PROGRAM_BUDGET", "PURCHASE_PROJECT", "项目预算");
            /// <summary>
			/// 预算金额币种
			/// </summary>
			public readonly static Field BUDGET_CURRENCY = new Field("BUDGET_CURRENCY", "PURCHASE_PROJECT", "预算金额币种");
            /// <summary>
			/// 预算金额单位
			/// </summary>
			public readonly static Field UNIT_BUDGET = new Field("UNIT_BUDGET", "PURCHASE_PROJECT", "预算金额单位");
            /// <summary>
			/// 是否PPP项目
			/// </summary>
			public readonly static Field IS_PROJECT = new Field("IS_PROJECT", "PURCHASE_PROJECT", "是否PPP项目");
            /// <summary>
			/// 采购方式
			/// </summary>
			public readonly static Field PURCHASER_MODE = new Field("PURCHASER_MODE", "PURCHASE_PROJECT", "采购方式");
            /// <summary>
			/// 采购内容
			/// </summary>
			public readonly static Field PURCHASER_CONTENT = new Field("PURCHASER_CONTENT", "PURCHASE_PROJECT",DbType.AnsiString, null, "采购内容");
            /// <summary>
			/// 采购组织形式
			/// </summary>
			public readonly static Field PURCHASER_ORGANIZE_FORM = new Field("PURCHASER_ORGANIZE_FORM", "PURCHASE_PROJECT", "采购组织形式");
            /// <summary>
			/// 采购代理机构名称
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_NAME = new Field("PURCHASER_AGENCY_NAME", "PURCHASE_PROJECT", "采购代理机构名称");
            /// <summary>
			/// 采购代理机构代码
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_CODE = new Field("PURCHASER_AGENCY_CODE", "PURCHASE_PROJECT", "采购代理机构代码");
            /// <summary>
			/// 采购代理机构角色
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_ROLE = new Field("PURCHASER_AGENCY_ROLE", "PURCHASE_PROJECT", "采购代理机构角色");
            /// <summary>
			/// 采购代理机构联系人
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_CONNECTOR = new Field("PURCHASER_AGENCY_CONNECTOR", "PURCHASE_PROJECT", "采购代理机构联系人");
            /// <summary>
			/// 采购代理机构联系电话
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_INFORMATION = new Field("PURCHASER_AGENCY_INFORMATION", "PURCHASE_PROJECT", "采购代理机构联系电话");
            /// <summary>
			/// 采购项目子包编号
			/// </summary>
			public readonly static Field PURCHASE_SECTION_CODE = new Field("PURCHASE_SECTION_CODE", "PURCHASE_PROJECT", "采购项目子包编号");
            /// <summary>
			/// 采购项目子包名称
			/// </summary>
			public readonly static Field PURCHASE_SECTION_NAME = new Field("PURCHASE_SECTION_NAME", "PURCHASE_PROJECT", "采购项目子包名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "PURCHASE_PROJECT", "统一交易标识码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "PURCHASE_PROJECT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "PURCHASE_PROJECT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PURCHASE_PROJECT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 项目创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "PURCHASE_PROJECT", "项目创建时间");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "PURCHASE_PROJECT", "ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "PURCHASE_PROJECT", "");
            /// <summary>
			/// 采购项目所在地
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "PURCHASE_PROJECT", "采购项目所在地");
            /// <summary>
			/// 项目类别关联代码
			/// </summary>
			public readonly static Field RELATE_CODE = new Field("RELATE_CODE", "PURCHASE_PROJECT", "项目类别关联代码");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "PURCHASE_PROJECT", "价款形式代码");
            /// <summary>
			/// 优惠率或其它类型项目预算
			/// </summary>
			public readonly static Field OTHER_PROGRAM_BUDGET = new Field("OTHER_PROGRAM_BUDGET", "PURCHASE_PROJECT", "优惠率或其它类型项目预算");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "PURCHASE_PROJECT", "交易发生行政区域代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "PURCHASE_PROJECT", "");
        }
        #endregion
	}
}