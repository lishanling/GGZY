using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类MV_GCJS_GGXX_HISTORY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_GCJS_GGXX_HISTORY")]
    [Serializable]
    public partial class MV_GCJS_GGXX_HISTORY : JdEntity
    {
        #region Model
		private decimal? _PROJECT_CATEGORY;
		private string _KIND;
		private string _HY_TYPE;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _PROJECT_TYPE;
		private string _PROTYPE_TEXT;
		private string _NAME;
		private string _TITLE;
		private string _GGTYPE;
		private string _REGION_CODE;
		private string _AREANAME;
		private string _PLATFORM_CODE;
		private string _PLATFORM_NAME;
		private DateTime? _TM;

		/// <summary>
		/// 
		/// </summary>
		public decimal? PROJECT_CATEGORY
		{
			get{ return _PROJECT_CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CATEGORY, _PROJECT_CATEGORY, value);
				this._PROJECT_CATEGORY = value;
			}
		}
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
		public string HY_TYPE
		{
			get{ return _HY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.HY_TYPE, _HY_TYPE, value);
				this._HY_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_TYPE
		{
			get{ return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
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
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
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
				_.PROJECT_CATEGORY,
				_.KIND,
				_.HY_TYPE,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.PROJECT_TYPE,
				_.PROTYPE_TEXT,
				_.NAME,
				_.TITLE,
				_.GGTYPE,
				_.REGION_CODE,
				_.AREANAME,
				_.PLATFORM_CODE,
				_.PLATFORM_NAME,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CATEGORY,
				this._KIND,
				this._HY_TYPE,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._PROJECT_TYPE,
				this._PROTYPE_TEXT,
				this._NAME,
				this._TITLE,
				this._GGTYPE,
				this._REGION_CODE,
				this._AREANAME,
				this._PLATFORM_CODE,
				this._PLATFORM_NAME,
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
			public readonly static Field All = new Field("*", "MV_GCJS_GGXX_HISTORY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CATEGORY = new Field("PROJECT_CATEGORY", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HY_TYPE = new Field("HY_TYPE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROTYPE_TEXT = new Field("PROTYPE_TEXT", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GGTYPE = new Field("GGTYPE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME", "MV_GCJS_GGXX_HISTORY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "MV_GCJS_GGXX_HISTORY", "");
        }
        #endregion
	}
}