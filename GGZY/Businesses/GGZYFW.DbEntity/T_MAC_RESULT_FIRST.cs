using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类T_MAC_RESULT_FIRST。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_MAC_RESULT_FIRST")]
	[Serializable]
	public partial class T_MAC_RESULT_FIRST : FwEntity
	{
		#region Model
		private string _FID;
		private string _CPU_ID;
		private string _HDISK;
		private string _MAC;
		private decimal? _PCOUNT;
		private DateTime? _LASTTIME;
		private DateTime? _UPDATETIME;

		/// <summary>
		/// 
		/// </summary>
		public string FID
		{
			get { return _FID; }
			set
			{
				this.OnPropertyValueChange(_.FID, _FID, value);
				this._FID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPU_ID
		{
			get { return _CPU_ID; }
			set
			{
				this.OnPropertyValueChange(_.CPU_ID, _CPU_ID, value);
				this._CPU_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HDISK
		{
			get { return _HDISK; }
			set
			{
				this.OnPropertyValueChange(_.HDISK, _HDISK, value);
				this._HDISK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAC
		{
			get { return _MAC; }
			set
			{
				this.OnPropertyValueChange(_.MAC, _MAC, value);
				this._MAC = value;
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
				_.FID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.FID,
				_.CPU_ID,
				_.HDISK,
				_.MAC,
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
				this._FID,
				this._CPU_ID,
				this._HDISK,
				this._MAC,
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
			public readonly static Field All = new Field("*", "T_MAC_RESULT_FIRST");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FID = new Field("FID", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HDISK = new Field("HDISK", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MAC = new Field("MAC", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PCOUNT = new Field("PCOUNT", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LASTTIME = new Field("LASTTIME", "T_MAC_RESULT_FIRST", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_MAC_RESULT_FIRST", "");
		}
		#endregion
	}
}