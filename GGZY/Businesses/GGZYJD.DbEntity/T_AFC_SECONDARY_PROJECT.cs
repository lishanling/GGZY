using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_SECONDARY_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_SECONDARY_PROJECT")]
    [Serializable]
    public partial class T_AFC_SECONDARY_PROJECT : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _REPORT_CODE;
        private string _APPLY_DATE;
        private string _AREA_CODE;
        private string _AREA_NAME;
        private string _BUILDING_AREA;
        private string _CITY_CODE;
        private string _CREATETIME;
        private string _DIVISION_CODE;
        private string _DIVISION_CODE_NAME;
        private string _END_MONTH;
        private string _END_YEAR;
        private string _FOREIGN_ABROAD_FLAG;
        private string _GOV_INVESTMENT_DIRECTION;
        private string _GOV_INVESTMENT_DIRECTION_NAME;
        private string _HOUSE_PROJECT_NATURE;
        private string _HOUSE_PROJECT_TYPE;
        private string _INDUSTRY;
        private string _INDUSTRY_NAME;
        private string _INDUSTRY_STRUCTURE;
        private string _IS_INDUSTRIAL_POLICY;
        private string _IS_MAJOR;
        private string _PLACE_CODE_DETAIL;
        private string _PLACE_CODE_DETAIL_EXTENSION;
        private string _PLACE_CODE_DETAIL_NAME;
        private string _PROJECT_ATTRIBUTES;
        private string _PROJECT_CODE;
        private string _PROJECT_FUNCTION;
        private string _PROJECT_INVESTMENT_NATURE;
        private string _PROJECT_NAME;
        private string _PROJECT_NATURE;
        private string _PROJECT_NATURE_EXTENSION;
        private string _PROJECT_TYPE;
        private string _PROVINCE_CODE;
        private string _START_MONTH;
        private string _START_YEAR;
        private string _THE_INDUSTRY;
        private string _THE_INDUSTRY_NAME;
        private string _TOTAL_MONEY;
        private string _UPDATETIME;
        private string _VALIDITY_FLAG;
        private string _SCALE_CONTENT;
        private DateTime? _APPLY_DATE_TIME;

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
        public string AREA_CODE
        {
            get { return _AREA_CODE; }
            set
            {
                this.OnPropertyValueChange(_.AREA_CODE, _AREA_CODE, value);
                this._AREA_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AREA_NAME
        {
            get { return _AREA_NAME; }
            set
            {
                this.OnPropertyValueChange(_.AREA_NAME, _AREA_NAME, value);
                this._AREA_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUILDING_AREA
        {
            get { return _BUILDING_AREA; }
            set
            {
                this.OnPropertyValueChange(_.BUILDING_AREA, _BUILDING_AREA, value);
                this._BUILDING_AREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CITY_CODE
        {
            get { return _CITY_CODE; }
            set
            {
                this.OnPropertyValueChange(_.CITY_CODE, _CITY_CODE, value);
                this._CITY_CODE = value;
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
        public string END_MONTH
        {
            get { return _END_MONTH; }
            set
            {
                this.OnPropertyValueChange(_.END_MONTH, _END_MONTH, value);
                this._END_MONTH = value;
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
        public string GOV_INVESTMENT_DIRECTION
        {
            get { return _GOV_INVESTMENT_DIRECTION; }
            set
            {
                this.OnPropertyValueChange(_.GOV_INVESTMENT_DIRECTION, _GOV_INVESTMENT_DIRECTION, value);
                this._GOV_INVESTMENT_DIRECTION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GOV_INVESTMENT_DIRECTION_NAME
        {
            get { return _GOV_INVESTMENT_DIRECTION_NAME; }
            set
            {
                this.OnPropertyValueChange(_.GOV_INVESTMENT_DIRECTION_NAME, _GOV_INVESTMENT_DIRECTION_NAME, value);
                this._GOV_INVESTMENT_DIRECTION_NAME = value;
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
        public string INDUSTRY_NAME
        {
            get { return _INDUSTRY_NAME; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY_NAME, _INDUSTRY_NAME, value);
                this._INDUSTRY_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRY_STRUCTURE
        {
            get { return _INDUSTRY_STRUCTURE; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY_STRUCTURE, _INDUSTRY_STRUCTURE, value);
                this._INDUSTRY_STRUCTURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IS_INDUSTRIAL_POLICY
        {
            get { return _IS_INDUSTRIAL_POLICY; }
            set
            {
                this.OnPropertyValueChange(_.IS_INDUSTRIAL_POLICY, _IS_INDUSTRIAL_POLICY, value);
                this._IS_INDUSTRIAL_POLICY = value;
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
        public string PLACE_CODE_DETAIL
        {
            get { return _PLACE_CODE_DETAIL; }
            set
            {
                this.OnPropertyValueChange(_.PLACE_CODE_DETAIL, _PLACE_CODE_DETAIL, value);
                this._PLACE_CODE_DETAIL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACE_CODE_DETAIL_EXTENSION
        {
            get { return _PLACE_CODE_DETAIL_EXTENSION; }
            set
            {
                this.OnPropertyValueChange(_.PLACE_CODE_DETAIL_EXTENSION, _PLACE_CODE_DETAIL_EXTENSION, value);
                this._PLACE_CODE_DETAIL_EXTENSION = value;
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
        public string PROJECT_ATTRIBUTES
        {
            get { return _PROJECT_ATTRIBUTES; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_ATTRIBUTES, _PROJECT_ATTRIBUTES, value);
                this._PROJECT_ATTRIBUTES = value;
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
        public string PROJECT_NATURE_EXTENSION
        {
            get { return _PROJECT_NATURE_EXTENSION; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_NATURE_EXTENSION, _PROJECT_NATURE_EXTENSION, value);
                this._PROJECT_NATURE_EXTENSION = value;
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
        public string PROVINCE_CODE
        {
            get { return _PROVINCE_CODE; }
            set
            {
                this.OnPropertyValueChange(_.PROVINCE_CODE, _PROVINCE_CODE, value);
                this._PROVINCE_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string START_MONTH
        {
            get { return _START_MONTH; }
            set
            {
                this.OnPropertyValueChange(_.START_MONTH, _START_MONTH, value);
                this._START_MONTH = value;
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
        public string THE_INDUSTRY_NAME
        {
            get { return _THE_INDUSTRY_NAME; }
            set
            {
                this.OnPropertyValueChange(_.THE_INDUSTRY_NAME, _THE_INDUSTRY_NAME, value);
                this._THE_INDUSTRY_NAME = value;
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
        /// <summary>
        /// 
        /// </summary>
        public DateTime? APPLY_DATE_TIME
        {
            get { return _APPLY_DATE_TIME; }
            set
            {
                this.OnPropertyValueChange(_.APPLY_DATE_TIME, _APPLY_DATE_TIME, value);
                this._APPLY_DATE_TIME = value;
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
                _.APPLY_DATE,
                _.AREA_CODE,
                _.AREA_NAME,
                _.BUILDING_AREA,
                _.CITY_CODE,
                _.CREATETIME,
                _.DIVISION_CODE,
                _.DIVISION_CODE_NAME,
                _.END_MONTH,
                _.END_YEAR,
                _.FOREIGN_ABROAD_FLAG,
                _.GOV_INVESTMENT_DIRECTION,
                _.GOV_INVESTMENT_DIRECTION_NAME,
                _.HOUSE_PROJECT_NATURE,
                _.HOUSE_PROJECT_TYPE,
                _.INDUSTRY,
                _.INDUSTRY_NAME,
                _.INDUSTRY_STRUCTURE,
                _.IS_INDUSTRIAL_POLICY,
                _.IS_MAJOR,
                _.PLACE_CODE_DETAIL,
                _.PLACE_CODE_DETAIL_EXTENSION,
                _.PLACE_CODE_DETAIL_NAME,
                _.PROJECT_ATTRIBUTES,
                _.PROJECT_CODE,
                _.PROJECT_FUNCTION,
                _.PROJECT_INVESTMENT_NATURE,
                _.PROJECT_NAME,
                _.PROJECT_NATURE,
                _.PROJECT_NATURE_EXTENSION,
                _.PROJECT_TYPE,
                _.PROVINCE_CODE,
                _.START_MONTH,
                _.START_YEAR,
                _.THE_INDUSTRY,
                _.THE_INDUSTRY_NAME,
                _.TOTAL_MONEY,
                _.UPDATETIME,
                _.VALIDITY_FLAG,
                _.SCALE_CONTENT,
                _.APPLY_DATE_TIME,
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
                this._APPLY_DATE,
                this._AREA_CODE,
                this._AREA_NAME,
                this._BUILDING_AREA,
                this._CITY_CODE,
                this._CREATETIME,
                this._DIVISION_CODE,
                this._DIVISION_CODE_NAME,
                this._END_MONTH,
                this._END_YEAR,
                this._FOREIGN_ABROAD_FLAG,
                this._GOV_INVESTMENT_DIRECTION,
                this._GOV_INVESTMENT_DIRECTION_NAME,
                this._HOUSE_PROJECT_NATURE,
                this._HOUSE_PROJECT_TYPE,
                this._INDUSTRY,
                this._INDUSTRY_NAME,
                this._INDUSTRY_STRUCTURE,
                this._IS_INDUSTRIAL_POLICY,
                this._IS_MAJOR,
                this._PLACE_CODE_DETAIL,
                this._PLACE_CODE_DETAIL_EXTENSION,
                this._PLACE_CODE_DETAIL_NAME,
                this._PROJECT_ATTRIBUTES,
                this._PROJECT_CODE,
                this._PROJECT_FUNCTION,
                this._PROJECT_INVESTMENT_NATURE,
                this._PROJECT_NAME,
                this._PROJECT_NATURE,
                this._PROJECT_NATURE_EXTENSION,
                this._PROJECT_TYPE,
                this._PROVINCE_CODE,
                this._START_MONTH,
                this._START_YEAR,
                this._THE_INDUSTRY,
                this._THE_INDUSTRY_NAME,
                this._TOTAL_MONEY,
                this._UPDATETIME,
                this._VALIDITY_FLAG,
                this._SCALE_CONTENT,
                this._APPLY_DATE_TIME,
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
            public readonly static Field All = new Field("*", "T_AFC_SECONDARY_PROJECT");
            /// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_SECONDARY_PROJECT", "唯一标识");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_SECONDARY_PROJECT", "创建时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REPORT_CODE = new Field("REPORT_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_DATE = new Field("APPLY_DATE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_NAME = new Field("AREA_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUILDING_AREA = new Field("BUILDING_AREA", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CITY_CODE = new Field("CITY_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DIVISION_CODE = new Field("DIVISION_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DIVISION_CODE_NAME = new Field("DIVISION_CODE_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field END_MONTH = new Field("END_MONTH", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field END_YEAR = new Field("END_YEAR", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FOREIGN_ABROAD_FLAG = new Field("FOREIGN_ABROAD_FLAG", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GOV_INVESTMENT_DIRECTION = new Field("GOV_INVESTMENT_DIRECTION", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GOV_INVESTMENT_DIRECTION_NAME = new Field("GOV_INVESTMENT_DIRECTION_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HOUSE_PROJECT_NATURE = new Field("HOUSE_PROJECT_NATURE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HOUSE_PROJECT_TYPE = new Field("HOUSE_PROJECT_TYPE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRY = new Field("INDUSTRY", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRY_NAME = new Field("INDUSTRY_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRY_STRUCTURE = new Field("INDUSTRY_STRUCTURE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_INDUSTRIAL_POLICY = new Field("IS_INDUSTRIAL_POLICY", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_MAJOR = new Field("IS_MAJOR", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE_DETAIL = new Field("PLACE_CODE_DETAIL", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE_DETAIL_EXTENSION = new Field("PLACE_CODE_DETAIL_EXTENSION", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACE_CODE_DETAIL_NAME = new Field("PLACE_CODE_DETAIL_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_ATTRIBUTES = new Field("PROJECT_ATTRIBUTES", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_FUNCTION = new Field("PROJECT_FUNCTION", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_INVESTMENT_NATURE = new Field("PROJECT_INVESTMENT_NATURE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NATURE = new Field("PROJECT_NATURE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NATURE_EXTENSION = new Field("PROJECT_NATURE_EXTENSION", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROVINCE_CODE = new Field("PROVINCE_CODE", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field START_MONTH = new Field("START_MONTH", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field START_YEAR = new Field("START_YEAR", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field THE_INDUSTRY = new Field("THE_INDUSTRY", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field THE_INDUSTRY_NAME = new Field("THE_INDUSTRY_NAME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTAL_MONEY = new Field("TOTAL_MONEY", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALIDITY_FLAG = new Field("VALIDITY_FLAG", "T_AFC_SECONDARY_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALE_CONTENT = new Field("SCALE_CONTENT", "T_AFC_SECONDARY_PROJECT", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_DATE_TIME = new Field("APPLY_DATE_TIME", "T_AFC_SECONDARY_PROJECT", "");
        }
        #endregion
    }
}