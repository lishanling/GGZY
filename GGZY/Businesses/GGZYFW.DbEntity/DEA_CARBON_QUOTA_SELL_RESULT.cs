using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_CARBON_QUOTA_SELL_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_CARBON_QUOTA_SELL_RESULT")]
    [Serializable]
    public partial class DEA_CARBON_QUOTA_SELL_RESULT : FwEntity
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
		private DateTime? _NOTICE_SEND_TIME;
		private string _UNIFIED_DEAL_CODES;
		private string _CA_QUOTA_NAME;
		private string _CA_QUOTA_CODE;
		private string _IN_BUY_KIND;
		private string _CA_BUYER_NAME;
		private string _CA_BUYER_CODE;
		private string _CA_BUYER_TYPE;
		private string _BUYER_IDTYPE;
		private string _BUYER_IDCARD;
		private string _BARGAIN_NO;
		private decimal? _BARGAIN_PRICE;
		private decimal? _BARGAIN_QTY;
		private decimal? _BARGAIN_VALUE;
		private DateTime? _BARGAIN_TIME;
		private string _CA_QUOTA_URL;
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
		/// 公告发布时间
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODES
		{
			get{ return _UNIFIED_DEAL_CODES; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODES, _UNIFIED_DEAL_CODES, value);
				this._UNIFIED_DEAL_CODES = value;
			}
		}
		/// <summary>
		/// 公告名称
		/// </summary>
		public string CA_QUOTA_NAME
		{
			get{ return _CA_QUOTA_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_NAME, _CA_QUOTA_NAME, value);
				this._CA_QUOTA_NAME = value;
			}
		}
		/// <summary>
		/// 公告编号
		/// </summary>
		public string CA_QUOTA_CODE
		{
			get{ return _CA_QUOTA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_CODE, _CA_QUOTA_CODE, value);
				this._CA_QUOTA_CODE = value;
			}
		}
		/// <summary>
		/// 出让方式(sys_dic type=9544)
		/// </summary>
		public string IN_BUY_KIND
		{
			get{ return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
			}
		}
		/// <summary>
		/// 受让方名称
		/// </summary>
		public string CA_BUYER_NAME
		{
			get{ return _CA_BUYER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CA_BUYER_NAME, _CA_BUYER_NAME, value);
				this._CA_BUYER_NAME = value;
			}
		}
		/// <summary>
		/// 受让方代码
		/// </summary>
		public string CA_BUYER_CODE
		{
			get{ return _CA_BUYER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CA_BUYER_CODE, _CA_BUYER_CODE, value);
				this._CA_BUYER_CODE = value;
			}
		}
		/// <summary>
		/// 受让方类型(sys_dic type=9546)
		/// </summary>
		public string CA_BUYER_TYPE
		{
			get{ return _CA_BUYER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CA_BUYER_TYPE, _CA_BUYER_TYPE, value);
				this._CA_BUYER_TYPE = value;
			}
		}
		/// <summary>
		/// 受让方证件类型(sys_dic type=9547)
		/// </summary>
		public string BUYER_IDTYPE
		{
			get{ return _BUYER_IDTYPE; }
			set
			{
				this.OnPropertyValueChange(_.BUYER_IDTYPE, _BUYER_IDTYPE, value);
				this._BUYER_IDTYPE = value;
			}
		}
		/// <summary>
		/// 受让方证件号码
		/// </summary>
		public string BUYER_IDCARD
		{
			get{ return _BUYER_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.BUYER_IDCARD, _BUYER_IDCARD, value);
				this._BUYER_IDCARD = value;
			}
		}
		/// <summary>
		/// 成交编号
		/// </summary>
		public string BARGAIN_NO
		{
			get{ return _BARGAIN_NO; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_NO, _BARGAIN_NO, value);
				this._BARGAIN_NO = value;
			}
		}
		/// <summary>
		/// 成交单价)
		/// </summary>
		public decimal? BARGAIN_PRICE
		{
			get{ return _BARGAIN_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_PRICE, _BARGAIN_PRICE, value);
				this._BARGAIN_PRICE = value;
			}
		}
		/// <summary>
		/// 成交数量
		/// </summary>
		public decimal? BARGAIN_QTY
		{
			get{ return _BARGAIN_QTY; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_QTY, _BARGAIN_QTY, value);
				this._BARGAIN_QTY = value;
			}
		}
		/// <summary>
		/// 成交金额
		/// </summary>
		public decimal? BARGAIN_VALUE
		{
			get{ return _BARGAIN_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_VALUE, _BARGAIN_VALUE, value);
				this._BARGAIN_VALUE = value;
			}
		}
		/// <summary>
		/// 成交时间
		/// </summary>
		public DateTime? BARGAIN_TIME
		{
			get{ return _BARGAIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BARGAIN_TIME, _BARGAIN_TIME, value);
				this._BARGAIN_TIME = value;
			}
		}
		/// <summary>
		/// 公告源URL
		/// </summary>
		public string CA_QUOTA_URL
		{
			get{ return _CA_QUOTA_URL; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_URL, _CA_QUOTA_URL, value);
				this._CA_QUOTA_URL = value;
			}
		}
		/// <summary>
		/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
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
				_.NOTICE_SEND_TIME,
				_.UNIFIED_DEAL_CODES,
				_.CA_QUOTA_NAME,
				_.CA_QUOTA_CODE,
				_.IN_BUY_KIND,
				_.CA_BUYER_NAME,
				_.CA_BUYER_CODE,
				_.CA_BUYER_TYPE,
				_.BUYER_IDTYPE,
				_.BUYER_IDCARD,
				_.BARGAIN_NO,
				_.BARGAIN_PRICE,
				_.BARGAIN_QTY,
				_.BARGAIN_VALUE,
				_.BARGAIN_TIME,
				_.CA_QUOTA_URL,
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
				this._NOTICE_SEND_TIME,
				this._UNIFIED_DEAL_CODES,
				this._CA_QUOTA_NAME,
				this._CA_QUOTA_CODE,
				this._IN_BUY_KIND,
				this._CA_BUYER_NAME,
				this._CA_BUYER_CODE,
				this._CA_BUYER_TYPE,
				this._BUYER_IDTYPE,
				this._BUYER_IDCARD,
				this._BARGAIN_NO,
				this._BARGAIN_PRICE,
				this._BARGAIN_QTY,
				this._BARGAIN_VALUE,
				this._BARGAIN_TIME,
				this._CA_QUOTA_URL,
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
			public readonly static Field All = new Field("*", "DEA_CARBON_QUOTA_SELL_RESULT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_CARBON_QUOTA_SELL_RESULT", "");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "DEA_CARBON_QUOTA_SELL_RESULT", "公告发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "DEA_CARBON_QUOTA_SELL_RESULT", "统一交易标识码");
            /// <summary>
			/// 公告名称
			/// </summary>
			public readonly static Field CA_QUOTA_NAME = new Field("CA_QUOTA_NAME", "DEA_CARBON_QUOTA_SELL_RESULT", "公告名称");
            /// <summary>
			/// 公告编号
			/// </summary>
			public readonly static Field CA_QUOTA_CODE = new Field("CA_QUOTA_CODE", "DEA_CARBON_QUOTA_SELL_RESULT", "公告编号");
            /// <summary>
			/// 出让方式(sys_dic type=9544)
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "DEA_CARBON_QUOTA_SELL_RESULT", "出让方式(sys_dic type=9544)");
            /// <summary>
			/// 受让方名称
			/// </summary>
			public readonly static Field CA_BUYER_NAME = new Field("CA_BUYER_NAME", "DEA_CARBON_QUOTA_SELL_RESULT", "受让方名称");
            /// <summary>
			/// 受让方代码
			/// </summary>
			public readonly static Field CA_BUYER_CODE = new Field("CA_BUYER_CODE", "DEA_CARBON_QUOTA_SELL_RESULT", "受让方代码");
            /// <summary>
			/// 受让方类型(sys_dic type=9546)
			/// </summary>
			public readonly static Field CA_BUYER_TYPE = new Field("CA_BUYER_TYPE", "DEA_CARBON_QUOTA_SELL_RESULT", "受让方类型(sys_dic type=9546)");
            /// <summary>
			/// 受让方证件类型(sys_dic type=9547)
			/// </summary>
			public readonly static Field BUYER_IDTYPE = new Field("BUYER_IDTYPE", "DEA_CARBON_QUOTA_SELL_RESULT", "受让方证件类型(sys_dic type=9547)");
            /// <summary>
			/// 受让方证件号码
			/// </summary>
			public readonly static Field BUYER_IDCARD = new Field("BUYER_IDCARD", "DEA_CARBON_QUOTA_SELL_RESULT", "受让方证件号码");
            /// <summary>
			/// 成交编号
			/// </summary>
			public readonly static Field BARGAIN_NO = new Field("BARGAIN_NO", "DEA_CARBON_QUOTA_SELL_RESULT", "成交编号");
            /// <summary>
			/// 成交单价)
			/// </summary>
			public readonly static Field BARGAIN_PRICE = new Field("BARGAIN_PRICE", "DEA_CARBON_QUOTA_SELL_RESULT", "成交单价)");
            /// <summary>
			/// 成交数量
			/// </summary>
			public readonly static Field BARGAIN_QTY = new Field("BARGAIN_QTY", "DEA_CARBON_QUOTA_SELL_RESULT", "成交数量");
            /// <summary>
			/// 成交金额
			/// </summary>
			public readonly static Field BARGAIN_VALUE = new Field("BARGAIN_VALUE", "DEA_CARBON_QUOTA_SELL_RESULT", "成交金额");
            /// <summary>
			/// 成交时间
			/// </summary>
			public readonly static Field BARGAIN_TIME = new Field("BARGAIN_TIME", "DEA_CARBON_QUOTA_SELL_RESULT", "成交时间");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field CA_QUOTA_URL = new Field("CA_QUOTA_URL", "DEA_CARBON_QUOTA_SELL_RESULT", "公告源URL");
            /// <summary>
			/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_CARBON_QUOTA_SELL_RESULT", "交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_CARBON_QUOTA_SELL_RESULT", "公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_CARBON_QUOTA_SELL_RESULT", "数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_CARBON_QUOTA_SELL_RESULT", "");
        }
        #endregion
	}
}