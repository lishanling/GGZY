using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP_FIELD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP_FIELD")]
    [Serializable]
    public partial class T_RP_FIELD : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _RP_CODE;
		private string _FNAME_C;
		private string _FNAME;
		private string _FTYPE;
		private string _STYLE;
		private string _FORMAT_METHOD;
		private string _FORMAT_PAR;
		private decimal? _ORDER_ID;
		private string _FOREIGN_SQL;
		private decimal? _WIDTH;
		private string _ALIGN;

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
		public string RP_CODE
		{
			get{ return _RP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RP_CODE, _RP_CODE, value);
				this._RP_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FNAME_C
		{
			get{ return _FNAME_C; }
			set
			{
				this.OnPropertyValueChange(_.FNAME_C, _FNAME_C, value);
				this._FNAME_C = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FNAME
		{
			get{ return _FNAME; }
			set
			{
				this.OnPropertyValueChange(_.FNAME, _FNAME, value);
				this._FNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FTYPE
		{
			get{ return _FTYPE; }
			set
			{
				this.OnPropertyValueChange(_.FTYPE, _FTYPE, value);
				this._FTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STYLE
		{
			get{ return _STYLE; }
			set
			{
				this.OnPropertyValueChange(_.STYLE, _STYLE, value);
				this._STYLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FORMAT_METHOD
		{
			get{ return _FORMAT_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.FORMAT_METHOD, _FORMAT_METHOD, value);
				this._FORMAT_METHOD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FORMAT_PAR
		{
			get{ return _FORMAT_PAR; }
			set
			{
				this.OnPropertyValueChange(_.FORMAT_PAR, _FORMAT_PAR, value);
				this._FORMAT_PAR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDER_ID
		{
			get{ return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FOREIGN_SQL
		{
			get{ return _FOREIGN_SQL; }
			set
			{
				this.OnPropertyValueChange(_.FOREIGN_SQL, _FOREIGN_SQL, value);
				this._FOREIGN_SQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WIDTH
		{
			get{ return _WIDTH; }
			set
			{
				this.OnPropertyValueChange(_.WIDTH, _WIDTH, value);
				this._WIDTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALIGN
		{
			get{ return _ALIGN; }
			set
			{
				this.OnPropertyValueChange(_.ALIGN, _ALIGN, value);
				this._ALIGN = value;
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
				_.RP_CODE,
				_.FNAME_C,
				_.FNAME,
				_.FTYPE,
				_.STYLE,
				_.FORMAT_METHOD,
				_.FORMAT_PAR,
				_.ORDER_ID,
				_.FOREIGN_SQL,
				_.WIDTH,
				_.ALIGN,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._RP_CODE,
				this._FNAME_C,
				this._FNAME,
				this._FTYPE,
				this._STYLE,
				this._FORMAT_METHOD,
				this._FORMAT_PAR,
				this._ORDER_ID,
				this._FOREIGN_SQL,
				this._WIDTH,
				this._ALIGN,
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
			public readonly static Field All = new Field("*", "T_RP_FIELD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_CODE = new Field("RP_CODE", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FNAME_C = new Field("FNAME_C", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FNAME = new Field("FNAME", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FTYPE = new Field("FTYPE", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STYLE = new Field("STYLE", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FORMAT_METHOD = new Field("FORMAT_METHOD", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FORMAT_PAR = new Field("FORMAT_PAR", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FOREIGN_SQL = new Field("FOREIGN_SQL", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WIDTH = new Field("WIDTH", "T_RP_FIELD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ALIGN = new Field("ALIGN", "T_RP_FIELD", "");
        }
        #endregion
	}
}