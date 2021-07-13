using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MSSM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MSSM")]
    [Serializable]
    public partial class T_MSSM : FwEntity
    {
        #region Model
		private string _OWNER;
		private string _OBJECT_NAME;
		private string _SUBOBJECT_NAME;
		private decimal? _OBJECT_ID;
		private decimal? _DATA_OBJECT_ID;
		private string _OBJECT_TYPE;
		private DateTime? _CREATED;
		private DateTime? _LAST_DDL_TIME;
		private string _TIMESTAMP;
		private string _STATUS;
		private string _TEMPORARY;
		private string _GENERATED;
		private string _SECONDARY;
		private decimal? _NAMESPACE;
		private string _EDITION_NAME;

		/// <summary>
		/// 
		/// </summary>
		public string OWNER
		{
			get{ return _OWNER; }
			set
			{
				this.OnPropertyValueChange(_.OWNER, _OWNER, value);
				this._OWNER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OBJECT_NAME
		{
			get{ return _OBJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OBJECT_NAME, _OBJECT_NAME, value);
				this._OBJECT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUBOBJECT_NAME
		{
			get{ return _SUBOBJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUBOBJECT_NAME, _SUBOBJECT_NAME, value);
				this._SUBOBJECT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OBJECT_ID
		{
			get{ return _OBJECT_ID; }
			set
			{
				this.OnPropertyValueChange(_.OBJECT_ID, _OBJECT_ID, value);
				this._OBJECT_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DATA_OBJECT_ID
		{
			get{ return _DATA_OBJECT_ID; }
			set
			{
				this.OnPropertyValueChange(_.DATA_OBJECT_ID, _DATA_OBJECT_ID, value);
				this._DATA_OBJECT_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OBJECT_TYPE
		{
			get{ return _OBJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.OBJECT_TYPE, _OBJECT_TYPE, value);
				this._OBJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATED
		{
			get{ return _CREATED; }
			set
			{
				this.OnPropertyValueChange(_.CREATED, _CREATED, value);
				this._CREATED = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_DDL_TIME
		{
			get{ return _LAST_DDL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LAST_DDL_TIME, _LAST_DDL_TIME, value);
				this._LAST_DDL_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIMESTAMP
		{
			get{ return _TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.TIMESTAMP, _TIMESTAMP, value);
				this._TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
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
		public string TEMPORARY
		{
			get{ return _TEMPORARY; }
			set
			{
				this.OnPropertyValueChange(_.TEMPORARY, _TEMPORARY, value);
				this._TEMPORARY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GENERATED
		{
			get{ return _GENERATED; }
			set
			{
				this.OnPropertyValueChange(_.GENERATED, _GENERATED, value);
				this._GENERATED = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SECONDARY
		{
			get{ return _SECONDARY; }
			set
			{
				this.OnPropertyValueChange(_.SECONDARY, _SECONDARY, value);
				this._SECONDARY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NAMESPACE
		{
			get{ return _NAMESPACE; }
			set
			{
				this.OnPropertyValueChange(_.NAMESPACE, _NAMESPACE, value);
				this._NAMESPACE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDITION_NAME
		{
			get{ return _EDITION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EDITION_NAME, _EDITION_NAME, value);
				this._EDITION_NAME = value;
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
				_.OWNER,
				_.OBJECT_NAME,
				_.SUBOBJECT_NAME,
				_.OBJECT_ID,
				_.DATA_OBJECT_ID,
				_.OBJECT_TYPE,
				_.CREATED,
				_.LAST_DDL_TIME,
				_.TIMESTAMP,
				_.STATUS,
				_.TEMPORARY,
				_.GENERATED,
				_.SECONDARY,
				_.NAMESPACE,
				_.EDITION_NAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._OWNER,
				this._OBJECT_NAME,
				this._SUBOBJECT_NAME,
				this._OBJECT_ID,
				this._DATA_OBJECT_ID,
				this._OBJECT_TYPE,
				this._CREATED,
				this._LAST_DDL_TIME,
				this._TIMESTAMP,
				this._STATUS,
				this._TEMPORARY,
				this._GENERATED,
				this._SECONDARY,
				this._NAMESPACE,
				this._EDITION_NAME,
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
			public readonly static Field All = new Field("*", "T_MSSM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OWNER = new Field("OWNER", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OBJECT_NAME = new Field("OBJECT_NAME", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUBOBJECT_NAME = new Field("SUBOBJECT_NAME", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OBJECT_ID = new Field("OBJECT_ID", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_OBJECT_ID = new Field("DATA_OBJECT_ID", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OBJECT_TYPE = new Field("OBJECT_TYPE", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATED = new Field("CREATED", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LAST_DDL_TIME = new Field("LAST_DDL_TIME", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TIMESTAMP = new Field("TIMESTAMP", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TEMPORARY = new Field("TEMPORARY", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GENERATED = new Field("GENERATED", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SECONDARY = new Field("SECONDARY", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAMESPACE = new Field("NAMESPACE", "T_MSSM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDITION_NAME = new Field("EDITION_NAME", "T_MSSM", "");
        }
        #endregion
	}
}