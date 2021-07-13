using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EVALUATION_RESULTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EVALUATION_RESULTS")]
    [Serializable]
    public partial class EVALUATION_RESULTS : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BIDDING_PROJECT;
		private string _MAIN_EVALUATION;
		private string _EVALUATION_MATERIALS;
		private string _REVIEW_RESULTS;
		private string _REMARKS;
		private string _TENDER_PROJECT_CODE;
		private DateTime? _OPEN_TIME;
		private string _BID_HOUXUANREN;
		private string _REMARK;

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
		/// 评标项目
		/// </summary>
		public string BIDDING_PROJECT
		{
			get{ return _BIDDING_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.BIDDING_PROJECT, _BIDDING_PROJECT, value);
				this._BIDDING_PROJECT = value;
			}
		}
		/// <summary>
		/// 主会场评标材料
		/// </summary>
		public string MAIN_EVALUATION
		{
			get{ return _MAIN_EVALUATION; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_EVALUATION, _MAIN_EVALUATION, value);
				this._MAIN_EVALUATION = value;
			}
		}
		/// <summary>
		/// 分会场评标材料
		/// </summary>
		public string EVALUATION_MATERIALS
		{
			get{ return _EVALUATION_MATERIALS; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_MATERIALS, _EVALUATION_MATERIALS, value);
				this._EVALUATION_MATERIALS = value;
			}
		}
		/// <summary>
		/// 评审结果
		/// </summary>
		public string REVIEW_RESULTS
		{
			get{ return _REVIEW_RESULTS; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_RESULTS, _REVIEW_RESULTS, value);
				this._REVIEW_RESULTS = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARKS
		{
			get{ return _REMARKS; }
			set
			{
				this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
				this._REMARKS = value;
			}
		}
		/// <summary>
		/// 
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
		public DateTime? OPEN_TIME
		{
			get{ return _OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_TIME, _OPEN_TIME, value);
				this._OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BID_HOUXUANREN
		{
			get{ return _BID_HOUXUANREN; }
			set
			{
				this.OnPropertyValueChange(_.BID_HOUXUANREN, _BID_HOUXUANREN, value);
				this._BID_HOUXUANREN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.BIDDING_PROJECT,
				_.MAIN_EVALUATION,
				_.EVALUATION_MATERIALS,
				_.REVIEW_RESULTS,
				_.REMARKS,
				_.TENDER_PROJECT_CODE,
				_.OPEN_TIME,
				_.BID_HOUXUANREN,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BIDDING_PROJECT,
				this._MAIN_EVALUATION,
				this._EVALUATION_MATERIALS,
				this._REVIEW_RESULTS,
				this._REMARKS,
				this._TENDER_PROJECT_CODE,
				this._OPEN_TIME,
				this._BID_HOUXUANREN,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "EVALUATION_RESULTS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "EVALUATION_RESULTS", "ID");
            /// <summary>
			/// 评标项目
			/// </summary>
			public readonly static Field BIDDING_PROJECT = new Field("BIDDING_PROJECT", "EVALUATION_RESULTS", "评标项目");
            /// <summary>
			/// 主会场评标材料
			/// </summary>
			public readonly static Field MAIN_EVALUATION = new Field("MAIN_EVALUATION", "EVALUATION_RESULTS", "主会场评标材料");
            /// <summary>
			/// 分会场评标材料
			/// </summary>
			public readonly static Field EVALUATION_MATERIALS = new Field("EVALUATION_MATERIALS", "EVALUATION_RESULTS", "分会场评标材料");
            /// <summary>
			/// 评审结果
			/// </summary>
			public readonly static Field REVIEW_RESULTS = new Field("REVIEW_RESULTS", "EVALUATION_RESULTS", "评审结果");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "EVALUATION_RESULTS", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "EVALUATION_RESULTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPEN_TIME = new Field("OPEN_TIME", "EVALUATION_RESULTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_HOUXUANREN = new Field("BID_HOUXUANREN", "EVALUATION_RESULTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "EVALUATION_RESULTS", "");
        }
        #endregion
	}
}