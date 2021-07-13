using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_HISTORY_DISHI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_HISTORY_DISHI")]
    [Serializable]
    public partial class MV_HISTORY_DISHI : FwEntity
    {
        #region Model
		private decimal? _SUM;
		private string _M;
		private string _M_DATA_SOURCE;
		private string _PLATFORM_CODE;

		/// <summary>
		/// 
		/// </summary>
		public decimal? SUM
		{
			get{ return _SUM; }
			set
			{
				this.OnPropertyValueChange(_.SUM, _SUM, value);
				this._SUM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M
		{
			get{ return _M; }
			set
			{
				this.OnPropertyValueChange(_.M, _M, value);
				this._M = value;
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
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
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
				_.SUM,
				_.M,
				_.M_DATA_SOURCE,
				_.PLATFORM_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._SUM,
				this._M,
				this._M_DATA_SOURCE,
				this._PLATFORM_CODE,
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
			public readonly static Field All = new Field("*", "MV_HISTORY_DISHI");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUM = new Field("SUM", "MV_HISTORY_DISHI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M = new Field("M", "MV_HISTORY_DISHI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_HISTORY_DISHI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_HISTORY_DISHI", "");
        }
        #endregion
	}
}