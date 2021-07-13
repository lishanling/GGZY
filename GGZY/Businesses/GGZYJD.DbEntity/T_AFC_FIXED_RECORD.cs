using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_FIXED_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_FIXED_RECORD")]
    [Serializable]
    public partial class T_AFC_FIXED_RECORD : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _PROJECT_CODE;
        private string _PROJECT_NAME;
        private string _PROJECT_FUNCTION;
        private string _PROJECT_INVESTMENT_NATURE;
        private string _REPORT_CODE;
        private string _IS_MAJOR;
        private string _PLACE_CODE_NAME;
        private string _PLACE_CODE_DETAIL_NAME;
        private string _PROJECT_NATURE;
        private string _HOUSE_PROJECT_NATURE;
        private string _HOUSE_PROJECT_TYPE;
        private string _DIVISION_CODE;
        private string _FOREIGN_ABROAD_FLAG;
        private string _PROJECT_TYPE;
        private string _VALIDITY_FLAG;
        private string _START_YEAR;
        private string _END_YEAR;
        private string _TOTAL_MONEY;
        private string _TOTAL_MONEY_EXPLAIN;
        private string _PLACE_CODE;
        private string _INDUSTRY;
        private string _THE_INDUSTRY;
        private string _APPLY_DATE;
        private DateTime? _CREATETIME;
        private string _PERMIT_ITEM_CODE;
        private string _DIVISION_CODE_NAME;
        private string _IS_COUNTRY_SECURITY;
        private string _SECURITY_APPROVAL_NUMBER;
        private string _INVESTMENT_MODE;
        private string _TOTAL_MONEY_DOLLAR;
        private string _TOTAL_MONEY_DOLLAR_RATE;
        private string _PROJECT_CAPITAL_MONEY;
        private string _PROJECT_CAPITAL_MONEY_DOLLAR;
        private string _PROJECT_CAPITAL_MONEY_RATE;
        private string _INDUSTRIAL_POLICY_TYPE;
        private string _INDUSTRIAL_POLICY;
        private string _OTHER_INVESTMENT_APPLY_INFO;
        private string _TRANSACTION_BOTH_INFO;
        private DateTime? _UPDATETIME;
        private string _MERGER_PLAN;
        private string _MERGER_MANAGEMENT_MODE_SCOPE;
        private string _GET_LAND_MODE;
        private string _BUILT_AREA;
        private string _IS_ADD_DEVICE;
        private string _IMPORT_DEVICE_NUMBER_MONEY;
        private string _PROJECT_SITE;
        private string _CHINA_TOTAL_MONEY;
        private string _SCALE_CONTENT;

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
        /// 入库时间
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
        /// 报建编号（项目登记编号）
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
        public string PROJECT_NAME
        {
            get { return _PROJECT_NAME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
                this._PROJECT_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_FUNCTION
        {
            get { return _PROJECT_FUNCTION; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_FUNCTION, _PROJECT_FUNCTION, value);
                this._PROJECT_FUNCTION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_INVESTMENT_NATURE
        {
            get { return _PROJECT_INVESTMENT_NATURE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_INVESTMENT_NATURE, _PROJECT_INVESTMENT_NATURE, value);
                this._PROJECT_INVESTMENT_NATURE = value;
            }
        }
        /// <summary>
        /// 
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
        public string IS_MAJOR
        {
            get { return _IS_MAJOR; }
            set
            {
                this.OnPropertyValueChange(_.IS_MAJOR, _IS_MAJOR, value);
                this._IS_MAJOR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACE_CODE_NAME
        {
            get { return _PLACE_CODE_NAME; }
            set
            {
                this.OnPropertyValueChange(_.PLACE_CODE_NAME, _PLACE_CODE_NAME, value);
                this._PLACE_CODE_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACE_CODE_DETAIL_NAME
        {
            get { return _PLACE_CODE_DETAIL_NAME; }
            set
            {
                this.OnPropertyValueChange(_.PLACE_CODE_DETAIL_NAME, _PLACE_CODE_DETAIL_NAME, value);
                this._PLACE_CODE_DETAIL_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_NATURE
        {
            get { return _PROJECT_NATURE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_NATURE, _PROJECT_NATURE, value);
                this._PROJECT_NATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HOUSE_PROJECT_NATURE
        {
            get { return _HOUSE_PROJECT_NATURE; }
            set
            {
                this.OnPropertyValueChange(_.HOUSE_PROJECT_NATURE, _HOUSE_PROJECT_NATURE, value);
                this._HOUSE_PROJECT_NATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HOUSE_PROJECT_TYPE
        {
            get { return _HOUSE_PROJECT_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.HOUSE_PROJECT_TYPE, _HOUSE_PROJECT_TYPE, value);
                this._HOUSE_PROJECT_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DIVISION_CODE
        {
            get { return _DIVISION_CODE; }
            set
            {
                this.OnPropertyValueChange(_.DIVISION_CODE, _DIVISION_CODE, value);
                this._DIVISION_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FOREIGN_ABROAD_FLAG
        {
            get { return _FOREIGN_ABROAD_FLAG; }
            set
            {
                this.OnPropertyValueChange(_.FOREIGN_ABROAD_FLAG, _FOREIGN_ABROAD_FLAG, value);
                this._FOREIGN_ABROAD_FLAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_TYPE
        {
            get { return _PROJECT_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
                this._PROJECT_TYPE = value;
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
        /// <summary>
        /// 
        /// </summary>
        public string START_YEAR
        {
            get { return _START_YEAR; }
            set
            {
                this.OnPropertyValueChange(_.START_YEAR, _START_YEAR, value);
                this._START_YEAR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string END_YEAR
        {
            get { return _END_YEAR; }
            set
            {
                this.OnPropertyValueChange(_.END_YEAR, _END_YEAR, value);
                this._END_YEAR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_MONEY
        {
            get { return _TOTAL_MONEY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_MONEY, _TOTAL_MONEY, value);
                this._TOTAL_MONEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_MONEY_EXPLAIN
        {
            get { return _TOTAL_MONEY_EXPLAIN; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_MONEY_EXPLAIN, _TOTAL_MONEY_EXPLAIN, value);
                this._TOTAL_MONEY_EXPLAIN = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACE_CODE
        {
            get { return _PLACE_CODE; }
            set
            {
                this.OnPropertyValueChange(_.PLACE_CODE, _PLACE_CODE, value);
                this._PLACE_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRY
        {
            get { return _INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY, _INDUSTRY, value);
                this._INDUSTRY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string THE_INDUSTRY
        {
            get { return _THE_INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.THE_INDUSTRY, _THE_INDUSTRY, value);
                this._THE_INDUSTRY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string APPLY_DATE
        {
            get { return _APPLY_DATE; }
            set
            {
                this.OnPropertyValueChange(_.APPLY_DATE, _APPLY_DATE, value);
                this._APPLY_DATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATETIME
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
        public string PERMIT_ITEM_CODE
        {
            get { return _PERMIT_ITEM_CODE; }
            set
            {
                this.OnPropertyValueChange(_.PERMIT_ITEM_CODE, _PERMIT_ITEM_CODE, value);
                this._PERMIT_ITEM_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DIVISION_CODE_NAME
        {
            get { return _DIVISION_CODE_NAME; }
            set
            {
                this.OnPropertyValueChange(_.DIVISION_CODE_NAME, _DIVISION_CODE_NAME, value);
                this._DIVISION_CODE_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IS_COUNTRY_SECURITY
        {
            get { return _IS_COUNTRY_SECURITY; }
            set
            {
                this.OnPropertyValueChange(_.IS_COUNTRY_SECURITY, _IS_COUNTRY_SECURITY, value);
                this._IS_COUNTRY_SECURITY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SECURITY_APPROVAL_NUMBER
        {
            get { return _SECURITY_APPROVAL_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.SECURITY_APPROVAL_NUMBER, _SECURITY_APPROVAL_NUMBER, value);
                this._SECURITY_APPROVAL_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INVESTMENT_MODE
        {
            get { return _INVESTMENT_MODE; }
            set
            {
                this.OnPropertyValueChange(_.INVESTMENT_MODE, _INVESTMENT_MODE, value);
                this._INVESTMENT_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_MONEY_DOLLAR
        {
            get { return _TOTAL_MONEY_DOLLAR; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_MONEY_DOLLAR, _TOTAL_MONEY_DOLLAR, value);
                this._TOTAL_MONEY_DOLLAR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_MONEY_DOLLAR_RATE
        {
            get { return _TOTAL_MONEY_DOLLAR_RATE; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_MONEY_DOLLAR_RATE, _TOTAL_MONEY_DOLLAR_RATE, value);
                this._TOTAL_MONEY_DOLLAR_RATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CAPITAL_MONEY
        {
            get { return _PROJECT_CAPITAL_MONEY; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_CAPITAL_MONEY, _PROJECT_CAPITAL_MONEY, value);
                this._PROJECT_CAPITAL_MONEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CAPITAL_MONEY_DOLLAR
        {
            get { return _PROJECT_CAPITAL_MONEY_DOLLAR; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_CAPITAL_MONEY_DOLLAR, _PROJECT_CAPITAL_MONEY_DOLLAR, value);
                this._PROJECT_CAPITAL_MONEY_DOLLAR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CAPITAL_MONEY_RATE
        {
            get { return _PROJECT_CAPITAL_MONEY_RATE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_CAPITAL_MONEY_RATE, _PROJECT_CAPITAL_MONEY_RATE, value);
                this._PROJECT_CAPITAL_MONEY_RATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRIAL_POLICY_TYPE
        {
            get { return _INDUSTRIAL_POLICY_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRIAL_POLICY_TYPE, _INDUSTRIAL_POLICY_TYPE, value);
                this._INDUSTRIAL_POLICY_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRIAL_POLICY
        {
            get { return _INDUSTRIAL_POLICY; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRIAL_POLICY, _INDUSTRIAL_POLICY, value);
                this._INDUSTRIAL_POLICY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OTHER_INVESTMENT_APPLY_INFO
        {
            get { return _OTHER_INVESTMENT_APPLY_INFO; }
            set
            {
                this.OnPropertyValueChange(_.OTHER_INVESTMENT_APPLY_INFO, _OTHER_INVESTMENT_APPLY_INFO, value);
                this._OTHER_INVESTMENT_APPLY_INFO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TRANSACTION_BOTH_INFO
        {
            get { return _TRANSACTION_BOTH_INFO; }
            set
            {
                this.OnPropertyValueChange(_.TRANSACTION_BOTH_INFO, _TRANSACTION_BOTH_INFO, value);
                this._TRANSACTION_BOTH_INFO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATETIME
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
        public string MERGER_PLAN
        {
            get { return _MERGER_PLAN; }
            set
            {
                this.OnPropertyValueChange(_.MERGER_PLAN, _MERGER_PLAN, value);
                this._MERGER_PLAN = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MERGER_MANAGEMENT_MODE_SCOPE
        {
            get { return _MERGER_MANAGEMENT_MODE_SCOPE; }
            set
            {
                this.OnPropertyValueChange(_.MERGER_MANAGEMENT_MODE_SCOPE, _MERGER_MANAGEMENT_MODE_SCOPE, value);
                this._MERGER_MANAGEMENT_MODE_SCOPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GET_LAND_MODE
        {
            get { return _GET_LAND_MODE; }
            set
            {
                this.OnPropertyValueChange(_.GET_LAND_MODE, _GET_LAND_MODE, value);
                this._GET_LAND_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUILT_AREA
        {
            get { return _BUILT_AREA; }
            set
            {
                this.OnPropertyValueChange(_.BUILT_AREA, _BUILT_AREA, value);
                this._BUILT_AREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IS_ADD_DEVICE
        {
            get { return _IS_ADD_DEVICE; }
            set
            {
                this.OnPropertyValueChange(_.IS_ADD_DEVICE, _IS_ADD_DEVICE, value);
                this._IS_ADD_DEVICE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IMPORT_DEVICE_NUMBER_MONEY
        {
            get { return _IMPORT_DEVICE_NUMBER_MONEY; }
            set
            {
                this.OnPropertyValueChange(_.IMPORT_DEVICE_NUMBER_MONEY, _IMPORT_DEVICE_NUMBER_MONEY, value);
                this._IMPORT_DEVICE_NUMBER_MONEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_SITE
        {
            get { return _PROJECT_SITE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_SITE, _PROJECT_SITE, value);
                this._PROJECT_SITE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHINA_TOTAL_MONEY
        {
            get { return _CHINA_TOTAL_MONEY; }
            set
            {
                this.OnPropertyValueChange(_.CHINA_TOTAL_MONEY, _CHINA_TOTAL_MONEY, value);
                this._CHINA_TOTAL_MONEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALE_CONTENT
        {
            get { return _SCALE_CONTENT; }
            set
            {
                this.OnPropertyValueChange(_.SCALE_CONTENT, _SCALE_CONTENT, value);
                this._SCALE_CONTENT = value;
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
                _.PROJECT_NAME,
                _.PROJECT_FUNCTION,
                _.PROJECT_INVESTMENT_NATURE,
                _.REPORT_CODE,
                _.IS_MAJOR,
                _.PLACE_CODE_NAME,
                _.PLACE_CODE_DETAIL_NAME,
                _.PROJECT_NATURE,
                _.HOUSE_PROJECT_NATURE,
                _.HOUSE_PROJECT_TYPE,
                _.DIVISION_CODE,
                _.FOREIGN_ABROAD_FLAG,
                _.PROJECT_TYPE,
                _.VALIDITY_FLAG,
                _.START_YEAR,
                _.END_YEAR,
                _.TOTAL_MONEY,
                _.TOTAL_MONEY_EXPLAIN,
                _.PLACE_CODE,
                _.INDUSTRY,
                _.THE_INDUSTRY,
                _.APPLY_DATE,
                _.CREATETIME,
                _.PERMIT_ITEM_CODE,
                _.DIVISION_CODE_NAME,
                _.IS_COUNTRY_SECURITY,
                _.SECURITY_APPROVAL_NUMBER,
                _.INVESTMENT_MODE,
                _.TOTAL_MONEY_DOLLAR,
                _.TOTAL_MONEY_DOLLAR_RATE,
                _.PROJECT_CAPITAL_MONEY,
                _.PROJECT_CAPITAL_MONEY_DOLLAR,
                _.PROJECT_CAPITAL_MONEY_RATE,
                _.INDUSTRIAL_POLICY_TYPE,
                _.INDUSTRIAL_POLICY,
                _.OTHER_INVESTMENT_APPLY_INFO,
                _.TRANSACTION_BOTH_INFO,
                _.UPDATETIME,
                _.MERGER_PLAN,
                _.MERGER_MANAGEMENT_MODE_SCOPE,
                _.GET_LAND_MODE,
                _.BUILT_AREA,
                _.IS_ADD_DEVICE,
                _.IMPORT_DEVICE_NUMBER_MONEY,
                _.PROJECT_SITE,
                _.CHINA_TOTAL_MONEY,
                _.SCALE_CONTENT,
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
                this._PROJECT_NAME,
                this._PROJECT_FUNCTION,
                this._PROJECT_INVESTMENT_NATURE,
                this._REPORT_CODE,
                this._IS_MAJOR,
                this._PLACE_CODE_NAME,
                this._PLACE_CODE_DETAIL_NAME,
                this._PROJECT_NATURE,
                this._HOUSE_PROJECT_NATURE,
                this._HOUSE_PROJECT_TYPE,
                this._DIVISION_CODE,
                this._FOREIGN_ABROAD_FLAG,
                this._PROJECT_TYPE,
                this._VALIDITY_FLAG,
                this._START_YEAR,
                this._END_YEAR,
                this._TOTAL_MONEY,
                this._TOTAL_MONEY_EXPLAIN,
                this._PLACE_CODE,
                this._INDUSTRY,
                this._THE_INDUSTRY,
                this._APPLY_DATE,
                this._CREATETIME,
                this._PERMIT_ITEM_CODE,
                this._DIVISION_CODE_NAME,
                this._IS_COUNTRY_SECURITY,
                this._SECURITY_APPROVAL_NUMBER,
                this._INVESTMENT_MODE,
                this._TOTAL_MONEY_DOLLAR,
                this._TOTAL_MONEY_DOLLAR_RATE,
                this._PROJECT_CAPITAL_MONEY,
                this._PROJECT_CAPITAL_MONEY_DOLLAR,
                this._PROJECT_CAPITAL_MONEY_RATE,
                this._INDUSTRIAL_POLICY_TYPE,
                this._INDUSTRIAL_POLICY,
                this._OTHER_INVESTMENT_APPLY_INFO,
                this._TRANSACTION_BOTH_INFO,
                this._UPDATETIME,
                this._MERGER_PLAN,
                this._MERGER_MANAGEMENT_MODE_SCOPE,
                this._GET_LAND_MODE,
                this._BUILT_AREA,
                this._IS_ADD_DEVICE,
                this._IMPORT_DEVICE_NUMBER_MONEY,
                this._PROJECT_SITE,
                this._CHINA_TOTAL_MONEY,
                this._SCALE_CONTENT,
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
            public readonly static Field All = new Field("*", "T_AFC_FIXED_RECORD");
            /// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_FIXED_RECORD", "唯一标识");
            /// <summary>
			/// 入库时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_FIXED_RECORD", "入库时间");
            /// <summary>
			/// 报建编号（项目登记编号）
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_FIXED_RECORD", "报建编号（项目登记编号）");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_FUNCTION = new Field("PROJECT_FUNCTION", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_INVESTMENT_NATURE = new Field("PROJECT_INVESTMENT_NATURE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REPORT_CODE = new Field("REPORT_CODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_MAJOR = new Field("IS_MAJOR", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE_NAME = new Field("PLACE_CODE_NAME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE_DETAIL_NAME = new Field("PLACE_CODE_DETAIL_NAME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NATURE = new Field("PROJECT_NATURE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HOUSE_PROJECT_NATURE = new Field("HOUSE_PROJECT_NATURE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HOUSE_PROJECT_TYPE = new Field("HOUSE_PROJECT_TYPE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DIVISION_CODE = new Field("DIVISION_CODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FOREIGN_ABROAD_FLAG = new Field("FOREIGN_ABROAD_FLAG", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALIDITY_FLAG = new Field("VALIDITY_FLAG", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field START_YEAR = new Field("START_YEAR", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field END_YEAR = new Field("END_YEAR", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTAL_MONEY = new Field("TOTAL_MONEY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTAL_MONEY_EXPLAIN = new Field("TOTAL_MONEY_EXPLAIN", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE = new Field("PLACE_CODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRY = new Field("INDUSTRY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field THE_INDUSTRY = new Field("THE_INDUSTRY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_DATE = new Field("APPLY_DATE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PERMIT_ITEM_CODE = new Field("PERMIT_ITEM_CODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DIVISION_CODE_NAME = new Field("DIVISION_CODE_NAME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_COUNTRY_SECURITY = new Field("IS_COUNTRY_SECURITY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SECURITY_APPROVAL_NUMBER = new Field("SECURITY_APPROVAL_NUMBER", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INVESTMENT_MODE = new Field("INVESTMENT_MODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTAL_MONEY_DOLLAR = new Field("TOTAL_MONEY_DOLLAR", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTAL_MONEY_DOLLAR_RATE = new Field("TOTAL_MONEY_DOLLAR_RATE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CAPITAL_MONEY = new Field("PROJECT_CAPITAL_MONEY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CAPITAL_MONEY_DOLLAR = new Field("PROJECT_CAPITAL_MONEY_DOLLAR", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CAPITAL_MONEY_RATE = new Field("PROJECT_CAPITAL_MONEY_RATE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRIAL_POLICY_TYPE = new Field("INDUSTRIAL_POLICY_TYPE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRIAL_POLICY = new Field("INDUSTRIAL_POLICY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OTHER_INVESTMENT_APPLY_INFO = new Field("OTHER_INVESTMENT_APPLY_INFO", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRANSACTION_BOTH_INFO = new Field("TRANSACTION_BOTH_INFO", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MERGER_PLAN = new Field("MERGER_PLAN", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MERGER_MANAGEMENT_MODE_SCOPE = new Field("MERGER_MANAGEMENT_MODE_SCOPE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GET_LAND_MODE = new Field("GET_LAND_MODE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUILT_AREA = new Field("BUILT_AREA", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_ADD_DEVICE = new Field("IS_ADD_DEVICE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORT_DEVICE_NUMBER_MONEY = new Field("IMPORT_DEVICE_NUMBER_MONEY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_SITE = new Field("PROJECT_SITE", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CHINA_TOTAL_MONEY = new Field("CHINA_TOTAL_MONEY", "T_AFC_FIXED_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALE_CONTENT = new Field("SCALE_CONTENT", "T_AFC_FIXED_RECORD", DbType.AnsiString, null, "");
        }
        #endregion
    }
}