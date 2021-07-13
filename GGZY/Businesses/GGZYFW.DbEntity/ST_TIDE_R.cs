using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ST_TIDE_R。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ST_TIDE_R")]
    [Serializable]
    public partial class ST_TIDE_R : FwEntity
    {
        #region Model
		private string _STCD;
		private DateTime? _TM;
		private decimal? _TDZ;
		private decimal? _AIRP;
		private string _TDCHRCD;
		private string _TDPTN;
		private string _HLTDMK;

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
		public decimal? TDZ
		{
			get{ return _TDZ; }
			set
			{
				this.OnPropertyValueChange(_.TDZ, _TDZ, value);
				this._TDZ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AIRP
		{
			get{ return _AIRP; }
			set
			{
				this.OnPropertyValueChange(_.AIRP, _AIRP, value);
				this._AIRP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TDCHRCD
		{
			get{ return _TDCHRCD; }
			set
			{
				this.OnPropertyValueChange(_.TDCHRCD, _TDCHRCD, value);
				this._TDCHRCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TDPTN
		{
			get{ return _TDPTN; }
			set
			{
				this.OnPropertyValueChange(_.TDPTN, _TDPTN, value);
				this._TDPTN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HLTDMK
		{
			get{ return _HLTDMK; }
			set
			{
				this.OnPropertyValueChange(_.HLTDMK, _HLTDMK, value);
				this._HLTDMK = value;
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
				_.TDZ,
				_.AIRP,
				_.TDCHRCD,
				_.TDPTN,
				_.HLTDMK,
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
				this._TDZ,
				this._AIRP,
				this._TDCHRCD,
				this._TDPTN,
				this._HLTDMK,
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
			public readonly static Field All = new Field("*", "ST_TIDE_R");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TDZ = new Field("TDZ", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AIRP = new Field("AIRP", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TDCHRCD = new Field("TDCHRCD", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TDPTN = new Field("TDPTN", "ST_TIDE_R", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HLTDMK = new Field("HLTDMK", "ST_TIDE_R", "");
        }
        #endregion
	}
}