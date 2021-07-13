using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_EXPRESSION。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_EXPRESSION")]
	[Serializable]
	public partial class WARN_EXPRESSION : FwEntity
	{
		#region Model
		private decimal? _M_ID;
		private string _SP_NAME;
		private string _SP_NODE_NAME;
		private string _SP_FLOW_NAME;
		private string _SP_TYPE;
		private string _SP_WAY;
		private string _SP_POINT_RULE;
		private string _SP_POINT_TYPE;
		private string _SP_STATUS;
		private decimal? _ISDELETE;
		private string _SQL;
		private DateTime? _DELETE_TIME;
		private DateTime? _CREATE_TIME;
		private string _DEPARTMENT_CODE;
		private string _SP_NODE_NAME_EN;
		private string _SP_MENU_NAME_EN;
		private decimal? _ORDERBY;
		private string _REMARK;

		/// <summary>
		/// 唯一标识
		/// </summary>
		public decimal? M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 监督点名称
		/// </summary>
		public string SP_NAME
		{
			get { return _SP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SP_NAME, _SP_NAME, value);
				this._SP_NAME = value;
			}
		}
		/// <summary>
		/// 节点名称
		/// </summary>
		public string SP_NODE_NAME
		{
			get { return _SP_NODE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SP_NODE_NAME, _SP_NODE_NAME, value);
				this._SP_NODE_NAME = value;
			}
		}
		/// <summary>
		/// 所属环节
		/// </summary>
		public string SP_FLOW_NAME
		{
			get { return _SP_FLOW_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SP_FLOW_NAME, _SP_FLOW_NAME, value);
				this._SP_FLOW_NAME = value;
			}
		}
		/// <summary>
		/// 监督类型
		/// </summary>
		public string SP_TYPE
		{
			get { return _SP_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SP_TYPE, _SP_TYPE, value);
				this._SP_TYPE = value;
			}
		}
		/// <summary>
		/// 监督方式
		/// </summary>
		public string SP_WAY
		{
			get { return _SP_WAY; }
			set
			{
				this.OnPropertyValueChange(_.SP_WAY, _SP_WAY, value);
				this._SP_WAY = value;
			}
		}
		/// <summary>
		/// 监督点规则描述
		/// </summary>
		public string SP_POINT_RULE
		{
			get { return _SP_POINT_RULE; }
			set
			{
				this.OnPropertyValueChange(_.SP_POINT_RULE, _SP_POINT_RULE, value);
				this._SP_POINT_RULE = value;
			}
		}
		/// <summary>
		/// 监督点大分类
		/// </summary>
		public string SP_POINT_TYPE
		{
			get { return _SP_POINT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SP_POINT_TYPE, _SP_POINT_TYPE, value);
				this._SP_POINT_TYPE = value;
			}
		}
		/// <summary>
		/// 预警状态（1绿 2黄 3红）
		/// </summary>
		public string SP_STATUS
		{
			get { return _SP_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.SP_STATUS, _SP_STATUS, value);
				this._SP_STATUS = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? ISDELETE
		{
			get { return _ISDELETE; }
			set
			{
				this.OnPropertyValueChange(_.ISDELETE, _ISDELETE, value);
				this._ISDELETE = value;
			}
		}
		/// <summary>
		/// sql执行语句，获取展示内容信息
		/// </summary>
		public string SQL
		{
			get { return _SQL; }
			set
			{
				this.OnPropertyValueChange(_.SQL, _SQL, value);
				this._SQL = value;
			}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? DELETE_TIME
		{
			get { return _DELETE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DELETE_TIME, _DELETE_TIME, value);
				this._DELETE_TIME = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 对应MGR_DEPERTMENT的CODE
		/// </summary>
		public string DEPARTMENT_CODE
		{
			get { return _DEPARTMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DEPARTMENT_CODE, _DEPARTMENT_CODE, value);
				this._DEPARTMENT_CODE = value;
			}
		}
		/// <summary>
		/// 节点名称英文名，用于前后端交互
		/// </summary>
		public string SP_NODE_NAME_EN
		{
			get { return _SP_NODE_NAME_EN; }
			set
			{
				this.OnPropertyValueChange(_.SP_NODE_NAME_EN, _SP_NODE_NAME_EN, value);
				this._SP_NODE_NAME_EN = value;
			}
		}
		/// <summary>
		/// 对应菜单英文名，用于决定在备案审核的哪些菜单展示改监督点
		/// </summary>
		public string SP_MENU_NAME_EN
		{
			get { return _SP_MENU_NAME_EN; }
			set
			{
				this.OnPropertyValueChange(_.SP_MENU_NAME_EN, _SP_MENU_NAME_EN, value);
				this._SP_MENU_NAME_EN = value;
			}
		}
		/// <summary>
		/// 顺序
		/// </summary>
		public decimal? ORDERBY
		{
			get { return _ORDERBY; }
			set
			{
				this.OnPropertyValueChange(_.ORDERBY, _ORDERBY, value);
				this._ORDERBY = value;
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
				_.SP_NAME,
				_.SP_NODE_NAME,
				_.SP_FLOW_NAME,
				_.SP_TYPE,
				_.SP_WAY,
				_.SP_POINT_RULE,
				_.SP_POINT_TYPE,
				_.SP_STATUS,
				_.ISDELETE,
				_.SQL,
				_.DELETE_TIME,
				_.CREATE_TIME,
				_.DEPARTMENT_CODE,
				_.SP_NODE_NAME_EN,
				_.SP_MENU_NAME_EN,
				_.ORDERBY,
				_.REMARK,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._SP_NAME,
				this._SP_NODE_NAME,
				this._SP_FLOW_NAME,
				this._SP_TYPE,
				this._SP_WAY,
				this._SP_POINT_RULE,
				this._SP_POINT_TYPE,
				this._SP_STATUS,
				this._ISDELETE,
				this._SQL,
				this._DELETE_TIME,
				this._CREATE_TIME,
				this._DEPARTMENT_CODE,
				this._SP_NODE_NAME_EN,
				this._SP_MENU_NAME_EN,
				this._ORDERBY,
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
			public readonly static Field All = new Field("*", "WARN_EXPRESSION");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_EXPRESSION", "唯一标识");
			/// <summary>
			/// 监督点名称
			/// </summary>
			public readonly static Field SP_NAME = new Field("SP_NAME", "WARN_EXPRESSION", "监督点名称");
			/// <summary>
			/// 节点名称
			/// </summary>
			public readonly static Field SP_NODE_NAME = new Field("SP_NODE_NAME", "WARN_EXPRESSION", "节点名称");
			/// <summary>
			/// 所属环节
			/// </summary>
			public readonly static Field SP_FLOW_NAME = new Field("SP_FLOW_NAME", "WARN_EXPRESSION", "所属环节");
			/// <summary>
			/// 监督类型
			/// </summary>
			public readonly static Field SP_TYPE = new Field("SP_TYPE", "WARN_EXPRESSION", "监督类型");
			/// <summary>
			/// 监督方式
			/// </summary>
			public readonly static Field SP_WAY = new Field("SP_WAY", "WARN_EXPRESSION", "监督方式");
			/// <summary>
			/// 监督点规则描述
			/// </summary>
			public readonly static Field SP_POINT_RULE = new Field("SP_POINT_RULE", "WARN_EXPRESSION", "监督点规则描述");
			/// <summary>
			/// 监督点大分类
			/// </summary>
			public readonly static Field SP_POINT_TYPE = new Field("SP_POINT_TYPE", "WARN_EXPRESSION", "监督点大分类");
			/// <summary>
			/// 预警状态（1绿 2黄 3红）
			/// </summary>
			public readonly static Field SP_STATUS = new Field("SP_STATUS", "WARN_EXPRESSION", "预警状态（1绿 2黄 3红）");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "WARN_EXPRESSION", "是否删除");
			/// <summary>
			/// sql执行语句，获取展示内容信息
			/// </summary>
			public readonly static Field SQL = new Field("SQL", "WARN_EXPRESSION", DbType.AnsiString, null, "sql执行语句，获取展示内容信息");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DELETE_TIME = new Field("DELETE_TIME", "WARN_EXPRESSION", "删除时间");
			/// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "WARN_EXPRESSION", "添加时间");
			/// <summary>
			/// 对应MGR_DEPERTMENT的CODE
			/// </summary>
			public readonly static Field DEPARTMENT_CODE = new Field("DEPARTMENT_CODE", "WARN_EXPRESSION", "对应MGR_DEPERTMENT的CODE");
			/// <summary>
			/// 节点名称英文名，用于前后端交互
			/// </summary>
			public readonly static Field SP_NODE_NAME_EN = new Field("SP_NODE_NAME_EN", "WARN_EXPRESSION", "节点名称英文名，用于前后端交互");
			/// <summary>
			/// 对应菜单英文名，用于决定在备案审核的哪些菜单展示改监督点
			/// </summary>
			public readonly static Field SP_MENU_NAME_EN = new Field("SP_MENU_NAME_EN", "WARN_EXPRESSION", "对应菜单英文名，用于决定在备案审核的哪些菜单展示改监督点");
			/// <summary>
			/// 顺序
			/// </summary>
			public readonly static Field ORDERBY = new Field("ORDERBY", "WARN_EXPRESSION", "顺序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "WARN_EXPRESSION", DbType.AnsiString, null, "备注");
		}
		#endregion
	}
}