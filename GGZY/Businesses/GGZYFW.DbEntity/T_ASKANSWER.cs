using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ASKANSWER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ASKANSWER")]
    [Serializable]
    public partial class T_ASKANSWER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _ANN_ID;
		private decimal? _TYPE;
		private DateTime? _TM;
		private decimal? _ASK_USERID;
		private decimal? _ANSWER_USERID;
		private DateTime? _ANSWER_TM;
		private decimal? _RETURN;
		private string _ASK_ZY_REASON;
		private string _ASK;
		private string _ANSWER;
		private string _TITLE;
		private decimal? _ZP_ID;
		private decimal? _IS_GS;
		private string _ANN_CODE;
		private string _TENDERER_CODE;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _NOTICE_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 公告ID
		/// </summary>
		public decimal? ANN_ID
		{
			get{ return _ANN_ID; }
			set
			{
				this.OnPropertyValueChange(_.ANN_ID, _ANN_ID, value);
				this._ANN_ID = value;
			}
		}
		/// <summary>
		/// 类型 sys_dic type:9001
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 咨询质疑时间
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 咨询用户
		/// </summary>
		public decimal? ASK_USERID
		{
			get{ return _ASK_USERID; }
			set
			{
				this.OnPropertyValueChange(_.ASK_USERID, _ASK_USERID, value);
				this._ASK_USERID = value;
			}
		}
		/// <summary>
		/// 回复用户
		/// </summary>
		public decimal? ANSWER_USERID
		{
			get{ return _ANSWER_USERID; }
			set
			{
				this.OnPropertyValueChange(_.ANSWER_USERID, _ANSWER_USERID, value);
				this._ANSWER_USERID = value;
			}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? ANSWER_TM
		{
			get{ return _ANSWER_TM; }
			set
			{
				this.OnPropertyValueChange(_.ANSWER_TM, _ANSWER_TM, value);
				this._ANSWER_TM = value;
			}
		}
		/// <summary>
		/// 是否回复--用于列表下拉框查询   sys_dic 9002
		/// </summary>
		public decimal? RETURN
		{
			get{ return _RETURN; }
			set
			{
				this.OnPropertyValueChange(_.RETURN, _RETURN, value);
				this._RETURN = value;
			}
		}
		/// <summary>
		/// 质疑理由
		/// </summary>
		public string ASK_ZY_REASON
		{
			get{ return _ASK_ZY_REASON; }
			set
			{
				this.OnPropertyValueChange(_.ASK_ZY_REASON, _ASK_ZY_REASON, value);
				this._ASK_ZY_REASON = value;
			}
		}
		/// <summary>
		/// 咨询质疑内容
		/// </summary>
		public string ASK
		{
			get{ return _ASK; }
			set
			{
				this.OnPropertyValueChange(_.ASK, _ASK, value);
				this._ASK = value;
			}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string ANSWER
		{
			get{ return _ANSWER; }
			set
			{
				this.OnPropertyValueChange(_.ANSWER, _ANSWER, value);
				this._ANSWER = value;
			}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 从招标采购网 同步的质疑信息
		/// </summary>
		public decimal? ZP_ID
		{
			get{ return _ZP_ID; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ID, _ZP_ID, value);
				this._ZP_ID = value;
			}
		}
		/// <summary>
		/// 是否公示到首页
		/// </summary>
		public decimal? IS_GS
		{
			get{ return _IS_GS; }
			set
			{
				this.OnPropertyValueChange(_.IS_GS, _IS_GS, value);
				this._IS_GS = value;
			}
		}
		/// <summary>
		/// 质疑编号
		/// </summary>
		public string ANN_CODE
		{
			get{ return _ANN_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ANN_CODE, _ANN_CODE, value);
				this._ANN_CODE = value;
			}
		}
		/// <summary>
		/// 招标公告编号
		/// </summary>
		public string TENDERER_CODE
		{
			get{ return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
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
		/// 招标公告名称
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.ANN_ID,
				_.TYPE,
				_.TM,
				_.ASK_USERID,
				_.ANSWER_USERID,
				_.ANSWER_TM,
				_.RETURN,
				_.ASK_ZY_REASON,
				_.ASK,
				_.ANSWER,
				_.TITLE,
				_.ZP_ID,
				_.IS_GS,
				_.ANN_CODE,
				_.TENDERER_CODE,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.NOTICE_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODES,
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
				this._ID,
				this._ANN_ID,
				this._TYPE,
				this._TM,
				this._ASK_USERID,
				this._ANSWER_USERID,
				this._ANSWER_TM,
				this._RETURN,
				this._ASK_ZY_REASON,
				this._ASK,
				this._ANSWER,
				this._TITLE,
				this._ZP_ID,
				this._IS_GS,
				this._ANN_CODE,
				this._TENDERER_CODE,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._NOTICE_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODES,
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
			public readonly static Field All = new Field("*", "T_ASKANSWER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ASKANSWER", "ID");
            /// <summary>
			/// 公告ID
			/// </summary>
			public readonly static Field ANN_ID = new Field("ANN_ID", "T_ASKANSWER", "公告ID");
            /// <summary>
			/// 类型 sys_dic type:9001
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_ASKANSWER", "类型 sys_dic type:9001");
            /// <summary>
			/// 咨询质疑时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_ASKANSWER", "咨询质疑时间");
            /// <summary>
			/// 咨询用户
			/// </summary>
			public readonly static Field ASK_USERID = new Field("ASK_USERID", "T_ASKANSWER", "咨询用户");
            /// <summary>
			/// 回复用户
			/// </summary>
			public readonly static Field ANSWER_USERID = new Field("ANSWER_USERID", "T_ASKANSWER", "回复用户");
            /// <summary>
			/// 回复时间
			/// </summary>
			public readonly static Field ANSWER_TM = new Field("ANSWER_TM", "T_ASKANSWER", "回复时间");
            /// <summary>
			/// 是否回复--用于列表下拉框查询   sys_dic 9002
			/// </summary>
			public readonly static Field RETURN = new Field("RETURN", "T_ASKANSWER", "是否回复--用于列表下拉框查询   sys_dic 9002");
            /// <summary>
			/// 质疑理由
			/// </summary>
			public readonly static Field ASK_ZY_REASON = new Field("ASK_ZY_REASON", "T_ASKANSWER", "质疑理由");
            /// <summary>
			/// 咨询质疑内容
			/// </summary>
			public readonly static Field ASK = new Field("ASK", "T_ASKANSWER",DbType.AnsiString, null, "咨询质疑内容");
            /// <summary>
			/// 回复内容
			/// </summary>
			public readonly static Field ANSWER = new Field("ANSWER", "T_ASKANSWER",DbType.AnsiString, null, "回复内容");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_ASKANSWER", "标题");
            /// <summary>
			/// 从招标采购网 同步的质疑信息
			/// </summary>
			public readonly static Field ZP_ID = new Field("ZP_ID", "T_ASKANSWER", "从招标采购网 同步的质疑信息");
            /// <summary>
			/// 是否公示到首页
			/// </summary>
			public readonly static Field IS_GS = new Field("IS_GS", "T_ASKANSWER", "是否公示到首页");
            /// <summary>
			/// 质疑编号
			/// </summary>
			public readonly static Field ANN_CODE = new Field("ANN_CODE", "T_ASKANSWER", "质疑编号");
            /// <summary>
			/// 招标公告编号
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "T_ASKANSWER", "招标公告编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "T_ASKANSWER", "");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_ASKANSWER", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "T_ASKANSWER", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "T_ASKANSWER", "数据时间戳");
            /// <summary>
			/// 招标公告名称
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "T_ASKANSWER", "招标公告名称");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_ASKANSWER", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "T_ASKANSWER",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "T_ASKANSWER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "T_ASKANSWER", "");
        }
        #endregion
	}
}