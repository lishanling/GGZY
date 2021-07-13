using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRT_ROLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRT_ROLE")]
    [Serializable]
    public partial class PRT_ROLE : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _CREATE_BY;
		private DateTime? _CREATE_DATE;
		private string _UPDATE_BY;
		private DateTime? _UPDATE_DATE;
		private string _REMARKS;
		private decimal? _ENABLED;
		private string _SYSTEM_NAME;
		private string _M_DATA_SOURCE;

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
		/// 名称
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
		/// 是否启用
		/// </summary>
		public decimal? ENABLED
		{
			get{ return _ENABLED; }
			set
			{
				this.OnPropertyValueChange(_.ENABLED, _ENABLED, value);
				this._ENABLED = value;
			}
		}
		/// <summary>
		/// 系统名称
		/// </summary>
		public string SYSTEM_NAME
		{
			get{ return _SYSTEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NAME, _SYSTEM_NAME, value);
				this._SYSTEM_NAME = value;
			}
		}
		/// <summary>
		/// 数据源
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
				_.CREATE_BY,
				_.CREATE_DATE,
				_.UPDATE_BY,
				_.UPDATE_DATE,
				_.REMARKS,
				_.ENABLED,
				_.SYSTEM_NAME,
				_.M_DATA_SOURCE,
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
				this._CREATE_BY,
				this._CREATE_DATE,
				this._UPDATE_BY,
				this._UPDATE_DATE,
				this._REMARKS,
				this._ENABLED,
				this._SYSTEM_NAME,
				this._M_DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "PRT_ROLE");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRT_ROLE", "主键");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "PRT_ROLE", "名称");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "PRT_ROLE", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "PRT_ROLE", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "PRT_ROLE", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATE_DATE = new Field("UPDATE_DATE", "PRT_ROLE", "修改时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "PRT_ROLE", "备注");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field ENABLED = new Field("ENABLED", "PRT_ROLE", "是否启用");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYSTEM_NAME = new Field("SYSTEM_NAME", "PRT_ROLE", "系统名称");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PRT_ROLE", "数据源");
        }
        #endregion
	}
}