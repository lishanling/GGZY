using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MESSAGE_TEXT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MESSAGE_TEXT")]
    [Serializable]
    public partial class T_MESSAGE_TEXT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _C_TEXT;

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
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_TEXT
		{
			get{ return _C_TEXT; }
			set
			{
				this.OnPropertyValueChange(_.C_TEXT, _C_TEXT, value);
				this._C_TEXT = value;
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
				_.TITLE,
				_.C_TEXT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._C_TEXT,
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
			public readonly static Field All = new Field("*", "T_MESSAGE_TEXT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MESSAGE_TEXT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_MESSAGE_TEXT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field C_TEXT = new Field("C_TEXT", "T_MESSAGE_TEXT",DbType.AnsiString, null, "");
        }
        #endregion
	}
}