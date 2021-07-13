using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_FINDPWD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_FINDPWD")]
    [Serializable]
    public partial class T_FINDPWD : FwEntity
    {
        #region Model
		private Guid _GUID;
		private decimal? _U_ID;
		private DateTime? _CREATE_DATE;
		private decimal? _IS_ENABLE;

		/// <summary>
		/// 主键，36位guid
		/// </summary>
		public Guid GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// T_USER外键
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 找回密码时间
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
		/// 是否有效
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
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
				_.GUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.GUID,
				_.U_ID,
				_.CREATE_DATE,
				_.IS_ENABLE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._GUID,
				this._U_ID,
				this._CREATE_DATE,
				this._IS_ENABLE,
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
			public readonly static Field All = new Field("*", "T_FINDPWD");
            /// <summary>
			/// 主键，36位guid
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_FINDPWD", "主键，36位guid");
            /// <summary>
			/// T_USER外键
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_FINDPWD", "T_USER外键");
            /// <summary>
			/// 找回密码时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "T_FINDPWD", "找回密码时间");
            /// <summary>
			/// 是否有效
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "T_FINDPWD", "是否有效");
        }
        #endregion
	}
}