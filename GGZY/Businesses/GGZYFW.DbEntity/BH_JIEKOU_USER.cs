using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_JIEKOU_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_JIEKOU_USER")]
    [Serializable]
    public partial class BH_JIEKOU_USER : FwEntity
    {
        #region Model
        private int _ID;
        private string _NAME;
        private string _SYSTEM_NO;
        private string _SECRET;
        private string _CENTER_NAME;
        private string _INDUSTRY_NAME;
        private string _TYPE;
        private string _SYSTEM_CREDIT_CODE;
        private string _SYSTEM_CONTACT_NAME;
        private string _SYSTEM_CONTACT_TEL;
        private string _SHOW_NAME;
        private string _SEND_URL;
        private string _PARTEN_CENTER_NAME;
        private decimal? _ORDERBY;
        private string _REGION;

        /// <summary>
        /// 
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
        /// 系统名称，承保人系统或交易系统
        /// </summary>
        public string NAME
        {
            get { return _NAME; }
            set
            {
                this.OnPropertyValueChange(_.NAME, _NAME, value);
                this._NAME = value;
            }
        }
        /// <summary>
        /// 系统编号
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
        /// 密钥
        /// </summary>
        public string SECRET
        {
            get { return _SECRET; }
            set
            {
                this.OnPropertyValueChange(_.SECRET, _SECRET, value);
                this._SECRET = value;
            }
        }
        /// <summary>
        /// 交易中心名称
        /// </summary>
        public string CENTER_NAME
        {
            get { return _CENTER_NAME; }
            set
            {
                this.OnPropertyValueChange(_.CENTER_NAME, _CENTER_NAME, value);
                this._CENTER_NAME = value;
            }
        }
        /// <summary>
        /// 行业名称名称
        /// </summary>
        public string INDUSTRY_NAME
        {
            get { return _INDUSTRY_NAME; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY_NAME, _INDUSTRY_NAME, value);
                this._INDUSTRY_NAME = value;
            }
        }
        /// <summary>
        /// 类型，1承保人系统，2交易系统
        /// </summary>
        public string TYPE
        {
            get { return _TYPE; }
            set
            {
                this.OnPropertyValueChange(_.TYPE, _TYPE, value);
                this._TYPE = value;
            }
        }
        /// <summary>
        /// 统一社会代码
        /// </summary>
        public string SYSTEM_CREDIT_CODE
        {
            get { return _SYSTEM_CREDIT_CODE; }
            set
            {
                this.OnPropertyValueChange(_.SYSTEM_CREDIT_CODE, _SYSTEM_CREDIT_CODE, value);
                this._SYSTEM_CREDIT_CODE = value;
            }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string SYSTEM_CONTACT_NAME
        {
            get { return _SYSTEM_CONTACT_NAME; }
            set
            {
                this.OnPropertyValueChange(_.SYSTEM_CONTACT_NAME, _SYSTEM_CONTACT_NAME, value);
                this._SYSTEM_CONTACT_NAME = value;
            }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string SYSTEM_CONTACT_TEL
        {
            get { return _SYSTEM_CONTACT_TEL; }
            set
            {
                this.OnPropertyValueChange(_.SYSTEM_CONTACT_TEL, _SYSTEM_CONTACT_TEL, value);
                this._SYSTEM_CONTACT_TEL = value;
            }
        }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string SHOW_NAME
        {
            get { return _SHOW_NAME; }
            set
            {
                this.OnPropertyValueChange(_.SHOW_NAME, _SHOW_NAME, value);
                this._SHOW_NAME = value;
            }
        }
        /// <summary>
        /// 申请单发送地址
        /// </summary>
        public string SEND_URL
        {
            get { return _SEND_URL; }
            set
            {
                this.OnPropertyValueChange(_.SEND_URL, _SEND_URL, value);
                this._SEND_URL = value;
            }
        }
        /// <summary>
        /// 父交易中心名称
        /// </summary>
        public string PARTEN_CENTER_NAME
        {
            get { return _PARTEN_CENTER_NAME; }
            set
            {
                this.OnPropertyValueChange(_.PARTEN_CENTER_NAME, _PARTEN_CENTER_NAME, value);
                this._PARTEN_CENTER_NAME = value;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public decimal? ORDERBY
        {
            get { return _ORDERBY; }
            set
            {
                this.OnPropertyValueChange(_.ORDERBY, _ORDERBY, value);
                this._ORDERBY = value;
            }
        }
        /// <summary>
        /// 地区
        /// </summary>
        public string REGION
        {
            get { return _REGION; }
            set
            {
                this.OnPropertyValueChange(_.REGION, _REGION, value);
                this._REGION = value;
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
                _.NAME,
                _.SYSTEM_NO,
                _.SECRET,
                _.CENTER_NAME,
                _.INDUSTRY_NAME,
                _.TYPE,
                _.SYSTEM_CREDIT_CODE,
                _.SYSTEM_CONTACT_NAME,
                _.SYSTEM_CONTACT_TEL,
                _.SHOW_NAME,
                _.SEND_URL,
                _.PARTEN_CENTER_NAME,
                _.ORDERBY,
                _.REGION,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ID,
                this._NAME,
                this._SYSTEM_NO,
                this._SECRET,
                this._CENTER_NAME,
                this._INDUSTRY_NAME,
                this._TYPE,
                this._SYSTEM_CREDIT_CODE,
                this._SYSTEM_CONTACT_NAME,
                this._SYSTEM_CONTACT_TEL,
                this._SHOW_NAME,
                this._SEND_URL,
                this._PARTEN_CENTER_NAME,
                this._ORDERBY,
                this._REGION,
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
            public readonly static Field All = new Field("*", "BH_JIEKOU_USER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "BH_JIEKOU_USER", "");
            /// <summary>
			/// 系统名称，承保人系统或交易系统
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "BH_JIEKOU_USER", "系统名称，承保人系统或交易系统");
            /// <summary>
			/// 系统编号
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "BH_JIEKOU_USER", "系统编号");
            /// <summary>
			/// 密钥
			/// </summary>
			public readonly static Field SECRET = new Field("SECRET", "BH_JIEKOU_USER", "密钥");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "BH_JIEKOU_USER", "交易中心名称");
            /// <summary>
			/// 行业名称名称
			/// </summary>
			public readonly static Field INDUSTRY_NAME = new Field("INDUSTRY_NAME", "BH_JIEKOU_USER", "行业名称名称");
            /// <summary>
			/// 类型，1承保人系统，2交易系统
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "BH_JIEKOU_USER", "类型，1承保人系统，2交易系统");
            /// <summary>
			/// 统一社会代码
			/// </summary>
			public readonly static Field SYSTEM_CREDIT_CODE = new Field("SYSTEM_CREDIT_CODE", "BH_JIEKOU_USER", "统一社会代码");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field SYSTEM_CONTACT_NAME = new Field("SYSTEM_CONTACT_NAME", "BH_JIEKOU_USER", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field SYSTEM_CONTACT_TEL = new Field("SYSTEM_CONTACT_TEL", "BH_JIEKOU_USER", "联系电话");
            /// <summary>
			/// 显示名称
			/// </summary>
			public readonly static Field SHOW_NAME = new Field("SHOW_NAME", "BH_JIEKOU_USER", "显示名称");
            /// <summary>
			/// 申请单发送地址
			/// </summary>
			public readonly static Field SEND_URL = new Field("SEND_URL", "BH_JIEKOU_USER", "申请单发送地址");
            /// <summary>
			/// 父交易中心名称
			/// </summary>
			public readonly static Field PARTEN_CENTER_NAME = new Field("PARTEN_CENTER_NAME", "BH_JIEKOU_USER", "父交易中心名称");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDERBY = new Field("ORDERBY", "BH_JIEKOU_USER", "排序");
            /// <summary>
			/// 地区
			/// </summary>
			public readonly static Field REGION = new Field("REGION", "BH_JIEKOU_USER", "地区");
        }
        #endregion
    }
}