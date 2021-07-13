using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_ORDERID_NUM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_ORDERID_NUM")]
    [Serializable]
    public partial class BH_ORDERID_NUM : FwEntity
    {
        #region Model
        private string _GUID;
        private string _THISDATE;
        private int _THISNUM;

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
        /// 当天
        /// </summary>
        public string THISDATE
        {
            get { return _THISDATE; }
            set
            {
                this.OnPropertyValueChange(_.THISDATE, _THISDATE, value);
                this._THISDATE = value;
            }
        }
        /// <summary>
        /// 序列
        /// </summary>
        public int THISNUM
        {
            get { return _THISNUM; }
            set
            {
                this.OnPropertyValueChange(_.THISNUM, _THISNUM, value);
                this._THISNUM = value;
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
                _.THISDATE,
                _.THISNUM,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._THISDATE,
                this._THISNUM,
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
            public readonly static Field All = new Field("*", "BH_ORDERID_NUM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "BH_ORDERID_NUM", "");
            /// <summary>
			/// 当天
			/// </summary>
			public readonly static Field THISDATE = new Field("THISDATE", "BH_ORDERID_NUM", "当天");
            /// <summary>
			/// 序列
			/// </summary>
			public readonly static Field THISNUM = new Field("THISNUM", "BH_ORDERID_NUM", "序列");
        }
        #endregion
    }
}