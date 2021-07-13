using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRODUCT_CLASSIFY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRODUCT_CLASSIFY")]
    [Serializable]
    public partial class PRODUCT_CLASSIFY : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRODUCT_FL_CODE;
		private string _PRODUCT_FL_NAME;
		private string _MATERIAL_TYPE;
		private string _PRODUCT_TYPE;
		private string _FL_JMPN;
		private string _FL_UNIT;
		private string _AUDIT_DATA;
		private string _AUDIT_HINT;
		private string _STOCKING_STANDARD;
		private string _PRODUCT_PRICE_EXPLAIN;
		private string _CO_REQID_QSMSG;

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
		/// 产品分类编码
		/// </summary>
		public string PRODUCT_FL_CODE
		{
			get{ return _PRODUCT_FL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_FL_CODE, _PRODUCT_FL_CODE, value);
				this._PRODUCT_FL_CODE = value;
			}
		}
		/// <summary>
		/// 产品分类名称
		/// </summary>
		public string PRODUCT_FL_NAME
		{
			get{ return _PRODUCT_FL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_FL_NAME, _PRODUCT_FL_NAME, value);
				this._PRODUCT_FL_NAME = value;
			}
		}
		/// <summary>
		/// 材料类别
		/// </summary>
		public string MATERIAL_TYPE
		{
			get{ return _MATERIAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL_TYPE, _MATERIAL_TYPE, value);
				this._MATERIAL_TYPE = value;
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
		/// 分类简拼
		/// </summary>
		public string FL_JMPN
		{
			get{ return _FL_JMPN; }
			set
			{
				this.OnPropertyValueChange(_.FL_JMPN, _FL_JMPN, value);
				this._FL_JMPN = value;
			}
		}
		/// <summary>
		/// 分类单位
		/// </summary>
		public string FL_UNIT
		{
			get{ return _FL_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.FL_UNIT, _FL_UNIT, value);
				this._FL_UNIT = value;
			}
		}
		/// <summary>
		/// 审核资料
		/// </summary>
		public string AUDIT_DATA
		{
			get{ return _AUDIT_DATA; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_DATA, _AUDIT_DATA, value);
				this._AUDIT_DATA = value;
			}
		}
		/// <summary>
		/// 审核提示
		/// </summary>
		public string AUDIT_HINT
		{
			get{ return _AUDIT_HINT; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_HINT, _AUDIT_HINT, value);
				this._AUDIT_HINT = value;
			}
		}
		/// <summary>
		/// 入库标准
		/// </summary>
		public string STOCKING_STANDARD
		{
			get{ return _STOCKING_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.STOCKING_STANDARD, _STOCKING_STANDARD, value);
				this._STOCKING_STANDARD = value;
			}
		}
		/// <summary>
		/// 产品报价说明
		/// </summary>
		public string PRODUCT_PRICE_EXPLAIN
		{
			get{ return _PRODUCT_PRICE_EXPLAIN; }
			set
			{
				this.OnPropertyValueChange(_.PRODUCT_PRICE_EXPLAIN, _PRODUCT_PRICE_EXPLAIN, value);
				this._PRODUCT_PRICE_EXPLAIN = value;
			}
		}
		/// <summary>
		/// 企业必填认证与资质信息
		/// </summary>
		public string CO_REQID_QSMSG
		{
			get{ return _CO_REQID_QSMSG; }
			set
			{
				this.OnPropertyValueChange(_.CO_REQID_QSMSG, _CO_REQID_QSMSG, value);
				this._CO_REQID_QSMSG = value;
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
				_.PRODUCT_FL_CODE,
				_.PRODUCT_FL_NAME,
				_.MATERIAL_TYPE,
				_.PRODUCT_TYPE,
				_.FL_JMPN,
				_.FL_UNIT,
				_.AUDIT_DATA,
				_.AUDIT_HINT,
				_.STOCKING_STANDARD,
				_.PRODUCT_PRICE_EXPLAIN,
				_.CO_REQID_QSMSG,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PRODUCT_FL_CODE,
				this._PRODUCT_FL_NAME,
				this._MATERIAL_TYPE,
				this._PRODUCT_TYPE,
				this._FL_JMPN,
				this._FL_UNIT,
				this._AUDIT_DATA,
				this._AUDIT_HINT,
				this._STOCKING_STANDARD,
				this._PRODUCT_PRICE_EXPLAIN,
				this._CO_REQID_QSMSG,
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
			public readonly static Field All = new Field("*", "PRODUCT_CLASSIFY");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRODUCT_CLASSIFY", "ID");
            /// <summary>
			/// 产品分类编码
			/// </summary>
			public readonly static Field PRODUCT_FL_CODE = new Field("PRODUCT_FL_CODE", "PRODUCT_CLASSIFY", "产品分类编码");
            /// <summary>
			/// 产品分类名称
			/// </summary>
			public readonly static Field PRODUCT_FL_NAME = new Field("PRODUCT_FL_NAME", "PRODUCT_CLASSIFY", "产品分类名称");
            /// <summary>
			/// 材料类别
			/// </summary>
			public readonly static Field MATERIAL_TYPE = new Field("MATERIAL_TYPE", "PRODUCT_CLASSIFY", "材料类别");
            /// <summary>
			/// 产品类别
			/// </summary>
			public readonly static Field PRODUCT_TYPE = new Field("PRODUCT_TYPE", "PRODUCT_CLASSIFY", "产品类别");
            /// <summary>
			/// 分类简拼
			/// </summary>
			public readonly static Field FL_JMPN = new Field("FL_JMPN", "PRODUCT_CLASSIFY", "分类简拼");
            /// <summary>
			/// 分类单位
			/// </summary>
			public readonly static Field FL_UNIT = new Field("FL_UNIT", "PRODUCT_CLASSIFY", "分类单位");
            /// <summary>
			/// 审核资料
			/// </summary>
			public readonly static Field AUDIT_DATA = new Field("AUDIT_DATA", "PRODUCT_CLASSIFY", "审核资料");
            /// <summary>
			/// 审核提示
			/// </summary>
			public readonly static Field AUDIT_HINT = new Field("AUDIT_HINT", "PRODUCT_CLASSIFY", "审核提示");
            /// <summary>
			/// 入库标准
			/// </summary>
			public readonly static Field STOCKING_STANDARD = new Field("STOCKING_STANDARD", "PRODUCT_CLASSIFY", "入库标准");
            /// <summary>
			/// 产品报价说明
			/// </summary>
			public readonly static Field PRODUCT_PRICE_EXPLAIN = new Field("PRODUCT_PRICE_EXPLAIN", "PRODUCT_CLASSIFY", "产品报价说明");
            /// <summary>
			/// 企业必填认证与资质信息
			/// </summary>
			public readonly static Field CO_REQID_QSMSG = new Field("CO_REQID_QSMSG", "PRODUCT_CLASSIFY", "企业必填认证与资质信息");
        }
        #endregion
	}
}