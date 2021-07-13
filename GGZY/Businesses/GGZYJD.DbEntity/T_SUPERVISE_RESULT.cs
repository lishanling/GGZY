using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_SUPERVISE_RESULT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_SUPERVISE_RESULT")]
	[Serializable]
	public partial class T_SUPERVISE_RESULT : JdEntity
	{
		#region Model
		private string _M_ID;
		private string _ENTITY_TYPE_NAME;
		private decimal? _STATUS;
		private string _SUPERVISE_NAME;
		private string _SUPERVISE_TYPE;
		private string _SUPERVISE_WAY;
		private DateTime? _SUPERVISE_TIME;
		private string _SUPERVISE_RULE;
		private DateTime? _ENTITY_SUBMIT_TIME;
		private DateTime? _ENTITY_HANDLE_TIME;
		private string _SUPERVISE_OP_ID;
		private string _SUPERVISE_OP_NAME;
		private string _ENTITY_REGION_CODE;
		private string _ENTITY_TENDER_PROJECT_TYPE;
		private decimal? _WARNING;
		private string _ENTITY_ID;
		private string _ENTITY_TENDER_PROJECT_CODE;
		private string _ENTITY_TENDER_PROJECT_NAME;

		/// <summary>
		/// 
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
		/// 监察名称
		/// </summary>
		public string SUPERVISE_NAME
		{
			get { return _SUPERVISE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_NAME, _SUPERVISE_NAME, value);
				this._SUPERVISE_NAME = value;
			}
		}
		/// <summary>
		/// 监察类型
		/// </summary>
		public string SUPERVISE_TYPE
		{
			get { return _SUPERVISE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_TYPE, _SUPERVISE_TYPE, value);
				this._SUPERVISE_TYPE = value;
			}
		}
		/// <summary>
		/// 监察方式
		/// </summary>
		public string SUPERVISE_WAY
		{
			get { return _SUPERVISE_WAY; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_WAY, _SUPERVISE_WAY, value);
				this._SUPERVISE_WAY = value;
			}
		}
		/// <summary>
		/// 监察时间
		/// </summary>
		public DateTime? SUPERVISE_TIME
		{
			get { return _SUPERVISE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_TIME, _SUPERVISE_TIME, value);
				this._SUPERVISE_TIME = value;
			}
		}
		/// <summary>
		/// 监察规则
		/// </summary>
		public string SUPERVISE_RULE
		{
			get { return _SUPERVISE_RULE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_RULE, _SUPERVISE_RULE, value);
				this._SUPERVISE_RULE = value;
			}
		}
		/// <summary>
		/// 提交日期
		/// </summary>
		public DateTime? ENTITY_SUBMIT_TIME
		{
			get { return _ENTITY_SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_SUBMIT_TIME, _ENTITY_SUBMIT_TIME, value);
				this._ENTITY_SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 审查日期
		/// </summary>
		public DateTime? ENTITY_HANDLE_TIME
		{
			get { return _ENTITY_HANDLE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_HANDLE_TIME, _ENTITY_HANDLE_TIME, value);
				this._ENTITY_HANDLE_TIME = value;
			}
		}
		/// <summary>
		/// 监察人员id
		/// </summary>
		public string SUPERVISE_OP_ID
		{
			get { return _SUPERVISE_OP_ID; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_OP_ID, _SUPERVISE_OP_ID, value);
				this._SUPERVISE_OP_ID = value;
			}
		}
		/// <summary>
		/// 监察人员名称
		/// </summary>
		public string SUPERVISE_OP_NAME
		{
			get { return _SUPERVISE_OP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_OP_NAME, _SUPERVISE_OP_NAME, value);
				this._SUPERVISE_OP_NAME = value;
			}
		}
		/// <summary>
		/// 实体记录归属地
		/// </summary>
		public string ENTITY_REGION_CODE
		{
			get { return _ENTITY_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_REGION_CODE, _ENTITY_REGION_CODE, value);
				this._ENTITY_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 实体记录行业
		/// </summary>
		public string ENTITY_TENDER_PROJECT_TYPE
		{
			get { return _ENTITY_TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TENDER_PROJECT_TYPE, _ENTITY_TENDER_PROJECT_TYPE, value);
				this._ENTITY_TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 是否预警（出现过红灯）
		/// </summary>
		public decimal? WARNING
		{
			get { return _WARNING; }
			set
			{
				this.OnPropertyValueChange(_.WARNING, _WARNING, value);
				this._WARNING = value;
			}
		}
		/// <summary>
		/// 实体记录主键值
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
		/// 招标项目编号
		/// </summary>
		public string ENTITY_TENDER_PROJECT_CODE
		{
			get { return _ENTITY_TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TENDER_PROJECT_CODE, _ENTITY_TENDER_PROJECT_CODE, value);
				this._ENTITY_TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string ENTITY_TENDER_PROJECT_NAME
		{
			get { return _ENTITY_TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TENDER_PROJECT_NAME, _ENTITY_TENDER_PROJECT_NAME, value);
				this._ENTITY_TENDER_PROJECT_NAME = value;
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
				_.ENTITY_TYPE_NAME,
				_.STATUS,
				_.SUPERVISE_NAME,
				_.SUPERVISE_TYPE,
				_.SUPERVISE_WAY,
				_.SUPERVISE_TIME,
				_.SUPERVISE_RULE,
				_.ENTITY_SUBMIT_TIME,
				_.ENTITY_HANDLE_TIME,
				_.SUPERVISE_OP_ID,
				_.SUPERVISE_OP_NAME,
				_.ENTITY_REGION_CODE,
				_.ENTITY_TENDER_PROJECT_TYPE,
				_.WARNING,
				_.ENTITY_ID,
				_.ENTITY_TENDER_PROJECT_CODE,
				_.ENTITY_TENDER_PROJECT_NAME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._ENTITY_TYPE_NAME,
				this._STATUS,
				this._SUPERVISE_NAME,
				this._SUPERVISE_TYPE,
				this._SUPERVISE_WAY,
				this._SUPERVISE_TIME,
				this._SUPERVISE_RULE,
				this._ENTITY_SUBMIT_TIME,
				this._ENTITY_HANDLE_TIME,
				this._SUPERVISE_OP_ID,
				this._SUPERVISE_OP_NAME,
				this._ENTITY_REGION_CODE,
				this._ENTITY_TENDER_PROJECT_TYPE,
				this._WARNING,
				this._ENTITY_ID,
				this._ENTITY_TENDER_PROJECT_CODE,
				this._ENTITY_TENDER_PROJECT_NAME,
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
			public readonly static Field All = new Field("*", "T_SUPERVISE_RESULT");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "T_SUPERVISE_RESULT", "");
			/// <summary>
			/// 实体对象名称T_AFC_PROJECT PT_ZXTS
			/// </summary>
			public readonly static Field ENTITY_TYPE_NAME = new Field("ENTITY_TYPE_NAME", "T_SUPERVISE_RESULT", "实体对象名称T_AFC_PROJECT PT_ZXTS");
			/// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_SUPERVISE_RESULT", "状态");
			/// <summary>
			/// 监察名称
			/// </summary>
			public readonly static Field SUPERVISE_NAME = new Field("SUPERVISE_NAME", "T_SUPERVISE_RESULT", "监察名称");
			/// <summary>
			/// 监察类型
			/// </summary>
			public readonly static Field SUPERVISE_TYPE = new Field("SUPERVISE_TYPE", "T_SUPERVISE_RESULT", "监察类型");
			/// <summary>
			/// 监察方式
			/// </summary>
			public readonly static Field SUPERVISE_WAY = new Field("SUPERVISE_WAY", "T_SUPERVISE_RESULT", "监察方式");
			/// <summary>
			/// 监察时间
			/// </summary>
			public readonly static Field SUPERVISE_TIME = new Field("SUPERVISE_TIME", "T_SUPERVISE_RESULT", "监察时间");
			/// <summary>
			/// 监察规则
			/// </summary>
			public readonly static Field SUPERVISE_RULE = new Field("SUPERVISE_RULE", "T_SUPERVISE_RESULT", "监察规则");
			/// <summary>
			/// 提交日期
			/// </summary>
			public readonly static Field ENTITY_SUBMIT_TIME = new Field("ENTITY_SUBMIT_TIME", "T_SUPERVISE_RESULT", "提交日期");
			/// <summary>
			/// 审查日期
			/// </summary>
			public readonly static Field ENTITY_HANDLE_TIME = new Field("ENTITY_HANDLE_TIME", "T_SUPERVISE_RESULT", "审查日期");
			/// <summary>
			/// 监察人员id
			/// </summary>
			public readonly static Field SUPERVISE_OP_ID = new Field("SUPERVISE_OP_ID", "T_SUPERVISE_RESULT", "监察人员id");
			/// <summary>
			/// 监察人员名称
			/// </summary>
			public readonly static Field SUPERVISE_OP_NAME = new Field("SUPERVISE_OP_NAME", "T_SUPERVISE_RESULT", "监察人员名称");
			/// <summary>
			/// 实体记录归属地
			/// </summary>
			public readonly static Field ENTITY_REGION_CODE = new Field("ENTITY_REGION_CODE", "T_SUPERVISE_RESULT", "实体记录归属地");
			/// <summary>
			/// 实体记录行业
			/// </summary>
			public readonly static Field ENTITY_TENDER_PROJECT_TYPE = new Field("ENTITY_TENDER_PROJECT_TYPE", "T_SUPERVISE_RESULT", "实体记录行业");
			/// <summary>
			/// 是否预警（出现过红灯）
			/// </summary>
			public readonly static Field WARNING = new Field("WARNING", "T_SUPERVISE_RESULT", "是否预警（出现过红灯）");
			/// <summary>
			/// 实体记录主键值
			/// </summary>
			public readonly static Field ENTITY_ID = new Field("ENTITY_ID", "T_SUPERVISE_RESULT", "实体记录主键值");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field ENTITY_TENDER_PROJECT_CODE = new Field("ENTITY_TENDER_PROJECT_CODE", "T_SUPERVISE_RESULT", "招标项目编号");
			/// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field ENTITY_TENDER_PROJECT_NAME = new Field("ENTITY_TENDER_PROJECT_NAME", "T_SUPERVISE_RESULT", "招标项目名称");
		}
		#endregion
	}
}