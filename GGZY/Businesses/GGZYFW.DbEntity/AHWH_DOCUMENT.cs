using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AHWH_DOCUMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AHWH_DOCUMENT")]
    [Serializable]
    public partial class AHWH_DOCUMENT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _TITLE;
		private string _TYPE;
		private DateTime? _TIME;
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
		public DateTime? TIME
		{
			get{ return _TIME; }
			set
			{
				this.OnPropertyValueChange(_.TIME, _TIME, value);
				this._TIME = value;
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
				_.TYPE,
				_.TIME,
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
				this._TYPE,
				this._TIME,
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
			public readonly static Field All = new Field("*", "AHWH_DOCUMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "AHWH_DOCUMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "AHWH_DOCUMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "AHWH_DOCUMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "AHWH_DOCUMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TIME = new Field("TIME", "AHWH_DOCUMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AID = new Field("AID", "AHWH_DOCUMENT", "");
        }
        #endregion
	}
}