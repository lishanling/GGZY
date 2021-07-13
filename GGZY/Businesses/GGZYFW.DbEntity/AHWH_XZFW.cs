using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AHWH_XZFW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AHWH_XZFW")]
    [Serializable]
    public partial class AHWH_XZFW : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _TITLE;
		private DateTime? _TM;
		private decimal? _AID;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AID
		{
			get{ return _AID; }
			set
			{
				this.OnPropertyValueChange(_.AID, _AID, value);
				this._AID = value;
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
				_.U_ID,
				_.TITLE,
				_.TM,
				_.AID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._TITLE,
				this._TM,
				this._AID,
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
			public readonly static Field All = new Field("*", "AHWH_XZFW");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "AHWH_XZFW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "AHWH_XZFW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "AHWH_XZFW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "AHWH_XZFW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AID = new Field("AID", "AHWH_XZFW", "");
        }
        #endregion
	}
}