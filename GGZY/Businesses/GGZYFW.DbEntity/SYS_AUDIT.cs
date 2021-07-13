using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_AUDIT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_AUDIT")]
    [Serializable]
    public partial class SYS_AUDIT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TCID;
		private string _OPERATE_TYPE;
		private decimal? _IS_SUCCESS;
		private decimal? _CREATE_USERID;
		private DateTime? _CREATE_TIME;
		private string _LCONTENT;

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
		public decimal? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID, _TCID, value);
				this._TCID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPERATE_TYPE
		{
			get{ return _OPERATE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_TYPE, _OPERATE_TYPE, value);
				this._OPERATE_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_SUCCESS
		{
			get{ return _IS_SUCCESS; }
			set
			{
				this.OnPropertyValueChange(_.IS_SUCCESS, _IS_SUCCESS, value);
				this._IS_SUCCESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATE_USERID
		{
			get{ return _CREATE_USERID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_USERID, _CREATE_USERID, value);
				this._CREATE_USERID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LCONTENT
		{
			get{ return _LCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.LCONTENT, _LCONTENT, value);
				this._LCONTENT = value;
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
				_.TCID,
				_.OPERATE_TYPE,
				_.IS_SUCCESS,
				_.CREATE_USERID,
				_.CREATE_TIME,
				_.LCONTENT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TCID,
				this._OPERATE_TYPE,
				this._IS_SUCCESS,
				this._CREATE_USERID,
				this._CREATE_TIME,
				this._LCONTENT,
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
			public readonly static Field All = new Field("*", "SYS_AUDIT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPERATE_TYPE = new Field("OPERATE_TYPE", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_SUCCESS = new Field("IS_SUCCESS", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_USERID = new Field("CREATE_USERID", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "SYS_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LCONTENT = new Field("LCONTENT", "SYS_AUDIT", "");
        }
        #endregion
	}
}