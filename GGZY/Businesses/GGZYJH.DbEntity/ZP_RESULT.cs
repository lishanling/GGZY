using System;
using System.Data;
using Dos.ORM;

namespace GGZYJH.DbEntity
{
    /// <summary>
    /// 实体类ZP_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZP_RESULT")]
    [Serializable]
    public partial class ZP_RESULT : JhEntity
    {
        #region Model
        private decimal? _ZR_ID;
        private string _ZR_UNIT;
        private string _ZR_ADDRESS;
        private string _ZR_NAME;
        private string _ZR_PHONE;
        private string _ZR_POST;
        private string _ZR_FAX;
        private string _ZR_EMAIL;
        private string _ZR_BID;
        private string _ZR_CODE;
        private string _ZR_TITLE;
        private string _ZR_ZUNIT;
        private string _ZR_QUOTE;
        private string _ZR_INDUSTRY;
        private string _ZR_PROXY;
        private string _ZR_CONTENT;
        private DateTime? _CRTIME;
        private string _ZR_GOV;
        private DateTime? _ZR_EDITTIME;
        private string _ZR_STATE;
        private string _ZR_USERID;
        private string _ZR_TYPE;
        private string _ZR_TAG;
        private string _ZN_ZJLY_YZ;
        private string _ZN_ZJLY_SK;
        private string _ZN_ZJLY_QT;
        private string _ZN_GSQ_KSSJ;
        private string _ZN_GSQ_JZSJ;
        private decimal? _ZR_QUOTES;

