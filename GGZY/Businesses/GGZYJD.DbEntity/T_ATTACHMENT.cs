using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ATTACHMENT")]
    [Serializable]
    public partial class T_ATTACHMENT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSTEM_NO;
		private string _TB_NO;
		private string _ATTACHMENT_SET_CODE;
		private string _ATTACHMENT_NAME;
		private string _ATTACHMENT_TYPE;
		private string _ATTACHMENT_FILE_NAME;
		private string _URL;
		private DateTime? _CREATE_TIME;
		private string _SAVE_FILE_NAME;
		private string _REMARK;
		private string _FILE_NAME;
		private string _DATA_KEY;
		private string _MD5;
		private string _REVIEW_ID;
		private string _GUID;
		private string _TB_NAME;
		private string _M_DATA_SOURCE;

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
		/// 交易系统编码
		/// </summary>
		public string SYSTEM_NO
		{
			get{ return _SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NO, _SYSTEM_NO, value);
				this._SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 表编码
		/// </summary>
		public string TB_NO
		{
			get{ return _TB_NO; }
			set
			{
				this.OnPropertyValueChange(_.TB_NO, _TB_NO, value);
				this._TB_NO = value;
			}
		}
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
		/// <summary>
		/// 上传时间
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
		/// 转存到服务器的相对路径
		/// </summary>
		public string SAVE_FILE_NAME
		{
			get{ return _SAVE_FILE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SAVE_FILE_NAME, _SAVE_FILE_NAME, value);
				this._SAVE_FILE_NAME = value;
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
		/// 上传的源文件名
		/// </summary>
		public string FILE_NAME
		{
			get{ return _FILE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.FILE_NAME, _FILE_NAME, value);
				this._FILE_NAME = value;
			}
		}
		/// <summary>
		/// DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// MD5
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
		/// 对应的插入数据的ID
		/// </summary>
		public string REVIEW_ID
		{
			get{ return _REVIEW_ID; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_ID, _REVIEW_ID, value);
				this._REVIEW_ID = value;
			}
		}
		/// <summary>
		/// 默认生成guid
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
		/// 表名
		/// </summary>
		public string TB_NAME
		{
			get{ return _TB_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
				this._TB_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
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
				_.SYSTEM_NO,
				_.TB_NO,
				_.ATTACHMENT_SET_CODE,
				_.ATTACHMENT_NAME,
				_.ATTACHMENT_TYPE,
				_.ATTACHMENT_FILE_NAME,
				_.URL,
				_.CREATE_TIME,
				_.SAVE_FILE_NAME,
				_.REMARK,
				_.FILE_NAME,
				_.DATA_KEY,
				_.MD5,
				_.REVIEW_ID,
				_.GUID,
				_.TB_NAME,
				_.M_DATA_SOURCE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SYSTEM_NO,
				this._TB_NO,
				this._ATTACHMENT_SET_CODE,
				this._ATTACHMENT_NAME,
				this._ATTACHMENT_TYPE,
				this._ATTACHMENT_FILE_NAME,
				this._URL,
				this._CREATE_TIME,
				this._SAVE_FILE_NAME,
				this._REMARK,
				this._FILE_NAME,
				this._DATA_KEY,
				this._MD5,
				this._REVIEW_ID,
				this._GUID,
				this._TB_NAME,
				this._M_DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "T_ATTACHMENT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ATTACHMENT", "ID");
            /// <summary>
			/// 交易系统编码
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "T_ATTACHMENT", "交易系统编码");
            /// <summary>
			/// 表编码
			/// </summary>
			public readonly static Field TB_NO = new Field("TB_NO", "T_ATTACHMENT", "表编码");
            /// <summary>
			/// 附件关联数据集标识符
			/// </summary>
			public readonly static Field ATTACHMENT_SET_CODE = new Field("ATTACHMENT_SET_CODE", "T_ATTACHMENT", "附件关联数据集标识符");
            /// <summary>
			/// 附件名称
			/// </summary>
			public readonly static Field ATTACHMENT_NAME = new Field("ATTACHMENT_NAME", "T_ATTACHMENT", "附件名称");
            /// <summary>
			/// 附件类型
			/// </summary>
			public readonly static Field ATTACHMENT_TYPE = new Field("ATTACHMENT_TYPE", "T_ATTACHMENT", "附件类型");
            /// <summary>
			/// 附件文件名
			/// </summary>
			public readonly static Field ATTACHMENT_FILE_NAME = new Field("ATTACHMENT_FILE_NAME", "T_ATTACHMENT", "附件文件名");
            /// <summary>
			/// 附件URL地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "T_ATTACHMENT", "附件URL地址");
            /// <summary>
			/// 上传时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_ATTACHMENT", "上传时间");
            /// <summary>
			/// 转存到服务器的相对路径
			/// </summary>
			public readonly static Field SAVE_FILE_NAME = new Field("SAVE_FILE_NAME", "T_ATTACHMENT", "转存到服务器的相对路径");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_ATTACHMENT", "备注");
            /// <summary>
			/// 上传的源文件名
			/// </summary>
			public readonly static Field FILE_NAME = new Field("FILE_NAME", "T_ATTACHMENT", "上传的源文件名");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_ATTACHMENT", "DATA_KEY");
            /// <summary>
			/// MD5
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "T_ATTACHMENT", "MD5");
            /// <summary>
			/// 对应的插入数据的ID
			/// </summary>
			public readonly static Field REVIEW_ID = new Field("REVIEW_ID", "T_ATTACHMENT", "对应的插入数据的ID");
            /// <summary>
			/// 默认生成guid
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_ATTACHMENT", "默认生成guid");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_ATTACHMENT", "表名");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_ATTACHMENT", "");
        }
        #endregion
	}
}