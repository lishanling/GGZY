using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_POPEDOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_POPEDOM")]
    [Serializable]
    public partial class T_USER_POPEDOM : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _MENU_ID;
		private decimal? _ROLE_ID;
		private string _REMARK;
		private string _POWER;

		/// <summary>
		/// 权限ID
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
		/// 菜单ID
		/// </summary>
		public decimal? MENU_ID
		{
			get{ return _MENU_ID; }
			set
			{
				this.OnPropertyValueChange(_.MENU_ID, _MENU_ID, value);
				this._MENU_ID = value;
			}
		}
		/// <summary>
		/// 权限类别 insert,delete,update,select等 与sys_publictypeinfo中的sign=3的属性值关联
		/// </summary>
		public decimal? ROLE_ID
		{
			get{ return _ROLE_ID; }
			set
			{
				this.OnPropertyValueChange(_.ROLE_ID, _ROLE_ID, value);
				this._ROLE_ID = value;
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
				_.MENU_ID,
				_.ROLE_ID,
				_.REMARK,
				_.POWER,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._MENU_ID,
				this._ROLE_ID,
				this._REMARK,
				this._POWER,
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
			public readonly static Field All = new Field("*", "T_USER_POPEDOM");
            /// <summary>
			/// 权限ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_POPEDOM", "权限ID");
            /// <summary>
			/// 菜单ID
			/// </summary>
			public readonly static Field MENU_ID = new Field("MENU_ID", "T_USER_POPEDOM", "菜单ID");
            /// <summary>
			/// 权限类别 insert,delete,update,select等 与sys_publictypeinfo中的sign=3的属性值关联
			/// </summary>
			public readonly static Field ROLE_ID = new Field("ROLE_ID", "T_USER_POPEDOM", "权限类别 insert,delete,update,select等 与sys_publictypeinfo中的sign=3的属性值关联");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_POPEDOM", "备注");
            /// <summary>
			/// 权限类型 insert,delete,update,select等 用逗号隔开
			/// </summary>
			public readonly static Field POWER = new Field("POWER", "T_USER_POPEDOM", "权限类型 insert,delete,update,select等 用逗号隔开");
        }
        #endregion
	}
}