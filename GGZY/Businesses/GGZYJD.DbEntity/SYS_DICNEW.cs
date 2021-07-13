using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_DICNEW。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_DICNEW")]
    [Serializable]
    public partial class SYS_DICNEW : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TYPE;
		private string _TEXT;
		private string _VALUE;
		private decimal? _ORDER_ID;
		private string _VALUE1;
		private string _VALUE2;
		private string _VALUE3;
		private string _VALUE4;
		private string _VALUE5;
		private decimal? _PID;
		private string _REMARK;
		private decimal? _IS_DEL;
		private decimal? _IS_ENABLE;
		private string _OP_BY;
		private DateTime? _OP_TIME;
		private string _PLATFORM;

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
		public string TEXT
		{
			get{ return _TEXT; }
			set
			{
				this.OnPropertyValueChange(_.TEXT, _TEXT, value);
				this._TEXT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE
		{
			get{ return _VALUE; }
			set
			{
				this.OnPropertyValueChange(_.VALUE, _VALUE, value);
				this._VALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDER_ID
		{
			get{ return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE1
		{
			get{ return _VALUE1; }
			set
			{
				this.OnPropertyValueChange(_.VALUE1, _VALUE1, value);
				this._VALUE1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE2
		{
			get{ return _VALUE2; }
			set
			{
				this.OnPropertyValueChange(_.VALUE2, _VALUE2, value);
				this._VALUE2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE3
		{
			get{ return _VALUE3; }
			set
			{
				this.OnPropertyValueChange(_.VALUE3, _VALUE3, value);
				this._VALUE3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE4
		{
			get{ return _VALUE4; }
			set
			{
				this.OnPropertyValueChange(_.VALUE4, _VALUE4, value);
				this._VALUE4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE5
		{
			get{ return _VALUE5; }
			set
			{
				this.OnPropertyValueChange(_.VALUE5, _VALUE5, value);
				this._VALUE5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PID
		{
			get{ return _PID; }
			set
			{
				this.OnPropertyValueChange(_.PID, _PID, value);
				this._PID = value;
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OP_BY
		{
			get{ return _OP_BY; }
			set
			{
				this.OnPropertyValueChange(_.OP_BY, _OP_BY, value);
				this._OP_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OP_TIME
		{
			get{ return _OP_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OP_TIME, _OP_TIME, value);
				this._OP_TIME = value;
			}
		}
		/// <summary>
		/// 属于哪个平台的外键
		/// </summary>
		public string PLATFORM
		{
			get{ return _PLATFORM; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM, _PLATFORM, value);
				this._PLATFORM = value;
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
				_.ID,
				_.TYPE,
				_.TEXT,
				_.VALUE,
				_.ORDER_ID,
				_.VALUE1,
				_.VALUE2,
				_.VALUE3,
				_.VALUE4,
				_.VALUE5,
				_.PID,
				_.REMARK,
				_.IS_DEL,
				_.IS_ENABLE,
				_.OP_BY,
				_.OP_TIME,
				_.PLATFORM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TYPE,
				this._TEXT,
				this._VALUE,
				this._ORDER_ID,
				this._VALUE1,
				this._VALUE2,
				this._VALUE3,
				this._VALUE4,
				this._VALUE5,
				this._PID,
				this._REMARK,
				this._IS_DEL,
				this._IS_ENABLE,
				this._OP_BY,
				this._OP_TIME,
				this._PLATFORM,
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
			public readonly static Field All = new Field("*", "SYS_DICNEW");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TEXT = new Field("TEXT", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE = new Field("VALUE", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE1 = new Field("VALUE1", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE2 = new Field("VALUE2", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE3 = new Field("VALUE3", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE4 = new Field("VALUE4", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALUE5 = new Field("VALUE5", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PID = new Field("PID", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_DEL = new Field("IS_DEL", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OP_BY = new Field("OP_BY", "SYS_DICNEW", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OP_TIME = new Field("OP_TIME", "SYS_DICNEW", "");
            /// <summary>
			/// 属于哪个平台的外键
			/// </summary>
			public readonly static Field PLATFORM = new Field("PLATFORM", "SYS_DICNEW", "属于哪个平台的外键");
        }
        #endregion
	}
}