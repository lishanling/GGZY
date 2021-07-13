using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类V_YDPB_ROOM_SEAT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_YDPB_ROOM_SEAT")]
	[Serializable]
	public partial class V_YDPB_ROOM_SEAT : JdEntity
	{
		#region Model
		private decimal? _SEATID;
		private decimal? _APPLY_ID;
		private string _AREA_CODE;
		private string _CENTER_NAME;
		private decimal? _ROOMID;
		private string _EVAL_ROOM_NAME;
		private string _SEAT_NUMBER;
		private DateTime? _START_TIME;
		private DateTime? _END_TIME;
		private DateTime? _EVAL_DATE;

		/// <summary>
		/// 
		/// </summary>
		public decimal? SEATID
		{
			get { return _SEATID; }
			set
			{
				this.OnPropertyValueChange(_.SEATID, _SEATID, value);
				this._SEATID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? APPLY_ID
		{
			get { return _APPLY_ID; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_ID, _APPLY_ID, value);
				this._APPLY_ID = value;
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
		public decimal? ROOMID
		{
			get { return _ROOMID; }
			set
			{
				this.OnPropertyValueChange(_.ROOMID, _ROOMID, value);
				this._ROOMID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EVAL_ROOM_NAME
		{
			get { return _EVAL_ROOM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_ROOM_NAME, _EVAL_ROOM_NAME, value);
				this._EVAL_ROOM_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEAT_NUMBER
		{
			get { return _SEAT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SEAT_NUMBER, _SEAT_NUMBER, value);
				this._SEAT_NUMBER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? START_TIME
		{
			get { return _START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.START_TIME, _START_TIME, value);
				this._START_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? END_TIME
		{
			get { return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EVAL_DATE
		{
			get { return _EVAL_DATE; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_DATE, _EVAL_DATE, value);
				this._EVAL_DATE = value;
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
				_.SEATID,
				_.APPLY_ID,
				_.AREA_CODE,
				_.CENTER_NAME,
				_.ROOMID,
				_.EVAL_ROOM_NAME,
				_.SEAT_NUMBER,
				_.START_TIME,
				_.END_TIME,
				_.EVAL_DATE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SEATID,
				this._APPLY_ID,
				this._AREA_CODE,
				this._CENTER_NAME,
				this._ROOMID,
				this._EVAL_ROOM_NAME,
				this._SEAT_NUMBER,
				this._START_TIME,
				this._END_TIME,
				this._EVAL_DATE,
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
			public readonly static Field All = new Field("*", "V_YDPB_ROOM_SEAT");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEATID = new Field("SEATID", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APPLY_ID = new Field("APPLY_ID", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ROOMID = new Field("ROOMID", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EVAL_ROOM_NAME = new Field("EVAL_ROOM_NAME", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEAT_NUMBER = new Field("SEAT_NUMBER", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field START_TIME = new Field("START_TIME", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "V_YDPB_ROOM_SEAT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EVAL_DATE = new Field("EVAL_DATE", "V_YDPB_ROOM_SEAT", "");
		}
		#endregion
	}
}