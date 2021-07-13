using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_ZJRJ_CODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_ZJRJ_CODE")]
    [Serializable]
    public partial class BID_ZJRJ_CODE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BIDDER_NAME;
		private string _BDMC;
		private string _CPUXLH;
		private string _GHSJ;
		private string _IPDZ;
		private string _JMSXLH;
		private string _NCXLH;
		private string _RJBBH;
		private string _RJGSMC;
		private string _TBRMC;
		private string _WKDZ;
		private string _YPXLH;
		private string _ZBXMMC;
		private DateTime? _TENDER_DOC_SUBMITTIME;
		private string _VALUATION_XML;
		private DateTime? _CREATETIME;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BDMC
		{
			get{ return _BDMC; }
			set
			{
				this.OnPropertyValueChange(_.BDMC, _BDMC, value);
				this._BDMC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPUXLH
		{
			get{ return _CPUXLH; }
			set
			{
				this.OnPropertyValueChange(_.CPUXLH, _CPUXLH, value);
				this._CPUXLH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GHSJ
		{
			get{ return _GHSJ; }
			set
			{
				this.OnPropertyValueChange(_.GHSJ, _GHSJ, value);
				this._GHSJ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IPDZ
		{
			get{ return _IPDZ; }
			set
			{
				this.OnPropertyValueChange(_.IPDZ, _IPDZ, value);
				this._IPDZ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JMSXLH
		{
			get{ return _JMSXLH; }
			set
			{
				this.OnPropertyValueChange(_.JMSXLH, _JMSXLH, value);
				this._JMSXLH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NCXLH
		{
			get{ return _NCXLH; }
			set
			{
				this.OnPropertyValueChange(_.NCXLH, _NCXLH, value);
				this._NCXLH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RJBBH
		{
			get{ return _RJBBH; }
			set
			{
				this.OnPropertyValueChange(_.RJBBH, _RJBBH, value);
				this._RJBBH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RJGSMC
		{
			get{ return _RJGSMC; }
			set
			{
				this.OnPropertyValueChange(_.RJGSMC, _RJGSMC, value);
				this._RJGSMC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBRMC
		{
			get{ return _TBRMC; }
			set
			{
				this.OnPropertyValueChange(_.TBRMC, _TBRMC, value);
				this._TBRMC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WKDZ
		{
			get{ return _WKDZ; }
			set
			{
				this.OnPropertyValueChange(_.WKDZ, _WKDZ, value);
				this._WKDZ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YPXLH
		{
			get{ return _YPXLH; }
			set
			{
				this.OnPropertyValueChange(_.YPXLH, _YPXLH, value);
				this._YPXLH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZBXMMC
		{
			get{ return _ZBXMMC; }
			set
			{
				this.OnPropertyValueChange(_.ZBXMMC, _ZBXMMC, value);
				this._ZBXMMC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TENDER_DOC_SUBMITTIME
		{
			get{ return _TENDER_DOC_SUBMITTIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_SUBMITTIME, _TENDER_DOC_SUBMITTIME, value);
				this._TENDER_DOC_SUBMITTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUATION_XML
		{
			get{ return _VALUATION_XML; }
			set
			{
				this.OnPropertyValueChange(_.VALUATION_XML, _VALUATION_XML, value);
				this._VALUATION_XML = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BIDDER_NAME,
				_.BDMC,
				_.CPUXLH,
				_.GHSJ,
				_.IPDZ,
				_.JMSXLH,
				_.NCXLH,
				_.RJBBH,
				_.RJGSMC,
				_.TBRMC,
				_.WKDZ,
				_.YPXLH,
				_.ZBXMMC,
				_.TENDER_DOC_SUBMITTIME,
				_.VALUATION_XML,
				_.CREATETIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BIDDER_NAME,
				this._BDMC,
				this._CPUXLH,
				this._GHSJ,
				this._IPDZ,
				this._JMSXLH,
				this._NCXLH,
				this._RJBBH,
				this._RJGSMC,
				this._TBRMC,
				this._WKDZ,
				this._YPXLH,
				this._ZBXMMC,
				this._TENDER_DOC_SUBMITTIME,
				this._VALUATION_XML,
				this._CREATETIME,
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
			public readonly static Field All = new Field("*", "BID_ZJRJ_CODE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "BID_ZJRJ_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BID_ZJRJ_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BID_ZJRJ_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BID_ZJRJ_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BDMC = new Field("BDMC", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CPUXLH = new Field("CPUXLH", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GHSJ = new Field("GHSJ", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IPDZ = new Field("IPDZ", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JMSXLH = new Field("JMSXLH", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NCXLH = new Field("NCXLH", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RJBBH = new Field("RJBBH", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RJGSMC = new Field("RJGSMC", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TBRMC = new Field("TBRMC", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WKDZ = new Field("WKDZ", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YPXLH = new Field("YPXLH", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBXMMC = new Field("ZBXMMC", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_DOC_SUBMITTIME = new Field("TENDER_DOC_SUBMITTIME", "BID_ZJRJ_CODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUATION_XML = new Field("VALUATION_XML", "BID_ZJRJ_CODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "BID_ZJRJ_CODE", "");
        }
        #endregion
	}
}