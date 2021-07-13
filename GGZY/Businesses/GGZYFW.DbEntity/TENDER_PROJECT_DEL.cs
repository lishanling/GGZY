using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_PROJECT_DEL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_PROJECT_DEL")]
    [Serializable]
    public partial class TENDER_PROJECT_DEL : FwEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_TYPE;
		private string _REGION_CODE;
		private string _TENDER_CONTENT;
		private string _OWNER_NAME;
		private string _TENDERER_NAME;
		private string _TENDERER_CODE_TYPE;
		private string _TENDERER_CODE;
		private string _TENDERER_ROLE;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE_TYPE;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_AGENCY_ROLE;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private DateTime? _CREATE_TIME;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_CODE;
		private string _APPROVE_DEPT_NAME;
		private string _APPROVE_DEPT_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_ID;
		private string _M_ATT_PROJECT_REG;
		private string _M_ATT_AGENT_COMMIT;
		private string _M_ATT_OTHER_FILE;
		private string _M_ATT_PROJECT_REG_APPROVE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private string _TENDER_PROJECT_CODE_OLD1;
		private decimal? _ID;
		private decimal? _M_DEL_USER;
		private DateTime? _M_DEL_TM;

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
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
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
		public string TENDER_CONTENT
		{
			get{ return _TENDER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTENT, _TENDER_CONTENT, value);
				this._TENDER_CONTENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OWNER_NAME
		{
			get{ return _OWNER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NAME, _OWNER_NAME, value);
				this._OWNER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_NAME
		{
			get{ return _TENDERER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NAME, _TENDERER_NAME, value);
				this._TENDERER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_CODE_TYPE
		{
			get{ return _TENDERER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE_TYPE, _TENDERER_CODE_TYPE, value);
				this._TENDERER_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_CODE
		{
			get{ return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_ROLE
		{
			get{ return _TENDERER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_ROLE, _TENDERER_ROLE, value);
				this._TENDERER_ROLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_CODE_TYPE
		{
			get{ return _TENDER_AGENCY_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE_TYPE, _TENDER_AGENCY_CODE_TYPE, value);
				this._TENDER_AGENCY_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get{ return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_ROLE
		{
			get{ return _TENDER_AGENCY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_ROLE, _TENDER_AGENCY_ROLE, value);
				this._TENDER_AGENCY_ROLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_MODE
		{
			get{ return _TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
				this._TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_ORGANIZE_FORM
		{
			get{ return _TENDER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ORGANIZE_FORM, _TENDER_ORGANIZE_FORM, value);
				this._TENDER_ORGANIZE_FORM = value;
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
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPERVISE_DEPT_CODE
		{
			get{ return _SUPERVISE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_CODE, _SUPERVISE_DEPT_CODE, value);
				this._SUPERVISE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPROVE_DEPT_NAME
		{
			get{ return _APPROVE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_NAME, _APPROVE_DEPT_NAME, value);
				this._APPROVE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPROVE_DEPT_CODE
		{
			get{ return _APPROVE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_CODE, _APPROVE_DEPT_CODE, value);
				this._APPROVE_DEPT_CODE = value;
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
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
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
		public string M_ATT_PROJECT_REG
		{
			get{ return _M_ATT_PROJECT_REG; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROJECT_REG, _M_ATT_PROJECT_REG, value);
				this._M_ATT_PROJECT_REG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_ATT_AGENT_COMMIT
		{
			get{ return _M_ATT_AGENT_COMMIT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_AGENT_COMMIT, _M_ATT_AGENT_COMMIT, value);
				this._M_ATT_AGENT_COMMIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_ATT_OTHER_FILE
		{
			get{ return _M_ATT_OTHER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_OTHER_FILE, _M_ATT_OTHER_FILE, value);
				this._M_ATT_OTHER_FILE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_ATT_PROJECT_REG_APPROVE
		{
			get{ return _M_ATT_PROJECT_REG_APPROVE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROJECT_REG_APPROVE, _M_ATT_PROJECT_REG_APPROVE, value);
				this._M_ATT_PROJECT_REG_APPROVE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_ATT_TENDER_AGENT_CONTRACT
		{
			get{ return _M_ATT_TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_AGENT_CONTRACT, _M_ATT_TENDER_AGENT_CONTRACT, value);
				this._M_ATT_TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1
		{
			get{ return _TENDER_PROJECT_CODE_OLD1; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE_OLD1, _TENDER_PROJECT_CODE_OLD1, value);
				this._TENDER_PROJECT_CODE_OLD1 = value;
			}
		}
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
		/// N
		/// </summary>
		public decimal? M_DEL_USER
		{
			get{ return _M_DEL_USER; }
			set
			{
				this.OnPropertyValueChange(_.M_DEL_USER, _M_DEL_USER, value);
				this._M_DEL_USER = value;
			}
		}
		/// <summary>
		/// N
		/// </summary>
		public DateTime? M_DEL_TM
		{
			get{ return _M_DEL_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_DEL_TM, _M_DEL_TM, value);
				this._M_DEL_TM = value;
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
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_TYPE,
				_.REGION_CODE,
				_.TENDER_CONTENT,
				_.OWNER_NAME,
				_.TENDERER_NAME,
				_.TENDERER_CODE_TYPE,
				_.TENDERER_CODE,
				_.TENDERER_ROLE,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE_TYPE,
				_.TENDER_AGENCY_CODE,
				_.TENDER_AGENCY_ROLE,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.CREATE_TIME,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_CODE,
				_.APPROVE_DEPT_NAME,
				_.APPROVE_DEPT_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_ID,
				_.M_ATT_PROJECT_REG,
				_.M_ATT_AGENT_COMMIT,
				_.M_ATT_OTHER_FILE,
				_.M_ATT_PROJECT_REG_APPROVE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.TENDER_PROJECT_CODE_OLD1,
				_.ID,
				_.M_DEL_USER,
				_.M_DEL_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_TYPE,
				this._REGION_CODE,
				this._TENDER_CONTENT,
				this._OWNER_NAME,
				this._TENDERER_NAME,
				this._TENDERER_CODE_TYPE,
				this._TENDERER_CODE,
				this._TENDERER_ROLE,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE_TYPE,
				this._TENDER_AGENCY_CODE,
				this._TENDER_AGENCY_ROLE,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._CREATE_TIME,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_CODE,
				this._APPROVE_DEPT_NAME,
				this._APPROVE_DEPT_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_ID,
				this._M_ATT_PROJECT_REG,
				this._M_ATT_AGENT_COMMIT,
				this._M_ATT_OTHER_FILE,
				this._M_ATT_PROJECT_REG_APPROVE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._TENDER_PROJECT_CODE_OLD1,
				this._ID,
				this._M_DEL_USER,
				this._M_DEL_TM,
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
			public readonly static Field All = new Field("*", "TENDER_PROJECT_DEL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "TENDER_PROJECT_DEL",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_CODE_TYPE = new Field("TENDERER_CODE_TYPE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_ROLE = new Field("TENDERER_ROLE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE_TYPE = new Field("TENDER_AGENCY_CODE_TYPE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_ROLE = new Field("TENDER_AGENCY_ROLE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPROVE_DEPT_NAME = new Field("APPROVE_DEPT_NAME", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPROVE_DEPT_CODE = new Field("APPROVE_DEPT_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG = new Field("M_ATT_PROJECT_REG", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ATT_AGENT_COMMIT = new Field("M_ATT_AGENT_COMMIT", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ATT_OTHER_FILE = new Field("M_ATT_OTHER_FILE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG_APPROVE = new Field("M_ATT_PROJECT_REG_APPROVE", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ATT_TENDER_AGENT_CONTRACT = new Field("M_ATT_TENDER_AGENT_CONTRACT", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE_OLD1 = new Field("TENDER_PROJECT_CODE_OLD1", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TENDER_PROJECT_DEL", "");
            /// <summary>
			/// N
			/// </summary>
			public readonly static Field M_DEL_USER = new Field("M_DEL_USER", "TENDER_PROJECT_DEL", "N");
            /// <summary>
			/// N
			/// </summary>
			public readonly static Field M_DEL_TM = new Field("M_DEL_TM", "TENDER_PROJECT_DEL", "N");
        }
        #endregion
	}
}