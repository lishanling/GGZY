using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_MENU_V2。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_MENU_V2")]
    [Serializable]
    public partial class T_USER_MENU_V2 : JdEntity
    {
        #region Model
		private string _MENU_ID;
		private string _PARENT_ID;
		private string _NAME;
		private string _ALIAS;
		private string _ICON;
		private string _REMARK;
		private string _MODULE;
		private decimal? _TYPE;
		private string _URL;
		private string _PARAMS;
		private string _TARGET;
		private decimal? _IS_NAVI;
		private decimal? _SORT;
		private decimal? _STATUS;
		private decimal? _MENU_LEVEL;
		private decimal? _CHILDREN_TOTAL;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private decimal? _ISSHOW;

		/// <summary>
		/// 菜单编号
		/// </summary>
		public string MENU_ID
		{
			get{ return _MENU_ID; }
			set
			{
				this.OnPropertyValueChange(_.MENU_ID, _MENU_ID, value);
				this._MENU_ID = value;
			}
		}
		/// <summary>
		/// 菜单上级编号
		/// </summary>
		public string PARENT_ID
		{
			get{ return _PARENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.PARENT_ID, _PARENT_ID, value);
				this._PARENT_ID = value;
			}
		}
		/// <summary>
		/// 菜单名称
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
		/// 菜单别名
		/// </summary>
		public string ALIAS
		{
			get{ return _ALIAS; }
			set
			{
				this.OnPropertyValueChange(_.ALIAS, _ALIAS, value);
				this._ALIAS = value;
			}
		}
		/// <summary>
		/// 菜单图标(样式图标)
		/// </summary>
		public string ICON
		{
			get{ return _ICON; }
			set
			{
				this.OnPropertyValueChange(_.ICON, _ICON, value);
				this._ICON = value;
			}
		}
		/// <summary>
		/// 菜单备注
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
		/// 所属模块
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
		/// 链接类型 0=模块 1=外链
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 链接地址
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 链接参数
		/// </summary>
		public string PARAMS
		{
			get{ return _PARAMS; }
			set
			{
				this.OnPropertyValueChange(_.PARAMS, _PARAMS, value);
				this._PARAMS = value;
			}
		}
		/// <summary>
		/// 打开方式 _self _blank
		/// </summary>
		public string TARGET
		{
			get{ return _TARGET; }
			set
			{
				this.OnPropertyValueChange(_.TARGET, _TARGET, value);
				this._TARGET = value;
			}
		}
		/// <summary>
		/// 是否属于导航菜单 0=否 1=是
		/// </summary>
		public decimal? IS_NAVI
		{
			get{ return _IS_NAVI; }
			set
			{
				this.OnPropertyValueChange(_.IS_NAVI, _IS_NAVI, value);
				this._IS_NAVI = value;
			}
		}
		/// <summary>
		/// 菜单排序值
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
		/// <summary>
		/// 菜单状态 0=禁用 1=启用
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
		/// 该菜单的层级深度
		/// </summary>
		public decimal? MENU_LEVEL
		{
			get{ return _MENU_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.MENU_LEVEL, _MENU_LEVEL, value);
				this._MENU_LEVEL = value;
			}
		}
		/// <summary>
		/// 该菜单下子级菜单数的合计
		/// </summary>
		public decimal? CHILDREN_TOTAL
		{
			get{ return _CHILDREN_TOTAL; }
			set
			{
				this.OnPropertyValueChange(_.CHILDREN_TOTAL, _CHILDREN_TOTAL, value);
				this._CHILDREN_TOTAL = value;
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
		/// 是否展示
		/// </summary>
		public decimal? ISSHOW
		{
			get{ return _ISSHOW; }
			set
			{
				this.OnPropertyValueChange(_.ISSHOW, _ISSHOW, value);
				this._ISSHOW = value;
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
				_.MENU_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MENU_ID,
				_.PARENT_ID,
				_.NAME,
				_.ALIAS,
				_.ICON,
				_.REMARK,
				_.MODULE,
				_.TYPE,
				_.URL,
				_.PARAMS,
				_.TARGET,
				_.IS_NAVI,
				_.SORT,
				_.STATUS,
				_.MENU_LEVEL,
				_.CHILDREN_TOTAL,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.ISSHOW,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MENU_ID,
				this._PARENT_ID,
				this._NAME,
				this._ALIAS,
				this._ICON,
				this._REMARK,
				this._MODULE,
				this._TYPE,
				this._URL,
				this._PARAMS,
				this._TARGET,
				this._IS_NAVI,
				this._SORT,
				this._STATUS,
				this._MENU_LEVEL,
				this._CHILDREN_TOTAL,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._ISSHOW,
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
			public readonly static Field All = new Field("*", "T_USER_MENU_V2");
            /// <summary>
			/// 菜单编号
			/// </summary>
			public readonly static Field MENU_ID = new Field("MENU_ID", "T_USER_MENU_V2", "菜单编号");
            /// <summary>
			/// 菜单上级编号
			/// </summary>
			public readonly static Field PARENT_ID = new Field("PARENT_ID", "T_USER_MENU_V2", "菜单上级编号");
            /// <summary>
			/// 菜单名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_USER_MENU_V2", "菜单名称");
            /// <summary>
			/// 菜单别名
			/// </summary>
			public readonly static Field ALIAS = new Field("ALIAS", "T_USER_MENU_V2", "菜单别名");
            /// <summary>
			/// 菜单图标(样式图标)
			/// </summary>
			public readonly static Field ICON = new Field("ICON", "T_USER_MENU_V2", "菜单图标(样式图标)");
            /// <summary>
			/// 菜单备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_MENU_V2", "菜单备注");
            /// <summary>
			/// 所属模块
			/// </summary>
			public readonly static Field MODULE = new Field("MODULE", "T_USER_MENU_V2", "所属模块");
            /// <summary>
			/// 链接类型 0=模块 1=外链
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_USER_MENU_V2", "链接类型 0=模块 1=外链");
            /// <summary>
			/// 链接地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_USER_MENU_V2", "链接地址");
            /// <summary>
			/// 链接参数
			/// </summary>
			public readonly static Field PARAMS = new Field("PARAMS", "T_USER_MENU_V2", "链接参数");
            /// <summary>
			/// 打开方式 _self _blank
			/// </summary>
			public readonly static Field TARGET = new Field("TARGET", "T_USER_MENU_V2", "打开方式 _self _blank");
            /// <summary>
			/// 是否属于导航菜单 0=否 1=是
			/// </summary>
			public readonly static Field IS_NAVI = new Field("IS_NAVI", "T_USER_MENU_V2", "是否属于导航菜单 0=否 1=是");
            /// <summary>
			/// 菜单排序值
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "T_USER_MENU_V2", "菜单排序值");
            /// <summary>
			/// 菜单状态 0=禁用 1=启用
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_USER_MENU_V2", "菜单状态 0=禁用 1=启用");
            /// <summary>
			/// 该菜单的层级深度
			/// </summary>
			public readonly static Field MENU_LEVEL = new Field("MENU_LEVEL", "T_USER_MENU_V2", "该菜单的层级深度");
            /// <summary>
			/// 该菜单下子级菜单数的合计
			/// </summary>
			public readonly static Field CHILDREN_TOTAL = new Field("CHILDREN_TOTAL", "T_USER_MENU_V2", "该菜单下子级菜单数的合计");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "T_USER_MENU_V2", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "T_USER_MENU_V2", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "T_USER_MENU_V2", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "T_USER_MENU_V2", "修改时间");
            /// <summary>
			/// 是否展示
			/// </summary>
			public readonly static Field ISSHOW = new Field("ISSHOW", "T_USER_MENU_V2", "是否展示");
        }
        #endregion
	}
}