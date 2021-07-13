using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_USER_BIND_ACCOUNT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_USER_BIND_ACCOUNT")]
	[Serializable]
	public partial class T_USER_BIND_ACCOUNT : JdEntity
	{
		#region Model
		private string _ID;
		private string _CREDIT_CODE;
		private int _MAIN_U_ID;
		private int _CHILD_U_ID;
		private string _REMARK;

		/// <summary>
		/// 唯一标识
		/// </summary>
		public string ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 统一社会信用代码
		/// </summary>
		public string CREDIT_CODE
		{
			get { return _CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_CODE, _CREDIT_CODE, value);
				this._CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 主账号
		/// </summary>
		public int MAIN_U_ID
		{
			get { return _MAIN_U_ID; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_U_ID, _MAIN_U_ID, value);
				this._MAIN_U_ID = value;
			}
		}
		/// <summary>
		/// 子账号
		/// </summary>
		public int CHILD_U_ID
		{
			get { return _CHILD_U_ID; }
			set
			{
				this.OnPropertyValueChange(_.CHILD_U_ID, _CHILD_U_ID, value);
				this._CHILD_U_ID = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get { return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.CREDIT_CODE,
				_.MAIN_U_ID,
				_.CHILD_U_ID,
				_.REMARK,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._CREDIT_CODE,
				this._MAIN_U_ID,
				this._CHILD_U_ID,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "T_USER_BIND_ACCOUNT");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_BIND_ACCOUNT", "唯一标识");
			/// <summary>
			/// 统一社会信用代码
			/// </summary>
			public readonly static Field CREDIT_CODE = new Field("CREDIT_CODE", "T_USER_BIND_ACCOUNT", "统一社会信用代码");
			/// <summary>
			/// 主账号
			/// </summary>
			public readonly static Field MAIN_U_ID = new Field("MAIN_U_ID", "T_USER_BIND_ACCOUNT", "主账号");
			/// <summary>
			/// 子账号
			/// </summary>
			public readonly static Field CHILD_U_ID = new Field("CHILD_U_ID", "T_USER_BIND_ACCOUNT", "子账号");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_USER_BIND_ACCOUNT", "备注");
		}
		#endregion
	}
}