using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类UNIFY_APP。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("UNIFY_APP")]
	[Serializable]
	public partial class UNIFY_APP : FwEntity
	{
		#region Model
		private string _MGUID;
		private string _APPKEY;
		private string _APPNAME;
		private string _APPICON;
		private decimal? _SORT;
		private string _HOSTURL;
		private string _APPTYPE;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private string _SSOURL;
		private string _OAUTHURL;
		private decimal? _IS_AUTO_AUTH;

		/// <summary>
		/// 主键
		/// </summary>
		public string MGUID
		{
			get { return _MGUID; }
			set
			{
				this.OnPropertyValueChange(_.MGUID, _MGUID, value);
				this._MGUID = value;
			}
		}
		/// <summary>
		/// 应用KEY
		/// </summary>
		public string APPKEY
		{
			get { return _APPKEY; }
			set
			{
				this.OnPropertyValueChange(_.APPKEY, _APPKEY, value);
				this._APPKEY = value;
			}
		}
		/// <summary>
		/// 应用名称
		/// </summary>
		public string APPNAME
		{
			get { return _APPNAME; }
			set
			{
				this.OnPropertyValueChange(_.APPNAME, _APPNAME, value);
				this._APPNAME = value;
			}
		}
		/// <summary>
		/// 应用图标
		/// </summary>
		public string APPICON
		{
			get { return _APPICON; }
			set
			{
				this.OnPropertyValueChange(_.APPICON, _APPICON, value);
				this._APPICON = value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? SORT
		{
			get { return _SORT; }
			set
			{
				this.OnPropertyValueChange(_.SORT, _SORT, value);
				this._SORT = value;
			}
		}
		/// <summary>
		/// 主机地址
		/// </summary>
		public string HOSTURL
		{
			get { return _HOSTURL; }
			set
			{
				this.OnPropertyValueChange(_.HOSTURL, _HOSTURL, value);
				this._HOSTURL = value;
			}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string APPTYPE
		{
			get { return _APPTYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPTYPE, _APPTYPE, value);
				this._APPTYPE = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATEDBY
		{
			get { return _CREATEDBY; }
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
			get { return _CREATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDTIME, _CREATEDTIME, value);
				this._CREATEDTIME = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATEDBY
		{
			get { return _UPDATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDBY, _UPDATEDBY, value);
				this._UPDATEDBY = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATEDTIME
		{
			get { return _UPDATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDTIME, _UPDATEDTIME, value);
				this._UPDATEDTIME = value;
			}
		}
		/// <summary>
		/// SSO登录地址
		/// </summary>
		public string SSOURL
		{
			get { return _SSOURL; }
			set
			{
				this.OnPropertyValueChange(_.SSOURL, _SSOURL, value);
				this._SSOURL = value;
			}
		}
		/// <summary>
		/// OAUTH认证地址
		/// </summary>
		public string OAUTHURL
		{
			get { return _OAUTHURL; }
			set
			{
				this.OnPropertyValueChange(_.OAUTHURL, _OAUTHURL, value);
				this._OAUTHURL = value;
			}
		}
		/// <summary>
		/// 是否开启自动授权1是0否
		/// </summary>
		public decimal? IS_AUTO_AUTH
		{
			get { return _IS_AUTO_AUTH; }
			set
			{
				this.OnPropertyValueChange(_.IS_AUTO_AUTH, _IS_AUTO_AUTH, value);
				this._IS_AUTO_AUTH = value;
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
				_.APPKEY,
				_.APPNAME,
				_.APPICON,
				_.SORT,
				_.HOSTURL,
				_.APPTYPE,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.SSOURL,
				_.OAUTHURL,
				_.IS_AUTO_AUTH,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MGUID,
				this._APPKEY,
				this._APPNAME,
				this._APPICON,
				this._SORT,
				this._HOSTURL,
				this._APPTYPE,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._SSOURL,
				this._OAUTHURL,
				this._IS_AUTO_AUTH,
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
			public readonly static Field All = new Field("*", "UNIFY_APP");
			/// <summary>
			/// 主键
			/// </summary>
			public readonly static Field MGUID = new Field("MGUID", "UNIFY_APP", "主键");
			/// <summary>
			/// 应用KEY
			/// </summary>
			public readonly static Field APPKEY = new Field("APPKEY", "UNIFY_APP", "应用KEY");
			/// <summary>
			/// 应用名称
			/// </summary>
			public readonly static Field APPNAME = new Field("APPNAME", "UNIFY_APP", "应用名称");
			/// <summary>
			/// 应用图标
			/// </summary>
			public readonly static Field APPICON = new Field("APPICON", "UNIFY_APP", "应用图标");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "UNIFY_APP", "排序");
			/// <summary>
			/// 主机地址
			/// </summary>
			public readonly static Field HOSTURL = new Field("HOSTURL", "UNIFY_APP", "主机地址");
			/// <summary>
			/// 类型
			/// </summary>
			public readonly static Field APPTYPE = new Field("APPTYPE", "UNIFY_APP", "类型");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "UNIFY_APP", "创建人");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "UNIFY_APP", "创建时间");
			/// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "UNIFY_APP", "修改人");
			/// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "UNIFY_APP", "修改时间");
			/// <summary>
			/// SSO登录地址
			/// </summary>
			public readonly static Field SSOURL = new Field("SSOURL", "UNIFY_APP", "SSO登录地址");
			/// <summary>
			/// OAUTH认证地址
			/// </summary>
			public readonly static Field OAUTHURL = new Field("OAUTHURL", "UNIFY_APP", "OAUTH认证地址");
			/// <summary>
			/// 是否开启自动授权1是0否
			/// </summary>
			public readonly static Field IS_AUTO_AUTH = new Field("IS_AUTO_AUTH", "UNIFY_APP", "是否开启自动授权1是0否");
		}
		#endregion
	}
}