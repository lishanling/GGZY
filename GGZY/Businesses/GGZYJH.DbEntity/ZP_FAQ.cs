using System;
using System.Data;
using Dos.ORM;

namespace GGZYJH.DbEntity
{
    /// <summary>
    /// 实体类ZP_FAQ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZP_FAQ")]
    [Serializable]
    public partial class ZP_FAQ : JhEntity
    {
        #region Model
        private decimal? _ZF_ID;
        private string _ZF_TITLE;
        private string _ZF_QID;
        private string _ZF_QNAME;
        private string _ZF_AID;
        private string _ZF_ANAME;
        private string _ZF_TYPE;
        private DateTime? _ZF_QTIME;
        private DateTime? _ZF_ATIME;
        private decimal? _ZF_TID;
        private string _ZF_STATE;
        private DateTime? _CRTIME;
        private string _ZF_ANSWER;
        private string _ZF_QUESTION;

        /// <summary>
        /// 
        /// </summary>
        public decimal? ZF_ID
        {
            get { return _ZF_ID; }
            set
            {
                this.OnPropertyValueChange(_.ZF_ID, _ZF_ID, value);
                this._ZF_ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_TITLE
        {
            get { return _ZF_TITLE; }
            set
            {
                this.OnPropertyValueChange(_.ZF_TITLE, _ZF_TITLE, value);
                this._ZF_TITLE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_QID
        {
            get { return _ZF_QID; }
            set
            {
                this.OnPropertyValueChange(_.ZF_QID, _ZF_QID, value);
                this._ZF_QID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_QNAME
        {
            get { return _ZF_QNAME; }
            set
            {
                this.OnPropertyValueChange(_.ZF_QNAME, _ZF_QNAME, value);
                this._ZF_QNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_AID
        {
            get { return _ZF_AID; }
            set
            {
                this.OnPropertyValueChange(_.ZF_AID, _ZF_AID, value);
                this._ZF_AID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_ANAME
        {
            get { return _ZF_ANAME; }
            set
            {
                this.OnPropertyValueChange(_.ZF_ANAME, _ZF_ANAME, value);
                this._ZF_ANAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_TYPE
        {
            get { return _ZF_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.ZF_TYPE, _ZF_TYPE, value);
                this._ZF_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZF_QTIME
        {
            get { return _ZF_QTIME; }
            set
            {
                this.OnPropertyValueChange(_.ZF_QTIME, _ZF_QTIME, value);
                this._ZF_QTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ZF_ATIME
        {
            get { return _ZF_ATIME; }
            set
            {
                this.OnPropertyValueChange(_.ZF_ATIME, _ZF_ATIME, value);
                this._ZF_ATIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ZF_TID
        {
            get { return _ZF_TID; }
            set
            {
                this.OnPropertyValueChange(_.ZF_TID, _ZF_TID, value);
                this._ZF_TID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_STATE
        {
            get { return _ZF_STATE; }
            set
            {
                this.OnPropertyValueChange(_.ZF_STATE, _ZF_STATE, value);
                this._ZF_STATE = value;
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
        public string ZF_ANSWER
        {
            get { return _ZF_ANSWER; }
            set
            {
                this.OnPropertyValueChange(_.ZF_ANSWER, _ZF_ANSWER, value);
                this._ZF_ANSWER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZF_QUESTION
        {
            get { return _ZF_QUESTION; }
            set
            {
                this.OnPropertyValueChange(_.ZF_QUESTION, _ZF_QUESTION, value);
                this._ZF_QUESTION = value;
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
                _.ZF_ID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ZF_ID,
                _.ZF_TITLE,
                _.ZF_QID,
                _.ZF_QNAME,
                _.ZF_AID,
                _.ZF_ANAME,
                _.ZF_TYPE,
                _.ZF_QTIME,
                _.ZF_ATIME,
                _.ZF_TID,
                _.ZF_STATE,
                _.CRTIME,
                _.ZF_ANSWER,
                _.ZF_QUESTION,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ZF_ID,
                this._ZF_TITLE,
                this._ZF_QID,
                this._ZF_QNAME,
                this._ZF_AID,
                this._ZF_ANAME,
                this._ZF_TYPE,
                this._ZF_QTIME,
                this._ZF_ATIME,
                this._ZF_TID,
                this._ZF_STATE,
                this._CRTIME,
                this._ZF_ANSWER,
                this._ZF_QUESTION,
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
            public readonly static Field All = new Field("*", "ZP_FAQ");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_ID = new Field("ZF_ID", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_TITLE = new Field("ZF_TITLE", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_QID = new Field("ZF_QID", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_QNAME = new Field("ZF_QNAME", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_AID = new Field("ZF_AID", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_ANAME = new Field("ZF_ANAME", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_TYPE = new Field("ZF_TYPE", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_QTIME = new Field("ZF_QTIME", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_ATIME = new Field("ZF_ATIME", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_TID = new Field("ZF_TID", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_STATE = new Field("ZF_STATE", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CRTIME = new Field("CRTIME", "ZP_FAQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_ANSWER = new Field("ZF_ANSWER", "ZP_FAQ", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZF_QUESTION = new Field("ZF_QUESTION", "ZP_FAQ", DbType.AnsiString, null, "");
        }
        #endregion
    }
}
