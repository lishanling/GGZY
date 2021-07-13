using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TB_REPLACE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TB_REPLACE")]
    [Serializable]
    public partial class TB_REPLACE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _OLD_VALUE;
		private string _NEW_VALUE;
		private string _SYS_CODE;

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
		/// <summary>
		/// 
		/// </summary>
		public string SYS_CODE
		{
			get{ return _SYS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SYS_CODE, _SYS_CODE, value);
				this._SYS_CODE = value;
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
				_.OLD_VALUE,
				_.NEW_VALUE,
				_.SYS_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._OLD_VALUE,
				this._NEW_VALUE,
				this._SYS_CODE,
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
			public readonly static Field All = new Field("*", "TB_REPLACE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TB_REPLACE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OLD_VALUE = new Field("OLD_VALUE", "TB_REPLACE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NEW_VALUE = new Field("NEW_VALUE", "TB_REPLACE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYS_CODE = new Field("SYS_CODE", "TB_REPLACE", "");
        }
        #endregion
	}
}