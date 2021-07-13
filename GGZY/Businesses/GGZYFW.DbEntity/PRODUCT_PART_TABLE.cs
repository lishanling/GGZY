using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_PART_TABLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_PART_TABLE")]
    [Serializable]
    public partial class PRODUCT_PART_TABLE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSTEM_NAME;
		private string _EQUIPMENT_NAME;
		private string _PART_NAME;
		private string _MODAL_SIZE;
		private string _REMARK;

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
		public string PART_NAME
		{
			get{ return _PART_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PART_NAME, _PART_NAME, value);
				this._PART_NAME = value;
			}
		}
		/// <summary>
		/// 型号规格/功能需求
		/// </summary>
		public string MODAL_SIZE
		{
			get{ return _MODAL_SIZE; }
			set
			{
				this.OnPropertyValueChange(_.MODAL_SIZE, _MODAL_SIZE, value);
				this._MODAL_SIZE = value;
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
				_.PART_NAME,
				_.MODAL_SIZE,
				_.REMARK,
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
				this._PART_NAME,
				this._MODAL_SIZE,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "PRODUCT_PART_TABLE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_PART_TABLE", "ID");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYSTEM_NAME = new Field("SYSTEM_NAME", "PRODUCT_PART_TABLE", "系统名称");
            /// <summary>
			/// 设备名称
			/// </summary>
			public readonly static Field EQUIPMENT_NAME = new Field("EQUIPMENT_NAME", "PRODUCT_PART_TABLE", "设备名称");
            /// <summary>
			/// 部件名称
			/// </summary>
			public readonly static Field PART_NAME = new Field("PART_NAME", "PRODUCT_PART_TABLE", "部件名称");
            /// <summary>
			/// 型号规格/功能需求
			/// </summary>
			public readonly static Field MODAL_SIZE = new Field("MODAL_SIZE", "PRODUCT_PART_TABLE", "型号规格/功能需求");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "PRODUCT_PART_TABLE", "备注");
        }
        #endregion
	}
}