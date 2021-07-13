using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_JIEKOU_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_JIEKOU_LOG")]
    [Serializable]
    public partial class BH_JIEKOU_LOG : FwEntity
    {
        #region Model
        private string _GUID;
        private string _SYSTEM_NO;
        private string _DATA_KEY;
        private DateTime? _CREATE_TIME;
        private string _LOGTYPE;

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
        /// 
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
        /// 
        /// </summary>
        public string DATA_KEY
        {
            get { return _DATA_KEY; }
            set
            {
                this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
                this._DATA_KEY = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public string LOGTYPE
        {
            get { return _LOGTYPE; }
            set
            {
                this.OnPropertyValueChange(_.LOGTYPE, _LOGTYPE, value);
                this._LOGTYPE = value;
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
                _.SYSTEM_NO,
                _.DATA_KEY,
                _.CREATE_TIME,
                _.LOGTYPE,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._SYSTEM_NO,
                this._DATA_KEY,
                this._CREATE_TIME,
                this._LOGTYPE,
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
            public readonly static Field All = new Field("*", "BH_JIEKOU_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "BH_JIEKOU_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "BH_JIEKOU_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "BH_JIEKOU_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_JIEKOU_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOGTYPE = new Field("LOGTYPE", "BH_JIEKOU_LOG", "");
        }
        #endregion
    }
}