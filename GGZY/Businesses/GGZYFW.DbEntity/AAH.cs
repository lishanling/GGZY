using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AAH。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AAH")]
    [Serializable]
    public partial class AAH : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _MODULE;
		private string _NAME;
		private string _METHOD;
		private string _FREQUEN;
		private string _PRIORITY;
		private string _USER_BY;
		private string _REMARK;
		private string _IS_FIN;
		private DateTime? _OPERATE_TIME;
		private string _OPERATE_BY;
		private string _TCID;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 代码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 模块
		/// </summary>
		public string MODULE
		{
			get{ return _MODULE; }
			set
			{
				this.OnPropertyValueChange(_.MODULE, _MODULE, value);
				this._MODULE = value;
			}
		}
		/// <summary>
		/// 数据集名
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 实现方式
		/// </summary>
		public string METHOD
		{
			get{ return _METHOD; }
			set
			{
				this.OnPropertyValueChange(_.METHOD, _METHOD, value);
				this._METHOD = value;
			}
		}
		/// <summary>
		/// 频率
		/// </summary>
		public string FREQUEN
		{
			get{ return _FREQUEN; }
			set
			{
				this.OnPropertyValueChange(_.FREQUEN, _FREQUEN, value);
				this._FREQUEN = value;
			}
		}
		/// <summary>
		/// 优先级
		/// </summary>
		public string PRIORITY
		{
			get{ return _PRIORITY; }
			set
			{
				this.OnPropertyValueChange(_.PRIORITY, _PRIORITY, value);
				this._PRIORITY = value;
			}
		}
		/// <summary>
		/// 使用者
		/// </summary>
		public string USER_BY
		{
			get{ return _USER_BY; }
			set
			{
				this.OnPropertyValueChange(_.USER_BY, _USER_BY, value);
				this._USER_BY = value;
			}
		}
		/// <summary>
		/// 备注
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
		/// <summary>
		/// 是否完成
		/// </summary>
		public string IS_FIN
		{
			get{ return _IS_FIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_FIN, _IS_FIN, value);
				this._IS_FIN = value;
			}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime? OPERATE_TIME
		{
			get{ return _OPERATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_TIME, _OPERATE_TIME, value);
				this._OPERATE_TIME = value;
			}
		}
		/// <summary>
		/// 操作员
		/// </summary>
		public string OPERATE_BY
		{
			get{ return _OPERATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_BY, _OPERATE_BY, value);
				this._OPERATE_BY = value;
			}
		}
		/// <summary>
		/// TCID
		/// </summary>
		public string TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID, _TCID, value);
				this._TCID = value;
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
				_.ID,
				_.CODE,
				_.MODULE,
				_.NAME,
				_.METHOD,
				_.FREQUEN,
				_.PRIORITY,
				_.USER_BY,
				_.REMARK,
				_.IS_FIN,
				_.OPERATE_TIME,
				_.OPERATE_BY,
				_.TCID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._MODULE,
				this._NAME,
				this._METHOD,
				this._FREQUEN,
				this._PRIORITY,
				this._USER_BY,
				this._REMARK,
				this._IS_FIN,
				this._OPERATE_TIME,
				this._OPERATE_BY,
				this._TCID,
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
			public readonly static Field All = new Field("*", "AAH");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "AAH", "ID");
            /// <summary>
			/// 代码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "AAH", "代码");
            /// <summary>
			/// 模块
			/// </summary>
			public readonly static Field MODULE = new Field("MODULE", "AAH", "模块");
            /// <summary>
			/// 数据集名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "AAH", "数据集名");
            /// <summary>
			/// 实现方式
			/// </summary>
			public readonly static Field METHOD = new Field("METHOD", "AAH", "实现方式");
            /// <summary>
			/// 频率
			/// </summary>
			public readonly static Field FREQUEN = new Field("FREQUEN", "AAH", "频率");
            /// <summary>
			/// 优先级
			/// </summary>
			public readonly static Field PRIORITY = new Field("PRIORITY", "AAH", "优先级");
            /// <summary>
			/// 使用者
			/// </summary>
			public readonly static Field USER_BY = new Field("USER_BY", "AAH", "使用者");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "AAH", "备注");
            /// <summary>
			/// 是否完成
			/// </summary>
			public readonly static Field IS_FIN = new Field("IS_FIN", "AAH", "是否完成");
            /// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field OPERATE_TIME = new Field("OPERATE_TIME", "AAH", "操作时间");
            /// <summary>
			/// 操作员
			/// </summary>
			public readonly static Field OPERATE_BY = new Field("OPERATE_BY", "AAH", "操作员");
            /// <summary>
			/// TCID
			/// </summary>
			public readonly static Field TCID = new Field("TCID", "AAH", "TCID");
        }
        #endregion
	}
}