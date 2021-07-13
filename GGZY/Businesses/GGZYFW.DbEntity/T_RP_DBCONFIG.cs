using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP_DBCONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP_DBCONFIG")]
    [Serializable]
    public partial class T_RP_DBCONFIG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _DB_CODE;
		private string _DB_CONFIG;
		private string _DB_TYPE;

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
		/// 
		/// </summary>
		public string DB_CODE
		{
			get{ return _DB_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DB_CODE, _DB_CODE, value);
				this._DB_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DB_CONFIG
		{
			get{ return _DB_CONFIG; }
			set
			{
				this.OnPropertyValueChange(_.DB_CONFIG, _DB_CONFIG, value);
				this._DB_CONFIG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DB_TYPE
		{
			get{ return _DB_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.DB_TYPE, _DB_TYPE, value);
				this._DB_TYPE = value;
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
				_.NAME,
				_.DB_CODE,
				_.DB_CONFIG,
				_.DB_TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._DB_CODE,
				this._DB_CONFIG,
				this._DB_TYPE,
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
			public readonly static Field All = new Field("*", "T_RP_DBCONFIG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RP_DBCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_RP_DBCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DB_CODE = new Field("DB_CODE", "T_RP_DBCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DB_CONFIG = new Field("DB_CONFIG", "T_RP_DBCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DB_TYPE = new Field("DB_TYPE", "T_RP_DBCONFIG", "");
        }
        #endregion
	}
}