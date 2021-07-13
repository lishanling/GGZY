using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类GTEMPP。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GTEMPP")]
    [Serializable]
    public partial class GTEMPP : FwEntity
    {
        #region Model
		private string _TENDERPROJECTCODE;
		private string _SECTIONCODE;
		private string _NOTICECONTENT;
		private string _BULLETINTYPE;
		private string _NOTICENATURE;
		private DateTime? _DOCSELLSTARTTIME;
		private decimal? _DOCPRICE;
		private string _DOCPRICEUNIT;
		private DateTime? _BIDOPENTIME;
		private string _SYNDICATEDFLAG;
		private string _NOTICEMEDIA;
		private DateTime? _NOTICESENDTIME;
		private DateTime? _DATATIMESTAMP;
		private string _M_AREACODE;
		private string _M_ANNOUNCEMENT_TITLE;
		private DateTime? _DOCGETENDTIME;
		private string _TENDERDOCGETMETHOD;
		private DateTime? _BIDDOCREFERENDTIME;
		private string _BIDDOCREFERMETHOD;
		private string _BULLETINDUTY;
		private string _BULLETINDUTYCODETYPE;
		private string _URL;
		private string _ATTACHMENTCODE;
		private string _DOCPRICECURRENCY;
		private string _DATASOURCECODE;

		/// <summary>
		/// 
		/// </summary>
		public string TENDERPROJECTCODE
		{
			get{ return _TENDERPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTCODE, _TENDERPROJECTCODE, value);
				this._TENDERPROJECTCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SECTIONCODE
		{
			get{ return _SECTIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.SECTIONCODE, _SECTIONCODE, value);
				this._SECTIONCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTICECONTENT
		{
			get{ return _NOTICECONTENT; }
			set
			{
				this.OnPropertyValueChange(_.NOTICECONTENT, _NOTICECONTENT, value);
				this._NOTICECONTENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULLETINTYPE
		{
			get{ return _BULLETINTYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINTYPE, _BULLETINTYPE, value);
				this._BULLETINTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTICENATURE
		{
			get{ return _NOTICENATURE; }
			set
			{
				this.OnPropertyValueChange(_.NOTICENATURE, _NOTICENATURE, value);
				this._NOTICENATURE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DOCSELLSTARTTIME
		{
			get{ return _DOCSELLSTARTTIME; }
			set
			{
				this.OnPropertyValueChange(_.DOCSELLSTARTTIME, _DOCSELLSTARTTIME, value);
				this._DOCSELLSTARTTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DOCPRICE
		{
			get{ return _DOCPRICE; }
			set
			{
				this.OnPropertyValueChange(_.DOCPRICE, _DOCPRICE, value);
				this._DOCPRICE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCPRICEUNIT
		{
			get{ return _DOCPRICEUNIT; }
			set
			{
				this.OnPropertyValueChange(_.DOCPRICEUNIT, _DOCPRICEUNIT, value);
				this._DOCPRICEUNIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BIDOPENTIME
		{
			get{ return _BIDOPENTIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDOPENTIME, _BIDOPENTIME, value);
				this._BIDOPENTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYNDICATEDFLAG
		{
			get{ return _SYNDICATEDFLAG; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATEDFLAG, _SYNDICATEDFLAG, value);
				this._SYNDICATEDFLAG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTICEMEDIA
		{
			get{ return _NOTICEMEDIA; }
			set
			{
				this.OnPropertyValueChange(_.NOTICEMEDIA, _NOTICEMEDIA, value);
				this._NOTICEMEDIA = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NOTICESENDTIME
		{
			get{ return _NOTICESENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICESENDTIME, _NOTICESENDTIME, value);
				this._NOTICESENDTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_AREACODE
		{
			get{ return _M_AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.M_AREACODE, _M_AREACODE, value);
				this._M_AREACODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_ANNOUNCEMENT_TITLE
		{
			get{ return _M_ANNOUNCEMENT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.M_ANNOUNCEMENT_TITLE, _M_ANNOUNCEMENT_TITLE, value);
				this._M_ANNOUNCEMENT_TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DOCGETENDTIME
		{
			get{ return _DOCGETENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.DOCGETENDTIME, _DOCGETENDTIME, value);
				this._DOCGETENDTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERDOCGETMETHOD
		{
			get{ return _TENDERDOCGETMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.TENDERDOCGETMETHOD, _TENDERDOCGETMETHOD, value);
				this._TENDERDOCGETMETHOD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BIDDOCREFERENDTIME
		{
			get{ return _BIDDOCREFERENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDOCREFERENDTIME, _BIDDOCREFERENDTIME, value);
				this._BIDDOCREFERENDTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BIDDOCREFERMETHOD
		{
			get{ return _BIDDOCREFERMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.BIDDOCREFERMETHOD, _BIDDOCREFERMETHOD, value);
				this._BIDDOCREFERMETHOD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULLETINDUTY
		{
			get{ return _BULLETINDUTY; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINDUTY, _BULLETINDUTY, value);
				this._BULLETINDUTY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULLETINDUTYCODETYPE
		{
			get{ return _BULLETINDUTYCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETINDUTYCODETYPE, _BULLETINDUTYCODETYPE, value);
				this._BULLETINDUTYCODETYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATTACHMENTCODE
		{
			get{ return _ATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTCODE, _ATTACHMENTCODE, value);
				this._ATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCPRICECURRENCY
		{
			get{ return _DOCPRICECURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.DOCPRICECURRENCY, _DOCPRICECURRENCY, value);
				this._DOCPRICECURRENCY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DATASOURCECODE
		{
			get{ return _DATASOURCECODE; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCECODE, _DATASOURCECODE, value);
				this._DATASOURCECODE = value;
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
				_.TENDERPROJECTCODE,
				_.SECTIONCODE,
				_.NOTICECONTENT,
				_.BULLETINTYPE,
				_.NOTICENATURE,
				_.DOCSELLSTARTTIME,
				_.DOCPRICE,
				_.DOCPRICEUNIT,
				_.BIDOPENTIME,
				_.SYNDICATEDFLAG,
				_.NOTICEMEDIA,
				_.NOTICESENDTIME,
				_.DATATIMESTAMP,
				_.M_AREACODE,
				_.M_ANNOUNCEMENT_TITLE,
				_.DOCGETENDTIME,
				_.TENDERDOCGETMETHOD,
				_.BIDDOCREFERENDTIME,
				_.BIDDOCREFERMETHOD,
				_.BULLETINDUTY,
				_.BULLETINDUTYCODETYPE,
				_.URL,
				_.ATTACHMENTCODE,
				_.DOCPRICECURRENCY,
				_.DATASOURCECODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDERPROJECTCODE,
				this._SECTIONCODE,
				this._NOTICECONTENT,
				this._BULLETINTYPE,
				this._NOTICENATURE,
				this._DOCSELLSTARTTIME,
				this._DOCPRICE,
				this._DOCPRICEUNIT,
				this._BIDOPENTIME,
				this._SYNDICATEDFLAG,
				this._NOTICEMEDIA,
				this._NOTICESENDTIME,
				this._DATATIMESTAMP,
				this._M_AREACODE,
				this._M_ANNOUNCEMENT_TITLE,
				this._DOCGETENDTIME,
				this._TENDERDOCGETMETHOD,
				this._BIDDOCREFERENDTIME,
				this._BIDDOCREFERMETHOD,
				this._BULLETINDUTY,
				this._BULLETINDUTYCODETYPE,
				this._URL,
				this._ATTACHMENTCODE,
				this._DOCPRICECURRENCY,
				this._DATASOURCECODE,
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
			public readonly static Field All = new Field("*", "GTEMPP");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SECTIONCODE = new Field("SECTIONCODE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICECONTENT = new Field("NOTICECONTENT", "GTEMPP",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULLETINTYPE = new Field("BULLETINTYPE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICENATURE = new Field("NOTICENATURE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCSELLSTARTTIME = new Field("DOCSELLSTARTTIME", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCPRICE = new Field("DOCPRICE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCPRICEUNIT = new Field("DOCPRICEUNIT", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDOPENTIME = new Field("BIDOPENTIME", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNDICATEDFLAG = new Field("SYNDICATEDFLAG", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICEMEDIA = new Field("NOTICEMEDIA", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICESENDTIME = new Field("NOTICESENDTIME", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_AREACODE = new Field("M_AREACODE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ANNOUNCEMENT_TITLE = new Field("M_ANNOUNCEMENT_TITLE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCGETENDTIME = new Field("DOCGETENDTIME", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERDOCGETMETHOD = new Field("TENDERDOCGETMETHOD", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDOCREFERENDTIME = new Field("BIDDOCREFERENDTIME", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDOCREFERMETHOD = new Field("BIDDOCREFERMETHOD", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULLETINDUTY = new Field("BULLETINDUTY", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULLETINDUTYCODETYPE = new Field("BULLETINDUTYCODETYPE", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ATTACHMENTCODE = new Field("ATTACHMENTCODE", "GTEMPP",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCPRICECURRENCY = new Field("DOCPRICECURRENCY", "GTEMPP", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "GTEMPP", "");
        }
        #endregion
	}
}