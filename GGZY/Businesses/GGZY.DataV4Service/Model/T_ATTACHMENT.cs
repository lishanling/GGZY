using System;
using System.Data;
using Dos.ORM;

namespace GGZY.DataV4Service.Model
{
    /// <summary>
    /// 实体类T_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ATTACHMENT")]
    [Serializable]
    public partial class T_ATTACHMENT : Entity
    {
        #region Model
        private int _ID;
        private string _SYSTEM_NO;
        private string _TB_NAME;
        private string _ATTACHMENT_SET_CODE;
        private decimal? _ATTACHMENT_COUNT;
        private string _ATTACHMENT_NAME;
        private string _ATTACHMENT_TYPE;
        private string _ATTACHMENT_FILE_NAME;
        private string _URL;
        private DateTime? _CREATE_TIME;
        private string _SAVE_FILE_NAME;
        private string _M_KEY;
        private string _M_DATA_SOURCE;
        private string _CREATE_BY;
        private decimal? _TB_ID;
        private decimal? _ORDER_BY;
        private string _REMARK;
        private string _FILE_NAME;
        private string _GUID;
        private string _MD5;

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange(_.ID, _ID, value);
                this._ID = value;
            }
        }
        /// <summary>
        /// 系统编码
        /// </summary>
        public string SYSTEM_NO
        {
            get { return _SYSTEM_NO; }
            set
            {
                this.OnPropertyValueChange(_.SYSTEM_NO, _SYSTEM_NO, value);
                this._SYSTEM_NO = value;
            }
        }
        /// <summary>
        /// 表名
        /// </summary>
        public string TB_NAME
        {
            get { return _TB_NAME; }
            set
            {
                this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
                this._TB_NAME = value;
            }
        }
        /// <summary>
        /// 附件关联数据集标识符
        /// </summary>
        public string ATTACHMENT_SET_CODE
        {
            get { return _ATTACHMENT_SET_CODE; }
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
            get { return _ATTACHMENT_COUNT; }
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
            get { return _ATTACHMENT_NAME; }
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
            get { return _ATTACHMENT_TYPE; }
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
            get { return _ATTACHMENT_FILE_NAME; }
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
            get { return _URL; }
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
            get { return _CREATE_TIME; }
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
            get { return _SAVE_FILE_NAME; }
            set
            {
                this.OnPropertyValueChange(_.SAVE_FILE_NAME, _SAVE_FILE_NAME, value);
                this._SAVE_FILE_NAME = value;
            }
        }
        /// <summary>
        /// DATA_KEY数据唯一性验证
        /// </summary>
        public string M_KEY
        {
            get { return _M_KEY; }
            set
            {
                this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
                this._M_KEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string M_DATA_SOURCE
        {
            get { return _M_DATA_SOURCE; }
            set
            {
                this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
                this._M_DATA_SOURCE = value;
            }
        }
        /// <summary>
        /// 操作员
        /// </summary>
        public string CREATE_BY
        {
            get { return _CREATE_BY; }
            set
            {
                this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
                this._CREATE_BY = value;
            }
        }
        /// <summary>
        /// 记录表ID
        /// </summary>
        public decimal? TB_ID
        {
            get { return _TB_ID; }
            set
            {
                this.OnPropertyValueChange(_.TB_ID, _TB_ID, value);
                this._TB_ID = value;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public decimal? ORDER_BY
        {
            get { return _ORDER_BY; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
                this._ORDER_BY = value;
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK
        {
            get { return _REMARK; }
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
            get { return _FILE_NAME; }
            set
            {
                this.OnPropertyValueChange(_.FILE_NAME, _FILE_NAME, value);
                this._FILE_NAME = value;
            }
        }
        /// <summary>
        /// 默认生成guid
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
        /// MD5
        /// </summary>
        public string MD5
        {
            get { return _MD5; }
            set
            {
                this.OnPropertyValueChange(_.MD5, _MD5, value);
                this._MD5 = value;
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
                _.TB_NAME,
                _.ATTACHMENT_SET_CODE,
                _.ATTACHMENT_COUNT,
                _.ATTACHMENT_NAME,
                _.ATTACHMENT_TYPE,
                _.ATTACHMENT_FILE_NAME,
                _.URL,
                _.CREATE_TIME,
                _.SAVE_FILE_NAME,
                _.M_KEY,
                _.M_DATA_SOURCE,
                _.CREATE_BY,
                _.TB_ID,
                _.ORDER_BY,
                _.REMARK,
                _.FILE_NAME,
                _.GUID,
                _.MD5,
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
                this._TB_NAME,
                this._ATTACHMENT_SET_CODE,
                this._ATTACHMENT_COUNT,
                this._ATTACHMENT_NAME,
                this._ATTACHMENT_TYPE,
                this._ATTACHMENT_FILE_NAME,
                this._URL,
                this._CREATE_TIME,
                this._SAVE_FILE_NAME,
                this._M_KEY,
                this._M_DATA_SOURCE,
                this._CREATE_BY,
                this._TB_ID,
                this._ORDER_BY,
                this._REMARK,
                this._FILE_NAME,
                this._GUID,
                this._MD5,
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
			/// 系统编码
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "T_ATTACHMENT", "系统编码");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_ATTACHMENT", "表名");
            /// <summary>
			/// 附件关联数据集标识符
			/// </summary>
			public readonly static Field ATTACHMENT_SET_CODE = new Field("ATTACHMENT_SET_CODE", "T_ATTACHMENT", "附件关联数据集标识符");
            /// <summary>
			/// 关联附件数量
			/// </summary>
			public readonly static Field ATTACHMENT_COUNT = new Field("ATTACHMENT_COUNT", "T_ATTACHMENT", "关联附件数量");
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
			/// DATA_KEY数据唯一性验证
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_ATTACHMENT", "DATA_KEY数据唯一性验证");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_ATTACHMENT", "");
            /// <summary>
			/// 操作员
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_ATTACHMENT", "操作员");
            /// <summary>
			/// 记录表ID
			/// </summary>
			public readonly static Field TB_ID = new Field("TB_ID", "T_ATTACHMENT", "记录表ID");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_ATTACHMENT", "排序");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_ATTACHMENT", "备注");
            /// <summary>
			/// 上传的源文件名
			/// </summary>
			public readonly static Field FILE_NAME = new Field("FILE_NAME", "T_ATTACHMENT", "上传的源文件名");
            /// <summary>
			/// 默认生成guid
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_ATTACHMENT", "默认生成guid");
            /// <summary>
			/// MD5
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "T_ATTACHMENT", "MD5");
        }
        #endregion
        public override string GetSequence()
        {
            return "SEQ_T_ATTACHMENT";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}