using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类GY_TENDER_ABNORMITY_REPORT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GY_TENDER_ABNORMITY_REPORT")]
    [Serializable]
    public partial class GY_TENDER_ABNORMITY_REPORT : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _EXCEPITON_NAME;
		private string _EXCEPITON_INFOR;
		private string _APPROVAL_RESULT;
		private DateTime? _APPROVAL_TIME;
		private decimal? _EXCEPITON_TYPE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;

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
		/// 报告名称
		/// </summary>
		public string EXCEPITON_NAME
		{
			get{ return _EXCEPITON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXCEPITON_NAME, _EXCEPITON_NAME, value);
				this._EXCEPITON_NAME = value;
			}
		}
		/// <summary>
		/// 异常情况描述
		/// </summary>
		public string EXCEPITON_INFOR
		{
			get{ return _EXCEPITON_INFOR; }
			set
			{
				this.OnPropertyValueChange(_.EXCEPITON_INFOR, _EXCEPITON_INFOR, value);
				this._EXCEPITON_INFOR = value;
			}
		}
		/// <summary>
		/// 审批或核准结果
		/// </summary>
		public string APPROVAL_RESULT
		{
			get{ return _APPROVAL_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_RESULT, _APPROVAL_RESULT, value);
				this._APPROVAL_RESULT = value;
			}
		}
		/// <summary>
		/// 审批或核准时间
		/// </summary>
		public DateTime? APPROVAL_TIME
		{
			get{ return _APPROVAL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_TIME, _APPROVAL_TIME, value);
				this._APPROVAL_TIME = value;
			}
		}
		/// <summary>
		/// 异常类型
		/// </summary>
		public decimal? EXCEPITON_TYPE
		{
			get{ return _EXCEPITON_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXCEPITON_TYPE, _EXCEPITON_TYPE, value);
				this._EXCEPITON_TYPE = value;
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
		/// 交易服务系统标识码
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
		/// 交易平台或发布工具标识码
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
		/// 公共服务平台标识码
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
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.EXCEPITON_NAME,
				_.EXCEPITON_INFOR,
				_.APPROVAL_RESULT,
				_.APPROVAL_TIME,
				_.EXCEPITON_TYPE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._EXCEPITON_NAME,
				this._EXCEPITON_INFOR,
				this._APPROVAL_RESULT,
				this._APPROVAL_TIME,
				this._EXCEPITON_TYPE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "GY_TENDER_ABNORMITY_REPORT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "GY_TENDER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "GY_TENDER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "GY_TENDER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "GY_TENDER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "GY_TENDER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "GY_TENDER_ABNORMITY_REPORT", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "GY_TENDER_ABNORMITY_REPORT", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "GY_TENDER_ABNORMITY_REPORT", "统一交易标识码");
            /// <summary>
			/// 报告名称
			/// </summary>
			public readonly static Field EXCEPITON_NAME = new Field("EXCEPITON_NAME", "GY_TENDER_ABNORMITY_REPORT", "报告名称");
            /// <summary>
			/// 异常情况描述
			/// </summary>
			public readonly static Field EXCEPITON_INFOR = new Field("EXCEPITON_INFOR", "GY_TENDER_ABNORMITY_REPORT",DbType.AnsiString, null, "异常情况描述");
            /// <summary>
			/// 审批或核准结果
			/// </summary>
			public readonly static Field APPROVAL_RESULT = new Field("APPROVAL_RESULT", "GY_TENDER_ABNORMITY_REPORT",DbType.AnsiString, null, "审批或核准结果");
            /// <summary>
			/// 审批或核准时间
			/// </summary>
			public readonly static Field APPROVAL_TIME = new Field("APPROVAL_TIME", "GY_TENDER_ABNORMITY_REPORT", "审批或核准时间");
            /// <summary>
			/// 异常类型
			/// </summary>
			public readonly static Field EXCEPITON_TYPE = new Field("EXCEPITON_TYPE", "GY_TENDER_ABNORMITY_REPORT", "异常类型");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "GY_TENDER_ABNORMITY_REPORT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "GY_TENDER_ABNORMITY_REPORT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "GY_TENDER_ABNORMITY_REPORT", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "GY_TENDER_ABNORMITY_REPORT", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "GY_TENDER_ABNORMITY_REPORT", "公共服务平台标识码");
        }
        #endregion
	}
}