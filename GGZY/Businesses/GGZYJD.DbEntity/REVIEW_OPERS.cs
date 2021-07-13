using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_OPERS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_OPERS")]
    [Serializable]
    public partial class REVIEW_OPERS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _NODE_ID;
		private string _OPERS;
		private string _TENDER_PROJECT_CODE;
		private decimal? _BA_ID;
		private string _QTR;

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
		public decimal? NODE_ID
		{
			get{ return _NODE_ID; }
			set
			{
				this.OnPropertyValueChange(_.NODE_ID, _NODE_ID, value);
				this._NODE_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPERS
		{
			get{ return _OPERS; }
			set
			{
				this.OnPropertyValueChange(_.OPERS, _OPERS, value);
				this._OPERS = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BA_ID
		{
			get{ return _BA_ID; }
			set
			{
				this.OnPropertyValueChange(_.BA_ID, _BA_ID, value);
				this._BA_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QTR
		{
			get{ return _QTR; }
			set
			{
				this.OnPropertyValueChange(_.QTR, _QTR, value);
				this._QTR = value;
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
				_.NODE_ID,
				_.OPERS,
				_.TENDER_PROJECT_CODE,
				_.BA_ID,
				_.QTR,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NODE_ID,
				this._OPERS,
				this._TENDER_PROJECT_CODE,
				this._BA_ID,
				this._QTR,
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
			public readonly static Field All = new Field("*", "REVIEW_OPERS");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_OPERS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NODE_ID = new Field("NODE_ID", "REVIEW_OPERS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPERS = new Field("OPERS", "REVIEW_OPERS", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "REVIEW_OPERS", "招标项目编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BA_ID = new Field("BA_ID", "REVIEW_OPERS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field QTR = new Field("QTR", "REVIEW_OPERS", "");
        }
        #endregion
	}
}