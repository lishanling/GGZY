using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LIST_PUB_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LIST_PUB_INFO")]
    [Serializable]
    public partial class LIST_PUB_INFO : FwEntity
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
		private string _PUBLISH_DURATION;
		private DateTime? _PUBLISH_DATE;
		private string _POST_PONE;
		private string _PRE_EXCHANGE_TYPE;
		private string _TRANSFER_NOTES;
		private string _PROJECT_URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;

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
		public string PUBLISH_DURATION
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
		/// 交易平台标识码
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.PROJECT_CODE,
				_.SELLER_CODE,
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
			public readonly static Field All = new Field("*", "LIST_PUB_INFO");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "LIST_PUB_INFO", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "LIST_PUB_INFO", "项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "LIST_PUB_INFO", "统一交易标识码");
            /// <summary>
			/// 项目分类代码
			/// </summary>
			public readonly static Field PROJECT_CLASSIFY_CODE = new Field("PROJECT_CLASSIFY_CODE", "LIST_PUB_INFO", "项目分类代码");
            /// <summary>
			/// 资产类别（实物）
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "LIST_PUB_INFO", "资产类别（实物）");
            /// <summary>
			/// 转让方名称
			/// </summary>
			public readonly static Field SELLER_NAME = new Field("SELLER_NAME", "LIST_PUB_INFO", "转让方名称");
            /// <summary>
			/// 转让方代码
			/// </summary>
			public readonly static Field SELLER_CODE = new Field("SELLER_CODE", "LIST_PUB_INFO", "转让方代码");
            /// <summary>
			/// 转让方类别
			/// </summary>
			public readonly static Field SELLER_TYPE = new Field("SELLER_TYPE", "LIST_PUB_INFO", "转让方类别");
            /// <summary>
			/// 转让方角色
			/// </summary>
			public readonly static Field SELLER_ROLE = new Field("SELLER_ROLE", "LIST_PUB_INFO", "转让方角色");
            /// <summary>
			/// 转让标的所在地区
			/// </summary>
			public readonly static Field ZONE = new Field("ZONE", "LIST_PUB_INFO", "转让标的所在地区");
            /// <summary>
			/// 挂牌价格
			/// </summary>
			public readonly static Field PROJECT_PRICE = new Field("PROJECT_PRICE", "LIST_PUB_INFO", "挂牌价格");
            /// <summary>
			/// 挂牌期间
			/// </summary>
			public readonly static Field PUBLISH_DURATION = new Field("PUBLISH_DURATION", "LIST_PUB_INFO", "挂牌期间");
            /// <summary>
			/// 挂牌日期
			/// </summary>
			public readonly static Field PUBLISH_DATE = new Field("PUBLISH_DATE", "LIST_PUB_INFO", "挂牌日期");
            /// <summary>
			/// 是否自动延期
			/// </summary>
			public readonly static Field POST_PONE = new Field("POST_PONE", "LIST_PUB_INFO", "是否自动延期");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field PRE_EXCHANGE_TYPE = new Field("PRE_EXCHANGE_TYPE", "LIST_PUB_INFO", "交易方式");
            /// <summary>
			/// 转让说明事项
			/// </summary>
			public readonly static Field TRANSFER_NOTES = new Field("TRANSFER_NOTES", "LIST_PUB_INFO", "转让说明事项");
            /// <summary>
			/// 在交易机构网站进行挂牌信息披露的链接
			/// </summary>
			public readonly static Field PROJECT_URL = new Field("PROJECT_URL", "LIST_PUB_INFO", "在交易机构网站进行挂牌信息披露的链接");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "LIST_PUB_INFO", "交易平台标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "LIST_PUB_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "LIST_PUB_INFO", "数据时间戳");
        }
        #endregion
	}
}