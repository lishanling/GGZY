using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_DEPCONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_DEPCONFIG")]
    [Serializable]
    public partial class PT_ZXTS_DEPCONFIG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _DEP_ID;
		private decimal? _USER_ID;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;

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
		/// 部门ID
		/// </summary>
		public decimal? DEP_ID
		{
			get{ return _DEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.DEP_ID, _DEP_ID, value);
				this._DEP_ID = value;
			}
		}
		/// <summary>
		/// 签收人员
		/// </summary>
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 创建人时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
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
				_.DEP_ID,
				_.USER_ID,
				_.CREATE_BY,
				_.CREATE_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DEP_ID,
				this._USER_ID,
				this._CREATE_BY,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_DEPCONFIG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_DEPCONFIG", "ID");
            /// <summary>
			/// 部门ID
			/// </summary>
			public readonly static Field DEP_ID = new Field("DEP_ID", "PT_ZXTS_DEPCONFIG", "部门ID");
            /// <summary>
			/// 签收人员
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "PT_ZXTS_DEPCONFIG", "签收人员");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "PT_ZXTS_DEPCONFIG", "创建人");
            /// <summary>
			/// 创建人时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_ZXTS_DEPCONFIG", "创建人时间");
        }
        #endregion
	}
}