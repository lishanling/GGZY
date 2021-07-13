using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类OIL_GAS_EXPLOR_REG_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("OIL_GAS_EXPLOR_REG_ANN")]
    [Serializable]
    public partial class OIL_GAS_EXPLOR_REG_ANN : FwEntity
    {
        #region Model
		private string _NA_ITEM_NAME;
		private DateTime? _PUBLISHING_TIME;
		private string _UNIFIED_DEAL_CODE;
		private string _ID_LICENCEID;
		private string _IN_ITEM_TYPE;
		private string _NA_APPLY_PERSON;
		private string _APPLY_TYPE;
		private string _APPLY_CODE;
		private string _APPLY_ROLE;
		private string _NA_JZZB;
		private DateTime? _DT_USEFULLIFE_START;
		private DateTime? _DT_USEFULLIFE_END;
		private decimal? _QT_TOTAL_AREA;
		private string _NA_GEOGRAPHY_POSITION;
		private string _APPROVE_ORG;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _URL;
		private decimal? _M_ID;
		private string _M_ATT_OIL_EXPLOR_ANNOUCEMNET;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 项目名称
		/// </summary>
		public string NA_ITEM_NAME
		{
			get{ return _NA_ITEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_ITEM_NAME, _NA_ITEM_NAME, value);
				this._NA_ITEM_NAME = value;
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
		/// 许可证号
		/// </summary>
		public string ID_LICENCEID
		{
			get{ return _ID_LICENCEID; }
			set
			{
				this.OnPropertyValueChange(_.ID_LICENCEID, _ID_LICENCEID, value);
				this._ID_LICENCEID = value;
			}
		}
		/// <summary>
		/// 项目类型
		/// </summary>
		public string IN_ITEM_TYPE
		{
			get{ return _IN_ITEM_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.IN_ITEM_TYPE, _IN_ITEM_TYPE, value);
				this._IN_ITEM_TYPE = value;
			}
		}
		/// <summary>
		/// 探矿权人
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
		/// 探矿权人类别
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
		/// 探矿权人代码
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
		/// 探矿权人角色
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
		/// 极值坐标
		/// </summary>
		public string NA_JZZB
		{
			get{ return _NA_JZZB; }
			set
			{
				this.OnPropertyValueChange(_.NA_JZZB, _NA_JZZB, value);
				this._NA_JZZB = value;
			}
		}
		/// <summary>
		/// 有效期起
		/// </summary>
		public DateTime? DT_USEFULLIFE_START
		{
			get{ return _DT_USEFULLIFE_START; }
			set
			{
				this.OnPropertyValueChange(_.DT_USEFULLIFE_START, _DT_USEFULLIFE_START, value);
				this._DT_USEFULLIFE_START = value;
			}
		}
		/// <summary>
		/// 有效期止
		/// </summary>
		public DateTime? DT_USEFULLIFE_END
		{
			get{ return _DT_USEFULLIFE_END; }
			set
			{
				this.OnPropertyValueChange(_.DT_USEFULLIFE_END, _DT_USEFULLIFE_END, value);
				this._DT_USEFULLIFE_END = value;
			}
		}
		/// <summary>
		/// 面积
		/// </summary>
		public decimal? QT_TOTAL_AREA
		{
			get{ return _QT_TOTAL_AREA; }
			set
			{
				this.OnPropertyValueChange(_.QT_TOTAL_AREA, _QT_TOTAL_AREA, value);
				this._QT_TOTAL_AREA = value;
			}
		}
		/// <summary>
		/// 地理位置
		/// </summary>
		public string NA_GEOGRAPHY_POSITION
		{
			get{ return _NA_GEOGRAPHY_POSITION; }
			set
			{
				this.OnPropertyValueChange(_.NA_GEOGRAPHY_POSITION, _NA_GEOGRAPHY_POSITION, value);
				this._NA_GEOGRAPHY_POSITION = value;
			}
		}
		/// <summary>
		/// 发证机关
		/// </summary>
		public string APPROVE_ORG
		{
			get{ return _APPROVE_ORG; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_ORG, _APPROVE_ORG, value);
				this._APPROVE_ORG = value;
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
		/// 油气探矿权登记公告信息
		/// </summary>
		public string M_ATT_OIL_EXPLOR_ANNOUCEMNET
		{
			get{ return _M_ATT_OIL_EXPLOR_ANNOUCEMNET; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_OIL_EXPLOR_ANNOUCEMNET, _M_ATT_OIL_EXPLOR_ANNOUCEMNET, value);
				this._M_ATT_OIL_EXPLOR_ANNOUCEMNET = value;
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
				_.NA_ITEM_NAME,
				_.PUBLISHING_TIME,
				_.UNIFIED_DEAL_CODE,
				_.ID_LICENCEID,
				_.IN_ITEM_TYPE,
				_.NA_APPLY_PERSON,
				_.APPLY_TYPE,
				_.APPLY_CODE,
				_.APPLY_ROLE,
				_.NA_JZZB,
				_.DT_USEFULLIFE_START,
				_.DT_USEFULLIFE_END,
				_.QT_TOTAL_AREA,
				_.NA_GEOGRAPHY_POSITION,
				_.APPROVE_ORG,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.URL,
				_.M_ID,
				_.M_ATT_OIL_EXPLOR_ANNOUCEMNET,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._NA_ITEM_NAME,
				this._PUBLISHING_TIME,
				this._UNIFIED_DEAL_CODE,
				this._ID_LICENCEID,
				this._IN_ITEM_TYPE,
				this._NA_APPLY_PERSON,
				this._APPLY_TYPE,
				this._APPLY_CODE,
				this._APPLY_ROLE,
				this._NA_JZZB,
				this._DT_USEFULLIFE_START,
				this._DT_USEFULLIFE_END,
				this._QT_TOTAL_AREA,
				this._NA_GEOGRAPHY_POSITION,
				this._APPROVE_ORG,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._URL,
				this._M_ID,
				this._M_ATT_OIL_EXPLOR_ANNOUCEMNET,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
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
			public readonly static Field All = new Field("*", "OIL_GAS_EXPLOR_REG_ANN");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field NA_ITEM_NAME = new Field("NA_ITEM_NAME", "OIL_GAS_EXPLOR_REG_ANN", "项目名称");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "OIL_GAS_EXPLOR_REG_ANN", "发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "OIL_GAS_EXPLOR_REG_ANN", "统一交易标识码");
            /// <summary>
			/// 许可证号
			/// </summary>
			public readonly static Field ID_LICENCEID = new Field("ID_LICENCEID", "OIL_GAS_EXPLOR_REG_ANN", "许可证号");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field IN_ITEM_TYPE = new Field("IN_ITEM_TYPE", "OIL_GAS_EXPLOR_REG_ANN", "项目类型");
            /// <summary>
			/// 探矿权人
			/// </summary>
			public readonly static Field NA_APPLY_PERSON = new Field("NA_APPLY_PERSON", "OIL_GAS_EXPLOR_REG_ANN", "探矿权人");
            /// <summary>
			/// 探矿权人类别
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "OIL_GAS_EXPLOR_REG_ANN", "探矿权人类别");
            /// <summary>
			/// 探矿权人代码
			/// </summary>
			public readonly static Field APPLY_CODE = new Field("APPLY_CODE", "OIL_GAS_EXPLOR_REG_ANN", "探矿权人代码");
            /// <summary>
			/// 探矿权人角色
			/// </summary>
			public readonly static Field APPLY_ROLE = new Field("APPLY_ROLE", "OIL_GAS_EXPLOR_REG_ANN", "探矿权人角色");
            /// <summary>
			/// 极值坐标
			/// </summary>
			public readonly static Field NA_JZZB = new Field("NA_JZZB", "OIL_GAS_EXPLOR_REG_ANN", "极值坐标");
            /// <summary>
			/// 有效期起
			/// </summary>
			public readonly static Field DT_USEFULLIFE_START = new Field("DT_USEFULLIFE_START", "OIL_GAS_EXPLOR_REG_ANN", "有效期起");
            /// <summary>
			/// 有效期止
			/// </summary>
			public readonly static Field DT_USEFULLIFE_END = new Field("DT_USEFULLIFE_END", "OIL_GAS_EXPLOR_REG_ANN", "有效期止");
            /// <summary>
			/// 面积
			/// </summary>
			public readonly static Field QT_TOTAL_AREA = new Field("QT_TOTAL_AREA", "OIL_GAS_EXPLOR_REG_ANN", "面积");
            /// <summary>
			/// 地理位置
			/// </summary>
			public readonly static Field NA_GEOGRAPHY_POSITION = new Field("NA_GEOGRAPHY_POSITION", "OIL_GAS_EXPLOR_REG_ANN", "地理位置");
            /// <summary>
			/// 发证机关
			/// </summary>
			public readonly static Field APPROVE_ORG = new Field("APPROVE_ORG", "OIL_GAS_EXPLOR_REG_ANN", "发证机关");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "OIL_GAS_EXPLOR_REG_ANN", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "OIL_GAS_EXPLOR_REG_ANN", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "OIL_GAS_EXPLOR_REG_ANN", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "OIL_GAS_EXPLOR_REG_ANN", "公告源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 油气探矿权登记公告信息
			/// </summary>
			public readonly static Field M_ATT_OIL_EXPLOR_ANNOUCEMNET = new Field("M_ATT_OIL_EXPLOR_ANNOUCEMNET", "OIL_GAS_EXPLOR_REG_ANN", "油气探矿权登记公告信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "OIL_GAS_EXPLOR_REG_ANN", "");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "OIL_GAS_EXPLOR_REG_ANN", "项目所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "OIL_GAS_EXPLOR_REG_ANN", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "OIL_GAS_EXPLOR_REG_ANN", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "OIL_GAS_EXPLOR_REG_ANN", "交易机构代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "OIL_GAS_EXPLOR_REG_ANN", "");
        }
        #endregion
	}
}