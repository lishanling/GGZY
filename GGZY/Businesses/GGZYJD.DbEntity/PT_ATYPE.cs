using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ATYPE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ATYPE")]
    [Serializable]
    public partial class PT_ATYPE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _PARENT_ID;
		private string _TEXT;
		private string _CODE;
		private decimal? _ORDER_ID;
		private string _REMARK;
		private string _SHOWTYPE;

		/// <summary>
		/// 编号
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
		/// 父编号
		/// </summary>
		public decimal? PARENT_ID
		{
			get{ return _PARENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.PARENT_ID, _PARENT_ID, value);
				this._PARENT_ID = value;
			}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string TEXT
		{
			get{ return _TEXT; }
			set
			{
				this.OnPropertyValueChange(_.TEXT, _TEXT, value);
				this._TEXT = value;
			}
		}
		/// <summary>
		/// 类型编码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 排序编号
		/// </summary>
		public decimal? ORDER_ID
		{
			get{ return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 文章显示类型
		/// </summary>
		public string SHOWTYPE
		{
			get{ return _SHOWTYPE; }
			set
			{
				this.OnPropertyValueChange(_.SHOWTYPE, _SHOWTYPE, value);
				this._SHOWTYPE = value;
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
				_.PARENT_ID,
				_.TEXT,
				_.CODE,
				_.ORDER_ID,
				_.REMARK,
				_.SHOWTYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PARENT_ID,
				this._TEXT,
				this._CODE,
				this._ORDER_ID,
				this._REMARK,
				this._SHOWTYPE,
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
			public readonly static Field All = new Field("*", "PT_ATYPE");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ATYPE", "编号");
            /// <summary>
			/// 父编号
			/// </summary>
			public readonly static Field PARENT_ID = new Field("PARENT_ID", "PT_ATYPE", "父编号");
            /// <summary>
			/// 类型名称
			/// </summary>
			public readonly static Field TEXT = new Field("TEXT", "PT_ATYPE", "类型名称");
            /// <summary>
			/// 类型编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_ATYPE", "类型编码");
            /// <summary>
			/// 排序编号
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "PT_ATYPE", "排序编号");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "PT_ATYPE", "备注");
            /// <summary>
			/// 文章显示类型
			/// </summary>
			public readonly static Field SHOWTYPE = new Field("SHOWTYPE", "PT_ATYPE", "文章显示类型");
        }
        #endregion
	}
}