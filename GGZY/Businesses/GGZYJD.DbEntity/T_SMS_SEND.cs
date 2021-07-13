using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_SMS_SEND。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SMS_SEND")]
    [Serializable]
    public partial class T_SMS_SEND : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _MODULE_NAME;
		private string _TEL_PHONE;
		private string _SMS_CONTENT;
		private decimal? _STATUS;
		private DateTime? _YJ_SEND_TM;
		private DateTime? _SEND_TM;
		private string _SMS_PLATFORM;
		private string _RESPONSE_TEXT;
		private decimal? _OPER_BY;
		private decimal? _RETRY;

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
		/// 模块名称
		/// </summary>
		public string MODULE_NAME
		{
			get{ return _MODULE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MODULE_NAME, _MODULE_NAME, value);
				this._MODULE_NAME = value;
			}
		}
		/// <summary>
		/// 手机号码
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
		/// 状态 0:未发送 1:已发送
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 预计发送时间
		/// </summary>
		public DateTime? YJ_SEND_TM
		{
			get{ return _YJ_SEND_TM; }
			set
			{
				this.OnPropertyValueChange(_.YJ_SEND_TM, _YJ_SEND_TM, value);
				this._YJ_SEND_TM = value;
			}
		}
		/// <summary>
		/// 实际发送时间
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
		/// 短信平台返回值
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
		/// 操作人
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
		/// 重试次数
		/// </summary>
		public decimal? RETRY
		{
			get{ return _RETRY; }
			set
			{
				this.OnPropertyValueChange(_.RETRY, _RETRY, value);
				this._RETRY = value;
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
				_.MODULE_NAME,
				_.TEL_PHONE,
				_.SMS_CONTENT,
				_.STATUS,
				_.YJ_SEND_TM,
				_.SEND_TM,
				_.SMS_PLATFORM,
				_.RESPONSE_TEXT,
				_.OPER_BY,
				_.RETRY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._MODULE_NAME,
				this._TEL_PHONE,
				this._SMS_CONTENT,
				this._STATUS,
				this._YJ_SEND_TM,
				this._SEND_TM,
				this._SMS_PLATFORM,
				this._RESPONSE_TEXT,
				this._OPER_BY,
				this._RETRY,
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
			public readonly static Field All = new Field("*", "T_SMS_SEND");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SMS_SEND", "ID");
            /// <summary>
			/// 模块名称
			/// </summary>
			public readonly static Field MODULE_NAME = new Field("MODULE_NAME", "T_SMS_SEND", "模块名称");
            /// <summary>
			/// 手机号码
			/// </summary>
			public readonly static Field TEL_PHONE = new Field("TEL_PHONE", "T_SMS_SEND", "手机号码");
            /// <summary>
			/// 短信内容
			/// </summary>
			public readonly static Field SMS_CONTENT = new Field("SMS_CONTENT", "T_SMS_SEND", "短信内容");
            /// <summary>
			/// 状态 0:未发送 1:已发送
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_SMS_SEND", "状态 0:未发送 1:已发送");
            /// <summary>
			/// 预计发送时间
			/// </summary>
			public readonly static Field YJ_SEND_TM = new Field("YJ_SEND_TM", "T_SMS_SEND", "预计发送时间");
            /// <summary>
			/// 实际发送时间
			/// </summary>
			public readonly static Field SEND_TM = new Field("SEND_TM", "T_SMS_SEND", "实际发送时间");
            /// <summary>
			/// 短信平台
			/// </summary>
			public readonly static Field SMS_PLATFORM = new Field("SMS_PLATFORM", "T_SMS_SEND", "短信平台");
            /// <summary>
			/// 短信平台返回值
			/// </summary>
			public readonly static Field RESPONSE_TEXT = new Field("RESPONSE_TEXT", "T_SMS_SEND", "短信平台返回值");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field OPER_BY = new Field("OPER_BY", "T_SMS_SEND", "操作人");
            /// <summary>
			/// 重试次数
			/// </summary>
			public readonly static Field RETRY = new Field("RETRY", "T_SMS_SEND", "重试次数");
        }
        #endregion
	}
}