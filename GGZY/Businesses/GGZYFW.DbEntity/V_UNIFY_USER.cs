using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类V_UNIFY_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("V_UNIFY_USER")]
    [Serializable]
    public partial class V_UNIFY_USER : FwEntity
    {
        #region Model
        private string _APPKEY;
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
        private string _MOBILE;

        /// <summary>
        /// 
        /// </summary>
        public string APPKEY
        {
            get { return _APPKEY; }
            set
            {
                this.OnPropertyValueChange(_.APPKEY, _APPKEY, value);
                this._APPKEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ID
        {
            get { return _ID; }
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
            get { return _USERNAME; }
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
            get { return _PASSWORD; }
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
            get { return _EMAIL; }
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
            get { return _TYPE; }
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
            get { return _CA_CODE; }
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
            get { return _REG_TM; }
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
            get { return _API_CODE; }
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
            get { return _API_KEY; }
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
            get { return _ROLEIDS; }
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
            get { return _SESSION_ID; }
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
            get { return _P_ID; }
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
            get { return _GENDER; }
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
            get { return _IS_ENABLE; }
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
            get { return _COMPANY_CODE; }
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
            get { return _MANAGE_NAME; }
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
            get { return _AREACODE; }
            set
            {
                this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
                this._AREACODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MOBILE
        {
            get { return _MOBILE; }
            set
            {
                this.OnPropertyValueChange(_.MOBILE, _MOBILE, value);
                this._MOBILE = value;
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
                _.APPKEY,
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
                _.MOBILE,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._APPKEY,
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
                this._MOBILE,
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
            public readonly static Field All = new Field("*", "V_UNIFY_USER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPKEY = new Field("APPKEY", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PASSWORD = new Field("PASSWORD", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CA_CODE = new Field("CA_CODE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REG_TM = new Field("REG_TM", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field API_CODE = new Field("API_CODE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field API_KEY = new Field("API_KEY", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ROLEIDS = new Field("ROLEIDS", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SESSION_ID = new Field("SESSION_ID", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_ID = new Field("P_ID", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COMPANY_CODE = new Field("COMPANY_CODE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MANAGE_NAME = new Field("MANAGE_NAME", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "V_UNIFY_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MOBILE = new Field("MOBILE", "V_UNIFY_USER", "");
        }
        #endregion
    }
}