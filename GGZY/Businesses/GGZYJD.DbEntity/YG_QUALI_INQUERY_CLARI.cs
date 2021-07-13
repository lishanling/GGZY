using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YG_QUALI_INQUERY_CLARI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YG_QUALI_INQUERY_CLARI")]
    [Serializable]
    public partial class YG_QUALI_INQUERY_CLARI : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _UNIFIED_DEAL_CODES;
		private string _DOC_CODE;
		private string _DOC_NAME;
		private string _APPLICANT_QUALIFICATIONS;
		private string _APPLICATION_VALID_TIME;
		private DateTime? _DOC_SUBMIT_END_TIME;
		private string _DOC_SUBMIT_METHOD;
		private DateTime? _DOC_OPEN_TIME;
		private string _DOC_OPEN_METHOD;
		private string _EVALUATION_METHOD;
		private string _CLARIFY_CONTENT;
		private string _IS_POSTPONE;
		private DateTime? _POST_OPEN_TIME;
		private string _POST_OPEN_ADDRESS;
		private string _TENDER_CLARIFY_CONTENT;
		private DateTime? _TENDER_SUBMIT_TIME;
		private DateTime? _SUBMIT_TIME;
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
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
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
		/// 文件编号
		/// </summary>
		public string DOC_CODE
		{
			get{ return _DOC_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DOC_CODE, _DOC_CODE, value);
				this._DOC_CODE = value;
			}
		}
		/// <summary>
		/// 文件名称
		/// </summary>
		public string DOC_NAME
		{
			get{ return _DOC_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_NAME, _DOC_NAME, value);
				this._DOC_NAME = value;
			}
		}
		/// <summary>
		/// 申请资格
		/// </summary>
		public string APPLICANT_QUALIFICATIONS
		{
			get{ return _APPLICANT_QUALIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.APPLICANT_QUALIFICATIONS, _APPLICANT_QUALIFICATIONS, value);
				this._APPLICANT_QUALIFICATIONS = value;
			}
		}
		/// <summary>
		/// 申请有效期
		/// </summary>
		public string APPLICATION_VALID_TIME
		{
			get{ return _APPLICATION_VALID_TIME; }
			set
			{
				this.OnPropertyValueChange(_.APPLICATION_VALID_TIME, _APPLICATION_VALID_TIME, value);
				this._APPLICATION_VALID_TIME = value;
			}
		}
		/// <summary>
		/// 申请文件递交截止时间
		/// </summary>
		public DateTime? DOC_SUBMIT_END_TIME
		{
			get{ return _DOC_SUBMIT_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_SUBMIT_END_TIME, _DOC_SUBMIT_END_TIME, value);
				this._DOC_SUBMIT_END_TIME = value;
			}
		}
		/// <summary>
		/// 申请文件递交方法
		/// </summary>
		public string DOC_SUBMIT_METHOD
		{
			get{ return _DOC_SUBMIT_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.DOC_SUBMIT_METHOD, _DOC_SUBMIT_METHOD, value);
				this._DOC_SUBMIT_METHOD = value;
			}
		}
		/// <summary>
		/// 文件开启时间
		/// </summary>
		public DateTime? DOC_OPEN_TIME
		{
			get{ return _DOC_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_OPEN_TIME, _DOC_OPEN_TIME, value);
				this._DOC_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 文件开启方式
		/// </summary>
		public string DOC_OPEN_METHOD
		{
			get{ return _DOC_OPEN_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.DOC_OPEN_METHOD, _DOC_OPEN_METHOD, value);
				this._DOC_OPEN_METHOD = value;
			}
		}
		/// <summary>
		/// 评审办法
		/// </summary>
		public string EVALUATION_METHOD
		{
			get{ return _EVALUATION_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_METHOD, _EVALUATION_METHOD, value);
				this._EVALUATION_METHOD = value;
			}
		}
		/// <summary>
		/// 对文件澄清与修改的主要内容
		/// </summary>
		public string CLARIFY_CONTENT
		{
			get{ return _CLARIFY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_CONTENT, _CLARIFY_CONTENT, value);
				this._CLARIFY_CONTENT = value;
			}
		}
		/// <summary>
		/// 是否延期
		/// </summary>
		public string IS_POSTPONE
		{
			get{ return _IS_POSTPONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_POSTPONE, _IS_POSTPONE, value);
				this._IS_POSTPONE = value;
			}
		}
		/// <summary>
		/// 延期后开标时间
		/// </summary>
		public DateTime? POST_OPEN_TIME
		{
			get{ return _POST_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_TIME, _POST_OPEN_TIME, value);
				this._POST_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 延期后开标地点
		/// </summary>
		public string POST_OPEN_ADDRESS
		{
			get{ return _POST_OPEN_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_ADDRESS, _POST_OPEN_ADDRESS, value);
				this._POST_OPEN_ADDRESS = value;
			}
		}
		/// <summary>
		/// 对资格预审澄清与修改的主要内容
		/// </summary>
		public string TENDER_CLARIFY_CONTENT
		{
			get{ return _TENDER_CLARIFY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CLARIFY_CONTENT, _TENDER_CLARIFY_CONTENT, value);
				this._TENDER_CLARIFY_CONTENT = value;
			}
		}
		/// <summary>
		/// 递交时间
		/// </summary>
		public DateTime? TENDER_SUBMIT_TIME
		{
			get{ return _TENDER_SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_SUBMIT_TIME, _TENDER_SUBMIT_TIME, value);
				this._TENDER_SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 上传时间
		/// </summary>
		public DateTime? SUBMIT_TIME
		{
			get{ return _SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_TIME, _SUBMIT_TIME, value);
				this._SUBMIT_TIME = value;
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
				_.BID_SECTION_CODES,
				_.UNIFIED_DEAL_CODES,
				_.DOC_CODE,
				_.DOC_NAME,
				_.APPLICANT_QUALIFICATIONS,
				_.APPLICATION_VALID_TIME,
				_.DOC_SUBMIT_END_TIME,
				_.DOC_SUBMIT_METHOD,
				_.DOC_OPEN_TIME,
				_.DOC_OPEN_METHOD,
				_.EVALUATION_METHOD,
				_.CLARIFY_CONTENT,
				_.IS_POSTPONE,
				_.POST_OPEN_TIME,
				_.POST_OPEN_ADDRESS,
				_.TENDER_CLARIFY_CONTENT,
				_.TENDER_SUBMIT_TIME,
				_.SUBMIT_TIME,
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
				this._BID_SECTION_CODES,
				this._UNIFIED_DEAL_CODES,
				this._DOC_CODE,
				this._DOC_NAME,
				this._APPLICANT_QUALIFICATIONS,
				this._APPLICATION_VALID_TIME,
				this._DOC_SUBMIT_END_TIME,
				this._DOC_SUBMIT_METHOD,
				this._DOC_OPEN_TIME,
				this._DOC_OPEN_METHOD,
				this._EVALUATION_METHOD,
				this._CLARIFY_CONTENT,
				this._IS_POSTPONE,
				this._POST_OPEN_TIME,
				this._POST_OPEN_ADDRESS,
				this._TENDER_CLARIFY_CONTENT,
				this._TENDER_SUBMIT_TIME,
				this._SUBMIT_TIME,
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
			public readonly static Field All = new Field("*", "YG_QUALI_INQUERY_CLARI");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "YG_QUALI_INQUERY_CLARI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "YG_QUALI_INQUERY_CLARI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "YG_QUALI_INQUERY_CLARI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "YG_QUALI_INQUERY_CLARI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "YG_QUALI_INQUERY_CLARI", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "YG_QUALI_INQUERY_CLARI", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 文件编号
			/// </summary>
			public readonly static Field DOC_CODE = new Field("DOC_CODE", "YG_QUALI_INQUERY_CLARI", "文件编号");
            /// <summary>
			/// 文件名称
			/// </summary>
			public readonly static Field DOC_NAME = new Field("DOC_NAME", "YG_QUALI_INQUERY_CLARI", "文件名称");
            /// <summary>
			/// 申请资格
			/// </summary>
			public readonly static Field APPLICANT_QUALIFICATIONS = new Field("APPLICANT_QUALIFICATIONS", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "申请资格");
            /// <summary>
			/// 申请有效期
			/// </summary>
			public readonly static Field APPLICATION_VALID_TIME = new Field("APPLICATION_VALID_TIME", "YG_QUALI_INQUERY_CLARI", "申请有效期");
            /// <summary>
			/// 申请文件递交截止时间
			/// </summary>
			public readonly static Field DOC_SUBMIT_END_TIME = new Field("DOC_SUBMIT_END_TIME", "YG_QUALI_INQUERY_CLARI", "申请文件递交截止时间");
            /// <summary>
			/// 申请文件递交方法
			/// </summary>
			public readonly static Field DOC_SUBMIT_METHOD = new Field("DOC_SUBMIT_METHOD", "YG_QUALI_INQUERY_CLARI", "申请文件递交方法");
            /// <summary>
			/// 文件开启时间
			/// </summary>
			public readonly static Field DOC_OPEN_TIME = new Field("DOC_OPEN_TIME", "YG_QUALI_INQUERY_CLARI", "文件开启时间");
            /// <summary>
			/// 文件开启方式
			/// </summary>
			public readonly static Field DOC_OPEN_METHOD = new Field("DOC_OPEN_METHOD", "YG_QUALI_INQUERY_CLARI", "文件开启方式");
            /// <summary>
			/// 评审办法
			/// </summary>
			public readonly static Field EVALUATION_METHOD = new Field("EVALUATION_METHOD", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "评审办法");
            /// <summary>
			/// 对文件澄清与修改的主要内容
			/// </summary>
			public readonly static Field CLARIFY_CONTENT = new Field("CLARIFY_CONTENT", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "对文件澄清与修改的主要内容");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "YG_QUALI_INQUERY_CLARI", "是否延期");
            /// <summary>
			/// 延期后开标时间
			/// </summary>
			public readonly static Field POST_OPEN_TIME = new Field("POST_OPEN_TIME", "YG_QUALI_INQUERY_CLARI", "延期后开标时间");
            /// <summary>
			/// 延期后开标地点
			/// </summary>
			public readonly static Field POST_OPEN_ADDRESS = new Field("POST_OPEN_ADDRESS", "YG_QUALI_INQUERY_CLARI", "延期后开标地点");
            /// <summary>
			/// 对资格预审澄清与修改的主要内容
			/// </summary>
			public readonly static Field TENDER_CLARIFY_CONTENT = new Field("TENDER_CLARIFY_CONTENT", "YG_QUALI_INQUERY_CLARI",DbType.AnsiString, null, "对资格预审澄清与修改的主要内容");
            /// <summary>
			/// 递交时间
			/// </summary>
			public readonly static Field TENDER_SUBMIT_TIME = new Field("TENDER_SUBMIT_TIME", "YG_QUALI_INQUERY_CLARI", "递交时间");
            /// <summary>
			/// 上传时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "YG_QUALI_INQUERY_CLARI", "上传时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "YG_QUALI_INQUERY_CLARI", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "YG_QUALI_INQUERY_CLARI", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YG_QUALI_INQUERY_CLARI", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "YG_QUALI_INQUERY_CLARI", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "YG_QUALI_INQUERY_CLARI", "公共服务平台标识码");
        }
        #endregion
	}
}