using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类COMPLAINT_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("COMPLAINT_INFO")]
    [Serializable]
    public partial class COMPLAINT_INFO : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _COMPLAINT_NAME;
		private string _COMPLAINT_PHONE;
		private string _COMPLAINT_MAIL;
		private string _COMPLAINTED_BODY_NAME;
		private string _COMPLAINTED_BODY_TYPE;
		private string _COMPLAINTED_BODY_CODE;
		private string _DISSENT_REASON;
		private string _COMPLAINT_CONTENT;
		private DateTime? _COMPLAINT_DATE;
		private DateTime? _ACCEPT_DATE;
		private string _HANDLE_RESULT;
		private string _HANDLE_BASIS;
		private DateTime? _HANDLE_DATE;
		private string _CONFINED_ACTION;
		private DateTime? _START_DATE;
		private DateTime? _END_DATE;
		private string _DEALING_UNIT;
		private string _ENTER_CREDIT_PLAT;
		private string _SIGNATURE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 招标项目（采购项目）名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）编号
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
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
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
		/// 投诉者姓名
		/// </summary>
		public string COMPLAINT_NAME
		{
			get{ return _COMPLAINT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_NAME, _COMPLAINT_NAME, value);
				this._COMPLAINT_NAME = value;
			}
		}
		/// <summary>
		/// 投诉者电话
		/// </summary>
		public string COMPLAINT_PHONE
		{
			get{ return _COMPLAINT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_PHONE, _COMPLAINT_PHONE, value);
				this._COMPLAINT_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉者邮箱
		/// </summary>
		public string COMPLAINT_MAIL
		{
			get{ return _COMPLAINT_MAIL; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_MAIL, _COMPLAINT_MAIL, value);
				this._COMPLAINT_MAIL = value;
			}
		}
		/// <summary>
		/// 被投诉主体名称
		/// </summary>
		public string COMPLAINTED_BODY_NAME
		{
			get{ return _COMPLAINTED_BODY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_BODY_NAME, _COMPLAINTED_BODY_NAME, value);
				this._COMPLAINTED_BODY_NAME = value;
			}
		}
		/// <summary>
		/// 被投诉者类别
		/// </summary>
		public string COMPLAINTED_BODY_TYPE
		{
			get{ return _COMPLAINTED_BODY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_BODY_TYPE, _COMPLAINTED_BODY_TYPE, value);
				this._COMPLAINTED_BODY_TYPE = value;
			}
		}
		/// <summary>
		/// 被投诉主体代码
		/// </summary>
		public string COMPLAINTED_BODY_CODE
		{
			get{ return _COMPLAINTED_BODY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_BODY_CODE, _COMPLAINTED_BODY_CODE, value);
				this._COMPLAINTED_BODY_CODE = value;
			}
		}
		/// <summary>
		/// 依据和理由
		/// </summary>
		public string DISSENT_REASON
		{
			get{ return _DISSENT_REASON; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_REASON, _DISSENT_REASON, value);
				this._DISSENT_REASON = value;
			}
		}
		/// <summary>
		/// 投诉内容
		/// </summary>
		public string COMPLAINT_CONTENT
		{
			get{ return _COMPLAINT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTENT, _COMPLAINT_CONTENT, value);
				this._COMPLAINT_CONTENT = value;
			}
		}
		/// <summary>
		/// 投诉日期
		/// </summary>
		public DateTime? COMPLAINT_DATE
		{
			get{ return _COMPLAINT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_DATE, _COMPLAINT_DATE, value);
				this._COMPLAINT_DATE = value;
			}
		}
		/// <summary>
		/// 受理日期
		/// </summary>
		public DateTime? ACCEPT_DATE
		{
			get{ return _ACCEPT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_DATE, _ACCEPT_DATE, value);
				this._ACCEPT_DATE = value;
			}
		}
		/// <summary>
		/// 处理结果
		/// </summary>
		public string HANDLE_RESULT
		{
			get{ return _HANDLE_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_RESULT, _HANDLE_RESULT, value);
				this._HANDLE_RESULT = value;
			}
		}
		/// <summary>
		/// 处理依据
		/// </summary>
		public string HANDLE_BASIS
		{
			get{ return _HANDLE_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_BASIS, _HANDLE_BASIS, value);
				this._HANDLE_BASIS = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? HANDLE_DATE
		{
			get{ return _HANDLE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_DATE, _HANDLE_DATE, value);
				this._HANDLE_DATE = value;
			}
		}
		/// <summary>
		/// 限制的行为
		/// </summary>
		public string CONFINED_ACTION
		{
			get{ return _CONFINED_ACTION; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_ACTION, _CONFINED_ACTION, value);
				this._CONFINED_ACTION = value;
			}
		}
		/// <summary>
		/// 限制行为开始时间
		/// </summary>
		public DateTime? START_DATE
		{
			get{ return _START_DATE; }
			set
			{
				this.OnPropertyValueChange(_.START_DATE, _START_DATE, value);
				this._START_DATE = value;
			}
		}
		/// <summary>
		/// 限制行为结束时间
		/// </summary>
		public DateTime? END_DATE
		{
			get{ return _END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.END_DATE, _END_DATE, value);
				this._END_DATE = value;
			}
		}
		/// <summary>
		/// 处理单位
		/// </summary>
		public string DEALING_UNIT
		{
			get{ return _DEALING_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.DEALING_UNIT, _DEALING_UNIT, value);
				this._DEALING_UNIT = value;
			}
		}
		/// <summary>
		/// 处理结果是否进入信用平台
		/// </summary>
		public string ENTER_CREDIT_PLAT
		{
			get{ return _ENTER_CREDIT_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.ENTER_CREDIT_PLAT, _ENTER_CREDIT_PLAT, value);
				this._ENTER_CREDIT_PLAT = value;
			}
		}
		/// <summary>
		/// 处理人电子签名
		/// </summary>
		public string SIGNATURE
		{
			get{ return _SIGNATURE; }
			set
			{
				this.OnPropertyValueChange(_.SIGNATURE, _SIGNATURE, value);
				this._SIGNATURE = value;
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
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.COMPLAINT_NAME,
				_.COMPLAINT_PHONE,
				_.COMPLAINT_MAIL,
				_.COMPLAINTED_BODY_NAME,
				_.COMPLAINTED_BODY_TYPE,
				_.COMPLAINTED_BODY_CODE,
				_.DISSENT_REASON,
				_.COMPLAINT_CONTENT,
				_.COMPLAINT_DATE,
				_.ACCEPT_DATE,
				_.HANDLE_RESULT,
				_.HANDLE_BASIS,
				_.HANDLE_DATE,
				_.CONFINED_ACTION,
				_.START_DATE,
				_.END_DATE,
				_.DEALING_UNIT,
				_.ENTER_CREDIT_PLAT,
				_.SIGNATURE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._COMPLAINT_NAME,
				this._COMPLAINT_PHONE,
				this._COMPLAINT_MAIL,
				this._COMPLAINTED_BODY_NAME,
				this._COMPLAINTED_BODY_TYPE,
				this._COMPLAINTED_BODY_CODE,
				this._DISSENT_REASON,
				this._COMPLAINT_CONTENT,
				this._COMPLAINT_DATE,
				this._ACCEPT_DATE,
				this._HANDLE_RESULT,
				this._HANDLE_BASIS,
				this._HANDLE_DATE,
				this._CONFINED_ACTION,
				this._START_DATE,
				this._END_DATE,
				this._DEALING_UNIT,
				this._ENTER_CREDIT_PLAT,
				this._SIGNATURE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "COMPLAINT_INFO");
            /// <summary>
			/// 招标项目（采购项目）名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "COMPLAINT_INFO", "招标项目（采购项目）名称");
            /// <summary>
			/// 招标项目（采购项目）编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "COMPLAINT_INFO", "招标项目（采购项目）编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "COMPLAINT_INFO", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "COMPLAINT_INFO", "标段（包）名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "COMPLAINT_INFO", "统一交易标识码");
            /// <summary>
			/// 投诉者姓名
			/// </summary>
			public readonly static Field COMPLAINT_NAME = new Field("COMPLAINT_NAME", "COMPLAINT_INFO", "投诉者姓名");
            /// <summary>
			/// 投诉者电话
			/// </summary>
			public readonly static Field COMPLAINT_PHONE = new Field("COMPLAINT_PHONE", "COMPLAINT_INFO", "投诉者电话");
            /// <summary>
			/// 投诉者邮箱
			/// </summary>
			public readonly static Field COMPLAINT_MAIL = new Field("COMPLAINT_MAIL", "COMPLAINT_INFO", "投诉者邮箱");
            /// <summary>
			/// 被投诉主体名称
			/// </summary>
			public readonly static Field COMPLAINTED_BODY_NAME = new Field("COMPLAINTED_BODY_NAME", "COMPLAINT_INFO", "被投诉主体名称");
            /// <summary>
			/// 被投诉者类别
			/// </summary>
			public readonly static Field COMPLAINTED_BODY_TYPE = new Field("COMPLAINTED_BODY_TYPE", "COMPLAINT_INFO", "被投诉者类别");
            /// <summary>
			/// 被投诉主体代码
			/// </summary>
			public readonly static Field COMPLAINTED_BODY_CODE = new Field("COMPLAINTED_BODY_CODE", "COMPLAINT_INFO", "被投诉主体代码");
            /// <summary>
			/// 依据和理由
			/// </summary>
			public readonly static Field DISSENT_REASON = new Field("DISSENT_REASON", "COMPLAINT_INFO",DbType.AnsiString, null, "依据和理由");
            /// <summary>
			/// 投诉内容
			/// </summary>
			public readonly static Field COMPLAINT_CONTENT = new Field("COMPLAINT_CONTENT", "COMPLAINT_INFO",DbType.AnsiString, null, "投诉内容");
            /// <summary>
			/// 投诉日期
			/// </summary>
			public readonly static Field COMPLAINT_DATE = new Field("COMPLAINT_DATE", "COMPLAINT_INFO", "投诉日期");
            /// <summary>
			/// 受理日期
			/// </summary>
			public readonly static Field ACCEPT_DATE = new Field("ACCEPT_DATE", "COMPLAINT_INFO", "受理日期");
            /// <summary>
			/// 处理结果
			/// </summary>
			public readonly static Field HANDLE_RESULT = new Field("HANDLE_RESULT", "COMPLAINT_INFO",DbType.AnsiString, null, "处理结果");
            /// <summary>
			/// 处理依据
			/// </summary>
			public readonly static Field HANDLE_BASIS = new Field("HANDLE_BASIS", "COMPLAINT_INFO",DbType.AnsiString, null, "处理依据");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field HANDLE_DATE = new Field("HANDLE_DATE", "COMPLAINT_INFO", "处理时间");
            /// <summary>
			/// 限制的行为
			/// </summary>
			public readonly static Field CONFINED_ACTION = new Field("CONFINED_ACTION", "COMPLAINT_INFO", "限制的行为");
            /// <summary>
			/// 限制行为开始时间
			/// </summary>
			public readonly static Field START_DATE = new Field("START_DATE", "COMPLAINT_INFO", "限制行为开始时间");
            /// <summary>
			/// 限制行为结束时间
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "COMPLAINT_INFO", "限制行为结束时间");
            /// <summary>
			/// 处理单位
			/// </summary>
			public readonly static Field DEALING_UNIT = new Field("DEALING_UNIT", "COMPLAINT_INFO", "处理单位");
            /// <summary>
			/// 处理结果是否进入信用平台
			/// </summary>
			public readonly static Field ENTER_CREDIT_PLAT = new Field("ENTER_CREDIT_PLAT", "COMPLAINT_INFO", "处理结果是否进入信用平台");
            /// <summary>
			/// 处理人电子签名
			/// </summary>
			public readonly static Field SIGNATURE = new Field("SIGNATURE", "COMPLAINT_INFO",DbType.AnsiString, null, "处理人电子签名");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "COMPLAINT_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "COMPLAINT_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "COMPLAINT_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "COMPLAINT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "COMPLAINT_INFO", "");
        }
        #endregion
	}
}