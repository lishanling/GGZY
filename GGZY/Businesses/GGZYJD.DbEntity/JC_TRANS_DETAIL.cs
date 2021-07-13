using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JC_TRANS_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JC_TRANS_DETAIL")]
    [Serializable]
	public partial class JC_TRANS_DETAIL : JdEntity
    {
        #region Model
		private string _ID;
		private decimal? _VIOLATION_TYPE;
		private string _VIOLATION_ID;
		private string _VIOLATION_POINT_CODE;
		private string _VIOLATION_POINT_NAME;
		private string _VIOLATION_POINT_TYPE;
		private DateTime? _CHECK_TIME;
		private decimal? _STATUS;
		private string _RECORD_ID;
		private string _F_RECORD_ID;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

		/// <summary>
		/// ID
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 违规点类型 0：项目 1：主体
		/// </summary>
		public decimal? VIOLATION_TYPE
		{
			get{ return _VIOLATION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_TYPE, _VIOLATION_TYPE, value);
				this._VIOLATION_TYPE = value;
			}
		}
		/// <summary>
		/// 疑似违规记录项目/实体记录ID
		/// </summary>
		public string VIOLATION_ID
		{
			get{ return _VIOLATION_ID; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_ID, _VIOLATION_ID, value);
				this._VIOLATION_ID = value;
			}
		}
		/// <summary>
		/// 疑似违规点代码
		/// </summary>
		public string VIOLATION_POINT_CODE
		{
			get{ return _VIOLATION_POINT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_POINT_CODE, _VIOLATION_POINT_CODE, value);
				this._VIOLATION_POINT_CODE = value;
			}
		}
		/// <summary>
		/// 疑似违规点名称
		/// </summary>
		public string VIOLATION_POINT_NAME
		{
			get{ return _VIOLATION_POINT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_POINT_NAME, _VIOLATION_POINT_NAME, value);
				this._VIOLATION_POINT_NAME = value;
			}
		}
		/// <summary>
		/// 违规类型
		/// </summary>
		public string VIOLATION_POINT_TYPE
		{
			get{ return _VIOLATION_POINT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_POINT_TYPE, _VIOLATION_POINT_TYPE, value);
				this._VIOLATION_POINT_TYPE = value;
			}
		}
		/// <summary>
		/// 触发时间
		/// </summary>
		public DateTime? CHECK_TIME
		{
			get{ return _CHECK_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_TIME, _CHECK_TIME, value);
				this._CHECK_TIME = value;
			}
		}
		/// <summary>
		/// 处理状态（0：待处理 1：处理中 2：已处理）
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 移送记录ID
		/// </summary>
		public string RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 移送项目/实体记录ID
		/// </summary>
		public string F_RECORD_ID
		{
			get{ return _F_RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.F_RECORD_ID, _F_RECORD_ID, value);
				this._F_RECORD_ID = value;
			}
		}
		/// <summary>
		/// 时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		[JsonIgnore]
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.VIOLATION_TYPE,
				_.VIOLATION_ID,
				_.VIOLATION_POINT_CODE,
				_.VIOLATION_POINT_NAME,
				_.VIOLATION_POINT_TYPE,
				_.CHECK_TIME,
				_.STATUS,
				_.RECORD_ID,
				_.F_RECORD_ID,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._VIOLATION_TYPE,
				this._VIOLATION_ID,
				this._VIOLATION_POINT_CODE,
				this._VIOLATION_POINT_NAME,
				this._VIOLATION_POINT_TYPE,
				this._CHECK_TIME,
				this._STATUS,
				this._RECORD_ID,
				this._F_RECORD_ID,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "JC_TRANS_DETAIL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_DETAIL", "ID");
            /// <summary>
			/// 违规点类型 0：项目 1：主体
			/// </summary>
			public readonly static Field VIOLATION_TYPE = new Field("VIOLATION_TYPE", "JC_TRANS_DETAIL", "违规点类型 0：项目 1：主体");
            /// <summary>
			/// 疑似违规记录项目/实体记录ID
			/// </summary>
			public readonly static Field VIOLATION_ID = new Field("VIOLATION_ID", "JC_TRANS_DETAIL", "疑似违规记录项目/实体记录ID");
            /// <summary>
			/// 疑似违规点代码
			/// </summary>
			public readonly static Field VIOLATION_POINT_CODE = new Field("VIOLATION_POINT_CODE", "JC_TRANS_DETAIL", "疑似违规点代码");
            /// <summary>
			/// 疑似违规点名称
			/// </summary>
			public readonly static Field VIOLATION_POINT_NAME = new Field("VIOLATION_POINT_NAME", "JC_TRANS_DETAIL", "疑似违规点名称");
            /// <summary>
			/// 违规类型
			/// </summary>
			public readonly static Field VIOLATION_POINT_TYPE = new Field("VIOLATION_POINT_TYPE", "JC_TRANS_DETAIL", "违规类型");
            /// <summary>
			/// 触发时间
			/// </summary>
			public readonly static Field CHECK_TIME = new Field("CHECK_TIME", "JC_TRANS_DETAIL", "触发时间");
            /// <summary>
			/// 处理状态（0：待处理 1：处理中 2：已处理）
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "JC_TRANS_DETAIL", "处理状态（0：待处理 1：处理中 2：已处理）");
            /// <summary>
			/// 移送记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "JC_TRANS_DETAIL", "移送记录ID");
            /// <summary>
			/// 移送项目/实体记录ID
			/// </summary>
			public readonly static Field F_RECORD_ID = new Field("F_RECORD_ID", "JC_TRANS_DETAIL", "移送项目/实体记录ID");
            /// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_DETAIL", "时间戳");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_DETAIL", "是否删除");
        }
        #endregion
	}
}