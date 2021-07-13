using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EVALUATION_RESULTS_BIDDER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EVALUATION_RESULTS_BIDDER")]
    [Serializable]
    public partial class EVALUATION_RESULTS_BIDDER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BIDDER;
		private decimal? _SORT;
		private decimal? _IS_DELETE;
		private decimal? _FID;

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
		/// 候选人名称
		/// </summary>
		public string BIDDER
		{
			get{ return _BIDDER; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER, _BIDDER, value);
				this._BIDDER = value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? SORT
		{
			get{ return _SORT; }
			set
			{
				this.OnPropertyValueChange(_.SORT, _SORT, value);
				this._SORT = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
			}
		}
		/// <summary>
		/// EVALUATION_RESULTS 关联ID
		/// </summary>
		public decimal? FID
		{
			get{ return _FID; }
			set
			{
				this.OnPropertyValueChange(_.FID, _FID, value);
				this._FID = value;
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
				_.BIDDER,
				_.SORT,
				_.IS_DELETE,
				_.FID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BIDDER,
				this._SORT,
				this._IS_DELETE,
				this._FID,
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
			public readonly static Field All = new Field("*", "EVALUATION_RESULTS_BIDDER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "EVALUATION_RESULTS_BIDDER", "ID");
            /// <summary>
			/// 候选人名称
			/// </summary>
			public readonly static Field BIDDER = new Field("BIDDER", "EVALUATION_RESULTS_BIDDER", "候选人名称");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "EVALUATION_RESULTS_BIDDER", "排序");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "EVALUATION_RESULTS_BIDDER", "是否删除");
            /// <summary>
			/// EVALUATION_RESULTS 关联ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "EVALUATION_RESULTS_BIDDER", "EVALUATION_RESULTS 关联ID");
        }
        #endregion
	}
}