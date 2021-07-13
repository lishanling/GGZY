using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_FILE")]
    [Serializable]
    public partial class YDPB_FILE : JdEntity
    {
        #region Model
		private decimal? _FILE_ID;
		private decimal? _FID;
		private string _F_TABLE;
		private string _ID;
		private string _CATEGORY;
		private string _NAME;
		private string _URL;
		private string _MD5;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

		/// <summary>
		/// 主键
		/// </summary>
		public decimal? FILE_ID
		{
			get{ return _FILE_ID; }
			set
			{
				this.OnPropertyValueChange(_.FILE_ID, _FILE_ID, value);
				this._FILE_ID = value;
			}
		}
		/// <summary>
		/// 关联外键ID
		/// </summary>
		public decimal? FID
		{
			get{ return _FID; }
			set
			{
				this.OnPropertyValueChange(_.FID, _FID, value);
				this._FID = value;
			}
		}
		/// <summary>
		/// 关联表名
		/// </summary>
		public string F_TABLE
		{
			get{ return _F_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.F_TABLE, _F_TABLE, value);
				this._F_TABLE = value;
			}
		}
		/// <summary>
		/// 文件服务器返回ID
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
		/// 附件类别
		/// </summary>
		public string CATEGORY
		{
			get{ return _CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.CATEGORY, _CATEGORY, value);
				this._CATEGORY = value;
			}
		}
		/// <summary>
		/// 文件名
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
		/// 文件服务器对应Url
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
		/// 文件MD5值
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
		/// 添加人ID
		/// </summary>
		public decimal? CREATOR_ID
		{
			get{ return _CREATOR_ID; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR_ID, _CREATOR_ID, value);
				this._CREATOR_ID = value;
			}
		}
		/// <summary>
		/// 创建人名称
		/// </summary>
		public string CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 数据创建时间
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
		/// 数据最后修改时间
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
		/// 是否删除 0:正常 1：删除
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
				_.FILE_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.FILE_ID,
				_.FID,
				_.F_TABLE,
				_.ID,
				_.CATEGORY,
				_.NAME,
				_.URL,
				_.MD5,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
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
				this._FILE_ID,
				this._FID,
				this._F_TABLE,
				this._ID,
				this._CATEGORY,
				this._NAME,
				this._URL,
				this._MD5,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "YDPB_FILE");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field FILE_ID = new Field("FILE_ID", "YDPB_FILE", "主键");
            /// <summary>
			/// 关联外键ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "YDPB_FILE", "关联外键ID");
            /// <summary>
			/// 关联表名
			/// </summary>
			public readonly static Field F_TABLE = new Field("F_TABLE", "YDPB_FILE", "关联表名");
            /// <summary>
			/// 文件服务器返回ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_FILE", "文件服务器返回ID");
            /// <summary>
			/// 附件类别
			/// </summary>
			public readonly static Field CATEGORY = new Field("CATEGORY", "YDPB_FILE", "附件类别");
            /// <summary>
			/// 文件名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "YDPB_FILE", "文件名");
            /// <summary>
			/// 文件服务器对应Url
			/// </summary>
			public readonly static Field URL = new Field("URL", "YDPB_FILE", "文件服务器对应Url");
            /// <summary>
			/// 文件MD5值
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "YDPB_FILE", "文件MD5值");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_FILE", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_FILE", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_FILE", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_FILE", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_FILE", "是否删除 0:正常 1：删除");
        }
        #endregion
	}
}