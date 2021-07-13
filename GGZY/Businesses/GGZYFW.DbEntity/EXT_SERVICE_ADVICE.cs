using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EXT_SERVICE_ADVICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EXT_SERVICE_ADVICE")]
    [Serializable]
    public partial class EXT_SERVICE_ADVICE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REALNAME;
		private string _PHONE;
		private string _EMAIL;
		private string _TITLE;
		private string _CONTENT;
		private DateTime? _TM;
		private string _ANSWER;
		private decimal? _ANSWER_USERID;
		private DateTime? _ANSWER_TM;
		private decimal? _RETURN;

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
		/// 姓名
		/// </summary>
		public string REALNAME
		{
			get{ return _REALNAME; }
			set
			{
				this.OnPropertyValueChange(_.REALNAME, _REALNAME, value);
				this._REALNAME = value;
			}
		}
		/// <summary>
		/// 手机号码
		/// </summary>
		public string PHONE
		{
			get{ return _PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PHONE, _PHONE, value);
				this._PHONE = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
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
		/// 意见或建议
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 意见或建议时间
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
				_.REALNAME,
				_.PHONE,
				_.EMAIL,
				_.TITLE,
				_.CONTENT,
				_.TM,
				_.ANSWER,
				_.ANSWER_USERID,
				_.ANSWER_TM,
				_.RETURN,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REALNAME,
				this._PHONE,
				this._EMAIL,
				this._TITLE,
				this._CONTENT,
				this._TM,
				this._ANSWER,
				this._ANSWER_USERID,
				this._ANSWER_TM,
				this._RETURN,
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
			public readonly static Field All = new Field("*", "EXT_SERVICE_ADVICE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "EXT_SERVICE_ADVICE", "ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field REALNAME = new Field("REALNAME", "EXT_SERVICE_ADVICE", "姓名");
            /// <summary>
			/// 手机号码
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "EXT_SERVICE_ADVICE", "手机号码");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "EXT_SERVICE_ADVICE", "电子邮箱");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "EXT_SERVICE_ADVICE", "标题");
            /// <summary>
			/// 意见或建议
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "EXT_SERVICE_ADVICE", "意见或建议");
            /// <summary>
			/// 意见或建议时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "EXT_SERVICE_ADVICE", "意见或建议时间");
            /// <summary>
			/// 回复内容
			/// </summary>
			public readonly static Field ANSWER = new Field("ANSWER", "EXT_SERVICE_ADVICE", "回复内容");
            /// <summary>
			/// 回复用户
			/// </summary>
			public readonly static Field ANSWER_USERID = new Field("ANSWER_USERID", "EXT_SERVICE_ADVICE", "回复用户");
            /// <summary>
			/// 回复时间
			/// </summary>
			public readonly static Field ANSWER_TM = new Field("ANSWER_TM", "EXT_SERVICE_ADVICE", "回复时间");
            /// <summary>
			/// 是否回复--用于列表下拉框查询   sys_dic 9002
			/// </summary>
			public readonly static Field RETURN = new Field("RETURN", "EXT_SERVICE_ADVICE", "是否回复--用于列表下拉框查询   sys_dic 9002");
        }
        #endregion
	}
}