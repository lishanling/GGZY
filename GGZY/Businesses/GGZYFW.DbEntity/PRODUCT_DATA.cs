using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_DATA")]
    [Serializable]
    public partial class PRODUCT_DATA : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSTEM_NAME;
		private string _EQUIPMENT_NAME;
		private string _COMPONENT_NAME;
		private string _MODEL_FUNCTION;
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
		/// 设备名称
		/// </summary>
		public string EQUIPMENT_NAME
		{
			get{ return _EQUIPMENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_NAME, _EQUIPMENT_NAME, value);
				this._EQUIPMENT_NAME = value;
			}
		}
		/// <summary>
		/// 部件名称
		/// </summary>
		public string COMPONENT_NAME
		{
			get{ return _COMPONENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPONENT_NAME, _COMPONENT_NAME, value);
				this._COMPONENT_NAME = value;
			}
		}
		/// <summary>
		/// 型号规格/功能需求
		/// </summary>
		public string MODEL_FUNCTION
		{
			get{ return _MODEL_FUNCTION; }
			set
			{
				this.OnPropertyValueChange(_.MODEL_FUNCTION, _MODEL_FUNCTION, value);
				this._MODEL_FUNCTION = value;
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
				_.SYSTEM_NAME,
				_.EQUIPMENT_NAME,
				_.COMPONENT_NAME,
				_.MODEL_FUNCTION,
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
				this._SYSTEM_NAME,
				this._EQUIPMENT_NAME,
				this._COMPONENT_NAME,
				this._MODEL_FUNCTION,
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
			public readonly static Field All = new Field("*", "PRODUCT_DATA");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_DATA", "ID");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYSTEM_NAME = new Field("SYSTEM_NAME", "PRODUCT_DATA", "系统名称");
            /// <summary>
			/// 设备名称
			/// </summary>
			public readonly static Field EQUIPMENT_NAME = new Field("EQUIPMENT_NAME", "PRODUCT_DATA", "设备名称");
            /// <summary>
			/// 部件名称
			/// </summary>
			public readonly static Field COMPONENT_NAME = new Field("COMPONENT_NAME", "PRODUCT_DATA", "部件名称");
            /// <summary>
			/// 型号规格/功能需求
			/// </summary>
			public readonly static Field MODEL_FUNCTION = new Field("MODEL/FUNCTION", "PRODUCT_DATA", "型号规格/功能需求");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "PRODUCT_DATA", "备注");
        }
        #endregion
	}
}