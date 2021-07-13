using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LISTING_PUB_INFO_PRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LISTING_PUB_INFO_PRE")]
    [Serializable]
    public partial class LISTING_PUB_INFO_PRE : FwEntity
    {
        #region Model
		private string _PROJECT_NAME;
		private string _PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _PROJECT_CLASSIFY_CODE;
		private string _PROJECT_TYPE;
		private string _SELLER_NAME;
		private string _SELLER_CODE;
		private string _SELLER_TYPE;
		private string _SELLER_ROLE;
		private string _ZONE;
		private decimal? _PROJECT_PRICE;
		private decimal? _PUBLISH_DURATION;
		private DateTime? _PUBLISH_DATE;
		private string _POST_PONE;
		private string _PRE_EXCHANGE_TYPE;
		private string _TRANSFER_NOTES;
		private string _PROJECT_URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_GET_TM;
		private string _M_TRANSFER_RESULT;

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
		/// 项目分类代码
		/// </summary>
		public string PROJECT_CLASSIFY_CODE
		{
			get{ return _PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CLASSIFY_CODE, _PROJECT_CLASSIFY_CODE, value);
				this._PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 资产类别（实物）
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
		/// 转让方名称
		/// </summary>
		public string SELLER_NAME
		{
			get{ return _SELLER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_NAME, _SELLER_NAME, value);
				this._SELLER_NAME = value;
			}
		}
		/// <summary>
		/// 转让方代码
		/// </summary>
		public string SELLER_CODE
		{
			get{ return _SELLER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_CODE, _SELLER_CODE, value);
				this._SELLER_CODE = value;
			}
		}
		/// <summary>
		/// 转让方类别
		/// </summary>
		public string SELLER_TYPE
		{
			get{ return _SELLER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_TYPE, _SELLER_TYPE, value);
				this._SELLER_TYPE = value;
			}
		}
		/// <summary>
		/// 转让方角色
		/// </summary>
		public string SELLER_ROLE
		{
			get{ return _SELLER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_ROLE, _SELLER_ROLE, value);
				this._SELLER_ROLE = value;
			}
		}
		/// <summary>
		/// 转让标的所在地区
		/// </summary>
		public string ZONE
		{
			get{ return _ZONE; }
			set
			{
				this.OnPropertyValueChange(_.ZONE, _ZONE, value);
				this._ZONE = value;
			}
		}
		/// <summary>
		/// 挂牌价格
		/// </summary>
		public decimal? PROJECT_PRICE
		{
			get{ return _PROJECT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PRICE, _PROJECT_PRICE, value);
				this._PROJECT_PRICE = value;
			}
		}
		/// <summary>
		/// 挂牌期间
		/// </summary>
		public decimal? PUBLISH_DURATION
		{
			get{ return _PUBLISH_DURATION; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DURATION, _PUBLISH_DURATION, value);
				this._PUBLISH_DURATION = value;
			}
		}
		/// <summary>
		/// 挂牌日期
		/// </summary>
		public DateTime? PUBLISH_DATE
		{
			get{ return _PUBLISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DATE, _PUBLISH_DATE, value);
				this._PUBLISH_DATE = value;
			}
		}
		/// <summary>
		/// 是否自动延期
		/// </summary>
		public string POST_PONE
		{
			get{ return _POST_PONE; }
			set
			{
				this.OnPropertyValueChange(_.POST_PONE, _POST_PONE, value);
				this._POST_PONE = value;
			}
		}
		/// <summary>
		/// 交易方式
		/// </summary>
		public string PRE_EXCHANGE_TYPE
		{
			get{ return _PRE_EXCHANGE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PRE_EXCHANGE_TYPE, _PRE_EXCHANGE_TYPE, value);
				this._PRE_EXCHANGE_TYPE = value;
			}
		}
		/// <summary>
		/// 转让说明事项
		/// </summary>
		public string TRANSFER_NOTES
		{
			get{ return _TRANSFER_NOTES; }
			set
			{
				this.OnPropertyValueChange(_.TRANSFER_NOTES, _TRANSFER_NOTES, value);
				this._TRANSFER_NOTES = value;
			}
		}
		/// <summary>
		/// 在交易机构网站进行挂牌信息披露的链接
		/// </summary>
		public string PROJECT_URL
		{
			get{ return _PROJECT_URL; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_URL, _PROJECT_URL, value);
				this._PROJECT_URL = value;
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
		/// 价格币种代码
		/// </summary>
		public string CURRENCY_CODE
		{
			get{ return _CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY_CODE, _CURRENCY_CODE, value);
				this._CURRENCY_CODE = value;
			}
		}
		/// <summary>
		/// 价格单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
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
		/// 获批日期
		/// </summary>
		public DateTime? M_GET_TM
		{
			get{ return _M_GET_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_GET_TM, _M_GET_TM, value);
				this._M_GET_TM = value;
			}
		}
		/// <summary>
		/// 产权转让行为的决策及批准情况
		/// </summary>
		public string M_TRANSFER_RESULT
		{
			get{ return _M_TRANSFER_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.M_TRANSFER_RESULT, _M_TRANSFER_RESULT, value);
				this._M_TRANSFER_RESULT = value;
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
				_.PROJECT_NAME,
				_.PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.PROJECT_CLASSIFY_CODE,
				_.PROJECT_TYPE,
				_.SELLER_NAME,
				_.SELLER_CODE,
				_.SELLER_TYPE,
				_.SELLER_ROLE,
				_.ZONE,
				_.PROJECT_PRICE,
				_.PUBLISH_DURATION,
				_.PUBLISH_DATE,
				_.POST_PONE,
				_.PRE_EXCHANGE_TYPE,
				_.TRANSFER_NOTES,
				_.PROJECT_URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_GET_TM,
				_.M_TRANSFER_RESULT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_NAME,
				this._PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._PROJECT_CLASSIFY_CODE,
				this._PROJECT_TYPE,
				this._SELLER_NAME,
				this._SELLER_CODE,
				this._SELLER_TYPE,
				this._SELLER_ROLE,
				this._ZONE,
				this._PROJECT_PRICE,
				this._PUBLISH_DURATION,
				this._PUBLISH_DATE,
				this._POST_PONE,
				this._PRE_EXCHANGE_TYPE,
				this._TRANSFER_NOTES,
				this._PROJECT_URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_GET_TM,
				this._M_TRANSFER_RESULT,
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
			public readonly static Field All = new Field("*", "LISTING_PUB_INFO_PRE");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "LISTING_PUB_INFO_PRE", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "LISTING_PUB_INFO_PRE", "项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "LISTING_PUB_INFO_PRE", "统一交易标识码");
            /// <summary>
			/// 项目分类代码
			/// </summary>
			public readonly static Field PROJECT_CLASSIFY_CODE = new Field("PROJECT_CLASSIFY_CODE", "LISTING_PUB_INFO_PRE", "项目分类代码");
            /// <summary>
			/// 资产类别（实物）
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "LISTING_PUB_INFO_PRE", "资产类别（实物）");
            /// <summary>
			/// 转让方名称
			/// </summary>
			public readonly static Field SELLER_NAME = new Field("SELLER_NAME", "LISTING_PUB_INFO_PRE", "转让方名称");
            /// <summary>
			/// 转让方代码
			/// </summary>
			public readonly static Field SELLER_CODE = new Field("SELLER_CODE", "LISTING_PUB_INFO_PRE", "转让方代码");
            /// <summary>
			/// 转让方类别
			/// </summary>
			public readonly static Field SELLER_TYPE = new Field("SELLER_TYPE", "LISTING_PUB_INFO_PRE", "转让方类别");
            /// <summary>
			/// 转让方角色
			/// </summary>
			public readonly static Field SELLER_ROLE = new Field("SELLER_ROLE", "LISTING_PUB_INFO_PRE", "转让方角色");
            /// <summary>
			/// 转让标的所在地区
			/// </summary>
			public readonly static Field ZONE = new Field("ZONE", "LISTING_PUB_INFO_PRE", "转让标的所在地区");
            /// <summary>
			/// 挂牌价格
			/// </summary>
			public readonly static Field PROJECT_PRICE = new Field("PROJECT_PRICE", "LISTING_PUB_INFO_PRE", "挂牌价格");
            /// <summary>
			/// 挂牌期间
			/// </summary>
			public readonly static Field PUBLISH_DURATION = new Field("PUBLISH_DURATION", "LISTING_PUB_INFO_PRE", "挂牌期间");
            /// <summary>
			/// 挂牌日期
			/// </summary>
			public readonly static Field PUBLISH_DATE = new Field("PUBLISH_DATE", "LISTING_PUB_INFO_PRE", "挂牌日期");
            /// <summary>
			/// 是否自动延期
			/// </summary>
			public readonly static Field POST_PONE = new Field("POST_PONE", "LISTING_PUB_INFO_PRE", "是否自动延期");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field PRE_EXCHANGE_TYPE = new Field("PRE_EXCHANGE_TYPE", "LISTING_PUB_INFO_PRE", "交易方式");
            /// <summary>
			/// 转让说明事项
			/// </summary>
			public readonly static Field TRANSFER_NOTES = new Field("TRANSFER_NOTES", "LISTING_PUB_INFO_PRE",DbType.AnsiString, null, "转让说明事项");
            /// <summary>
			/// 在交易机构网站进行挂牌信息披露的链接
			/// </summary>
			public readonly static Field PROJECT_URL = new Field("PROJECT_URL", "LISTING_PUB_INFO_PRE", "在交易机构网站进行挂牌信息披露的链接");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "LISTING_PUB_INFO_PRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "LISTING_PUB_INFO_PRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "LISTING_PUB_INFO_PRE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "LISTING_PUB_INFO_PRE", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "LISTING_PUB_INFO_PRE", "价格单位");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "LISTING_PUB_INFO_PRE", "");
            /// <summary>
			/// 获批日期
			/// </summary>
			public readonly static Field M_GET_TM = new Field("M_GET_TM", "LISTING_PUB_INFO_PRE", "获批日期");
            /// <summary>
			/// 产权转让行为的决策及批准情况
			/// </summary>
			public readonly static Field M_TRANSFER_RESULT = new Field("M_TRANSFER_RESULT", "LISTING_PUB_INFO_PRE", "产权转让行为的决策及批准情况");
        }
        #endregion
	}
}