using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_XMCODE_ENTERPRISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_XMCODE_ENTERPRISE")]
    [Serializable]
    public partial class T_AFC_XMCODE_ENTERPRISE : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _PROJECT_CODE;
        private string _BUSINESSSCOPE;
        private string _CHINAFOREIGNSHARERATIO;
        private string _CONTACTEMAIL;
        private string _CONTACTNAME;
        private string _CONTACTPHONE;
        private string _CORRESPONDENCEADDRESS;
        private string _ENTERPRISEFAX;
        private string _ENTERPRISELICENCENO;
        private string _ENTERPRISELICENCETYPE;
        private string _ENTERPRISENAME;
        private string _ENTERPRISENATURE;
        private string _ENTERPRISEPLACE;
        private string _LEGALREPRESENTATIVEIDNO;
        private string _LEGALREPRESENTATIVENAME;
        private string _LEGALREPRESENTATIVETYPE;
        private string _REMARK;
        private decimal? _SORTORDER;
        private decimal? _SORTORDERSPECIFIED;
        private string _PROJECTLEGALCONTRIBUTIONBOS;
        private string _VALIDITYFLAG;

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
        public string BUSINESSSCOPE
        {
            get { return _BUSINESSSCOPE; }
            set
            {
                this.OnPropertyValueChange(_.BUSINESSSCOPE, _BUSINESSSCOPE, value);
                this._BUSINESSSCOPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHINAFOREIGNSHARERATIO
        {
            get { return _CHINAFOREIGNSHARERATIO; }
            set
            {
                this.OnPropertyValueChange(_.CHINAFOREIGNSHARERATIO, _CHINAFOREIGNSHARERATIO, value);
                this._CHINAFOREIGNSHARERATIO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACTEMAIL
        {
            get { return _CONTACTEMAIL; }
            set
            {
                this.OnPropertyValueChange(_.CONTACTEMAIL, _CONTACTEMAIL, value);
                this._CONTACTEMAIL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACTNAME
        {
            get { return _CONTACTNAME; }
            set
            {
                this.OnPropertyValueChange(_.CONTACTNAME, _CONTACTNAME, value);
                this._CONTACTNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACTPHONE
        {
            get { return _CONTACTPHONE; }
            set
            {
                this.OnPropertyValueChange(_.CONTACTPHONE, _CONTACTPHONE, value);
                this._CONTACTPHONE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CORRESPONDENCEADDRESS
        {
            get { return _CORRESPONDENCEADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.CORRESPONDENCEADDRESS, _CORRESPONDENCEADDRESS, value);
                this._CORRESPONDENCEADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISEFAX
        {
            get { return _ENTERPRISEFAX; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEFAX, _ENTERPRISEFAX, value);
                this._ENTERPRISEFAX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISELICENCENO
        {
            get { return _ENTERPRISELICENCENO; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISELICENCENO, _ENTERPRISELICENCENO, value);
                this._ENTERPRISELICENCENO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISELICENCETYPE
        {
            get { return _ENTERPRISELICENCETYPE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISELICENCETYPE, _ENTERPRISELICENCETYPE, value);
                this._ENTERPRISELICENCETYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISENAME
        {
            get { return _ENTERPRISENAME; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISENAME, _ENTERPRISENAME, value);
                this._ENTERPRISENAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISENATURE
        {
            get { return _ENTERPRISENATURE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISENATURE, _ENTERPRISENATURE, value);
                this._ENTERPRISENATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISEPLACE
        {
            get { return _ENTERPRISEPLACE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISEPLACE, _ENTERPRISEPLACE, value);
                this._ENTERPRISEPLACE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEGALREPRESENTATIVEIDNO
        {
            get { return _LEGALREPRESENTATIVEIDNO; }
            set
            {
                this.OnPropertyValueChange(_.LEGALREPRESENTATIVEIDNO, _LEGALREPRESENTATIVEIDNO, value);
                this._LEGALREPRESENTATIVEIDNO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEGALREPRESENTATIVENAME
        {
            get { return _LEGALREPRESENTATIVENAME; }
            set
            {
                this.OnPropertyValueChange(_.LEGALREPRESENTATIVENAME, _LEGALREPRESENTATIVENAME, value);
                this._LEGALREPRESENTATIVENAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LEGALREPRESENTATIVETYPE
        {
            get { return _LEGALREPRESENTATIVETYPE; }
            set
            {
                this.OnPropertyValueChange(_.LEGALREPRESENTATIVETYPE, _LEGALREPRESENTATIVETYPE, value);
                this._LEGALREPRESENTATIVETYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REMARK
        {
            get { return _REMARK; }
            set
            {
                this.OnPropertyValueChange(_.REMARK, _REMARK, value);
                this._REMARK = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SORTORDER
        {
            get { return _SORTORDER; }
            set
            {
                this.OnPropertyValueChange(_.SORTORDER, _SORTORDER, value);
                this._SORTORDER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SORTORDERSPECIFIED
        {
            get { return _SORTORDERSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.SORTORDERSPECIFIED, _SORTORDERSPECIFIED, value);
                this._SORTORDERSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTLEGALCONTRIBUTIONBOS
        {
            get { return _PROJECTLEGALCONTRIBUTIONBOS; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTLEGALCONTRIBUTIONBOS, _PROJECTLEGALCONTRIBUTIONBOS, value);
                this._PROJECTLEGALCONTRIBUTIONBOS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VALIDITYFLAG
        {
            get { return _VALIDITYFLAG; }
            set
            {
                this.OnPropertyValueChange(_.VALIDITYFLAG, _VALIDITYFLAG, value);
                this._VALIDITYFLAG = value;
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
                _.PROJECT_CODE,
                _.BUSINESSSCOPE,
                _.CHINAFOREIGNSHARERATIO,
                _.CONTACTEMAIL,
                _.CONTACTNAME,
                _.CONTACTPHONE,
                _.CORRESPONDENCEADDRESS,
                _.ENTERPRISEFAX,
                _.ENTERPRISELICENCENO,
                _.ENTERPRISELICENCETYPE,
                _.ENTERPRISENAME,
                _.ENTERPRISENATURE,
                _.ENTERPRISEPLACE,
                _.LEGALREPRESENTATIVEIDNO,
                _.LEGALREPRESENTATIVENAME,
                _.LEGALREPRESENTATIVETYPE,
                _.REMARK,
                _.SORTORDER,
                _.SORTORDERSPECIFIED,
                _.PROJECTLEGALCONTRIBUTIONBOS,
                _.VALIDITYFLAG,
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
                this._PROJECT_CODE,
                this._BUSINESSSCOPE,
                this._CHINAFOREIGNSHARERATIO,
                this._CONTACTEMAIL,
                this._CONTACTNAME,
                this._CONTACTPHONE,
                this._CORRESPONDENCEADDRESS,
                this._ENTERPRISEFAX,
                this._ENTERPRISELICENCENO,
                this._ENTERPRISELICENCETYPE,
                this._ENTERPRISENAME,
                this._ENTERPRISENATURE,
                this._ENTERPRISEPLACE,
                this._LEGALREPRESENTATIVEIDNO,
                this._LEGALREPRESENTATIVENAME,
                this._LEGALREPRESENTATIVETYPE,
                this._REMARK,
                this._SORTORDER,
                this._SORTORDERSPECIFIED,
                this._PROJECTLEGALCONTRIBUTIONBOS,
                this._VALIDITYFLAG,
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
            public readonly static Field All = new Field("*", "T_AFC_XMCODE_ENTERPRISE");
            /// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_XMCODE_ENTERPRISE", "唯一标识");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_XMCODE_ENTERPRISE", "创建时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUSINESSSCOPE = new Field("BUSINESSSCOPE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CHINAFOREIGNSHARERATIO = new Field("CHINAFOREIGNSHARERATIO", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACTEMAIL = new Field("CONTACTEMAIL", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACTNAME = new Field("CONTACTNAME", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACTPHONE = new Field("CONTACTPHONE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CORRESPONDENCEADDRESS = new Field("CORRESPONDENCEADDRESS", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISEFAX = new Field("ENTERPRISEFAX", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISELICENCENO = new Field("ENTERPRISELICENCENO", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISELICENCETYPE = new Field("ENTERPRISELICENCETYPE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISENAME = new Field("ENTERPRISENAME", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISENATURE = new Field("ENTERPRISENATURE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISEPLACE = new Field("ENTERPRISEPLACE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGALREPRESENTATIVEIDNO = new Field("LEGALREPRESENTATIVEIDNO", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGALREPRESENTATIVENAME = new Field("LEGALREPRESENTATIVENAME", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGALREPRESENTATIVETYPE = new Field("LEGALREPRESENTATIVETYPE", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTORDER = new Field("SORTORDER", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTORDERSPECIFIED = new Field("SORTORDERSPECIFIED", "T_AFC_XMCODE_ENTERPRISE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTLEGALCONTRIBUTIONBOS = new Field("PROJECTLEGALCONTRIBUTIONBOS", "T_AFC_XMCODE_ENTERPRISE", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALIDITYFLAG = new Field("VALIDITYFLAG", "T_AFC_XMCODE_ENTERPRISE", "");
        }
        #endregion
    }
}