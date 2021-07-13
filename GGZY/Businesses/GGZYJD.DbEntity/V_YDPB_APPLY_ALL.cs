using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类V_YDPB_APPLY_ALL。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_YDPB_APPLY_ALL")]
	[Serializable]
	public partial class V_YDPB_APPLY_ALL : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _SERIES_NUMBER;
		private decimal? _APPLY_TYPE;
		private string _APPLY_STEP;
		private decimal? _STATE;
		private decimal? _STATUS;
		private DateTime? _BID_EVAL_START_TIME;
		private DateTime? _BID_EVAL_END_TIME;
		private string _CENTER_NAME;
		private decimal? _FLAG;
		private decimal? _CREATOR_ID;
		private DateTime? _CREATE_TIME;
		private decimal? _EXPERT_COUNT;

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
		public string APPLY_STEP
		{
			get { return _APPLY_STEP; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_STEP, _APPLY_STEP, value);
				this._APPLY_STEP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? STATE
		{
			get { return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
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
		public decimal? CREATOR_ID
		{
			get { return _CREATOR_ID; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR_ID, _CREATOR_ID, value);
				this._CREATOR_ID = value;
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
		public decimal? EXPERT_COUNT
		{
			get { return _EXPERT_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_COUNT, _EXPERT_COUNT, value);
				this._EXPERT_COUNT = value;
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
				_.APPLY_TYPE,
				_.APPLY_STEP,
				_.STATE,
				_.STATUS,
				_.BID_EVAL_START_TIME,
				_.BID_EVAL_END_TIME,
				_.CENTER_NAME,
				_.FLAG,
				_.CREATOR_ID,
				_.CREATE_TIME,
				_.EXPERT_COUNT,
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
				this._APPLY_TYPE,
				this._APPLY_STEP,
				this._STATE,
				this._STATUS,
				this._BID_EVAL_START_TIME,
				this._BID_EVAL_END_TIME,
				this._CENTER_NAME,
				this._FLAG,
				this._CREATOR_ID,
				this._CREATE_TIME,
				this._EXPERT_COUNT,
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
			public readonly static Field All = new Field("*", "V_YDPB_APPLY_ALL");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SERIES_NUMBER = new Field("SERIES_NUMBER", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_STEP = new Field("APPLY_STEP", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_EVAL_START_TIME = new Field("BID_EVAL_START_TIME", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_EVAL_END_TIME = new Field("BID_EVAL_END_TIME", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FLAG = new Field("FLAG", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "V_YDPB_APPLY_ALL", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EXPERT_COUNT = new Field("EXPERT_COUNT", "V_YDPB_APPLY_ALL", "");
		}
		#endregion
	}
}