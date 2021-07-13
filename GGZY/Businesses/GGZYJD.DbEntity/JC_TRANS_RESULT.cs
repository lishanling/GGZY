using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JC_TRANS_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JC_TRANS_RESULT")]
    [Serializable]
    public partial class JC_TRANS_RESULT : JdEntity
    {
        #region Model
		private string _ID;
		private string _RECORD_ID;
		private string _F_RECORD_ID;
		private string _RESULT_MSG;
		private string _SENDER;
		private string _SENDER_UNIT;
		private decimal? _SEBDER_ID;
		private decimal? _SENDER_UNIT_ID;
		private string _ATTACHMENTS;
		private DateTime? _SUBMIT_TIME;
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
		/// 处理结果内容
		/// </summary>
		public string RESULT_MSG
		{
			get{ return _RESULT_MSG; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_MSG, _RESULT_MSG, value);
				this._RESULT_MSG = value;
			}
		}
		/// <summary>
		/// 提交人
		/// </summary>
		public string SENDER
		{
			get{ return _SENDER; }
			set
			{
				this.OnPropertyValueChange(_.SENDER, _SENDER, value);
				this._SENDER = value;
			}
		}
		/// <summary>
		/// 提交人所在单位
		/// </summary>
		public string SENDER_UNIT
		{
			get{ return _SENDER_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.SENDER_UNIT, _SENDER_UNIT, value);
				this._SENDER_UNIT = value;
			}
		}
		/// <summary>
		/// 提交人ID
		/// </summary>
		public decimal? SEBDER_ID
		{
			get{ return _SEBDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.SEBDER_ID, _SEBDER_ID, value);
				this._SEBDER_ID = value;
			}
		}
		/// <summary>
		/// 提交人所在单位ID
		/// </summary>
		public decimal? SENDER_UNIT_ID
		{
			get{ return _SENDER_UNIT_ID; }
			set
			{
				this.OnPropertyValueChange(_.SENDER_UNIT_ID, _SENDER_UNIT_ID, value);
				this._SENDER_UNIT_ID = value;
			}
		}
		/// <summary>
		/// 相关附件信息
		/// </summary>
		public string ATTACHMENTS
		{
			get{ return _ATTACHMENTS; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTS, _ATTACHMENTS, value);
				this._ATTACHMENTS = value;
			}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime? SUBMIT_TIME
		{
			get{ return _SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_TIME, _SUBMIT_TIME, value);
				this._SUBMIT_TIME = value;
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
				_.RECORD_ID,
				_.F_RECORD_ID,
				_.RESULT_MSG,
				_.SENDER,
				_.SENDER_UNIT,
				_.SEBDER_ID,
				_.SENDER_UNIT_ID,
				_.ATTACHMENTS,
				_.SUBMIT_TIME,
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
				this._RECORD_ID,
				this._F_RECORD_ID,
				this._RESULT_MSG,
				this._SENDER,
				this._SENDER_UNIT,
				this._SEBDER_ID,
				this._SENDER_UNIT_ID,
				this._ATTACHMENTS,
				this._SUBMIT_TIME,
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
			public readonly static Field All = new Field("*", "JC_TRANS_RESULT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_RESULT", "ID");
            /// <summary>
			/// 移送记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "JC_TRANS_RESULT", "移送记录ID");
            /// <summary>
			/// 移送项目/实体记录ID
			/// </summary>
			public readonly static Field F_RECORD_ID = new Field("F_RECORD_ID", "JC_TRANS_RESULT", "移送项目/实体记录ID");
            /// <summary>
			/// 处理结果内容
			/// </summary>
			public readonly static Field RESULT_MSG = new Field("RESULT_MSG", "JC_TRANS_RESULT",DbType.AnsiString, null, "处理结果内容");
            /// <summary>
			/// 提交人
			/// </summary>
			public readonly static Field SENDER = new Field("SENDER", "JC_TRANS_RESULT", "提交人");
            /// <summary>
			/// 提交人所在单位
			/// </summary>
			public readonly static Field SENDER_UNIT = new Field("SENDER_UNIT", "JC_TRANS_RESULT", "提交人所在单位");
            /// <summary>
			/// 提交人ID
			/// </summary>
			public readonly static Field SEBDER_ID = new Field("SEBDER_ID", "JC_TRANS_RESULT", "提交人ID");
            /// <summary>
			/// 提交人所在单位ID
			/// </summary>
			public readonly static Field SENDER_UNIT_ID = new Field("SENDER_UNIT_ID", "JC_TRANS_RESULT", "提交人所在单位ID");
            /// <summary>
			/// 相关附件信息
			/// </summary>
			public readonly static Field ATTACHMENTS = new Field("ATTACHMENTS", "JC_TRANS_RESULT", "相关附件信息");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "JC_TRANS_RESULT", "提交时间");
            /// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_RESULT", "时间戳");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_RESULT", "是否删除");
        }
        #endregion
	}
}