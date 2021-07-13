using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_YC_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_YC_LOG")]
    [Serializable]
    public partial class T_YC_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _LOG_TEXT;
		private string _IP;
		private DateTime? _TM;
		private string _YC_TYPE;

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
		/// 
		/// </summary>
		public string LOG_TEXT
		{
			get{ return _LOG_TEXT; }
			set
			{
				this.OnPropertyValueChange(_.LOG_TEXT, _LOG_TEXT, value);
				this._LOG_TEXT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YC_TYPE
		{
			get{ return _YC_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.YC_TYPE, _YC_TYPE, value);
				this._YC_TYPE = value;
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
				_.U_ID,
				_.LOG_TEXT,
				_.IP,
				_.TM,
				_.YC_TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._LOG_TEXT,
				this._IP,
				this._TM,
				this._YC_TYPE,
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
			public readonly static Field All = new Field("*", "T_YC_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_YC_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_YC_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOG_TEXT = new Field("LOG_TEXT", "T_YC_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IP = new Field("IP", "T_YC_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_YC_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YC_TYPE = new Field("YC_TYPE", "T_YC_LOG", "");
        }
        #endregion
	}
}