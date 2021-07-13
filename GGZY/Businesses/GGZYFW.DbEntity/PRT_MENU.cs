using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRT_MENU。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRT_MENU")]
    [Serializable]
    public partial class PRT_MENU : FwEntity
    {
        #region Model
		private string _ID;
		private string _PARENT_ID;
		private string _NAME;
		private decimal? _SORT;
		private string _CONTROLLER_NAME;
		private string _ACTION_NAME;
		private string _PARAMETER;
		private decimal? _MENU_TYPE;
		private string _CREATE_BY;
		private DateTime? _CREATE_DATE;
		private string _UPDATE_BY;
		private DateTime? _UPDATE_DATE;
		private string _REMARKS;
		private decimal? _ENABLED;
		private string _PARENT_IDS;
		private string _ICON;

		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 父级ID
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
		/// 名称
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
		/// 排序
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
		/// 控制器
		/// </summary>
		public string CONTROLLER_NAME
		{
			get{ return _CONTROLLER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTROLLER_NAME, _CONTROLLER_NAME, value);
				this._CONTROLLER_NAME = value;
			}
		}
		/// <summary>
		/// 方法
		/// </summary>
		public string ACTION_NAME
		{
			get{ return _ACTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ACTION_NAME, _ACTION_NAME, value);
				this._ACTION_NAME = value;
			}
		}
		/// <summary>
		/// 参数
		/// </summary>
		public string PARAMETER
		{
			get{ return _PARAMETER; }
			set
			{
				this.OnPropertyValueChange(_.PARAMETER, _PARAMETER, value);
				this._PARAMETER = value;
			}
		}
		/// <summary>
		/// 菜单类型
		/// </summary>
		public decimal? MENU_TYPE
		{
			get{ return _MENU_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MENU_TYPE, _MENU_TYPE, value);
				this._MENU_TYPE = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			get{ return _CREATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DATE, _CREATE_DATE, value);
				this._CREATE_DATE = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATE_BY
		{
			get{ return _UPDATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_BY, _UPDATE_BY, value);
				this._UPDATE_BY = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATE_DATE
		{
			get{ return _UPDATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_DATE, _UPDATE_DATE, value);
				this._UPDATE_DATE = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARKS
		{
			get{ return _REMARKS; }
			set
			{
				this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
				this._REMARKS = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? ENABLED
		{
			get{ return _ENABLED; }
			set
			{
				this.OnPropertyValueChange(_.ENABLED, _ENABLED, value);
				this._ENABLED = value;
			}
		}
		/// <summary>
		/// 所有父级编号
		/// </summary>
		public string PARENT_IDS
		{
			get{ return _PARENT_IDS; }
			set
			{
				this.OnPropertyValueChange(_.PARENT_IDS, _PARENT_IDS, value);
				this._PARENT_IDS = value;
			}
		}
		/// <summary>
		/// 图标
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
				_.PARENT_ID,
				_.NAME,
				_.SORT,
				_.CONTROLLER_NAME,
				_.ACTION_NAME,
				_.PARAMETER,
				_.MENU_TYPE,
				_.CREATE_BY,
				_.CREATE_DATE,
				_.UPDATE_BY,
				_.UPDATE_DATE,
				_.REMARKS,
				_.ENABLED,
				_.PARENT_IDS,
				_.ICON,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PARENT_ID,
				this._NAME,
				this._SORT,
				this._CONTROLLER_NAME,
				this._ACTION_NAME,
				this._PARAMETER,
				this._MENU_TYPE,
				this._CREATE_BY,
				this._CREATE_DATE,
				this._UPDATE_BY,
				this._UPDATE_DATE,
				this._REMARKS,
				this._ENABLED,
				this._PARENT_IDS,
				this._ICON,
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
			public readonly static Field All = new Field("*", "PRT_MENU");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRT_MENU", "主键");
            /// <summary>
			/// 父级ID
			/// </summary>
			public readonly static Field PARENT_ID = new Field("PARENT_ID", "PRT_MENU", "父级ID");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "PRT_MENU", "名称");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "PRT_MENU", "排序");
            /// <summary>
			/// 控制器
			/// </summary>
			public readonly static Field CONTROLLER_NAME = new Field("CONTROLLER_NAME", "PRT_MENU", "控制器");
            /// <summary>
			/// 方法
			/// </summary>
			public readonly static Field ACTION_NAME = new Field("ACTION_NAME", "PRT_MENU", "方法");
            /// <summary>
			/// 参数
			/// </summary>
			public readonly static Field PARAMETER = new Field("PARAMETER", "PRT_MENU", "参数");
            /// <summary>
			/// 菜单类型
			/// </summary>
			public readonly static Field MENU_TYPE = new Field("MENU_TYPE", "PRT_MENU", "菜单类型");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "PRT_MENU", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "PRT_MENU", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "PRT_MENU", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATE_DATE = new Field("UPDATE_DATE", "PRT_MENU", "修改时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "PRT_MENU", "备注");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field ENABLED = new Field("ENABLED", "PRT_MENU", "是否启用");
            /// <summary>
			/// 所有父级编号
			/// </summary>
			public readonly static Field PARENT_IDS = new Field("PARENT_IDS", "PRT_MENU", "所有父级编号");
            /// <summary>
			/// 图标
			/// </summary>
			public readonly static Field ICON = new Field("ICON", "PRT_MENU", "图标");
        }
        #endregion
	}
}