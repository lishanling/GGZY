using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRT_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRT_USER")]
    [Serializable]
    public partial class PRT_USER : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _UNAME;
		private string _PWD;
		private decimal? _STATUS;
		private string _CREATE_BY;
		private DateTime? _CREATE_DATE;
		private string _UPDATE_BY;
		private DateTime? _UPDATE_DATE;
		private string _REMARKS;
		private string _ROLEIDS;
		private string _REGIONNAME;
		private string _REGIONCODES;

		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 登录名
		/// </summary>
		public string UNAME
		{
			get{ return _UNAME; }
			set
			{
				this.OnPropertyValueChange(_.UNAME, _UNAME, value);
				this._UNAME = value;
			}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string PWD
		{
			get{ return _PWD; }
			set
			{
				this.OnPropertyValueChange(_.PWD, _PWD, value);
				this._PWD = value;
			}
		}
		/// <summary>
		/// 状态 0 不启用-不允许登录 1启用- 允许登录
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			get{ return _CREATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DATE, _CREATE_DATE, value);
				this._CREATE_DATE = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATE_BY
		{
			get{ return _UPDATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_BY, _UPDATE_BY, value);
				this._UPDATE_BY = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATE_DATE
		{
			get{ return _UPDATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_DATE, _UPDATE_DATE, value);
				this._UPDATE_DATE = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARKS
		{
			get{ return _REMARKS; }
			set
			{
				this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
				this._REMARKS = value;
			}
		}
		/// <summary>
		/// 用户角色
		/// </summary>
		public string ROLEIDS
		{
			get{ return _ROLEIDS; }
			set
			{
				this.OnPropertyValueChange(_.ROLEIDS, _ROLEIDS, value);
				this._ROLEIDS = value;
			}
		}
		/// <summary>
		/// 区域名称
		/// </summary>
		public string REGIONNAME
		{
			get{ return _REGIONNAME; }
			set
			{
				this.OnPropertyValueChange(_.REGIONNAME, _REGIONNAME, value);
				this._REGIONNAME = value;
			}
		}
		/// <summary>
		/// 区域编号
		/// </summary>
		public string REGIONCODES
		{
			get{ return _REGIONCODES; }
			set
			{
				this.OnPropertyValueChange(_.REGIONCODES, _REGIONCODES, value);
				this._REGIONCODES = value;
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
				_.NAME,
				_.UNAME,
				_.PWD,
				_.STATUS,
				_.CREATE_BY,
				_.CREATE_DATE,
				_.UPDATE_BY,
				_.UPDATE_DATE,
				_.REMARKS,
				_.ROLEIDS,
				_.REGIONNAME,
				_.REGIONCODES,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._UNAME,
				this._PWD,
				this._STATUS,
				this._CREATE_BY,
				this._CREATE_DATE,
				this._UPDATE_BY,
				this._UPDATE_DATE,
				this._REMARKS,
				this._ROLEIDS,
				this._REGIONNAME,
				this._REGIONCODES,
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
			public readonly static Field All = new Field("*", "PRT_USER");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRT_USER", "主键");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "PRT_USER", "姓名");
            /// <summary>
			/// 登录名
			/// </summary>
			public readonly static Field UNAME = new Field("UNAME", "PRT_USER", "登录名");
            /// <summary>
			/// 密码
			/// </summary>
			public readonly static Field PWD = new Field("PWD", "PRT_USER", "密码");
            /// <summary>
			/// 状态 0 不启用-不允许登录 1启用- 允许登录
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "PRT_USER", "状态 0 不启用-不允许登录 1启用- 允许登录");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "PRT_USER", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "PRT_USER", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "PRT_USER", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATE_DATE = new Field("UPDATE_DATE", "PRT_USER", "修改时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "PRT_USER", "备注");
            /// <summary>
			/// 用户角色
			/// </summary>
			public readonly static Field ROLEIDS = new Field("ROLEIDS", "PRT_USER", "用户角色");
            /// <summary>
			/// 区域名称
			/// </summary>
			public readonly static Field REGIONNAME = new Field("REGIONNAME", "PRT_USER", "区域名称");
            /// <summary>
			/// 区域编号
			/// </summary>
			public readonly static Field REGIONCODES = new Field("REGIONCODES", "PRT_USER", "区域编号");
        }
        #endregion
	}
}