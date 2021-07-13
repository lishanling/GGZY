using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ST_RIVER_R。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ST_RIVER_R")]
    [Serializable]
    public partial class ST_RIVER_R : FwEntity
    {
        #region Model
		private string _STCD;
		private DateTime? _TM;
		private decimal? _Z;
		private decimal? _Q;
		private decimal? _XSA;
		private decimal? _XSAVV;
		private decimal? _XSMXV;
		private string _FLWCHRCD;
		private string _WPTN;
		private string _MSQMT;
		private string _MSAMT;
		private string _MSVMT;

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
		public decimal? Z
		{
			get{ return _Z; }
			set
			{
				this.OnPropertyValueChange(_.Z, _Z, value);
				this._Z = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Q
		{
			get{ return _Q; }
			set
			{
				this.OnPropertyValueChange(_.Q, _Q, value);
				this._Q = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? XSA
		{
			get{ return _XSA; }
			set
			{
				this.OnPropertyValueChange(_.XSA, _XSA, value);
				this._XSA = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? XSAVV
		{
			get{ return _XSAVV; }
			set
			{
				this.OnPropertyValueChange(_.XSAVV, _XSAVV, value);
				this._XSAVV = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? XSMXV
		{
			get{ return _XSMXV; }
			set
			{
				this.OnPropertyValueChange(_.XSMXV, _XSMXV, value);
				this._XSMXV = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FLWCHRCD
		{
			get{ return _FLWCHRCD; }
			set
			{
				this.OnPropertyValueChange(_.FLWCHRCD, _FLWCHRCD, value);
				this._FLWCHRCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPTN
		{
			get{ return _WPTN; }
			set
			{
				this.OnPropertyValueChange(_.WPTN, _WPTN, value);
				this._WPTN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MSQMT
		{
			get{ return _MSQMT; }
			set
			{
				this.OnPropertyValueChange(_.MSQMT, _MSQMT, value);
				this._MSQMT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MSAMT
		{
			get{ return _MSAMT; }
			set
			{
				this.OnPropertyValueChange(_.MSAMT, _MSAMT, value);
				this._MSAMT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MSVMT
		{
			get{ return _MSVMT; }
			set
			{
				this.OnPropertyValueChange(_.MSVMT, _MSVMT, value);
				this._MSVMT = value;
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
				_.Z,
				_.Q,
				_.XSA,
				_.XSAVV,
				_.XSMXV,
				_.FLWCHRCD,
				_.WPTN,
				_.MSQMT,
				_.MSAMT,
				_.MSVMT,
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
				this._Z,
				this._Q,
				this._XSA,
				this._XSAVV,
				this._XSMXV,
				this._FLWCHRCD,
				this._WPTN,
				this._MSQMT,
				this._MSAMT,
				this._MSVMT,
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
			public readonly static Field All = new Field("*", "ST_RIVER_R");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Z = new Field("Z", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Q = new Field("Q", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XSA = new Field("XSA", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XSAVV = new Field("XSAVV", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XSMXV = new Field("XSMXV", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FLWCHRCD = new Field("FLWCHRCD", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WPTN = new Field("WPTN", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MSQMT = new Field("MSQMT", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MSAMT = new Field("MSAMT", "ST_RIVER_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MSVMT = new Field("MSVMT", "ST_RIVER_R", "");
        }
        #endregion
	}
}