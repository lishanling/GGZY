using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类V_YDPB_APPLY_TRADE。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_YDPB_APPLY_TRADE")]
	[Serializable]
	public partial class V_YDPB_APPLY_TRADE : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _SERIES_NUMBER;
		private decimal? _IS_MAIN;
		private DateTime? _BID_EVAL_START_TIME;
		private DateTime? _BID_EVAL_END_TIME;
		private decimal? _EXPERT_COUNT;
		private decimal? _STATUS;
		private decimal? _EVAL_STATUS;
		private DateTime? _CREATE_TIME;
		private string _AREA_CODE;
		private string _CENTER_NAME;
		private decimal? _FLAG;
		private decimal? _APPLY_TYPE;
		private decimal? _APPLY_STATUS;
		private decimal? _IS_EVAL_EXPERT;
		private decimal? _APPLY_IS_EVAL_EXPERT;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SERIES_NUMBER
		{
			get { return _SERIES_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SERIES_NUMBER, _SERIES_NUMBER, value);
				this._SERIES_NUMBER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_MAIN
		{
			get { return _IS_MAIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_MAIN, _IS_MAIN, value);
				this._IS_MAIN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BID_EVAL_START_TIME
		{
			get { return _BID_EVAL_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVAL_START_TIME, _BID_EVAL_START_TIME, value);
				this._BID_EVAL_START_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BID_EVAL_END_TIME
		{
			get { return _BID_EVAL_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVAL_END_TIME, _BID_EVAL_END_TIME, value);
				this._BID_EVAL_END_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EXPERT_COUNT
		{
			get { return _EXPERT_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_COUNT, _EXPERT_COUNT, value);
				this._EXPERT_COUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? STATUS
		{
			get { return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EVAL_STATUS
		{
			get { return _EVAL_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_STATUS, _EVAL_STATUS, value);
				this._EVAL_STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREA_CODE
		{
			get { return _AREA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AREA_CODE, _AREA_CODE, value);
				this._AREA_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CENTER_NAME
		{
			get { return _CENTER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CENTER_NAME, _CENTER_NAME, value);
				this._CENTER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FLAG
		{
			get { return _FLAG; }
			set
			{
				this.OnPropertyValueChange(_.FLAG, _FLAG, value);
				this._FLAG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? APPLY_TYPE
		{
			get { return _APPLY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_TYPE, _APPLY_TYPE, value);
				this._APPLY_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? APPLY_STATUS
		{
			get { return _APPLY_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_STATUS, _APPLY_STATUS, value);
				this._APPLY_STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_EVAL_EXPERT
		{
			get { return _IS_EVAL_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.IS_EVAL_EXPERT, _IS_EVAL_EXPERT, value);
				this._IS_EVAL_EXPERT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? APPLY_IS_EVAL_EXPERT
		{
			get { return _APPLY_IS_EVAL_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_IS_EVAL_EXPERT, _APPLY_IS_EVAL_EXPERT, value);
				this._APPLY_IS_EVAL_EXPERT = value;
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
				_.SERIES_NUMBER,
				_.IS_MAIN,
				_.BID_EVAL_START_TIME,
				_.BID_EVAL_END_TIME,
				_.EXPERT_COUNT,
				_.STATUS,
				_.EVAL_STATUS,
				_.CREATE_TIME,
				_.AREA_CODE,
				_.CENTER_NAME,
				_.FLAG,
				_.APPLY_TYPE,
				_.APPLY_STATUS,
				_.IS_EVAL_EXPERT,
				_.APPLY_IS_EVAL_EXPERT,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._SERIES_NUMBER,
				this._IS_MAIN,
				this._BID_EVAL_START_TIME,
				this._BID_EVAL_END_TIME,
				this._EXPERT_COUNT,
				this._STATUS,
				this._EVAL_STATUS,
				this._CREATE_TIME,
				this._AREA_CODE,
				this._CENTER_NAME,
				this._FLAG,
				this._APPLY_TYPE,
				this._APPLY_STATUS,
				this._IS_EVAL_EXPERT,
				this._APPLY_IS_EVAL_EXPERT,
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
			public readonly static Field All = new Field("*", "V_YDPB_APPLY_TRADE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SERIES_NUMBER = new Field("SERIES_NUMBER", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_MAIN = new Field("IS_MAIN", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_EVAL_START_TIME = new Field("BID_EVAL_START_TIME", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_EVAL_END_TIME = new Field("BID_EVAL_END_TIME", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EXPERT_COUNT = new Field("EXPERT_COUNT", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EVAL_STATUS = new Field("EVAL_STATUS", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FLAG = new Field("FLAG", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_STATUS = new Field("APPLY_STATUS", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_EVAL_EXPERT = new Field("IS_EVAL_EXPERT", "V_YDPB_APPLY_TRADE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_IS_EVAL_EXPERT = new Field("APPLY_IS_EVAL_EXPERT", "V_YDPB_APPLY_TRADE", "");
		}
		#endregion
	}
}