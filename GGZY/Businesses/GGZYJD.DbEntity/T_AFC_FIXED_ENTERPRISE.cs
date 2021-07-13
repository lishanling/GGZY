using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_FIXED_ENTERPRISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_FIXED_ENTERPRISE")]
    [Serializable]
    public partial class T_AFC_FIXED_ENTERPRISE : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _CONTACT_EMAIL;
        private string _CONTACT_NAME;
        private string _CONTACT_PHONE;
        private string _CONTACT_TEL;
        private string _ENTERPRISE_ID;
        private string _ENTERPRISE_NAME;
        private string _LEREP_CERTNO;
        private string _LEREP_CERTTYPE;
        private string _PROJECT_CODE;
        private string _ENTERPRISE_PLACE;
        private string _CHINA_FOREIGN_SHARE_RATIO;
        private string _BUSINESS_SCOPE;
        private string _CONTACT_FAX;
        private string _CORRESPONDENCE_ADDRESS;
        private string _ENTERPRISE_NATURE;
        private string _CONTACT_TYPE;

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string GUID
        {
            get { return _GUID; }
            set
            {
                this.OnPropertyValueChange(_.GUID, _GUID, value);
                this._GUID = value;
            }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? SYNCTIME
        {
            get { return _SYNCTIME; }
            set
            {
                this.OnPropertyValueChange(_.SYNCTIME, _SYNCTIME, value);
                this._SYNCTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_EMAIL
        {
            get { return _CONTACT_EMAIL; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_EMAIL, _CONTACT_EMAIL, value);
                this._CONTACT_EMAIL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_NAME
        {
            get { return _CONTACT_NAME; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_NAME, _CONTACT_NAME, value);
                this._CONTACT_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_PHONE
        {
            get { return _CONTACT_PHONE; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_PHONE, _CONTACT_PHONE, value);
                this._CONTACT_PHONE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_TEL
        {
            get { return _CONTACT_TEL; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_TEL, _CONTACT_TEL, value);
                this._CONTACT_TEL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISE_ID
        {
            get { return _ENTERPRISE_ID; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISE_ID, _ENTERPRISE_ID, value);
                this._ENTERPRISE_ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISE_NAME
        {
            get { return _ENTERPRISE_NAME; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISE_NAME, _ENTERPRISE_NAME, value);
                this._ENTERPRISE_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEREP_CERTNO
        {
            get { return _LEREP_CERTNO; }
            set
            {
                this.OnPropertyValueChange(_.LEREP_CERTNO, _LEREP_CERTNO, value);
                this._LEREP_CERTNO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEREP_CERTTYPE
        {
            get { return _LEREP_CERTTYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEREP_CERTTYPE, _LEREP_CERTTYPE, value);
                this._LEREP_CERTTYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CODE
        {
            get { return _PROJECT_CODE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
                this._PROJECT_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISE_PLACE
        {
            get { return _ENTERPRISE_PLACE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISE_PLACE, _ENTERPRISE_PLACE, value);
                this._ENTERPRISE_PLACE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHINA_FOREIGN_SHARE_RATIO
        {
            get { return _CHINA_FOREIGN_SHARE_RATIO; }
            set
            {
                this.OnPropertyValueChange(_.CHINA_FOREIGN_SHARE_RATIO, _CHINA_FOREIGN_SHARE_RATIO, value);
                this._CHINA_FOREIGN_SHARE_RATIO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUSINESS_SCOPE
        {
            get { return _BUSINESS_SCOPE; }
            set
            {
                this.OnPropertyValueChange(_.BUSINESS_SCOPE, _BUSINESS_SCOPE, value);
                this._BUSINESS_SCOPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_FAX
        {
            get { return _CONTACT_FAX; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_FAX, _CONTACT_FAX, value);
                this._CONTACT_FAX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CORRESPONDENCE_ADDRESS
        {
            get { return _CORRESPONDENCE_ADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.CORRESPONDENCE_ADDRESS, _CORRESPONDENCE_ADDRESS, value);
                this._CORRESPONDENCE_ADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISE_NATURE
        {
            get { return _ENTERPRISE_NATURE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISE_NATURE, _ENTERPRISE_NATURE, value);
                this._ENTERPRISE_NATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_TYPE
        {
            get { return _CONTACT_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_TYPE, _CONTACT_TYPE, value);
                this._CONTACT_TYPE = value;
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
                _.GUID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.GUID,
                _.SYNCTIME,
                _.CONTACT_EMAIL,
                _.CONTACT_NAME,
                _.CONTACT_PHONE,
                _.CONTACT_TEL,
                _.ENTERPRISE_ID,
                _.ENTERPRISE_NAME,
                _.LEREP_CERTNO,
                _.LEREP_CERTTYPE,
                _.PROJECT_CODE,
                _.ENTERPRISE_PLACE,
                _.CHINA_FOREIGN_SHARE_RATIO,
                _.BUSINESS_SCOPE,
                _.CONTACT_FAX,
                _.CORRESPONDENCE_ADDRESS,
                _.ENTERPRISE_NATURE,
                _.CONTACT_TYPE,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._SYNCTIME,
                this._CONTACT_EMAIL,
                this._CONTACT_NAME,
                this._CONTACT_PHONE,
                this._CONTACT_TEL,
                this._ENTERPRISE_ID,
                this._ENTERPRISE_NAME,
                this._LEREP_CERTNO,
                this._LEREP_CERTTYPE,
                this._PROJECT_CODE,
                this._ENTERPRISE_PLACE,
                this._CHINA_FOREIGN_SHARE_RATIO,
                this._BUSINESS_SCOPE,
                this._CONTACT_FAX,
                this._CORRESPONDENCE_ADDRESS,
                this._ENTERPRISE_NATURE,
                this._CONTACT_TYPE,
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
            public readonly static Field All = new Field("*", "T_AFC_FIXED_ENTERPRISE");
            /// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_FIXED_ENTERPRISE", "唯一标识");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_FIXED_ENTERPRISE", "创建时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_EMAIL = new Field("CONTACT_EMAIL", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_NAME = new Field("CONTACT_NAME", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_PHONE = new Field("CONTACT_PHONE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_TEL = new Field("CONTACT_TEL", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_ID = new Field("ENTERPRISE_ID", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_NAME = new Field("ENTERPRISE_NAME", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_CERTNO = new Field("LEREP_CERTNO", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_CERTTYPE = new Field("LEREP_CERTTYPE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_PLACE = new Field("ENTERPRISE_PLACE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CHINA_FOREIGN_SHARE_RATIO = new Field("CHINA_FOREIGN_SHARE_RATIO", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUSINESS_SCOPE = new Field("BUSINESS_SCOPE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_FAX = new Field("CONTACT_FAX", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CORRESPONDENCE_ADDRESS = new Field("CORRESPONDENCE_ADDRESS", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_NATURE = new Field("ENTERPRISE_NATURE", "T_AFC_FIXED_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_TYPE = new Field("CONTACT_TYPE", "T_AFC_FIXED_ENTERPRISE", "");
        }
        #endregion
    }
}