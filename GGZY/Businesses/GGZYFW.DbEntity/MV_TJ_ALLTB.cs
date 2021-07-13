using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_TJ_ALLTB。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_TJ_ALLTB")]
    [Serializable]
    public partial class MV_TJ_ALLTB : FwEntity
    {
        #region Model
		private string _M;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _PLATFORM_CODE;
		private string _M_KEY;

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
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
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
				_.M,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.PLATFORM_CODE,
				_.M_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._PLATFORM_CODE,
				this._M_KEY,
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
			public readonly static Field All = new Field("*", "MV_TJ_ALLTB");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M = new Field("M", "MV_TJ_ALLTB", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_TJ_ALLTB", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "MV_TJ_ALLTB", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_TJ_ALLTB", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MV_TJ_ALLTB", "");
        }
        #endregion
	}
}