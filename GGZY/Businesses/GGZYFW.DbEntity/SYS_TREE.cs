using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_TREE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_TREE")]
    [Serializable]
    public partial class SYS_TREE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _PID;
		private decimal? _FLAG;
		private string _NODETEXT;
		private string _NODEVALUE;
		private string _NODEVALUE2;
		private decimal? _ORDERID;
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
		public decimal? FLAG
		{
			get{ return _FLAG; }
			set
			{
				this.OnPropertyValueChange(_.FLAG, _FLAG, value);
				this._FLAG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NODETEXT
		{
			get{ return _NODETEXT; }
			set
			{
				this.OnPropertyValueChange(_.NODETEXT, _NODETEXT, value);
				this._NODETEXT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NODEVALUE
		{
			get{ return _NODEVALUE; }
			set
			{
				this.OnPropertyValueChange(_.NODEVALUE, _NODEVALUE, value);
				this._NODEVALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NODEVALUE2
		{
			get{ return _NODEVALUE2; }
			set
			{
				this.OnPropertyValueChange(_.NODEVALUE2, _NODEVALUE2, value);
				this._NODEVALUE2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
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
				_.PID,
				_.FLAG,
				_.NODETEXT,
				_.NODEVALUE,
				_.NODEVALUE2,
				_.ORDERID,
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
				this._PID,
				this._FLAG,
				this._NODETEXT,
				this._NODEVALUE,
				this._NODEVALUE2,
				this._ORDERID,
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
			public readonly static Field All = new Field("*", "SYS_TREE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PID = new Field("PID", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FLAG = new Field("FLAG", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NODETEXT = new Field("NODETEXT", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NODEVALUE = new Field("NODEVALUE", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NODEVALUE2 = new Field("NODEVALUE2", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_TREE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_TREE", "");
        }
        #endregion
	}
}