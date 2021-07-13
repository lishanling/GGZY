using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EVALUATION_RESULTS_SCORE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EVALUATION_RESULTS_SCORE")]
    [Serializable]
    public partial class EVALUATION_RESULTS_SCORE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BIDDER;
		private string _RESULT;
		private decimal? _SCORE;
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
		/// 评标结果
		/// </summary>
		public string RESULT
		{
			get{ return _RESULT; }
			set
			{
				this.OnPropertyValueChange(_.RESULT, _RESULT, value);
				this._RESULT = value;
			}
		}
		/// <summary>
		/// 评标得分
		/// </summary>
		public decimal? SCORE
		{
			get{ return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
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
				_.RESULT,
				_.SCORE,
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
				this._RESULT,
				this._SCORE,
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
			public readonly static Field All = new Field("*", "EVALUATION_RESULTS_SCORE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "EVALUATION_RESULTS_SCORE", "ID");
            /// <summary>
			/// 候选人名称
			/// </summary>
			public readonly static Field BIDDER = new Field("BIDDER", "EVALUATION_RESULTS_SCORE", "候选人名称");
            /// <summary>
			/// 评标结果
			/// </summary>
			public readonly static Field RESULT = new Field("RESULT", "EVALUATION_RESULTS_SCORE", "评标结果");
            /// <summary>
			/// 评标得分
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "EVALUATION_RESULTS_SCORE", "评标得分");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "EVALUATION_RESULTS_SCORE", "是否删除");
            /// <summary>
			/// EVALUATION_RESULTS 关联ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "EVALUATION_RESULTS_SCORE", "EVALUATION_RESULTS 关联ID");
        }
        #endregion
	}
}