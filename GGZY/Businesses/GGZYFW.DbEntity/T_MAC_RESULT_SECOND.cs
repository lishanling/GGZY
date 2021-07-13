using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类T_MAC_RESULT_SECOND。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_MAC_RESULT_SECOND")]
	[Serializable]
	public partial class T_MAC_RESULT_SECOND : FwEntity
	{
		#region Model
		private string _SEID;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private decimal? _PCOUNT;
		private DateTime? _LASTTIME;
		private DateTime? _UPDATETIME;

		/// <summary>
		/// 
		/// </summary>
		public string SEID
		{
			get { return _SEID; }
			set
			{
				this.OnPropertyValueChange(_.SEID, _SEID, value);
				this._SEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BIDDER_NAME
		{
			get { return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get { return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
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
				_.SEID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SEID,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
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
				this._SEID,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
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
			public readonly static Field All = new Field("*", "T_MAC_RESULT_SECOND");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEID = new Field("SEID", "T_MAC_RESULT_SECOND", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "T_MAC_RESULT_SECOND", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "T_MAC_RESULT_SECOND", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PCOUNT = new Field("PCOUNT", "T_MAC_RESULT_SECOND", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LASTTIME = new Field("LASTTIME", "T_MAC_RESULT_SECOND", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_MAC_RESULT_SECOND", "");
		}
		#endregion
	}
}