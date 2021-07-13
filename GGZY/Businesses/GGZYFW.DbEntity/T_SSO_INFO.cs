using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SSO_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SSO_INFO")]
    [Serializable]
    public partial class T_SSO_INFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REDIRECT_URI;
		private string _LOGOUT_URL;
		private string _NAME;
		private string _CLIENT_ID;
		private string _CLIENT_SECRET;

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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
				_.CLIENT_ID,
				_.CLIENT_SECRET,
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
				this._CLIENT_ID,
				this._CLIENT_SECRET,
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
			public readonly static Field All = new Field("*", "T_SSO_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SSO_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REDIRECT_URI = new Field("REDIRECT_URI", "T_SSO_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOGOUT_URL = new Field("LOGOUT_URL", "T_SSO_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_SSO_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLIENT_ID = new Field("CLIENT_ID", "T_SSO_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLIENT_SECRET = new Field("CLIENT_SECRET", "T_SSO_INFO", "");
        }
        #endregion
	}
}