using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_SECONDARY_ENTERPRISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_SECONDARY_ENTERPRISE")]
    [Serializable]
    public partial class T_AFC_SECONDARY_ENTERPRISE : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _REPORT_CODE;
        private string _CONTACT_CERTNO;
        private string _CONTACT_CERTTYPE;
        private string _CONTACT_EMAIL;
        private string _CONTACT_NAME;
        private string _CONTACT_PHONE;
        private string _CONTACT_TEL;
        private string _CREATETIME;
        private string _ENTERPRISE_ID;
        private string _ENTERPRISE_NAME;
        private string _LEREP_CERTNO;
        private string _LEREP_CERTTYPE;
        private string _LEREP_REPRESENTATIVE;
        private string _LEREP_REPRESENTATIVE_CERTNO;
        private string _LEREP_REPRESENTATIVE_CERTTYPE;
        private string _PROJECT_CODE;
        private string _REGISTRATION_NATURE;
        private string _UPDATETIME;
        private string _VALIDITY_FLAG;

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
        /// 项目代码，对应T_AFC_SECONDARY CODE
        /// </summary>
        public string REPORT_CODE
        {
            get { return _REPORT_CODE; }
            set
            {
                this.OnPropertyValueChange(_.REPORT_CODE, _REPORT_CODE, value);
                this._REPORT_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_CERTNO
        {
            get { return _CONTACT_CERTNO; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_CERTNO, _CONTACT_CERTNO, value);
                this._CONTACT_CERTNO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_CERTTYPE
        {
            get { return _CONTACT_CERTTYPE; }
            set
            {
                this.OnPropertyValueChange(_.CONTACT_CERTTYPE, _CONTACT_CERTTYPE, value);
                this._CONTACT_CERTTYPE = value;
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
        public string CREATETIME
        {
            get { return _CREATETIME; }
            set
            {
                this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
                this._CREATETIME = value;
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
        public string LEREP_REPRESENTATIVE
        {
            get { return _LEREP_REPRESENTATIVE; }
            set
            {
                this.OnPropertyValueChange(_.LEREP_REPRESENTATIVE, _LEREP_REPRESENTATIVE, value);
                this._LEREP_REPRESENTATIVE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEREP_REPRESENTATIVE_CERTNO
        {
            get { return _LEREP_REPRESENTATIVE_CERTNO; }
            set
            {
                this.OnPropertyValueChange(_.LEREP_REPRESENTATIVE_CERTNO, _LEREP_REPRESENTATIVE_CERTNO, value);
                this._LEREP_REPRESENTATIVE_CERTNO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEREP_REPRESENTATIVE_CERTTYPE
        {
            get { return _LEREP_REPRESENTATIVE_CERTTYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEREP_REPRESENTATIVE_CERTTYPE, _LEREP_REPRESENTATIVE_CERTTYPE, value);
                this._LEREP_REPRESENTATIVE_CERTTYPE = value;
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
        public string REGISTRATION_NATURE
        {
            get { return _REGISTRATION_NATURE; }
            set
            {
                this.OnPropertyValueChange(_.REGISTRATION_NATURE, _REGISTRATION_NATURE, value);
                this._REGISTRATION_NATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPDATETIME
        {
            get { return _UPDATETIME; }
            set
            {
                this.OnPropertyValueChange(_.UPDATETIME, _UPDATETIME, value);
                this._UPDATETIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VALIDITY_FLAG
        {
            get { return _VALIDITY_FLAG; }
            set
            {
                this.OnPropertyValueChange(_.VALIDITY_FLAG, _VALIDITY_FLAG, value);
                this._VALIDITY_FLAG = value;
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
                _.REPORT_CODE,
                _.CONTACT_CERTNO,
                _.CONTACT_CERTTYPE,
                _.CONTACT_EMAIL,
                _.CONTACT_NAME,
                _.CONTACT_PHONE,
                _.CONTACT_TEL,
                _.CREATETIME,
                _.ENTERPRISE_ID,
                _.ENTERPRISE_NAME,
                _.LEREP_CERTNO,
                _.LEREP_CERTTYPE,
                _.LEREP_REPRESENTATIVE,
                _.LEREP_REPRESENTATIVE_CERTNO,
                _.LEREP_REPRESENTATIVE_CERTTYPE,
                _.PROJECT_CODE,
                _.REGISTRATION_NATURE,
                _.UPDATETIME,
                _.VALIDITY_FLAG,
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
                this._REPORT_CODE,
                this._CONTACT_CERTNO,
                this._CONTACT_CERTTYPE,
                this._CONTACT_EMAIL,
                this._CONTACT_NAME,
                this._CONTACT_PHONE,
                this._CONTACT_TEL,
                this._CREATETIME,
                this._ENTERPRISE_ID,
                this._ENTERPRISE_NAME,
                this._LEREP_CERTNO,
                this._LEREP_CERTTYPE,
                this._LEREP_REPRESENTATIVE,
                this._LEREP_REPRESENTATIVE_CERTNO,
                this._LEREP_REPRESENTATIVE_CERTTYPE,
                this._PROJECT_CODE,
                this._REGISTRATION_NATURE,
                this._UPDATETIME,
                this._VALIDITY_FLAG,
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
            public readonly static Field All = new Field("*", "T_AFC_SECONDARY_ENTERPRISE");
            /// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_SECONDARY_ENTERPRISE", "唯一标识");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_SECONDARY_ENTERPRISE", "创建时间");
            /// <summary>
			/// 项目代码，对应T_AFC_SECONDARY CODE
			/// </summary>
			public readonly static Field REPORT_CODE = new Field("REPORT_CODE", "T_AFC_SECONDARY_ENTERPRISE", "项目代码，对应T_AFC_SECONDARY CODE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_CERTNO = new Field("CONTACT_CERTNO", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_CERTTYPE = new Field("CONTACT_CERTTYPE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_EMAIL = new Field("CONTACT_EMAIL", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_NAME = new Field("CONTACT_NAME", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_PHONE = new Field("CONTACT_PHONE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_TEL = new Field("CONTACT_TEL", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_ID = new Field("ENTERPRISE_ID", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISE_NAME = new Field("ENTERPRISE_NAME", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_CERTNO = new Field("LEREP_CERTNO", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_CERTTYPE = new Field("LEREP_CERTTYPE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_REPRESENTATIVE = new Field("LEREP_REPRESENTATIVE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_REPRESENTATIVE_CERTNO = new Field("LEREP_REPRESENTATIVE_CERTNO", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEREP_REPRESENTATIVE_CERTTYPE = new Field("LEREP_REPRESENTATIVE_CERTTYPE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGISTRATION_NATURE = new Field("REGISTRATION_NATURE", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_AFC_SECONDARY_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALIDITY_FLAG = new Field("VALIDITY_FLAG", "T_AFC_SECONDARY_ENTERPRISE", "");
        }
        #endregion
    }
}