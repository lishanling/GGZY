using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_ANALYSIS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_ANALYSIS")]
    [Serializable]
    public partial class PRODUCT_ANALYSIS : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REPORT_NAME;
		private string _ENABLE;
		private string _ADD_MAN;
		private DateTime? _ADD_TIME;
		private string _ASSOCIATION_TABLE;
		private string _ASSOCIATION_FIELD;
		private string _REMARKS;

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
		/// 报表名称
		/// </summary>
		public string REPORT_NAME
		{
			get{ return _REPORT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_NAME, _REPORT_NAME, value);
				this._REPORT_NAME = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public string ENABLE
		{
			get{ return _ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.ENABLE, _ENABLE, value);
				this._ENABLE = value;
			}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public string ADD_MAN
		{
			get{ return _ADD_MAN; }
			set
			{
				this.OnPropertyValueChange(_.ADD_MAN, _ADD_MAN, value);
				this._ADD_MAN = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? ADD_TIME
		{
			get{ return _ADD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ADD_TIME, _ADD_TIME, value);
				this._ADD_TIME = value;
			}
		}
		/// <summary>
		/// 关联表
		/// </summary>
		public string ASSOCIATION_TABLE
		{
			get{ return _ASSOCIATION_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.ASSOCIATION_TABLE, _ASSOCIATION_TABLE, value);
				this._ASSOCIATION_TABLE = value;
			}
		}
		/// <summary>
		/// 关联字段
		/// </summary>
		public string ASSOCIATION_FIELD
		{
			get{ return _ASSOCIATION_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.ASSOCIATION_FIELD, _ASSOCIATION_FIELD, value);
				this._ASSOCIATION_FIELD = value;
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
				_.REPORT_NAME,
				_.ENABLE,
				_.ADD_MAN,
				_.ADD_TIME,
				_.ASSOCIATION_TABLE,
				_.ASSOCIATION_FIELD,
				_.REMARKS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REPORT_NAME,
				this._ENABLE,
				this._ADD_MAN,
				this._ADD_TIME,
				this._ASSOCIATION_TABLE,
				this._ASSOCIATION_FIELD,
				this._REMARKS,
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
			public readonly static Field All = new Field("*", "PRODUCT_ANALYSIS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_ANALYSIS", "ID");
            /// <summary>
			/// 报表名称
			/// </summary>
			public readonly static Field REPORT_NAME = new Field("REPORT_NAME", "PRODUCT_ANALYSIS", "报表名称");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field ENABLE = new Field("ENABLE", "PRODUCT_ANALYSIS", "是否启用");
            /// <summary>
			/// 添加人
			/// </summary>
			public readonly static Field ADD_MAN = new Field("ADD_MAN", "PRODUCT_ANALYSIS", "添加人");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field ADD_TIME = new Field("ADD_TIME", "PRODUCT_ANALYSIS", "添加时间");
            /// <summary>
			/// 关联表
			/// </summary>
			public readonly static Field ASSOCIATION_TABLE = new Field("ASSOCIATION_TABLE", "PRODUCT_ANALYSIS", "关联表");
            /// <summary>
			/// 关联字段
			/// </summary>
			public readonly static Field ASSOCIATION_FIELD = new Field("ASSOCIATION_FIELD", "PRODUCT_ANALYSIS", "关联字段");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "PRODUCT_ANALYSIS", "备注");
        }
        #endregion
	}
}