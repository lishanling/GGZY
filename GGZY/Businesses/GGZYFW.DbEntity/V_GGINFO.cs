using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类V_GGINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("V_GGINFO")]
    [Serializable]
    public partial class V_GGINFO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _BULLETIN_TYPE;
		private string _TENDER_PROJECT_CODE;
		private string _NOTICE_NAME;
		private DateTime? _NOTICE_SEND_TIME;
		private string _REGION_CODE;
		private string _TENDER_PROJECT_TYPE;
		private decimal? _M_CREATOR;
		private string _ZBGG;
		private decimal? _BGGG;
		private decimal? _DYGS;
		private decimal? _ZBHXR;
		private decimal? _ZBJG;
		private string _ZGYS;

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
		public string BULLETIN_TYPE
		{
			get{ return _BULLETIN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_TYPE, _BULLETIN_TYPE, value);
				this._BULLETIN_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
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
		public string TENDER_PROJECT_TYPE
		{
			get{ return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZBGG
		{
			get{ return _ZBGG; }
			set
			{
				this.OnPropertyValueChange(_.ZBGG, _ZBGG, value);
				this._ZBGG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BGGG
		{
			get{ return _BGGG; }
			set
			{
				this.OnPropertyValueChange(_.BGGG, _BGGG, value);
				this._BGGG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DYGS
		{
			get{ return _DYGS; }
			set
			{
				this.OnPropertyValueChange(_.DYGS, _DYGS, value);
				this._DYGS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZBHXR
		{
			get{ return _ZBHXR; }
			set
			{
				this.OnPropertyValueChange(_.ZBHXR, _ZBHXR, value);
				this._ZBHXR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZBJG
		{
			get{ return _ZBJG; }
			set
			{
				this.OnPropertyValueChange(_.ZBJG, _ZBJG, value);
				this._ZBJG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGYS
		{
			get{ return _ZGYS; }
			set
			{
				this.OnPropertyValueChange(_.ZGYS, _ZGYS, value);
				this._ZGYS = value;
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
				_.BULLETIN_TYPE,
				_.TENDER_PROJECT_CODE,
				_.NOTICE_NAME,
				_.NOTICE_SEND_TIME,
				_.REGION_CODE,
				_.TENDER_PROJECT_TYPE,
				_.M_CREATOR,
				_.ZBGG,
				_.BGGG,
				_.DYGS,
				_.ZBHXR,
				_.ZBJG,
				_.ZGYS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._BULLETIN_TYPE,
				this._TENDER_PROJECT_CODE,
				this._NOTICE_NAME,
				this._NOTICE_SEND_TIME,
				this._REGION_CODE,
				this._TENDER_PROJECT_TYPE,
				this._M_CREATOR,
				this._ZBGG,
				this._BGGG,
				this._DYGS,
				this._ZBHXR,
				this._ZBJG,
				this._ZGYS,
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
			public readonly static Field All = new Field("*", "V_GGINFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULLETIN_TYPE = new Field("BULLETIN_TYPE", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBGG = new Field("ZBGG", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BGGG = new Field("BGGG", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DYGS = new Field("DYGS", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBHXR = new Field("ZBHXR", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBJG = new Field("ZBJG", "V_GGINFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZGYS = new Field("ZGYS", "V_GGINFO", "");
        }
        #endregion
	}
}