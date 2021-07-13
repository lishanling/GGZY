using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SIGN_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SIGN_LOG")]
    [Serializable]
    public partial class T_SIGN_LOG : FwEntity
    {
        #region Model
		private string _ID;
		private string _KEY_ID;
		private string _TCID;
		private string _FILE_URL;
		private string _MD5;
		private DateTime? _CREATE_TM;
		private decimal? _CREATE_BY;
		private decimal? _IS_BASE64;
		private string _PARAMS;
		private string _PC_INFO;
		private string _FILE_INFO;
		private string _CA_INFO;
		private decimal? _FILE_LENGTH;
		private decimal? _IS_EFFECTIVE;
		private string _EXT_SIGN_FILE_URL;
		private string _USER_URL_PROTOCOL;

		/// <summary>
		/// 
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
		/// 对应签章表的主键ID
		/// </summary>
		public string KEY_ID
		{
			get{ return _KEY_ID; }
			set
			{
				this.OnPropertyValueChange(_.KEY_ID, _KEY_ID, value);
				this._KEY_ID = value;
			}
		}
		/// <summary>
		/// 
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
		/// <summary>
		/// 签章文件地址
		/// </summary>
		public string FILE_URL
		{
			get{ return _FILE_URL; }
			set
			{
				this.OnPropertyValueChange(_.FILE_URL, _FILE_URL, value);
				this._FILE_URL = value;
			}
		}
		/// <summary>
		/// 文件对应的md5值
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
		/// 签章时间
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
		/// 签章人
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_BASE64
		{
			get{ return _IS_BASE64; }
			set
			{
				this.OnPropertyValueChange(_.IS_BASE64, _IS_BASE64, value);
				this._IS_BASE64 = value;
			}
		}
		/// <summary>
		/// 附加的参数
		/// </summary>
		public string PARAMS
		{
			get{ return _PARAMS; }
			set
			{
				this.OnPropertyValueChange(_.PARAMS, _PARAMS, value);
				this._PARAMS = value;
			}
		}
		/// <summary>
		/// 客户端PC信息
		/// </summary>
		public string PC_INFO
		{
			get{ return _PC_INFO; }
			set
			{
				this.OnPropertyValueChange(_.PC_INFO, _PC_INFO, value);
				this._PC_INFO = value;
			}
		}
		/// <summary>
		/// 文件信息
		/// </summary>
		public string FILE_INFO
		{
			get{ return _FILE_INFO; }
			set
			{
				this.OnPropertyValueChange(_.FILE_INFO, _FILE_INFO, value);
				this._FILE_INFO = value;
			}
		}
		/// <summary>
		/// 章的信息
		/// </summary>
		public string CA_INFO
		{
			get{ return _CA_INFO; }
			set
			{
				this.OnPropertyValueChange(_.CA_INFO, _CA_INFO, value);
				this._CA_INFO = value;
			}
		}
		/// <summary>
		/// 文件大小
		/// </summary>
		public decimal? FILE_LENGTH
		{
			get{ return _FILE_LENGTH; }
			set
			{
				this.OnPropertyValueChange(_.FILE_LENGTH, _FILE_LENGTH, value);
				this._FILE_LENGTH = value;
			}
		}
		/// <summary>
		/// 签章是否有效（签章完后数据是否有保存）
		/// </summary>
		public decimal? IS_EFFECTIVE
		{
			get{ return _IS_EFFECTIVE; }
			set
			{
				this.OnPropertyValueChange(_.IS_EFFECTIVE, _IS_EFFECTIVE, value);
				this._IS_EFFECTIVE = value;
			}
		}
		/// <summary>
		/// 签章前文件地址
		/// </summary>
		public string EXT_SIGN_FILE_URL
		{
			get{ return _EXT_SIGN_FILE_URL; }
			set
			{
				this.OnPropertyValueChange(_.EXT_SIGN_FILE_URL, _EXT_SIGN_FILE_URL, value);
				this._EXT_SIGN_FILE_URL = value;
			}
		}
		/// <summary>
		/// 使用的url协议名
		/// </summary>
		public string USER_URL_PROTOCOL
		{
			get{ return _USER_URL_PROTOCOL; }
			set
			{
				this.OnPropertyValueChange(_.USER_URL_PROTOCOL, _USER_URL_PROTOCOL, value);
				this._USER_URL_PROTOCOL = value;
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
				_.KEY_ID,
				_.TCID,
				_.FILE_URL,
				_.MD5,
				_.CREATE_TM,
				_.CREATE_BY,
				_.IS_BASE64,
				_.PARAMS,
				_.PC_INFO,
				_.FILE_INFO,
				_.CA_INFO,
				_.FILE_LENGTH,
				_.IS_EFFECTIVE,
				_.EXT_SIGN_FILE_URL,
				_.USER_URL_PROTOCOL,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._KEY_ID,
				this._TCID,
				this._FILE_URL,
				this._MD5,
				this._CREATE_TM,
				this._CREATE_BY,
				this._IS_BASE64,
				this._PARAMS,
				this._PC_INFO,
				this._FILE_INFO,
				this._CA_INFO,
				this._FILE_LENGTH,
				this._IS_EFFECTIVE,
				this._EXT_SIGN_FILE_URL,
				this._USER_URL_PROTOCOL,
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
			public readonly static Field All = new Field("*", "T_SIGN_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SIGN_LOG", "");
            /// <summary>
			/// 对应签章表的主键ID
			/// </summary>
			public readonly static Field KEY_ID = new Field("KEY_ID", "T_SIGN_LOG", "对应签章表的主键ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID", "T_SIGN_LOG", "");
            /// <summary>
			/// 签章文件地址
			/// </summary>
			public readonly static Field FILE_URL = new Field("FILE_URL", "T_SIGN_LOG", "签章文件地址");
            /// <summary>
			/// 文件对应的md5值
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "T_SIGN_LOG", "文件对应的md5值");
            /// <summary>
			/// 签章时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_SIGN_LOG", "签章时间");
            /// <summary>
			/// 签章人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_SIGN_LOG", "签章人");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_BASE64 = new Field("IS_BASE64", "T_SIGN_LOG", "");
            /// <summary>
			/// 附加的参数
			/// </summary>
			public readonly static Field PARAMS = new Field("PARAMS", "T_SIGN_LOG", "附加的参数");
            /// <summary>
			/// 客户端PC信息
			/// </summary>
			public readonly static Field PC_INFO = new Field("PC_INFO", "T_SIGN_LOG", "客户端PC信息");
            /// <summary>
			/// 文件信息
			/// </summary>
			public readonly static Field FILE_INFO = new Field("FILE_INFO", "T_SIGN_LOG", "文件信息");
            /// <summary>
			/// 章的信息
			/// </summary>
			public readonly static Field CA_INFO = new Field("CA_INFO", "T_SIGN_LOG", "章的信息");
            /// <summary>
			/// 文件大小
			/// </summary>
			public readonly static Field FILE_LENGTH = new Field("FILE_LENGTH", "T_SIGN_LOG", "文件大小");
            /// <summary>
			/// 签章是否有效（签章完后数据是否有保存）
			/// </summary>
			public readonly static Field IS_EFFECTIVE = new Field("IS_EFFECTIVE", "T_SIGN_LOG", "签章是否有效（签章完后数据是否有保存）");
            /// <summary>
			/// 签章前文件地址
			/// </summary>
			public readonly static Field EXT_SIGN_FILE_URL = new Field("EXT_SIGN_FILE_URL", "T_SIGN_LOG", "签章前文件地址");
            /// <summary>
			/// 使用的url协议名
			/// </summary>
			public readonly static Field USER_URL_PROTOCOL = new Field("USER_URL_PROTOCOL", "T_SIGN_LOG", "使用的url协议名");
        }
        #endregion
	}
}