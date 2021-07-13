using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_RESULT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_RESULT")]
	[Serializable]
	public partial class WARN_RESULT : FwEntity
	{
		#region Model
		private string _M_ID;
		private string _MAIN_M_ID;
		private string _SUB_M_ID;
		private string _TENDER_PROJECT_CODE;
		private string _PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _RESULT_STATUS;
		private string _OPERATE_STATUS;
		private string _REGION_CODE;
		private string _TENDER_PROJECT_TYPE;
		private string _CONTENT;
		private DateTime? _SP_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private DateTime? _DEAL_LIMIT_TIME;
		private DateTime? _LAST_RECORD_TIME;
		private decimal? _ISDELETE;
		private decimal? _SP_ID;
		private string _RECORD_DEPID;

		/// <summary>
		/// 唯一标识
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
		/// 主表id，对应的数据主表
		/// </summary>
		public string MAIN_M_ID
		{
			get { return _MAIN_M_ID; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_M_ID, _MAIN_M_ID, value);
				this._MAIN_M_ID = value;
			}
		}
		/// <summary>
		/// 子表id，分号隔开（表名+逗号+ID+分号+表名+逗号+ID）
		/// </summary>
		public string SUB_M_ID
		{
			get { return _SUB_M_ID; }
			set
			{
				this.OnPropertyValueChange(_.SUB_M_ID, _SUB_M_ID, value);
				this._SUB_M_ID = value;
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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get { return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 标段编号
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
		/// 状态（0未监督 1绿 2黄 3红）
		/// </summary>
		public string RESULT_STATUS
		{
			get { return _RESULT_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_STATUS, _RESULT_STATUS, value);
				this._RESULT_STATUS = value;
			}
		}
		/// <summary>
		/// 处理状态 1:待处理 2：已发出预警信息 3： 已反馈  4：反馈已读  5：已办结
		/// </summary>
		public string OPERATE_STATUS
		{
			get { return _OPERATE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_STATUS, _OPERATE_STATUS, value);
				this._OPERATE_STATUS = value;
			}
		}
		/// <summary>
		/// 项目所在地区
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
		/// 招标项目类型，区分住建水利交通
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
		/// 监督点数据
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
		/// 监督时间
		/// </summary>
		public DateTime? SP_TIME
		{
			get { return _SP_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SP_TIME, _SP_TIME, value);
				this._SP_TIME = value;
			}
		}
		/// <summary>
		/// 时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get { return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 处理时限
		/// </summary>
		public DateTime? DEAL_LIMIT_TIME
		{
			get { return _DEAL_LIMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_LIMIT_TIME, _DEAL_LIMIT_TIME, value);
				this._DEAL_LIMIT_TIME = value;
			}
		}
		/// <summary>
		/// 最后处理时间
		/// </summary>
		public DateTime? LAST_RECORD_TIME
		{
			get { return _LAST_RECORD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LAST_RECORD_TIME, _LAST_RECORD_TIME, value);
				this._LAST_RECORD_TIME = value;
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
		/// 对应的监督点id
		/// </summary>
		public decimal? SP_ID
		{
			get { return _SP_ID; }
			set
			{
				this.OnPropertyValueChange(_.SP_ID, _SP_ID, value);
				this._SP_ID = value;
			}
		}
		/// <summary>
		/// 对应监督平台tender_project的record_depid,通过定时任务刷数据
		/// </summary>
		public string RECORD_DEPID
		{
			get { return _RECORD_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_DEPID, _RECORD_DEPID, value);
				this._RECORD_DEPID = value;
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
				_.MAIN_M_ID,
				_.SUB_M_ID,
				_.TENDER_PROJECT_CODE,
				_.PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.RESULT_STATUS,
				_.OPERATE_STATUS,
				_.REGION_CODE,
				_.TENDER_PROJECT_TYPE,
				_.CONTENT,
				_.SP_TIME,
				_.DATA_TIMESTAMP,
				_.DEAL_LIMIT_TIME,
				_.LAST_RECORD_TIME,
				_.ISDELETE,
				_.SP_ID,
				_.RECORD_DEPID,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._MAIN_M_ID,
				this._SUB_M_ID,
				this._TENDER_PROJECT_CODE,
				this._PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._RESULT_STATUS,
				this._OPERATE_STATUS,
				this._REGION_CODE,
				this._TENDER_PROJECT_TYPE,
				this._CONTENT,
				this._SP_TIME,
				this._DATA_TIMESTAMP,
				this._DEAL_LIMIT_TIME,
				this._LAST_RECORD_TIME,
				this._ISDELETE,
				this._SP_ID,
				this._RECORD_DEPID,
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
			public readonly static Field All = new Field("*", "WARN_RESULT");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_RESULT", "唯一标识");
			/// <summary>
			/// 主表id，对应的数据主表
			/// </summary>
			public readonly static Field MAIN_M_ID = new Field("MAIN_M_ID", "WARN_RESULT", "主表id，对应的数据主表");
			/// <summary>
			/// 子表id，分号隔开（表名+逗号+ID+分号+表名+逗号+ID）
			/// </summary>
			public readonly static Field SUB_M_ID = new Field("SUB_M_ID", "WARN_RESULT", "子表id，分号隔开（表名+逗号+ID+分号+表名+逗号+ID）");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "WARN_RESULT", "招标项目编号");
			/// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "WARN_RESULT", "项目编号");
			/// <summary>
			/// 标段编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "WARN_RESULT", "标段编号");
			/// <summary>
			/// 状态（0未监督 1绿 2黄 3红）
			/// </summary>
			public readonly static Field RESULT_STATUS = new Field("RESULT_STATUS", "WARN_RESULT", "状态（0未监督 1绿 2黄 3红）");
			/// <summary>
			/// 处理状态 1:待处理 2：已发出预警信息 3： 已反馈  4：反馈已读  5：已办结
			/// </summary>
			public readonly static Field OPERATE_STATUS = new Field("OPERATE_STATUS", "WARN_RESULT", "处理状态 1:待处理 2：已发出预警信息 3： 已反馈  4：反馈已读  5：已办结");
			/// <summary>
			/// 项目所在地区
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "WARN_RESULT", "项目所在地区");
			/// <summary>
			/// 招标项目类型，区分住建水利交通
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "WARN_RESULT", "招标项目类型，区分住建水利交通");
			/// <summary>
			/// 监督点数据
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "WARN_RESULT", DbType.AnsiString, null, "监督点数据");
			/// <summary>
			/// 监督时间
			/// </summary>
			public readonly static Field SP_TIME = new Field("SP_TIME", "WARN_RESULT", "监督时间");
			/// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "WARN_RESULT", "时间戳");
			/// <summary>
			/// 处理时限
			/// </summary>
			public readonly static Field DEAL_LIMIT_TIME = new Field("DEAL_LIMIT_TIME", "WARN_RESULT", "处理时限");
			/// <summary>
			/// 最后处理时间
			/// </summary>
			public readonly static Field LAST_RECORD_TIME = new Field("LAST_RECORD_TIME", "WARN_RESULT", "最后处理时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "WARN_RESULT", "是否删除");
			/// <summary>
			/// 对应的监督点id
			/// </summary>
			public readonly static Field SP_ID = new Field("SP_ID", "WARN_RESULT", "对应的监督点id");
			/// <summary>
			/// 对应监督平台tender_project的record_depid,通过定时任务刷数据
			/// </summary>
			public readonly static Field RECORD_DEPID = new Field("RECORD_DEPID", "WARN_RESULT", "对应监督平台tender_project的record_depid,通过定时任务刷数据");
		}
		#endregion
	}
}