using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_SMS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SMS_LOG")]
    [Serializable]
    public partial class T_SMS_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSNAME;
		private string _TEL_PHONE;
		private string _SMS_CONTENT;
		private string _STATUS;
		private DateTime? _SEND_TM;
		private string _SMS_PLATFORM;
		private string _RESPONSE_TEXT;
		private decimal? _OPER_BY;
		private string _IP;

		/// <summary>
		/// 
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
		/// 系统名称
		/// </summary>
		public string SYSNAME
		{
			get{ return _SYSNAME; }
			set
			{
				this.OnPropertyValueChange(_.SYSNAME, _SYSNAME, value);
				this._SYSNAME = value;
			}
		}
		/// <summary>
		/// 电话号码
		/// </summary>
		public string TEL_PHONE
		{
			get{ return _TEL_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TEL_PHONE, _TEL_PHONE, value);
				this._TEL_PHONE = value;
			}
		}
		/// <summary>
		/// 短信内容
		/// </summary>
		public string SMS_CONTENT
		{
			get{ return _SMS_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.SMS_CONTENT, _SMS_CONTENT, value);
				this._SMS_CONTENT = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime? SEND_TM
		{
			get{ return _SEND_TM; }
			set
			{
				this.OnPropertyValueChange(_.SEND_TM, _SEND_TM, value);
				this._SEND_TM = value;
			}
		}
		/// <summary>
		/// 短信平台
		/// </summary>
		public string SMS_PLATFORM
		{
			get{ return _SMS_PLATFORM; }
			set
			{
				this.OnPropertyValueChange(_.SMS_PLATFORM, _SMS_PLATFORM, value);
				this._SMS_PLATFORM = value;
			}
		}
		/// <summary>
		/// 返回值
		/// </summary>
		public string RESPONSE_TEXT
		{
			get{ return _RESPONSE_TEXT; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_TEXT, _RESPONSE_TEXT, value);
				this._RESPONSE_TEXT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OPER_BY
		{
			get{ return _OPER_BY; }
			set
			{
				this.OnPropertyValueChange(_.OPER_BY, _OPER_BY, value);
				this._OPER_BY = value;
			}
		}
		/// <summary>
		/// 发送人IP
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
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
				_.SYSNAME,
				_.TEL_PHONE,
				_.SMS_CONTENT,
				_.STATUS,
				_.SEND_TM,
				_.SMS_PLATFORM,
				_.RESPONSE_TEXT,
				_.OPER_BY,
				_.IP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SYSNAME,
				this._TEL_PHONE,
				this._SMS_CONTENT,
				this._STATUS,
				this._SEND_TM,
				this._SMS_PLATFORM,
				this._RESPONSE_TEXT,
				this._OPER_BY,
				this._IP,
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
			public readonly static Field All = new Field("*", "T_SMS_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SMS_LOG", "");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYSNAME = new Field("SYSNAME", "T_SMS_LOG", "系统名称");
            /// <summary>
			/// 电话号码
			/// </summary>
			public readonly static Field TEL_PHONE = new Field("TEL_PHONE", "T_SMS_LOG", "电话号码");
            /// <summary>
			/// 短信内容
			/// </summary>
			public readonly static Field SMS_CONTENT = new Field("SMS_CONTENT", "T_SMS_LOG", "短信内容");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_SMS_LOG", "状态");
            /// <summary>
			/// 发送时间
			/// </summary>
			public readonly static Field SEND_TM = new Field("SEND_TM", "T_SMS_LOG", "发送时间");
            /// <summary>
			/// 短信平台
			/// </summary>
			public readonly static Field SMS_PLATFORM = new Field("SMS_PLATFORM", "T_SMS_LOG", "短信平台");
            /// <summary>
			/// 返回值
			/// </summary>
			public readonly static Field RESPONSE_TEXT = new Field("RESPONSE_TEXT", "T_SMS_LOG", "返回值");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_BY = new Field("OPER_BY", "T_SMS_LOG", "");
            /// <summary>
			/// 发送人IP
			/// </summary>
			public readonly static Field IP = new Field("IP", "T_SMS_LOG", "发送人IP");
        }
        #endregion
	}
}