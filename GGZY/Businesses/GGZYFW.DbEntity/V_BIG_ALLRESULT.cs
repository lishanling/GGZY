using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类V_BIG_ALLRESULT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_BIG_ALLRESULT")]
	[Serializable]
	public partial class V_BIG_ALLRESULT : FwEntity
	{
		#region Model
		private string _TYPE;
		private DateTime? _M_TM;
		private string _SECTION_CODE;
		private string _PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private decimal? _AMOUNT;
		private string _AREACODE;
		private string _AREANAME;
		private string _KIND;
		private string _M_TABLE;
		private string _EVALUATION_RESULT;
		private decimal? _RECKON_AMOUNT;
		private string _PROJECT_TYPE;
		private string _TENDER_MODE;
		private string _ORGANIZE_FORM;
		private string _BULLETIN_TYPE;
		private decimal? _LISTING_TYPE;
		private string _IN_BUY_KIND;

		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			get { return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
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
		public string UNIFIED_DEAL_CODE
		{
			get { return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
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
		public string KIND
		{
			get { return _KIND; }
			set
			{
				this.OnPropertyValueChange(_.KIND, _KIND, value);
				this._KIND = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_TABLE
		{
			get { return _M_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.M_TABLE, _M_TABLE, value);
				this._M_TABLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EVALUATION_RESULT
		{
			get { return _EVALUATION_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_RESULT, _EVALUATION_RESULT, value);
				this._EVALUATION_RESULT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RECKON_AMOUNT
		{
			get { return _RECKON_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.RECKON_AMOUNT, _RECKON_AMOUNT, value);
				this._RECKON_AMOUNT = value;
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
		public string TENDER_MODE
		{
			get { return _TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
				this._TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORGANIZE_FORM
		{
			get { return _ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.ORGANIZE_FORM, _ORGANIZE_FORM, value);
				this._ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULLETIN_TYPE
		{
			get { return _BULLETIN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_TYPE, _BULLETIN_TYPE, value);
				this._BULLETIN_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LISTING_TYPE
		{
			get { return _LISTING_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LISTING_TYPE, _LISTING_TYPE, value);
				this._LISTING_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_BUY_KIND
		{
			get { return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
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
				_.TYPE,
				_.M_TM,
				_.SECTION_CODE,
				_.PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.AMOUNT,
				_.AREACODE,
				_.AREANAME,
				_.KIND,
				_.M_TABLE,
				_.EVALUATION_RESULT,
				_.RECKON_AMOUNT,
				_.PROJECT_TYPE,
				_.TENDER_MODE,
				_.ORGANIZE_FORM,
				_.BULLETIN_TYPE,
				_.LISTING_TYPE,
				_.IN_BUY_KIND,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TYPE,
				this._M_TM,
				this._SECTION_CODE,
				this._PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._AMOUNT,
				this._AREACODE,
				this._AREANAME,
				this._KIND,
				this._M_TABLE,
				this._EVALUATION_RESULT,
				this._RECKON_AMOUNT,
				this._PROJECT_TYPE,
				this._TENDER_MODE,
				this._ORGANIZE_FORM,
				this._BULLETIN_TYPE,
				this._LISTING_TYPE,
				this._IN_BUY_KIND,
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
			public readonly static Field All = new Field("*", "V_BIG_ALLRESULT");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TABLE = new Field("M_TABLE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EVALUATION_RESULT = new Field("EVALUATION_RESULT", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RECKON_AMOUNT = new Field("RECKON_AMOUNT", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ORGANIZE_FORM = new Field("ORGANIZE_FORM", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BULLETIN_TYPE = new Field("BULLETIN_TYPE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LISTING_TYPE = new Field("LISTING_TYPE", "V_BIG_ALLRESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "V_BIG_ALLRESULT", "");
		}
		#endregion
	}
}