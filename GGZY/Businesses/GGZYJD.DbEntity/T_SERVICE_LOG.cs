using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_SERVICE_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SERVICE_LOG")]
    [Serializable]
    public partial class T_SERVICE_LOG : JdEntity
    {
        #region Model
		private DateTime? _TM;
		private string _RES;
		private decimal? _ID;
		private string _DATA_KEY;
		private string _SYSTEMCODE;
		private string _TABLENAME;
		private string _NOTICE_KEY;
		private string _REVIEW_KEY;

		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string RES
		{
			get{ return _RES; }
			set
			{
				this.OnPropertyValueChange(_.RES, _RES, value);
				this._RES = value;
			}
		}
		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 交易平台编码
		/// </summary>
		public string SYSTEMCODE
		{
			get{ return _SYSTEMCODE; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEMCODE, _SYSTEMCODE, value);
				this._SYSTEMCODE = value;
			}
		}
		/// <summary>
		/// 表名
		/// </summary>
		public string TABLENAME
		{
			get{ return _TABLENAME; }
			set
			{
				this.OnPropertyValueChange(_.TABLENAME, _TABLENAME, value);
				this._TABLENAME = value;
			}
		}
		/// <summary>
		/// 原招标公告的data_key
		/// </summary>
		public string NOTICE_KEY
		{
			get{ return _NOTICE_KEY; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_KEY, _NOTICE_KEY, value);
				this._NOTICE_KEY = value;
			}
		}
		/// <summary>
		/// 备案审查的key
		/// </summary>
		public string REVIEW_KEY
		{
			get{ return _REVIEW_KEY; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_KEY, _REVIEW_KEY, value);
				this._REVIEW_KEY = value;
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
				_.TM,
				_.RES,
				_.ID,
				_.DATA_KEY,
				_.SYSTEMCODE,
				_.TABLENAME,
				_.NOTICE_KEY,
				_.REVIEW_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TM,
				this._RES,
				this._ID,
				this._DATA_KEY,
				this._SYSTEMCODE,
				this._TABLENAME,
				this._NOTICE_KEY,
				this._REVIEW_KEY,
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
			public readonly static Field All = new Field("*", "T_SERVICE_LOG");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_SERVICE_LOG", "时间");
            /// <summary>
			/// 内容
			/// </summary>
			public readonly static Field RES = new Field("RES", "T_SERVICE_LOG",DbType.AnsiString, null, "内容");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SERVICE_LOG", "ID");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_SERVICE_LOG", "DATA_KEY");
            /// <summary>
			/// 交易平台编码
			/// </summary>
			public readonly static Field SYSTEMCODE = new Field("SYSTEMCODE", "T_SERVICE_LOG", "交易平台编码");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TABLENAME = new Field("TABLENAME", "T_SERVICE_LOG", "表名");
            /// <summary>
			/// 原招标公告的data_key
			/// </summary>
			public readonly static Field NOTICE_KEY = new Field("NOTICE_KEY", "T_SERVICE_LOG", "原招标公告的data_key");
            /// <summary>
			/// 备案审查的key
			/// </summary>
			public readonly static Field REVIEW_KEY = new Field("REVIEW_KEY", "T_SERVICE_LOG", "备案审查的key");
        }
        #endregion
	}
}