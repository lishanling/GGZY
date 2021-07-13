using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_WANZHENGLV_TDKYQT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_WANZHENGLV_TDKYQT")]
    [Serializable]
    public partial class MV_WANZHENGLV_TDKYQT : FwEntity
    {
        #region Model
		private string _TYPE;
		private string _ID;
		private string _M_DATA_SOURCE;
		private string _M_KEY;
		private DateTime? _PUBLISHING_TIME;
		private decimal? _结果公告;

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
		public string ID
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PUBLISHING_TIME
		{
			get{ return _PUBLISHING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHING_TIME, _PUBLISHING_TIME, value);
				this._PUBLISHING_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 结果公告
		{
			get{ return _结果公告; }
			set
			{
				this.OnPropertyValueChange(_.结果公告, _结果公告, value);
				this._结果公告 = value;
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
				_.TYPE,
				_.ID,
				_.M_DATA_SOURCE,
				_.M_KEY,
				_.PUBLISHING_TIME,
				_.结果公告,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TYPE,
				this._ID,
				this._M_DATA_SOURCE,
				this._M_KEY,
				this._PUBLISHING_TIME,
				this._结果公告,
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
			public readonly static Field All = new Field("*", "MV_WANZHENGLV_TDKYQT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "MV_WANZHENGLV_TDKYQT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "MV_WANZHENGLV_TDKYQT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MV_WANZHENGLV_TDKYQT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MV_WANZHENGLV_TDKYQT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "MV_WANZHENGLV_TDKYQT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field 结果公告 = new Field("结果公告", "MV_WANZHENGLV_TDKYQT", "");
        }
        #endregion
	}
}