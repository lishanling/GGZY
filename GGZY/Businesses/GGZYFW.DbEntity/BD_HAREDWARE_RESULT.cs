using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BD_HAREDWARE_RESULT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_HAREDWARE_RESULT")]
	[Serializable]
	public partial class BD_HAREDWARE_RESULT : FwEntity
	{
		#region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _CPU_ID;
		private string _HARD_DISK_SERIAL_NUMBER;
		private string _MAC_ADDRESS;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private DateTime? _M_TM;

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
		/// <summary>
		/// 
		/// </summary>
		public string BID_SECTION_CODE
		{
			get { return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
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
		public string HARD_DISK_SERIAL_NUMBER
		{
			get { return _HARD_DISK_SERIAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.HARD_DISK_SERIAL_NUMBER, _HARD_DISK_SERIAL_NUMBER, value);
				this._HARD_DISK_SERIAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAC_ADDRESS
		{
			get { return _MAC_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.MAC_ADDRESS, _MAC_ADDRESS, value);
				this._MAC_ADDRESS = value;
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
		public DateTime? M_TM
		{
			get { return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.CPU_ID,
				_.HARD_DISK_SERIAL_NUMBER,
				_.MAC_ADDRESS,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
				_.M_TM,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._CPU_ID,
				this._HARD_DISK_SERIAL_NUMBER,
				this._MAC_ADDRESS,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
				this._M_TM,
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
			public readonly static Field All = new Field("*", "BD_HAREDWARE_RESULT");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HARD_DISK_SERIAL_NUMBER = new Field("HARD_DISK_SERIAL_NUMBER", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MAC_ADDRESS = new Field("MAC_ADDRESS", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "BD_HAREDWARE_RESULT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BD_HAREDWARE_RESULT", "");
		}
		#endregion
	}
}