using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类T_MAC。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_MAC")]
	[Serializable]
	public partial class T_MAC : FwEntity
	{
		#region Model
		private string _MID;
		private decimal? _INFO_ID;
		private string _CPU_ID;
		private string _HDISK;
		private string _BIDDER_NAME;
		private string _MAC;
		private string _BIDDER_ORG_CODE;
		private DateTime? _TI;
		private decimal? _SOURCETYPE;
		private DateTime? _UPDATETIME;
		private string _TENDER_PROJECT_CODE;

		/// <summary>
		/// 
		/// </summary>
		public string MID
		{
			get { return _MID; }
			set
			{
				this.OnPropertyValueChange(_.MID, _MID, value);
				this._MID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INFO_ID
		{
			get { return _INFO_ID; }
			set
			{
				this.OnPropertyValueChange(_.INFO_ID, _INFO_ID, value);
				this._INFO_ID = value;
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
		public DateTime? TI
		{
			get { return _TI; }
			set
			{
				this.OnPropertyValueChange(_.TI, _TI, value);
				this._TI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SOURCETYPE
		{
			get { return _SOURCETYPE; }
			set
			{
				this.OnPropertyValueChange(_.SOURCETYPE, _SOURCETYPE, value);
				this._SOURCETYPE = value;
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
		/// <summary>
		/// 
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get { return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
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
				_.MID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MID,
				_.INFO_ID,
				_.CPU_ID,
				_.HDISK,
				_.BIDDER_NAME,
				_.MAC,
				_.BIDDER_ORG_CODE,
				_.TI,
				_.SOURCETYPE,
				_.UPDATETIME,
				_.TENDER_PROJECT_CODE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MID,
				this._INFO_ID,
				this._CPU_ID,
				this._HDISK,
				this._BIDDER_NAME,
				this._MAC,
				this._BIDDER_ORG_CODE,
				this._TI,
				this._SOURCETYPE,
				this._UPDATETIME,
				this._TENDER_PROJECT_CODE,
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
			public readonly static Field All = new Field("*", "T_MAC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MID = new Field("MID", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field INFO_ID = new Field("INFO_ID", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HDISK = new Field("HDISK", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MAC = new Field("MAC", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TI = new Field("TI", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SOURCETYPE = new Field("SOURCETYPE", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_MAC", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_MAC", "");
		}
		#endregion
	}
}