using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SSO_INFO_SQ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SSO_INFO_SQ")]
    [Serializable]
    public partial class T_SSO_INFO_SQ : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REDIRECT_URI;
		private string _LOGOUT_URL;
		private string _NAME;
		private string _CITY_NAME;
		private string _EMAIL;
		private string _CONTACT_PERSON;
		private string _PHONE_NO;
		private string _CLIENT_ID;
		private string _CLIENT_SECRET;
		private decimal? _STATUS;
		private string _REMARK;

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
		/// 回调地址
		/// </summary>
		public string REDIRECT_URI
		{
			get{ return _REDIRECT_URI; }
			set
			{
				this.OnPropertyValueChange(_.REDIRECT_URI, _REDIRECT_URI, value);
				this._REDIRECT_URI = value;
			}
		}
		/// <summary>
		/// 注销地址
		/// </summary>
		public string LOGOUT_URL
		{
			get{ return _LOGOUT_URL; }
			set
			{
				this.OnPropertyValueChange(_.LOGOUT_URL, _LOGOUT_URL, value);
				this._LOGOUT_URL = value;
			}
		}
		/// <summary>
		/// 电子交易平台名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 所在城市
		/// </summary>
		public string CITY_NAME
		{
			get{ return _CITY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CITY_NAME, _CITY_NAME, value);
				this._CITY_NAME = value;
			}
		}
		/// <summary>
		/// 联系邮箱
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
		/// 联系人
		/// </summary>
		public string CONTACT_PERSON
		{
			get{ return _CONTACT_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_PERSON, _CONTACT_PERSON, value);
				this._CONTACT_PERSON = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PHONE_NO
		{
			get{ return _PHONE_NO; }
			set
			{
				this.OnPropertyValueChange(_.PHONE_NO, _PHONE_NO, value);
				this._PHONE_NO = value;
			}
		}
		/// <summary>
		/// CLIENT_ID
		/// </summary>
		public string CLIENT_ID
		{
			get{ return _CLIENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.CLIENT_ID, _CLIENT_ID, value);
				this._CLIENT_ID = value;
			}
		}
		/// <summary>
		/// CLIENT_SECRET
		/// </summary>
		public string CLIENT_SECRET
		{
			get{ return _CLIENT_SECRET; }
			set
			{
				this.OnPropertyValueChange(_.CLIENT_SECRET, _CLIENT_SECRET, value);
				this._CLIENT_SECRET = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.REDIRECT_URI,
				_.LOGOUT_URL,
				_.NAME,
				_.CITY_NAME,
				_.EMAIL,
				_.CONTACT_PERSON,
				_.PHONE_NO,
				_.CLIENT_ID,
				_.CLIENT_SECRET,
				_.STATUS,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REDIRECT_URI,
				this._LOGOUT_URL,
				this._NAME,
				this._CITY_NAME,
				this._EMAIL,
				this._CONTACT_PERSON,
				this._PHONE_NO,
				this._CLIENT_ID,
				this._CLIENT_SECRET,
				this._STATUS,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "T_SSO_INFO_SQ");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SSO_INFO_SQ", "");
            /// <summary>
			/// 回调地址
			/// </summary>
			public readonly static Field REDIRECT_URI = new Field("REDIRECT_URI", "T_SSO_INFO_SQ", "回调地址");
            /// <summary>
			/// 注销地址
			/// </summary>
			public readonly static Field LOGOUT_URL = new Field("LOGOUT_URL", "T_SSO_INFO_SQ", "注销地址");
            /// <summary>
			/// 电子交易平台名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_SSO_INFO_SQ", "电子交易平台名称");
            /// <summary>
			/// 所在城市
			/// </summary>
			public readonly static Field CITY_NAME = new Field("CITY_NAME", "T_SSO_INFO_SQ", "所在城市");
            /// <summary>
			/// 联系邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "T_SSO_INFO_SQ", "联系邮箱");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACT_PERSON = new Field("CONTACT_PERSON", "T_SSO_INFO_SQ", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PHONE_NO = new Field("PHONE_NO", "T_SSO_INFO_SQ", "联系电话");
            /// <summary>
			/// CLIENT_ID
			/// </summary>
			public readonly static Field CLIENT_ID = new Field("CLIENT_ID", "T_SSO_INFO_SQ", "CLIENT_ID");
            /// <summary>
			/// CLIENT_SECRET
			/// </summary>
			public readonly static Field CLIENT_SECRET = new Field("CLIENT_SECRET", "T_SSO_INFO_SQ", "CLIENT_SECRET");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_SSO_INFO_SQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_SSO_INFO_SQ", "");
        }
        #endregion
	}
}