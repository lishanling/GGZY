using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_BID_DOC_CHARACT_CODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_BID_DOC_CHARACT_CODE")]
    [Serializable]
    public partial class XX_BID_DOC_CHARACT_CODE : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODES;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_ROLE;
		private string _BID_DOCUMENT_NAME;
		private string _BID_DOCUMENT_SIDE;
		private string _BID_DOCUMENT_MD5;
		private DateTime? _TENDER_DOC_SUBMITTIME;
		private string _CPU_ID;
		private string _HARD_DISK_SERIAL_NUMBER;
		private string _MEMORY_SERIAL_NUMBER;
		private string _NET_ID;
		private string _MAC_ADDRESS;
		private string _TENDER_DOCUMENTS_URL;
		private string _VALUATION_XML;
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
		/// 相关统一交易标识码
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
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人类别
		/// </summary>
		public string BIDDER_CODE_TYPE
		{
			get{ return _BIDDER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE_TYPE, _BIDDER_CODE_TYPE, value);
				this._BIDDER_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get{ return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 投标人角色
		/// </summary>
		public string BIDDER_ROLE
		{
			get{ return _BIDDER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ROLE, _BIDDER_ROLE, value);
				this._BIDDER_ROLE = value;
			}
		}
		/// <summary>
		/// 投标文件名称
		/// </summary>
		public string BID_DOCUMENT_NAME
		{
			get{ return _BID_DOCUMENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOCUMENT_NAME, _BID_DOCUMENT_NAME, value);
				this._BID_DOCUMENT_NAME = value;
			}
		}
		/// <summary>
		/// 投标文件大小
		/// </summary>
		public string BID_DOCUMENT_SIDE
		{
			get{ return _BID_DOCUMENT_SIDE; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOCUMENT_SIDE, _BID_DOCUMENT_SIDE, value);
				this._BID_DOCUMENT_SIDE = value;
			}
		}
		/// <summary>
		/// 投标文件MD5码
		/// </summary>
		public string BID_DOCUMENT_MD5
		{
			get{ return _BID_DOCUMENT_MD5; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOCUMENT_MD5, _BID_DOCUMENT_MD5, value);
				this._BID_DOCUMENT_MD5 = value;
			}
		}
		/// <summary>
		/// 投标文件提交时间
		/// </summary>
		public DateTime? TENDER_DOC_SUBMITTIME
		{
			get{ return _TENDER_DOC_SUBMITTIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_SUBMITTIME, _TENDER_DOC_SUBMITTIME, value);
				this._TENDER_DOC_SUBMITTIME = value;
			}
		}
		/// <summary>
		/// CPU序列号
		/// </summary>
		public string CPU_ID
		{
			get{ return _CPU_ID; }
			set
			{
				this.OnPropertyValueChange(_.CPU_ID, _CPU_ID, value);
				this._CPU_ID = value;
			}
		}
		/// <summary>
		/// 硬盘序列号
		/// </summary>
		public string HARD_DISK_SERIAL_NUMBER
		{
			get{ return _HARD_DISK_SERIAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.HARD_DISK_SERIAL_NUMBER, _HARD_DISK_SERIAL_NUMBER, value);
				this._HARD_DISK_SERIAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 内存序列号
		/// </summary>
		public string MEMORY_SERIAL_NUMBER
		{
			get{ return _MEMORY_SERIAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.MEMORY_SERIAL_NUMBER, _MEMORY_SERIAL_NUMBER, value);
				this._MEMORY_SERIAL_NUMBER = value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string NET_ID
		{
			get{ return _NET_ID; }
			set
			{
				this.OnPropertyValueChange(_.NET_ID, _NET_ID, value);
				this._NET_ID = value;
			}
		}
		/// <summary>
		/// 网卡MAC地址
		/// </summary>
		public string MAC_ADDRESS
		{
			get{ return _MAC_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.MAC_ADDRESS, _MAC_ADDRESS, value);
				this._MAC_ADDRESS = value;
			}
		}
		/// <summary>
		/// 投标文件URL
		/// </summary>
		public string TENDER_DOCUMENTS_URL
		{
			get{ return _TENDER_DOCUMENTS_URL; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOCUMENTS_URL, _TENDER_DOCUMENTS_URL, value);
				this._TENDER_DOCUMENTS_URL = value;
			}
		}
		/// <summary>
		/// 计价软硬件信息xml
		/// </summary>
		public string VALUATION_XML
		{
			get{ return _VALUATION_XML; }
			set
			{
				this.OnPropertyValueChange(_.VALUATION_XML, _VALUATION_XML, value);
				this._VALUATION_XML = value;
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
				_.UNIFIED_DEAL_CODES,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_ORG_CODE,
				_.BIDDER_ROLE,
				_.BID_DOCUMENT_NAME,
				_.BID_DOCUMENT_SIDE,
				_.BID_DOCUMENT_MD5,
				_.TENDER_DOC_SUBMITTIME,
				_.CPU_ID,
				_.HARD_DISK_SERIAL_NUMBER,
				_.MEMORY_SERIAL_NUMBER,
				_.NET_ID,
				_.MAC_ADDRESS,
				_.TENDER_DOCUMENTS_URL,
				_.VALUATION_XML,
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
				this._UNIFIED_DEAL_CODES,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_ORG_CODE,
				this._BIDDER_ROLE,
				this._BID_DOCUMENT_NAME,
				this._BID_DOCUMENT_SIDE,
				this._BID_DOCUMENT_MD5,
				this._TENDER_DOC_SUBMITTIME,
				this._CPU_ID,
				this._HARD_DISK_SERIAL_NUMBER,
				this._MEMORY_SERIAL_NUMBER,
				this._NET_ID,
				this._MAC_ADDRESS,
				this._TENDER_DOCUMENTS_URL,
				this._VALUATION_XML,
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
			public readonly static Field All = new Field("*", "XX_BID_DOC_CHARACT_CODE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_BID_DOC_CHARACT_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_BID_DOC_CHARACT_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_BID_DOC_CHARACT_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_BID_DOC_CHARACT_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_BID_DOC_CHARACT_CODE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_BID_DOC_CHARACT_CODE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "XX_BID_DOC_CHARACT_CODE", "标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "XX_BID_DOC_CHARACT_CODE",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "XX_BID_DOC_CHARACT_CODE", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "XX_BID_DOC_CHARACT_CODE", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "XX_BID_DOC_CHARACT_CODE", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "XX_BID_DOC_CHARACT_CODE", "投标人角色");
            /// <summary>
			/// 投标文件名称
			/// </summary>
			public readonly static Field BID_DOCUMENT_NAME = new Field("BID_DOCUMENT_NAME", "XX_BID_DOC_CHARACT_CODE", "投标文件名称");
            /// <summary>
			/// 投标文件大小
			/// </summary>
			public readonly static Field BID_DOCUMENT_SIDE = new Field("BID_DOCUMENT_SIDE", "XX_BID_DOC_CHARACT_CODE", "投标文件大小");
            /// <summary>
			/// 投标文件MD5码
			/// </summary>
			public readonly static Field BID_DOCUMENT_MD5 = new Field("BID_DOCUMENT_MD5", "XX_BID_DOC_CHARACT_CODE", "投标文件MD5码");
            /// <summary>
			/// 投标文件提交时间
			/// </summary>
			public readonly static Field TENDER_DOC_SUBMITTIME = new Field("TENDER_DOC_SUBMITTIME", "XX_BID_DOC_CHARACT_CODE", "投标文件提交时间");
            /// <summary>
			/// CPU序列号
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "XX_BID_DOC_CHARACT_CODE", "CPU序列号");
            /// <summary>
			/// 硬盘序列号
			/// </summary>
			public readonly static Field HARD_DISK_SERIAL_NUMBER = new Field("HARD_DISK_SERIAL_NUMBER", "XX_BID_DOC_CHARACT_CODE", "硬盘序列号");
            /// <summary>
			/// 内存序列号
			/// </summary>
			public readonly static Field MEMORY_SERIAL_NUMBER = new Field("MEMORY_SERIAL_NUMBER", "XX_BID_DOC_CHARACT_CODE", "内存序列号");
            /// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field NET_ID = new Field("NET_ID", "XX_BID_DOC_CHARACT_CODE", "IP地址");
            /// <summary>
			/// 网卡MAC地址
			/// </summary>
			public readonly static Field MAC_ADDRESS = new Field("MAC_ADDRESS", "XX_BID_DOC_CHARACT_CODE", "网卡MAC地址");
            /// <summary>
			/// 投标文件URL
			/// </summary>
			public readonly static Field TENDER_DOCUMENTS_URL = new Field("TENDER_DOCUMENTS_URL", "XX_BID_DOC_CHARACT_CODE", "投标文件URL");
            /// <summary>
			/// 计价软硬件信息xml
			/// </summary>
			public readonly static Field VALUATION_XML = new Field("VALUATION_XML", "XX_BID_DOC_CHARACT_CODE",DbType.AnsiString, null, "计价软硬件信息xml");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_BID_DOC_CHARACT_CODE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_BID_DOC_CHARACT_CODE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_BID_DOC_CHARACT_CODE", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_BID_DOC_CHARACT_CODE", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_BID_DOC_CHARACT_CODE", "公共服务平台标识码");
        }
        #endregion
	}
}