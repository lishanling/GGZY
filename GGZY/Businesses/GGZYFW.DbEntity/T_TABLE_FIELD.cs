using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_TABLE_FIELD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TABLE_FIELD")]
    [Serializable]
    public partial class T_TABLE_FIELD : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TABLE_NAME;
		private string _TABLE_FIELD;
		private string _TABLE_FIELD_CHINESE;

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
		public string TABLE_FIELD_CHINESE
		{
			get{ return _TABLE_FIELD_CHINESE; }
			set
			{
				this.OnPropertyValueChange(_.TABLE_FIELD_CHINESE, _TABLE_FIELD_CHINESE, value);
				this._TABLE_FIELD_CHINESE = value;
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
				_.TABLE_NAME,
				_.TABLE_FIELD,
				_.TABLE_FIELD_CHINESE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TABLE_NAME,
				this._TABLE_FIELD,
				this._TABLE_FIELD_CHINESE,
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
			public readonly static Field All = new Field("*", "T_TABLE_FIELD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TABLE_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLE_NAME = new Field("TABLE_NAME", "T_TABLE_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLE_FIELD = new Field("TABLE_FIELD", "T_TABLE_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLE_FIELD_CHINESE = new Field("TABLE_FIELD_CHINESE", "T_TABLE_FIELD", "");
        }
        #endregion
	}
}