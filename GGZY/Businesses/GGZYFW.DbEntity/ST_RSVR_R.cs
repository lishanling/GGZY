using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ST_RSVR_R。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ST_RSVR_R")]
    [Serializable]
    public partial class ST_RSVR_R : FwEntity
    {
        #region Model
		private string _STCD;
		private DateTime? _TM;
		private decimal? _RZ;
		private decimal? _INQ;
		private decimal? _W;
		private decimal? _BLRZ;
		private decimal? _OTQ;
		private string _RWCHRCD;
		private string _RWPTN;
		private decimal? _INQDR;
		private string _MSQMT;

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
		public decimal? RZ
		{
			get{ return _RZ; }
			set
			{
				this.OnPropertyValueChange(_.RZ, _RZ, value);
				this._RZ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INQ
		{
			get{ return _INQ; }
			set
			{
				this.OnPropertyValueChange(_.INQ, _INQ, value);
				this._INQ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? W
		{
			get{ return _W; }
			set
			{
				this.OnPropertyValueChange(_.W, _W, value);
				this._W = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BLRZ
		{
			get{ return _BLRZ; }
			set
			{
				this.OnPropertyValueChange(_.BLRZ, _BLRZ, value);
				this._BLRZ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OTQ
		{
			get{ return _OTQ; }
			set
			{
				this.OnPropertyValueChange(_.OTQ, _OTQ, value);
				this._OTQ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RWCHRCD
		{
			get{ return _RWCHRCD; }
			set
			{
				this.OnPropertyValueChange(_.RWCHRCD, _RWCHRCD, value);
				this._RWCHRCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RWPTN
		{
			get{ return _RWPTN; }
			set
			{
				this.OnPropertyValueChange(_.RWPTN, _RWPTN, value);
				this._RWPTN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INQDR
		{
			get{ return _INQDR; }
			set
			{
				this.OnPropertyValueChange(_.INQDR, _INQDR, value);
				this._INQDR = value;
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
				_.RZ,
				_.INQ,
				_.W,
				_.BLRZ,
				_.OTQ,
				_.RWCHRCD,
				_.RWPTN,
				_.INQDR,
				_.MSQMT,
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
				this._RZ,
				this._INQ,
				this._W,
				this._BLRZ,
				this._OTQ,
				this._RWCHRCD,
				this._RWPTN,
				this._INQDR,
				this._MSQMT,
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
			public readonly static Field All = new Field("*", "ST_RSVR_R");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RZ = new Field("RZ", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INQ = new Field("INQ", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field W = new Field("W", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BLRZ = new Field("BLRZ", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OTQ = new Field("OTQ", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RWCHRCD = new Field("RWCHRCD", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RWPTN = new Field("RWPTN", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INQDR = new Field("INQDR", "ST_RSVR_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MSQMT = new Field("MSQMT", "ST_RSVR_R", "");
        }
        #endregion
	}
}