using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类THE_EEL_ROW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("THE_EEL_ROW")]
    [Serializable]
    public partial class THE_EEL_ROW : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _R_PRO;
		private string _BID_DOC;
		private string _R_SCORE;
		private string _R_RESUTL;
		private string _R_DATA;
		private string _REMARK;
		private DateTime? _OPEN_TIME;
		private string _TENDER_PROEJCT_CODE;
		private decimal? _ZHC_NUM;
		private decimal? _FHC_NUM;
		private decimal? _EXPERT_NUM;
		private decimal? _BIDDER_NUM;

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
		/// 评审项目
		/// </summary>
		public string R_PRO
		{
			get{ return _R_PRO; }
			set
			{
				this.OnPropertyValueChange(_.R_PRO, _R_PRO, value);
				this._R_PRO = value;
			}
		}
		/// <summary>
		/// 标书
		/// </summary>
		public string BID_DOC
		{
			get{ return _BID_DOC; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC, _BID_DOC, value);
				this._BID_DOC = value;
			}
		}
		/// <summary>
		/// 评审打分
		/// </summary>
		public string R_SCORE
		{
			get{ return _R_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.R_SCORE, _R_SCORE, value);
				this._R_SCORE = value;
			}
		}
		/// <summary>
		/// 评审结果
		/// </summary>
		public string R_RESUTL
		{
			get{ return _R_RESUTL; }
			set
			{
				this.OnPropertyValueChange(_.R_RESUTL, _R_RESUTL, value);
				this._R_RESUTL = value;
			}
		}
		/// <summary>
		/// 评审资料
		/// </summary>
		public string R_DATA
		{
			get{ return _R_DATA; }
			set
			{
				this.OnPropertyValueChange(_.R_DATA, _R_DATA, value);
				this._R_DATA = value;
			}
		}
		/// <summary>
		/// 备注
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
		public string TENDER_PROEJCT_CODE
		{
			get{ return _TENDER_PROEJCT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROEJCT_CODE, _TENDER_PROEJCT_CODE, value);
				this._TENDER_PROEJCT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZHC_NUM
		{
			get{ return _ZHC_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ZHC_NUM, _ZHC_NUM, value);
				this._ZHC_NUM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FHC_NUM
		{
			get{ return _FHC_NUM; }
			set
			{
				this.OnPropertyValueChange(_.FHC_NUM, _FHC_NUM, value);
				this._FHC_NUM = value;
			}
		}
		/// <summary>
		/// 评标专家数量
		/// </summary>
		public decimal? EXPERT_NUM
		{
			get{ return _EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NUM, _EXPERT_NUM, value);
				this._EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 投标企业数量
		/// </summary>
		public decimal? BIDDER_NUM
		{
			get{ return _BIDDER_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NUM, _BIDDER_NUM, value);
				this._BIDDER_NUM = value;
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
				_.R_PRO,
				_.BID_DOC,
				_.R_SCORE,
				_.R_RESUTL,
				_.R_DATA,
				_.REMARK,
				_.OPEN_TIME,
				_.TENDER_PROEJCT_CODE,
				_.ZHC_NUM,
				_.FHC_NUM,
				_.EXPERT_NUM,
				_.BIDDER_NUM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._R_PRO,
				this._BID_DOC,
				this._R_SCORE,
				this._R_RESUTL,
				this._R_DATA,
				this._REMARK,
				this._OPEN_TIME,
				this._TENDER_PROEJCT_CODE,
				this._ZHC_NUM,
				this._FHC_NUM,
				this._EXPERT_NUM,
				this._BIDDER_NUM,
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
			public readonly static Field All = new Field("*", "THE_EEL_ROW");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "THE_EEL_ROW", "ID");
            /// <summary>
			/// 评审项目
			/// </summary>
			public readonly static Field R_PRO = new Field("R_PRO", "THE_EEL_ROW", "评审项目");
            /// <summary>
			/// 标书
			/// </summary>
			public readonly static Field BID_DOC = new Field("BID_DOC", "THE_EEL_ROW", "标书");
            /// <summary>
			/// 评审打分
			/// </summary>
			public readonly static Field R_SCORE = new Field("R_SCORE", "THE_EEL_ROW", "评审打分");
            /// <summary>
			/// 评审结果
			/// </summary>
			public readonly static Field R_RESUTL = new Field("R_RESUTL", "THE_EEL_ROW", "评审结果");
            /// <summary>
			/// 评审资料
			/// </summary>
			public readonly static Field R_DATA = new Field("R_DATA", "THE_EEL_ROW", "评审资料");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "THE_EEL_ROW", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPEN_TIME = new Field("OPEN_TIME", "THE_EEL_ROW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROEJCT_CODE = new Field("TENDER_PROEJCT_CODE", "THE_EEL_ROW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZHC_NUM = new Field("ZHC_NUM", "THE_EEL_ROW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FHC_NUM = new Field("FHC_NUM", "THE_EEL_ROW", "");
            /// <summary>
			/// 评标专家数量
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "THE_EEL_ROW", "评标专家数量");
            /// <summary>
			/// 投标企业数量
			/// </summary>
			public readonly static Field BIDDER_NUM = new Field("BIDDER_NUM", "THE_EEL_ROW", "投标企业数量");
        }
        #endregion
	}
}