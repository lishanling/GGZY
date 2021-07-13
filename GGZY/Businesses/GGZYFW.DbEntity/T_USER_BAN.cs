using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER_BAN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_BAN")]
    [Serializable]
    public partial class T_USER_BAN : FwEntity
    {
        #region Model
		private decimal? _USER_ID;
		private string _GG_M_ID;
		private string _PROJECT_CODE;
		private DateTime? _TM;
		private decimal? _IS_LIMIT;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string GG_M_ID
		{
			get{ return _GG_M_ID; }
			set
			{
				this.OnPropertyValueChange(_.GG_M_ID, _GG_M_ID, value);
				this._GG_M_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		public decimal? IS_LIMIT
		{
			get{ return _IS_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.IS_LIMIT, _IS_LIMIT, value);
				this._IS_LIMIT = value;
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
				_.USER_ID,
				_.GG_M_ID,
				_.PROJECT_CODE,
				_.TM,
				_.IS_LIMIT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._USER_ID,
				this._GG_M_ID,
				this._PROJECT_CODE,
				this._TM,
				this._IS_LIMIT,
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
			public readonly static Field All = new Field("*", "T_USER_BAN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_USER_BAN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GG_M_ID = new Field("GG_M_ID", "T_USER_BAN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_USER_BAN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_USER_BAN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_LIMIT = new Field("IS_LIMIT", "T_USER_BAN", "");
        }
        #endregion
	}
}