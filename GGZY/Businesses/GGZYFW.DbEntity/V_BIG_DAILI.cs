using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类V_BIG_DAILI。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_BIG_DAILI")]
	[Serializable]
	public partial class V_BIG_DAILI : FwEntity
	{
		#region Model
		private string _LEGAL_CODE;
		private DateTime? _M_TM;
		private string _QUYU;
		private string _TYPE;

		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_CODE
		{
			get { return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
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
		/// <summary>
		/// 
		/// </summary>
		public string QUYU
		{
			get { return _QUYU; }
			set
			{
				this.OnPropertyValueChange(_.QUYU, _QUYU, value);
				this._QUYU = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			get { return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
				_.LEGAL_CODE,
				_.M_TM,
				_.QUYU,
				_.TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LEGAL_CODE,
				this._M_TM,
				this._QUYU,
				this._TYPE,
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
			public readonly static Field All = new Field("*", "V_BIG_DAILI");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "V_BIG_DAILI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "V_BIG_DAILI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field QUYU = new Field("QUYU", "V_BIG_DAILI", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "V_BIG_DAILI", "");
		}
		#endregion
	}
}