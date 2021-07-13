using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_EQP。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_EQP")]
    [Serializable]
    public partial class PRODUCT_EQP : FwEntity
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
		private string _SI_GUIDE;
		private string _SI_QUOTES;
		private DateTime? _QUOTES_DATE;
		private string _SYS_NAME;
		private string _SI;
		private string _BRAND;
		private string _ORIGIN;
		private string _PRODUCT_SP_ATTR;
		private string _TECH_FEATURES;
		private string _TECH_PERF_INDI;
		private string _SYS_OVERVIEW;
		private string _SUPPLY_CYC;
		private string _USING;
		private string _DEBUG;
		private string _DES_CONTACT;
		private string _INSTALL_SPVS;
		private string _TRAIN;
		private string _PRJ_MGT;
		private string _WARRANTY_SRV;
		private DateTime? _MODIFY_TIME;
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
		/// 系统集成商指导价
		/// </summary>
		public string SI_GUIDE
		{
			get{ return _SI_GUIDE; }
			set
			{
				this.OnPropertyValueChange(_.SI_GUIDE, _SI_GUIDE, value);
				this._SI_GUIDE = value;
			}
		}
		/// <summary>
		/// 系统集成商报价说明
		/// </summary>
		public string SI_QUOTES
		{
			get{ return _SI_QUOTES; }
			set
			{
				this.OnPropertyValueChange(_.SI_QUOTES, _SI_QUOTES, value);
				this._SI_QUOTES = value;
			}
		}
		/// <summary>
		/// 报价日期
		/// </summary>
		public DateTime? QUOTES_DATE
		{
			get{ return _QUOTES_DATE; }
			set
			{
				this.OnPropertyValueChange(_.QUOTES_DATE, _QUOTES_DATE, value);
				this._QUOTES_DATE = value;
			}
		}
		/// <summary>
		/// 系统名称
		/// </summary>
		public string SYS_NAME
		{
			get{ return _SYS_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SYS_NAME, _SYS_NAME, value);
				this._SYS_NAME = value;
			}
		}
		/// <summary>
		/// 系统集成商
		/// </summary>
		public string SI
		{
			get{ return _SI; }
			set
			{
				this.OnPropertyValueChange(_.SI, _SI, value);
				this._SI = value;
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
		/// 系统特有功能属性
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
		/// 系统概述
		/// </summary>
		public string SYS_OVERVIEW
		{
			get{ return _SYS_OVERVIEW; }
			set
			{
				this.OnPropertyValueChange(_.SYS_OVERVIEW, _SYS_OVERVIEW, value);
				this._SYS_OVERVIEW = value;
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
		/// 调试
		/// </summary>
		public string DEBUG
		{
			get{ return _DEBUG; }
			set
			{
				this.OnPropertyValueChange(_.DEBUG, _DEBUG, value);
				this._DEBUG = value;
			}
		}
		/// <summary>
		/// 设计联络
		/// </summary>
		public string DES_CONTACT
		{
			get{ return _DES_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.DES_CONTACT, _DES_CONTACT, value);
				this._DES_CONTACT = value;
			}
		}
		/// <summary>
		/// 安装督导
		/// </summary>
		public string INSTALL_SPVS
		{
			get{ return _INSTALL_SPVS; }
			set
			{
				this.OnPropertyValueChange(_.INSTALL_SPVS, _INSTALL_SPVS, value);
				this._INSTALL_SPVS = value;
			}
		}
		/// <summary>
		/// 培训
		/// </summary>
		public string TRAIN
		{
			get{ return _TRAIN; }
			set
			{
				this.OnPropertyValueChange(_.TRAIN, _TRAIN, value);
				this._TRAIN = value;
			}
		}
		/// <summary>
		/// 项目管理
		/// </summary>
		public string PRJ_MGT
		{
			get{ return _PRJ_MGT; }
			set
			{
				this.OnPropertyValueChange(_.PRJ_MGT, _PRJ_MGT, value);
				this._PRJ_MGT = value;
			}
		}
		/// <summary>
		/// 质保期服务
		/// </summary>
		public string WARRANTY_SRV
		{
			get{ return _WARRANTY_SRV; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_SRV, _WARRANTY_SRV, value);
				this._WARRANTY_SRV = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? MODIFY_TIME
		{
			get{ return _MODIFY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_TIME, _MODIFY_TIME, value);
				this._MODIFY_TIME = value;
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
				_.SI_GUIDE,
				_.SI_QUOTES,
				_.QUOTES_DATE,
				_.SYS_NAME,
				_.SI,
				_.BRAND,
				_.ORIGIN,
				_.PRODUCT_SP_ATTR,
				_.TECH_FEATURES,
				_.TECH_PERF_INDI,
				_.SYS_OVERVIEW,
				_.SUPPLY_CYC,
				_.USING,
				_.DEBUG,
				_.DES_CONTACT,
				_.INSTALL_SPVS,
				_.TRAIN,
				_.PRJ_MGT,
				_.WARRANTY_SRV,
				_.MODIFY_TIME,
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
				this._SI_GUIDE,
				this._SI_QUOTES,
				this._QUOTES_DATE,
				this._SYS_NAME,
				this._SI,
				this._BRAND,
				this._ORIGIN,
				this._PRODUCT_SP_ATTR,
				this._TECH_FEATURES,
				this._TECH_PERF_INDI,
				this._SYS_OVERVIEW,
				this._SUPPLY_CYC,
				this._USING,
				this._DEBUG,
				this._DES_CONTACT,
				this._INSTALL_SPVS,
				this._TRAIN,
				this._PRJ_MGT,
				this._WARRANTY_SRV,
				this._MODIFY_TIME,
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
			public readonly static Field All = new Field("*", "PRODUCT_EQP");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_EQP", "ID");
            /// <summary>
			/// 产品类别
			/// </summary>
			public readonly static Field PRODUCT_TYPE = new Field("PRODUCT_TYPE", "PRODUCT_EQP", "产品类别");
            /// <summary>
			/// 分类编码
			/// </summary>
			public readonly static Field CLASSIFY_CODE = new Field("CLASSIFY_CODE", "PRODUCT_EQP", "分类编码");
            /// <summary>
			/// 产品编码
			/// </summary>
			public readonly static Field PRODUCT_CODE = new Field("PRODUCT_CODE", "PRODUCT_EQP", "产品编码");
            /// <summary>
			/// 是否系统产品
			/// </summary>
			public readonly static Field IS_SYS_PRODUCT = new Field("IS_SYS_PRODUCT", "PRODUCT_EQP", "是否系统产品");
            /// <summary>
			/// 产品名称
			/// </summary>
			public readonly static Field PRODUCT_NAME = new Field("PRODUCT_NAME", "PRODUCT_EQP", "产品名称");
            /// <summary>
			/// 产品等级
			/// </summary>
			public readonly static Field PRODUCT_LEVEL = new Field("PRODUCT_LEVEL", "PRODUCT_EQP", "产品等级");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "PRODUCT_EQP", "单位");
            /// <summary>
			/// 系统集成商指导价
			/// </summary>
			public readonly static Field SI_GUIDE = new Field("SI_GUIDE", "PRODUCT_EQP", "系统集成商指导价");
            /// <summary>
			/// 系统集成商报价说明
			/// </summary>
			public readonly static Field SI_QUOTES = new Field("SI_QUOTES", "PRODUCT_EQP", "系统集成商报价说明");
            /// <summary>
			/// 报价日期
			/// </summary>
			public readonly static Field QUOTES_DATE = new Field("QUOTES_DATE", "PRODUCT_EQP", "报价日期");
            /// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field SYS_NAME = new Field("SYS_NAME", "PRODUCT_EQP", "系统名称");
            /// <summary>
			/// 系统集成商
			/// </summary>
			public readonly static Field SI = new Field("SI", "PRODUCT_EQP", "系统集成商");
            /// <summary>
			/// 品牌
			/// </summary>
			public readonly static Field BRAND = new Field("BRAND", "PRODUCT_EQP", "品牌");
            /// <summary>
			/// 产地
			/// </summary>
			public readonly static Field ORIGIN = new Field("ORIGIN", "PRODUCT_EQP", "产地");
            /// <summary>
			/// 系统特有功能属性
			/// </summary>
			public readonly static Field PRODUCT_SP_ATTR = new Field("PRODUCT_SP_ATTR", "PRODUCT_EQP", "系统特有功能属性");
            /// <summary>
			/// 技术特点
			/// </summary>
			public readonly static Field TECH_FEATURES = new Field("TECH_FEATURES", "PRODUCT_EQP", "技术特点");
            /// <summary>
			/// 技术性能指标
			/// </summary>
			public readonly static Field TECH_PERF_INDI = new Field("TECH_PERF_INDI", "PRODUCT_EQP", "技术性能指标");
            /// <summary>
			/// 系统概述
			/// </summary>
			public readonly static Field SYS_OVERVIEW = new Field("SYS_OVERVIEW", "PRODUCT_EQP", "系统概述");
            /// <summary>
			/// 供货周期
			/// </summary>
			public readonly static Field SUPPLY_CYC = new Field("SUPPLY_CYC", "PRODUCT_EQP", "供货周期");
            /// <summary>
			/// 用途
			/// </summary>
			public readonly static Field USING = new Field("USING", "PRODUCT_EQP", "用途");
            /// <summary>
			/// 调试
			/// </summary>
			public readonly static Field DEBUG = new Field("DEBUG", "PRODUCT_EQP", "调试");
            /// <summary>
			/// 设计联络
			/// </summary>
			public readonly static Field DES_CONTACT = new Field("DES_CONTACT", "PRODUCT_EQP", "设计联络");
            /// <summary>
			/// 安装督导
			/// </summary>
			public readonly static Field INSTALL_SPVS = new Field("INSTALL_SPVS", "PRODUCT_EQP", "安装督导");
            /// <summary>
			/// 培训
			/// </summary>
			public readonly static Field TRAIN = new Field("TRAIN", "PRODUCT_EQP", "培训");
            /// <summary>
			/// 项目管理
			/// </summary>
			public readonly static Field PRJ_MGT = new Field("PRJ_MGT", "PRODUCT_EQP", "项目管理");
            /// <summary>
			/// 质保期服务
			/// </summary>
			public readonly static Field WARRANTY_SRV = new Field("WARRANTY_SRV", "PRODUCT_EQP", "质保期服务");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field MODIFY_TIME = new Field("MODIFY_TIME", "PRODUCT_EQP", "修改时间");
            /// <summary>
			/// 产品图片
			/// </summary>
			public readonly static Field PRODUCT_IMG = new Field("PRODUCT_IMG", "PRODUCT_EQP", "产品图片");
        }
        #endregion
	}
}