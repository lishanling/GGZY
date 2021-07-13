using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_PARAMETER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_PARAMETER")]
    [Serializable]
    public partial class PRODUCT_PARAMETER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PARAMETER_NAME;
		private string _FILL_WAY;
		private string _UNIT;
		private string _IS_SELECTION;
		private string _IS_REQ;
		private string _VALUE_TYPE;
		private string _PARAMETER_VALUE_LIST;
		private string _IS_FIX_SELLECTION;

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
		/// 参数名称
		/// </summary>
		public string PARAMETER_NAME
		{
			get{ return _PARAMETER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PARAMETER_NAME, _PARAMETER_NAME, value);
				this._PARAMETER_NAME = value;
			}
		}
		/// <summary>
		/// 填写方式
		/// </summary>
		public string FILL_WAY
		{
			get{ return _FILL_WAY; }
			set
			{
				this.OnPropertyValueChange(_.FILL_WAY, _FILL_WAY, value);
				this._FILL_WAY = value;
			}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string UNIT
		{
			get{ return _UNIT; }
			set
			{
				this.OnPropertyValueChange(_.UNIT, _UNIT, value);
				this._UNIT = value;
			}
		}
		/// <summary>
		/// 是否筛选
		/// </summary>
		public string IS_SELECTION
		{
			get{ return _IS_SELECTION; }
			set
			{
				this.OnPropertyValueChange(_.IS_SELECTION, _IS_SELECTION, value);
				this._IS_SELECTION = value;
			}
		}
		/// <summary>
		/// 是否必填
		/// </summary>
		public string IS_REQ
		{
			get{ return _IS_REQ; }
			set
			{
				this.OnPropertyValueChange(_.IS_REQ, _IS_REQ, value);
				this._IS_REQ = value;
			}
		}
		/// <summary>
		/// 值类型
		/// </summary>
		public string VALUE_TYPE
		{
			get{ return _VALUE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.VALUE_TYPE, _VALUE_TYPE, value);
				this._VALUE_TYPE = value;
			}
		}
		/// <summary>
		/// 参数值列表
		/// </summary>
		public string PARAMETER_VALUE_LIST
		{
			get{ return _PARAMETER_VALUE_LIST; }
			set
			{
				this.OnPropertyValueChange(_.PARAMETER_VALUE_LIST, _PARAMETER_VALUE_LIST, value);
				this._PARAMETER_VALUE_LIST = value;
			}
		}
		/// <summary>
		/// 是否固定筛选项
		/// </summary>
		public string IS_FIX_SELLECTION
		{
			get{ return _IS_FIX_SELLECTION; }
			set
			{
				this.OnPropertyValueChange(_.IS_FIX_SELLECTION, _IS_FIX_SELLECTION, value);
				this._IS_FIX_SELLECTION = value;
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
				_.PARAMETER_NAME,
				_.FILL_WAY,
				_.UNIT,
				_.IS_SELECTION,
				_.IS_REQ,
				_.VALUE_TYPE,
				_.PARAMETER_VALUE_LIST,
				_.IS_FIX_SELLECTION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PARAMETER_NAME,
				this._FILL_WAY,
				this._UNIT,
				this._IS_SELECTION,
				this._IS_REQ,
				this._VALUE_TYPE,
				this._PARAMETER_VALUE_LIST,
				this._IS_FIX_SELLECTION,
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
			public readonly static Field All = new Field("*", "PRODUCT_PARAMETER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_PARAMETER", "ID");
            /// <summary>
			/// 参数名称
			/// </summary>
			public readonly static Field PARAMETER_NAME = new Field("PARAMETER_NAME", "PRODUCT_PARAMETER", "参数名称");
            /// <summary>
			/// 填写方式
			/// </summary>
			public readonly static Field FILL_WAY = new Field("FILL_WAY", "PRODUCT_PARAMETER", "填写方式");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "PRODUCT_PARAMETER", "单位");
            /// <summary>
			/// 是否筛选
			/// </summary>
			public readonly static Field IS_SELECTION = new Field("IS_SELECTION", "PRODUCT_PARAMETER", "是否筛选");
            /// <summary>
			/// 是否必填
			/// </summary>
			public readonly static Field IS_REQ = new Field("IS_REQ", "PRODUCT_PARAMETER", "是否必填");
            /// <summary>
			/// 值类型
			/// </summary>
			public readonly static Field VALUE_TYPE = new Field("VALUE_TYPE", "PRODUCT_PARAMETER", "值类型");
            /// <summary>
			/// 参数值列表
			/// </summary>
			public readonly static Field PARAMETER_VALUE_LIST = new Field("PARAMETER_VALUE_LIST", "PRODUCT_PARAMETER", "参数值列表");
            /// <summary>
			/// 是否固定筛选项
			/// </summary>
			public readonly static Field IS_FIX_SELLECTION = new Field("IS_FIX_SELLECTION", "PRODUCT_PARAMETER", "是否固定筛选项");
        }
        #endregion
	}
}