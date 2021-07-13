using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_LINK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_LINK")]
    [Serializable]
    public partial class PT_LINK : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _ADDRESS;
		private string _TYPE;
		private DateTime? _TIME;
		private decimal? _ORDERID;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TIME
		{
			get{ return _TIME; }
			set
			{
				this.OnPropertyValueChange(_.TIME, _TIME, value);
				this._TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
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
				_.TITLE,
				_.ADDRESS,
				_.TYPE,
				_.TIME,
				_.ORDERID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._ADDRESS,
				this._TYPE,
				this._TIME,
				this._ORDERID,
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
			public readonly static Field All = new Field("*", "PT_LINK");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_LINK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "PT_LINK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "PT_LINK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "PT_LINK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TIME = new Field("TIME", "PT_LINK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "PT_LINK", "");
        }
        #endregion
	}
}