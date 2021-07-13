using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_POPEDOM_V2。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_POPEDOM_V2")]
    [Serializable]
    public partial class T_USER_POPEDOM_V2 : JdEntity
    {
        #region Model
		private string _RULE_ID;
		private string _GROUP_ID;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private string _REMARK;
		private string _POWER;
		private string _MODULE;
		private string _NAME;
		private string _LOG_AUTH;
		private string _MENU_AUTH;
		private decimal? _SORT;

		/// <summary>
		/// 角色菜单ID
		/// </summary>
		public string RULE_ID
		{
			get{ return _RULE_ID; }
			set
			{
				this.OnPropertyValueChange(_.RULE_ID, _RULE_ID, value);
				this._RULE_ID = value;
			}
		}
		/// <summary>
		/// 角色id
		/// </summary>
		public string GROUP_ID
		{
			get{ return _GROUP_ID; }
			set
			{
				this.OnPropertyValueChange(_.GROUP_ID, _GROUP_ID, value);
				this._GROUP_ID = value;
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
		/// 修改人
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
		/// 修改时间
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
		/// 备注
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
		/// <summary>
		/// 权限类型 insert,delete,update,select等 用逗号隔开
		/// </summary>
		public string POWER
		{
			get{ return _POWER; }
			set
			{
				this.OnPropertyValueChange(_.POWER, _POWER, value);
				this._POWER = value;
			}
		}
		/// <summary>
		/// 所属模块,参数的值是不固定的，可根据模块需求决定
		/// </summary>
		public string MODULE
		{
			get{ return _MODULE; }
			set
			{
				this.OnPropertyValueChange(_.MODULE, _MODULE, value);
				this._MODULE = value;
			}
		}
		/// <summary>
		/// 规则名称
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
		/// 对应菜单编号集合，表示该规则下的角色请求接口后是否记录操作。逗号分割
		/// </summary>
		public string LOG_AUTH
		{
			get{ return _LOG_AUTH; }
			set
			{
				this.OnPropertyValueChange(_.LOG_AUTH, _LOG_AUTH, value);
				this._LOG_AUTH = value;
			}
		}
		/// <summary>
		/// 对应菜单编号集合，表示该规则下的角色所拥有的菜单操作权。逗号分割
		/// </summary>
		public string MENU_AUTH
		{
			get{ return _MENU_AUTH; }
			set
			{
				this.OnPropertyValueChange(_.MENU_AUTH, _MENU_AUTH, value);
				this._MENU_AUTH = value;
			}
		}
		/// <summary>
		/// 规则排序值
		/// </summary>
		public decimal? SORT
		{
			get{ return _SORT; }
			set
			{
				this.OnPropertyValueChange(_.SORT, _SORT, value);
				this._SORT = value;
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
				_.RULE_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.RULE_ID,
				_.GROUP_ID,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.REMARK,
				_.POWER,
				_.MODULE,
				_.NAME,
				_.LOG_AUTH,
				_.MENU_AUTH,
				_.SORT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._RULE_ID,
				this._GROUP_ID,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._REMARK,
				this._POWER,
				this._MODULE,
				this._NAME,
				this._LOG_AUTH,
				this._MENU_AUTH,
				this._SORT,
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
			public readonly static Field All = new Field("*", "T_USER_POPEDOM_V2");
            /// <summary>
			/// 角色菜单ID
			/// </summary>
			public readonly static Field RULE_ID = new Field("RULE_ID", "T_USER_POPEDOM_V2", "角色菜单ID");
            /// <summary>
			/// 角色id
			/// </summary>
			public readonly static Field GROUP_ID = new Field("GROUP_ID", "T_USER_POPEDOM_V2", "角色id");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "T_USER_POPEDOM_V2", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "T_USER_POPEDOM_V2", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "T_USER_POPEDOM_V2", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "T_USER_POPEDOM_V2", "修改时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_POPEDOM_V2", "备注");
            /// <summary>
			/// 权限类型 insert,delete,update,select等 用逗号隔开
			/// </summary>
			public readonly static Field POWER = new Field("POWER", "T_USER_POPEDOM_V2", "权限类型 insert,delete,update,select等 用逗号隔开");
            /// <summary>
			/// 所属模块,参数的值是不固定的，可根据模块需求决定
			/// </summary>
			public readonly static Field MODULE = new Field("MODULE", "T_USER_POPEDOM_V2", "所属模块,参数的值是不固定的，可根据模块需求决定");
            /// <summary>
			/// 规则名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_USER_POPEDOM_V2", "规则名称");
            /// <summary>
			/// 对应菜单编号集合，表示该规则下的角色请求接口后是否记录操作。逗号分割
			/// </summary>
			public readonly static Field LOG_AUTH = new Field("LOG_AUTH", "T_USER_POPEDOM_V2",DbType.AnsiString, null, "对应菜单编号集合，表示该规则下的角色请求接口后是否记录操作。逗号分割");
            /// <summary>
			/// 对应菜单编号集合，表示该规则下的角色所拥有的菜单操作权。逗号分割
			/// </summary>
			public readonly static Field MENU_AUTH = new Field("MENU_AUTH", "T_USER_POPEDOM_V2",DbType.AnsiString, null, "对应菜单编号集合，表示该规则下的角色所拥有的菜单操作权。逗号分割");
            /// <summary>
			/// 规则排序值
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "T_USER_POPEDOM_V2", "规则排序值");
        }
        #endregion
	}
}