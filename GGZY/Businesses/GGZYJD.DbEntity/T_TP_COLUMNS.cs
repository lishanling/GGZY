using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TP_COLUMNS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TP_COLUMNS")]
    [Serializable]
    public partial class T_TP_COLUMNS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _COLUMN_CODE;
		private string _COLUMN_NAME;
		private string _FIELD_TYPE;
		private decimal? _ORDER_ID;
		private DateTime? _CREATE_TM;

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
		/// 归属编码
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
		/// 字段名
		/// </summary>
		public string COLUMN_CODE
		{
			get{ return _COLUMN_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COLUMN_CODE, _COLUMN_CODE, value);
				this._COLUMN_CODE = value;
			}
		}
		/// <summary>
		/// 字段名称
		/// </summary>
		public string COLUMN_NAME
		{
			get{ return _COLUMN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COLUMN_NAME, _COLUMN_NAME, value);
				this._COLUMN_NAME = value;
			}
		}
		/// <summary>
		/// 字段类型
		/// </summary>
		public string FIELD_TYPE
		{
			get{ return _FIELD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_TYPE, _FIELD_TYPE, value);
				this._FIELD_TYPE = value;
			}
		}
		/// <summary>
		/// 排序id
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
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
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
				_.CODE,
				_.COLUMN_CODE,
				_.COLUMN_NAME,
				_.FIELD_TYPE,
				_.ORDER_ID,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._COLUMN_CODE,
				this._COLUMN_NAME,
				this._FIELD_TYPE,
				this._ORDER_ID,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_TP_COLUMNS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TP_COLUMNS", "ID");
            /// <summary>
			/// 归属编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_TP_COLUMNS", "归属编码");
            /// <summary>
			/// 字段名
			/// </summary>
			public readonly static Field COLUMN_CODE = new Field("COLUMN_CODE", "T_TP_COLUMNS", "字段名");
            /// <summary>
			/// 字段名称
			/// </summary>
			public readonly static Field COLUMN_NAME = new Field("COLUMN_NAME", "T_TP_COLUMNS", "字段名称");
            /// <summary>
			/// 字段类型
			/// </summary>
			public readonly static Field FIELD_TYPE = new Field("FIELD_TYPE", "T_TP_COLUMNS", "字段类型");
            /// <summary>
			/// 排序id
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_TP_COLUMNS", "排序id");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_TP_COLUMNS", "创建时间");
        }
        #endregion
	}
}