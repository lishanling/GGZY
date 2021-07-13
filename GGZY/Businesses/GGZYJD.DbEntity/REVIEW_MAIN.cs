using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_MAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_MAIN")]
    [Serializable]
    public partial class REVIEW_MAIN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private decimal? _IS_ENABLE;
		private decimal? _SC_TYPE;
		private string _REAMRK;
		private decimal? _ORDERID;

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
		/// 审查机制名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 审查类型
		/// </summary>
		public decimal? SC_TYPE
		{
			get{ return _SC_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SC_TYPE, _SC_TYPE, value);
				this._SC_TYPE = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REAMRK
		{
			get{ return _REAMRK; }
			set
			{
				this.OnPropertyValueChange(_.REAMRK, _REAMRK, value);
				this._REAMRK = value;
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
				_.NAME,
				_.IS_ENABLE,
				_.SC_TYPE,
				_.REAMRK,
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
				this._NAME,
				this._IS_ENABLE,
				this._SC_TYPE,
				this._REAMRK,
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
			public readonly static Field All = new Field("*", "REVIEW_MAIN");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_MAIN", "ID");
            /// <summary>
			/// 审查机制名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "REVIEW_MAIN", "审查机制名称");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "REVIEW_MAIN", "是否启用");
            /// <summary>
			/// 审查类型
			/// </summary>
			public readonly static Field SC_TYPE = new Field("SC_TYPE", "REVIEW_MAIN", "审查类型");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REAMRK = new Field("REAMRK", "REVIEW_MAIN", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "REVIEW_MAIN", "");
        }
        #endregion
	}
}