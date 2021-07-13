using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_AREA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_AREA")]
    [Serializable]
    public partial class SYS_AREA : FwEntity
    {
        #region Model
		private string _AREACODE;
		private string _AREANAME;
		private decimal? _P_X;
		private decimal? _P_Y;
		private decimal? _A_MAXX;
		private decimal? _A_MAXY;
		private decimal? _A_MINX;
		private decimal? _A_MINY;
		private string _SHI;
		private string _XIAN;
		private string _JIEDAO;
		private string _CUN;
		private string _PCODE;
		private string _PPCODE;

		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREANAME
		{
			get{ return _AREANAME; }
			set
			{
				this.OnPropertyValueChange(_.AREANAME, _AREANAME, value);
				this._AREANAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? P_X
		{
			get{ return _P_X; }
			set
			{
				this.OnPropertyValueChange(_.P_X, _P_X, value);
				this._P_X = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? P_Y
		{
			get{ return _P_Y; }
			set
			{
				this.OnPropertyValueChange(_.P_Y, _P_Y, value);
				this._P_Y = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? A_MAXX
		{
			get{ return _A_MAXX; }
			set
			{
				this.OnPropertyValueChange(_.A_MAXX, _A_MAXX, value);
				this._A_MAXX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? A_MAXY
		{
			get{ return _A_MAXY; }
			set
			{
				this.OnPropertyValueChange(_.A_MAXY, _A_MAXY, value);
				this._A_MAXY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? A_MINX
		{
			get{ return _A_MINX; }
			set
			{
				this.OnPropertyValueChange(_.A_MINX, _A_MINX, value);
				this._A_MINX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? A_MINY
		{
			get{ return _A_MINY; }
			set
			{
				this.OnPropertyValueChange(_.A_MINY, _A_MINY, value);
				this._A_MINY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SHI
		{
			get{ return _SHI; }
			set
			{
				this.OnPropertyValueChange(_.SHI, _SHI, value);
				this._SHI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XIAN
		{
			get{ return _XIAN; }
			set
			{
				this.OnPropertyValueChange(_.XIAN, _XIAN, value);
				this._XIAN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JIEDAO
		{
			get{ return _JIEDAO; }
			set
			{
				this.OnPropertyValueChange(_.JIEDAO, _JIEDAO, value);
				this._JIEDAO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUN
		{
			get{ return _CUN; }
			set
			{
				this.OnPropertyValueChange(_.CUN, _CUN, value);
				this._CUN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCODE
		{
			get{ return _PCODE; }
			set
			{
				this.OnPropertyValueChange(_.PCODE, _PCODE, value);
				this._PCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PPCODE
		{
			get{ return _PPCODE; }
			set
			{
				this.OnPropertyValueChange(_.PPCODE, _PPCODE, value);
				this._PPCODE = value;
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
				_.AREACODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.AREACODE,
				_.AREANAME,
				_.P_X,
				_.P_Y,
				_.A_MAXX,
				_.A_MAXY,
				_.A_MINX,
				_.A_MINY,
				_.SHI,
				_.XIAN,
				_.JIEDAO,
				_.CUN,
				_.PCODE,
				_.PPCODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._AREACODE,
				this._AREANAME,
				this._P_X,
				this._P_Y,
				this._A_MAXX,
				this._A_MAXY,
				this._A_MINX,
				this._A_MINY,
				this._SHI,
				this._XIAN,
				this._JIEDAO,
				this._CUN,
				this._PCODE,
				this._PPCODE,
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
			public readonly static Field All = new Field("*", "SYS_AREA");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_X = new Field("P_X", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field P_Y = new Field("P_Y", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field A_MAXX = new Field("A_MAXX", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field A_MAXY = new Field("A_MAXY", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field A_MINX = new Field("A_MINX", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field A_MINY = new Field("A_MINY", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SHI = new Field("SHI", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XIAN = new Field("XIAN", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JIEDAO = new Field("JIEDAO", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CUN = new Field("CUN", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PCODE = new Field("PCODE", "SYS_AREA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PPCODE = new Field("PPCODE", "SYS_AREA", "");
        }
        #endregion
	}
}