using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PROJECT_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PROJECT_DATA")]
    [Serializable]
    public partial class T_PROJECT_DATA : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _BUSINESSID;
		private string _TP_CODE;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _PROJECT_TYPE;
		private string _REGION_CODE;
		private DateTime? _CREATE_TIME;
		private string _PLATFORM_NAME;
		private string _PLATFORM_CODE;
		private string _OWNER_NAME;
		private string _AGENCY_NAME;
		private string _AGENCY_CODE;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_CODE;
		private decimal? _IS_FINISH;
		private decimal? _BROWSE_NUM;
		private DateTime? _T_TM;
		private string _PROJECT_CATEGORY;
		private string _IN_NODE;
		private DateTime? _START_TM;
		private string _ERROR_NODES;
		private string _TYPE;

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
		/// 业务流水号
		/// </summary>
		public string BUSINESSID
		{
			get{ return _BUSINESSID; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSID, _BUSINESSID, value);
				this._BUSINESSID = value;
			}
		}
		/// <summary>
		/// 归属流程编码
		/// </summary>
		public string TP_CODE
		{
			get{ return _TP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TP_CODE, _TP_CODE, value);
				this._TP_CODE = value;
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
		/// 招标项目名称
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
		/// 项目类型
		/// </summary>
		public string PROJECT_TYPE
		{
			get{ return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 项目所在行政区域代码
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
		/// 项目建立时间
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
		/// 交易平台名称
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
		/// 交易平台标识码
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
		/// 代理机构名称
		/// </summary>
		public string AGENCY_NAME
		{
			get{ return _AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_NAME, _AGENCY_NAME, value);
				this._AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 代理机构代码
		/// </summary>
		public string AGENCY_CODE
		{
			get{ return _AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_CODE, _AGENCY_CODE, value);
				this._AGENCY_CODE = value;
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
		/// 是否已完成监督
		/// </summary>
		public decimal? IS_FINISH
		{
			get{ return _IS_FINISH; }
			set
			{
				this.OnPropertyValueChange(_.IS_FINISH, _IS_FINISH, value);
				this._IS_FINISH = value;
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
		/// 行业类别
		/// </summary>
		public string PROJECT_CATEGORY
		{
			get{ return _PROJECT_CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CATEGORY, _PROJECT_CATEGORY, value);
				this._PROJECT_CATEGORY = value;
			}
		}
		/// <summary>
		/// 当前监督节点
		/// </summary>
		public string IN_NODE
		{
			get{ return _IN_NODE; }
			set
			{
				this.OnPropertyValueChange(_.IN_NODE, _IN_NODE, value);
				this._IN_NODE = value;
			}
		}
		/// <summary>
		/// 监督启动时间
		/// </summary>
		public DateTime? START_TM
		{
			get{ return _START_TM; }
			set
			{
				this.OnPropertyValueChange(_.START_TM, _START_TM, value);
				this._START_TM = value;
			}
		}
		/// <summary>
		/// 监督失败的节点，多个用“,”分割
		/// </summary>
		public string ERROR_NODES
		{
			get{ return _ERROR_NODES; }
			set
			{
				this.OnPropertyValueChange(_.ERROR_NODES, _ERROR_NODES, value);
				this._ERROR_NODES = value;
			}
		}
		/// <summary>
		/// 数据类型（通用：无,住建：ZJ,水利：SL,交通：JT）
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
				_.BUSINESSID,
				_.TP_CODE,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.PROJECT_TYPE,
				_.REGION_CODE,
				_.CREATE_TIME,
				_.PLATFORM_NAME,
				_.PLATFORM_CODE,
				_.OWNER_NAME,
				_.AGENCY_NAME,
				_.AGENCY_CODE,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_CODE,
				_.IS_FINISH,
				_.BROWSE_NUM,
				_.T_TM,
				_.PROJECT_CATEGORY,
				_.IN_NODE,
				_.START_TM,
				_.ERROR_NODES,
				_.TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BUSINESSID,
				this._TP_CODE,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._PROJECT_TYPE,
				this._REGION_CODE,
				this._CREATE_TIME,
				this._PLATFORM_NAME,
				this._PLATFORM_CODE,
				this._OWNER_NAME,
				this._AGENCY_NAME,
				this._AGENCY_CODE,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_CODE,
				this._IS_FINISH,
				this._BROWSE_NUM,
				this._T_TM,
				this._PROJECT_CATEGORY,
				this._IN_NODE,
				this._START_TM,
				this._ERROR_NODES,
				this._TYPE,
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
			public readonly static Field All = new Field("*", "T_PROJECT_DATA");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PROJECT_DATA", "ID");
            /// <summary>
			/// 业务流水号
			/// </summary>
			public readonly static Field BUSINESSID = new Field("BUSINESSID", "T_PROJECT_DATA", "业务流水号");
            /// <summary>
			/// 归属流程编码
			/// </summary>
			public readonly static Field TP_CODE = new Field("TP_CODE", "T_PROJECT_DATA", "归属流程编码");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_PROJECT_DATA", "项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_PROJECT_DATA", "招标项目名称");
            /// <summary>
			/// 项目类型
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "T_PROJECT_DATA", "项目类型");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_PROJECT_DATA", "项目所在行政区域代码");
            /// <summary>
			/// 项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_PROJECT_DATA", "项目建立时间");
            /// <summary>
			/// 交易平台名称
			/// </summary>
			public readonly static Field PLATFORM_NAME = new Field("PLATFORM_NAME", "T_PROJECT_DATA", "交易平台名称");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_PROJECT_DATA", "交易平台标识码");
            /// <summary>
			/// 项目业主名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "T_PROJECT_DATA", "项目业主名称");
            /// <summary>
			/// 代理机构名称
			/// </summary>
			public readonly static Field AGENCY_NAME = new Field("AGENCY_NAME", "T_PROJECT_DATA", "代理机构名称");
            /// <summary>
			/// 代理机构代码
			/// </summary>
			public readonly static Field AGENCY_CODE = new Field("AGENCY_CODE", "T_PROJECT_DATA", "代理机构代码");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "T_PROJECT_DATA", "监督部门名称");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "T_PROJECT_DATA", "监督部门代码");
            /// <summary>
			/// 是否已完成监督
			/// </summary>
			public readonly static Field IS_FINISH = new Field("IS_FINISH", "T_PROJECT_DATA", "是否已完成监督");
            /// <summary>
			/// 浏览次数
			/// </summary>
			public readonly static Field BROWSE_NUM = new Field("BROWSE_NUM", "T_PROJECT_DATA", "浏览次数");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field T_TM = new Field("T_TM", "T_PROJECT_DATA", "创建时间");
            /// <summary>
			/// 行业类别
			/// </summary>
			public readonly static Field PROJECT_CATEGORY = new Field("PROJECT_CATEGORY", "T_PROJECT_DATA", "行业类别");
            /// <summary>
			/// 当前监督节点
			/// </summary>
			public readonly static Field IN_NODE = new Field("IN_NODE", "T_PROJECT_DATA", "当前监督节点");
            /// <summary>
			/// 监督启动时间
			/// </summary>
			public readonly static Field START_TM = new Field("START_TM", "T_PROJECT_DATA", "监督启动时间");
            /// <summary>
			/// 监督失败的节点，多个用“,”分割
			/// </summary>
			public readonly static Field ERROR_NODES = new Field("ERROR_NODES", "T_PROJECT_DATA", "监督失败的节点，多个用“,”分割");
            /// <summary>
			/// 数据类型（通用：无,住建：ZJ,水利：SL,交通：JT）
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_PROJECT_DATA", "数据类型（通用：无,住建：ZJ,水利：SL,交通：JT）");
        }
        #endregion
	}
}