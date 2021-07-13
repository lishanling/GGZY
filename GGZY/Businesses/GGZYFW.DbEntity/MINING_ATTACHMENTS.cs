using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MINING_ATTACHMENTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MINING_ATTACHMENTS")]
    [Serializable]
    public partial class MINING_ATTACHMENTS : FwEntity
    {
        #region Model
		private string _ATTACHMENT_SET_CODE;
		private decimal? _ATTACHMENT_COUNT;
		private string _ATTACHMENT_NAME;
		private string _ATTACHMENT_TYPE;
		private string _ATTACHMENT_FILE_NAME;
		private string _URL;

		/// <summary>
		/// 附件关联数据集标识符
		/// </summary>
		public string ATTACHMENT_SET_CODE
		{
			get{ return _ATTACHMENT_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_SET_CODE, _ATTACHMENT_SET_CODE, value);
				this._ATTACHMENT_SET_CODE = value;
			}
		}
		/// <summary>
		/// 关联附件数量
		/// </summary>
		public decimal? ATTACHMENT_COUNT
		{
			get{ return _ATTACHMENT_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_COUNT, _ATTACHMENT_COUNT, value);
				this._ATTACHMENT_COUNT = value;
			}
		}
		/// <summary>
		/// 附件名称
		/// </summary>
		public string ATTACHMENT_NAME
		{
			get{ return _ATTACHMENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_NAME, _ATTACHMENT_NAME, value);
				this._ATTACHMENT_NAME = value;
			}
		}
		/// <summary>
		/// 附件类型
		/// </summary>
		public string ATTACHMENT_TYPE
		{
			get{ return _ATTACHMENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_TYPE, _ATTACHMENT_TYPE, value);
				this._ATTACHMENT_TYPE = value;
			}
		}
		/// <summary>
		/// 附件文件名
		/// </summary>
		public string ATTACHMENT_FILE_NAME
		{
			get{ return _ATTACHMENT_FILE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_FILE_NAME, _ATTACHMENT_FILE_NAME, value);
				this._ATTACHMENT_FILE_NAME = value;
			}
		}
		/// <summary>
		/// 附件URL地址
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
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
				_.ATTACHMENT_SET_CODE,
				_.ATTACHMENT_COUNT,
				_.ATTACHMENT_NAME,
				_.ATTACHMENT_TYPE,
				_.ATTACHMENT_FILE_NAME,
				_.URL,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ATTACHMENT_SET_CODE,
				this._ATTACHMENT_COUNT,
				this._ATTACHMENT_NAME,
				this._ATTACHMENT_TYPE,
				this._ATTACHMENT_FILE_NAME,
				this._URL,
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
			public readonly static Field All = new Field("*", "MINING_ATTACHMENTS");
            /// <summary>
			/// 附件关联数据集标识符
			/// </summary>
			public readonly static Field ATTACHMENT_SET_CODE = new Field("ATTACHMENT_SET_CODE", "MINING_ATTACHMENTS",DbType.AnsiString, null, "附件关联数据集标识符");
            /// <summary>
			/// 关联附件数量
			/// </summary>
			public readonly static Field ATTACHMENT_COUNT = new Field("ATTACHMENT_COUNT", "MINING_ATTACHMENTS", "关联附件数量");
            /// <summary>
			/// 附件名称
			/// </summary>
			public readonly static Field ATTACHMENT_NAME = new Field("ATTACHMENT_NAME", "MINING_ATTACHMENTS", "附件名称");
            /// <summary>
			/// 附件类型
			/// </summary>
			public readonly static Field ATTACHMENT_TYPE = new Field("ATTACHMENT_TYPE", "MINING_ATTACHMENTS", "附件类型");
            /// <summary>
			/// 附件文件名
			/// </summary>
			public readonly static Field ATTACHMENT_FILE_NAME = new Field("ATTACHMENT_FILE_NAME", "MINING_ATTACHMENTS", "附件文件名");
            /// <summary>
			/// 附件URL地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "MINING_ATTACHMENTS", "附件URL地址");
        }
        #endregion
	}
}