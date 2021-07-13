using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类GGZY_QUARTZ_TASK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GGZY_QUARTZ_TASK")]
    [Serializable]
    public partial class GGZY_QUARTZ_TASK : FwEntity
    {
        #region Model
		private string _TASKID;
		private string _TASKNAME;
		private string _TASKPARAM;
		private string _CRONEXPRESSIONSTRING;
		private string _CRONREMARK;
		private string _ASSEMBLYNAME;
		private string _CLASSNAME;
		private decimal? _STATE;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _MODIFIEDBY;
		private DateTime? _MODIFIEDTIME;
		private DateTime? _RECENTRUNTIME;
		private DateTime? _LASTRUNTIME;
		private string _REMARK;

		/// <summary>
		/// 任务ID
		/// </summary>
		public string TASKID
		{
			get{ return _TASKID; }
			set
			{
				this.OnPropertyValueChange(_.TASKID, _TASKID, value);
				this._TASKID = value;
			}
		}
		/// <summary>
		/// 任务名称
		/// </summary>
		public string TASKNAME
		{
			get{ return _TASKNAME; }
			set
			{
				this.OnPropertyValueChange(_.TASKNAME, _TASKNAME, value);
				this._TASKNAME = value;
			}
		}
		/// <summary>
		/// 任务执行参数
		/// </summary>
		public string TASKPARAM
		{
			get{ return _TASKPARAM; }
			set
			{
				this.OnPropertyValueChange(_.TASKPARAM, _TASKPARAM, value);
				this._TASKPARAM = value;
			}
		}
		/// <summary>
		/// 运行频率设置
		/// </summary>
		public string CRONEXPRESSIONSTRING
		{
			get{ return _CRONEXPRESSIONSTRING; }
			set
			{
				this.OnPropertyValueChange(_.CRONEXPRESSIONSTRING, _CRONEXPRESSIONSTRING, value);
				this._CRONEXPRESSIONSTRING = value;
			}
		}
		/// <summary>
		/// 任务运频率中文说明
		/// </summary>
		public string CRONREMARK
		{
			get{ return _CRONREMARK; }
			set
			{
				this.OnPropertyValueChange(_.CRONREMARK, _CRONREMARK, value);
				this._CRONREMARK = value;
			}
		}
		/// <summary>
		/// 任务所在DLL对应的程序集名称
		/// </summary>
		public string ASSEMBLYNAME
		{
			get{ return _ASSEMBLYNAME; }
			set
			{
				this.OnPropertyValueChange(_.ASSEMBLYNAME, _ASSEMBLYNAME, value);
				this._ASSEMBLYNAME = value;
			}
		}
		/// <summary>
		/// 任务所在类
		/// </summary>
		public string CLASSNAME
		{
			get{ return _CLASSNAME; }
			set
			{
				this.OnPropertyValueChange(_.CLASSNAME, _CLASSNAME, value);
				this._CLASSNAME = value;
			}
		}
		/// <summary>
		/// 任务状态中文说明
		/// </summary>
		public decimal? STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 任务创建人
		/// </summary>
		public string CREATEDBY
		{
			get{ return _CREATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDBY, _CREATEDBY, value);
				this._CREATEDBY = value;
			}
		}
		/// <summary>
		/// 任务创建时间
		/// </summary>
		public DateTime? CREATEDTIME
		{
			get{ return _CREATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDTIME, _CREATEDTIME, value);
				this._CREATEDTIME = value;
			}
		}
		/// <summary>
		/// 任务修改人
		/// </summary>
		public string MODIFIEDBY
		{
			get{ return _MODIFIEDBY; }
			set
			{
				this.OnPropertyValueChange(_.MODIFIEDBY, _MODIFIEDBY, value);
				this._MODIFIEDBY = value;
			}
		}
		/// <summary>
		/// 任务修改时间
		/// </summary>
		public DateTime? MODIFIEDTIME
		{
			get{ return _MODIFIEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFIEDTIME, _MODIFIEDTIME, value);
				this._MODIFIEDTIME = value;
			}
		}
		/// <summary>
		/// 任务最近运行时间
		/// </summary>
		public DateTime? RECENTRUNTIME
		{
			get{ return _RECENTRUNTIME; }
			set
			{
				this.OnPropertyValueChange(_.RECENTRUNTIME, _RECENTRUNTIME, value);
				this._RECENTRUNTIME = value;
			}
		}
		/// <summary>
		/// 任务下次运行时间
		/// </summary>
		public DateTime? LASTRUNTIME
		{
			get{ return _LASTRUNTIME; }
			set
			{
				this.OnPropertyValueChange(_.LASTRUNTIME, _LASTRUNTIME, value);
				this._LASTRUNTIME = value;
			}
		}
		/// <summary>
		/// 任务备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
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
				_.TASKID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TASKID,
				_.TASKNAME,
				_.TASKPARAM,
				_.CRONEXPRESSIONSTRING,
				_.CRONREMARK,
				_.ASSEMBLYNAME,
				_.CLASSNAME,
				_.STATE,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.MODIFIEDBY,
				_.MODIFIEDTIME,
				_.RECENTRUNTIME,
				_.LASTRUNTIME,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TASKID,
				this._TASKNAME,
				this._TASKPARAM,
				this._CRONEXPRESSIONSTRING,
				this._CRONREMARK,
				this._ASSEMBLYNAME,
				this._CLASSNAME,
				this._STATE,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._MODIFIEDBY,
				this._MODIFIEDTIME,
				this._RECENTRUNTIME,
				this._LASTRUNTIME,
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
			public readonly static Field All = new Field("*", "GGZY_QUARTZ_TASK");
            /// <summary>
			/// 任务ID
			/// </summary>
			public readonly static Field TASKID = new Field("TASKID", "GGZY_QUARTZ_TASK", "任务ID");
            /// <summary>
			/// 任务名称
			/// </summary>
			public readonly static Field TASKNAME = new Field("TASKNAME", "GGZY_QUARTZ_TASK", "任务名称");
            /// <summary>
			/// 任务执行参数
			/// </summary>
			public readonly static Field TASKPARAM = new Field("TASKPARAM", "GGZY_QUARTZ_TASK",DbType.AnsiString, null, "任务执行参数");
            /// <summary>
			/// 运行频率设置
			/// </summary>
			public readonly static Field CRONEXPRESSIONSTRING = new Field("CRONEXPRESSIONSTRING", "GGZY_QUARTZ_TASK", "运行频率设置");
            /// <summary>
			/// 任务运频率中文说明
			/// </summary>
			public readonly static Field CRONREMARK = new Field("CRONREMARK", "GGZY_QUARTZ_TASK", "任务运频率中文说明");
            /// <summary>
			/// 任务所在DLL对应的程序集名称
			/// </summary>
			public readonly static Field ASSEMBLYNAME = new Field("ASSEMBLYNAME", "GGZY_QUARTZ_TASK", "任务所在DLL对应的程序集名称");
            /// <summary>
			/// 任务所在类
			/// </summary>
			public readonly static Field CLASSNAME = new Field("CLASSNAME", "GGZY_QUARTZ_TASK", "任务所在类");
            /// <summary>
			/// 任务状态中文说明
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "GGZY_QUARTZ_TASK", "任务状态中文说明");
            /// <summary>
			/// 任务创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "GGZY_QUARTZ_TASK", "任务创建人");
            /// <summary>
			/// 任务创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "GGZY_QUARTZ_TASK", "任务创建时间");
            /// <summary>
			/// 任务修改人
			/// </summary>
			public readonly static Field MODIFIEDBY = new Field("MODIFIEDBY", "GGZY_QUARTZ_TASK", "任务修改人");
            /// <summary>
			/// 任务修改时间
			/// </summary>
			public readonly static Field MODIFIEDTIME = new Field("MODIFIEDTIME", "GGZY_QUARTZ_TASK", "任务修改时间");
            /// <summary>
			/// 任务最近运行时间
			/// </summary>
			public readonly static Field RECENTRUNTIME = new Field("RECENTRUNTIME", "GGZY_QUARTZ_TASK", "任务最近运行时间");
            /// <summary>
			/// 任务下次运行时间
			/// </summary>
			public readonly static Field LASTRUNTIME = new Field("LASTRUNTIME", "GGZY_QUARTZ_TASK", "任务下次运行时间");
            /// <summary>
			/// 任务备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "GGZY_QUARTZ_TASK", "任务备注");
        }
        #endregion
	}
}