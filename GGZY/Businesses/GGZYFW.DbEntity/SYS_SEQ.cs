using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_SEQ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_SEQ")]
    [Serializable]
    public partial class SYS_SEQ : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TB_NAME;
		private DateTime? _CUR_DATE;
		private decimal? _CUR_SEQ;
		private DateTime? _UPDATE_TIME;
		private string _REMARK;

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
		public string TB_NAME
		{
			get{ return _TB_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
				this._TB_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CUR_DATE
		{
			get{ return _CUR_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CUR_DATE, _CUR_DATE, value);
				this._CUR_DATE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CUR_SEQ
		{
			get{ return _CUR_SEQ; }
			set
			{
				this.OnPropertyValueChange(_.CUR_SEQ, _CUR_SEQ, value);
				this._CUR_SEQ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			get{ return _UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
				this._UPDATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.TB_NAME,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.TB_NAME,
				_.CUR_DATE,
				_.CUR_SEQ,
				_.UPDATE_TIME,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TB_NAME,
				this._CUR_DATE,
				this._CUR_SEQ,
				this._UPDATE_TIME,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "SYS_SEQ");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_SEQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "SYS_SEQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CUR_DATE = new Field("CUR_DATE", "SYS_SEQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CUR_SEQ = new Field("CUR_SEQ", "SYS_SEQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "SYS_SEQ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_SEQ", "");
        }
        #endregion
	}
}