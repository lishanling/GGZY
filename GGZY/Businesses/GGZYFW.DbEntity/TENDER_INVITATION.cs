using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_INVITATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_INVITATION")]
    [Serializable]
    public partial class TENDER_INVITATION : FwEntity
    {
        #region Model
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BID_QUALIFICATION;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_CODE;
		private string _BIDDER_ROLE;
		private DateTime? _TENDER_DOC_GET_TIME;
		private string _TENDER_DOC_GET_METHOD;
		private DateTime? _BID_DOC_REFER_END_TIME;
		private string _BID_DOC_REFER_METHOD;
		private DateTime? _BID_INVITE_END_TIME;
		private DateTime? _BID_INVITE_ISSUE_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_CREATOR;
		private string _M_ATT_INVITE_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _TENDER_PROJECT_CODE;
		private string _BID_INVITE_ISSUE_NATURE;
		private string _BID_INVITE_ISSUE_CONTENT;
		private DateTime? _DOC_GET_START_TIME;
		private DateTime? _DOC_GET_END_TIME;
		private string _BULLETIN_DUTY;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 投标资格
		/// </summary>
		public string BID_QUALIFICATION
		{
			get{ return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
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
		public string BIDDER_CODE
		{
			get{ return _BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE, _BIDDER_CODE, value);
				this._BIDDER_CODE = value;
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
		/// 招标文件/资格预审文件获取时间
		/// </summary>
		public DateTime? TENDER_DOC_GET_TIME
		{
			get{ return _TENDER_DOC_GET_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_GET_TIME, _TENDER_DOC_GET_TIME, value);
				this._TENDER_DOC_GET_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件/资格预审文件获取方法
		/// </summary>
		public string TENDER_DOC_GET_METHOD
		{
			get{ return _TENDER_DOC_GET_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_GET_METHOD, _TENDER_DOC_GET_METHOD, value);
				this._TENDER_DOC_GET_METHOD = value;
			}
		}
		/// <summary>
		/// 投标文件/资审申请文件递交截止时间
		/// </summary>
		public DateTime? BID_DOC_REFER_END_TIME
		{
			get{ return _BID_DOC_REFER_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_END_TIME, _BID_DOC_REFER_END_TIME, value);
				this._BID_DOC_REFER_END_TIME = value;
			}
		}
		/// <summary>
		/// 投标文件/资审申请文件递交方法
		/// </summary>
		public string BID_DOC_REFER_METHOD
		{
			get{ return _BID_DOC_REFER_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_METHOD, _BID_DOC_REFER_METHOD, value);
				this._BID_DOC_REFER_METHOD = value;
			}
		}
		/// <summary>
		/// 回复截止时间
		/// </summary>
		public DateTime? BID_INVITE_END_TIME
		{
			get{ return _BID_INVITE_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_INVITE_END_TIME, _BID_INVITE_END_TIME, value);
				this._BID_INVITE_END_TIME = value;
			}
		}
		/// <summary>
		/// 投标邀请发出时间
		/// </summary>
		public DateTime? BID_INVITE_ISSUE_TIME
		{
			get{ return _BID_INVITE_ISSUE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_INVITE_ISSUE_TIME, _BID_INVITE_ISSUE_TIME, value);
				this._BID_INVITE_ISSUE_TIME = value;
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
		/// ID
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
		/// 创建人
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
		/// ?????
		/// </summary>
		public string M_ATT_INVITE_DOC
		{
			get{ return _M_ATT_INVITE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_INVITE_DOC, _M_ATT_INVITE_DOC, value);
				this._M_ATT_INVITE_DOC = value;
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
		/// 投标邀请性质
		/// </summary>
		public string BID_INVITE_ISSUE_NATURE
		{
			get{ return _BID_INVITE_ISSUE_NATURE; }
			set
			{
				this.OnPropertyValueChange(_.BID_INVITE_ISSUE_NATURE, _BID_INVITE_ISSUE_NATURE, value);
				this._BID_INVITE_ISSUE_NATURE = value;
			}
		}
		/// <summary>
		/// 投标邀请内容及变更内容
		/// </summary>
		public string BID_INVITE_ISSUE_CONTENT
		{
			get{ return _BID_INVITE_ISSUE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_INVITE_ISSUE_CONTENT, _BID_INVITE_ISSUE_CONTENT, value);
				this._BID_INVITE_ISSUE_CONTENT = value;
			}
		}
		/// <summary>
		/// 招标文件获取开始时间
		/// </summary>
		public DateTime? DOC_GET_START_TIME
		{
			get{ return _DOC_GET_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_START_TIME, _DOC_GET_START_TIME, value);
				this._DOC_GET_START_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件获取截止时间
		/// </summary>
		public DateTime? DOC_GET_END_TIME
		{
			get{ return _DOC_GET_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_END_TIME, _DOC_GET_END_TIME, value);
				this._DOC_GET_END_TIME = value;
			}
		}
		/// <summary>
		/// 投标邀请发布责任人
		/// </summary>
		public string BULLETIN_DUTY
		{
			get{ return _BULLETIN_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_DUTY, _BULLETIN_DUTY, value);
				this._BULLETIN_DUTY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BID_QUALIFICATION,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_CODE,
				_.BIDDER_ROLE,
				_.TENDER_DOC_GET_TIME,
				_.TENDER_DOC_GET_METHOD,
				_.BID_DOC_REFER_END_TIME,
				_.BID_DOC_REFER_METHOD,
				_.BID_INVITE_END_TIME,
				_.BID_INVITE_ISSUE_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_CREATOR,
				_.M_ATT_INVITE_DOC,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.TENDER_PROJECT_CODE,
				_.BID_INVITE_ISSUE_NATURE,
				_.BID_INVITE_ISSUE_CONTENT,
				_.DOC_GET_START_TIME,
				_.DOC_GET_END_TIME,
				_.BULLETIN_DUTY,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BID_QUALIFICATION,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_CODE,
				this._BIDDER_ROLE,
				this._TENDER_DOC_GET_TIME,
				this._TENDER_DOC_GET_METHOD,
				this._BID_DOC_REFER_END_TIME,
				this._BID_DOC_REFER_METHOD,
				this._BID_INVITE_END_TIME,
				this._BID_INVITE_ISSUE_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_CREATOR,
				this._M_ATT_INVITE_DOC,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._TENDER_PROJECT_CODE,
				this._BID_INVITE_ISSUE_NATURE,
				this._BID_INVITE_ISSUE_CONTENT,
				this._DOC_GET_START_TIME,
				this._DOC_GET_END_TIME,
				this._BULLETIN_DUTY,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "TENDER_INVITATION");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "TENDER_INVITATION", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "TENDER_INVITATION", "统一交易标识码");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "TENDER_INVITATION",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "TENDER_INVITATION", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "TENDER_INVITATION", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_CODE = new Field("BIDDER_CODE", "TENDER_INVITATION", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "TENDER_INVITATION", "投标人角色");
            /// <summary>
			/// 招标文件/资格预审文件获取时间
			/// </summary>
			public readonly static Field TENDER_DOC_GET_TIME = new Field("TENDER_DOC_GET_TIME", "TENDER_INVITATION", "招标文件/资格预审文件获取时间");
            /// <summary>
			/// 招标文件/资格预审文件获取方法
			/// </summary>
			public readonly static Field TENDER_DOC_GET_METHOD = new Field("TENDER_DOC_GET_METHOD", "TENDER_INVITATION",DbType.AnsiString, null, "招标文件/资格预审文件获取方法");
            /// <summary>
			/// 投标文件/资审申请文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "TENDER_INVITATION", "投标文件/资审申请文件递交截止时间");
            /// <summary>
			/// 投标文件/资审申请文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "TENDER_INVITATION",DbType.AnsiString, null, "投标文件/资审申请文件递交方法");
            /// <summary>
			/// 回复截止时间
			/// </summary>
			public readonly static Field BID_INVITE_END_TIME = new Field("BID_INVITE_END_TIME", "TENDER_INVITATION", "回复截止时间");
            /// <summary>
			/// 投标邀请发出时间
			/// </summary>
			public readonly static Field BID_INVITE_ISSUE_TIME = new Field("BID_INVITE_ISSUE_TIME", "TENDER_INVITATION", "投标邀请发出时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TENDER_INVITATION", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TENDER_INVITATION", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TENDER_INVITATION", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TENDER_INVITATION", "");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TENDER_INVITATION", "ID");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "TENDER_INVITATION", "创建人");
            /// <summary>
			/// ?????
			/// </summary>
			public readonly static Field M_ATT_INVITE_DOC = new Field("M_ATT_INVITE_DOC", "TENDER_INVITATION", "?????");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TENDER_INVITATION", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "TENDER_INVITATION", "招标项目编号");
            /// <summary>
			/// 投标邀请性质
			/// </summary>
			public readonly static Field BID_INVITE_ISSUE_NATURE = new Field("BID_INVITE_ISSUE_NATURE", "TENDER_INVITATION", "投标邀请性质");
            /// <summary>
			/// 投标邀请内容及变更内容
			/// </summary>
			public readonly static Field BID_INVITE_ISSUE_CONTENT = new Field("BID_INVITE_ISSUE_CONTENT", "TENDER_INVITATION",DbType.AnsiString, null, "投标邀请内容及变更内容");
            /// <summary>
			/// 招标文件获取开始时间
			/// </summary>
			public readonly static Field DOC_GET_START_TIME = new Field("DOC_GET_START_TIME", "TENDER_INVITATION", "招标文件获取开始时间");
            /// <summary>
			/// 招标文件获取截止时间
			/// </summary>
			public readonly static Field DOC_GET_END_TIME = new Field("DOC_GET_END_TIME", "TENDER_INVITATION", "招标文件获取截止时间");
            /// <summary>
			/// 投标邀请发布责任人
			/// </summary>
			public readonly static Field BULLETIN_DUTY = new Field("BULLETIN_DUTY", "TENDER_INVITATION", "投标邀请发布责任人");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "TENDER_INVITATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "TENDER_INVITATION", "");
        }
        #endregion
	}
}