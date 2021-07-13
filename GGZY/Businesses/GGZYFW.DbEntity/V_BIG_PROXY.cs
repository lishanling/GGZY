using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类V_BIG_PROXY。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_BIG_PROXY")]
	[Serializable]
	public partial class V_BIG_PROXY : FwEntity
	{
		#region Model
		private DateTime? _M_TM;
		private string _SECTION_CODE;
		private string _PROJECT_CODE;
		private decimal? _AMOUNT;
		private string _AREACODE;
		private string _AREANAME;
		private string _PROJECT_TYPE;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;

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
				_.AMOUNT,
				_.AREACODE,
				_.AREANAME,
				_.PROJECT_TYPE,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
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
				this._AMOUNT,
				this._AREACODE,
				this._AREANAME,
				this._PROJECT_TYPE,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
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
			public readonly static Field All = new Field("*", "V_BIG_PROXY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREANAME = new Field("AREANAME", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "V_BIG_PROXY", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "V_BIG_PROXY", "");
		}
		#endregion
	}
}