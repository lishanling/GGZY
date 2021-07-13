using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_JYXX。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_JYXX")]
    [Serializable]
    public partial class MV_JYXX : FwEntity
    {
        #region Model
		private string _KIND;
		private string _TITLE;
		private string _GGTYPE;
		private string _NAME;
		private decimal? _M_ID;
		private string _PLATFORM_CODE;
		private string _PLATFORM_NAME;
		private DateTime? _TM1;
		private string _PROCODE;
		private string _AREACODE;
		private string _AREANAME;
		private string _PROTYPE_TEXT;
		private string _PROTYPE;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_PROJECT_TYPE;
		private DateTime? _TM;

		/// <summary>
		/// 
		/// </summary>
		public string KIND
		{
			get{ return _KIND; }
			set
			{
				this.OnPropertyValueChange(_.KIND, _KIND, value);
				this._KIND = value;
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
		public string GGTYPE
		{
			get{ return _GGTYPE; }
			set
			{
				this.OnPropertyValueChange(_.GGTYPE, _GGTYPE, value);
				this._GGTYPE = value;
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
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
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
		public string PLATFORM_NAME
		{
			get{ return _PLATFORM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_NAME, _PLATFORM_NAME, value);
				this._PLATFORM_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM1
		{
			get{ return _TM1; }
			set
			{
				this.OnPropertyValueChange(_.TM1, _TM1, value);
				this._TM1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROCODE
		{
			get{ return _PROCODE; }
			set
			{
				this.OnPropertyValueChange(_.PROCODE, _PROCODE, value);
				this._PROCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREANAME
		{
			get{ return _AREANAME; }
			set
			{
				this.OnPropertyValueChange(_.AREANAME, _AREANAME, value);
				this._AREANAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROTYPE_TEXT
		{
			get{ return _PROTYPE_TEXT; }
			set
			{
				this.OnPropertyValueChange(_.PROTYPE_TEXT, _PROTYPE_TEXT, value);
				this._PROTYPE_TEXT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROTYPE
		{
			get{ return _PROTYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROTYPE, _PROTYPE, value);
				this._PROTYPE = value;
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
		public string M_PROJECT_TYPE
		{
			get{ return _M_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.M_PROJECT_TYPE, _M_PROJECT_TYPE, value);
				this._M_PROJECT_TYPE = value;
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.KIND,
				_.TITLE,
				_.GGTYPE,
				_.NAME,
				_.M_ID,
				_.PLATFORM_CODE,
				_.PLATFORM_NAME,
				_.TM1,
				_.PROCODE,
				_.AREACODE,
				_.AREANAME,
				_.PROTYPE_TEXT,
				_.PROTYPE,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_PROJECT_TYPE,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._KIND,
				this._TITLE,
				this._GGTYPE,
				this._NAME,
				this._M_ID,
				this._PLATFORM_CODE,
				this._PLATFORM_NAME,
				this._TM1,
				this._PROCODE,
				this._AREACODE,
				this._AREANAME,
				this._PROTYPE_TEXT,
				this._PROTYPE,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_PROJECT_TYPE,
				this._TM,
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
			public readonly static Field All = new Field("*", "MV_JYXX");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GGTYPE = new Field("GGTYPE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM1 = new Field("TM1", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROCODE = new Field("PROCODE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROTYPE_TEXT = new Field("PROTYPE_TEXT", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROTYPE = new Field("PROTYPE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_PROJECT_TYPE = new Field("M_PROJECT_TYPE", "MV_JYXX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "MV_JYXX", "");
        }
        #endregion
	}
}