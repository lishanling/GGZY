using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_TJ_ALLTB_UPLOAD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TJ_ALLTB_UPLOAD")]
    [Serializable]
    public partial class T_TJ_ALLTB_UPLOAD : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _PLATFORM_CODE;
		private string _M_KEY;
		private decimal? _M_IS_HISTORY;
		private string _M_TABLE;
		private decimal? _M_CREATEBY;
		private decimal? _UPLOAD_ID;

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
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_TABLE
		{
			get{ return _M_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.M_TABLE, _M_TABLE, value);
				this._M_TABLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UPLOAD_ID
		{
			get{ return _UPLOAD_ID; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD_ID, _UPLOAD_ID, value);
				this._UPLOAD_ID = value;
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
				_.M_DATA_SOURCE,
				_.M_TM,
				_.PLATFORM_CODE,
				_.M_KEY,
				_.M_IS_HISTORY,
				_.M_TABLE,
				_.M_CREATEBY,
				_.UPLOAD_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._PLATFORM_CODE,
				this._M_KEY,
				this._M_IS_HISTORY,
				this._M_TABLE,
				this._M_CREATEBY,
				this._UPLOAD_ID,
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
			public readonly static Field All = new Field("*", "T_TJ_ALLTB_UPLOAD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TABLE = new Field("M_TABLE", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "T_TJ_ALLTB_UPLOAD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPLOAD_ID = new Field("UPLOAD_ID", "T_TJ_ALLTB_UPLOAD", "");
        }
        #endregion
	}
}