using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类TENDER_DOC_TRANS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_DOC_TRANS_LOG")]
    [Serializable]
    public partial class TENDER_DOC_TRANS_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _SOURCE_ID;
		private string _TARGET_ID;
		private DateTime? _CREATE_TIME;
		private string _CREATE_ID;
		private string _RECORD_ID;
		private string _ATT_NAME;
		private string _GUID;
		private string _MD5;
		private string _IS_USE;

		/// <summary>
		/// 
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
		/// 交易平台上传的附件的id
		/// </summary>
		public string SOURCE_ID
		{
			get{ return _SOURCE_ID; }
			set
			{
				this.OnPropertyValueChange(_.SOURCE_ID, _SOURCE_ID, value);
				this._SOURCE_ID = value;
			}
		}
		/// <summary>
		/// 备案审查的附件id
		/// </summary>
		public string TARGET_ID
		{
			get{ return _TARGET_ID; }
			set
			{
				this.OnPropertyValueChange(_.TARGET_ID, _TARGET_ID, value);
				this._TARGET_ID = value;
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
		/// 创建人（操作这个行为的人）
		/// </summary>
		public string CREATE_ID
		{
			get{ return _CREATE_ID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_ID, _CREATE_ID, value);
				this._CREATE_ID = value;
			}
		}
		/// <summary>
		/// 备案ID
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
		/// 附件名称
		/// </summary>
		public string ATT_NAME
		{
			get{ return _ATT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ATT_NAME, _ATT_NAME, value);
				this._ATT_NAME = value;
			}
		}
		/// <summary>
		/// 附件的GUID
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 附件的MD5
		/// </summary>
		public string MD5
		{
			get{ return _MD5; }
			set
			{
				this.OnPropertyValueChange(_.MD5, _MD5, value);
				this._MD5 = value;
			}
		}
		/// <summary>
		/// 是否在用（1表示在用，0表示有上传过，但是没提交）
		/// </summary>
		public string IS_USE
		{
			get{ return _IS_USE; }
			set
			{
				this.OnPropertyValueChange(_.IS_USE, _IS_USE, value);
				this._IS_USE = value;
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
				_.SOURCE_ID,
				_.TARGET_ID,
				_.CREATE_TIME,
				_.CREATE_ID,
				_.RECORD_ID,
				_.ATT_NAME,
				_.GUID,
				_.MD5,
				_.IS_USE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SOURCE_ID,
				this._TARGET_ID,
				this._CREATE_TIME,
				this._CREATE_ID,
				this._RECORD_ID,
				this._ATT_NAME,
				this._GUID,
				this._MD5,
				this._IS_USE,
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
			public readonly static Field All = new Field("*", "TENDER_DOC_TRANS_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TENDER_DOC_TRANS_LOG", "");
            /// <summary>
			/// 交易平台上传的附件的id
			/// </summary>
			public readonly static Field SOURCE_ID = new Field("SOURCE_ID", "TENDER_DOC_TRANS_LOG", "交易平台上传的附件的id");
            /// <summary>
			/// 备案审查的附件id
			/// </summary>
			public readonly static Field TARGET_ID = new Field("TARGET_ID", "TENDER_DOC_TRANS_LOG", "备案审查的附件id");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "TENDER_DOC_TRANS_LOG", "创建时间");
            /// <summary>
			/// 创建人（操作这个行为的人）
			/// </summary>
			public readonly static Field CREATE_ID = new Field("CREATE_ID", "TENDER_DOC_TRANS_LOG", "创建人（操作这个行为的人）");
            /// <summary>
			/// 备案ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "TENDER_DOC_TRANS_LOG", "备案ID");
            /// <summary>
			/// 附件名称
			/// </summary>
			public readonly static Field ATT_NAME = new Field("ATT_NAME", "TENDER_DOC_TRANS_LOG", "附件名称");
            /// <summary>
			/// 附件的GUID
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "TENDER_DOC_TRANS_LOG", "附件的GUID");
            /// <summary>
			/// 附件的MD5
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "TENDER_DOC_TRANS_LOG", "附件的MD5");
            /// <summary>
			/// 是否在用（1表示在用，0表示有上传过，但是没提交）
			/// </summary>
			public readonly static Field IS_USE = new Field("IS_USE", "TENDER_DOC_TRANS_LOG", "是否在用（1表示在用，0表示有上传过，但是没提交）");
        }
        #endregion
	}
}