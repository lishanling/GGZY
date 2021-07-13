using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_MSG_STATE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MSG_STATE")]
    [Serializable]
    public partial class T_MSG_STATE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private decimal? _ISREAD;
		private DateTime? _READ_TM;
		private decimal? _ISDEL;
		private DateTime? _DEL_TM;
		private decimal? _MID;

		/// <summary>
		/// ID
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
		/// 接收用户ID
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
		/// 是否已读:1是 0否
		/// </summary>
		public decimal? ISREAD
		{
			get{ return _ISREAD; }
			set
			{
				this.OnPropertyValueChange(_.ISREAD, _ISREAD, value);
				this._ISREAD = value;
			}
		}
		/// <summary>
		/// 读取时间
		/// </summary>
		public DateTime? READ_TM
		{
			get{ return _READ_TM; }
			set
			{
				this.OnPropertyValueChange(_.READ_TM, _READ_TM, value);
				this._READ_TM = value;
			}
		}
		/// <summary>
		/// 是否已删除:1是 0否
		/// </summary>
		public decimal? ISDEL
		{
			get{ return _ISDEL; }
			set
			{
				this.OnPropertyValueChange(_.ISDEL, _ISDEL, value);
				this._ISDEL = value;
			}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? DEL_TM
		{
			get{ return _DEL_TM; }
			set
			{
				this.OnPropertyValueChange(_.DEL_TM, _DEL_TM, value);
				this._DEL_TM = value;
			}
		}
		/// <summary>
		/// 消息ID
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
				_.ISREAD,
				_.READ_TM,
				_.ISDEL,
				_.DEL_TM,
				_.MID,
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
				this._ISREAD,
				this._READ_TM,
				this._ISDEL,
				this._DEL_TM,
				this._MID,
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
			public readonly static Field All = new Field("*", "T_MSG_STATE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MSG_STATE", "ID");
            /// <summary>
			/// 接收用户ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_MSG_STATE", "接收用户ID");
            /// <summary>
			/// 是否已读:1是 0否
			/// </summary>
			public readonly static Field ISREAD = new Field("ISREAD", "T_MSG_STATE", "是否已读:1是 0否");
            /// <summary>
			/// 读取时间
			/// </summary>
			public readonly static Field READ_TM = new Field("READ_TM", "T_MSG_STATE", "读取时间");
            /// <summary>
			/// 是否已删除:1是 0否
			/// </summary>
			public readonly static Field ISDEL = new Field("ISDEL", "T_MSG_STATE", "是否已删除:1是 0否");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DEL_TM = new Field("DEL_TM", "T_MSG_STATE", "删除时间");
            /// <summary>
			/// 消息ID
			/// </summary>
			public readonly static Field MID = new Field("MID", "T_MSG_STATE", "消息ID");
        }
        #endregion
	}
}