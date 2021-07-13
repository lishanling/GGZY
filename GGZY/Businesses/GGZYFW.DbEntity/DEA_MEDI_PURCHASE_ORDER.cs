using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_MEDI_PURCHASE_ORDER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_MEDI_PURCHASE_ORDER")]
    [Serializable]
    public partial class DEA_MEDI_PURCHASE_ORDER : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _PROJECT_CODE;
		private string _PROJNAME;
		private string _DRUGGROUP;
		private string _UNIFIED_DEAL_CODE;
		private string _ORDERDETAILID;
		private string _ORDERNAME;
		private string _HOSPNAME;
		private string _ORGCODE;
		private string _ORGID;
		private decimal? _PURPRICE;
		private DateTime? _ORDTIME;
		private string _PURSTATUS;
		private string _BID_CURRENCY;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_VERSION;

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
		public string PROJNAME
		{
			get{ return _PROJNAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJNAME, _PROJNAME, value);
				this._PROJNAME = value;
			}
		}
		/// <summary>
		/// 采购类别
		/// </summary>
		public string DRUGGROUP
		{
			get{ return _DRUGGROUP; }
			set
			{
				this.OnPropertyValueChange(_.DRUGGROUP, _DRUGGROUP, value);
				this._DRUGGROUP = value;
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
		/// 采购单编号
		/// </summary>
		public string ORDERDETAILID
		{
			get{ return _ORDERDETAILID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERDETAILID, _ORDERDETAILID, value);
				this._ORDERDETAILID = value;
			}
		}
		/// <summary>
		/// 采购单名称
		/// </summary>
		public string ORDERNAME
		{
			get{ return _ORDERNAME; }
			set
			{
				this.OnPropertyValueChange(_.ORDERNAME, _ORDERNAME, value);
				this._ORDERNAME = value;
			}
		}
		/// <summary>
		/// 药品采购机构名称
		/// </summary>
		public string HOSPNAME
		{
			get{ return _HOSPNAME; }
			set
			{
				this.OnPropertyValueChange(_.HOSPNAME, _HOSPNAME, value);
				this._HOSPNAME = value;
			}
		}
		/// <summary>
		/// 药品采购机构统一社会信用代码/组织机构代码
		/// </summary>
		public string ORGCODE
		{
			get{ return _ORGCODE; }
			set
			{
				this.OnPropertyValueChange(_.ORGCODE, _ORGCODE, value);
				this._ORGCODE = value;
			}
		}
		/// <summary>
		/// 药品采购机构编码
		/// </summary>
		public string ORGID
		{
			get{ return _ORGID; }
			set
			{
				this.OnPropertyValueChange(_.ORGID, _ORGID, value);
				this._ORGID = value;
			}
		}
		/// <summary>
		/// 采购金额
		/// </summary>
		public decimal? PURPRICE
		{
			get{ return _PURPRICE; }
			set
			{
				this.OnPropertyValueChange(_.PURPRICE, _PURPRICE, value);
				this._PURPRICE = value;
			}
		}
		/// <summary>
		/// 下单时间
		/// </summary>
		public DateTime? ORDTIME
		{
			get{ return _ORDTIME; }
			set
			{
				this.OnPropertyValueChange(_.ORDTIME, _ORDTIME, value);
				this._ORDTIME = value;
			}
		}
		/// <summary>
		/// 订单状态
		/// </summary>
		public string PURSTATUS
		{
			get{ return _PURSTATUS; }
			set
			{
				this.OnPropertyValueChange(_.PURSTATUS, _PURSTATUS, value);
				this._PURSTATUS = value;
			}
		}
		/// <summary>
		/// 价格币种代码
		/// </summary>
		public string BID_CURRENCY
		{
			get{ return _BID_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.BID_CURRENCY, _BID_CURRENCY, value);
				this._BID_CURRENCY = value;
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
				_.M_ID,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.PROJECT_CODE,
				_.PROJNAME,
				_.DRUGGROUP,
				_.UNIFIED_DEAL_CODE,
				_.ORDERDETAILID,
				_.ORDERNAME,
				_.HOSPNAME,
				_.ORGCODE,
				_.ORGID,
				_.PURPRICE,
				_.ORDTIME,
				_.PURSTATUS,
				_.BID_CURRENCY,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._PROJECT_CODE,
				this._PROJNAME,
				this._DRUGGROUP,
				this._UNIFIED_DEAL_CODE,
				this._ORDERDETAILID,
				this._ORDERNAME,
				this._HOSPNAME,
				this._ORGCODE,
				this._ORGID,
				this._PURPRICE,
				this._ORDTIME,
				this._PURSTATUS,
				this._BID_CURRENCY,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "DEA_MEDI_PURCHASE_ORDER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_MEDI_PURCHASE_ORDER", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "DEA_MEDI_PURCHASE_ORDER", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJNAME = new Field("PROJNAME", "DEA_MEDI_PURCHASE_ORDER", "项目名称");
            /// <summary>
			/// 采购类别
			/// </summary>
			public readonly static Field DRUGGROUP = new Field("DRUGGROUP", "DEA_MEDI_PURCHASE_ORDER", "采购类别");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "DEA_MEDI_PURCHASE_ORDER", "统一交易标识码");
            /// <summary>
			/// 采购单编号
			/// </summary>
			public readonly static Field ORDERDETAILID = new Field("ORDERDETAILID", "DEA_MEDI_PURCHASE_ORDER", "采购单编号");
            /// <summary>
			/// 采购单名称
			/// </summary>
			public readonly static Field ORDERNAME = new Field("ORDERNAME", "DEA_MEDI_PURCHASE_ORDER", "采购单名称");
            /// <summary>
			/// 药品采购机构名称
			/// </summary>
			public readonly static Field HOSPNAME = new Field("HOSPNAME", "DEA_MEDI_PURCHASE_ORDER", "药品采购机构名称");
            /// <summary>
			/// 药品采购机构统一社会信用代码/组织机构代码
			/// </summary>
			public readonly static Field ORGCODE = new Field("ORGCODE", "DEA_MEDI_PURCHASE_ORDER", "药品采购机构统一社会信用代码/组织机构代码");
            /// <summary>
			/// 药品采购机构编码
			/// </summary>
			public readonly static Field ORGID = new Field("ORGID", "DEA_MEDI_PURCHASE_ORDER", "药品采购机构编码");
            /// <summary>
			/// 采购金额
			/// </summary>
			public readonly static Field PURPRICE = new Field("PURPRICE", "DEA_MEDI_PURCHASE_ORDER", "采购金额");
            /// <summary>
			/// 下单时间
			/// </summary>
			public readonly static Field ORDTIME = new Field("ORDTIME", "DEA_MEDI_PURCHASE_ORDER", "下单时间");
            /// <summary>
			/// 订单状态
			/// </summary>
			public readonly static Field PURSTATUS = new Field("PURSTATUS", "DEA_MEDI_PURCHASE_ORDER", "订单状态");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field BID_CURRENCY = new Field("BID_CURRENCY", "DEA_MEDI_PURCHASE_ORDER", "价格币种代码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_MEDI_PURCHASE_ORDER", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_MEDI_PURCHASE_ORDER", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_MEDI_PURCHASE_ORDER", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_MEDI_PURCHASE_ORDER", "");
        }
        #endregion
	}
}