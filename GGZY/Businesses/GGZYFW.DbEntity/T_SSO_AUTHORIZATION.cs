using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SSO_AUTHORIZATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SSO_AUTHORIZATION")]
    [Serializable]
    public partial class T_SSO_AUTHORIZATION : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _ACCESS_TOKEN;
		private string _CLIENT_ID;
		private decimal? _USER_ID;
		private string _SCOPE;
		private DateTime? _CREATE_TM;
		private DateTime? _EXPIRAT_TM;
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
		/// 
		/// </summary>
		public string ACCESS_TOKEN
		{
			get{ return _ACCESS_TOKEN; }
			set
			{
				this.OnPropertyValueChange(_.ACCESS_TOKEN, _ACCESS_TOKEN, value);
				this._ACCESS_TOKEN = value;
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
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCOPE
		{
			get{ return _SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE, _SCOPE, value);
				this._SCOPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EXPIRAT_TM
		{
			get{ return _EXPIRAT_TM; }
			set
			{
				this.OnPropertyValueChange(_.EXPIRAT_TM, _EXPIRAT_TM, value);
				this._EXPIRAT_TM = value;
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
				_.ACCESS_TOKEN,
				_.CLIENT_ID,
				_.USER_ID,
				_.SCOPE,
				_.CREATE_TM,
				_.EXPIRAT_TM,
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
				this._ACCESS_TOKEN,
				this._CLIENT_ID,
				this._USER_ID,
				this._SCOPE,
				this._CREATE_TM,
				this._EXPIRAT_TM,
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
			public readonly static Field All = new Field("*", "T_SSO_AUTHORIZATION");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ACCESS_TOKEN = new Field("ACCESS_TOKEN", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLIENT_ID = new Field("CLIENT_ID", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EXPIRAT_TM = new Field("EXPIRAT_TM", "T_SSO_AUTHORIZATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_SSO_AUTHORIZATION", "");
        }
        #endregion
	}
}