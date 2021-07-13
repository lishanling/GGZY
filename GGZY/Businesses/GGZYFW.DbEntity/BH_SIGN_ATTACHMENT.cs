using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_SIGN_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_SIGN_ATTACHMENT")]
    [Serializable]
    public partial class BH_SIGN_ATTACHMENT : FwEntity
    {
        #region Model
        private string _GUID;
        private string _PARAMS;
        private string _SOURCE_PDF_URL;
        private string _SIGN_PDF_URL;
        private string _SIGN_SOURCE_FILE_URL;
        private string _UPLOAD_URL;
        private DateTime? _CREATE_TIME;
        private DateTime? _SIGN_TIME;
        private string _SOURCE_PDF_MD5;
        private string _SIGN_PDF_MD5;
        private string _SIGN_SOURCE_FILE_MD5;
        private string _SOURCE_PDF_FILENAME;
        private string _SIGN_PDF_FILENAME;
        private string _SIGN_SOURCE_FILE_FILENAME;
        private DateTime? _OVER_TIME;
        private string _SIGN_INFO;
        private string _ORDER_ID;

        /// <summary>
        /// 
        /// </summary>
        public string GUID
        {
            get { return _GUID; }
            set
            {
                this.OnPropertyValueChange(_.GUID, _GUID, value);
                this._GUID = value;
            }
        }
        /// <summary>
        /// 入参参数
        /// </summary>
        public string PARAMS
        {
            get { return _PARAMS; }
            set
            {
                this.OnPropertyValueChange(_.PARAMS, _PARAMS, value);
                this._PARAMS = value;
            }
        }
        /// <summary>
        /// 签章原pdf文件地址
        /// </summary>
        public string SOURCE_PDF_URL
        {
            get { return _SOURCE_PDF_URL; }
            set
            {
                this.OnPropertyValueChange(_.SOURCE_PDF_URL, _SOURCE_PDF_URL, value);
                this._SOURCE_PDF_URL = value;
            }
        }
        /// <summary>
        /// 签章后的pdf地址
        /// </summary>
        public string SIGN_PDF_URL
        {
            get { return _SIGN_PDF_URL; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_PDF_URL, _SIGN_PDF_URL, value);
                this._SIGN_PDF_URL = value;
            }
        }
        /// <summary>
        /// 签章后的原文件地址
        /// </summary>
        public string SIGN_SOURCE_FILE_URL
        {
            get { return _SIGN_SOURCE_FILE_URL; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_SOURCE_FILE_URL, _SIGN_SOURCE_FILE_URL, value);
                this._SIGN_SOURCE_FILE_URL = value;
            }
        }
        /// <summary>
        /// 签章后的文件上传地址
        /// </summary>
        public string UPLOAD_URL
        {
            get { return _UPLOAD_URL; }
            set
            {
                this.OnPropertyValueChange(_.UPLOAD_URL, _UPLOAD_URL, value);
                this._UPLOAD_URL = value;
            }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATE_TIME
        {
            get { return _CREATE_TIME; }
            set
            {
                this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
                this._CREATE_TIME = value;
            }
        }
        /// <summary>
        /// 签章时间
        /// </summary>
        public DateTime? SIGN_TIME
        {
            get { return _SIGN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_TIME, _SIGN_TIME, value);
                this._SIGN_TIME = value;
            }
        }
        /// <summary>
        /// 签章原pdf文件md5
        /// </summary>
        public string SOURCE_PDF_MD5
        {
            get { return _SOURCE_PDF_MD5; }
            set
            {
                this.OnPropertyValueChange(_.SOURCE_PDF_MD5, _SOURCE_PDF_MD5, value);
                this._SOURCE_PDF_MD5 = value;
            }
        }
        /// <summary>
        /// 签章后的pdf文件md5
        /// </summary>
        public string SIGN_PDF_MD5
        {
            get { return _SIGN_PDF_MD5; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_PDF_MD5, _SIGN_PDF_MD5, value);
                this._SIGN_PDF_MD5 = value;
            }
        }
        /// <summary>
        /// 签章原文件的md5
        /// </summary>
        public string SIGN_SOURCE_FILE_MD5
        {
            get { return _SIGN_SOURCE_FILE_MD5; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_SOURCE_FILE_MD5, _SIGN_SOURCE_FILE_MD5, value);
                this._SIGN_SOURCE_FILE_MD5 = value;
            }
        }
        /// <summary>
        /// 签章原pdf文件的文件名
        /// </summary>
        public string SOURCE_PDF_FILENAME
        {
            get { return _SOURCE_PDF_FILENAME; }
            set
            {
                this.OnPropertyValueChange(_.SOURCE_PDF_FILENAME, _SOURCE_PDF_FILENAME, value);
                this._SOURCE_PDF_FILENAME = value;
            }
        }
        /// <summary>
        /// 签章后pdf文件的文件名
        /// </summary>
        public string SIGN_PDF_FILENAME
        {
            get { return _SIGN_PDF_FILENAME; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_PDF_FILENAME, _SIGN_PDF_FILENAME, value);
                this._SIGN_PDF_FILENAME = value;
            }
        }
        /// <summary>
        /// 签章后原文件的文件名
        /// </summary>
        public string SIGN_SOURCE_FILE_FILENAME
        {
            get { return _SIGN_SOURCE_FILE_FILENAME; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_SOURCE_FILE_FILENAME, _SIGN_SOURCE_FILE_FILENAME, value);
                this._SIGN_SOURCE_FILE_FILENAME = value;
            }
        }
        /// <summary>
        /// 签章超时时间，设置10分钟
        /// </summary>
        public DateTime? OVER_TIME
        {
            get { return _OVER_TIME; }
            set
            {
                this.OnPropertyValueChange(_.OVER_TIME, _OVER_TIME, value);
                this._OVER_TIME = value;
            }
        }
        /// <summary>
        /// 签章信息，json
        /// </summary>
        public string SIGN_INFO
        {
            get { return _SIGN_INFO; }
            set
            {
                this.OnPropertyValueChange(_.SIGN_INFO, _SIGN_INFO, value);
                this._SIGN_INFO = value;
            }
        }
        /// <summary>
        /// 对应的订单号id
        /// </summary>
        public string ORDER_ID
        {
            get { return _ORDER_ID; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
                this._ORDER_ID = value;
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
                _.GUID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.GUID,
                _.PARAMS,
                _.SOURCE_PDF_URL,
                _.SIGN_PDF_URL,
                _.SIGN_SOURCE_FILE_URL,
                _.UPLOAD_URL,
                _.CREATE_TIME,
                _.SIGN_TIME,
                _.SOURCE_PDF_MD5,
                _.SIGN_PDF_MD5,
                _.SIGN_SOURCE_FILE_MD5,
                _.SOURCE_PDF_FILENAME,
                _.SIGN_PDF_FILENAME,
                _.SIGN_SOURCE_FILE_FILENAME,
                _.OVER_TIME,
                _.SIGN_INFO,
                _.ORDER_ID,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._PARAMS,
                this._SOURCE_PDF_URL,
                this._SIGN_PDF_URL,
                this._SIGN_SOURCE_FILE_URL,
                this._UPLOAD_URL,
                this._CREATE_TIME,
                this._SIGN_TIME,
                this._SOURCE_PDF_MD5,
                this._SIGN_PDF_MD5,
                this._SIGN_SOURCE_FILE_MD5,
                this._SOURCE_PDF_FILENAME,
                this._SIGN_PDF_FILENAME,
                this._SIGN_SOURCE_FILE_FILENAME,
                this._OVER_TIME,
                this._SIGN_INFO,
                this._ORDER_ID,
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
            public readonly static Field All = new Field("*", "BH_SIGN_ATTACHMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "BH_SIGN_ATTACHMENT", "");
            /// <summary>
			/// 入参参数
			/// </summary>
			public readonly static Field PARAMS = new Field("PARAMS", "BH_SIGN_ATTACHMENT", DbType.AnsiString, null, "入参参数");
            /// <summary>
			/// 签章原pdf文件地址
			/// </summary>
			public readonly static Field SOURCE_PDF_URL = new Field("SOURCE_PDF_URL", "BH_SIGN_ATTACHMENT", "签章原pdf文件地址");
            /// <summary>
			/// 签章后的pdf地址
			/// </summary>
			public readonly static Field SIGN_PDF_URL = new Field("SIGN_PDF_URL", "BH_SIGN_ATTACHMENT", "签章后的pdf地址");
            /// <summary>
			/// 签章后的原文件地址
			/// </summary>
			public readonly static Field SIGN_SOURCE_FILE_URL = new Field("SIGN_SOURCE_FILE_URL", "BH_SIGN_ATTACHMENT", "签章后的原文件地址");
            /// <summary>
			/// 签章后的文件上传地址
			/// </summary>
			public readonly static Field UPLOAD_URL = new Field("UPLOAD_URL", "BH_SIGN_ATTACHMENT", "签章后的文件上传地址");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_SIGN_ATTACHMENT", "创建时间");
            /// <summary>
			/// 签章时间
			/// </summary>
			public readonly static Field SIGN_TIME = new Field("SIGN_TIME", "BH_SIGN_ATTACHMENT", "签章时间");
            /// <summary>
			/// 签章原pdf文件md5
			/// </summary>
			public readonly static Field SOURCE_PDF_MD5 = new Field("SOURCE_PDF_MD5", "BH_SIGN_ATTACHMENT", "签章原pdf文件md5");
            /// <summary>
			/// 签章后的pdf文件md5
			/// </summary>
			public readonly static Field SIGN_PDF_MD5 = new Field("SIGN_PDF_MD5", "BH_SIGN_ATTACHMENT", "签章后的pdf文件md5");
            /// <summary>
			/// 签章原文件的md5
			/// </summary>
			public readonly static Field SIGN_SOURCE_FILE_MD5 = new Field("SIGN_SOURCE_FILE_MD5", "BH_SIGN_ATTACHMENT", "签章原文件的md5");
            /// <summary>
			/// 签章原pdf文件的文件名
			/// </summary>
			public readonly static Field SOURCE_PDF_FILENAME = new Field("SOURCE_PDF_FILENAME", "BH_SIGN_ATTACHMENT", "签章原pdf文件的文件名");
            /// <summary>
			/// 签章后pdf文件的文件名
			/// </summary>
			public readonly static Field SIGN_PDF_FILENAME = new Field("SIGN_PDF_FILENAME", "BH_SIGN_ATTACHMENT", "签章后pdf文件的文件名");
            /// <summary>
			/// 签章后原文件的文件名
			/// </summary>
			public readonly static Field SIGN_SOURCE_FILE_FILENAME = new Field("SIGN_SOURCE_FILE_FILENAME", "BH_SIGN_ATTACHMENT", "签章后原文件的文件名");
            /// <summary>
			/// 签章超时时间，设置10分钟
			/// </summary>
			public readonly static Field OVER_TIME = new Field("OVER_TIME", "BH_SIGN_ATTACHMENT", "签章超时时间，设置10分钟");
            /// <summary>
			/// 签章信息，json
			/// </summary>
			public readonly static Field SIGN_INFO = new Field("SIGN_INFO", "BH_SIGN_ATTACHMENT", DbType.AnsiString, null, "签章信息，json");
            /// <summary>
			/// 对应的订单号id
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_SIGN_ATTACHMENT", "对应的订单号id");
        }
        #endregion
    }
}