using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_BAK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_BAK")]
    [Serializable]
    public partial class T_USER_BAK : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _USERNAME;
		private string _PASSWORD;
		private string _EMAIL;
		private decimal? _TYPE;
		private string _CA_CODE;
		private DateTime? _REG_TM;
		private string _API_CODE;
		private string _API_KEY;
		private string _ROLEIDS;
		private string _SESSION_ID;
		private decimal? _P_ID;
		private decimal? _GENDER;
		private decimal? _IS_ENABLE;
		private string _COMPANY_CODE;
		private string _MANAGE_NAME;
		private string _AREACODE;
		private string _ZP_FAX;
		private string _ZP_UNIT;
		private string _ZP_ADDRESS;
		private decimal? _ZP_ID;
		private string _ZP_PHONE;
		private string _CHECK_CODE;
		private decimal? _IS_CHECK_PHONE;
		private DateTime? _EFECTIVE_TIME;
		private decimal? _IS_AUDIT;
		private decimal? _AUDIT_BY;
		private DateTime? _AUDIT_TM;
		private decimal? _IS_DELETE;

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
		public string USERNAME
		{
			get{ return _USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.USERNAME, _USERNAME, value);
				this._USERNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PASSWORD
		{
			get{ return _PASSWORD; }
			set
			{
				this.OnPropertyValueChange(_.PASSWORD, _PASSWORD, value);
				this._PASSWORD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CA_CODE
		{
			get{ return _CA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CA_CODE, _CA_CODE, value);
				this._CA_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? REG_TM
		{
			get{ return _REG_TM; }
			set
			{
				this.OnPropertyValueChange(_.REG_TM, _REG_TM, value);
				this._REG_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string API_CODE
		{
			get{ return _API_CODE; }
			set
			{
				this.OnPropertyValueChange(_.API_CODE, _API_CODE, value);
				this._API_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string API_KEY
		{
			get{ return _API_KEY; }
			set
			{
				this.OnPropertyValueChange(_.API_KEY, _API_KEY, value);
				this._API_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLEIDS
		{
			get{ return _ROLEIDS; }
			set
			{
				this.OnPropertyValueChange(_.ROLEIDS, _ROLEIDS, value);
				this._ROLEIDS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SESSION_ID
		{
			get{ return _SESSION_ID; }
			set
			{
				this.OnPropertyValueChange(_.SESSION_ID, _SESSION_ID, value);
				this._SESSION_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? P_ID
		{
			get{ return _P_ID; }
			set
			{
				this.OnPropertyValueChange(_.P_ID, _P_ID, value);
				this._P_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GENDER
		{
			get{ return _GENDER; }
			set
			{
				this.OnPropertyValueChange(_.GENDER, _GENDER, value);
				this._GENDER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPANY_CODE
		{
			get{ return _COMPANY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY_CODE, _COMPANY_CODE, value);
				this._COMPANY_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANAGE_NAME
		{
			get{ return _MANAGE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MANAGE_NAME, _MANAGE_NAME, value);
				this._MANAGE_NAME = value;
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
		public string ZP_FAX
		{
			get{ return _ZP_FAX; }
			set
			{
				this.OnPropertyValueChange(_.ZP_FAX, _ZP_FAX, value);
				this._ZP_FAX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_UNIT
		{
			get{ return _ZP_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.ZP_UNIT, _ZP_UNIT, value);
				this._ZP_UNIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_ADDRESS
		{
			get{ return _ZP_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ADDRESS, _ZP_ADDRESS, value);
				this._ZP_ADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZP_ID
		{
			get{ return _ZP_ID; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ID, _ZP_ID, value);
				this._ZP_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_PHONE
		{
			get{ return _ZP_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_PHONE, _ZP_PHONE, value);
				this._ZP_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHECK_CODE
		{
			get{ return _CHECK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_CODE, _CHECK_CODE, value);
				this._CHECK_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_CHECK_PHONE
		{
			get{ return _IS_CHECK_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_CHECK_PHONE, _IS_CHECK_PHONE, value);
				this._IS_CHECK_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EFECTIVE_TIME
		{
			get{ return _EFECTIVE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.EFECTIVE_TIME, _EFECTIVE_TIME, value);
				this._EFECTIVE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_AUDIT
		{
			get{ return _IS_AUDIT; }
			set
			{
				this.OnPropertyValueChange(_.IS_AUDIT, _IS_AUDIT, value);
				this._IS_AUDIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AUDIT_BY
		{
			get{ return _AUDIT_BY; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_BY, _AUDIT_BY, value);
				this._AUDIT_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AUDIT_TM
		{
			get{ return _AUDIT_TM; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_TM, _AUDIT_TM, value);
				this._AUDIT_TM = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.ID,
				_.USERNAME,
				_.PASSWORD,
				_.EMAIL,
				_.TYPE,
				_.CA_CODE,
				_.REG_TM,
				_.API_CODE,
				_.API_KEY,
				_.ROLEIDS,
				_.SESSION_ID,
				_.P_ID,
				_.GENDER,
				_.IS_ENABLE,
				_.COMPANY_CODE,
				_.MANAGE_NAME,
				_.AREACODE,
				_.ZP_FAX,
				_.ZP_UNIT,
				_.ZP_ADDRESS,
				_.ZP_ID,
				_.ZP_PHONE,
				_.CHECK_CODE,
				_.IS_CHECK_PHONE,
				_.EFECTIVE_TIME,
				_.IS_AUDIT,
				_.AUDIT_BY,
				_.AUDIT_TM,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._USERNAME,
				this._PASSWORD,
				this._EMAIL,
				this._TYPE,
				this._CA_CODE,
				this._REG_TM,
				this._API_CODE,
				this._API_KEY,
				this._ROLEIDS,
				this._SESSION_ID,
				this._P_ID,
				this._GENDER,
				this._IS_ENABLE,
				this._COMPANY_CODE,
				this._MANAGE_NAME,
				this._AREACODE,
				this._ZP_FAX,
				this._ZP_UNIT,
				this._ZP_ADDRESS,
				this._ZP_ID,
				this._ZP_PHONE,
				this._CHECK_CODE,
				this._IS_CHECK_PHONE,
				this._EFECTIVE_TIME,
				this._IS_AUDIT,
				this._AUDIT_BY,
				this._AUDIT_TM,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "T_USER_BAK");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PASSWORD = new Field("PASSWORD", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CA_CODE = new Field("CA_CODE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REG_TM = new Field("REG_TM", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field API_CODE = new Field("API_CODE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field API_KEY = new Field("API_KEY", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ROLEIDS = new Field("ROLEIDS", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SESSION_ID = new Field("SESSION_ID", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_ID = new Field("P_ID", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPANY_CODE = new Field("COMPANY_CODE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MANAGE_NAME = new Field("MANAGE_NAME", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_FAX = new Field("ZP_FAX", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_UNIT = new Field("ZP_UNIT", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_ADDRESS = new Field("ZP_ADDRESS", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_ID = new Field("ZP_ID", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_PHONE = new Field("ZP_PHONE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CHECK_CODE = new Field("CHECK_CODE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_CHECK_PHONE = new Field("IS_CHECK_PHONE", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EFECTIVE_TIME = new Field("EFECTIVE_TIME", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_AUDIT = new Field("IS_AUDIT", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AUDIT_BY = new Field("AUDIT_BY", "T_USER_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AUDIT_TM = new Field("AUDIT_TM", "T_USER_BAK", "");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "T_USER_BAK", "是否删除");
        }
        #endregion
	}
}