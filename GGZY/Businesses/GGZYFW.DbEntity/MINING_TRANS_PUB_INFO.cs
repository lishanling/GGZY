using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MINING_TRANS_PUB_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MINING_TRANS_PUB_INFO")]
    [Serializable]
    public partial class MINING_TRANS_PUB_INFO : FwEntity
    {
        #region Model
		private string _NA_APP_NAME;
		private DateTime? _PUBLISHING_TIME;
		private string _UNIFIED_DEAL_CODE;
		private string _NA_APPLY_PERSON;
		private string _APPLY_TYPE;
		private string _APPLY_CODE;
		private string _APPLY_ROLE;
		private decimal? _QT_DESIGN_SCOPE;
		private string _NA_SCOPE_UNIT;
		private string _NA_GOV_NAME;
		private decimal? _IN_BUY_KIND;
		private decimal? _IN_MINE_COME;
		private DateTime? _DT_RECIVE_DATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _URL;
		private decimal? _M_ID;
		private string _M_ATT_OTHER_MINING_PUBLIC_INFO;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

		/// <summary>
		/// 项目名称
		/// </summary>
		public string NA_APP_NAME
		{
			get{ return _NA_APP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_APP_NAME, _NA_APP_NAME, value);
				this._NA_APP_NAME = value;
			}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? PUBLISHING_TIME
		{
			get{ return _PUBLISHING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHING_TIME, _PUBLISHING_TIME, value);
				this._PUBLISHING_TIME = value;
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
		/// 申请人
		/// </summary>
		public string NA_APPLY_PERSON
		{
			get{ return _NA_APPLY_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.NA_APPLY_PERSON, _NA_APPLY_PERSON, value);
				this._NA_APPLY_PERSON = value;
			}
		}
		/// <summary>
		/// 申请人类别
		/// </summary>
		public string APPLY_TYPE
		{
			get{ return _APPLY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_TYPE, _APPLY_TYPE, value);
				this._APPLY_TYPE = value;
			}
		}
		/// <summary>
		/// 申请人代码
		/// </summary>
		public string APPLY_CODE
		{
			get{ return _APPLY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_CODE, _APPLY_CODE, value);
				this._APPLY_CODE = value;
			}
		}
		/// <summary>
		/// 申请人角色
		/// </summary>
		public string APPLY_ROLE
		{
			get{ return _APPLY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_ROLE, _APPLY_ROLE, value);
				this._APPLY_ROLE = value;
			}
		}
		/// <summary>
		/// 设计生产规模
		/// </summary>
		public decimal? QT_DESIGN_SCOPE
		{
			get{ return _QT_DESIGN_SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.QT_DESIGN_SCOPE, _QT_DESIGN_SCOPE, value);
				this._QT_DESIGN_SCOPE = value;
			}
		}
		/// <summary>
		/// 规模单位
		/// </summary>
		public string NA_SCOPE_UNIT
		{
			get{ return _NA_SCOPE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.NA_SCOPE_UNIT, _NA_SCOPE_UNIT, value);
				this._NA_SCOPE_UNIT = value;
			}
		}
		/// <summary>
		/// 审批机关
		/// </summary>
		public string NA_GOV_NAME
		{
			get{ return _NA_GOV_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_GOV_NAME, _NA_GOV_NAME, value);
				this._NA_GOV_NAME = value;
			}
		}
		/// <summary>
		/// 取得方式
		/// </summary>
		public decimal? IN_BUY_KIND
		{
			get{ return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
			}
		}
		/// <summary>
		/// 开采主矿种
		/// </summary>
		public decimal? IN_MINE_COME
		{
			get{ return _IN_MINE_COME; }
			set
			{
				this.OnPropertyValueChange(_.IN_MINE_COME, _IN_MINE_COME, value);
				this._IN_MINE_COME = value;
			}
		}
		/// <summary>
		/// 受理日期
		/// </summary>
		public DateTime? DT_RECIVE_DATE
		{
			get{ return _DT_RECIVE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.DT_RECIVE_DATE, _DT_RECIVE_DATE, value);
				this._DT_RECIVE_DATE = value;
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
		/// 公告源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
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
		/// 其他方式出让矿业权公开信息（采矿权出让公开信息）
		/// </summary>
		public string M_ATT_OTHER_MINING_PUBLIC_INFO
		{
			get{ return _M_ATT_OTHER_MINING_PUBLIC_INFO; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_OTHER_MINING_PUBLIC_INFO, _M_ATT_OTHER_MINING_PUBLIC_INFO, value);
				this._M_ATT_OTHER_MINING_PUBLIC_INFO = value;
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
		/// 交易机构名称
		/// </summary>
		public string TRA_AGENCY_NAME
		{
			get{ return _TRA_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_NAME, _TRA_AGENCY_NAME, value);
				this._TRA_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 交易机构代码
		/// </summary>
		public string TRA_AGENCY_CODE
		{
			get{ return _TRA_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_CODE, _TRA_AGENCY_CODE, value);
				this._TRA_AGENCY_CODE = value;
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
				_.NA_APP_NAME,
				_.PUBLISHING_TIME,
				_.UNIFIED_DEAL_CODE,
				_.NA_APPLY_PERSON,
				_.APPLY_TYPE,
				_.APPLY_CODE,
				_.APPLY_ROLE,
				_.QT_DESIGN_SCOPE,
				_.NA_SCOPE_UNIT,
				_.NA_GOV_NAME,
				_.IN_BUY_KIND,
				_.IN_MINE_COME,
				_.DT_RECIVE_DATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.URL,
				_.M_ID,
				_.M_ATT_OTHER_MINING_PUBLIC_INFO,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
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
				this._NA_APP_NAME,
				this._PUBLISHING_TIME,
				this._UNIFIED_DEAL_CODE,
				this._NA_APPLY_PERSON,
				this._APPLY_TYPE,
				this._APPLY_CODE,
				this._APPLY_ROLE,
				this._QT_DESIGN_SCOPE,
				this._NA_SCOPE_UNIT,
				this._NA_GOV_NAME,
				this._IN_BUY_KIND,
				this._IN_MINE_COME,
				this._DT_RECIVE_DATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._URL,
				this._M_ID,
				this._M_ATT_OTHER_MINING_PUBLIC_INFO,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
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
			public readonly static Field All = new Field("*", "MINING_TRANS_PUB_INFO");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field NA_APP_NAME = new Field("NA_APP_NAME", "MINING_TRANS_PUB_INFO", "项目名称");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "MINING_TRANS_PUB_INFO", "发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "MINING_TRANS_PUB_INFO", "统一交易标识码");
            /// <summary>
			/// 申请人
			/// </summary>
			public readonly static Field NA_APPLY_PERSON = new Field("NA_APPLY_PERSON", "MINING_TRANS_PUB_INFO", "申请人");
            /// <summary>
			/// 申请人类别
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "MINING_TRANS_PUB_INFO", "申请人类别");
            /// <summary>
			/// 申请人代码
			/// </summary>
			public readonly static Field APPLY_CODE = new Field("APPLY_CODE", "MINING_TRANS_PUB_INFO", "申请人代码");
            /// <summary>
			/// 申请人角色
			/// </summary>
			public readonly static Field APPLY_ROLE = new Field("APPLY_ROLE", "MINING_TRANS_PUB_INFO", "申请人角色");
            /// <summary>
			/// 设计生产规模
			/// </summary>
			public readonly static Field QT_DESIGN_SCOPE = new Field("QT_DESIGN_SCOPE", "MINING_TRANS_PUB_INFO", "设计生产规模");
            /// <summary>
			/// 规模单位
			/// </summary>
			public readonly static Field NA_SCOPE_UNIT = new Field("NA_SCOPE_UNIT", "MINING_TRANS_PUB_INFO", "规模单位");
            /// <summary>
			/// 审批机关
			/// </summary>
			public readonly static Field NA_GOV_NAME = new Field("NA_GOV_NAME", "MINING_TRANS_PUB_INFO", "审批机关");
            /// <summary>
			/// 取得方式
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "MINING_TRANS_PUB_INFO", "取得方式");
            /// <summary>
			/// 开采主矿种
			/// </summary>
			public readonly static Field IN_MINE_COME = new Field("IN_MINE_COME", "MINING_TRANS_PUB_INFO", "开采主矿种");
            /// <summary>
			/// 受理日期
			/// </summary>
			public readonly static Field DT_RECIVE_DATE = new Field("DT_RECIVE_DATE", "MINING_TRANS_PUB_INFO", "受理日期");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MINING_TRANS_PUB_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "MINING_TRANS_PUB_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "MINING_TRANS_PUB_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "MINING_TRANS_PUB_INFO", "公告源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 其他方式出让矿业权公开信息（采矿权出让公开信息）
			/// </summary>
			public readonly static Field M_ATT_OTHER_MINING_PUBLIC_INFO = new Field("M_ATT_OTHER_MINING_PUBLIC_INFO", "MINING_TRANS_PUB_INFO", "其他方式出让矿业权公开信息（采矿权出让公开信息）");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "MINING_TRANS_PUB_INFO", "项目所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "MINING_TRANS_PUB_INFO", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "MINING_TRANS_PUB_INFO", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "MINING_TRANS_PUB_INFO", "交易机构代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "MINING_TRANS_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "MINING_TRANS_PUB_INFO", "");
        }
        #endregion
	}
}