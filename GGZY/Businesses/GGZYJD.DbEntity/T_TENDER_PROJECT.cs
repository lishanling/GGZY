using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TENDER_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TENDER_PROJECT")]
    [Serializable]
    public partial class T_TENDER_PROJECT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_TYPE;
		private string _REGION_CODE;
		private DateTime? _CREATE_TIME;
		private decimal? _ISCREATE;
		private DateTime? _T_TM;
		private string _OWNER_NAME;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_CODE;
		private string _PLATFORM_NAME;
		private string _PLATFORM_CODE;
		private decimal? _BROWSE_NUM;

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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		/// 招标项目所在行政区域代码
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
		/// 招标项目建立时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 是否已创建监督点
		/// </summary>
		public decimal? ISCREATE
		{
			get{ return _ISCREATE; }
			set
			{
				this.OnPropertyValueChange(_.ISCREATE, _ISCREATE, value);
				this._ISCREATE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? T_TM
		{
			get{ return _T_TM; }
			set
			{
				this.OnPropertyValueChange(_.T_TM, _T_TM, value);
				this._T_TM = value;
			}
		}
		/// <summary>
		/// 项目业主名称
		/// </summary>
		public string OWNER_NAME
		{
			get{ return _OWNER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NAME, _OWNER_NAME, value);
				this._OWNER_NAME = value;
			}
		}
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 监督部门代码
		/// </summary>
		public string SUPERVISE_DEPT_CODE
		{
			get{ return _SUPERVISE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_CODE, _SUPERVISE_DEPT_CODE, value);
				this._SUPERVISE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 交易系统名称
		/// </summary>
		public string PLATFORM_NAME
		{
			get{ return _PLATFORM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_NAME, _PLATFORM_NAME, value);
				this._PLATFORM_NAME = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 浏览次数
		/// </summary>
		public decimal? BROWSE_NUM
		{
			get{ return _BROWSE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BROWSE_NUM, _BROWSE_NUM, value);
				this._BROWSE_NUM = value;
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
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_TYPE,
				_.REGION_CODE,
				_.CREATE_TIME,
				_.ISCREATE,
				_.T_TM,
				_.OWNER_NAME,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_CODE,
				_.PLATFORM_NAME,
				_.PLATFORM_CODE,
				_.BROWSE_NUM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_TYPE,
				this._REGION_CODE,
				this._CREATE_TIME,
				this._ISCREATE,
				this._T_TM,
				this._OWNER_NAME,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_CODE,
				this._PLATFORM_NAME,
				this._PLATFORM_CODE,
				this._BROWSE_NUM,
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
			public readonly static Field All = new Field("*", "T_TENDER_PROJECT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TENDER_PROJECT", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_TENDER_PROJECT", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_TENDER_PROJECT", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_TENDER_PROJECT", "招标项目名称");
            /// <summary>
			/// 招标项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "T_TENDER_PROJECT", "招标项目类型");
            /// <summary>
			/// 招标项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_TENDER_PROJECT", "招标项目所在行政区域代码");
            /// <summary>
			/// 招标项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_TENDER_PROJECT", "招标项目建立时间");
            /// <summary>
			/// 是否已创建监督点
			/// </summary>
			public readonly static Field ISCREATE = new Field("ISCREATE", "T_TENDER_PROJECT", "是否已创建监督点");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field T_TM = new Field("T_TM", "T_TENDER_PROJECT", "创建时间");
            /// <summary>
			/// 项目业主名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "T_TENDER_PROJECT", "项目业主名称");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "T_TENDER_PROJECT", "监督部门名称");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "T_TENDER_PROJECT", "监督部门代码");
            /// <summary>
			/// 交易系统名称
			/// </summary>
			public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME", "T_TENDER_PROJECT", "交易系统名称");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_TENDER_PROJECT", "交易系统标识码");
            /// <summary>
			/// 浏览次数
			/// </summary>
			public readonly static Field BROWSE_NUM = new Field("BROWSE_NUM", "T_TENDER_PROJECT", "浏览次数");
        }
        #endregion
	}
}