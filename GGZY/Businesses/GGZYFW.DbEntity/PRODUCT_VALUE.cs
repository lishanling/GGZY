using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_VALUE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_VALUE")]
    [Serializable]
    public partial class PRODUCT_VALUE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSTEM_NAME;
		private string _EQUIPMENT_NAME;
		private string _SPECIFICATION_MODEL;
		private string _FUNCTION_REQUIRE;
		private string _MANUFACTURER;
		private string _AREA;
		private string _COUNT;
		private string _UNIT_PRICE;
		private string _EQUIPMENT_PRICE;

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
		/// 规格型号
		/// </summary>
		public string SPECIFICATION_MODEL
		{
			get{ return _SPECIFICATION_MODEL; }
			set
			{
				this.OnPropertyValueChange(_.SPECIFICATION_MODEL, _SPECIFICATION_MODEL, value);
				this._SPECIFICATION_MODEL = value;
			}
		}
		/// <summary>
		/// 功能需求
		/// </summary>
		public string FUNCTION_REQUIRE
		{
			get{ return _FUNCTION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.FUNCTION_REQUIRE, _FUNCTION_REQUIRE, value);
				this._FUNCTION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 生产厂家
		/// </summary>
		public string MANUFACTURER
		{
			get{ return _MANUFACTURER; }
			set
			{
				this.OnPropertyValueChange(_.MANUFACTURER, _MANUFACTURER, value);
				this._MANUFACTURER = value;
			}
		}
		/// <summary>
		/// 产地
		/// </summary>
		public string AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string COUNT
		{
			get{ return _COUNT; }
			set
			{
				this.OnPropertyValueChange(_.COUNT, _COUNT, value);
				this._COUNT = value;
			}
		}
		/// <summary>
		/// 单价(/综合单价)
		/// </summary>
		public string UNIT_PRICE
		{
			get{ return _UNIT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_PRICE, _UNIT_PRICE, value);
				this._UNIT_PRICE = value;
			}
		}
		/// <summary>
		/// 设备报价
		/// </summary>
		public string EQUIPMENT_PRICE
		{
			get{ return _EQUIPMENT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_PRICE, _EQUIPMENT_PRICE, value);
				this._EQUIPMENT_PRICE = value;
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
				_.SPECIFICATION_MODEL,
				_.FUNCTION_REQUIRE,
				_.MANUFACTURER,
				_.AREA,
				_.COUNT,
				_.UNIT_PRICE,
				_.EQUIPMENT_PRICE,
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
				this._SPECIFICATION_MODEL,
				this._FUNCTION_REQUIRE,
				this._MANUFACTURER,
				this._AREA,
				this._COUNT,
				this._UNIT_PRICE,
				this._EQUIPMENT_PRICE,
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
			public readonly static Field All = new Field("*", "PRODUCT_VALUE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_VALUE", "ID");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYSTEM_NAME = new Field("SYSTEM_NAME", "PRODUCT_VALUE", "系统名称");
            /// <summary>
			/// 设备名称
			/// </summary>
			public readonly static Field EQUIPMENT_NAME = new Field("EQUIPMENT_NAME", "PRODUCT_VALUE", "设备名称");
            /// <summary>
			/// 规格型号
			/// </summary>
			public readonly static Field SPECIFICATION_MODEL = new Field("SPECIFICATION_MODEL", "PRODUCT_VALUE", "规格型号");
            /// <summary>
			/// 功能需求
			/// </summary>
			public readonly static Field FUNCTION_REQUIRE = new Field("FUNCTION_REQUIRE", "PRODUCT_VALUE", "功能需求");
            /// <summary>
			/// 生产厂家
			/// </summary>
			public readonly static Field MANUFACTURER = new Field("MANUFACTURER", "PRODUCT_VALUE", "生产厂家");
            /// <summary>
			/// 产地
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "PRODUCT_VALUE", "产地");
            /// <summary>
			/// 数量
			/// </summary>
			public readonly static Field COUNT = new Field("COUNT", "PRODUCT_VALUE", "数量");
            /// <summary>
			/// 单价(/综合单价)
			/// </summary>
			public readonly static Field UNIT_PRICE = new Field("UNIT_PRICE", "PRODUCT_VALUE", "单价(/综合单价)");
            /// <summary>
			/// 设备报价
			/// </summary>
			public readonly static Field EQUIPMENT_PRICE = new Field("EQUIPMENT_PRICE", "PRODUCT_VALUE", "设备报价");
        }
        #endregion
	}
}