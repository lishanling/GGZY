using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_RECORD_REVIEW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RECORD_REVIEW")]
    [Serializable]
    public partial class T_RECORD_REVIEW : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _REVIEW_TYPE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_TYPE;
		private string _TENDER_AGENCY_CODE;
		private DateTime? _COMMIT_TIME;
		private decimal? _IS_REVIEW;
		private DateTime? _REVIEW_TIME;
		private decimal? _IS_PASS_REVIEW;
		private string _REVIEW_COMMENT;
		private string _SECTION_CODE;
		private string _SECTION_NAME;
		private string _DATA_KEY;
		private string _M_ID;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_AGENCY_NAME;
		private string _NOTICE_KEY;
		private string _AUDIT_UNIT;
		private string _M_DATA_SOURCE;
		private string _M_TM;
		private string _SECTION_TYPE;
		private decimal? _IS_VIEW;
		private string _REVIEW_KEY;

		/// <summary>
		/// ID
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
		/// 审查类型
		/// </summary>
		public string REVIEW_TYPE
		{
			get{ return _REVIEW_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TYPE, _REVIEW_TYPE, value);
				this._REVIEW_TYPE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
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
		/// 招标项目类型
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
		/// 送审单位代码（招标人或者招标代理机构）
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
		/// 提交时间
		/// </summary>
		public DateTime? COMMIT_TIME
		{
			get{ return _COMMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COMMIT_TIME, _COMMIT_TIME, value);
				this._COMMIT_TIME = value;
			}
		}
		/// <summary>
		/// 是否审查（0否，1是）
		/// </summary>
		public decimal? IS_REVIEW
		{
			get{ return _IS_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.IS_REVIEW, _IS_REVIEW, value);
				this._IS_REVIEW = value;
			}
		}
		/// <summary>
		/// 审查时间
		/// </summary>
		public DateTime? REVIEW_TIME
		{
			get{ return _REVIEW_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TIME, _REVIEW_TIME, value);
				this._REVIEW_TIME = value;
			}
		}
		/// <summary>
		/// 审查是否通过（0否，1是）
		/// </summary>
		public decimal? IS_PASS_REVIEW
		{
			get{ return _IS_PASS_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.IS_PASS_REVIEW, _IS_PASS_REVIEW, value);
				this._IS_PASS_REVIEW = value;
			}
		}
		/// <summary>
		/// 审查意见
		/// </summary>
		public string REVIEW_COMMENT
		{
			get{ return _REVIEW_COMMENT; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_COMMENT, _REVIEW_COMMENT, value);
				this._REVIEW_COMMENT = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string SECTION_CODE
		{
			get{ return _SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_CODE, _SECTION_CODE, value);
				this._SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string SECTION_NAME
		{
			get{ return _SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NAME, _SECTION_NAME, value);
				this._SECTION_NAME = value;
			}
		}
		/// <summary>
		/// DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 对应的公共服务平台的对应的M_ID
		/// </summary>
		public string M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 招标项目名称
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
		/// 送审单位名称（招标人或者招标代理机构）
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
		/// 招标项目的data_key
		/// </summary>
		public string NOTICE_KEY
		{
			get{ return _NOTICE_KEY; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_KEY, _NOTICE_KEY, value);
				this._NOTICE_KEY = value;
			}
		}
		/// <summary>
		/// 审核单位名称
		/// </summary>
		public string AUDIT_UNIT
		{
			get{ return _AUDIT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_UNIT, _AUDIT_UNIT, value);
				this._AUDIT_UNIT = value;
			}
		}
		/// <summary>
		/// 上报的用户编码
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
		/// 上报的当前时间
		/// </summary>
		public string M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 标段（包）类型
		/// </summary>
		public string SECTION_TYPE
		{
			get{ return _SECTION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_TYPE, _SECTION_TYPE, value);
				this._SECTION_TYPE = value;
			}
		}
		/// <summary>
		/// 是否查看过
		/// </summary>
		public decimal? IS_VIEW
		{
			get{ return _IS_VIEW; }
			set
			{
				this.OnPropertyValueChange(_.IS_VIEW, _IS_VIEW, value);
				this._IS_VIEW = value;
			}
		}
		/// <summary>
		/// 备案审查的key
		/// </summary>
		public string REVIEW_KEY
		{
			get{ return _REVIEW_KEY; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_KEY, _REVIEW_KEY, value);
				this._REVIEW_KEY = value;
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
				_.ID,
				_.REVIEW_TYPE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_TYPE,
				_.TENDER_AGENCY_CODE,
				_.COMMIT_TIME,
				_.IS_REVIEW,
				_.REVIEW_TIME,
				_.IS_PASS_REVIEW,
				_.REVIEW_COMMENT,
				_.SECTION_CODE,
				_.SECTION_NAME,
				_.DATA_KEY,
				_.M_ID,
				_.TENDER_PROJECT_NAME,
				_.TENDER_AGENCY_NAME,
				_.NOTICE_KEY,
				_.AUDIT_UNIT,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.SECTION_TYPE,
				_.IS_VIEW,
				_.REVIEW_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REVIEW_TYPE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_TYPE,
				this._TENDER_AGENCY_CODE,
				this._COMMIT_TIME,
				this._IS_REVIEW,
				this._REVIEW_TIME,
				this._IS_PASS_REVIEW,
				this._REVIEW_COMMENT,
				this._SECTION_CODE,
				this._SECTION_NAME,
				this._DATA_KEY,
				this._M_ID,
				this._TENDER_PROJECT_NAME,
				this._TENDER_AGENCY_NAME,
				this._NOTICE_KEY,
				this._AUDIT_UNIT,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._SECTION_TYPE,
				this._IS_VIEW,
				this._REVIEW_KEY,
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
			public readonly static Field All = new Field("*", "T_RECORD_REVIEW");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RECORD_REVIEW", "ID");
            /// <summary>
			/// 审查类型
			/// </summary>
			public readonly static Field REVIEW_TYPE = new Field("REVIEW_TYPE", "T_RECORD_REVIEW", "审查类型");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_RECORD_REVIEW", "招标项目编号");
            /// <summary>
			/// 招标项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "T_RECORD_REVIEW", "招标项目类型");
            /// <summary>
			/// 送审单位代码（招标人或者招标代理机构）
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "T_RECORD_REVIEW", "送审单位代码（招标人或者招标代理机构）");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "T_RECORD_REVIEW", "提交时间");
            /// <summary>
			/// 是否审查（0否，1是）
			/// </summary>
			public readonly static Field IS_REVIEW = new Field("IS_REVIEW", "T_RECORD_REVIEW", "是否审查（0否，1是）");
            /// <summary>
			/// 审查时间
			/// </summary>
			public readonly static Field REVIEW_TIME = new Field("REVIEW_TIME", "T_RECORD_REVIEW", "审查时间");
            /// <summary>
			/// 审查是否通过（0否，1是）
			/// </summary>
			public readonly static Field IS_PASS_REVIEW = new Field("IS_PASS_REVIEW", "T_RECORD_REVIEW", "审查是否通过（0否，1是）");
            /// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field REVIEW_COMMENT = new Field("REVIEW_COMMENT", "T_RECORD_REVIEW", "审查意见");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "T_RECORD_REVIEW", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field SECTION_NAME = new Field("SECTION_NAME", "T_RECORD_REVIEW", "标段（包）名称");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_RECORD_REVIEW", "DATA_KEY");
            /// <summary>
			/// 对应的公共服务平台的对应的M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_RECORD_REVIEW", "对应的公共服务平台的对应的M_ID");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_RECORD_REVIEW", "招标项目名称");
            /// <summary>
			/// 送审单位名称（招标人或者招标代理机构）
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "T_RECORD_REVIEW", "送审单位名称（招标人或者招标代理机构）");
            /// <summary>
			/// 招标项目的data_key
			/// </summary>
			public readonly static Field NOTICE_KEY = new Field("NOTICE_KEY", "T_RECORD_REVIEW", "招标项目的data_key");
            /// <summary>
			/// 审核单位名称
			/// </summary>
			public readonly static Field AUDIT_UNIT = new Field("AUDIT_UNIT", "T_RECORD_REVIEW", "审核单位名称");
            /// <summary>
			/// 上报的用户编码
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_RECORD_REVIEW", "上报的用户编码");
            /// <summary>
			/// 上报的当前时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_RECORD_REVIEW", "上报的当前时间");
            /// <summary>
			/// 标段（包）类型
			/// </summary>
			public readonly static Field SECTION_TYPE = new Field("SECTION_TYPE", "T_RECORD_REVIEW", "标段（包）类型");
            /// <summary>
			/// 是否查看过
			/// </summary>
			public readonly static Field IS_VIEW = new Field("IS_VIEW", "T_RECORD_REVIEW", "是否查看过");
            /// <summary>
			/// 备案审查的key
			/// </summary>
			public readonly static Field REVIEW_KEY = new Field("REVIEW_KEY", "T_RECORD_REVIEW", "备案审查的key");
        }
        #endregion
	}
}