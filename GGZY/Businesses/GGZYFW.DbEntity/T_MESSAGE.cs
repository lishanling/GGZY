using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MESSAGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MESSAGE")]
    [Serializable]
    public partial class T_MESSAGE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _SID;
		private decimal? _RID;
		private decimal? _MID;
		private decimal? _TID;
		private DateTime? _TM;
		private decimal? _STATUS;
		private decimal? _IS_DEL;

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
		/// 发件人
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
		/// 收件人
		/// </summary>
		public decimal? RID
		{
			get{ return _RID; }
			set
			{
				this.OnPropertyValueChange(_.RID, _RID, value);
				this._RID = value;
			}
		}
		/// <summary>
		/// 群发表关联ID
		/// </summary>
		public decimal? MID
		{
			get{ return _MID; }
			set
			{
				this.OnPropertyValueChange(_.MID, _MID, value);
				this._MID = value;
			}
		}
		/// <summary>
		/// 消息内容表对应ID
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
		/// <summary>
		/// 状态 0：未读 1：已读。
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_DEL
		{
			get{ return _IS_DEL; }
			set
			{
				this.OnPropertyValueChange(_.IS_DEL, _IS_DEL, value);
				this._IS_DEL = value;
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
				_.RID,
				_.MID,
				_.TID,
				_.TM,
				_.STATUS,
				_.IS_DEL,
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
				this._RID,
				this._MID,
				this._TID,
				this._TM,
				this._STATUS,
				this._IS_DEL,
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
			public readonly static Field All = new Field("*", "T_MESSAGE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MESSAGE", "");
            /// <summary>
			/// 发件人
			/// </summary>
			public readonly static Field SID = new Field("SID", "T_MESSAGE", "发件人");
            /// <summary>
			/// 收件人
			/// </summary>
			public readonly static Field RID = new Field("RID", "T_MESSAGE", "收件人");
            /// <summary>
			/// 群发表关联ID
			/// </summary>
			public readonly static Field MID = new Field("MID", "T_MESSAGE", "群发表关联ID");
            /// <summary>
			/// 消息内容表对应ID
			/// </summary>
			public readonly static Field TID = new Field("TID", "T_MESSAGE", "消息内容表对应ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_MESSAGE", "");
            /// <summary>
			/// 状态 0：未读 1：已读。
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_MESSAGE", "状态 0：未读 1：已读。");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_DEL = new Field("IS_DEL", "T_MESSAGE", "");
        }
        #endregion
	}
}