        /// <summary>
        /// 
        /// </summary>
        public decimal? ZR_ID
        {
            get { return _ZR_ID; }
            set
            {
                this.OnPropertyValueChange(_.ZR_ID, _ZR_ID, value);
                this._ZR_ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_UNIT
        {
            get { return _ZR_UNIT; }
            set
            {
                this.OnPropertyValueChange(_.ZR_UNIT, _ZR_UNIT, value);
                this._ZR_UNIT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_ADDRESS
        {
            get { return _ZR_ADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.ZR_ADDRESS, _ZR_ADDRESS, value);
                this._ZR_ADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_NAME
        {
            get { return _ZR_NAME; }
            set
            {
                this.OnPropertyValueChange(_.ZR_NAME, _ZR_NAME, value);
                this._ZR_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_PHONE
        {
            get { return _ZR_PHONE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_PHONE, _ZR_PHONE, value);
                this._ZR_PHONE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_POST
        {
            get { return _ZR_POST; }
            set
            {
                this.OnPropertyValueChange(_.ZR_POST, _ZR_POST, value);
                this._ZR_POST = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_FAX
        {
            get { return _ZR_FAX; }
            set
            {
                this.OnPropertyValueChange(_.ZR_FAX, _ZR_FAX, value);
                this._ZR_FAX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_EMAIL
        {
            get { return _ZR_EMAIL; }
            set
            {
                this.OnPropertyValueChange(_.ZR_EMAIL, _ZR_EMAIL, value);
                this._ZR_EMAIL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_BID
        {
            get { return _ZR_BID; }
            set
            {
                this.OnPropertyValueChange(_.ZR_BID, _ZR_BID, value);
                this._ZR_BID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_CODE
        {
            get { return _ZR_CODE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_CODE, _ZR_CODE, value);
                this._ZR_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_TITLE
        {
            get { return _ZR_TITLE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_TITLE, _ZR_TITLE, value);
                this._ZR_TITLE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_ZUNIT
        {
            get { return _ZR_ZUNIT; }
            set
            {
                this.OnPropertyValueChange(_.ZR_ZUNIT, _ZR_ZUNIT, value);
                this._ZR_ZUNIT = value;
            }
        }
        /// <summary>
        /// 字符
        /// </summary>
        public string ZR_QUOTE
        {
            get { return _ZR_QUOTE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_QUOTE, _ZR_QUOTE, value);
                this._ZR_QUOTE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_INDUSTRY
        {
            get { return _ZR_INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.ZR_INDUSTRY, _ZR_INDUSTRY, value);
                this._ZR_INDUSTRY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_PROXY
        {
            get { return _ZR_PROXY; }
            set
            {
                this.OnPropertyValueChange(_.ZR_PROXY, _ZR_PROXY, value);
                this._ZR_PROXY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_CONTENT
        {
            get { return _ZR_CONTENT; }
            set
            {
                this.OnPropertyValueChange(_.ZR_CONTENT, _ZR_CONTENT, value);
                this._ZR_CONTENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CRTIME
        {
            get { return _CRTIME; }
            set
            {
                this.OnPropertyValueChange(_.CRTIME, _CRTIME, value);
                this._CRTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_GOV
        {
            get { return _ZR_GOV; }
            set
            {
                this.OnPropertyValueChange(_.ZR_GOV, _ZR_GOV, value);
                this._ZR_GOV = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZR_EDITTIME
        {
            get { return _ZR_EDITTIME; }
            set
            {
                this.OnPropertyValueChange(_.ZR_EDITTIME, _ZR_EDITTIME, value);
                this._ZR_EDITTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_STATE
        {
            get { return _ZR_STATE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_STATE, _ZR_STATE, value);
                this._ZR_STATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_USERID
        {
            get { return _ZR_USERID; }
            set
            {
                this.OnPropertyValueChange(_.ZR_USERID, _ZR_USERID, value);
                this._ZR_USERID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_TYPE
        {
            get { return _ZR_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.ZR_TYPE, _ZR_TYPE, value);
                this._ZR_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZR_TAG
        {
            get { return _ZR_TAG; }
            set
            {
                this.OnPropertyValueChange(_.ZR_TAG, _ZR_TAG, value);
                this._ZR_TAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_YZ
        {
            get { return _ZN_ZJLY_YZ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_YZ, _ZN_ZJLY_YZ, value);
                this._ZN_ZJLY_YZ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_SK
        {
            get { return _ZN_ZJLY_SK; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_SK, _ZN_ZJLY_SK, value);
                this._ZN_ZJLY_SK = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_ZJLY_QT
        {
            get { return _ZN_ZJLY_QT; }
            set
            {
                this.OnPropertyValueChange(_.ZN_ZJLY_QT, _ZN_ZJLY_QT, value);
                this._ZN_ZJLY_QT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_GSQ_KSSJ
        {
            get { return _ZN_GSQ_KSSJ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_GSQ_KSSJ, _ZN_GSQ_KSSJ, value);
                this._ZN_GSQ_KSSJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZN_GSQ_JZSJ
        {
            get { return _ZN_GSQ_JZSJ; }
            set
            {
                this.OnPropertyValueChange(_.ZN_GSQ_JZSJ, _ZN_GSQ_JZSJ, value);
                this._ZN_GSQ_JZSJ = value;
            }
        }
        /// <summary>
        /// 数字
        /// </summary>
        public decimal? ZR_QUOTES
        {
            get { return _ZR_QUOTES; }
            set
            {
                this.OnPropertyValueChange(_.ZR_QUOTES, _ZR_QUOTES, value);
                this._ZR_QUOTES = value;
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
                _.ZR_ID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ZR_ID,
                _.ZR_UNIT,
                _.ZR_ADDRESS,
                _.ZR_NAME,
                _.ZR_PHONE,
                _.ZR_POST,
                _.ZR_FAX,
                _.ZR_EMAIL,
                _.ZR_BID,
                _.ZR_CODE,
                _.ZR_TITLE,
                _.ZR_ZUNIT,
                _.ZR_QUOTE,
                _.ZR_INDUSTRY,
                _.ZR_PROXY,
                _.ZR_CONTENT,
                _.CRTIME,
                _.ZR_GOV,
                _.ZR_EDITTIME,
                _.ZR_STATE,
                _.ZR_USERID,
                _.ZR_TYPE,
                _.ZR_TAG,
                _.ZN_ZJLY_YZ,
                _.ZN_ZJLY_SK,
                _.ZN_ZJLY_QT,
                _.ZN_GSQ_KSSJ,
                _.ZN_GSQ_JZSJ,
                _.ZR_QUOTES,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ZR_ID,
                this._ZR_UNIT,
                this._ZR_ADDRESS,
                this._ZR_NAME,
                this._ZR_PHONE,
                this._ZR_POST,
                this._ZR_FAX,
                this._ZR_EMAIL,
                this._ZR_BID,
                this._ZR_CODE,
                this._ZR_TITLE,
                this._ZR_ZUNIT,
                this._ZR_QUOTE,
                this._ZR_INDUSTRY,
                this._ZR_PROXY,
                this._ZR_CONTENT,
                this._CRTIME,
                this._ZR_GOV,
                this._ZR_EDITTIME,
                this._ZR_STATE,
                this._ZR_USERID,
                this._ZR_TYPE,
                this._ZR_TAG,
                this._ZN_ZJLY_YZ,
                this._ZN_ZJLY_SK,
                this._ZN_ZJLY_QT,
                this._ZN_GSQ_KSSJ,
                this._ZN_GSQ_JZSJ,
                this._ZR_QUOTES,
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
            public readonly static Field All = new Field("*", "ZP_RESULT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_ID = new Field("ZR_ID", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_UNIT = new Field("ZR_UNIT", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_ADDRESS = new Field("ZR_ADDRESS", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_NAME = new Field("ZR_NAME", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_PHONE = new Field("ZR_PHONE", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_POST = new Field("ZR_POST", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_FAX = new Field("ZR_FAX", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_EMAIL = new Field("ZR_EMAIL", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_BID = new Field("ZR_BID", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_CODE = new Field("ZR_CODE", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_TITLE = new Field("ZR_TITLE", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_ZUNIT = new Field("ZR_ZUNIT", "ZP_RESULT", "");
            /// <summary>
			/// 字符
			/// </summary>
			public readonly static Field ZR_QUOTE = new Field("ZR_QUOTE", "ZP_RESULT", "字符");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_INDUSTRY = new Field("ZR_INDUSTRY", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_PROXY = new Field("ZR_PROXY", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_CONTENT = new Field("ZR_CONTENT", "ZP_RESULT", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CRTIME = new Field("CRTIME", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_GOV = new Field("ZR_GOV", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_EDITTIME = new Field("ZR_EDITTIME", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_STATE = new Field("ZR_STATE", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_USERID = new Field("ZR_USERID", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_TYPE = new Field("ZR_TYPE", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZR_TAG = new Field("ZR_TAG", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_YZ = new Field("ZN_ZJLY_YZ", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_SK = new Field("ZN_ZJLY_SK", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_ZJLY_QT = new Field("ZN_ZJLY_QT", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_GSQ_KSSJ = new Field("ZN_GSQ_KSSJ", "ZP_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZN_GSQ_JZSJ = new Field("ZN_GSQ_JZSJ", "ZP_RESULT", "");
            /// <summary>
			/// 数字
			/// </summary>
			public readonly static Field ZR_QUOTES = new Field("ZR_QUOTES", "ZP_RESULT", "数字");
        }
        #endregion
    }
}