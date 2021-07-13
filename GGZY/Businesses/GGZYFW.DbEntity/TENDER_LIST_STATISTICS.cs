using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类TENDER_LIST_STATISTICS。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TENDER_LIST_STATISTICS")]
	[Serializable]
	public partial class TENDER_LIST_STATISTICS : FwEntity
	{
		#region Model
		private string _TID;
		private string _BID_MANAGER;
		private string _PM_CODE;
		private decimal? _PCOUNT;
		private DateTime? _LASTTIME;
		private DateTime? _UPDATETIME;

		/// <summary>
		/// 
		/// </summary>
		public string TID
		{
			get { return _TID; }
			set
			{
				this.OnPropertyValueChange(_.TID, _TID, value);
				this._TID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BID_MANAGER
		{
			get { return _BID_MANAGER; }
			set
			{
				this.OnPropertyValueChange(_.BID_MANAGER, _BID_MANAGER, value);
				this._BID_MANAGER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PM_CODE
		{
			get { return _PM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PM_CODE, _PM_CODE, value);
				this._PM_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PCOUNT
		{
			get { return _PCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.PCOUNT, _PCOUNT, value);
				this._PCOUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LASTTIME
		{
			get { return _LASTTIME; }
			set
			{
				this.OnPropertyValueChange(_.LASTTIME, _LASTTIME, value);
				this._LASTTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATETIME
		{
			get { return _UPDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATETIME, _UPDATETIME, value);
				this._UPDATETIME = value;
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
				_.TID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TID,
				_.BID_MANAGER,
				_.PM_CODE,
				_.PCOUNT,
				_.LASTTIME,
				_.UPDATETIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TID,
				this._BID_MANAGER,
				this._PM_CODE,
				this._PCOUNT,
				this._LASTTIME,
				this._UPDATETIME,
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
			public readonly static Field All = new Field("*", "TENDER_LIST_STATISTICS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TID = new Field("TID", "TENDER_LIST_STATISTICS", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_MANAGER = new Field("BID_MANAGER", "TENDER_LIST_STATISTICS", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PM_CODE = new Field("PM_CODE", "TENDER_LIST_STATISTICS", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PCOUNT = new Field("PCOUNT", "TENDER_LIST_STATISTICS", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LASTTIME = new Field("LASTTIME", "TENDER_LIST_STATISTICS", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "TENDER_LIST_STATISTICS", "");
		}
		#endregion
	}
}