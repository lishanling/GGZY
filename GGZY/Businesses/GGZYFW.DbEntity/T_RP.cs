using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_RP。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RP")]
    [Serializable]
    public partial class T_RP : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _RP_CODE;
		private string _NAME;
		private string _DB_CONFIG;
		private decimal? _HEAD_TYPE;
		private string _HEAD_HTML;
		private decimal? _SQL_TYPE;
		private string _GET_DATA_SQL;
		private decimal? _RP_TYPE;
		private decimal? _SEARCH_TYPE;
		private string _SEARCH_HTML;
		private string _SEARCH_PARAM;
		private string _CREATE_BY;
		private DateTime? _CREATE_TIME;
		private string _STCD_TYPE;
		private string _RP_PARAM;
		private string _PAGE_FOOT;
		private string _PAGE_TITLE;
		private string _PAGE_HEAD;
		private string _RP_SERVER_PARAM;
		private string _TREE_CODE;
		private decimal? _PAGE_HEAD_SCRIPT_TYPE;
		private string _PAGE_HEAD_SCRIPT;

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
		public decimal? HEAD_TYPE
		{
			get{ return _HEAD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.HEAD_TYPE, _HEAD_TYPE, value);
				this._HEAD_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEAD_HTML
		{
			get{ return _HEAD_HTML; }
			set
			{
				this.OnPropertyValueChange(_.HEAD_HTML, _HEAD_HTML, value);
				this._HEAD_HTML = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SQL_TYPE
		{
			get{ return _SQL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SQL_TYPE, _SQL_TYPE, value);
				this._SQL_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GET_DATA_SQL
		{
			get{ return _GET_DATA_SQL; }
			set
			{
				this.OnPropertyValueChange(_.GET_DATA_SQL, _GET_DATA_SQL, value);
				this._GET_DATA_SQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RP_TYPE
		{
			get{ return _RP_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.RP_TYPE, _RP_TYPE, value);
				this._RP_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SEARCH_TYPE
		{
			get{ return _SEARCH_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SEARCH_TYPE, _SEARCH_TYPE, value);
				this._SEARCH_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEARCH_HTML
		{
			get{ return _SEARCH_HTML; }
			set
			{
				this.OnPropertyValueChange(_.SEARCH_HTML, _SEARCH_HTML, value);
				this._SEARCH_HTML = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEARCH_PARAM
		{
			get{ return _SEARCH_PARAM; }
			set
			{
				this.OnPropertyValueChange(_.SEARCH_PARAM, _SEARCH_PARAM, value);
				this._SEARCH_PARAM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STCD_TYPE
		{
			get{ return _STCD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.STCD_TYPE, _STCD_TYPE, value);
				this._STCD_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RP_PARAM
		{
			get{ return _RP_PARAM; }
			set
			{
				this.OnPropertyValueChange(_.RP_PARAM, _RP_PARAM, value);
				this._RP_PARAM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAGE_FOOT
		{
			get{ return _PAGE_FOOT; }
			set
			{
				this.OnPropertyValueChange(_.PAGE_FOOT, _PAGE_FOOT, value);
				this._PAGE_FOOT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAGE_TITLE
		{
			get{ return _PAGE_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.PAGE_TITLE, _PAGE_TITLE, value);
				this._PAGE_TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAGE_HEAD
		{
			get{ return _PAGE_HEAD; }
			set
			{
				this.OnPropertyValueChange(_.PAGE_HEAD, _PAGE_HEAD, value);
				this._PAGE_HEAD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RP_SERVER_PARAM
		{
			get{ return _RP_SERVER_PARAM; }
			set
			{
				this.OnPropertyValueChange(_.RP_SERVER_PARAM, _RP_SERVER_PARAM, value);
				this._RP_SERVER_PARAM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TREE_CODE
		{
			get{ return _TREE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TREE_CODE, _TREE_CODE, value);
				this._TREE_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PAGE_HEAD_SCRIPT_TYPE
		{
			get{ return _PAGE_HEAD_SCRIPT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PAGE_HEAD_SCRIPT_TYPE, _PAGE_HEAD_SCRIPT_TYPE, value);
				this._PAGE_HEAD_SCRIPT_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAGE_HEAD_SCRIPT
		{
			get{ return _PAGE_HEAD_SCRIPT; }
			set
			{
				this.OnPropertyValueChange(_.PAGE_HEAD_SCRIPT, _PAGE_HEAD_SCRIPT, value);
				this._PAGE_HEAD_SCRIPT = value;
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
				_.RP_CODE,
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
				_.NAME,
				_.DB_CONFIG,
				_.HEAD_TYPE,
				_.HEAD_HTML,
				_.SQL_TYPE,
				_.GET_DATA_SQL,
				_.RP_TYPE,
				_.SEARCH_TYPE,
				_.SEARCH_HTML,
				_.SEARCH_PARAM,
				_.CREATE_BY,
				_.CREATE_TIME,
				_.STCD_TYPE,
				_.RP_PARAM,
				_.PAGE_FOOT,
				_.PAGE_TITLE,
				_.PAGE_HEAD,
				_.RP_SERVER_PARAM,
				_.TREE_CODE,
				_.PAGE_HEAD_SCRIPT_TYPE,
				_.PAGE_HEAD_SCRIPT,
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
				this._NAME,
				this._DB_CONFIG,
				this._HEAD_TYPE,
				this._HEAD_HTML,
				this._SQL_TYPE,
				this._GET_DATA_SQL,
				this._RP_TYPE,
				this._SEARCH_TYPE,
				this._SEARCH_HTML,
				this._SEARCH_PARAM,
				this._CREATE_BY,
				this._CREATE_TIME,
				this._STCD_TYPE,
				this._RP_PARAM,
				this._PAGE_FOOT,
				this._PAGE_TITLE,
				this._PAGE_HEAD,
				this._RP_SERVER_PARAM,
				this._TREE_CODE,
				this._PAGE_HEAD_SCRIPT_TYPE,
				this._PAGE_HEAD_SCRIPT,
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
			public readonly static Field All = new Field("*", "T_RP");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_CODE = new Field("RP_CODE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DB_CONFIG = new Field("DB_CONFIG", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HEAD_TYPE = new Field("HEAD_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HEAD_HTML = new Field("HEAD_HTML", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SQL_TYPE = new Field("SQL_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GET_DATA_SQL = new Field("GET_DATA_SQL", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_TYPE = new Field("RP_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCH_TYPE = new Field("SEARCH_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCH_HTML = new Field("SEARCH_HTML", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCH_PARAM = new Field("SEARCH_PARAM", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD_TYPE = new Field("STCD_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_PARAM = new Field("RP_PARAM", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGE_FOOT = new Field("PAGE_FOOT", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGE_TITLE = new Field("PAGE_TITLE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGE_HEAD = new Field("PAGE_HEAD", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RP_SERVER_PARAM = new Field("RP_SERVER_PARAM", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TREE_CODE = new Field("TREE_CODE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGE_HEAD_SCRIPT_TYPE = new Field("PAGE_HEAD_SCRIPT_TYPE", "T_RP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGE_HEAD_SCRIPT = new Field("PAGE_HEAD_SCRIPT", "T_RP", "");
        }
        #endregion
	}
}