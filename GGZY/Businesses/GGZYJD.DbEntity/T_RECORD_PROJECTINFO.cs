using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_RECORD_PROJECTINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RECORD_PROJECTINFO")]
    [Serializable]
    public partial class T_RECORD_PROJECTINFO : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_AGENCY_NAME;
		private string _M_DATA_SOURCE;
		private string _SECTION_TYPE;
		private string _PROJECT_NAME;
		private string _REGION_CODE;
		private string _TENDERER_CODE;
		private string _TENDERER_NAME;
		private string _TENDER_CONTENT;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private string _AUDIT_UNIT;
		private string _CONTRACT_NAME;
		private string _CONTRACT_PHONE;
		private DateTime? _M_TM;
		private decimal? _USERID;

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
		/// 项目基本信息提交时间
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
				_.TENDER_PROJECT_CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDER_PROJECT_CODE,
				_.TENDER_AGENCY_CODE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_AGENCY_NAME,
				_.M_DATA_SOURCE,
				_.SECTION_TYPE,
				_.PROJECT_NAME,
				_.REGION_CODE,
				_.TENDERER_CODE,
				_.TENDERER_NAME,
				_.TENDER_CONTENT,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.AUDIT_UNIT,
				_.CONTRACT_NAME,
				_.CONTRACT_PHONE,
				_.M_TM,
				_.USERID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._TENDER_AGENCY_CODE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_AGENCY_NAME,
				this._M_DATA_SOURCE,
				this._SECTION_TYPE,
				this._PROJECT_NAME,
				this._REGION_CODE,
				this._TENDERER_CODE,
				this._TENDERER_NAME,
				this._TENDER_CONTENT,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._AUDIT_UNIT,
				this._CONTRACT_NAME,
				this._CONTRACT_PHONE,
				this._M_TM,
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
			public readonly static Field All = new Field("*", "T_RECORD_PROJECTINFO");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_RECORD_PROJECTINFO", "招标项目编号");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "T_RECORD_PROJECTINFO", "招标代理机构代码");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_RECORD_PROJECTINFO", "招标项目名称");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "T_RECORD_PROJECTINFO", "招标代理机构名称");
            /// <summary>
			/// 上报的用户编码
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_RECORD_PROJECTINFO", "上报的用户编码");
            /// <summary>
			/// 标段（包）类型
			/// </summary>
			public readonly static Field SECTION_TYPE = new Field("SECTION_TYPE", "T_RECORD_PROJECTINFO", "标段（包）类型");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_RECORD_PROJECTINFO", "项目名称");
            /// <summary>
			/// 项目所在行政区域
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_RECORD_PROJECTINFO", "项目所在行政区域");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "T_RECORD_PROJECTINFO", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "T_RECORD_PROJECTINFO", "招标人名称");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "T_RECORD_PROJECTINFO",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "T_RECORD_PROJECTINFO", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "T_RECORD_PROJECTINFO", "招标组织形式");
            /// <summary>
			/// 备案部门
			/// </summary>
			public readonly static Field AUDIT_UNIT = new Field("AUDIT_UNIT", "T_RECORD_PROJECTINFO", "备案部门");
            /// <summary>
			/// 联系人名称
			/// </summary>
			public readonly static Field CONTRACT_NAME = new Field("CONTRACT_NAME", "T_RECORD_PROJECTINFO", "联系人名称");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field CONTRACT_PHONE = new Field("CONTRACT_PHONE", "T_RECORD_PROJECTINFO", "联系人电话");
            /// <summary>
			/// 项目基本信息提交时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_RECORD_PROJECTINFO", "项目基本信息提交时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "T_RECORD_PROJECTINFO", "创建人");
        }
        #endregion
	}
}