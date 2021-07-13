using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_SUPERVISE。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_SUPERVISE")]
	[Serializable]
	public partial class T_SUPERVISE : JdEntity
	{
		#region Model
		private string _M_ID;
		private string _NAME;
		private string _CONTENT;
		private string _FILES;
		private DateTime? _TIME;
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
		private decimal? _STATUS;
		private string _REGION_CODE;
		private string _TENDER_PROJECT_TYPE;
		private string _ENTITY_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;

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
		/// 督查标题
		/// </summary>
		public string NAME
		{
			get { return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 督查内容
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
		/// 督查附件
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
		/// 督查时间
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
		/// 实体对象主键
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
		/// 状态
		/// </summary>
		public decimal? STATUS
		{
			get { return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 归属地
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
		/// 行业
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get { return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 实体对象名称
		/// </summary>
		public string ENTITY_NAME
		{
			get { return _ENTITY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_NAME, _ENTITY_NAME, value);
				this._ENTITY_NAME = value;
			}
		}
		/// <summary>
		/// 招标项目编号
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
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get { return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
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
				_.NAME,
				_.CONTENT,
				_.FILES,
				_.TIME,
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
				_.STATUS,
				_.REGION_CODE,
				_.TENDER_PROJECT_TYPE,
				_.ENTITY_NAME,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._NAME,
				this._CONTENT,
				this._FILES,
				this._TIME,
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
				this._STATUS,
				this._REGION_CODE,
				this._TENDER_PROJECT_TYPE,
				this._ENTITY_NAME,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
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
			public readonly static Field All = new Field("*", "T_SUPERVISE");
			/// <summary>
			/// 主键
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_SUPERVISE", "主键");
			/// <summary>
			/// 督查标题
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_SUPERVISE", "督查标题");
			/// <summary>
			/// 督查内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_SUPERVISE", "督查内容");
			/// <summary>
			/// 督查附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "T_SUPERVISE", "督查附件");
			/// <summary>
			/// 督查时间
			/// </summary>
			public readonly static Field TIME = new Field("TIME", "T_SUPERVISE", "督查时间");
			/// <summary>
			/// 督查人
			/// </summary>
			public readonly static Field OP_ID = new Field("OP_ID", "T_SUPERVISE", "督查人");
			/// <summary>
			/// 督查人员名称
			/// </summary>
			public readonly static Field OP_NAME = new Field("OP_NAME", "T_SUPERVISE", "督查人员名称");
			/// <summary>
			/// 督查人员部门id
			/// </summary>
			public readonly static Field DEP_ID = new Field("DEP_ID", "T_SUPERVISE", "督查人员部门id");
			/// <summary>
			/// 督查人员部门名称
			/// </summary>
			public readonly static Field DEP_NAME = new Field("DEP_NAME", "T_SUPERVISE", "督查人员部门名称");
			/// <summary>
			/// 督查对象
			/// </summary>
			public readonly static Field OBJ = new Field("OBJ", "T_SUPERVISE", "督查对象");
			/// <summary>
			/// 督查对象名称
			/// </summary>
			public readonly static Field OBJ_NAME = new Field("OBJ_NAME", "T_SUPERVISE", "督查对象名称");
			/// <summary>
			/// 督查对象部门id
			/// </summary>
			public readonly static Field OBJ_DEP_ID = new Field("OBJ_DEP_ID", "T_SUPERVISE", "督查对象部门id");
			/// <summary>
			/// 督查对象部门名称
			/// </summary>
			public readonly static Field OBJDEP_NAME = new Field("OBJDEP_NAME", "T_SUPERVISE", "督查对象部门名称");
			/// <summary>
			/// 督查码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_SUPERVISE", "督查码");
			/// <summary>
			/// 实体对象主键
			/// </summary>
			public readonly static Field ENTITY_ID = new Field("ENTITY_ID", "T_SUPERVISE", "实体对象主键");
			/// <summary>
			/// 实体对象名称T_AFC_PROJECT PT_ZXTS
			/// </summary>
			public readonly static Field ENTITY_TYPE_NAME = new Field("ENTITY_TYPE_NAME", "T_SUPERVISE", "实体对象名称T_AFC_PROJECT PT_ZXTS");
			/// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_SUPERVISE", "状态");
			/// <summary>
			/// 归属地
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_SUPERVISE", "归属地");
			/// <summary>
			/// 行业
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "T_SUPERVISE", "行业");
			/// <summary>
			/// 实体对象名称
			/// </summary>
			public readonly static Field ENTITY_NAME = new Field("ENTITY_NAME", "T_SUPERVISE", "实体对象名称");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_SUPERVISE", "招标项目编号");
			/// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "T_SUPERVISE", "招标项目名称");
		}
		#endregion
	}
}