using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类V_BIG_JG。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_BIG_JG")]
	[Serializable]
	public partial class V_BIG_JG : FwEntity
	{
		#region Model
		private DateTime? _M_TM;
		private string _SECTION_CODE;
		private string _PROJECT_CODE;
		private string _WIN_BIDDER_NAME;
		private DateTime? _NOTICE_SEND_TIME;
		private decimal? _AMOUNT;
		private string _AREACODE;
		private string _AREANAME;
		private string _PROJECT_TYPE;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;
		private string _TENDERER_CODE;
		private string _TENDERER_NAME;

		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get { return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SECTION_CODE
		{
			get { return _SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_CODE, _SECTION_CODE, value);
				this._SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_CODE
		{
			get { return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WIN_BIDDER_NAME
		{
			get { return _WIN_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_NAME, _WIN_BIDDER_NAME, value);
				this._WIN_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get { return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AMOUNT
		{
			get { return _AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.AMOUNT, _AMOUNT, value);
				this._AMOUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get { return _AREACODE; }
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
			get { return _AREANAME; }
			set
			{
				this.OnPropertyValueChange(_.AREANAME, _AREANAME, value);
				this._AREANAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_TYPE
		{
			get { return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get { return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get { return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_CODE
		{
			get { return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TENDERER_NAME
		{
			get { return _TENDERER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NAME, _TENDERER_NAME, value);
				this._TENDERER_NAME = value;
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
				_.M_TM,
				_.SECTION_CODE,
				_.PROJECT_CODE,
				_.WIN_BIDDER_NAME,
				_.NOTICE_SEND_TIME,
				_.AMOUNT,
				_.AREACODE,
				_.AREANAME,
				_.PROJECT_TYPE,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
				_.TENDERER_CODE,
				_.TENDERER_NAME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_TM,
				this._SECTION_CODE,
				this._PROJECT_CODE,
				this._WIN_BIDDER_NAME,
				this._NOTICE_SEND_TIME,
				this._AMOUNT,
				this._AREACODE,
				this._AREANAME,
				this._PROJECT_TYPE,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
				this._TENDERER_CODE,
				this._TENDERER_NAME,
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
			public readonly static Field All = new Field("*", "V_BIG_JG");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "V_BIG_JG", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "V_BIG_JG", "");
		}
		#endregion
	}
}