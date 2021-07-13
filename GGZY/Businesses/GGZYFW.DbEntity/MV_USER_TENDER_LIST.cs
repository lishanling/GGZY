using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_USER_TENDER_LIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_USER_TENDER_LIST")]
    [Serializable]
    public partial class MV_USER_TENDER_LIST : FwEntity
    {
        #region Model
		private string _LEGAL_NAME;
		private string _SHI;
		private string _LEGAL_CODE;
		private decimal? _COUNT;
		private decimal? _WIN_COUNT;
		private decimal? _RATE;
		private string _AREACODE;

		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_NAME
		{
			get{ return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SHI
		{
			get{ return _SHI; }
			set
			{
				this.OnPropertyValueChange(_.SHI, _SHI, value);
				this._SHI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COUNT
		{
			get{ return _COUNT; }
			set
			{
				this.OnPropertyValueChange(_.COUNT, _COUNT, value);
				this._COUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WIN_COUNT
		{
			get{ return _WIN_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.WIN_COUNT, _WIN_COUNT, value);
				this._WIN_COUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RATE
		{
			get{ return _RATE; }
			set
			{
				this.OnPropertyValueChange(_.RATE, _RATE, value);
				this._RATE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
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
				_.LEGAL_NAME,
				_.SHI,
				_.LEGAL_CODE,
				_.COUNT,
				_.WIN_COUNT,
				_.RATE,
				_.AREACODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._LEGAL_NAME,
				this._SHI,
				this._LEGAL_CODE,
				this._COUNT,
				this._WIN_COUNT,
				this._RATE,
				this._AREACODE,
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
			public readonly static Field All = new Field("*", "MV_USER_TENDER_LIST");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SHI = new Field("SHI", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COUNT = new Field("COUNT", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WIN_COUNT = new Field("WIN_COUNT", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RATE = new Field("RATE", "MV_USER_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "MV_USER_TENDER_LIST", "");
        }
        #endregion
	}
}