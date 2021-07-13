using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_WANZHENGLV_GCJS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_WANZHENGLV_GCJS")]
    [Serializable]
    public partial class MV_WANZHENGLV_GCJS : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_MODE;
		private string _M_DATA_SOURCE;
		private string _M_KEY;
		private DateTime? _OPEN_TIME;
		private decimal? _标段;
		private decimal? _公告;
		private decimal? _投标邀请书;
		private decimal? _招标文件;
		private decimal? _开标记录;
		private decimal? _投标人;
		private decimal? _评标专家;
		private decimal? _评标报告;
		private decimal? _候选人;
		private decimal? _候选人公示;
		private decimal? _中标结果公示;
		private decimal? _特征码;
		private decimal? _评标明细;

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
		public string TENDER_MODE
		{
			get{ return _TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
				this._TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
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
		public decimal? 标段
		{
			get{ return _标段; }
			set
			{
				this.OnPropertyValueChange(_.标段, _标段, value);
				this._标段 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 公告
		{
			get{ return _公告; }
			set
			{
				this.OnPropertyValueChange(_.公告, _公告, value);
				this._公告 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 投标邀请书
		{
			get{ return _投标邀请书; }
			set
			{
				this.OnPropertyValueChange(_.投标邀请书, _投标邀请书, value);
				this._投标邀请书 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 招标文件
		{
			get{ return _招标文件; }
			set
			{
				this.OnPropertyValueChange(_.招标文件, _招标文件, value);
				this._招标文件 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 开标记录
		{
			get{ return _开标记录; }
			set
			{
				this.OnPropertyValueChange(_.开标记录, _开标记录, value);
				this._开标记录 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 投标人
		{
			get{ return _投标人; }
			set
			{
				this.OnPropertyValueChange(_.投标人, _投标人, value);
				this._投标人 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 评标专家
		{
			get{ return _评标专家; }
			set
			{
				this.OnPropertyValueChange(_.评标专家, _评标专家, value);
				this._评标专家 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 评标报告
		{
			get{ return _评标报告; }
			set
			{
				this.OnPropertyValueChange(_.评标报告, _评标报告, value);
				this._评标报告 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 候选人
		{
			get{ return _候选人; }
			set
			{
				this.OnPropertyValueChange(_.候选人, _候选人, value);
				this._候选人 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 候选人公示
		{
			get{ return _候选人公示; }
			set
			{
				this.OnPropertyValueChange(_.候选人公示, _候选人公示, value);
				this._候选人公示 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 中标结果公示
		{
			get{ return _中标结果公示; }
			set
			{
				this.OnPropertyValueChange(_.中标结果公示, _中标结果公示, value);
				this._中标结果公示 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 特征码
		{
			get{ return _特征码; }
			set
			{
				this.OnPropertyValueChange(_.特征码, _特征码, value);
				this._特征码 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 评标明细
		{
			get{ return _评标明细; }
			set
			{
				this.OnPropertyValueChange(_.评标明细, _评标明细, value);
				this._评标明细 = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDER_PROJECT_CODE,
				_.TENDER_MODE,
				_.M_DATA_SOURCE,
				_.M_KEY,
				_.OPEN_TIME,
				_.标段,
				_.公告,
				_.投标邀请书,
				_.招标文件,
				_.开标记录,
				_.投标人,
				_.评标专家,
				_.评标报告,
				_.候选人,
				_.候选人公示,
				_.中标结果公示,
				_.特征码,
				_.评标明细,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._TENDER_MODE,
				this._M_DATA_SOURCE,
				this._M_KEY,
				this._OPEN_TIME,
				this._标段,
				this._公告,
				this._投标邀请书,
				this._招标文件,
				this._开标记录,
				this._投标人,
				this._评标专家,
				this._评标报告,
				this._候选人,
				this._候选人公示,
				this._中标结果公示,
				this._特征码,
				this._评标明细,
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
			public readonly static Field All = new Field("*", "MV_WANZHENGLV_GCJS");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPEN_TIME = new Field("OPEN_TIME", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 标段 = new Field("标段", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 公告 = new Field("公告", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 投标邀请书 = new Field("投标邀请书", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 招标文件 = new Field("招标文件", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 开标记录 = new Field("开标记录", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 投标人 = new Field("投标人", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 评标专家 = new Field("评标专家", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 评标报告 = new Field("评标报告", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 候选人 = new Field("候选人", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 候选人公示 = new Field("候选人公示", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 中标结果公示 = new Field("中标结果公示", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 特征码 = new Field("特征码", "MV_WANZHENGLV_GCJS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 评标明细 = new Field("评标明细", "MV_WANZHENGLV_GCJS", "");
        }
        #endregion
	}
}