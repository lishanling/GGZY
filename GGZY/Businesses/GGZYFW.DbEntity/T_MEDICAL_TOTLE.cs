using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MEDICAL_TOTLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MEDICAL_TOTLE")]
    [Serializable]
    public partial class T_MEDICAL_TOTLE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private DateTime? _JY_DATE;
		private decimal? _FHJE;
		private decimal? _CPZS;
		private decimal? _YLJG;
		private decimal? _SCQY;
		private decimal? _PSQY;

		/// <summary>
		/// 主键ID
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
		/// 日期
		/// </summary>
		public DateTime? JY_DATE
		{
			get{ return _JY_DATE; }
			set
			{
				this.OnPropertyValueChange(_.JY_DATE, _JY_DATE, value);
				this._JY_DATE = value;
			}
		}
		/// <summary>
		/// 发货金额（万元）
		/// </summary>
		public decimal? FHJE
		{
			get{ return _FHJE; }
			set
			{
				this.OnPropertyValueChange(_.FHJE, _FHJE, value);
				this._FHJE = value;
			}
		}
		/// <summary>
		/// 产品总数
		/// </summary>
		public decimal? CPZS
		{
			get{ return _CPZS; }
			set
			{
				this.OnPropertyValueChange(_.CPZS, _CPZS, value);
				this._CPZS = value;
			}
		}
		/// <summary>
		/// 医疗机构总数
		/// </summary>
		public decimal? YLJG
		{
			get{ return _YLJG; }
			set
			{
				this.OnPropertyValueChange(_.YLJG, _YLJG, value);
				this._YLJG = value;
			}
		}
		/// <summary>
		/// 生产企业总数
		/// </summary>
		public decimal? SCQY
		{
			get{ return _SCQY; }
			set
			{
				this.OnPropertyValueChange(_.SCQY, _SCQY, value);
				this._SCQY = value;
			}
		}
		/// <summary>
		/// 配送企业总数
		/// </summary>
		public decimal? PSQY
		{
			get{ return _PSQY; }
			set
			{
				this.OnPropertyValueChange(_.PSQY, _PSQY, value);
				this._PSQY = value;
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
				_.JY_DATE,
				_.FHJE,
				_.CPZS,
				_.YLJG,
				_.SCQY,
				_.PSQY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._JY_DATE,
				this._FHJE,
				this._CPZS,
				this._YLJG,
				this._SCQY,
				this._PSQY,
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
			public readonly static Field All = new Field("*", "T_MEDICAL_TOTLE");
            /// <summary>
			/// 主键ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MEDICAL_TOTLE", "主键ID");
            /// <summary>
			/// 日期
			/// </summary>
			public readonly static Field JY_DATE = new Field("JY_DATE", "T_MEDICAL_TOTLE", "日期");
            /// <summary>
			/// 发货金额（万元）
			/// </summary>
			public readonly static Field FHJE = new Field("FHJE", "T_MEDICAL_TOTLE", "发货金额（万元）");
            /// <summary>
			/// 产品总数
			/// </summary>
			public readonly static Field CPZS = new Field("CPZS", "T_MEDICAL_TOTLE", "产品总数");
            /// <summary>
			/// 医疗机构总数
			/// </summary>
			public readonly static Field YLJG = new Field("YLJG", "T_MEDICAL_TOTLE", "医疗机构总数");
            /// <summary>
			/// 生产企业总数
			/// </summary>
			public readonly static Field SCQY = new Field("SCQY", "T_MEDICAL_TOTLE", "生产企业总数");
            /// <summary>
			/// 配送企业总数
			/// </summary>
			public readonly static Field PSQY = new Field("PSQY", "T_MEDICAL_TOTLE", "配送企业总数");
        }
        #endregion
	}
}