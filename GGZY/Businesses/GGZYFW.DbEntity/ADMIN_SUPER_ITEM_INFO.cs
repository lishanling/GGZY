using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ADMIN_SUPER_ITEM_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ADMIN_SUPER_ITEM_INFO")]
    [Serializable]
    public partial class ADMIN_SUPER_ITEM_INFO : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _PROJECT_TYPE;
		private string _TRADE_TYPE;
		private string _TRADE_STEP;
		private string _APPROVAL_PROJECT;
		private string _GOVERMENT;
		private string _AREA;
		private string _LAW;
		private string _IS_PAST;
		private string _CONTENT;
		private string _SIGNATURE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private DateTime? _APPROVAL_DATE;
		private decimal? _M_ID;
		private string _M_ATT_REGULATIONS_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 项目名称
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
		/// 项目编号
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
		/// 交易环节
		/// </summary>
		public string TRADE_STEP
		{
			get{ return _TRADE_STEP; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_STEP, _TRADE_STEP, value);
				this._TRADE_STEP = value;
			}
		}
		/// <summary>
		/// 监管事项
		/// </summary>
		public string APPROVAL_PROJECT
		{
			get{ return _APPROVAL_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_PROJECT, _APPROVAL_PROJECT, value);
				this._APPROVAL_PROJECT = value;
			}
		}
		/// <summary>
		/// 监管单位
		/// </summary>
		public string GOVERMENT
		{
			get{ return _GOVERMENT; }
			set
			{
				this.OnPropertyValueChange(_.GOVERMENT, _GOVERMENT, value);
				this._GOVERMENT = value;
			}
		}
		/// <summary>
		/// 行政区域
		/// </summary>
		public string AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 法律法规政策依据
		/// </summary>
		public string LAW
		{
			get{ return _LAW; }
			set
			{
				this.OnPropertyValueChange(_.LAW, _LAW, value);
				this._LAW = value;
			}
		}
		/// <summary>
		/// 是否通过
		/// </summary>
		public string IS_PAST
		{
			get{ return _IS_PAST; }
			set
			{
				this.OnPropertyValueChange(_.IS_PAST, _IS_PAST, value);
				this._IS_PAST = value;
			}
		}
		/// <summary>
		/// 监管意见
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 审批人电子签名
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
		/// 监管时间
		/// </summary>
		public DateTime? APPROVAL_DATE
		{
			get{ return _APPROVAL_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_DATE, _APPROVAL_DATE, value);
				this._APPROVAL_DATE = value;
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
		/// 行业监管相关资料扫描件
		/// </summary>
		public string M_ATT_REGULATIONS_DOC
		{
			get{ return _M_ATT_REGULATIONS_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_REGULATIONS_DOC, _M_ATT_REGULATIONS_DOC, value);
				this._M_ATT_REGULATIONS_DOC = value;
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
				_.TRADE_STEP,
				_.APPROVAL_PROJECT,
				_.GOVERMENT,
				_.AREA,
				_.LAW,
				_.IS_PAST,
				_.CONTENT,
				_.SIGNATURE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.APPROVAL_DATE,
				_.M_ID,
				_.M_ATT_REGULATIONS_DOC,
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
				this._TRADE_STEP,
				this._APPROVAL_PROJECT,
				this._GOVERMENT,
				this._AREA,
				this._LAW,
				this._IS_PAST,
				this._CONTENT,
				this._SIGNATURE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._APPROVAL_DATE,
				this._M_ID,
				this._M_ATT_REGULATIONS_DOC,
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
			public readonly static Field All = new Field("*", "ADMIN_SUPER_ITEM_INFO");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "ADMIN_SUPER_ITEM_INFO", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ADMIN_SUPER_ITEM_INFO", "项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ADMIN_SUPER_ITEM_INFO", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "ADMIN_SUPER_ITEM_INFO", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ADMIN_SUPER_ITEM_INFO", "统一交易标识码");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "ADMIN_SUPER_ITEM_INFO", "项目类型");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field TRADE_TYPE = new Field("TRADE_TYPE", "ADMIN_SUPER_ITEM_INFO", "交易方式");
            /// <summary>
			/// 交易环节
			/// </summary>
			public readonly static Field TRADE_STEP = new Field("TRADE_STEP", "ADMIN_SUPER_ITEM_INFO",DbType.AnsiString, null, "交易环节");
            /// <summary>
			/// 监管事项
			/// </summary>
			public readonly static Field APPROVAL_PROJECT = new Field("APPROVAL_PROJECT", "ADMIN_SUPER_ITEM_INFO",DbType.AnsiString, null, "监管事项");
            /// <summary>
			/// 监管单位
			/// </summary>
			public readonly static Field GOVERMENT = new Field("GOVERMENT", "ADMIN_SUPER_ITEM_INFO", "监管单位");
            /// <summary>
			/// 行政区域
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ADMIN_SUPER_ITEM_INFO", "行政区域");
            /// <summary>
			/// 法律法规政策依据
			/// </summary>
			public readonly static Field LAW = new Field("LAW", "ADMIN_SUPER_ITEM_INFO",DbType.AnsiString, null, "法律法规政策依据");
            /// <summary>
			/// 是否通过
			/// </summary>
			public readonly static Field IS_PAST = new Field("IS_PAST", "ADMIN_SUPER_ITEM_INFO", "是否通过");
            /// <summary>
			/// 监管意见
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "ADMIN_SUPER_ITEM_INFO",DbType.AnsiString, null, "监管意见");
            /// <summary>
			/// 审批人电子签名
			/// </summary>
			public readonly static Field SIGNATURE = new Field("SIGNATURE", "ADMIN_SUPER_ITEM_INFO",DbType.AnsiString, null, "审批人电子签名");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ADMIN_SUPER_ITEM_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ADMIN_SUPER_ITEM_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ADMIN_SUPER_ITEM_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 监管时间
			/// </summary>
			public readonly static Field APPROVAL_DATE = new Field("APPROVAL_DATE", "ADMIN_SUPER_ITEM_INFO", "监管时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 行业监管相关资料扫描件
			/// </summary>
			public readonly static Field M_ATT_REGULATIONS_DOC = new Field("M_ATT_REGULATIONS_DOC", "ADMIN_SUPER_ITEM_INFO", "行业监管相关资料扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ADMIN_SUPER_ITEM_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ADMIN_SUPER_ITEM_INFO", "");
        }
        #endregion
	}
}