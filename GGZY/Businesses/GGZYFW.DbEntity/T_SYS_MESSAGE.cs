using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SYS_MESSAGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SYS_MESSAGE")]
    [Serializable]
    public partial class T_SYS_MESSAGE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _SID;
		private decimal? _TID;
		private DateTime? _TM;

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
		public decimal? SID
		{
			get{ return _SID; }
			set
			{
				this.OnPropertyValueChange(_.SID, _SID, value);
				this._SID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TID
		{
			get{ return _TID; }
			set
			{
				this.OnPropertyValueChange(_.TID, _TID, value);
				this._TID = value;
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
				_.SID,
				_.TID,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SID,
				this._TID,
				this._TM,
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
			public readonly static Field All = new Field("*", "T_SYS_MESSAGE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SYS_MESSAGE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SID = new Field("SID", "T_SYS_MESSAGE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TID = new Field("TID", "T_SYS_MESSAGE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_SYS_MESSAGE", "");
        }
        #endregion
	}
}