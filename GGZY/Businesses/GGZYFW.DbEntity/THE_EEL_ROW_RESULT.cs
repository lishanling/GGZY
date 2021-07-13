using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类THE_EEL_ROW_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("THE_EEL_ROW_RESULT")]
    [Serializable]
    public partial class THE_EEL_ROW_RESULT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BIDDER;
		private string _REAL_NAME;
		private string _ID_CARD;
		private string _RESULT;
		private decimal? _BUSINESS_SCORE;
		private decimal? _TECHNOLOGY_SCORE;
		private string _REMARK;
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
		/// 投标人名称
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
		/// 专家姓名
		/// </summary>
		public string REAL_NAME
		{
			get{ return _REAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.REAL_NAME, _REAL_NAME, value);
				this._REAL_NAME = value;
			}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
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
		/// 商务得分
		/// </summary>
		public decimal? BUSINESS_SCORE
		{
			get{ return _BUSINESS_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_SCORE, _BUSINESS_SCORE, value);
				this._BUSINESS_SCORE = value;
			}
		}
		/// <summary>
		/// 技术得分
		/// </summary>
		public decimal? TECHNOLOGY_SCORE
		{
			get{ return _TECHNOLOGY_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.TECHNOLOGY_SCORE, _TECHNOLOGY_SCORE, value);
				this._TECHNOLOGY_SCORE = value;
			}
		}
		/// <summary>
		/// 评标说明
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
		/// THE_EEL_ROW关联ID
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
				_.REAL_NAME,
				_.ID_CARD,
				_.RESULT,
				_.BUSINESS_SCORE,
				_.TECHNOLOGY_SCORE,
				_.REMARK,
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
				this._REAL_NAME,
				this._ID_CARD,
				this._RESULT,
				this._BUSINESS_SCORE,
				this._TECHNOLOGY_SCORE,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "THE_EEL_ROW_RESULT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "THE_EEL_ROW_RESULT", "ID");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER = new Field("BIDDER", "THE_EEL_ROW_RESULT", "投标人名称");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field REAL_NAME = new Field("REAL_NAME", "THE_EEL_ROW_RESULT", "专家姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "THE_EEL_ROW_RESULT", "身份证号码");
            /// <summary>
			/// 评标结果
			/// </summary>
			public readonly static Field RESULT = new Field("RESULT", "THE_EEL_ROW_RESULT", "评标结果");
            /// <summary>
			/// 商务得分
			/// </summary>
			public readonly static Field BUSINESS_SCORE = new Field("BUSINESS_SCORE", "THE_EEL_ROW_RESULT", "商务得分");
            /// <summary>
			/// 技术得分
			/// </summary>
			public readonly static Field TECHNOLOGY_SCORE = new Field("TECHNOLOGY_SCORE", "THE_EEL_ROW_RESULT", "技术得分");
            /// <summary>
			/// 评标说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "THE_EEL_ROW_RESULT", "评标说明");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "THE_EEL_ROW_RESULT", "是否删除");
            /// <summary>
			/// THE_EEL_ROW关联ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "THE_EEL_ROW_RESULT", "THE_EEL_ROW关联ID");
        }
        #endregion
	}
}