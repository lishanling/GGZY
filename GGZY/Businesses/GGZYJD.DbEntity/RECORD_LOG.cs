using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_LOG")]
    [Serializable]
    public partial class RECORD_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _BA_ID;
		private string _TENDER_PROJECT_CODE;
		private string _ATTCHAMENT;
		private string _DATA_AND_ATT;
		private DateTime? _CREATE_TIME;
		private string _SUBMIT_PERSON;
		private string _SUBMIT_DEPID;
		private string _OPER_ID;

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
		/// 备案主表id
		/// </summary>
		public string BA_ID
		{
			get{ return _BA_ID; }
			set
			{
				this.OnPropertyValueChange(_.BA_ID, _BA_ID, value);
				this._BA_ID = value;
			}
		}
		/// <summary>
		/// 招标项目编号（内部）
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 附件内容
		/// </summary>
		public string ATTCHAMENT
		{
			get{ return _ATTCHAMENT; }
			set
			{
				this.OnPropertyValueChange(_.ATTCHAMENT, _ATTCHAMENT, value);
				this._ATTCHAMENT = value;
			}
		}
		/// <summary>
		/// 数据内容和附件内容
		/// </summary>
		public string DATA_AND_ATT
		{
			get{ return _DATA_AND_ATT; }
			set
			{
				this.OnPropertyValueChange(_.DATA_AND_ATT, _DATA_AND_ATT, value);
				this._DATA_AND_ATT = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 提交人
		/// </summary>
		public string SUBMIT_PERSON
		{
			get{ return _SUBMIT_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_PERSON, _SUBMIT_PERSON, value);
				this._SUBMIT_PERSON = value;
			}
		}
		/// <summary>
		/// 提交人组织机构
		/// </summary>
		public string SUBMIT_DEPID
		{
			get{ return _SUBMIT_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_DEPID, _SUBMIT_DEPID, value);
				this._SUBMIT_DEPID = value;
			}
		}
		/// <summary>
		/// 操作记录id
		/// </summary>
		public string OPER_ID
		{
			get{ return _OPER_ID; }
			set
			{
				this.OnPropertyValueChange(_.OPER_ID, _OPER_ID, value);
				this._OPER_ID = value;
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
				_.BA_ID,
				_.TENDER_PROJECT_CODE,
				_.ATTCHAMENT,
				_.DATA_AND_ATT,
				_.CREATE_TIME,
				_.SUBMIT_PERSON,
				_.SUBMIT_DEPID,
				_.OPER_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BA_ID,
				this._TENDER_PROJECT_CODE,
				this._ATTCHAMENT,
				this._DATA_AND_ATT,
				this._CREATE_TIME,
				this._SUBMIT_PERSON,
				this._SUBMIT_DEPID,
				this._OPER_ID,
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
			public readonly static Field All = new Field("*", "RECORD_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_LOG", "ID");
            /// <summary>
			/// 备案主表id
			/// </summary>
			public readonly static Field BA_ID = new Field("BA_ID", "RECORD_LOG", "备案主表id");
            /// <summary>
			/// 招标项目编号（内部）
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "RECORD_LOG", "招标项目编号（内部）");
            /// <summary>
			/// 附件内容
			/// </summary>
			public readonly static Field ATTCHAMENT = new Field("ATTCHAMENT", "RECORD_LOG",DbType.AnsiString, null, "附件内容");
            /// <summary>
			/// 数据内容和附件内容
			/// </summary>
			public readonly static Field DATA_AND_ATT = new Field("DATA_AND_ATT", "RECORD_LOG",DbType.AnsiString, null, "数据内容和附件内容");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "RECORD_LOG", "创建时间");
            /// <summary>
			/// 提交人
			/// </summary>
			public readonly static Field SUBMIT_PERSON = new Field("SUBMIT_PERSON", "RECORD_LOG", "提交人");
            /// <summary>
			/// 提交人组织机构
			/// </summary>
			public readonly static Field SUBMIT_DEPID = new Field("SUBMIT_DEPID", "RECORD_LOG", "提交人组织机构");
            /// <summary>
			/// 操作记录id
			/// </summary>
			public readonly static Field OPER_ID = new Field("OPER_ID", "RECORD_LOG", "操作记录id");
        }
        #endregion
	}
}