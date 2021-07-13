using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类OPERTION_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("OPERTION_RECORD")]
    [Serializable]
    public partial class OPERTION_RECORD : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private decimal? _DEPID;
		private decimal? _OPERATION_PERSON;
		private DateTime? _OPERATION_TIME;
		private decimal? _OPERATION_BEHAVIOR;
		private string _REVIEW_OPINION;
		private string _ATTACHMENT_ID;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _VERSION;
		private decimal? _INSTANCE_ID;

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
		/// 备案审查主表id
		/// </summary>
		public decimal? RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public decimal? DEPID
		{
			get{ return _DEPID; }
			set
			{
				this.OnPropertyValueChange(_.DEPID, _DEPID, value);
				this._DEPID = value;
			}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public decimal? OPERATION_PERSON
		{
			get{ return _OPERATION_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_PERSON, _OPERATION_PERSON, value);
				this._OPERATION_PERSON = value;
			}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime? OPERATION_TIME
		{
			get{ return _OPERATION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_TIME, _OPERATION_TIME, value);
				this._OPERATION_TIME = value;
			}
		}
		/// <summary>
		/// 操作行为 1:提交 2:退回，不属于本部门监管的项目 3:退回，备案材料不完整 5:未发现问题 
		/// 6:需整改 8:已签收 9:审查意见修改 10：撤回 11：重新提交
		/// </summary>
		public decimal? OPERATION_BEHAVIOR
		{
			get{ return _OPERATION_BEHAVIOR; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_BEHAVIOR, _OPERATION_BEHAVIOR, value);
				this._OPERATION_BEHAVIOR = value;
			}
		}
		/// <summary>
		/// 审查意见
		/// </summary>
		public string REVIEW_OPINION
		{
			get{ return _REVIEW_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_OPINION, _REVIEW_OPINION, value);
				this._REVIEW_OPINION = value;
			}
		}
		/// <summary>
		/// 附件下载id
		/// </summary>
		public string ATTACHMENT_ID
		{
			get{ return _ATTACHMENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_ID, _ATTACHMENT_ID, value);
				this._ATTACHMENT_ID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 版本号（审查时才生成版本号）
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 审查实例ID
		/// </summary>
		public decimal? INSTANCE_ID
		{
			get{ return _INSTANCE_ID; }
			set
			{
				this.OnPropertyValueChange(_.INSTANCE_ID, _INSTANCE_ID, value);
				this._INSTANCE_ID = value;
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
				_.DEPID,
				_.OPERATION_PERSON,
				_.OPERATION_TIME,
				_.OPERATION_BEHAVIOR,
				_.REVIEW_OPINION,
				_.ATTACHMENT_ID,
				_.CREATE_TM,
				_.CREATOR,
				_.VERSION,
				_.INSTANCE_ID,
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
				this._DEPID,
				this._OPERATION_PERSON,
				this._OPERATION_TIME,
				this._OPERATION_BEHAVIOR,
				this._REVIEW_OPINION,
				this._ATTACHMENT_ID,
				this._CREATE_TM,
				this._CREATOR,
				this._VERSION,
				this._INSTANCE_ID,
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
			public readonly static Field All = new Field("*", "OPERTION_RECORD");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "OPERTION_RECORD", "ID");
            /// <summary>
			/// 备案审查主表id
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "OPERTION_RECORD", "备案审查主表id");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field DEPID = new Field("DEPID", "OPERTION_RECORD", "单位");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field OPERATION_PERSON = new Field("OPERATION_PERSON", "OPERTION_RECORD", "操作人");
            /// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field OPERATION_TIME = new Field("OPERATION_TIME", "OPERTION_RECORD", "操作时间");
            /// <summary>
			/// 操作行为
			/// </summary>
			public readonly static Field OPERATION_BEHAVIOR = new Field("OPERATION_BEHAVIOR", "OPERTION_RECORD", "操作行为");
            /// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field REVIEW_OPINION = new Field("REVIEW_OPINION", "OPERTION_RECORD",DbType.AnsiString, null, "审查意见");
            /// <summary>
			/// 附件下载id
			/// </summary>
			public readonly static Field ATTACHMENT_ID = new Field("ATTACHMENT_ID", "OPERTION_RECORD", "附件下载id");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "OPERTION_RECORD", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "OPERTION_RECORD", "创建人");
            /// <summary>
			/// 版本号（审查时才生成版本号）
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "OPERTION_RECORD", "版本号（审查时才生成版本号）");
            /// <summary>
			/// 审查实例ID
			/// </summary>
			public readonly static Field INSTANCE_ID = new Field("INSTANCE_ID", "OPERTION_RECORD", "审查实例ID");
        }
        #endregion
	}
}