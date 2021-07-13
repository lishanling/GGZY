using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BIDDER_PERFORMANCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BIDDER_PERFORMANCE")]
    [Serializable]
    public partial class BIDDER_PERFORMANCE : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_ORG_CODE;
		private string _PROJECT_NAME;
		private string _TENDERE_NAME;
		private string _WIN_BIDDER;
		private string _WIN_BIDDER_NOTICE;
		private DateTime? _COMPLETE_TIME;
		private decimal? _BID_AMOUNT;
		private DateTime? _END_TIME;
		private string _EVALUATE;
		private decimal? _CONTRACT_BID_AMOUNT;
		private string _APPROVAL_NUMBER;
		private string _COMMEND_NAME;
		private string _COMMEND_CONTENT;
		private string _UNITY_COMPANY;
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
		/// 业绩项目名称
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
		/// 业绩项目招标人
		/// </summary>
		public string TENDERE_NAME
		{
			get{ return _TENDERE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERE_NAME, _TENDERE_NAME, value);
				this._TENDERE_NAME = value;
			}
		}
		/// <summary>
		/// 业绩项目中标人
		/// </summary>
		public string WIN_BIDDER
		{
			get{ return _WIN_BIDDER; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER, _WIN_BIDDER, value);
				this._WIN_BIDDER = value;
			}
		}
		/// <summary>
		/// 业绩项目中标通知书内容
		/// </summary>
		public string WIN_BIDDER_NOTICE
		{
			get{ return _WIN_BIDDER_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_NOTICE, _WIN_BIDDER_NOTICE, value);
				this._WIN_BIDDER_NOTICE = value;
			}
		}
		/// <summary>
		/// 业绩项目完成时间
		/// </summary>
		public DateTime? COMPLETE_TIME
		{
			get{ return _COMPLETE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLETE_TIME, _COMPLETE_TIME, value);
				this._COMPLETE_TIME = value;
			}
		}
		/// <summary>
		/// 业绩合同金额
		/// </summary>
		public decimal? BID_AMOUNT
		{
			get{ return _BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT, _BID_AMOUNT, value);
				this._BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 业绩竣工时间
		/// </summary>
		public DateTime? END_TIME
		{
			get{ return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
			}
		}
		/// <summary>
		/// 业绩评价
		/// </summary>
		public string EVALUATE
		{
			get{ return _EVALUATE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATE, _EVALUATE, value);
				this._EVALUATE = value;
			}
		}
		/// <summary>
		/// 业绩中标金额
		/// </summary>
		public decimal? CONTRACT_BID_AMOUNT
		{
			get{ return _CONTRACT_BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_BID_AMOUNT, _CONTRACT_BID_AMOUNT, value);
				this._CONTRACT_BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 业绩立项文号
		/// </summary>
		public string APPROVAL_NUMBER
		{
			get{ return _APPROVAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NUMBER, _APPROVAL_NUMBER, value);
				this._APPROVAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 业绩表彰名称
		/// </summary>
		public string COMMEND_NAME
		{
			get{ return _COMMEND_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMMEND_NAME, _COMMEND_NAME, value);
				this._COMMEND_NAME = value;
			}
		}
		/// <summary>
		/// 业绩表彰内容
		/// </summary>
		public string COMMEND_CONTENT
		{
			get{ return _COMMEND_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMMEND_CONTENT, _COMMEND_CONTENT, value);
				this._COMMEND_CONTENT = value;
			}
		}
		/// <summary>
		/// 联合体企业名称
		/// </summary>
		public string UNITY_COMPANY
		{
			get{ return _UNITY_COMPANY; }
			set
			{
				this.OnPropertyValueChange(_.UNITY_COMPANY, _UNITY_COMPANY, value);
				this._UNITY_COMPANY = value;
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_ORG_CODE,
				_.PROJECT_NAME,
				_.TENDERE_NAME,
				_.WIN_BIDDER,
				_.WIN_BIDDER_NOTICE,
				_.COMPLETE_TIME,
				_.BID_AMOUNT,
				_.END_TIME,
				_.EVALUATE,
				_.CONTRACT_BID_AMOUNT,
				_.APPROVAL_NUMBER,
				_.COMMEND_NAME,
				_.COMMEND_CONTENT,
				_.UNITY_COMPANY,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_ORG_CODE,
				this._PROJECT_NAME,
				this._TENDERE_NAME,
				this._WIN_BIDDER,
				this._WIN_BIDDER_NOTICE,
				this._COMPLETE_TIME,
				this._BID_AMOUNT,
				this._END_TIME,
				this._EVALUATE,
				this._CONTRACT_BID_AMOUNT,
				this._APPROVAL_NUMBER,
				this._COMMEND_NAME,
				this._COMMEND_CONTENT,
				this._UNITY_COMPANY,
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
			public readonly static Field All = new Field("*", "BIDDER_PERFORMANCE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BIDDER_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BIDDER_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BIDDER_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BIDDER_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BIDDER_PERFORMANCE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BIDDER_PERFORMANCE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BIDDER_PERFORMANCE", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BIDDER_PERFORMANCE", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BIDDER_PERFORMANCE", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "BIDDER_PERFORMANCE", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "BIDDER_PERFORMANCE", "投标人代码");
            /// <summary>
			/// 业绩项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "BIDDER_PERFORMANCE", "业绩项目名称");
            /// <summary>
			/// 业绩项目招标人
			/// </summary>
			public readonly static Field TENDERE_NAME = new Field("TENDERE_NAME", "BIDDER_PERFORMANCE", "业绩项目招标人");
            /// <summary>
			/// 业绩项目中标人
			/// </summary>
			public readonly static Field WIN_BIDDER = new Field("WIN_BIDDER", "BIDDER_PERFORMANCE", "业绩项目中标人");
            /// <summary>
			/// 业绩项目中标通知书内容
			/// </summary>
			public readonly static Field WIN_BIDDER_NOTICE = new Field("WIN_BIDDER_NOTICE", "BIDDER_PERFORMANCE",DbType.AnsiString, null, "业绩项目中标通知书内容");
            /// <summary>
			/// 业绩项目完成时间
			/// </summary>
			public readonly static Field COMPLETE_TIME = new Field("COMPLETE_TIME", "BIDDER_PERFORMANCE", "业绩项目完成时间");
            /// <summary>
			/// 业绩合同金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "BIDDER_PERFORMANCE", "业绩合同金额");
            /// <summary>
			/// 业绩竣工时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "BIDDER_PERFORMANCE", "业绩竣工时间");
            /// <summary>
			/// 业绩评价
			/// </summary>
			public readonly static Field EVALUATE = new Field("EVALUATE", "BIDDER_PERFORMANCE", "业绩评价");
            /// <summary>
			/// 业绩中标金额
			/// </summary>
			public readonly static Field CONTRACT_BID_AMOUNT = new Field("CONTRACT_BID_AMOUNT", "BIDDER_PERFORMANCE", "业绩中标金额");
            /// <summary>
			/// 业绩立项文号
			/// </summary>
			public readonly static Field APPROVAL_NUMBER = new Field("APPROVAL_NUMBER", "BIDDER_PERFORMANCE", "业绩立项文号");
            /// <summary>
			/// 业绩表彰名称
			/// </summary>
			public readonly static Field COMMEND_NAME = new Field("COMMEND_NAME", "BIDDER_PERFORMANCE", "业绩表彰名称");
            /// <summary>
			/// 业绩表彰内容
			/// </summary>
			public readonly static Field COMMEND_CONTENT = new Field("COMMEND_CONTENT", "BIDDER_PERFORMANCE",DbType.AnsiString, null, "业绩表彰内容");
            /// <summary>
			/// 联合体企业名称
			/// </summary>
			public readonly static Field UNITY_COMPANY = new Field("UNITY_COMPANY", "BIDDER_PERFORMANCE", "联合体企业名称");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BIDDER_PERFORMANCE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BIDDER_PERFORMANCE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BIDDER_PERFORMANCE", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BIDDER_PERFORMANCE", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BIDDER_PERFORMANCE", "公共服务平台标识码");
        }
        #endregion
	}
}