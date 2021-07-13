using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_RECORD_REVIEW_NEW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RECORD_REVIEW_NEW")]
    [Serializable]
    public partial class T_RECORD_REVIEW_NEW : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _REVIEW_TYPE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_AGENCY_CODE;
		private DateTime? _COMMIT_TIME;
		private decimal? _REVIEW_STATUS;
		private DateTime? _REVIEW_TIME;
		private decimal? _IS_PASS_REVIEW;
		private string _REVIEW_COMMENT;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_AGENCY_NAME;
		private string _AUDIT_UNIT;
		private string _M_DATA_SOURCE;
		private string _SECTION_TYPE;
		private decimal? _IS_VIEW;
		private string _PROJECT_NAME;
		private string _REGION_CODE;
		private string _TENDERER_CODE;
		private string _TENDERER_NAME;
		private string _TENDER_CONTENT;
		private string _REVIEW_ID;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private string _CONTRACT_NAME;
		private string _CONTRACT_PHONE;
		private decimal? _USERID;

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
		/// 招标代理机构代码
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
		/// 状态（0未提交，1已提交，2已审核）
		/// </summary>
		public decimal? REVIEW_STATUS
		{
			get{ return _REVIEW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_STATUS, _REVIEW_STATUS, value);
				this._REVIEW_STATUS = value;
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
		/// 招标代理机构名称
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
		/// 备案部门
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
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 项目所在行政区域
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
		/// 招标人代码
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
		/// 招标人名称
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
		/// 招标内容与范围及招标方案说明
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
		/// 备案编号
		/// </summary>
		public string REVIEW_ID
		{
			get{ return _REVIEW_ID; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_ID, _REVIEW_ID, value);
				this._REVIEW_ID = value;
			}
		}
		/// <summary>
		/// 招标方式
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
		/// 招标组织形式
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
		/// 联系人名称
		/// </summary>
		public string CONTRACT_NAME
		{
			get{ return _CONTRACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_NAME, _CONTRACT_NAME, value);
				this._CONTRACT_NAME = value;
			}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string CONTRACT_PHONE
		{
			get{ return _CONTRACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PHONE, _CONTRACT_PHONE, value);
				this._CONTRACT_PHONE = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? USERID
		{
			get{ return _USERID; }
			set
			{
				this.OnPropertyValueChange(_.USERID, _USERID, value);
				this._USERID = value;
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
				_.TENDER_AGENCY_CODE,
				_.COMMIT_TIME,
				_.REVIEW_STATUS,
				_.REVIEW_TIME,
				_.IS_PASS_REVIEW,
				_.REVIEW_COMMENT,
				_.TENDER_PROJECT_NAME,
				_.TENDER_AGENCY_NAME,
				_.AUDIT_UNIT,
				_.M_DATA_SOURCE,
				_.SECTION_TYPE,
				_.IS_VIEW,
				_.PROJECT_NAME,
				_.REGION_CODE,
				_.TENDERER_CODE,
				_.TENDERER_NAME,
				_.TENDER_CONTENT,
				_.REVIEW_ID,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.CONTRACT_NAME,
				_.CONTRACT_PHONE,
				_.USERID,
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
				this._TENDER_AGENCY_CODE,
				this._COMMIT_TIME,
				this._REVIEW_STATUS,
				this._REVIEW_TIME,
				this._IS_PASS_REVIEW,
				this._REVIEW_COMMENT,
				this._TENDER_PROJECT_NAME,
				this._TENDER_AGENCY_NAME,
				this._AUDIT_UNIT,
				this._M_DATA_SOURCE,
				this._SECTION_TYPE,
				this._IS_VIEW,
				this._PROJECT_NAME,
				this._REGION_CODE,
				this._TENDERER_CODE,
				this._TENDERER_NAME,
				this._TENDER_CONTENT,
				this._REVIEW_ID,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._CONTRACT_NAME,
				this._CONTRACT_PHONE,
				this._USERID,
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
			public readonly static Field All = new Field("*", "T_RECORD_REVIEW_NEW");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RECORD_REVIEW_NEW", "ID");
            /// <summary>
			/// 审查类型
			/// </summary>
			public readonly static Field REVIEW_TYPE = new Field("REVIEW_TYPE", "T_RECORD_REVIEW_NEW", "审查类型");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_RECORD_REVIEW_NEW", "招标项目编号");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "T_RECORD_REVIEW_NEW", "招标代理机构代码");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "T_RECORD_REVIEW_NEW", "提交时间");
            /// <summary>
			/// 状态（0未提交，1已提交，2已审核）
			/// </summary>
			public readonly static Field REVIEW_STATUS = new Field("REVIEW_STATUS", "T_RECORD_REVIEW_NEW", "状态（0未提交，1已提交，2已审核）");
            /// <summary>
			/// 审查时间
			/// </summary>
			public readonly static Field REVIEW_TIME = new Field("REVIEW_TIME", "T_RECORD_REVIEW_NEW", "审查时间");
            /// <summary>
			/// 审查是否通过（0否，1是）
			/// </summary>
			public readonly static Field IS_PASS_REVIEW = new Field("IS_PASS_REVIEW", "T_RECORD_REVIEW_NEW", "审查是否通过（0否，1是）");
            /// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field REVIEW_COMMENT = new Field("REVIEW_COMMENT", "T_RECORD_REVIEW_NEW", "审查意见");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_RECORD_REVIEW_NEW", "招标项目名称");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "T_RECORD_REVIEW_NEW", "招标代理机构名称");
            /// <summary>
			/// 备案部门
			/// </summary>
			public readonly static Field AUDIT_UNIT = new Field("AUDIT_UNIT", "T_RECORD_REVIEW_NEW", "备案部门");
            /// <summary>
			/// 上报的用户编码
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_RECORD_REVIEW_NEW", "上报的用户编码");
            /// <summary>
			/// 标段（包）类型
			/// </summary>
			public readonly static Field SECTION_TYPE = new Field("SECTION_TYPE", "T_RECORD_REVIEW_NEW", "标段（包）类型");
            /// <summary>
			/// 是否查看过
			/// </summary>
			public readonly static Field IS_VIEW = new Field("IS_VIEW", "T_RECORD_REVIEW_NEW", "是否查看过");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_RECORD_REVIEW_NEW", "项目名称");
            /// <summary>
			/// 项目所在行政区域
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_RECORD_REVIEW_NEW", "项目所在行政区域");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "T_RECORD_REVIEW_NEW", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "T_RECORD_REVIEW_NEW", "招标人名称");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "T_RECORD_REVIEW_NEW",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 备案编号
			/// </summary>
			public readonly static Field REVIEW_ID = new Field("REVIEW_ID", "T_RECORD_REVIEW_NEW", "备案编号");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "T_RECORD_REVIEW_NEW", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "T_RECORD_REVIEW_NEW", "招标组织形式");
            /// <summary>
			/// 联系人名称
			/// </summary>
			public readonly static Field CONTRACT_NAME = new Field("CONTRACT_NAME", "T_RECORD_REVIEW_NEW", "联系人名称");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field CONTRACT_PHONE = new Field("CONTRACT_PHONE", "T_RECORD_REVIEW_NEW", "联系人电话");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "T_RECORD_REVIEW_NEW", "创建人");
        }
        #endregion
	}
}