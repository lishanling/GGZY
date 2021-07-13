using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_SUPERVISE_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_SUPERVISE_FEEDBACK")]
	[Serializable]
	public partial class T_SUPERVISE_FEEDBACK : JdEntity
	{
		#region Model
		private string _M_ID;
		private string _SUPERVISE_ID;
		private string _CONTENT;
		private string _OP_ID;
		private string _OP_NAME;
		private string _DEP_ID;
		private string _DEP_NAME;
		private string _OBJ;
		private string _OBJ_NAME;
		private string _OBJ_DEP_ID;
		private string _OBJDEP_NAME;
		private string _CODE;
		private string _ENTITY_ID;
		private string _ENTITY_TYPE_NAME;
		private string _FILES;
		private DateTime? _TIME;

		/// <summary>
		/// 主键
		/// </summary>
		public string M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 督查主键
		/// </summary>
		public string SUPERVISE_ID
		{
			get { return _SUPERVISE_ID; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_ID, _SUPERVISE_ID, value);
				this._SUPERVISE_ID = value;
			}
		}
		/// <summary>
		/// 反馈内容
		/// </summary>
		public string CONTENT
		{
			get { return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 督查人
		/// </summary>
		public string OP_ID
		{
			get { return _OP_ID; }
			set
			{
				this.OnPropertyValueChange(_.OP_ID, _OP_ID, value);
				this._OP_ID = value;
			}
		}
		/// <summary>
		/// 督查人员名称
		/// </summary>
		public string OP_NAME
		{
			get { return _OP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OP_NAME, _OP_NAME, value);
				this._OP_NAME = value;
			}
		}
		/// <summary>
		/// 督查人员部门id
		/// </summary>
		public string DEP_ID
		{
			get { return _DEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.DEP_ID, _DEP_ID, value);
				this._DEP_ID = value;
			}
		}
		/// <summary>
		/// 督查人员部门名称
		/// </summary>
		public string DEP_NAME
		{
			get { return _DEP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DEP_NAME, _DEP_NAME, value);
				this._DEP_NAME = value;
			}
		}
		/// <summary>
		/// 督查对象
		/// </summary>
		public string OBJ
		{
			get { return _OBJ; }
			set
			{
				this.OnPropertyValueChange(_.OBJ, _OBJ, value);
				this._OBJ = value;
			}
		}
		/// <summary>
		/// 督查对象名称
		/// </summary>
		public string OBJ_NAME
		{
			get { return _OBJ_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OBJ_NAME, _OBJ_NAME, value);
				this._OBJ_NAME = value;
			}
		}
		/// <summary>
		/// 督查对象部门id
		/// </summary>
		public string OBJ_DEP_ID
		{
			get { return _OBJ_DEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.OBJ_DEP_ID, _OBJ_DEP_ID, value);
				this._OBJ_DEP_ID = value;
			}
		}
		/// <summary>
		/// 督查对象部门名称
		/// </summary>
		public string OBJDEP_NAME
		{
			get { return _OBJDEP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OBJDEP_NAME, _OBJDEP_NAME, value);
				this._OBJDEP_NAME = value;
			}
		}
		/// <summary>
		/// 督查码
		/// </summary>
		public string CODE
		{
			get { return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 实体主键
		/// </summary>
		public string ENTITY_ID
		{
			get { return _ENTITY_ID; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_ID, _ENTITY_ID, value);
				this._ENTITY_ID = value;
			}
		}
		/// <summary>
		/// 实体对象名称T_AFC_PROJECT PT_ZXTS
		/// </summary>
		public string ENTITY_TYPE_NAME
		{
			get { return _ENTITY_TYPE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TYPE_NAME, _ENTITY_TYPE_NAME, value);
				this._ENTITY_TYPE_NAME = value;
			}
		}
		/// <summary>
		/// 反馈附件
		/// </summary>
		public string FILES
		{
			get { return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 反馈时间
		/// </summary>
		public DateTime? TIME
		{
			get { return _TIME; }
			set
			{
				this.OnPropertyValueChange(_.TIME, _TIME, value);
				this._TIME = value;
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
				_.M_ID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.M_ID,
				_.SUPERVISE_ID,
				_.CONTENT,
				_.OP_ID,
				_.OP_NAME,
				_.DEP_ID,
				_.DEP_NAME,
				_.OBJ,
				_.OBJ_NAME,
				_.OBJ_DEP_ID,
				_.OBJDEP_NAME,
				_.CODE,
				_.ENTITY_ID,
				_.ENTITY_TYPE_NAME,
				_.FILES,
				_.TIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._SUPERVISE_ID,
				this._CONTENT,
				this._OP_ID,
				this._OP_NAME,
				this._DEP_ID,
				this._DEP_NAME,
				this._OBJ,
				this._OBJ_NAME,
				this._OBJ_DEP_ID,
				this._OBJDEP_NAME,
				this._CODE,
				this._ENTITY_ID,
				this._ENTITY_TYPE_NAME,
				this._FILES,
				this._TIME,
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
			public readonly static Field All = new Field("*", "T_SUPERVISE_FEEDBACK");
			/// <summary>
			/// 主键
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_SUPERVISE_FEEDBACK", "主键");
			/// <summary>
			/// 督查主键
			/// </summary>
			public readonly static Field SUPERVISE_ID = new Field("SUPERVISE_ID", "T_SUPERVISE_FEEDBACK", "督查主键");
			/// <summary>
			/// 反馈内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_SUPERVISE_FEEDBACK", "反馈内容");
			/// <summary>
			/// 督查人
			/// </summary>
			public readonly static Field OP_ID = new Field("OP_ID", "T_SUPERVISE_FEEDBACK", "督查人");
			/// <summary>
			/// 督查人员名称
			/// </summary>
			public readonly static Field OP_NAME = new Field("OP_NAME", "T_SUPERVISE_FEEDBACK", "督查人员名称");
			/// <summary>
			/// 督查人员部门id
			/// </summary>
			public readonly static Field DEP_ID = new Field("DEP_ID", "T_SUPERVISE_FEEDBACK", "督查人员部门id");
			/// <summary>
			/// 督查人员部门名称
			/// </summary>
			public readonly static Field DEP_NAME = new Field("DEP_NAME", "T_SUPERVISE_FEEDBACK", "督查人员部门名称");
			/// <summary>
			/// 督查对象
			/// </summary>
			public readonly static Field OBJ = new Field("OBJ", "T_SUPERVISE_FEEDBACK", "督查对象");
			/// <summary>
			/// 督查对象名称
			/// </summary>
			public readonly static Field OBJ_NAME = new Field("OBJ_NAME", "T_SUPERVISE_FEEDBACK", "督查对象名称");
			/// <summary>
			/// 督查对象部门id
			/// </summary>
			public readonly static Field OBJ_DEP_ID = new Field("OBJ_DEP_ID", "T_SUPERVISE_FEEDBACK", "督查对象部门id");
			/// <summary>
			/// 督查对象部门名称
			/// </summary>
			public readonly static Field OBJDEP_NAME = new Field("OBJDEP_NAME", "T_SUPERVISE_FEEDBACK", "督查对象部门名称");
			/// <summary>
			/// 督查码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_SUPERVISE_FEEDBACK", "督查码");
			/// <summary>
			/// 实体主键
			/// </summary>
			public readonly static Field ENTITY_ID = new Field("ENTITY_ID", "T_SUPERVISE_FEEDBACK", "实体主键");
			/// <summary>
			/// 实体对象名称T_AFC_PROJECT PT_ZXTS
			/// </summary>
			public readonly static Field ENTITY_TYPE_NAME = new Field("ENTITY_TYPE_NAME", "T_SUPERVISE_FEEDBACK", "实体对象名称T_AFC_PROJECT PT_ZXTS");
			/// <summary>
			/// 反馈附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "T_SUPERVISE_FEEDBACK", "反馈附件");
			/// <summary>
			/// 反馈时间
			/// </summary>
			public readonly static Field TIME = new Field("TIME", "T_SUPERVISE_FEEDBACK", "反馈时间");
		}
		#endregion
	}
}