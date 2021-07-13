using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_WANZHENGLV_ZFCG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_WANZHENGLV_ZFCG")]
    [Serializable]
    public partial class MV_WANZHENGLV_ZFCG : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _M_DATA_SOURCE;
		private string _M_KEY;
		private string _REGION_CODE;
		private DateTime? _CREATE_TIME;
		private decimal? _采购公告;
		private decimal? _结果公告;
		private decimal? _采购合同;

		/// <summary>
		/// 
		/// </summary>
		public string PURCHASE_PROJECT_CODE
		{
			get{ return _PURCHASE_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_CODE, _PURCHASE_PROJECT_CODE, value);
				this._PURCHASE_PROJECT_CODE = value;
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
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 采购公告
		{
			get{ return _采购公告; }
			set
			{
				this.OnPropertyValueChange(_.采购公告, _采购公告, value);
				this._采购公告 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 结果公告
		{
			get{ return _结果公告; }
			set
			{
				this.OnPropertyValueChange(_.结果公告, _结果公告, value);
				this._结果公告 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 采购合同
		{
			get{ return _采购合同; }
			set
			{
				this.OnPropertyValueChange(_.采购合同, _采购合同, value);
				this._采购合同 = value;
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
				_.PURCHASE_PROJECT_CODE,
				_.M_DATA_SOURCE,
				_.M_KEY,
				_.REGION_CODE,
				_.CREATE_TIME,
				_.采购公告,
				_.结果公告,
				_.采购合同,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PURCHASE_PROJECT_CODE,
				this._M_DATA_SOURCE,
				this._M_KEY,
				this._REGION_CODE,
				this._CREATE_TIME,
				this._采购公告,
				this._结果公告,
				this._采购合同,
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
			public readonly static Field All = new Field("*", "MV_WANZHENGLV_ZFCG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 采购公告 = new Field("采购公告", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 结果公告 = new Field("结果公告", "MV_WANZHENGLV_ZFCG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 采购合同 = new Field("采购合同", "MV_WANZHENGLV_ZFCG", "");
        }
        #endregion
	}
}