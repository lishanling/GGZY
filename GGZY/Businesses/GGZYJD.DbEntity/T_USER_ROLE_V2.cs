using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_ROLE_V2。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_ROLE_V2")]
    [Serializable]
    public partial class T_USER_ROLE_V2 : JdEntity
    {
        #region Model
		private string _GROUP_ID;
		private string _NAME;
		private string _DESCRIPTION;
		private decimal? _SORT;
		private decimal? _STATUS;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private decimal? _IS_DELETE;

		/// <summary>
		/// 角色ID
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
		/// 角色说明
		/// </summary>
		public string DESCRIPTION
		{
			get{ return _DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.DESCRIPTION, _DESCRIPTION, value);
				this._DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 排序号
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
		/// 用户组状态 0=禁用 1=启用
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
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.GROUP_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.GROUP_ID,
				_.NAME,
				_.DESCRIPTION,
				_.SORT,
				_.STATUS,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._GROUP_ID,
				this._NAME,
				this._DESCRIPTION,
				this._SORT,
				this._STATUS,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "T_USER_ROLE_V2");
            /// <summary>
			/// 角色ID
			/// </summary>
			public readonly static Field GROUP_ID = new Field("GROUP_ID", "T_USER_ROLE_V2", "角色ID");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_USER_ROLE_V2", "名称");
            /// <summary>
			/// 角色说明
			/// </summary>
			public readonly static Field DESCRIPTION = new Field("DESCRIPTION", "T_USER_ROLE_V2", "角色说明");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "T_USER_ROLE_V2", "排序号");
            /// <summary>
			/// 用户组状态 0=禁用 1=启用
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_USER_ROLE_V2", "用户组状态 0=禁用 1=启用");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "T_USER_ROLE_V2", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "T_USER_ROLE_V2", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "T_USER_ROLE_V2", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "T_USER_ROLE_V2", "修改时间");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "T_USER_ROLE_V2", "是否删除");
        }
        #endregion
	}
}