using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MEDICAL_TEST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MEDICAL_TEST")]
    [Serializable]
    public partial class T_MEDICAL_TEST : FwEntity
    {
        #region Model
		private string _SYNC_PROD_ID;
		private string _DIRCODE;
		private string _DIRNAME;
		private string _NAMECN;
		private string _DRUGWAY;
		private string _SMLNAME;
		private string _NORMF;
		private string _CONVERTF;
		private string _FACNAME;
		private string _SELECTEDGOODS;
		private string _SALELIMIT;
		private string _PAYPRICE;
		private string _LIMITEDRANGE;
		private DateTime? _UPDATE_TIME;

		/// <summary>
		/// 主键ID
		/// </summary>
		public string SYNC_PROD_ID
		{
			get{ return _SYNC_PROD_ID; }
			set
			{
				this.OnPropertyValueChange(_.SYNC_PROD_ID, _SYNC_PROD_ID, value);
				this._SYNC_PROD_ID = value;
			}
		}
		/// <summary>
		/// 目录号
		/// </summary>
		public string DIRCODE
		{
			get{ return _DIRCODE; }
			set
			{
				this.OnPropertyValueChange(_.DIRCODE, _DIRCODE, value);
				this._DIRCODE = value;
			}
		}
		/// <summary>
		/// 目录名称
		/// </summary>
		public string DIRNAME
		{
			get{ return _DIRNAME; }
			set
			{
				this.OnPropertyValueChange(_.DIRNAME, _DIRNAME, value);
				this._DIRNAME = value;
			}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string NAMECN
		{
			get{ return _NAMECN; }
			set
			{
				this.OnPropertyValueChange(_.NAMECN, _NAMECN, value);
				this._NAMECN = value;
			}
		}
		/// <summary>
		/// 给药途径
		/// </summary>
		public string DRUGWAY
		{
			get{ return _DRUGWAY; }
			set
			{
				this.OnPropertyValueChange(_.DRUGWAY, _DRUGWAY, value);
				this._DRUGWAY = value;
			}
		}
		/// <summary>
		/// 剂型
		/// </summary>
		public string SMLNAME
		{
			get{ return _SMLNAME; }
			set
			{
				this.OnPropertyValueChange(_.SMLNAME, _SMLNAME, value);
				this._SMLNAME = value;
			}
		}
		/// <summary>
		/// 通用规格
		/// </summary>
		public string NORMF
		{
			get{ return _NORMF; }
			set
			{
				this.OnPropertyValueChange(_.NORMF, _NORMF, value);
				this._NORMF = value;
			}
		}
		/// <summary>
		/// 通用包装
		/// </summary>
		public string CONVERTF
		{
			get{ return _CONVERTF; }
			set
			{
				this.OnPropertyValueChange(_.CONVERTF, _CONVERTF, value);
				this._CONVERTF = value;
			}
		}
		/// <summary>
		/// 挂网企业
		/// </summary>
		public string FACNAME
		{
			get{ return _FACNAME; }
			set
			{
				this.OnPropertyValueChange(_.FACNAME, _FACNAME, value);
				this._FACNAME = value;
			}
		}
		/// <summary>
		/// 代表品
		/// </summary>
		public string SELECTEDGOODS
		{
			get{ return _SELECTEDGOODS; }
			set
			{
				this.OnPropertyValueChange(_.SELECTEDGOODS, _SELECTEDGOODS, value);
				this._SELECTEDGOODS = value;
			}
		}
		/// <summary>
		/// 最高销售限价
		/// </summary>
		public string SALELIMIT
		{
			get{ return _SALELIMIT; }
			set
			{
				this.OnPropertyValueChange(_.SALELIMIT, _SALELIMIT, value);
				this._SALELIMIT = value;
			}
		}
		/// <summary>
		/// 医保支付结算价
		/// </summary>
		public string PAYPRICE
		{
			get{ return _PAYPRICE; }
			set
			{
				this.OnPropertyValueChange(_.PAYPRICE, _PAYPRICE, value);
				this._PAYPRICE = value;
			}
		}
		/// <summary>
		/// 医保限用范围
		/// </summary>
		public string LIMITEDRANGE
		{
			get{ return _LIMITEDRANGE; }
			set
			{
				this.OnPropertyValueChange(_.LIMITEDRANGE, _LIMITEDRANGE, value);
				this._LIMITEDRANGE = value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			get{ return _UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
				this._UPDATE_TIME = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.SYNC_PROD_ID,
				_.DIRCODE,
				_.DIRNAME,
				_.NAMECN,
				_.DRUGWAY,
				_.SMLNAME,
				_.NORMF,
				_.CONVERTF,
				_.FACNAME,
				_.SELECTEDGOODS,
				_.SALELIMIT,
				_.PAYPRICE,
				_.LIMITEDRANGE,
				_.UPDATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._SYNC_PROD_ID,
				this._DIRCODE,
				this._DIRNAME,
				this._NAMECN,
				this._DRUGWAY,
				this._SMLNAME,
				this._NORMF,
				this._CONVERTF,
				this._FACNAME,
				this._SELECTEDGOODS,
				this._SALELIMIT,
				this._PAYPRICE,
				this._LIMITEDRANGE,
				this._UPDATE_TIME,
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
			public readonly static Field All = new Field("*", "T_MEDICAL_TEST");
            /// <summary>
			/// 主键ID
			/// </summary>
			public readonly static Field SYNC_PROD_ID = new Field("SYNC_PROD_ID", "T_MEDICAL_TEST", "主键ID");
            /// <summary>
			/// 目录号
			/// </summary>
			public readonly static Field DIRCODE = new Field("DIRCODE", "T_MEDICAL_TEST", "目录号");
            /// <summary>
			/// 目录名称
			/// </summary>
			public readonly static Field DIRNAME = new Field("DIRNAME", "T_MEDICAL_TEST", "目录名称");
            /// <summary>
			/// 产品名称
			/// </summary>
			public readonly static Field NAMECN = new Field("NAMECN", "T_MEDICAL_TEST", "产品名称");
            /// <summary>
			/// 给药途径
			/// </summary>
			public readonly static Field DRUGWAY = new Field("DRUGWAY", "T_MEDICAL_TEST", "给药途径");
            /// <summary>
			/// 剂型
			/// </summary>
			public readonly static Field SMLNAME = new Field("SMLNAME", "T_MEDICAL_TEST", "剂型");
            /// <summary>
			/// 通用规格
			/// </summary>
			public readonly static Field NORMF = new Field("NORMF", "T_MEDICAL_TEST", "通用规格");
            /// <summary>
			/// 通用包装
			/// </summary>
			public readonly static Field CONVERTF = new Field("CONVERTF", "T_MEDICAL_TEST", "通用包装");
            /// <summary>
			/// 挂网企业
			/// </summary>
			public readonly static Field FACNAME = new Field("FACNAME", "T_MEDICAL_TEST", "挂网企业");
            /// <summary>
			/// 代表品
			/// </summary>
			public readonly static Field SELECTEDGOODS = new Field("SELECTEDGOODS", "T_MEDICAL_TEST", "代表品");
            /// <summary>
			/// 最高销售限价
			/// </summary>
			public readonly static Field SALELIMIT = new Field("SALELIMIT", "T_MEDICAL_TEST", "最高销售限价");
            /// <summary>
			/// 医保支付结算价
			/// </summary>
			public readonly static Field PAYPRICE = new Field("PAYPRICE", "T_MEDICAL_TEST", "医保支付结算价");
            /// <summary>
			/// 医保限用范围
			/// </summary>
			public readonly static Field LIMITEDRANGE = new Field("LIMITEDRANGE", "T_MEDICAL_TEST", "医保限用范围");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "T_MEDICAL_TEST", "更新时间");
        }
        #endregion
	}
}