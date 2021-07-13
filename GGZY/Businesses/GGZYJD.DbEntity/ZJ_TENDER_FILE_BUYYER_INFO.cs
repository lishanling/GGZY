﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_TENDER_FILE_BUYYER_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_TENDER_FILE_BUYYER_INFO")]
    [Serializable]
    public partial class ZJ_TENDER_FILE_BUYYER_INFO : JdEntity
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
		private string _PURCHASE_WAY;
		private string _PURCHASE_MODE;
		private decimal? _PURCHASE_MONEY;
		private string _PURCHASE_ORDER_NUMBER;
		private string _PURCHASE_ACCOUNT;
		private DateTime? _PURCHASE_TIME;
		private string _PURCHASE_IP;
		private string _PURCHASE_BROWSER;
		private string _DOWNLOAD_IP;
		private string _DOWNLOAD_BROWSER;
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
		/// 招标文件购买途径
		/// </summary>
		public string PURCHASE_WAY
		{
			get{ return _PURCHASE_WAY; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_WAY, _PURCHASE_WAY, value);
				this._PURCHASE_WAY = value;
			}
		}
		/// <summary>
		/// 招标文件购买方式
		/// </summary>
		public string PURCHASE_MODE
		{
			get{ return _PURCHASE_MODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_MODE, _PURCHASE_MODE, value);
				this._PURCHASE_MODE = value;
			}
		}
		/// <summary>
		/// 招标文件购买金额
		/// </summary>
		public decimal? PURCHASE_MONEY
		{
			get{ return _PURCHASE_MONEY; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_MONEY, _PURCHASE_MONEY, value);
				this._PURCHASE_MONEY = value;
			}
		}
		/// <summary>
		/// 招标文件购买订单号
		/// </summary>
		public string PURCHASE_ORDER_NUMBER
		{
			get{ return _PURCHASE_ORDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_ORDER_NUMBER, _PURCHASE_ORDER_NUMBER, value);
				this._PURCHASE_ORDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标文件购买账号
		/// </summary>
		public string PURCHASE_ACCOUNT
		{
			get{ return _PURCHASE_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_ACCOUNT, _PURCHASE_ACCOUNT, value);
				this._PURCHASE_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 招标文件购买时间
		/// </summary>
		public DateTime? PURCHASE_TIME
		{
			get{ return _PURCHASE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_TIME, _PURCHASE_TIME, value);
				this._PURCHASE_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件购买IP地址
		/// </summary>
		public string PURCHASE_IP
		{
			get{ return _PURCHASE_IP; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_IP, _PURCHASE_IP, value);
				this._PURCHASE_IP = value;
			}
		}
		/// <summary>
		/// 招标文件购买浏览器信息
		/// </summary>
		public string PURCHASE_BROWSER
		{
			get{ return _PURCHASE_BROWSER; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_BROWSER, _PURCHASE_BROWSER, value);
				this._PURCHASE_BROWSER = value;
			}
		}
		/// <summary>
		/// 招标文件下载IP地址
		/// </summary>
		public string DOWNLOAD_IP
		{
			get{ return _DOWNLOAD_IP; }
			set
			{
				this.OnPropertyValueChange(_.DOWNLOAD_IP, _DOWNLOAD_IP, value);
				this._DOWNLOAD_IP = value;
			}
		}
		/// <summary>
		/// 招标文件下载浏览器信息
		/// </summary>
		public string DOWNLOAD_BROWSER
		{
			get{ return _DOWNLOAD_BROWSER; }
			set
			{
				this.OnPropertyValueChange(_.DOWNLOAD_BROWSER, _DOWNLOAD_BROWSER, value);
				this._DOWNLOAD_BROWSER = value;
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
				_.PURCHASE_WAY,
				_.PURCHASE_MODE,
				_.PURCHASE_MONEY,
				_.PURCHASE_ORDER_NUMBER,
				_.PURCHASE_ACCOUNT,
				_.PURCHASE_TIME,
				_.PURCHASE_IP,
				_.PURCHASE_BROWSER,
				_.DOWNLOAD_IP,
				_.DOWNLOAD_BROWSER,
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
				this._PURCHASE_WAY,
				this._PURCHASE_MODE,
				this._PURCHASE_MONEY,
				this._PURCHASE_ORDER_NUMBER,
				this._PURCHASE_ACCOUNT,
				this._PURCHASE_TIME,
				this._PURCHASE_IP,
				this._PURCHASE_BROWSER,
				this._DOWNLOAD_IP,
				this._DOWNLOAD_BROWSER,
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
			public readonly static Field All = new Field("*", "ZJ_TENDER_FILE_BUYYER_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_TENDER_FILE_BUYYER_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_TENDER_FILE_BUYYER_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_TENDER_FILE_BUYYER_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_TENDER_FILE_BUYYER_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_TENDER_FILE_BUYYER_INFO", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_TENDER_FILE_BUYYER_INFO", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_TENDER_FILE_BUYYER_INFO", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_TENDER_FILE_BUYYER_INFO", "统一交易标识码");
            /// <summary>
			/// 招标文件购买途径
			/// </summary>
			public readonly static Field PURCHASE_WAY = new Field("PURCHASE_WAY", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买途径");
            /// <summary>
			/// 招标文件购买方式
			/// </summary>
			public readonly static Field PURCHASE_MODE = new Field("PURCHASE_MODE", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买方式");
            /// <summary>
			/// 招标文件购买金额
			/// </summary>
			public readonly static Field PURCHASE_MONEY = new Field("PURCHASE_MONEY", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买金额");
            /// <summary>
			/// 招标文件购买订单号
			/// </summary>
			public readonly static Field PURCHASE_ORDER_NUMBER = new Field("PURCHASE_ORDER_NUMBER", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买订单号");
            /// <summary>
			/// 招标文件购买账号
			/// </summary>
			public readonly static Field PURCHASE_ACCOUNT = new Field("PURCHASE_ACCOUNT", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买账号");
            /// <summary>
			/// 招标文件购买时间
			/// </summary>
			public readonly static Field PURCHASE_TIME = new Field("PURCHASE_TIME", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买时间");
            /// <summary>
			/// 招标文件购买IP地址
			/// </summary>
			public readonly static Field PURCHASE_IP = new Field("PURCHASE_IP", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买IP地址");
            /// <summary>
			/// 招标文件购买浏览器信息
			/// </summary>
			public readonly static Field PURCHASE_BROWSER = new Field("PURCHASE_BROWSER", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件购买浏览器信息");
            /// <summary>
			/// 招标文件下载IP地址
			/// </summary>
			public readonly static Field DOWNLOAD_IP = new Field("DOWNLOAD_IP", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件下载IP地址");
            /// <summary>
			/// 招标文件下载浏览器信息
			/// </summary>
			public readonly static Field DOWNLOAD_BROWSER = new Field("DOWNLOAD_BROWSER", "ZJ_TENDER_FILE_BUYYER_INFO", "招标文件下载浏览器信息");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_TENDER_FILE_BUYYER_INFO", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_TENDER_FILE_BUYYER_INFO", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_TENDER_FILE_BUYYER_INFO", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_TENDER_FILE_BUYYER_INFO", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_TENDER_FILE_BUYYER_INFO", "公共服务平台标识码");
        }
        #endregion
	}
}