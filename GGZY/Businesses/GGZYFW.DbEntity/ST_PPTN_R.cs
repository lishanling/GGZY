using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ST_PPTN_R。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ST_PPTN_R")]
    [Serializable]
    public partial class ST_PPTN_R : FwEntity
    {
        #region Model
		private string _STCD;
		private DateTime? _TM;
		private decimal? _DRP;
		private decimal? _INTV;
		private decimal? _PDR;
		private decimal? _DYP;
		private string _WTH;
		private DateTime? _GTM;

		/// <summary>
		/// 
		/// </summary>
		public string STCD
		{
			get{ return _STCD; }
			set
			{
				this.OnPropertyValueChange(_.STCD, _STCD, value);
				this._STCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DRP
		{
			get{ return _DRP; }
			set
			{
				this.OnPropertyValueChange(_.DRP, _DRP, value);
				this._DRP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INTV
		{
			get{ return _INTV; }
			set
			{
				this.OnPropertyValueChange(_.INTV, _INTV, value);
				this._INTV = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PDR
		{
			get{ return _PDR; }
			set
			{
				this.OnPropertyValueChange(_.PDR, _PDR, value);
				this._PDR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DYP
		{
			get{ return _DYP; }
			set
			{
				this.OnPropertyValueChange(_.DYP, _DYP, value);
				this._DYP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTH
		{
			get{ return _WTH; }
			set
			{
				this.OnPropertyValueChange(_.WTH, _WTH, value);
				this._WTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GTM
		{
			get{ return _GTM; }
			set
			{
				this.OnPropertyValueChange(_.GTM, _GTM, value);
				this._GTM = value;
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
				_.STCD,
				_.TM,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.STCD,
				_.TM,
				_.DRP,
				_.INTV,
				_.PDR,
				_.DYP,
				_.WTH,
				_.GTM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._STCD,
				this._TM,
				this._DRP,
				this._INTV,
				this._PDR,
				this._DYP,
				this._WTH,
				this._GTM,
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
			public readonly static Field All = new Field("*", "ST_PPTN_R");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DRP = new Field("DRP", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INTV = new Field("INTV", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PDR = new Field("PDR", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DYP = new Field("DYP", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WTH = new Field("WTH", "ST_PPTN_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GTM = new Field("GTM", "ST_PPTN_R", "");
        }
        #endregion
	}
}