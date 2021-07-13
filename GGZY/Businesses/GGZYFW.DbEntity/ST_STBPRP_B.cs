using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ST_STBPRP_B。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ST_STBPRP_B")]
    [Serializable]
    public partial class ST_STBPRP_B : FwEntity
    {
        #region Model
		private string _STCD;
		private string _STNM;
		private string _RVNM;
		private string _HNNM;
		private string _BSNM;
		private string _LGTD;
		private string _LTTD;
		private string _STLC;
		private string _ADDVCD;
		private string _DTMNM;
		private decimal? _DTMEL;
		private decimal? _DTPR;
		private string _STTP;
		private string _FRGRD;
		private string _ESSTYM;
		private string _BGFRYM;
		private string _ATCUNIT;
		private string _ADMAUTH;
		private string _LOCALITY;
		private string _STBK;
		private decimal? _STAZT;
		private decimal? _DSTRVM;
		private decimal? _DRNA;
		private string _PHCD;
		private string _USFL;
		private string _COMMENTS;
		private DateTime? _MODITIME;
		private decimal? _SORTID;
		private decimal? _SORTID_ALL;
		private decimal? _SORTID_RIVER;
		private decimal? _TYPE;
		private string _TSTCD;
		private string _GSTCD;
		private decimal? _HOUR;
		private decimal? _ISAUTO;

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
		public string STNM
		{
			get{ return _STNM; }
			set
			{
				this.OnPropertyValueChange(_.STNM, _STNM, value);
				this._STNM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RVNM
		{
			get{ return _RVNM; }
			set
			{
				this.OnPropertyValueChange(_.RVNM, _RVNM, value);
				this._RVNM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HNNM
		{
			get{ return _HNNM; }
			set
			{
				this.OnPropertyValueChange(_.HNNM, _HNNM, value);
				this._HNNM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BSNM
		{
			get{ return _BSNM; }
			set
			{
				this.OnPropertyValueChange(_.BSNM, _BSNM, value);
				this._BSNM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LGTD
		{
			get{ return _LGTD; }
			set
			{
				this.OnPropertyValueChange(_.LGTD, _LGTD, value);
				this._LGTD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LTTD
		{
			get{ return _LTTD; }
			set
			{
				this.OnPropertyValueChange(_.LTTD, _LTTD, value);
				this._LTTD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STLC
		{
			get{ return _STLC; }
			set
			{
				this.OnPropertyValueChange(_.STLC, _STLC, value);
				this._STLC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDVCD
		{
			get{ return _ADDVCD; }
			set
			{
				this.OnPropertyValueChange(_.ADDVCD, _ADDVCD, value);
				this._ADDVCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DTMNM
		{
			get{ return _DTMNM; }
			set
			{
				this.OnPropertyValueChange(_.DTMNM, _DTMNM, value);
				this._DTMNM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DTMEL
		{
			get{ return _DTMEL; }
			set
			{
				this.OnPropertyValueChange(_.DTMEL, _DTMEL, value);
				this._DTMEL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DTPR
		{
			get{ return _DTPR; }
			set
			{
				this.OnPropertyValueChange(_.DTPR, _DTPR, value);
				this._DTPR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STTP
		{
			get{ return _STTP; }
			set
			{
				this.OnPropertyValueChange(_.STTP, _STTP, value);
				this._STTP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FRGRD
		{
			get{ return _FRGRD; }
			set
			{
				this.OnPropertyValueChange(_.FRGRD, _FRGRD, value);
				this._FRGRD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ESSTYM
		{
			get{ return _ESSTYM; }
			set
			{
				this.OnPropertyValueChange(_.ESSTYM, _ESSTYM, value);
				this._ESSTYM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BGFRYM
		{
			get{ return _BGFRYM; }
			set
			{
				this.OnPropertyValueChange(_.BGFRYM, _BGFRYM, value);
				this._BGFRYM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATCUNIT
		{
			get{ return _ATCUNIT; }
			set
			{
				this.OnPropertyValueChange(_.ATCUNIT, _ATCUNIT, value);
				this._ATCUNIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADMAUTH
		{
			get{ return _ADMAUTH; }
			set
			{
				this.OnPropertyValueChange(_.ADMAUTH, _ADMAUTH, value);
				this._ADMAUTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOCALITY
		{
			get{ return _LOCALITY; }
			set
			{
				this.OnPropertyValueChange(_.LOCALITY, _LOCALITY, value);
				this._LOCALITY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STBK
		{
			get{ return _STBK; }
			set
			{
				this.OnPropertyValueChange(_.STBK, _STBK, value);
				this._STBK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? STAZT
		{
			get{ return _STAZT; }
			set
			{
				this.OnPropertyValueChange(_.STAZT, _STAZT, value);
				this._STAZT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DSTRVM
		{
			get{ return _DSTRVM; }
			set
			{
				this.OnPropertyValueChange(_.DSTRVM, _DSTRVM, value);
				this._DSTRVM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DRNA
		{
			get{ return _DRNA; }
			set
			{
				this.OnPropertyValueChange(_.DRNA, _DRNA, value);
				this._DRNA = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHCD
		{
			get{ return _PHCD; }
			set
			{
				this.OnPropertyValueChange(_.PHCD, _PHCD, value);
				this._PHCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USFL
		{
			get{ return _USFL; }
			set
			{
				this.OnPropertyValueChange(_.USFL, _USFL, value);
				this._USFL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			get{ return _COMMENTS; }
			set
			{
				this.OnPropertyValueChange(_.COMMENTS, _COMMENTS, value);
				this._COMMENTS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MODITIME
		{
			get{ return _MODITIME; }
			set
			{
				this.OnPropertyValueChange(_.MODITIME, _MODITIME, value);
				this._MODITIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SORTID
		{
			get{ return _SORTID; }
			set
			{
				this.OnPropertyValueChange(_.SORTID, _SORTID, value);
				this._SORTID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SORTID_ALL
		{
			get{ return _SORTID_ALL; }
			set
			{
				this.OnPropertyValueChange(_.SORTID_ALL, _SORTID_ALL, value);
				this._SORTID_ALL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SORTID_RIVER
		{
			get{ return _SORTID_RIVER; }
			set
			{
				this.OnPropertyValueChange(_.SORTID_RIVER, _SORTID_RIVER, value);
				this._SORTID_RIVER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TSTCD
		{
			get{ return _TSTCD; }
			set
			{
				this.OnPropertyValueChange(_.TSTCD, _TSTCD, value);
				this._TSTCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GSTCD
		{
			get{ return _GSTCD; }
			set
			{
				this.OnPropertyValueChange(_.GSTCD, _GSTCD, value);
				this._GSTCD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HOUR
		{
			get{ return _HOUR; }
			set
			{
				this.OnPropertyValueChange(_.HOUR, _HOUR, value);
				this._HOUR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISAUTO
		{
			get{ return _ISAUTO; }
			set
			{
				this.OnPropertyValueChange(_.ISAUTO, _ISAUTO, value);
				this._ISAUTO = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.STCD,
				_.STNM,
				_.RVNM,
				_.HNNM,
				_.BSNM,
				_.LGTD,
				_.LTTD,
				_.STLC,
				_.ADDVCD,
				_.DTMNM,
				_.DTMEL,
				_.DTPR,
				_.STTP,
				_.FRGRD,
				_.ESSTYM,
				_.BGFRYM,
				_.ATCUNIT,
				_.ADMAUTH,
				_.LOCALITY,
				_.STBK,
				_.STAZT,
				_.DSTRVM,
				_.DRNA,
				_.PHCD,
				_.USFL,
				_.COMMENTS,
				_.MODITIME,
				_.SORTID,
				_.SORTID_ALL,
				_.SORTID_RIVER,
				_.TYPE,
				_.TSTCD,
				_.GSTCD,
				_.HOUR,
				_.ISAUTO,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._STCD,
				this._STNM,
				this._RVNM,
				this._HNNM,
				this._BSNM,
				this._LGTD,
				this._LTTD,
				this._STLC,
				this._ADDVCD,
				this._DTMNM,
				this._DTMEL,
				this._DTPR,
				this._STTP,
				this._FRGRD,
				this._ESSTYM,
				this._BGFRYM,
				this._ATCUNIT,
				this._ADMAUTH,
				this._LOCALITY,
				this._STBK,
				this._STAZT,
				this._DSTRVM,
				this._DRNA,
				this._PHCD,
				this._USFL,
				this._COMMENTS,
				this._MODITIME,
				this._SORTID,
				this._SORTID_ALL,
				this._SORTID_RIVER,
				this._TYPE,
				this._TSTCD,
				this._GSTCD,
				this._HOUR,
				this._ISAUTO,
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
			public readonly static Field All = new Field("*", "ST_STBPRP_B");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STCD = new Field("STCD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STNM = new Field("STNM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RVNM = new Field("RVNM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HNNM = new Field("HNNM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BSNM = new Field("BSNM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LGTD = new Field("LGTD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LTTD = new Field("LTTD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STLC = new Field("STLC", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADDVCD = new Field("ADDVCD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DTMNM = new Field("DTMNM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DTMEL = new Field("DTMEL", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DTPR = new Field("DTPR", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STTP = new Field("STTP", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FRGRD = new Field("FRGRD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ESSTYM = new Field("ESSTYM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BGFRYM = new Field("BGFRYM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ATCUNIT = new Field("ATCUNIT", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADMAUTH = new Field("ADMAUTH", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOCALITY = new Field("LOCALITY", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STBK = new Field("STBK", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STAZT = new Field("STAZT", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DSTRVM = new Field("DSTRVM", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DRNA = new Field("DRNA", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PHCD = new Field("PHCD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USFL = new Field("USFL", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COMMENTS = new Field("COMMENTS", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODITIME = new Field("MODITIME", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTID = new Field("SORTID", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTID_ALL = new Field("SORTID_ALL", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTID_RIVER = new Field("SORTID_RIVER", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TSTCD = new Field("TSTCD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GSTCD = new Field("GSTCD", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HOUR = new Field("HOUR", "ST_STBPRP_B", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISAUTO = new Field("ISAUTO", "ST_STBPRP_B", "");
        }
        #endregion
	}
}