using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类OTHER_ABNORMITY_REPORT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("OTHER_ABNORMITY_REPORT")]
    [Serializable]
    public partial class OTHER_ABNORMITY_REPORT : FwEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _EXCEPITON_INFOR;
		private decimal? _EXCEPITON_INDUSTRY;
		private string _APPROVAL_RESULT;
		private DateTime? _APPROVAL_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _EXCEPITON_NAME;
		private decimal? _M_ID;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private decimal? _EXCEPITON_TYPE;
		private string _M_VERSION;

		/// <summary>
		/// 招标项目编号
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
		/// 异常报告所属行业
		/// </summary>
		public decimal? EXCEPITON_INDUSTRY
		{
			get{ return _EXCEPITON_INDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.EXCEPITON_INDUSTRY, _EXCEPITON_INDUSTRY, value);
				this._EXCEPITON_INDUSTRY = value;
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
		/// 创建者
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
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
				_.PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.EXCEPITON_INFOR,
				_.EXCEPITON_INDUSTRY,
				_.APPROVAL_RESULT,
				_.APPROVAL_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.EXCEPITON_NAME,
				_.M_ID,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.EXCEPITON_TYPE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._EXCEPITON_INFOR,
				this._EXCEPITON_INDUSTRY,
				this._APPROVAL_RESULT,
				this._APPROVAL_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._EXCEPITON_NAME,
				this._M_ID,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._EXCEPITON_TYPE,
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
			public readonly static Field All = new Field("*", "OTHER_ABNORMITY_REPORT");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "OTHER_ABNORMITY_REPORT", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "OTHER_ABNORMITY_REPORT", "统一交易标识码");
            /// <summary>
			/// 异常情况描述
			/// </summary>
			public readonly static Field EXCEPITON_INFOR = new Field("EXCEPITON_INFOR", "OTHER_ABNORMITY_REPORT",DbType.AnsiString, null, "异常情况描述");
            /// <summary>
			/// 异常报告所属行业
			/// </summary>
			public readonly static Field EXCEPITON_INDUSTRY = new Field("EXCEPITON_INDUSTRY", "OTHER_ABNORMITY_REPORT", "异常报告所属行业");
            /// <summary>
			/// 审批或核准结果
			/// </summary>
			public readonly static Field APPROVAL_RESULT = new Field("APPROVAL_RESULT", "OTHER_ABNORMITY_REPORT",DbType.AnsiString, null, "审批或核准结果");
            /// <summary>
			/// 审批或核准时间
			/// </summary>
			public readonly static Field APPROVAL_TIME = new Field("APPROVAL_TIME", "OTHER_ABNORMITY_REPORT", "审批或核准时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "OTHER_ABNORMITY_REPORT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "OTHER_ABNORMITY_REPORT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "OTHER_ABNORMITY_REPORT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 报告名称
			/// </summary>
			public readonly static Field EXCEPITON_NAME = new Field("EXCEPITON_NAME", "OTHER_ABNORMITY_REPORT", "报告名称");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "OTHER_ABNORMITY_REPORT", "ID");
            /// <summary>
			/// 创建者
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "OTHER_ABNORMITY_REPORT", "创建者");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "OTHER_ABNORMITY_REPORT", "");
            /// <summary>
			/// 异常类型
			/// </summary>
			public readonly static Field EXCEPITON_TYPE = new Field("EXCEPITON_TYPE", "OTHER_ABNORMITY_REPORT", "异常类型");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "OTHER_ABNORMITY_REPORT", "");
        }
        #endregion
	}
}