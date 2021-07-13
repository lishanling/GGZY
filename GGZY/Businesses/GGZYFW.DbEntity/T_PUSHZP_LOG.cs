using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_PUSHZP_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PUSHZP_LOG")]
    [Serializable]
    public partial class T_PUSHZP_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _M_ZPID;
		private string _RETURN_MSG;
		private decimal? _OPER_BY;
		private DateTime? _OPER_TM;
		private string _IP;
		private decimal? _ANN_ID;
		private string _TYPE;
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
		public decimal? M_ZPID
		{
			get{ return _M_ZPID; }
			set
			{
				this.OnPropertyValueChange(_.M_ZPID, _M_ZPID, value);
				this._M_ZPID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RETURN_MSG
		{
			get{ return _RETURN_MSG; }
			set
			{
				this.OnPropertyValueChange(_.RETURN_MSG, _RETURN_MSG, value);
				this._RETURN_MSG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OPER_BY
		{
			get{ return _OPER_BY; }
			set
			{
				this.OnPropertyValueChange(_.OPER_BY, _OPER_BY, value);
				this._OPER_BY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ANN_ID
		{
			get{ return _ANN_ID; }
			set
			{
				this.OnPropertyValueChange(_.ANN_ID, _ANN_ID, value);
				this._ANN_ID = value;
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
				_.M_ZPID,
				_.RETURN_MSG,
				_.OPER_BY,
				_.OPER_TM,
				_.IP,
				_.ANN_ID,
				_.TYPE,
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
				this._M_ZPID,
				this._RETURN_MSG,
				this._OPER_BY,
				this._OPER_TM,
				this._IP,
				this._ANN_ID,
				this._TYPE,
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
			public readonly static Field All = new Field("*", "T_PUSHZP_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ZPID = new Field("M_ZPID", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RETURN_MSG = new Field("RETURN_MSG", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_BY = new Field("OPER_BY", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_TM = new Field("OPER_TM", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IP = new Field("IP", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ANN_ID = new Field("ANN_ID", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_PUSHZP_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_PUSHZP_LOG", "");
        }
        #endregion
	}
}