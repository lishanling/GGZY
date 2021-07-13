using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_ACCESS_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ACCESS_DATA")]
    [Serializable]
    public partial class T_ACCESS_DATA : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _PROJECT_ID;
		private decimal? _DEP_ID;
		private decimal? _USER_ID;
		private DateTime? _EXPIRE_TM;
		private decimal? _CREATE_UID;
		private DateTime? _CREATE_TM;

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
		/// 项目ID
		/// </summary>
		public decimal? PROJECT_ID
		{
			get{ return _PROJECT_ID; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_ID, _PROJECT_ID, value);
				this._PROJECT_ID = value;
			}
		}
		/// <summary>
		/// 调阅单位
		/// </summary>
		public decimal? DEP_ID
		{
			get{ return _DEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.DEP_ID, _DEP_ID, value);
				this._DEP_ID = value;
			}
		}
		/// <summary>
		/// 所属用户ID
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
		/// 过期时间
		/// </summary>
		public DateTime? EXPIRE_TM
		{
			get{ return _EXPIRE_TM; }
			set
			{
				this.OnPropertyValueChange(_.EXPIRE_TM, _EXPIRE_TM, value);
				this._EXPIRE_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_UID
		{
			get{ return _CREATE_UID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_UID, _CREATE_UID, value);
				this._CREATE_UID = value;
			}
		}
		/// <summary>
		/// 创建时间
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
				_.PROJECT_ID,
				_.DEP_ID,
				_.USER_ID,
				_.EXPIRE_TM,
				_.CREATE_UID,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PROJECT_ID,
				this._DEP_ID,
				this._USER_ID,
				this._EXPIRE_TM,
				this._CREATE_UID,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_ACCESS_DATA");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ACCESS_DATA", "");
            /// <summary>
			/// 项目ID
			/// </summary>
			public readonly static Field PROJECT_ID = new Field("PROJECT_ID", "T_ACCESS_DATA", "项目ID");
            /// <summary>
			/// 调阅单位
			/// </summary>
			public readonly static Field DEP_ID = new Field("DEP_ID", "T_ACCESS_DATA", "调阅单位");
            /// <summary>
			/// 所属用户ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_ACCESS_DATA", "所属用户ID");
            /// <summary>
			/// 过期时间
			/// </summary>
			public readonly static Field EXPIRE_TM = new Field("EXPIRE_TM", "T_ACCESS_DATA", "过期时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_UID = new Field("CREATE_UID", "T_ACCESS_DATA", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_ACCESS_DATA", "创建时间");
        }
        #endregion
	}
}