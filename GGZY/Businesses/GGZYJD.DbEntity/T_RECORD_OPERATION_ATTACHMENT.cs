using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_RECORD_OPERATION_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_RECORD_OPERATION_ATTACHMENT")]
    [Serializable]
    public partial class T_RECORD_OPERATION_ATTACHMENT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _GUIDS;
		private decimal? _RECORD_ID;
		private string _REMARK;
		private string _ATTFILE_TYPECODE;
		private string _ATTFILE_TYPENAME;

		/// <summary>
		/// 附件表id
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
		/// sys_attachment表对应的GUID
		/// </summary>
		public string GUIDS
		{
			get{ return _GUIDS; }
			set
			{
				this.OnPropertyValueChange(_.GUIDS, _GUIDS, value);
				this._GUIDS = value;
			}
		}
		/// <summary>
		/// 备案审查主表ID
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
		/// 附件类型（如PROJECT_APPROVAL_FILE等）
		/// </summary>
		public string ATTFILE_TYPECODE
		{
			get{ return _ATTFILE_TYPECODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTFILE_TYPECODE, _ATTFILE_TYPECODE, value);
				this._ATTFILE_TYPECODE = value;
			}
		}
		/// <summary>
		/// 附件类型（如招标公告、招标文件等）
		/// </summary>
		public string ATTFILE_TYPENAME
		{
			get{ return _ATTFILE_TYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTFILE_TYPENAME, _ATTFILE_TYPENAME, value);
				this._ATTFILE_TYPENAME = value;
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
				_.GUIDS,
				_.RECORD_ID,
				_.REMARK,
				_.ATTFILE_TYPECODE,
				_.ATTFILE_TYPENAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._GUIDS,
				this._RECORD_ID,
				this._REMARK,
				this._ATTFILE_TYPECODE,
				this._ATTFILE_TYPENAME,
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
			public readonly static Field All = new Field("*", "T_RECORD_OPERATION_ATTACHMENT");
            /// <summary>
			/// 附件表id
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_RECORD_OPERATION_ATTACHMENT", "附件表id");
            /// <summary>
			/// sys_attachment表对应的GUID
			/// </summary>
			public readonly static Field GUIDS = new Field("GUIDS", "T_RECORD_OPERATION_ATTACHMENT", "sys_attachment表对应的GUID");
            /// <summary>
			/// 备案审查主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "T_RECORD_OPERATION_ATTACHMENT", "备案审查主表ID");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_RECORD_OPERATION_ATTACHMENT", "备注");
            /// <summary>
			/// 附件类型（如PROJECT_APPROVAL_FILE等）
			/// </summary>
			public readonly static Field ATTFILE_TYPECODE = new Field("ATTFILE_TYPECODE", "T_RECORD_OPERATION_ATTACHMENT", "附件类型（如PROJECT_APPROVAL_FILE等）");
            /// <summary>
			/// 附件类型（如招标公告、招标文件等）
			/// </summary>
			public readonly static Field ATTFILE_TYPENAME = new Field("ATTFILE_TYPENAME", "T_RECORD_OPERATION_ATTACHMENT", "附件类型（如招标公告、招标文件等）");
        }
        #endregion
	}
}