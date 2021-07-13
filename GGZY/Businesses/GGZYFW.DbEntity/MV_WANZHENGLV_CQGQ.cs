using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_WANZHENGLV_CQGQ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_WANZHENGLV_CQGQ")]
    [Serializable]
    public partial class MV_WANZHENGLV_CQGQ : FwEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _M_DATA_SOURCE;
		private DateTime? _PUBLISH_DATE;
		private string _M_KEY;
		private decimal? _转让企业;
		private decimal? _交易结果;

		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		public DateTime? PUBLISH_DATE
		{
			get{ return _PUBLISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DATE, _PUBLISH_DATE, value);
				this._PUBLISH_DATE = value;
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
		public decimal? 转让企业
		{
			get{ return _转让企业; }
			set
			{
				this.OnPropertyValueChange(_.转让企业, _转让企业, value);
				this._转让企业 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 交易结果
		{
			get{ return _交易结果; }
			set
			{
				this.OnPropertyValueChange(_.交易结果, _交易结果, value);
				this._交易结果 = value;
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
				_.PROJECT_CODE,
				_.M_DATA_SOURCE,
				_.PUBLISH_DATE,
				_.M_KEY,
				_.转让企业,
				_.交易结果,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._M_DATA_SOURCE,
				this._PUBLISH_DATE,
				this._M_KEY,
				this._转让企业,
				this._交易结果,
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
			public readonly static Field All = new Field("*", "MV_WANZHENGLV_CQGQ");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "MV_WANZHENGLV_CQGQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_WANZHENGLV_CQGQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUBLISH_DATE = new Field("PUBLISH_DATE", "MV_WANZHENGLV_CQGQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MV_WANZHENGLV_CQGQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 转让企业 = new Field("转让企业", "MV_WANZHENGLV_CQGQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 交易结果 = new Field("交易结果", "MV_WANZHENGLV_CQGQ", "");
        }
        #endregion
	}
}