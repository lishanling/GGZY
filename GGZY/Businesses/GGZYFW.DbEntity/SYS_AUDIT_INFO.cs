using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_AUDIT_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_AUDIT_INFO")]
    [Serializable]
    public partial class SYS_AUDIT_INFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _ATID;
		private string _CONTENT_INFO;

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
		public decimal? ATID
		{
			get{ return _ATID; }
			set
			{
				this.OnPropertyValueChange(_.ATID, _ATID, value);
				this._ATID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENT_INFO
		{
			get{ return _CONTENT_INFO; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT_INFO, _CONTENT_INFO, value);
				this._CONTENT_INFO = value;
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
				_.ATID,
				_.CONTENT_INFO,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ATID,
				this._CONTENT_INFO,
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
			public readonly static Field All = new Field("*", "SYS_AUDIT_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_AUDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ATID = new Field("ATID", "SYS_AUDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTENT_INFO = new Field("CONTENT_INFO", "SYS_AUDIT_INFO",DbType.AnsiString, null, "");
        }
        #endregion
	}
}