using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_TJ_ALLCREATE_XZJD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_TJ_ALLCREATE_XZJD")]
    [Serializable]
    public partial class MV_TJ_ALLCREATE_XZJD : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_DATA_SOURCE;
		private decimal? _PROJECT_CATEGORY;
		private string _KIND;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _PROJECT_TYPE;
		private string _UNIFIED_DEAL_CODE;
		private DateTime? _CREATE_TIME;
		private DateTime? _T_TM;
		private string _REGION_CODE;
		private string _AREACODE;
		private string _AREANAME;
		private string _PLATFORM_CODE;
		private string _PLATFORM_NAME;
		private DateTime? _BID_OPEN_TIME;

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
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
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
		public DateTime? T_TM
		{
			get{ return _T_TM; }
			set
			{
				this.OnPropertyValueChange(_.T_TM, _T_TM, value);
				this._T_TM = value;
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
		public DateTime? BID_OPEN_TIME
		{
			get{ return _BID_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIME, _BID_OPEN_TIME, value);
				this._BID_OPEN_TIME = value;
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
				_.M_ID,
				_.M_DATA_SOURCE,
				_.PROJECT_CATEGORY,
				_.KIND,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.PROJECT_TYPE,
				_.UNIFIED_DEAL_CODE,
				_.CREATE_TIME,
				_.T_TM,
				_.REGION_CODE,
				_.AREACODE,
				_.AREANAME,
				_.PLATFORM_CODE,
				_.PLATFORM_NAME,
				_.BID_OPEN_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_DATA_SOURCE,
				this._PROJECT_CATEGORY,
				this._KIND,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._PROJECT_TYPE,
				this._UNIFIED_DEAL_CODE,
				this._CREATE_TIME,
				this._T_TM,
				this._REGION_CODE,
				this._AREACODE,
				this._AREANAME,
				this._PLATFORM_CODE,
				this._PLATFORM_NAME,
				this._BID_OPEN_TIME,
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
			public readonly static Field All = new Field("*", "MV_TJ_ALLCREATE_XZJD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CATEGORY = new Field("PROJECT_CATEGORY", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field T_TM = new Field("T_TM", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME", "MV_TJ_ALLCREATE_XZJD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "MV_TJ_ALLCREATE_XZJD", "");
        }
        #endregion
	}
}