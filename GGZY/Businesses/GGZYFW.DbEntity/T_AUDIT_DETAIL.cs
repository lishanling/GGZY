using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_AUDIT_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AUDIT_DETAIL")]
    [Serializable]
    public partial class T_AUDIT_DETAIL : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _AUDIT_ID;
		private string _TABLE_NAME;
		private string _TABLE_FIELD;
		private string _OLD_VALUE;
		private string _NEW_VALUE;

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
		public decimal? AUDIT_ID
		{
			get{ return _AUDIT_ID; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_ID, _AUDIT_ID, value);
				this._AUDIT_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TABLE_NAME
		{
			get{ return _TABLE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TABLE_NAME, _TABLE_NAME, value);
				this._TABLE_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TABLE_FIELD
		{
			get{ return _TABLE_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.TABLE_FIELD, _TABLE_FIELD, value);
				this._TABLE_FIELD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OLD_VALUE
		{
			get{ return _OLD_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.OLD_VALUE, _OLD_VALUE, value);
				this._OLD_VALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NEW_VALUE
		{
			get{ return _NEW_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.NEW_VALUE, _NEW_VALUE, value);
				this._NEW_VALUE = value;
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
				_.AUDIT_ID,
				_.TABLE_NAME,
				_.TABLE_FIELD,
				_.OLD_VALUE,
				_.NEW_VALUE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._AUDIT_ID,
				this._TABLE_NAME,
				this._TABLE_FIELD,
				this._OLD_VALUE,
				this._NEW_VALUE,
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
			public readonly static Field All = new Field("*", "T_AUDIT_DETAIL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_AUDIT_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AUDIT_ID = new Field("AUDIT_ID", "T_AUDIT_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLE_NAME = new Field("TABLE_NAME", "T_AUDIT_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLE_FIELD = new Field("TABLE_FIELD", "T_AUDIT_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OLD_VALUE = new Field("OLD_VALUE", "T_AUDIT_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NEW_VALUE = new Field("NEW_VALUE", "T_AUDIT_DETAIL", "");
        }
        #endregion
	}
}