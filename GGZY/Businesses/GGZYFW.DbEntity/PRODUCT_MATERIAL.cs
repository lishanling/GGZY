using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_MATERIAL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_MATERIAL")]
    [Serializable]
    public partial class PRODUCT_MATERIAL : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRODUCT_TYPE;
		private string _CLASSIFY_CODE;
		private string _PRODUCT_CODE;
		private string _IS_SYS_PRODUCT;
		private string _PRODUCT_NAME;
		private string _PRODUCT_LEVEL;
		private string _UNIT;
		private string _MFR_PRICE;
		private string _MFR_OFFER_EXPLAIN;
		private DateTime? _OFFER_DATE;
		private string _BRAND;
		private string _ORIGIN;
		private string _PRODUCT_SP_ATTR;
		private string _TECH_FEATURES;
		private string _TECH_PERF_INDI;
		private string _PRODUCT_DESC;
		private string _SUPPLY_CYC;
		private string _PRODUCT_PERF;
		private string _USING;
		private string _PACKAGING;
		private string _DES_AND_INSTALL;
		private string _AFTER_SALES_SRV;
		private string _CAPACITY;
		private string _CAPACITY_UNIT;
		private string _INV_NUM;
		private string _INV_UNIT;
		private string _PRODUCT_IMG;

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
		/// 产品类别
		/// </summary>
		public string PRODUCT_TYPE
		{
			get{ return _PRODUCT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_TYPE, _PRODUCT_TYPE, value);
				this._PRODUCT_TYPE = value;
			}
		}
		/// <summary>
		/// 分类编码
		/// </summary>
		public string CLASSIFY_CODE
		{
			get{ return _CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CLASSIFY_CODE, _CLASSIFY_CODE, value);
				this._CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 产品编码
		/// </summary>
		public string PRODUCT_CODE
		{
			get{ return _PRODUCT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_CODE, _PRODUCT_CODE, value);
				this._PRODUCT_CODE = value;
			}
		}
		/// <summary>
		/// 是否系统产品
		/// </summary>
		public string IS_SYS_PRODUCT
		{
			get{ return _IS_SYS_PRODUCT; }
			set
			{
				this.OnPropertyValueChange(_.IS_SYS_PRODUCT, _IS_SYS_PRODUCT, value);
				this._IS_SYS_PRODUCT = value;
			}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string PRODUCT_NAME
		{
			get{ return _PRODUCT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_NAME, _PRODUCT_NAME, value);
				this._PRODUCT_NAME = value;
			}
		}
		/// <summary>
		/// 产品等级
		/// </summary>
		public string PRODUCT_LEVEL
		{
			get{ return _PRODUCT_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_LEVEL, _PRODUCT_LEVEL, value);
				this._PRODUCT_LEVEL = value;
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
		/// 厂商指导价
		/// </summary>
		public string MFR_PRICE
		{
			get{ return _MFR_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.MFR_PRICE, _MFR_PRICE, value);
				this._MFR_PRICE = value;
			}
		}
		/// <summary>
		/// 厂商报价说明
		/// </summary>
		public string MFR_OFFER_EXPLAIN
		{
			get{ return _MFR_OFFER_EXPLAIN; }
			set
			{
				this.OnPropertyValueChange(_.MFR_OFFER_EXPLAIN, _MFR_OFFER_EXPLAIN, value);
				this._MFR_OFFER_EXPLAIN = value;
			}
		}
		/// <summary>
		/// 报价日期
		/// </summary>
		public DateTime? OFFER_DATE
		{
			get{ return _OFFER_DATE; }
			set
			{
				this.OnPropertyValueChange(_.OFFER_DATE, _OFFER_DATE, value);
				this._OFFER_DATE = value;
			}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public string BRAND
		{
			get{ return _BRAND; }
			set
			{
				this.OnPropertyValueChange(_.BRAND, _BRAND, value);
				this._BRAND = value;
			}
		}
		/// <summary>
		/// 产地
		/// </summary>
		public string ORIGIN
		{
			get{ return _ORIGIN; }
			set
			{
				this.OnPropertyValueChange(_.ORIGIN, _ORIGIN, value);
				this._ORIGIN = value;
			}
		}
		/// <summary>
		/// 产品特有功能属性
		/// </summary>
		public string PRODUCT_SP_ATTR
		{
			get{ return _PRODUCT_SP_ATTR; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_SP_ATTR, _PRODUCT_SP_ATTR, value);
				this._PRODUCT_SP_ATTR = value;
			}
		}
		/// <summary>
		/// 技术特点
		/// </summary>
		public string TECH_FEATURES
		{
			get{ return _TECH_FEATURES; }
			set
			{
				this.OnPropertyValueChange(_.TECH_FEATURES, _TECH_FEATURES, value);
				this._TECH_FEATURES = value;
			}
		}
		/// <summary>
		/// 技术性能指标
		/// </summary>
		public string TECH_PERF_INDI
		{
			get{ return _TECH_PERF_INDI; }
			set
			{
				this.OnPropertyValueChange(_.TECH_PERF_INDI, _TECH_PERF_INDI, value);
				this._TECH_PERF_INDI = value;
			}
		}
		/// <summary>
		/// 产品描述
		/// </summary>
		public string PRODUCT_DESC
		{
			get{ return _PRODUCT_DESC; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_DESC, _PRODUCT_DESC, value);
				this._PRODUCT_DESC = value;
			}
		}
		/// <summary>
		/// 供货周期
		/// </summary>
		public string SUPPLY_CYC
		{
			get{ return _SUPPLY_CYC; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_CYC, _SUPPLY_CYC, value);
				this._SUPPLY_CYC = value;
			}
		}
		/// <summary>
		/// 产品性能
		/// </summary>
		public string PRODUCT_PERF
		{
			get{ return _PRODUCT_PERF; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_PERF, _PRODUCT_PERF, value);
				this._PRODUCT_PERF = value;
			}
		}
		/// <summary>
		/// 用途
		/// </summary>
		public string USING
		{
			get{ return _USING; }
			set
			{
				this.OnPropertyValueChange(_.USING, _USING, value);
				this._USING = value;
			}
		}
		/// <summary>
		/// 包装
		/// </summary>
		public string PACKAGING
		{
			get{ return _PACKAGING; }
			set
			{
				this.OnPropertyValueChange(_.PACKAGING, _PACKAGING, value);
				this._PACKAGING = value;
			}
		}
		/// <summary>
		/// 设计及安装
		/// </summary>
		public string DES_AND_INSTALL
		{
			get{ return _DES_AND_INSTALL; }
			set
			{
				this.OnPropertyValueChange(_.DES_AND_INSTALL, _DES_AND_INSTALL, value);
				this._DES_AND_INSTALL = value;
			}
		}
		/// <summary>
		/// 售后服务
		/// </summary>
		public string AFTER_SALES_SRV
		{
			get{ return _AFTER_SALES_SRV; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_SALES_SRV, _AFTER_SALES_SRV, value);
				this._AFTER_SALES_SRV = value;
			}
		}
		/// <summary>
		/// 产能
		/// </summary>
		public string CAPACITY
		{
			get{ return _CAPACITY; }
			set
			{
				this.OnPropertyValueChange(_.CAPACITY, _CAPACITY, value);
				this._CAPACITY = value;
			}
		}
		/// <summary>
		/// 产能单位
		/// </summary>
		public string CAPACITY_UNIT
		{
			get{ return _CAPACITY_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CAPACITY_UNIT, _CAPACITY_UNIT, value);
				this._CAPACITY_UNIT = value;
			}
		}
		/// <summary>
		/// 库存量
		/// </summary>
		public string INV_NUM
		{
			get{ return _INV_NUM; }
			set
			{
				this.OnPropertyValueChange(_.INV_NUM, _INV_NUM, value);
				this._INV_NUM = value;
			}
		}
		/// <summary>
		/// 库存单位
		/// </summary>
		public string INV_UNIT
		{
			get{ return _INV_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.INV_UNIT, _INV_UNIT, value);
				this._INV_UNIT = value;
			}
		}
		/// <summary>
		/// 产品图片
		/// </summary>
		public string PRODUCT_IMG
		{
			get{ return _PRODUCT_IMG; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_IMG, _PRODUCT_IMG, value);
				this._PRODUCT_IMG = value;
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
				_.PRODUCT_TYPE,
				_.CLASSIFY_CODE,
				_.PRODUCT_CODE,
				_.IS_SYS_PRODUCT,
				_.PRODUCT_NAME,
				_.PRODUCT_LEVEL,
				_.UNIT,
				_.MFR_PRICE,
				_.MFR_OFFER_EXPLAIN,
				_.OFFER_DATE,
				_.BRAND,
				_.ORIGIN,
				_.PRODUCT_SP_ATTR,
				_.TECH_FEATURES,
				_.TECH_PERF_INDI,
				_.PRODUCT_DESC,
				_.SUPPLY_CYC,
				_.PRODUCT_PERF,
				_.USING,
				_.PACKAGING,
				_.DES_AND_INSTALL,
				_.AFTER_SALES_SRV,
				_.CAPACITY,
				_.CAPACITY_UNIT,
				_.INV_NUM,
				_.INV_UNIT,
				_.PRODUCT_IMG,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PRODUCT_TYPE,
				this._CLASSIFY_CODE,
				this._PRODUCT_CODE,
				this._IS_SYS_PRODUCT,
				this._PRODUCT_NAME,
				this._PRODUCT_LEVEL,
				this._UNIT,
				this._MFR_PRICE,
				this._MFR_OFFER_EXPLAIN,
				this._OFFER_DATE,
				this._BRAND,
				this._ORIGIN,
				this._PRODUCT_SP_ATTR,
				this._TECH_FEATURES,
				this._TECH_PERF_INDI,
				this._PRODUCT_DESC,
				this._SUPPLY_CYC,
				this._PRODUCT_PERF,
				this._USING,
				this._PACKAGING,
				this._DES_AND_INSTALL,
				this._AFTER_SALES_SRV,
				this._CAPACITY,
				this._CAPACITY_UNIT,
				this._INV_NUM,
				this._INV_UNIT,
				this._PRODUCT_IMG,
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
			public readonly static Field All = new Field("*", "PRODUCT_MATERIAL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_MATERIAL", "ID");
            /// <summary>
			/// 产品类别
			/// </summary>
			public readonly static Field PRODUCT_TYPE = new Field("PRODUCT_TYPE", "PRODUCT_MATERIAL", "产品类别");
            /// <summary>
			/// 分类编码
			/// </summary>
			public readonly static Field CLASSIFY_CODE = new Field("CLASSIFY_CODE", "PRODUCT_MATERIAL", "分类编码");
            /// <summary>
			/// 产品编码
			/// </summary>
			public readonly static Field PRODUCT_CODE = new Field("PRODUCT_CODE", "PRODUCT_MATERIAL", "产品编码");
            /// <summary>
			/// 是否系统产品
			/// </summary>
			public readonly static Field IS_SYS_PRODUCT = new Field("IS_SYS_PRODUCT", "PRODUCT_MATERIAL", "是否系统产品");
            /// <summary>
			/// 产品名称
			/// </summary>
			public readonly static Field PRODUCT_NAME = new Field("PRODUCT_NAME", "PRODUCT_MATERIAL", "产品名称");
            /// <summary>
			/// 产品等级
			/// </summary>
			public readonly static Field PRODUCT_LEVEL = new Field("PRODUCT_LEVEL", "PRODUCT_MATERIAL", "产品等级");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "PRODUCT_MATERIAL", "单位");
            /// <summary>
			/// 厂商指导价
			/// </summary>
			public readonly static Field MFR_PRICE = new Field("MFR_PRICE", "PRODUCT_MATERIAL", "厂商指导价");
            /// <summary>
			/// 厂商报价说明
			/// </summary>
			public readonly static Field MFR_OFFER_EXPLAIN = new Field("MFR_OFFER_EXPLAIN", "PRODUCT_MATERIAL", "厂商报价说明");
            /// <summary>
			/// 报价日期
			/// </summary>
			public readonly static Field OFFER_DATE = new Field("OFFER_DATE", "PRODUCT_MATERIAL", "报价日期");
            /// <summary>
			/// 品牌
			/// </summary>
			public readonly static Field BRAND = new Field("BRAND", "PRODUCT_MATERIAL", "品牌");
            /// <summary>
			/// 产地
			/// </summary>
			public readonly static Field ORIGIN = new Field("ORIGIN", "PRODUCT_MATERIAL", "产地");
            /// <summary>
			/// 产品特有功能属性
			/// </summary>
			public readonly static Field PRODUCT_SP_ATTR = new Field("PRODUCT_SP_ATTR", "PRODUCT_MATERIAL", "产品特有功能属性");
            /// <summary>
			/// 技术特点
			/// </summary>
			public readonly static Field TECH_FEATURES = new Field("TECH_FEATURES", "PRODUCT_MATERIAL", "技术特点");
            /// <summary>
			/// 技术性能指标
			/// </summary>
			public readonly static Field TECH_PERF_INDI = new Field("TECH_PERF_INDI", "PRODUCT_MATERIAL", "技术性能指标");
            /// <summary>
			/// 产品描述
			/// </summary>
			public readonly static Field PRODUCT_DESC = new Field("PRODUCT_DESC", "PRODUCT_MATERIAL", "产品描述");
            /// <summary>
			/// 供货周期
			/// </summary>
			public readonly static Field SUPPLY_CYC = new Field("SUPPLY_CYC", "PRODUCT_MATERIAL", "供货周期");
            /// <summary>
			/// 产品性能
			/// </summary>
			public readonly static Field PRODUCT_PERF = new Field("PRODUCT_PERF", "PRODUCT_MATERIAL", "产品性能");
            /// <summary>
			/// 用途
			/// </summary>
			public readonly static Field USING = new Field("USING", "PRODUCT_MATERIAL", "用途");
            /// <summary>
			/// 包装
			/// </summary>
			public readonly static Field PACKAGING = new Field("PACKAGING", "PRODUCT_MATERIAL", "包装");
            /// <summary>
			/// 设计及安装
			/// </summary>
			public readonly static Field DES_AND_INSTALL = new Field("DES_AND_INSTALL", "PRODUCT_MATERIAL", "设计及安装");
            /// <summary>
			/// 售后服务
			/// </summary>
			public readonly static Field AFTER_SALES_SRV = new Field("AFTER_SALES_SRV", "PRODUCT_MATERIAL", "售后服务");
            /// <summary>
			/// 产能
			/// </summary>
			public readonly static Field CAPACITY = new Field("CAPACITY", "PRODUCT_MATERIAL", "产能");
            /// <summary>
			/// 产能单位
			/// </summary>
			public readonly static Field CAPACITY_UNIT = new Field("CAPACITY_UNIT", "PRODUCT_MATERIAL", "产能单位");
            /// <summary>
			/// 库存量
			/// </summary>
			public readonly static Field INV_NUM = new Field("INV_NUM", "PRODUCT_MATERIAL", "库存量");
            /// <summary>
			/// 库存单位
			/// </summary>
			public readonly static Field INV_UNIT = new Field("INV_UNIT", "PRODUCT_MATERIAL", "库存单位");
            /// <summary>
			/// 产品图片
			/// </summary>
			public readonly static Field PRODUCT_IMG = new Field("PRODUCT_IMG", "PRODUCT_MATERIAL", "产品图片");
        }
        #endregion
	}
}