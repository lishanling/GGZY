using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类GETDATALOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GETDATALOG")]
    [Serializable]
    public partial class GETDATALOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CONSTRUCT_ID;
		private string _M_DATA_SOURCE;
		private DateTime? _GETTIME;
		private string _TYPE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATETIME;

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
		/// 报建、备案编号、附件的guid、获取时间区间
		/// </summary>
		public string CONSTRUCT_ID
		{
			get{ return _CONSTRUCT_ID; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_ID, _CONSTRUCT_ID, value);
				this._CONSTRUCT_ID = value;
			}
		}
		/// <summary>
		/// 获取数据的用户
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 获取数据的时间
		/// </summary>
		public DateTime? GETTIME
		{
			get{ return _GETTIME; }
			set
			{
				this.OnPropertyValueChange(_.GETTIME, _GETTIME, value);
				this._GETTIME = value;
			}
		}
		/// <summary>
		/// _1表示报建、2表示备案、3表示 附件获取、4表示报建（根据时间获取）、5表示备案（根据时间获取）
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
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_CREATETIME
		{
			get{ return _M_CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATETIME, _M_CREATETIME, value);
				this._M_CREATETIME = value;
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
				_.CONSTRUCT_ID,
				_.M_DATA_SOURCE,
				_.GETTIME,
				_.TYPE,
				_.M_CREATEBY,
				_.M_CREATETIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CONSTRUCT_ID,
				this._M_DATA_SOURCE,
				this._GETTIME,
				this._TYPE,
				this._M_CREATEBY,
				this._M_CREATETIME,
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
			public readonly static Field All = new Field("*", "GETDATALOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "GETDATALOG", "");
            /// <summary>
			/// 报建、备案编号、附件的guid、获取时间区间
			/// </summary>
			public readonly static Field CONSTRUCT_ID = new Field("CONSTRUCT_ID", "GETDATALOG", "报建、备案编号、附件的guid、获取时间区间");
            /// <summary>
			/// 获取数据的用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "GETDATALOG", "获取数据的用户");
            /// <summary>
			/// 获取数据的时间
			/// </summary>
			public readonly static Field GETTIME = new Field("GETTIME", "GETDATALOG", "获取数据的时间");
            /// <summary>
			/// _1表示报建、2表示备案、3表示 附件获取、4表示报建（根据时间获取）、5表示备案（根据时间获取）
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "GETDATALOG", "_1表示报建、2表示备案、3表示 附件获取、4表示报建（根据时间获取）、5表示备案（根据时间获取）");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "GETDATALOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATETIME = new Field("M_CREATETIME", "GETDATALOG", "");
        }
        #endregion
	}
}