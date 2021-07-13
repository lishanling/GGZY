using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BD_HARDWARE_MULTI。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_HARDWARE_MULTI")]
	[Serializable]
	public partial class BD_HARDWARE_MULTI : FwEntity
	{
		#region Model
		private decimal? _ID;
		private string _CPU_ID;
		private string _MAC_ADDRESS;
		private string _HARD_DISK_SERIAL_NUMBER;

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
		public string HARD_DISK_SERIAL_NUMBER
		{
			get { return _HARD_DISK_SERIAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.HARD_DISK_SERIAL_NUMBER, _HARD_DISK_SERIAL_NUMBER, value);
				this._HARD_DISK_SERIAL_NUMBER = value;
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
				_.CPU_ID,
				_.MAC_ADDRESS,
				_.HARD_DISK_SERIAL_NUMBER,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._CPU_ID,
				this._MAC_ADDRESS,
				this._HARD_DISK_SERIAL_NUMBER,
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
			public readonly static Field All = new Field("*", "BD_HARDWARE_MULTI");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_HARDWARE_MULTI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPU_ID = new Field("CPU_ID", "BD_HARDWARE_MULTI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MAC_ADDRESS = new Field("MAC_ADDRESS", "BD_HARDWARE_MULTI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HARD_DISK_SERIAL_NUMBER = new Field("HARD_DISK_SERIAL_NUMBER", "BD_HARDWARE_MULTI", "");
		}
		#endregion
	}
}