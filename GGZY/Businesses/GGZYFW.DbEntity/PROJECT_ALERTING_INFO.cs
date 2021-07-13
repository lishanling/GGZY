using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PROJECT_ALERTING_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PROJECT_ALERTING_INFO")]
    [Serializable]
    public partial class PROJECT_ALERTING_INFO : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _PROJECT_TYPE;
		private string _TRADE_TYPE;
		private string _BODY_NAME;
		private string _BODY_CODE;
		private string _SUPERVISOR_UNIT_NAME;
		private string _SUPERVISOR_UNIT_CODE;
		private string _SUPERVISORY_NODE;
		private string _ALERT_LEVEL;
		private DateTime? _ALERT_DATE;
		private string _ALERT_INFO;
		private string _HANDLED;
		private string _HANDLE_RESULT;
		private DateTime? _PULISH_DATE;
		private string _CONFINED_ACTION;
		private DateTime? _START_DATE;
		private DateTime? _END_DATE;
		private string _OPERATOR;
		private string _ENTER_CREDIT_PLAT;
		private string _SIGNATURE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

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
		/// 项目类型
		/// </summary>
		public string PROJECT_TYPE
		{
			get{ return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 交易方式
		/// </summary>
		public string TRADE_TYPE
		{
			get{ return _TRADE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_TYPE, _TRADE_TYPE, value);
				this._TRADE_TYPE = value;
			}
		}
		/// <summary>
		/// 责任主体名称
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
		/// 责任主体代码
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
		/// 监管单位名称
		/// </summary>
		public string SUPERVISOR_UNIT_NAME
		{
			get{ return _SUPERVISOR_UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_UNIT_NAME, _SUPERVISOR_UNIT_NAME, value);
				this._SUPERVISOR_UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 监管单位代码
		/// </summary>
		public string SUPERVISOR_UNIT_CODE
		{
			get{ return _SUPERVISOR_UNIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISOR_UNIT_CODE, _SUPERVISOR_UNIT_CODE, value);
				this._SUPERVISOR_UNIT_CODE = value;
			}
		}
		/// <summary>
		/// 监督节点描述
		/// </summary>
		public string SUPERVISORY_NODE
		{
			get{ return _SUPERVISORY_NODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISORY_NODE, _SUPERVISORY_NODE, value);
				this._SUPERVISORY_NODE = value;
			}
		}
		/// <summary>
		/// 报警等级
		/// </summary>
		public string ALERT_LEVEL
		{
			get{ return _ALERT_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.ALERT_LEVEL, _ALERT_LEVEL, value);
				this._ALERT_LEVEL = value;
			}
		}
		/// <summary>
		/// 报警时间
		/// </summary>
		public DateTime? ALERT_DATE
		{
			get{ return _ALERT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.ALERT_DATE, _ALERT_DATE, value);
				this._ALERT_DATE = value;
			}
		}
		/// <summary>
		/// 报警信息
		/// </summary>
		public string ALERT_INFO
		{
			get{ return _ALERT_INFO; }
			set
			{
				this.OnPropertyValueChange(_.ALERT_INFO, _ALERT_INFO, value);
				this._ALERT_INFO = value;
			}
		}
		/// <summary>
		/// 是否已处理
		/// </summary>
		public string HANDLED
		{
			get{ return _HANDLED; }
			set
			{
				this.OnPropertyValueChange(_.HANDLED, _HANDLED, value);
				this._HANDLED = value;
			}
		}
		/// <summary>
		/// 处理结果
		/// </summary>
		public string HANDLE_RESULT
		{
			get{ return _HANDLE_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_RESULT, _HANDLE_RESULT, value);
				this._HANDLE_RESULT = value;
			}
		}
		/// <summary>
		/// 发布日期
		/// </summary>
		public DateTime? PULISH_DATE
		{
			get{ return _PULISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PULISH_DATE, _PULISH_DATE, value);
				this._PULISH_DATE = value;
			}
		}
		/// <summary>
		/// 限制的行为
		/// </summary>
		public string CONFINED_ACTION
		{
			get{ return _CONFINED_ACTION; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_ACTION, _CONFINED_ACTION, value);
				this._CONFINED_ACTION = value;
			}
		}
		/// <summary>
		/// 限制行为开始时间
		/// </summary>
		public DateTime? START_DATE
		{
			get{ return _START_DATE; }
			set
			{
				this.OnPropertyValueChange(_.START_DATE, _START_DATE, value);
				this._START_DATE = value;
			}
		}
		/// <summary>
		/// 限制行为结束时间
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
		/// 处理人
		/// </summary>
		public string OPERATOR
		{
			get{ return _OPERATOR; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR, _OPERATOR, value);
				this._OPERATOR = value;
			}
		}
		/// <summary>
		/// 处理结果是否进入信用平台
		/// </summary>
		public string ENTER_CREDIT_PLAT
		{
			get{ return _ENTER_CREDIT_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.ENTER_CREDIT_PLAT, _ENTER_CREDIT_PLAT, value);
				this._ENTER_CREDIT_PLAT = value;
			}
		}
		/// <summary>
		/// 处理人电子签名
		/// </summary>
		public string SIGNATURE
		{
			get{ return _SIGNATURE; }
			set
			{
				this.OnPropertyValueChange(_.SIGNATURE, _SIGNATURE, value);
				this._SIGNATURE = value;
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
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.PROJECT_TYPE,
				_.TRADE_TYPE,
				_.BODY_NAME,
				_.BODY_CODE,
				_.SUPERVISOR_UNIT_NAME,
				_.SUPERVISOR_UNIT_CODE,
				_.SUPERVISORY_NODE,
				_.ALERT_LEVEL,
				_.ALERT_DATE,
				_.ALERT_INFO,
				_.HANDLED,
				_.HANDLE_RESULT,
				_.PULISH_DATE,
				_.CONFINED_ACTION,
				_.START_DATE,
				_.END_DATE,
				_.OPERATOR,
				_.ENTER_CREDIT_PLAT,
				_.SIGNATURE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
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
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._PROJECT_TYPE,
				this._TRADE_TYPE,
				this._BODY_NAME,
				this._BODY_CODE,
				this._SUPERVISOR_UNIT_NAME,
				this._SUPERVISOR_UNIT_CODE,
				this._SUPERVISORY_NODE,
				this._ALERT_LEVEL,
				this._ALERT_DATE,
				this._ALERT_INFO,
				this._HANDLED,
				this._HANDLE_RESULT,
				this._PULISH_DATE,
				this._CONFINED_ACTION,
				this._START_DATE,
				this._END_DATE,
				this._OPERATOR,
				this._ENTER_CREDIT_PLAT,
				this._SIGNATURE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "PROJECT_ALERTING_INFO");
            /// <summary>
			/// 招标项目（采购项目）名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "PROJECT_ALERTING_INFO", "招标项目（采购项目）名称");
            /// <summary>
			/// 招标项目（采购项目）编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "PROJECT_ALERTING_INFO", "招标项目（采购项目）编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "PROJECT_ALERTING_INFO", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "PROJECT_ALERTING_INFO", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "PROJECT_ALERTING_INFO", "统一交易标识码");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "PROJECT_ALERTING_INFO", "项目类型");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field TRADE_TYPE = new Field("TRADE_TYPE", "PROJECT_ALERTING_INFO", "交易方式");
            /// <summary>
			/// 责任主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "PROJECT_ALERTING_INFO", "责任主体名称");
            /// <summary>
			/// 责任主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "PROJECT_ALERTING_INFO", "责任主体代码");
            /// <summary>
			/// 监管单位名称
			/// </summary>
			public readonly static Field SUPERVISOR_UNIT_NAME = new Field("SUPERVISOR_UNIT_NAME", "PROJECT_ALERTING_INFO", "监管单位名称");
            /// <summary>
			/// 监管单位代码
			/// </summary>
			public readonly static Field SUPERVISOR_UNIT_CODE = new Field("SUPERVISOR_UNIT_CODE", "PROJECT_ALERTING_INFO", "监管单位代码");
            /// <summary>
			/// 监督节点描述
			/// </summary>
			public readonly static Field SUPERVISORY_NODE = new Field("SUPERVISORY_NODE", "PROJECT_ALERTING_INFO", "监督节点描述");
            /// <summary>
			/// 报警等级
			/// </summary>
			public readonly static Field ALERT_LEVEL = new Field("ALERT_LEVEL", "PROJECT_ALERTING_INFO", "报警等级");
            /// <summary>
			/// 报警时间
			/// </summary>
			public readonly static Field ALERT_DATE = new Field("ALERT_DATE", "PROJECT_ALERTING_INFO", "报警时间");
            /// <summary>
			/// 报警信息
			/// </summary>
			public readonly static Field ALERT_INFO = new Field("ALERT_INFO", "PROJECT_ALERTING_INFO", "报警信息");
            /// <summary>
			/// 是否已处理
			/// </summary>
			public readonly static Field HANDLED = new Field("HANDLED", "PROJECT_ALERTING_INFO", "是否已处理");
            /// <summary>
			/// 处理结果
			/// </summary>
			public readonly static Field HANDLE_RESULT = new Field("HANDLE_RESULT", "PROJECT_ALERTING_INFO",DbType.AnsiString, null, "处理结果");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field PULISH_DATE = new Field("PULISH_DATE", "PROJECT_ALERTING_INFO", "发布日期");
            /// <summary>
			/// 限制的行为
			/// </summary>
			public readonly static Field CONFINED_ACTION = new Field("CONFINED_ACTION", "PROJECT_ALERTING_INFO", "限制的行为");
            /// <summary>
			/// 限制行为开始时间
			/// </summary>
			public readonly static Field START_DATE = new Field("START_DATE", "PROJECT_ALERTING_INFO", "限制行为开始时间");
            /// <summary>
			/// 限制行为结束时间
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "PROJECT_ALERTING_INFO", "限制行为结束时间");
            /// <summary>
			/// 处理人
			/// </summary>
			public readonly static Field OPERATOR = new Field("OPERATOR", "PROJECT_ALERTING_INFO", "处理人");
            /// <summary>
			/// 处理结果是否进入信用平台
			/// </summary>
			public readonly static Field ENTER_CREDIT_PLAT = new Field("ENTER_CREDIT_PLAT", "PROJECT_ALERTING_INFO", "处理结果是否进入信用平台");
            /// <summary>
			/// 处理人电子签名
			/// </summary>
			public readonly static Field SIGNATURE = new Field("SIGNATURE", "PROJECT_ALERTING_INFO",DbType.AnsiString, null, "处理人电子签名");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "PROJECT_ALERTING_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "PROJECT_ALERTING_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PROJECT_ALERTING_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "PROJECT_ALERTING_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "PROJECT_ALERTING_INFO", "");
        }
        #endregion
	}
}