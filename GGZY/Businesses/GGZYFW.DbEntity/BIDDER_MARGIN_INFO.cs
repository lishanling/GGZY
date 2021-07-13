using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BIDDER_MARGIN_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BIDDER_MARGIN_INFO")]
    [Serializable]
    public partial class BIDDER_MARGIN_INFO : FwEntity
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
		private string _BIDDER_ORG_CODE;
		private string _UNION_ENTERPRISE_NAME;
		private string _UNION_ORGAN_SET_CODE;
		private string _MARGIN_PAY_FORM;
		private DateTime? _MARGIN_RECEIVE_TIME;
		private string _MARGIN_BANK;
		private string _MARGIN_ACCOUNT;
		private decimal? _MARGIN_PAY;
		private string _YEAR_MARGIN;
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
		/// 联合体名称（如有）
		/// </summary>
		public string UNION_ENTERPRISE_NAME
		{
			get{ return _UNION_ENTERPRISE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ENTERPRISE_NAME, _UNION_ENTERPRISE_NAME, value);
				this._UNION_ENTERPRISE_NAME = value;
			}
		}
		/// <summary>
		/// 联合体组织机构代码证（联合体招标时填写）
		/// </summary>
		public string UNION_ORGAN_SET_CODE
		{
			get{ return _UNION_ORGAN_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ORGAN_SET_CODE, _UNION_ORGAN_SET_CODE, value);
				this._UNION_ORGAN_SET_CODE = value;
			}
		}
		/// <summary>
		/// 保证金递交方式
		/// </summary>
		public string MARGIN_PAY_FORM
		{
			get{ return _MARGIN_PAY_FORM; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_FORM, _MARGIN_PAY_FORM, value);
				this._MARGIN_PAY_FORM = value;
			}
		}
		/// <summary>
		/// 保证金递交时间
		/// </summary>
		public DateTime? MARGIN_RECEIVE_TIME
		{
			get{ return _MARGIN_RECEIVE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_RECEIVE_TIME, _MARGIN_RECEIVE_TIME, value);
				this._MARGIN_RECEIVE_TIME = value;
			}
		}
		/// <summary>
		/// 保证金缴纳基本户银行
		/// </summary>
		public string MARGIN_BANK
		{
			get{ return _MARGIN_BANK; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK, _MARGIN_BANK, value);
				this._MARGIN_BANK = value;
			}
		}
		/// <summary>
		/// 保证金缴纳基本户账号
		/// </summary>
		public string MARGIN_ACCOUNT
		{
			get{ return _MARGIN_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_ACCOUNT, _MARGIN_ACCOUNT, value);
				this._MARGIN_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 保证金缴纳金额
		/// </summary>
		public decimal? MARGIN_PAY
		{
			get{ return _MARGIN_PAY; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY, _MARGIN_PAY, value);
				this._MARGIN_PAY = value;
			}
		}
		/// <summary>
		/// 年度保证金信息
		/// </summary>
		public string YEAR_MARGIN
		{
			get{ return _YEAR_MARGIN; }
			set
			{
				this.OnPropertyValueChange(_.YEAR_MARGIN, _YEAR_MARGIN, value);
				this._YEAR_MARGIN = value;
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
				_.BIDDER_ORG_CODE,
				_.UNION_ENTERPRISE_NAME,
				_.UNION_ORGAN_SET_CODE,
				_.MARGIN_PAY_FORM,
				_.MARGIN_RECEIVE_TIME,
				_.MARGIN_BANK,
				_.MARGIN_ACCOUNT,
				_.MARGIN_PAY,
				_.YEAR_MARGIN,
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
				this._BIDDER_ORG_CODE,
				this._UNION_ENTERPRISE_NAME,
				this._UNION_ORGAN_SET_CODE,
				this._MARGIN_PAY_FORM,
				this._MARGIN_RECEIVE_TIME,
				this._MARGIN_BANK,
				this._MARGIN_ACCOUNT,
				this._MARGIN_PAY,
				this._YEAR_MARGIN,
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
			public readonly static Field All = new Field("*", "BIDDER_MARGIN_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BIDDER_MARGIN_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BIDDER_MARGIN_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BIDDER_MARGIN_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BIDDER_MARGIN_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BIDDER_MARGIN_INFO", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BIDDER_MARGIN_INFO", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BIDDER_MARGIN_INFO", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BIDDER_MARGIN_INFO", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BIDDER_MARGIN_INFO", "投标人名称");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "BIDDER_MARGIN_INFO", "投标人代码");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "BIDDER_MARGIN_INFO", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "BIDDER_MARGIN_INFO", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 保证金递交方式
			/// </summary>
			public readonly static Field MARGIN_PAY_FORM = new Field("MARGIN_PAY_FORM", "BIDDER_MARGIN_INFO", "保证金递交方式");
            /// <summary>
			/// 保证金递交时间
			/// </summary>
			public readonly static Field MARGIN_RECEIVE_TIME = new Field("MARGIN_RECEIVE_TIME", "BIDDER_MARGIN_INFO", "保证金递交时间");
            /// <summary>
			/// 保证金缴纳基本户银行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "BIDDER_MARGIN_INFO", "保证金缴纳基本户银行");
            /// <summary>
			/// 保证金缴纳基本户账号
			/// </summary>
			public readonly static Field MARGIN_ACCOUNT = new Field("MARGIN_ACCOUNT", "BIDDER_MARGIN_INFO", "保证金缴纳基本户账号");
            /// <summary>
			/// 保证金缴纳金额
			/// </summary>
			public readonly static Field MARGIN_PAY = new Field("MARGIN_PAY", "BIDDER_MARGIN_INFO", "保证金缴纳金额");
            /// <summary>
			/// 年度保证金信息
			/// </summary>
			public readonly static Field YEAR_MARGIN = new Field("YEAR_MARGIN", "BIDDER_MARGIN_INFO", "年度保证金信息");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BIDDER_MARGIN_INFO", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BIDDER_MARGIN_INFO", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BIDDER_MARGIN_INFO", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BIDDER_MARGIN_INFO", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BIDDER_MARGIN_INFO", "公共服务平台标识码");
        }
        #endregion
	}
}