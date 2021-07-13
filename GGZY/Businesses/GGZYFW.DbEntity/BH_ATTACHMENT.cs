using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_ATTACHMENT")]
    [Serializable]
    public partial class BH_ATTACHMENT : FwEntity
    {
        #region Model
        private string _ID;
        private string _NAME;
        private string _URL;
        private string _MD5;

        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange(_.ID, _ID, value);
                this._ID = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
                _.NAME,
                _.URL,
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
                this._NAME,
                this._URL,
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
            public readonly static Field All = new Field("*", "BH_ATTACHMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "BH_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "BH_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "BH_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "BH_ATTACHMENT", "");
        }
        #endregion
    }
}