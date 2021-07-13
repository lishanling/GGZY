using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类UNIFY_AUTHS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("UNIFY_AUTHS")]
    [Serializable]
    public partial class UNIFY_AUTHS : FwEntity
    {
        #region Model
		private string _MGUID;
		private string _USERGUID;
		private string _APPGUID;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private string _ACCESSTOKEN;
		private string _APPUID;

		/// <summary>
		/// 主键
		/// </summary>
		public string MGUID
		{
			get{ return _MGUID; }
			set
			{
				this.OnPropertyValueChange(_.MGUID, _MGUID, value);
				this._MGUID = value;
			}
		}
		/// <summary>
		/// 用户主键
		/// </summary>
		public string USERGUID
		{
			get{ return _USERGUID; }
			set
			{
				this.OnPropertyValueChange(_.USERGUID, _USERGUID, value);
				this._USERGUID = value;
			}
		}
		/// <summary>
		/// 应用主键
		/// </summary>
		public string APPGUID
		{
			get{ return _APPGUID; }
			set
			{
				this.OnPropertyValueChange(_.APPGUID, _APPGUID, value);
				this._APPGUID = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATEDBY
		{
			get{ return _CREATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDBY, _CREATEDBY, value);
				this._CREATEDBY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATEDTIME
		{
			get{ return _CREATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDTIME, _CREATEDTIME, value);
				this._CREATEDTIME = value;
			}
		}
		/// <summary>
		/// 更新人
		/// </summary>
		public string UPDATEDBY
		{
			get{ return _UPDATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDBY, _UPDATEDBY, value);
				this._UPDATEDBY = value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UPDATEDTIME
		{
			get{ return _UPDATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDTIME, _UPDATEDTIME, value);
				this._UPDATEDTIME = value;
			}
		}
		/// <summary>
		/// 调用凭证
		/// </summary>
		public string ACCESSTOKEN
		{
			get{ return _ACCESSTOKEN; }
			set
			{
				this.OnPropertyValueChange(_.ACCESSTOKEN, _ACCESSTOKEN, value);
				this._ACCESSTOKEN = value;
			}
		}
		/// <summary>
		/// 应用对应的用户主键
		/// </summary>
		public string APPUID
		{
			get{ return _APPUID; }
			set
			{
				this.OnPropertyValueChange(_.APPUID, _APPUID, value);
				this._APPUID = value;
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
				_.MGUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MGUID,
				_.USERGUID,
				_.APPGUID,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.ACCESSTOKEN,
				_.APPUID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MGUID,
				this._USERGUID,
				this._APPGUID,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._ACCESSTOKEN,
				this._APPUID,
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
			public readonly static Field All = new Field("*", "UNIFY_AUTHS");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field MGUID = new Field("MGUID", "UNIFY_AUTHS", "主键");
            /// <summary>
			/// 用户主键
			/// </summary>
			public readonly static Field USERGUID = new Field("USERGUID", "UNIFY_AUTHS", "用户主键");
            /// <summary>
			/// 应用主键
			/// </summary>
			public readonly static Field APPGUID = new Field("APPGUID", "UNIFY_AUTHS", "应用主键");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "UNIFY_AUTHS", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "UNIFY_AUTHS", "创建时间");
            /// <summary>
			/// 更新人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "UNIFY_AUTHS", "更新人");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "UNIFY_AUTHS", "更新时间");
            /// <summary>
			/// 调用凭证
			/// </summary>
			public readonly static Field ACCESSTOKEN = new Field("ACCESSTOKEN", "UNIFY_AUTHS", "调用凭证");
            /// <summary>
			/// 应用对应的用户主键
			/// </summary>
			public readonly static Field APPUID = new Field("APPUID", "UNIFY_AUTHS", "应用对应的用户主键");
        }
        #endregion
	}
}