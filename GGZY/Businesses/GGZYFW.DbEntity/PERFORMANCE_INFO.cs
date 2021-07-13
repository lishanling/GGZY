using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PERFORMANCE_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PERFORMANCE_INFO")]
    [Serializable]
    public partial class PERFORMANCE_INFO : FwEntity
    {
        #region Model
		private string _BODY_CODE;
		private string _BODY_NAME;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private decimal? _CONTRACT_AMOUNT;
		private string _CONTRACT_CURRENCY;
		private string _CONTRACT_CURRENCYUNIT;
		private decimal? _CONTRACT_PERIOD;
		private DateTime? _CONTRACT_SIGNING_TIME;
		private string _QUALITY_STANDARDS;
		private string _SAFETY_STANDARDS;
		private string _ENVIRONMENT_STANDARDS;
		private decimal? _CONSTRUCTION_PERIOD;
		private decimal? _CONTRACT_SETTLEMENT_AMOUNT;
		private DateTime? _CONTRACT_FINISH_TIME;
		private DateTime? _PERFORMANCE_SUBMITTED_TIME;
		private string _GOVERNMENT;
		private string _DOCUMENT_CODE;
		private decimal? _SCOPE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_PERFORMANCE_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string BODY_CODE
		{
			get{ return _BODY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_CODE, _BODY_CODE, value);
				this._BODY_CODE = value;
			}
		}
		/// <summary>
		/// 主体名称
		/// </summary>
		public string BODY_NAME
		{
			get{ return _BODY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BODY_NAME, _BODY_NAME, value);
				this._BODY_NAME = value;
			}
		}
		/// <summary>
		/// 主体类别
		/// </summary>
		public string BODY_TYPE
		{
			get{ return _BODY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_TYPE, _BODY_TYPE, value);
				this._BODY_TYPE = value;
			}
		}
		/// <summary>
		/// 主体角色
		/// </summary>
		public string BODY_ROLE
		{
			get{ return _BODY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_ROLE, _BODY_ROLE, value);
				this._BODY_ROLE = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）编号
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
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
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
		/// 合同金额
		/// </summary>
		public decimal? CONTRACT_AMOUNT
		{
			get{ return _CONTRACT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_AMOUNT, _CONTRACT_AMOUNT, value);
				this._CONTRACT_AMOUNT = value;
			}
		}
		/// <summary>
		/// 合同金额币种
		/// </summary>
		public string CONTRACT_CURRENCY
		{
			get{ return _CONTRACT_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CURRENCY, _CONTRACT_CURRENCY, value);
				this._CONTRACT_CURRENCY = value;
			}
		}
		/// <summary>
		/// 合同金额单位
		/// </summary>
		public string CONTRACT_CURRENCYUNIT
		{
			get{ return _CONTRACT_CURRENCYUNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CURRENCYUNIT, _CONTRACT_CURRENCYUNIT, value);
				this._CONTRACT_CURRENCYUNIT = value;
			}
		}
		/// <summary>
		/// 合同工期
		/// </summary>
		public decimal? CONTRACT_PERIOD
		{
			get{ return _CONTRACT_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PERIOD, _CONTRACT_PERIOD, value);
				this._CONTRACT_PERIOD = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public DateTime? CONTRACT_SIGNING_TIME
		{
			get{ return _CONTRACT_SIGNING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SIGNING_TIME, _CONTRACT_SIGNING_TIME, value);
				this._CONTRACT_SIGNING_TIME = value;
			}
		}
		/// <summary>
		/// 质量达标状况
		/// </summary>
		public string QUALITY_STANDARDS
		{
			get{ return _QUALITY_STANDARDS; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_STANDARDS, _QUALITY_STANDARDS, value);
				this._QUALITY_STANDARDS = value;
			}
		}
		/// <summary>
		/// 安全达标状况
		/// </summary>
		public string SAFETY_STANDARDS
		{
			get{ return _SAFETY_STANDARDS; }
			set
			{
				this.OnPropertyValueChange(_.SAFETY_STANDARDS, _SAFETY_STANDARDS, value);
				this._SAFETY_STANDARDS = value;
			}
		}
		/// <summary>
		/// 环保达标状况
		/// </summary>
		public string ENVIRONMENT_STANDARDS
		{
			get{ return _ENVIRONMENT_STANDARDS; }
			set
			{
				this.OnPropertyValueChange(_.ENVIRONMENT_STANDARDS, _ENVIRONMENT_STANDARDS, value);
				this._ENVIRONMENT_STANDARDS = value;
			}
		}
		/// <summary>
		/// 工期（天）
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
		/// 合同结算金额（元）
		/// </summary>
		public decimal? CONTRACT_SETTLEMENT_AMOUNT
		{
			get{ return _CONTRACT_SETTLEMENT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SETTLEMENT_AMOUNT, _CONTRACT_SETTLEMENT_AMOUNT, value);
				this._CONTRACT_SETTLEMENT_AMOUNT = value;
			}
		}
		/// <summary>
		/// 合同完成时间
		/// </summary>
		public DateTime? CONTRACT_FINISH_TIME
		{
			get{ return _CONTRACT_FINISH_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_FINISH_TIME, _CONTRACT_FINISH_TIME, value);
				this._CONTRACT_FINISH_TIME = value;
			}
		}
		/// <summary>
		/// 履约信息递交时间
		/// </summary>
		public DateTime? PERFORMANCE_SUBMITTED_TIME
		{
			get{ return _PERFORMANCE_SUBMITTED_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_SUBMITTED_TIME, _PERFORMANCE_SUBMITTED_TIME, value);
				this._PERFORMANCE_SUBMITTED_TIME = value;
			}
		}
		/// <summary>
		/// 发布部门
		/// </summary>
		public string GOVERNMENT
		{
			get{ return _GOVERNMENT; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT, _GOVERNMENT, value);
				this._GOVERNMENT = value;
			}
		}
		/// <summary>
		/// 处理文件文号
		/// </summary>
		public string DOCUMENT_CODE
		{
			get{ return _DOCUMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CODE, _DOCUMENT_CODE, value);
				this._DOCUMENT_CODE = value;
			}
		}
		/// <summary>
		/// 公开范围
		/// </summary>
		public decimal? SCOPE
		{
			get{ return _SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE, _SCOPE, value);
				this._SCOPE = value;
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
		/// 
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
		/// 履约信息相关文件扫描件
		/// </summary>
		public string M_ATT_PERFORMANCE_DOC
		{
			get{ return _M_ATT_PERFORMANCE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PERFORMANCE_DOC, _M_ATT_PERFORMANCE_DOC, value);
				this._M_ATT_PERFORMANCE_DOC = value;
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
				_.BODY_CODE,
				_.BODY_NAME,
				_.BODY_TYPE,
				_.BODY_ROLE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.CONTRACT_AMOUNT,
				_.CONTRACT_CURRENCY,
				_.CONTRACT_CURRENCYUNIT,
				_.CONTRACT_PERIOD,
				_.CONTRACT_SIGNING_TIME,
				_.QUALITY_STANDARDS,
				_.SAFETY_STANDARDS,
				_.ENVIRONMENT_STANDARDS,
				_.CONSTRUCTION_PERIOD,
				_.CONTRACT_SETTLEMENT_AMOUNT,
				_.CONTRACT_FINISH_TIME,
				_.PERFORMANCE_SUBMITTED_TIME,
				_.GOVERNMENT,
				_.DOCUMENT_CODE,
				_.SCOPE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_PERFORMANCE_DOC,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BODY_CODE,
				this._BODY_NAME,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._CONTRACT_AMOUNT,
				this._CONTRACT_CURRENCY,
				this._CONTRACT_CURRENCYUNIT,
				this._CONTRACT_PERIOD,
				this._CONTRACT_SIGNING_TIME,
				this._QUALITY_STANDARDS,
				this._SAFETY_STANDARDS,
				this._ENVIRONMENT_STANDARDS,
				this._CONSTRUCTION_PERIOD,
				this._CONTRACT_SETTLEMENT_AMOUNT,
				this._CONTRACT_FINISH_TIME,
				this._PERFORMANCE_SUBMITTED_TIME,
				this._GOVERNMENT,
				this._DOCUMENT_CODE,
				this._SCOPE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_PERFORMANCE_DOC,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "PERFORMANCE_INFO");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "PERFORMANCE_INFO", "主体代码");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "PERFORMANCE_INFO", "主体名称");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "PERFORMANCE_INFO", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "PERFORMANCE_INFO", "主体角色");
            /// <summary>
			/// 招标项目（采购项目）名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "PERFORMANCE_INFO", "招标项目（采购项目）名称");
            /// <summary>
			/// 招标项目（采购项目）编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "PERFORMANCE_INFO", "招标项目（采购项目）编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "PERFORMANCE_INFO", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "PERFORMANCE_INFO", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "PERFORMANCE_INFO", "统一交易标识码");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT = new Field("CONTRACT_AMOUNT", "PERFORMANCE_INFO", "合同金额");
            /// <summary>
			/// 合同金额币种
			/// </summary>
			public readonly static Field CONTRACT_CURRENCY = new Field("CONTRACT_CURRENCY", "PERFORMANCE_INFO", "合同金额币种");
            /// <summary>
			/// 合同金额单位
			/// </summary>
			public readonly static Field CONTRACT_CURRENCYUNIT = new Field("CONTRACT_CURRENCYUNIT", "PERFORMANCE_INFO", "合同金额单位");
            /// <summary>
			/// 合同工期
			/// </summary>
			public readonly static Field CONTRACT_PERIOD = new Field("CONTRACT_PERIOD", "PERFORMANCE_INFO", "合同工期");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACT_SIGNING_TIME = new Field("CONTRACT_SIGNING_TIME", "PERFORMANCE_INFO", "合同签署时间");
            /// <summary>
			/// 质量达标状况
			/// </summary>
			public readonly static Field QUALITY_STANDARDS = new Field("QUALITY_STANDARDS", "PERFORMANCE_INFO", "质量达标状况");
            /// <summary>
			/// 安全达标状况
			/// </summary>
			public readonly static Field SAFETY_STANDARDS = new Field("SAFETY_STANDARDS", "PERFORMANCE_INFO", "安全达标状况");
            /// <summary>
			/// 环保达标状况
			/// </summary>
			public readonly static Field ENVIRONMENT_STANDARDS = new Field("ENVIRONMENT_STANDARDS", "PERFORMANCE_INFO", "环保达标状况");
            /// <summary>
			/// 工期（天）
			/// </summary>
			public readonly static Field CONSTRUCTION_PERIOD = new Field("CONSTRUCTION_PERIOD", "PERFORMANCE_INFO", "工期（天）");
            /// <summary>
			/// 合同结算金额（元）
			/// </summary>
			public readonly static Field CONTRACT_SETTLEMENT_AMOUNT = new Field("CONTRACT_SETTLEMENT_AMOUNT", "PERFORMANCE_INFO", "合同结算金额（元）");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field CONTRACT_FINISH_TIME = new Field("CONTRACT_FINISH_TIME", "PERFORMANCE_INFO", "合同完成时间");
            /// <summary>
			/// 履约信息递交时间
			/// </summary>
			public readonly static Field PERFORMANCE_SUBMITTED_TIME = new Field("PERFORMANCE_SUBMITTED_TIME", "PERFORMANCE_INFO", "履约信息递交时间");
            /// <summary>
			/// 发布部门
			/// </summary>
			public readonly static Field GOVERNMENT = new Field("GOVERNMENT", "PERFORMANCE_INFO", "发布部门");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_CODE = new Field("DOCUMENT_CODE", "PERFORMANCE_INFO", "处理文件文号");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "PERFORMANCE_INFO", "公开范围");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "PERFORMANCE_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "PERFORMANCE_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PERFORMANCE_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 履约信息相关文件扫描件
			/// </summary>
			public readonly static Field M_ATT_PERFORMANCE_DOC = new Field("M_ATT_PERFORMANCE_DOC", "PERFORMANCE_INFO", "履约信息相关文件扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "PERFORMANCE_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "PERFORMANCE_INFO", "");
        }
        #endregion
	}
}