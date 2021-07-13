using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_AUDIT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AUDIT")]
    [Serializable]
    public partial class T_AUDIT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TCID;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TIME;
		private decimal? _OPER_TYPE;
		private decimal? _ADD_TYPE;
		private string _KEY1;
		private string _KEY2;
		private string _KEY5;
		private string _KEY4;
		private string _KEY3;

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
		public decimal? OPER_TYPE
		{
			get{ return _OPER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPER_TYPE, _OPER_TYPE, value);
				this._OPER_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ADD_TYPE
		{
			get{ return _ADD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ADD_TYPE, _ADD_TYPE, value);
				this._ADD_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KEY1
		{
			get{ return _KEY1; }
			set
			{
				this.OnPropertyValueChange(_.KEY1, _KEY1, value);
				this._KEY1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KEY2
		{
			get{ return _KEY2; }
			set
			{
				this.OnPropertyValueChange(_.KEY2, _KEY2, value);
				this._KEY2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KEY5
		{
			get{ return _KEY5; }
			set
			{
				this.OnPropertyValueChange(_.KEY5, _KEY5, value);
				this._KEY5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KEY4
		{
			get{ return _KEY4; }
			set
			{
				this.OnPropertyValueChange(_.KEY4, _KEY4, value);
				this._KEY4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KEY3
		{
			get{ return _KEY3; }
			set
			{
				this.OnPropertyValueChange(_.KEY3, _KEY3, value);
				this._KEY3 = value;
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
				_.CREATE_BY,
				_.CREATE_TIME,
				_.OPER_TYPE,
				_.ADD_TYPE,
				_.KEY1,
				_.KEY2,
				_.KEY5,
				_.KEY4,
				_.KEY3,
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
				this._CREATE_BY,
				this._CREATE_TIME,
				this._OPER_TYPE,
				this._ADD_TYPE,
				this._KEY1,
				this._KEY2,
				this._KEY5,
				this._KEY4,
				this._KEY3,
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
			public readonly static Field All = new Field("*", "T_AUDIT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_TYPE = new Field("OPER_TYPE", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADD_TYPE = new Field("ADD_TYPE", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KEY1 = new Field("KEY1", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KEY2 = new Field("KEY2", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KEY5 = new Field("KEY5", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KEY4 = new Field("KEY4", "T_AUDIT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KEY3 = new Field("KEY3", "T_AUDIT", "");
        }
        #endregion
	}
}