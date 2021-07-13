using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类V_BIG_LEGAL_BASE。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("V_BIG_LEGAL_BASE")]
	[Serializable]
	public partial class V_BIG_LEGAL_BASE : FwEntity
	{
		#region Model
		private string _LEGAL_CODE;
		private string _LEGAL_NAME;
		private string _REGION_CODE;
		private string _LEGAL_ROLE;
		private string _LEGAL_CONTACT_PHONE;
		private string _LEGAL_CONTACT;

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
		public string LEGAL_NAME
		{
			get { return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REGION_CODE
		{
			get { return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_ROLE
		{
			get { return _LEGAL_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_ROLE, _LEGAL_ROLE, value);
				this._LEGAL_ROLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_CONTACT_PHONE
		{
			get { return _LEGAL_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CONTACT_PHONE, _LEGAL_CONTACT_PHONE, value);
				this._LEGAL_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_CONTACT
		{
			get { return _LEGAL_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CONTACT, _LEGAL_CONTACT, value);
				this._LEGAL_CONTACT = value;
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
				_.LEGAL_NAME,
				_.REGION_CODE,
				_.LEGAL_ROLE,
				_.LEGAL_CONTACT_PHONE,
				_.LEGAL_CONTACT,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LEGAL_CODE,
				this._LEGAL_NAME,
				this._REGION_CODE,
				this._LEGAL_ROLE,
				this._LEGAL_CONTACT_PHONE,
				this._LEGAL_CONTACT,
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
			public readonly static Field All = new Field("*", "V_BIG_LEGAL_BASE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "V_BIG_LEGAL_BASE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "V_BIG_LEGAL_BASE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "V_BIG_LEGAL_BASE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_ROLE = new Field("LEGAL_ROLE", "V_BIG_LEGAL_BASE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_CONTACT_PHONE = new Field("LEGAL_CONTACT_PHONE", "V_BIG_LEGAL_BASE", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_CONTACT = new Field("LEGAL_CONTACT", "V_BIG_LEGAL_BASE", "");
		}
		#endregion
	}
}