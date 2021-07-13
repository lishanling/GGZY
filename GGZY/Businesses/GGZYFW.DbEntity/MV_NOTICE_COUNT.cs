using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_NOTICE_COUNT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_NOTICE_COUNT")]
    [Serializable]
    public partial class MV_NOTICE_COUNT : FwEntity
    {
        #region Model
		private decimal? _AMOUNT;
		private string _PLATFORM_CODE;
		private string _TYPE;
		private string _M;
		private string _TB;

		/// <summary>
		/// 
		/// </summary>
		public decimal? AMOUNT
		{
			get{ return _AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.AMOUNT, _AMOUNT, value);
				this._AMOUNT = value;
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
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
		public string TB
		{
			get{ return _TB; }
			set
			{
				this.OnPropertyValueChange(_.TB, _TB, value);
				this._TB = value;
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
				_.AMOUNT,
				_.PLATFORM_CODE,
				_.TYPE,
				_.M,
				_.TB,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._AMOUNT,
				this._PLATFORM_CODE,
				this._TYPE,
				this._M,
				this._TB,
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
			public readonly static Field All = new Field("*", "MV_NOTICE_COUNT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "MV_NOTICE_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MV_NOTICE_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "MV_NOTICE_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M = new Field("M", "MV_NOTICE_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TB = new Field("TB", "MV_NOTICE_COUNT", "");
        }
        #endregion
	}
}