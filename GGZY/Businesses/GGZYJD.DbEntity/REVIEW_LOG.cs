using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_LOG")]
    [Serializable]
    public partial class REVIEW_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _SL_ID;
		private decimal? _NODE_ID;
		private decimal? _BTN_ID;
		private string _OPERNAME;
		private decimal? _USER_ID;
		private DateTime? _OPER_TM;
		private string _C1;
		private string _C2;
		private string _C3;
		private string _C4;
		private string _C5;
		private string _DATA_DIC;

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
		/// 审查实例ID
		/// </summary>
		public decimal? SL_ID
		{
			get{ return _SL_ID; }
			set
			{
				this.OnPropertyValueChange(_.SL_ID, _SL_ID, value);
				this._SL_ID = value;
			}
		}
		/// <summary>
		/// 节点ID
		/// </summary>
		public decimal? NODE_ID
		{
			get{ return _NODE_ID; }
			set
			{
				this.OnPropertyValueChange(_.NODE_ID, _NODE_ID, value);
				this._NODE_ID = value;
			}
		}
		/// <summary>
		/// BTN_ID
		/// </summary>
		public decimal? BTN_ID
		{
			get{ return _BTN_ID; }
			set
			{
				this.OnPropertyValueChange(_.BTN_ID, _BTN_ID, value);
				this._BTN_ID = value;
			}
		}
		/// <summary>
		/// 操作名称
		/// </summary>
		public string OPERNAME
		{
			get{ return _OPERNAME; }
			set
			{
				this.OnPropertyValueChange(_.OPERNAME, _OPERNAME, value);
				this._OPERNAME = value;
			}
		}
		/// <summary>
		/// 操作人
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
		/// 操作时间
		/// </summary>
		public DateTime? OPER_TM
		{
			get{ return _OPER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OPER_TM, _OPER_TM, value);
				this._OPER_TM = value;
			}
		}
		/// <summary>
		/// 数据列1
		/// </summary>
		public string C1
		{
			get{ return _C1; }
			set
			{
				this.OnPropertyValueChange(_.C1, _C1, value);
				this._C1 = value;
			}
		}
		/// <summary>
		/// 数据列2
		/// </summary>
		public string C2
		{
			get{ return _C2; }
			set
			{
				this.OnPropertyValueChange(_.C2, _C2, value);
				this._C2 = value;
			}
		}
		/// <summary>
		/// 数据列3
		/// </summary>
		public string C3
		{
			get{ return _C3; }
			set
			{
				this.OnPropertyValueChange(_.C3, _C3, value);
				this._C3 = value;
			}
		}
		/// <summary>
		/// 数据列4
		/// </summary>
		public string C4
		{
			get{ return _C4; }
			set
			{
				this.OnPropertyValueChange(_.C4, _C4, value);
				this._C4 = value;
			}
		}
		/// <summary>
		/// 数据列5
		/// </summary>
		public string C5
		{
			get{ return _C5; }
			set
			{
				this.OnPropertyValueChange(_.C5, _C5, value);
				this._C5 = value;
			}
		}
		/// <summary>
		/// 数据列字典
		/// </summary>
		public string DATA_DIC
		{
			get{ return _DATA_DIC; }
			set
			{
				this.OnPropertyValueChange(_.DATA_DIC, _DATA_DIC, value);
				this._DATA_DIC = value;
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
				_.SL_ID,
				_.NODE_ID,
				_.BTN_ID,
				_.OPERNAME,
				_.USER_ID,
				_.OPER_TM,
				_.C1,
				_.C2,
				_.C3,
				_.C4,
				_.C5,
				_.DATA_DIC,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SL_ID,
				this._NODE_ID,
				this._BTN_ID,
				this._OPERNAME,
				this._USER_ID,
				this._OPER_TM,
				this._C1,
				this._C2,
				this._C3,
				this._C4,
				this._C5,
				this._DATA_DIC,
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
			public readonly static Field All = new Field("*", "REVIEW_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_LOG", "ID");
            /// <summary>
			/// 审查实例ID
			/// </summary>
			public readonly static Field SL_ID = new Field("SL_ID", "REVIEW_LOG", "审查实例ID");
            /// <summary>
			/// 节点ID
			/// </summary>
			public readonly static Field NODE_ID = new Field("NODE_ID", "REVIEW_LOG", "节点ID");
            /// <summary>
			/// BTN_ID
			/// </summary>
			public readonly static Field BTN_ID = new Field("BTN_ID", "REVIEW_LOG", "BTN_ID");
            /// <summary>
			/// 操作名称
			/// </summary>
			public readonly static Field OPERNAME = new Field("OPERNAME", "REVIEW_LOG", "操作名称");
            /// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "REVIEW_LOG", "操作人");
            /// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field OPER_TM = new Field("OPER_TM", "REVIEW_LOG", "操作时间");
            /// <summary>
			/// 数据列1
			/// </summary>
			public readonly static Field C1 = new Field("C1", "REVIEW_LOG", "数据列1");
            /// <summary>
			/// 数据列2
			/// </summary>
			public readonly static Field C2 = new Field("C2", "REVIEW_LOG", "数据列2");
            /// <summary>
			/// 数据列3
			/// </summary>
			public readonly static Field C3 = new Field("C3", "REVIEW_LOG", "数据列3");
            /// <summary>
			/// 数据列4
			/// </summary>
			public readonly static Field C4 = new Field("C4", "REVIEW_LOG", "数据列4");
            /// <summary>
			/// 数据列5
			/// </summary>
			public readonly static Field C5 = new Field("C5", "REVIEW_LOG", "数据列5");
            /// <summary>
			/// 数据列字典
			/// </summary>
			public readonly static Field DATA_DIC = new Field("DATA_DIC", "REVIEW_LOG", "数据列字典");
        }
        #endregion
	}
}